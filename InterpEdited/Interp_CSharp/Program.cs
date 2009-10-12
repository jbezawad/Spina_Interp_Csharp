////////////////////////////////////////////////////////////////////////
// Program.cs: demonstrates the interpreter for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Antlr.Runtime;



namespace Interp_CSharp
{
   class Program
   {
      InterpreterVisitor interp_visitor = new InterpreterVisitor();
      PrettyPrintVisitor print_visitor = new PrettyPrintVisitor();
      string results;
      public string resultMessage
      {
          get { return results;  }
          set { results = value; }
      }      
      public void VisitLine(String line){
         ANTLRStringStream string_stream = new ANTLRStringStream(line);
         InterpLexer lexer = new InterpLexer(string_stream);
         CommonTokenStream tokens = new CommonTokenStream(lexer);			
         InterpParser parser = new InterpParser(tokens);
         try {
            InterpParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for(int i = 0; i < elements.Count; i++){
              Element curr = elements[i];
              curr.Accept(print_visitor);
              curr.Accept(interp_visitor);
            }
            results=interp_visitor.results;            
            interp_visitor.results = "";
          } catch (RecognitionException e)  {
            Console.WriteLine(e.Message);
          } 

      }

      public void RunEvalLoop(string line){
          
             VisitLine(line);                 
      }
      
      [STAThread]
      public static void Main(String[] args)
      {
         
         UI ui = new UI();
         DialogResult dr = MessageBox.Show("Do You Want To Load Spina File ", "Welcome To SPINA Interpreter", MessageBoxButtons.YesNo);
         if (dr == DialogResult.Yes)
         {
             ui.communicate(false);
             ui.ShowDialog();
         }
         else if(dr==DialogResult.No)
         {
             ui.communicate(true);
             ui.ShowDialog();
         }
         
         //first demonstrate visiting premade line.
         //theprogram.VisitLine("myvar = 1+3; a[][] [10,20,30][20,30,40]; parallel_for(myvar 0..2){ a[i] = myvar + a[i];}; ");
         //theprogram.VisitLine("myvariable = 1 + 2; var = myvariable + 3; print var; a[][] [10,2][10,3]; b[][] [10,30][40,50]; c[][] = a[][] * b[][];");
         //theprogram.RunEvalLoop();
         //Console.Read();
         // uithread.
        
      }
   }
}
