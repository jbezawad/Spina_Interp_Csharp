// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-09-27 22:54:37


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class InterpParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ASSIGNMENT", 
		"END_OF_STATEMENT", 
		"MATVAR", 
		"MATVAL", 
		"VARIABLE", 
		"INT_LITERAL", 
		"PLUS", 
		"MULTIPLY", 
		"WHITESPACE", 
		"'print'"
    };

    public const int MATVAR = 6;
    public const int INT_LITERAL = 9;
    public const int VARIABLE = 8;
    public const int MATVAL = 7;
    public const int MULTIPLY = 11;
    public const int T__13 = 13;
    public const int WHITESPACE = 12;
    public const int PLUS = 10;
    public const int ASSIGNMENT = 4;
    public const int EOF = -1;
    public const int END_OF_STATEMENT = 5;

    // delegates
    // delegators



        public InterpParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public InterpParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return InterpParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Interp.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // Interp.g:29:1: program returns [List<Element> ret] : ( expr )+ ;
    public InterpParser.program_return program() // throws RecognitionException [1]
    {   
        InterpParser.program_return retval = new InterpParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // Interp.g:33:3: ( ( expr )+ )
            // Interp.g:33:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:33:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == MATVAR || LA1_0 == VARIABLE || LA1_0 == 13) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:33:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program74);
            			    	expr1 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1.Tree);
            			    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class expr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // Interp.g:35:1: expr returns [Element ret] : ( assignment | print | matdecelement | matmul );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.print_return print3 = null;

        InterpParser.matdecelement_return matdecelement4 = null;

        InterpParser.matmul_return matmul5 = null;



        try 
    	{
            // Interp.g:36:3: ( assignment | print | matdecelement | matmul )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                alt2 = 1;
                }
                break;
            case 13:
            	{
                alt2 = 2;
                }
                break;
            case MATVAR:
            	{
                int LA2_3 = input.LA(2);

                if ( (LA2_3 == MATVAL) )
                {
                    alt2 = 3;
                }
                else if ( (LA2_3 == ASSIGNMENT) )
                {
                    alt2 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d2s3 =
                        new NoViableAltException("", 2, 3, input);

                    throw nvae_d2s3;
                }
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // Interp.g:36:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr93);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    // Interp.g:37:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr101);
                    	print3 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print3.Tree);
                    	 retval.ret = ((print3 != null) ? print3.ret : null); 

                    }
                    break;
                case 3 :
                    // Interp.g:38:5: matdecelement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matdecelement_in_expr109);
                    	matdecelement4 = matdecelement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matdecelement4.Tree);
                    	 retval.ret = ((matdecelement4 != null) ? matdecelement4.ret : null); 

                    }
                    break;
                case 4 :
                    // Interp.g:39:5: matmul
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matmul_in_expr119);
                    	matmul5 = matmul();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matmul5.Tree);
                    	 retval.ret = ((matmul5 != null) ? matmul5.ret : null); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class assignment_return : ParserRuleReturnScope
    {
        public AssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // Interp.g:44:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT7 = null;
        IToken END_OF_STATEMENT11 = null;
        InterpParser.variable_return variable6 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal8 = null;

        InterpParser.addition_return addition9 = null;

        InterpParser.multiplication_return multiplication10 = null;


        object ASSIGNMENT7_tree=null;
        object END_OF_STATEMENT11_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:48:3: ( variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT )
            // Interp.g:48:5: variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment148);
            	variable6 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable6.Tree);
            	 retval.ret.setLhs(((variable6 != null) ? variable6.ret : null)); 
            	ASSIGNMENT7=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment156); 
            		ASSIGNMENT7_tree = (object)adaptor.Create(ASSIGNMENT7);
            		adaptor.AddChild(root_0, ASSIGNMENT7_tree);

            	// Interp.g:50:5: ( var_or_int_literal | addition | multiplication )
            	int alt3 = 3;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == VARIABLE) )
            	{
            	    switch ( input.LA(2) ) 
            	    {
            	    case END_OF_STATEMENT:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case MULTIPLY:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d3s1 =
            	    	        new NoViableAltException("", 3, 1, input);

            	    	    throw nvae_d3s1;
            	    }

            	}
            	else if ( (LA3_0 == INT_LITERAL) )
            	{
            	    switch ( input.LA(2) ) 
            	    {
            	    case MULTIPLY:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case END_OF_STATEMENT:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d3s2 =
            	    	        new NoViableAltException("", 3, 2, input);

            	    	    throw nvae_d3s2;
            	    }

            	}
            	else 
            	{
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Interp.g:50:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment164);
            	        	var_or_int_literal8 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal8.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal8 != null) ? var_or_int_literal8.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:51:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment175);
            	        	addition9 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition9.Tree);
            	        	retval.ret.setRhs(((addition9 != null) ? addition9.ret : null)); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:52:7: multiplication
            	        {
            	        	PushFollow(FOLLOW_multiplication_in_assignment185);
            	        	multiplication10 = multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, multiplication10.Tree);
            	        	 retval.ret.setRhs(((multiplication10 != null) ? multiplication10.ret : null)); 

            	        }
            	        break;

            	}

            	END_OF_STATEMENT11=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment197); 
            		END_OF_STATEMENT11_tree = (object)adaptor.Create(END_OF_STATEMENT11);
            		adaptor.AddChild(root_0, END_OF_STATEMENT11_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class matmul_return : ParserRuleReturnScope
    {
        public MatMul ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matmul"
    // Interp.g:55:1: matmul returns [MatMul ret] : matvar ASSIGNMENT matmultiplication ;
    public InterpParser.matmul_return matmul() // throws RecognitionException [1]
    {   
        InterpParser.matmul_return retval = new InterpParser.matmul_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT13 = null;
        InterpParser.matvar_return matvar12 = null;

        InterpParser.matmultiplication_return matmultiplication14 = null;


        object ASSIGNMENT13_tree=null;


        retval.ret = new MatMul();

        try 
    	{
            // Interp.g:59:1: ( matvar ASSIGNMENT matmultiplication )
            // Interp.g:60:1: matvar ASSIGNMENT matmultiplication
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_matmul218);
            	matvar12 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matvar12.Tree);
            	 retval.ret.setLhs(((matvar12 != null) ? matvar12.ret : null));   
            	ASSIGNMENT13=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matmul223); 
            		ASSIGNMENT13_tree = (object)adaptor.Create(ASSIGNMENT13);
            		adaptor.AddChild(root_0, ASSIGNMENT13_tree);

            	PushFollow(FOLLOW_matmultiplication_in_matmul249);
            	matmultiplication14 = matmultiplication();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matmultiplication14.Tree);
            	 retval.ret.setRhs(((matmultiplication14 != null) ? matmultiplication14.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matmul"

    public class matdecelement_return : ParserRuleReturnScope
    {
        public MatDecElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matdecelement"
    // Interp.g:65:1: matdecelement returns [MatDecElement ret] : matvar matval END_OF_STATEMENT ;
    public InterpParser.matdecelement_return matdecelement() // throws RecognitionException [1]
    {   
        InterpParser.matdecelement_return retval = new InterpParser.matdecelement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT17 = null;
        InterpParser.matvar_return matvar15 = null;

        InterpParser.matval_return matval16 = null;


        object END_OF_STATEMENT17_tree=null;


            retval.ret = new MatDecElement();

        try 
    	{
            // Interp.g:69:1: ( matvar matval END_OF_STATEMENT )
            // Interp.g:69:3: matvar matval END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_matdecelement274);
            	matvar15 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matvar15.Tree);
            	 retval.ret.setLhs(((matvar15 != null) ? matvar15.ret : null)); 
            	PushFollow(FOLLOW_matval_in_matdecelement282);
            	matval16 = matval();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matval16.Tree);
            	 retval.ret.setRhs(((matval16 != null) ? matval16.ret : null)); 
            	END_OF_STATEMENT17=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matdecelement288); 
            		END_OF_STATEMENT17_tree = (object)adaptor.Create(END_OF_STATEMENT17);
            		adaptor.AddChild(root_0, END_OF_STATEMENT17_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matdecelement"

    public class matvar_return : ParserRuleReturnScope
    {
        public MatVar ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matvar"
    // Interp.g:73:1: matvar returns [MatVar ret] : MATVAR ;
    public InterpParser.matvar_return matvar() // throws RecognitionException [1]
    {   
        InterpParser.matvar_return retval = new InterpParser.matvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MATVAR18 = null;

        object MATVAR18_tree=null;


        retval.ret = new MatVar();

        try 
    	{
            // Interp.g:77:1: ( MATVAR )
            // Interp.g:78:1: MATVAR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	MATVAR18=(IToken)Match(input,MATVAR,FOLLOW_MATVAR_in_matvar305); 
            		MATVAR18_tree = (object)adaptor.Create(MATVAR18);
            		adaptor.AddChild(root_0, MATVAR18_tree);

            	 retval.ret.setText(((MATVAR18 != null) ? MATVAR18.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matvar"

    public class matval_return : ParserRuleReturnScope
    {
        public MatVal ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matval"
    // Interp.g:80:1: matval returns [MatVal ret] : MATVAL ;
    public InterpParser.matval_return matval() // throws RecognitionException [1]
    {   
        InterpParser.matval_return retval = new InterpParser.matval_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MATVAL19 = null;

        object MATVAL19_tree=null;


        retval.ret = new MatVal();

        try 
    	{
            // Interp.g:84:1: ( MATVAL )
            // Interp.g:85:1: MATVAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	MATVAL19=(IToken)Match(input,MATVAL,FOLLOW_MATVAL_in_matval323); 
            		MATVAL19_tree = (object)adaptor.Create(MATVAL19);
            		adaptor.AddChild(root_0, MATVAL19_tree);

            	 retval.ret.setText(((MATVAL19 != null) ? MATVAL19.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matval"

    public class var_or_int_literal_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_or_int_literal"
    // Interp.g:88:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable20 = null;

        InterpParser.int_literal_return int_literal21 = null;



        try 
    	{
            // Interp.g:89:3: ( ( variable | int_literal ) )
            // Interp.g:89:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:89:6: ( variable | int_literal )
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == VARIABLE) )
            	{
            	    alt4 = 1;
            	}
            	else if ( (LA4_0 == INT_LITERAL) )
            	{
            	    alt4 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Interp.g:89:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal342);
            	        	variable20 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable20.Tree);
            	        	 retval.ret = ((variable20 != null) ? variable20.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:90:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal353);
            	        	int_literal21 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal21.Tree);
            	        	retval.ret = ((int_literal21 != null) ? int_literal21.ret : null); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var_or_int_literal"

    public class variable_return : ParserRuleReturnScope
    {
        public VariableElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // Interp.g:93:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE22 = null;

        object VARIABLE22_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:97:3: ( VARIABLE )
            // Interp.g:97:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE22=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable377); 
            		VARIABLE22_tree = (object)adaptor.Create(VARIABLE22);
            		adaptor.AddChild(root_0, VARIABLE22_tree);

            	 retval.ret.setText(((VARIABLE22 != null) ? VARIABLE22.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class int_literal_return : ParserRuleReturnScope
    {
        public IntegerElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_literal"
    // Interp.g:99:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL23 = null;

        object INT_LITERAL23_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:103:3: ( INT_LITERAL )
            // Interp.g:103:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL23=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal398); 
            		INT_LITERAL23_tree = (object)adaptor.Create(INT_LITERAL23);
            		adaptor.AddChild(root_0, INT_LITERAL23_tree);

            	 retval.ret.setText(((INT_LITERAL23 != null) ? INT_LITERAL23.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"

    public class addition_return : ParserRuleReturnScope
    {
        public AdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "addition"
    // Interp.g:105:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal24 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal24_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:109:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:109:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition421);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal24=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition430); 
            		char_literal24_tree = (object)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition439);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addition"

    public class multiplication_return : ParserRuleReturnScope
    {
        public MultiplicationOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplication"
    // Interp.g:113:1: multiplication returns [MultiplicationOperationElement ret] : el1= var_or_int_literal '*' el2= var_or_int_literal ;
    public InterpParser.multiplication_return multiplication() // throws RecognitionException [1]
    {   
        InterpParser.multiplication_return retval = new InterpParser.multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal25 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal25_tree=null;


                retval.ret = new MultiplicationOperationElement();

        try 
    	{
            // Interp.g:117:1: (el1= var_or_int_literal '*' el2= var_or_int_literal )
            // Interp.g:117:3: el1= var_or_int_literal '*' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication461);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal25=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplication467); 
            		char_literal25_tree = (object)adaptor.Create(char_literal25);
            		adaptor.AddChild(root_0, char_literal25_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication475);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplication"

    public class matmultiplication_return : ParserRuleReturnScope
    {
        public MatMultiplication  ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matmultiplication"
    // Interp.g:121:1: matmultiplication returns [MatMultiplication ret] : el1= matvar '*' el2= matvar ;
    public InterpParser.matmultiplication_return matmultiplication() // throws RecognitionException [1]
    {   
        InterpParser.matmultiplication_return retval = new InterpParser.matmultiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal26 = null;
        InterpParser.matvar_return el1 = null;

        InterpParser.matvar_return el2 = null;


        object char_literal26_tree=null;


        retval.ret = new MatMultiplication();

        try 
    	{
            // Interp.g:125:1: (el1= matvar '*' el2= matvar )
            // Interp.g:126:1: el1= matvar '*' el2= matvar
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_matmultiplication495);
            	el1 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null));   
            	char_literal26=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_matmultiplication504); 
            		char_literal26_tree = (object)adaptor.Create(char_literal26);
            		adaptor.AddChild(root_0, char_literal26_tree);

            	PushFollow(FOLLOW_matvar_in_matmultiplication508);
            	el2 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null));   

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matmultiplication"

    public class print_return : ParserRuleReturnScope
    {
        public PrintOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "print"
    // Interp.g:131:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal27 = null;
        IToken END_OF_STATEMENT29 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal28 = null;


        object string_literal27_tree=null;
        object END_OF_STATEMENT29_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:135:3: ( 'print' var_or_int_literal END_OF_STATEMENT )
            // Interp.g:135:5: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal27=(IToken)Match(input,13,FOLLOW_13_in_print531); 
            		string_literal27_tree = (object)adaptor.Create(string_literal27);
            		adaptor.AddChild(root_0, string_literal27_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print533);
            	var_or_int_literal28 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal28.Tree);
            	retval.ret.setChildElement(((var_or_int_literal28 != null) ? var_or_int_literal28.ret : null)); 
            	END_OF_STATEMENT29=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print541); 
            		END_OF_STATEMENT29_tree = (object)adaptor.Create(END_OF_STATEMENT29);
            		adaptor.AddChild(root_0, END_OF_STATEMENT29_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000002142UL});
    public static readonly BitSet FOLLOW_assignment_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matdecelement_in_expr109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matmul_in_expr119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment148 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment156 = new BitSet(new ulong[]{0x0000000000000300UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment164 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment175 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_multiplication_in_assignment185 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_matmul218 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matmul223 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_matmultiplication_in_matmul249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_matdecelement274 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_matval_in_matdecelement282 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matdecelement288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MATVAR_in_matvar305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MATVAL_in_matval323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition421 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition430 = new BitSet(new ulong[]{0x0000000000000300UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication461 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplication467 = new BitSet(new ulong[]{0x0000000000000300UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_matmultiplication495 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_matmultiplication504 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_matvar_in_matmultiplication508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_print531 = new BitSet(new ulong[]{0x0000000000000300UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print533 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print541 = new BitSet(new ulong[]{0x0000000000000002UL});

}
