﻿////////////////////////////////////////////////////////////////////////
// AssignmentOperationElement.cs: holds the data needed for an 
//  assignment operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class MatScalAdd : Element
{

    VariableElement mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatScalAddElement(this);
    }

    public VariableElement getLhs() { return mLhs; }
    public void setLhs(VariableElement lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(MatIndex rhs) { mRhs = rhs; }

}
