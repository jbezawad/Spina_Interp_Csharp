////////////////////////////////////////////////////////////////////////
// PrettyPrintVisitor.cs: demonstrates printing the syntax tree in 
//  a difference source language than the input for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class PrettyPrintVisitor : Visitor {

  public override void VisitVariableElement(VariableElement element){
    Console.Write("var:" + element.getText() + " ");
  }
  public override void VisitIntegerElement(IntegerElement element){
    Console.Write("int:" + element.getText() + " ");
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    VisitElement(element.getLhs());
    Console.Write(":= ");
    VisitElement(element.getRhs());
    Console.WriteLine(";");
  }
  
   public override void VisitAdditionOperationElement(AdditionOperationElement element)
   {
    VisitElement(element.getLhs());
    Console.Write("+ ");
    VisitElement(element.getRhs());
    Console.Write(" ");
   }

   public override void VisitMatDecElement(MatDecElement element)
   {
       VisitElement(element.getLhs());
       Console.Write(" ");
       VisitElement(element.getRhs());
   }

   public override void VisitMatValElement(MatVal element)
   {
       System.Console.WriteLine(element.getText());   
   }

   public override void VisitMatVarElement(MatVar element)
   {
       System.Console.WriteLine(element.getText());
   }

  public override void VisitMultiplicationOperationElement(MultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      Console.Write(" * ");
      VisitElement(element.getRhs());
      Console.Write(" ");     
  }
    
    public override void VisitPrintOperationElement(PrintOperationElement element)
    {
     Console.Write("function:print ");
     VisitElement(element.getChildElement());
     Console.WriteLine(";");
    }

    public override void VisitMatMultiplicationOperationElement(MatMultiplication element)
    {
       
    }
    public override void VisitMatAssignOperationElement(MatMul element)
    {
        //String s=element.getLhs();

        VisitElement(element.getRhs());

    }
    public override void VisitLoopElement(LoopElement element)
    {
        Console.WriteLine("loop element: {0}",element.getText());
    }
    public override void VisitMatIndElement(MatIndex element)
    {
        Console.WriteLine("matrix index: {0} \n",element.getText());
       

    }

    public override void VisitMatScalAddElement(MatScalAdd element)
    {
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
    }

    public override void VisitMatScalAssignElement(MatScalAssignment element)
    {
        VisitElement(element.getRhs());
        VisitElement(element.getLhs());

    }
    public override void VisitParallelForElement(Parallel_For element)
    {
        Console.Write("parallel_for");
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
    }

    public override void VisitMatAdditionOperationElement(MatAddition element)
    {
        VisitElement(element.getLhs());
        VisitElement(element.getRhs());
        Console.Write("matrix addition");
    }

}
