////////////////////////////////////////////////////////////////////////
// Interp.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////

grammar Interp;

options {
  language = 'CSharp';
  output=AST;
} 

@parser::header {
using System.Collections.Generic;
}

@lexer::header {
using System.Collections.Generic;
}

/*
 * Parser Rules
 */
program returns [List<Element> ret]
@init {
  retval.ret = new List<Element>();
}
  : (expr {retval.ret.Add($expr.ret); } )+;

expr returns [Element ret]
  : assignment {retval.ret = $assignment.ret;}
  | print { retval.ret = $print.ret; }
  | matdecelement { retval.ret = $matdecelement.ret; }  
  | matmul { retval.ret = $matmul.ret; }   
  ;



assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : variable { retval.ret.setLhs($variable.ret); }
    ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); } 
    | addition {retval.ret.setRhs($addition.ret); }
    | multiplication { retval.ret.setRhs($multiplication.ret); }  
    ) END_OF_STATEMENT;
     
matmul returns [MatMul ret]
@init{
retval.ret = new MatMul();
}
:
matvar { retval.ret.setLhs($matvar.ret);   } 
ASSIGNMENT                        
matmultiplication { retval.ret.setRhs($matmultiplication.ret); }     
;

matdecelement returns [MatDecElement ret]
@init {
    retval.ret = new MatDecElement();
}
: matvar { retval.ret.setLhs($matvar.ret); }  
  matval { retval.ret.setRhs($matval.ret); }
  END_OF_STATEMENT;

matvar returns [MatVar ret]
@init {
retval.ret = new MatVar();
}
:
MATVAR { retval.ret.setText($MATVAR.text); };

matval returns [MatVal ret]
@init{
retval.ret = new MatVal();
}
:
MATVAL { retval.ret.setText($MATVAL.text); };


var_or_int_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; } );


variable returns [VariableElement ret]
@init {
  retval.ret = new VariableElement();
}
  : VARIABLE { retval.ret.setText($VARIABLE.text); };

int_literal returns [IntegerElement ret]
@init {
  retval.ret = new IntegerElement();
}
  : INT_LITERAL { retval.ret.setText($INT_LITERAL.text); };

addition returns [AdditionOperationElement ret]
@init {
  retval.ret = new AdditionOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };

multiplication returns [MultiplicationOperationElement ret]
@init{
        retval.ret = new MultiplicationOperationElement();
}
: el1 = var_or_int_literal { retval.ret.setLhs($el1.ret); }
  '*'
  el2 = var_or_int_literal { retval.ret.setRhs($el2.ret); };

matmultiplication returns [MatMultiplication  ret]
@init{
retval.ret = new MatMultiplication();
}
:
el1=matvar { retval.ret.setLhs($el1.ret);   }    
 '*'
el2=matvar { retval.ret.setRhs($el2.ret);   }
;
 
print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_or_int_literal {retval.ret.setChildElement($var_or_int_literal.ret); }
    END_OF_STATEMENT; 

/*
 * Lexer Rules
 */

END_OF_STATEMENT: ';';
ASSIGNMENT: '=';
PLUS: '+';
MULTIPLY: '*';
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
WHITESPACE: (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;
MATVAR: VARIABLE ('['']')+;
MATVAL: ('['(('0'..'9')|(','))+']')+;

