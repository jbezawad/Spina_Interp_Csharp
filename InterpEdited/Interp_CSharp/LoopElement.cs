////////////////////////////////////////////////////////////////////////
// AssignmentOperationElement.cs: holds the data needed for an 
//  assignment operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class LoopElement : Element
{

    string mText;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitLoopElement(this);
    }

   
    public string getText() { return mText; }
    public void setText(string rhs) { mText = rhs; }

}
