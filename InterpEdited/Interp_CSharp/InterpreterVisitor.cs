////////////////////////////////////////////////////////////////////////
// InterpreterVisitor.cs: Implements a vistor that interprets the 
// syntax tree.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
// pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using Interp_CSharp;

class ThrScAndInd
{
    private int index;
    private int scalar;
    private string matvar;
    public ThrScAndInd(int index, int scalar,string matvar)
    {
        this.index = index;
        this.scalar = scalar;
        this.matvar = matvar;
    }

    public int retIndex
    {
        get { return index; }
        set { index = value; }
    }

    public int retScal
    {
        get { return scalar;  }
        set { scalar = value; }

    }

    public string retMatVar
    {
        get { return matvar;  }
        set { matvar = value; }

    }    
}

class ThrInd
{
    private int index;
    public ThrInd(int index)
    {
        this.index = index;
    }
    public int Index
    {
        get { return index; }
        set { index = value; }

    }
}


public class InterpreterVisitor : Visitor 
{

  Hashtable mVariableMap;
  String    s,larr,rarr;
  Hashtable arrVariableMap;
  Stack<int> mStack;
  int indicate,resrows,rescolumns,collim;  
  int[,] left;
  int[,] right;
  int[,] res;
  int[] temp;
  String loop;
  int    startloopvar, endloopvar;
  String loopvar,matind;
  string scalar,loopmatvar;
  string resultMessage="",operation;
  string varormatvar,arrvalue="";

  public string results
  {
      get { return resultMessage;  }
      set { resultMessage = value; }
  }
  private Object token = new Object();
  private Object parallelforlock = new Object();

  public InterpreterVisitor()
  {
      mVariableMap = new Hashtable();
      mStack = new Stack<int>();
      arrVariableMap = new Hashtable();
      loopvar = "";
      matind = "";
      resultMessage += "constructing InterpreterVisitor object"+"\n";
  }
  


  public int mulRowCol(int row, int col)
  {
    int sum=0;
    for(int i=0; i < collim; i++)  
    {
       sum+=left[row,i]*right[i,col];
    }
    
    return sum;
  }

  public void threadMul(Object obj)
  {
    lock(token)
    {
        if (obj is ThrInd)
        {
            ThrInd thind = (ThrInd)obj;
            for (int i = 0; i <= rescolumns - 1; i++)
            {
               res[thind.Index, i] = mulRowCol(thind.Index,i);
            } 
        } 
     }
  }

  public void threadAdd(Object obj)
  {
      lock (token)
      {
          if (obj is ThrInd)
          {
              ThrInd thind = (ThrInd)obj;
              for(int i=0; i <= rescolumns - 1; i++)
              {
                  res[thind.Index,i] = left[thind.Index,i] + right[thind.Index,i];
              }
          }
      }
  }

    public override void VisitVariableElement(VariableElement element){
    resultMessage += "Visiting Variable Element"+"\n";
    if(mVariableMap.ContainsKey(element.getText())){
      int element_value = (int) mVariableMap[element.getText()];
      mStack.Push(element_value);
      } 
    else {
      //lets assume that the syntax has been checked for this example because I don't like the exception
      //propegation that will happen if I throw here
      //throw new Exception("Variable " + element.getText() + " not defined.");
     }
    varormatvar = "var";
    }
  
    public override void VisitIntegerElement(IntegerElement element)
    {
       resultMessage += "Visiting Integer Element"+"\n";
       int element_value = int.Parse(element.getText());
       mStack.Push(element_value);
    }

    public override void VisitAssignmentOperationElement(AssignmentOperationElement element)
    {
      
       String variable_name = element.getLhs().getText();
       Element rhs = element.getRhs();
       VisitElement(rhs);
       resultMessage += "performing assignment operation"+"\n"; 
       int result = mStack.Pop();    
       mVariableMap[variable_name] = result;
    }

    public override void VisitAdditionOperationElement(AdditionOperationElement element)
    {     
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      resultMessage += "performing addition operation on scalar"+"\n";
      int rhs = mStack.Pop();
      int lhs = mStack.Pop();
      int result = rhs + lhs;
      mStack.Push(result);    
    }

    public override void VisitMultiplicationOperationElement(MultiplicationOperationElement element)
    {
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
        resultMessage += "performing multiplication operation"+"\n";
        int rhs = mStack.Pop();
        int lhs = mStack.Pop();
        int result = rhs * lhs;
        mStack.Push(result);
    }

    public int ArrRow(String Text)
    {
        CharEnumerator ce = Text.GetEnumerator();
        ce.MoveNext();
        int index=0,rows=0;
        while (index != Text.Length)
        {
            if(ce.Current.CompareTo('[')==0)
                rows++;
              index++;
              ce.MoveNext();
        }
        return rows;
    }

    public int ArrColumn(String Text)
    {
        CharEnumerator ce = Text.GetEnumerator();
        ce.MoveNext();
        int index = 0, columns = 0;
        while (index != Text.Length)
        {
            if (ce.Current.CompareTo(']')==0)
                break;
            index++;
            if(ce.Current.CompareTo(',')==0)
            columns++;
            ce.MoveNext();
        }
        return columns+1;
    } 

    public override void VisitMatMultiplicationOperationElement(MatMultiplication element)
    {
        resultMessage += "performing matrix multiplication element"+"\n";
        int index=0,row=0,column= 0;        
        indicate = 2;
        VisitElement(element.getLhs());
        indicate = 1;
        VisitElement(element.getRhs());
        indicate = -1;
        String value="0";
        operation = "*"; 
        CharEnumerator la = larr.GetEnumerator();
        CharEnumerator ra = rarr.GetEnumerator();

        la.MoveNext();
        ra.MoveNext();

        s = null;
         

         left  = new int[ArrRow(larr),ArrColumn(larr)];
         right = new int[ArrRow(rarr),ArrColumn(rarr)];

         resrows = ArrRow(larr);
         rescolumns = ArrColumn(rarr);
         collim = ArrColumn(larr);

        while (index != larr.Length)
        {
            
            if (la.Current.CompareTo(']')==0)
            {
                 left[row, column] = int.Parse(value);
                 row += 1;
                 column = 0;
                 value = "0";
            }        

           
            if (la.Current.CompareTo(',') != 0 && la.Current.CompareTo('[') != 0 && la.Current.CompareTo(']') != 0)
            {
                //String.Concat(value,value,la.Current.ToString());                  
                value = value + la.Current.ToString();
            }

            if (la.Current.CompareTo(',') == 0 && la.Current.CompareTo('[') != 0 && la.Current.CompareTo(']') != 0)
            {

                left[row, column] = int.Parse(value);
                column++;
                value = "0";

            }
            index++;
            la.MoveNext();
        }
       
        index = 0; row = 0; column = 0;
        value = "0";
        while (index != rarr.Length)
        {

            if (ra.Current.CompareTo(']') == 0)
            {
                right[row, column] = int.Parse(value);
                row += 1;
                column = 0;
                value = "0";
            }
            
            if (ra.Current.CompareTo(',') != 0 && ra.Current.CompareTo('[') != 0 && ra.Current.CompareTo(']') != 0)
            {
                //String.Concat(value,value,la.Current.ToString());                  
                value = value + ra.Current.ToString();
            }

            if (ra.Current.CompareTo(',') == 0 && ra.Current.CompareTo('[') != 0 && ra.Current.CompareTo(']') != 0)
            {

                right[row, column] = int.Parse(value);
                column++;
                value = "0";

            }
            index++;
            ra.MoveNext();
        }
        res = new int[resrows,rescolumns];       
    }


    public override void VisitMatDecElement(MatDecElement element)
    {
         
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
        resultMessage += "matrix declaration element"+"\n";
    }

    public override void VisitMatValElement(MatVal element)
    {
        arrVariableMap[s] = element.getText();
        s = "";
    }

    public override void VisitMatVarElement(MatVar element)
    {
        s = element.getText();
        if (indicate == 2)
            larr = (string)arrVariableMap[element.getText()];
        else if (indicate == 1)
            rarr = (string)arrVariableMap[element.getText()];
        varormatvar = "matvar";
        
    }

    public override void VisitPrintOperationElement(PrintOperationElement element)
    {
 
     VisitElement(element.getChildElement());
     int result = 0;
     if (varormatvar.CompareTo("var") == 0)
     {
         if (mStack.Count > 0)
             result = mStack.Pop();
         Console.WriteLine(result.ToString());
         resultMessage += result.ToString() + "\n";
     }
     else
     {
         resultMessage += arrVariableMap[s];
         Console.WriteLine("The print value of array is {0}",arrVariableMap[s]);         
     }
    }
    
    public override void VisitMatAssignOperationElement(MatMul element)
    {
        
        
        VisitElement(element.getRhs());
        VisitElement(element.getLhs());
        resultMessage += "Processing Matrix Assignment Operation"+"\n";
        Thread[] threads=new Thread[resrows];
        if (operation.CompareTo("*") == 0)
        {
            for (int i = 0; i < resrows; i++)
            {
                ParameterizedThreadStart pts = new ParameterizedThreadStart(threadMul);
                threads[i] = new Thread(pts);
                threads[i].Start(new ThrInd(i));
            }
        }
        else if (operation.CompareTo("+") == 0)
        {
            for (int i = 0; i < resrows; i++)
            {
                ParameterizedThreadStart pts = new ParameterizedThreadStart(threadAdd);
                threads[i] = new Thread(pts);
                threads[i].Start(new ThrInd(i));
            }
           

        }

        foreach (Thread t in threads)
        {
            while (t.IsAlive)
                continue;
        }

        for (int i = 0; i < resrows ; i++)
        {
            arrvalue += "[";
            Console.WriteLine("Arrvalue is{0}",arrvalue);
            for (int j = 0; j < rescolumns ; j++)
            {
                Console.Write("{0} \t",res[i,j]);
                resultMessage += string.Format("{0} \t", res[i, j]);
                arrvalue += string.Format("{0}",res[i,j]);
                if (j + 1 == rescolumns)
                { }
                else
                    arrvalue += ",";

            }
            arrvalue += "]";
            Console.Write("\n");
            resultMessage += "\n";
        }

        Console.WriteLine("Printing value of s in MatAssignOperation: {0} which is {1}",s,arrvalue); // to be removed
        arrVariableMap[s] = arrvalue;
        arrvalue = "";

    }


    public override void VisitMatAdditionOperationElement(MatAddition element)
    {
        //VisitElement(element.getLhs());
        //VisitElement(element.getRhs());
        operation = "+";
        resultMessage += "performing matrix addition element" + "\n";
        int index = 0, row = 0, column = 0;
        indicate = 2;
        VisitElement(element.getLhs());
        indicate = 1;
        VisitElement(element.getRhs());
        indicate = -1;
        String value = "0";
        operation = "+";
        CharEnumerator la = larr.GetEnumerator();
        CharEnumerator ra = rarr.GetEnumerator();

        la.MoveNext();
        ra.MoveNext();

        s = null;


        left = new int[ArrRow(larr), ArrColumn(larr)];
        right = new int[ArrRow(rarr), ArrColumn(rarr)];

        resrows = ArrRow(larr);
        rescolumns = ArrColumn(rarr);
        collim = ArrColumn(larr);

        while (index != larr.Length)
        {

            if (la.Current.CompareTo(']') == 0)
            {
                left[row, column] = int.Parse(value);
                row += 1;
                column = 0;
                value = "0";
            }


            if (la.Current.CompareTo(',') != 0 && la.Current.CompareTo('[') != 0 && la.Current.CompareTo(']') != 0)
            {
                //String.Concat(value,value,la.Current.ToString());                  
                value = value + la.Current.ToString();
            }

            if (la.Current.CompareTo(',') == 0 && la.Current.CompareTo('[') != 0 && la.Current.CompareTo(']') != 0)
            {

                left[row, column] = int.Parse(value);
                column++;
                value = "0";

            }
            index++;
            la.MoveNext();
        }

        index = 0; row = 0; column = 0;
        value = "0";
        while (index != rarr.Length)
        {

            if (ra.Current.CompareTo(']') == 0)
            {
                right[row, column] = int.Parse(value);
                row += 1;
                column = 0;
                value = "0";
            }

            if (ra.Current.CompareTo(',') != 0 && ra.Current.CompareTo('[') != 0 && ra.Current.CompareTo(']') != 0)
            {
                //String.Concat(value,value,la.Current.ToString());                  
                value = value + ra.Current.ToString();
            }

            if (ra.Current.CompareTo(',') == 0 && ra.Current.CompareTo('[') != 0 && ra.Current.CompareTo(']') != 0)
            {

                right[row, column] = int.Parse(value);
                column++;
                value = "0";

            }
            index++;
            ra.MoveNext();
        }
        res = new int[resrows, rescolumns]; 

    }


    public override void VisitLoopElement(LoopElement element)
    {
        resultMessage += "parsing loop element"+"\n";
        loop = element.getText();
        int inc=0;
        int mode = 0;
        CharEnumerator ce = loop.GetEnumerator();
        string remloop="0";
        ce.MoveNext();
        while( inc < loop.Length)
        {
            //Console.WriteLine("Writing loop value {0}", ce.Current);
           
            if (ce.Current.CompareTo('(') == 0 && mode != -1)
                mode = 1;
            if (ce.Current.CompareTo(' ') == 0)
            {                
                remloop = loop.Substring(inc);
                break;
                
            }

            if (mode == 1 && ce.Current.CompareTo('(')!=0)
            {
               loopvar = string.Concat(loopvar, ce.Current.ToString());                                
            }

            ce.MoveNext();
            inc++;
        }
        inc = 0;
        mode = 0;
        Console.WriteLine(" variable met in loop element:{0}",loopvar);
        resultMessage += String.Format(" variable met in loop element:{0}", loopvar)+"\n";
        Console.WriteLine(" substring left to parse:{0}", remloop);
        resultMessage += string.Format(" substring left to parse:{0}", remloop)+"\n";
        ce = remloop.GetEnumerator();
        ce.MoveNext();
        ce.MoveNext();
        string startvar="";
        string endvar="";
        while (inc < remloop.Length)
        {
            if (ce.Current.CompareTo('.') > 0 && mode == 0)
            {
                startvar += ce.Current.ToString();
            }
            else if(ce.Current.CompareTo('.')==0)
            {
                mode = 1;                    
            }
            else if (ce.Current.CompareTo(')') == 0)
            {
                break;
            }
            if (mode == 1 && ce.Current.CompareTo('.')!=0)
            {
                endvar += ce.Current.ToString();
            }
            ce.MoveNext();
            inc++;
        }
        Console.WriteLine("starting var of the loop is: {0}\n ending var of the loop is:{1}", startvar,endvar);
        resultMessage += string.Format("starting var of the loop is: {0}\n ending var of the loop is:{1}", startvar, endvar)+"\n";
        startloopvar = int.Parse(startvar);
        endloopvar = int.Parse(endvar);
    }

    public override void VisitMatIndElement(MatIndex element)
    {
        string matindst = element.getText();
        CharEnumerator ce = matindst.GetEnumerator();
        int inc=0;
        ce.MoveNext();
        string matvar = "";
        string matindvar = "";
        int mode = 0;
        while (inc < matindst.Length)
        {
            if (ce.Current.CompareTo('[') == 0)
            {
                mode = 1;             
            }
            if( mode == 0 && ce.Current.CompareTo('[')!=0)
            matvar += ce.Current.ToString();
            if (mode == 1 && ce.Current.CompareTo('[')!=0 && ce.Current.CompareTo(']')!=0 )
            {
                matindvar += ce.Current.ToString();
            }
            ce.MoveNext();
            inc++;
        }
         
        Console.WriteLine("matvariable with index is:{0}", matvar);
        resultMessage += string.Format("matvariable with index is:{0}", matvar)+"\n";
        Console.WriteLine("matvariable's index variable is:{0}",matindvar);
        resultMessage += string.Format("matvariable's index variable is:{0}", matindvar)+"\n";
        matind = matindvar;
        loopmatvar = matvar;
        
    }

    public override void VisitMatScalAddElement(MatScalAdd element)
    {
       
        VisitElement(element.getRhs());
        string var = element.getLhs().getText();
        int varval = (int)mVariableMap[var];
        Console.WriteLine("variable on matscaladd:{0}",var);
        resultMessage += string.Format("variable on matscaladd:{0}", var)+"\n";
        Console.WriteLine("Value of it is:{0}",varval);
        resultMessage += string.Format("Value of it is:{0}", varval)+"\n";
        scalar = var;
    }

    public int retValAtIndex(string arr,int index)
    {
        int value=0,inc=0,arrind=-1,mode=0;
        string s=(string)arrVariableMap[arr];
        string concatstr="";
        CharEnumerator ce = s.GetEnumerator();
        temp = new int[endloopvar - startloopvar + 1];
        ce.MoveNext();
        ce.MoveNext();
        
            while (inc < s.Length-1)
            {
                if (ce.Current.CompareTo(']') == 0 && arrind < endloopvar)
                {
                    temp[++arrind] = int.Parse(concatstr);
                    break;
                }
                mode = 0;

                if (ce.Current.CompareTo(',') == 0)
                {
                    temp[++arrind] = int.Parse(concatstr);
                    concatstr = "";
                    mode = 1;
                }

                if (ce.Current.CompareTo(',') != 0 && mode != 1)
                {
                    concatstr += ce.Current.ToString();

                }
                inc++;
                ce.MoveNext();
            }
        
        return temp[index];
    }

    public void MixedAddAssign(Object obj)
    {
        
        if (obj is ThrScAndInd)
        {
            ThrScAndInd th = (ThrScAndInd)obj;
            int index =  th.retIndex;
            int scalar = th.retScal;
            string var = th.retMatVar;
            var += "[]";
            lock (parallelforlock)
            {
                int i = retValAtIndex(var,index);
                temp[index] = i + scalar;
                Console.WriteLine("The element value of array {0} at index {1} is:{2}",var,index,temp[index]);
                resultMessage += string.Format("The element value of array {0} at index {1} is:{2}", var, index, temp[index])+"\n";
            }
        }
    }

    public override void VisitMatScalAssignElement(MatScalAssignment element)
    {
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
        Thread[] threads = new Thread[endloopvar - startloopvar+1];
        for (int i = startloopvar; i <= endloopvar; i++)
        {
            ParameterizedThreadStart ps = new ParameterizedThreadStart(MixedAddAssign);
            threads[i] = new Thread(ps);
            threads[i].Start(new ThrScAndInd(i,(int)mVariableMap[scalar],loopmatvar));
        }

        for (int i = 0; i < threads.Length; i++)
            if (!threads[i].IsAlive)
                continue;

    }

    public override void VisitParallelForElement(Parallel_For element)
    {
                           
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
        resultMessage += "visiting parallelfor element"+"\n";              
      
    }

    

}
