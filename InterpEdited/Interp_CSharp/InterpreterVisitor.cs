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
  String s,larr,rarr;
  Hashtable arrVariableMap;
  Stack<int> mStack;
  int indicate,resrows,rescolumns,collim;  
  int[,] left;
  int[,] right;
  int[,] res;
  

  private Object token = new Object();

  public int mulRowCol(int row, int col)
  {
    int sum=0;
    for(int i=0; i < collim; i++)  
    {
       sum+=left[row,i]*right[i,col];
    }
    Console.WriteLine("{0} ", sum);
    if (col != 0)
        Console.WriteLine("\t");
    else
        Console.WriteLine("\n");
    
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

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mStack = new Stack<int>();
    arrVariableMap = new Hashtable(); 
  }
  

    public override void VisitVariableElement(VariableElement element){
    if(mVariableMap.ContainsKey(element.getText())){
      int element_value = (int) mVariableMap[element.getText()];
      mStack.Push(element_value);
      } 
    else {
      //lets assume that the syntax has been checked for this example because I don't like the exception
      //propegation that will happen if I throw here
      //throw new Exception("Variable " + element.getText() + " not defined.");
     }
    }
  
    public override void VisitIntegerElement(IntegerElement element)
    {
     int element_value = int.Parse(element.getText());
     mStack.Push(element_value);
    }

    public override void VisitAssignmentOperationElement(AssignmentOperationElement element)
    {
     String variable_name = element.getLhs().getText();
     Element rhs = element.getRhs();
     VisitElement(rhs);
     int result = mStack.Pop();    
     mVariableMap[variable_name] = result;
    }

    public override void VisitAdditionOperationElement(AdditionOperationElement element)
    {     
     VisitElement(element.getLhs());
     VisitElement(element.getRhs());
     int rhs = mStack.Pop();
     int lhs = mStack.Pop();
     int result = rhs + lhs;
     mStack.Push(result);    
    }

    public override void VisitMultiplicationOperationElement(MultiplicationOperationElement element)
    {
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
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
        int index=0,row=0,column= 0;        
        indicate = 2;
        VisitElement(element.getLhs());
        indicate = 1;
        VisitElement(element.getRhs());
        indicate = -1;
        String value="0";
        
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
        Console.WriteLine("Hi");
        Console.ReadLine();
    }


    public override void VisitMatDecElement(MatDecElement element)
    {

        VisitElement(element.getLhs());
        VisitElement(element.getRhs());

    }

    public override void VisitMatValElement(MatVal element)
    {
        arrVariableMap[s] = element.getText();
        s = null;
    }

    public override void VisitMatVarElement(MatVar element)
    {
        s = element.getText();
        if (indicate == 2)
            larr = (string)arrVariableMap[element.getText()];
        else if (indicate == 1)
            rarr = (string)arrVariableMap[element.getText()]; 
    }

    public override void VisitPrintOperationElement(PrintOperationElement element)
    {
     VisitElement(element.getChildElement());
     int result = mStack.Pop();
     Console.WriteLine(result.ToString());
    }
    
    public override void VisitMatAssignOperationElement(MatMul element)
    {
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());

        Thread[] threads=new Thread[resrows];
       
        for (int i = 0; i < resrows; i++)
        {
         ParameterizedThreadStart pts = new ParameterizedThreadStart(threadMul);
         threads[i] = new Thread(pts);
         threads[i].Start(new ThrInd(i));         
        }

        foreach (Thread t in threads)
        {
            while (t.IsAlive)
                continue;
        }

        Console.WriteLine("The matrix multiplication output for a[][] * b[][] is ");
        

        for (int i = 0; i < resrows ; i++)
        {
            for (int j = 0; j < rescolumns ; j++)
            {
                Console.Write("{0} \t",res[i,j]);

            }

            Console.Write("\n");
        }
    }

}
