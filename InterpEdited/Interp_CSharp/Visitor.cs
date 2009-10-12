////////////////////////////////////////////////////////////////////////
// Visitor.cs: declares all the abstract Visit functions that each
//  visitor must implement.  Also includes the VisitElement function
//  which alows visiting of an Element when its type is not known.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public abstract class Visitor {

  public abstract void VisitVariableElement(VariableElement element);
  public abstract void VisitIntegerElement(IntegerElement element);
  public abstract void VisitAssignmentOperationElement(AssignmentOperationElement element);
  public abstract void VisitAdditionOperationElement(AdditionOperationElement element);
  public abstract void VisitPrintOperationElement(PrintOperationElement element);
  public abstract void VisitMultiplicationOperationElement(MultiplicationOperationElement element);
  public abstract void VisitMatValElement(MatVal element);
  public abstract void VisitMatVarElement(MatVar element);
  public abstract void VisitMatDecElement(MatDecElement element);
  public abstract void VisitMatMultiplicationOperationElement(MatMultiplication element);
  public abstract void VisitMatAssignOperationElement(MatMul element);
  public abstract void VisitMatIndElement(MatIndex element);
  public abstract void VisitMatScalAddElement(MatScalAdd element);
  public abstract void VisitMatScalAssignElement(MatScalAssignment element);
  public abstract void VisitParallelForElement(Parallel_For element);
  public abstract void VisitLoopElement(LoopElement element);
  public abstract void VisitMatAdditionOperationElement(MatAddition element);

  public void VisitElement(Element element){
    if(element is IntegerElement){
      IntegerElement int_elem = (IntegerElement) element;
      VisitIntegerElement(int_elem);       
    } else if(element is VariableElement){
      VariableElement var_elem = (VariableElement) element;
      VisitVariableElement(var_elem);
    } else if(element is AdditionOperationElement){
      AdditionOperationElement add_elem = (AdditionOperationElement) element;
      VisitAdditionOperationElement(add_elem);          
    } else if(element is AssignmentOperationElement){
      AssignmentOperationElement assign_elem = (AssignmentOperationElement) element;
      VisitAssignmentOperationElement(assign_elem);      
    }
    else if (element is MultiplicationOperationElement)
    {
        MultiplicationOperationElement multiply_elem = (MultiplicationOperationElement)element;
        VisitMultiplicationOperationElement(multiply_elem);
    }
    else if (element is MatDecElement)
    {
        MatDecElement matdec_elem = (MatDecElement)element;
        VisitMatDecElement(matdec_elem);  
    }
    else if (element is MatVal)
    { 
      MatVal matval_elem = (MatVal)element;
      VisitMatValElement(matval_elem);
    }
    else if (element is MatVar)
    {
        MatVar matvar_elem = (MatVar)element;
        VisitMatVarElement(matvar_elem);
    }
    else if (element is MatMultiplication)
    {
        MatMultiplication matmul_elem = (MatMultiplication)element;
        VisitMatMultiplicationOperationElement(matmul_elem);
    }
    else if (element is MatMul)
    {
        MatMul matmulassign_elem = (MatMul)element;
        VisitMatAssignOperationElement(matmulassign_elem);
    }
    else if(element is MatIndex)
    {
        MatIndex matind = (MatIndex)element;
        VisitMatIndElement(matind);

    }
    else if(element is MatScalAdd)
    {
        MatScalAdd matscaladd = (MatScalAdd)element;
        VisitMatScalAddElement(matscaladd);
 
    }
    else if( element is MatScalAssignment)
    {
        MatScalAssignment matscalassign = (MatScalAssignment)element;
        VisitMatScalAssignElement(matscalassign);
    }
    else if(element is LoopElement)
    {
        LoopElement loopel = (LoopElement)element;
        VisitLoopElement(loopel);
    }
    else if(element is Parallel_For)
    {
        Parallel_For parallelfor = (Parallel_For)element;
        VisitParallelForElement(parallelfor);
    }
    else if(element is MatAddition)
    {
      MatAddition mataddition = (MatAddition)element;
        VisitMatAdditionOperationElement(mataddition);
    }   

  }
       protected Visitor() { }
}
