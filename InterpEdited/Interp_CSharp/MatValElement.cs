﻿
////////////////////////////////////////////////////////////////////////
// IntegerElement.cs: holds the data needed to represent an Integer.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class MatVal : Element
{

    String mText;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatValElement(this); 
    }

    public String getText() { return mText; }
    public void setText(String value) { mText = value; }
}

