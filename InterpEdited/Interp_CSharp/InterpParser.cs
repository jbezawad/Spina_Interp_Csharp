// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-12 16:05:42


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
		"PARALLEL", 
		"OPENBRACE", 
		"CLOSEBRACE", 
		"MATINDEX", 
		"LOOP", 
		"MATVAR", 
		"MATVAL", 
		"VARIABLE", 
		"INT_LITERAL", 
		"PLUS", 
		"MULTIPLY", 
		"WHITESPACE", 
		"'print'"
    };

    public const int MATVAR = 11;
    public const int OPENBRACE = 7;
    public const int INT_LITERAL = 14;
    public const int VARIABLE = 13;
    public const int MATVAL = 12;
    public const int T__18 = 18;
    public const int MULTIPLY = 16;
    public const int CLOSEBRACE = 8;
    public const int LOOP = 10;
    public const int PARALLEL = 6;
    public const int WHITESPACE = 17;
    public const int PLUS = 15;
    public const int ASSIGNMENT = 4;
    public const int EOF = -1;
    public const int END_OF_STATEMENT = 5;
    public const int MATINDEX = 9;

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

            	    if ( (LA1_0 == PARALLEL || LA1_0 == MATVAR || LA1_0 == VARIABLE || LA1_0 == 18) )
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
    // Interp.g:35:1: expr returns [Element ret] : ( assignment | print | matdecelement | matmul | parallel );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.print_return print3 = null;

        InterpParser.matdecelement_return matdecelement4 = null;

        InterpParser.matmul_return matmul5 = null;

        InterpParser.parallel_return parallel6 = null;



        try 
    	{
            // Interp.g:36:3: ( assignment | print | matdecelement | matmul | parallel )
            int alt2 = 5;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                alt2 = 1;
                }
                break;
            case 18:
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
            case PARALLEL:
            	{
                alt2 = 5;
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
                    	 retval.ret =  ((matmul5 != null) ? matmul5.ret : null);  

                    }
                    break;
                case 5 :
                    // Interp.g:40:5: parallel
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallel_in_expr131);
                    	parallel6 = parallel();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallel6.Tree);
                    	 retval.ret = ((parallel6 != null) ? parallel6.ret : null);

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
    // Interp.g:45:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT8 = null;
        IToken END_OF_STATEMENT12 = null;
        InterpParser.variable_return variable7 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal9 = null;

        InterpParser.addition_return addition10 = null;

        InterpParser.multiplication_return multiplication11 = null;


        object ASSIGNMENT8_tree=null;
        object END_OF_STATEMENT12_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:49:3: ( variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT )
            // Interp.g:49:5: variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment157);
            	variable7 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable7.Tree);
            	 retval.ret.setLhs(((variable7 != null) ? variable7.ret : null)); 
            	ASSIGNMENT8=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment165); 
            		ASSIGNMENT8_tree = (object)adaptor.Create(ASSIGNMENT8);
            		adaptor.AddChild(root_0, ASSIGNMENT8_tree);

            	// Interp.g:51:5: ( var_or_int_literal | addition | multiplication )
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
            	    case END_OF_STATEMENT:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case MULTIPLY:
            	    	{
            	        alt3 = 3;
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
            	        // Interp.g:51:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment173);
            	        	var_or_int_literal9 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal9.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal9 != null) ? var_or_int_literal9.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:52:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment184);
            	        	addition10 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition10.Tree);
            	        	retval.ret.setRhs(((addition10 != null) ? addition10.ret : null)); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:53:7: multiplication
            	        {
            	        	PushFollow(FOLLOW_multiplication_in_assignment194);
            	        	multiplication11 = multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, multiplication11.Tree);
            	        	 retval.ret.setRhs(((multiplication11 != null) ? multiplication11.ret : null)); 

            	        }
            	        break;

            	}

            	END_OF_STATEMENT12=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment206); 
            		END_OF_STATEMENT12_tree = (object)adaptor.Create(END_OF_STATEMENT12);
            		adaptor.AddChild(root_0, END_OF_STATEMENT12_tree);


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
    // Interp.g:56:1: matmul returns [MatMul ret] : matvar ASSIGNMENT ( matmultiplication | mataddition ) ;
    public InterpParser.matmul_return matmul() // throws RecognitionException [1]
    {   
        InterpParser.matmul_return retval = new InterpParser.matmul_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT14 = null;
        InterpParser.matvar_return matvar13 = null;

        InterpParser.matmultiplication_return matmultiplication15 = null;

        InterpParser.mataddition_return mataddition16 = null;


        object ASSIGNMENT14_tree=null;


        retval.ret = new MatMul();

        try 
    	{
            // Interp.g:60:1: ( matvar ASSIGNMENT ( matmultiplication | mataddition ) )
            // Interp.g:61:1: matvar ASSIGNMENT ( matmultiplication | mataddition )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_matmul227);
            	matvar13 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matvar13.Tree);
            	 retval.ret.setLhs(((matvar13 != null) ? matvar13.ret : null));   
            	ASSIGNMENT14=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matmul232); 
            		ASSIGNMENT14_tree = (object)adaptor.Create(ASSIGNMENT14);
            		adaptor.AddChild(root_0, ASSIGNMENT14_tree);

            	// Interp.g:63:1: ( matmultiplication | mataddition )
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == MATVAR) )
            	{
            	    int LA4_1 = input.LA(2);

            	    if ( (LA4_1 == PLUS) )
            	    {
            	        alt4 = 2;
            	    }
            	    else if ( (LA4_1 == MULTIPLY) )
            	    {
            	        alt4 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d4s1 =
            	            new NoViableAltException("", 4, 1, input);

            	        throw nvae_d4s1;
            	    }
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
            	        // Interp.g:63:3: matmultiplication
            	        {
            	        	PushFollow(FOLLOW_matmultiplication_in_matmul260);
            	        	matmultiplication15 = matmultiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matmultiplication15.Tree);
            	        	 retval.ret.setRhs(((matmultiplication15 != null) ? matmultiplication15.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:65:2: mataddition
            	        {
            	        	PushFollow(FOLLOW_mataddition_in_matmul272);
            	        	mataddition16 = mataddition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, mataddition16.Tree);
            	        	 retval.ret.setRhs(((mataddition16 != null) ? mataddition16.ret : null)); 

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
    // $ANTLR end "matmul"

    public class parallel_return : ParserRuleReturnScope
    {
        public Parallel_For ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallel"
    // Interp.g:68:1: parallel returns [Parallel_For ret] : PARALLEL loop OPENBRACE matscalassignment CLOSEBRACE END_OF_STATEMENT ;
    public InterpParser.parallel_return parallel() // throws RecognitionException [1]
    {   
        InterpParser.parallel_return retval = new InterpParser.parallel_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PARALLEL17 = null;
        IToken OPENBRACE19 = null;
        IToken CLOSEBRACE21 = null;
        IToken END_OF_STATEMENT22 = null;
        InterpParser.loop_return loop18 = null;

        InterpParser.matscalassignment_return matscalassignment20 = null;


        object PARALLEL17_tree=null;
        object OPENBRACE19_tree=null;
        object CLOSEBRACE21_tree=null;
        object END_OF_STATEMENT22_tree=null;


        retval.ret = new Parallel_For();

        try 
    	{
            // Interp.g:72:1: ( PARALLEL loop OPENBRACE matscalassignment CLOSEBRACE END_OF_STATEMENT )
            // Interp.g:73:1: PARALLEL loop OPENBRACE matscalassignment CLOSEBRACE END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARALLEL17=(IToken)Match(input,PARALLEL,FOLLOW_PARALLEL_in_parallel295); 
            		PARALLEL17_tree = (object)adaptor.Create(PARALLEL17);
            		adaptor.AddChild(root_0, PARALLEL17_tree);

            	PushFollow(FOLLOW_loop_in_parallel297);
            	loop18 = loop();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, loop18.Tree);
            	   retval.ret.setLhs(((loop18 != null) ? loop18.ret : null));        
            	OPENBRACE19=(IToken)Match(input,OPENBRACE,FOLLOW_OPENBRACE_in_parallel322); 
            		OPENBRACE19_tree = (object)adaptor.Create(OPENBRACE19);
            		adaptor.AddChild(root_0, OPENBRACE19_tree);

            	PushFollow(FOLLOW_matscalassignment_in_parallel331);
            	matscalassignment20 = matscalassignment();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matscalassignment20.Tree);
            	   retval.ret.setRhs(((matscalassignment20 != null) ? matscalassignment20.ret : null));  
            	CLOSEBRACE21=(IToken)Match(input,CLOSEBRACE,FOLLOW_CLOSEBRACE_in_parallel346); 
            		CLOSEBRACE21_tree = (object)adaptor.Create(CLOSEBRACE21);
            		adaptor.AddChild(root_0, CLOSEBRACE21_tree);

            	END_OF_STATEMENT22=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallel348); 
            		END_OF_STATEMENT22_tree = (object)adaptor.Create(END_OF_STATEMENT22);
            		adaptor.AddChild(root_0, END_OF_STATEMENT22_tree);


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
    // $ANTLR end "parallel"

    public class matscalassignment_return : ParserRuleReturnScope
    {
        public MatScalAssignment ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matscalassignment"
    // Interp.g:82:1: matscalassignment returns [ MatScalAssignment ret] : matindex ASSIGNMENT matscaladd END_OF_STATEMENT ;
    public InterpParser.matscalassignment_return matscalassignment() // throws RecognitionException [1]
    {   
        InterpParser.matscalassignment_return retval = new InterpParser.matscalassignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT24 = null;
        IToken END_OF_STATEMENT26 = null;
        InterpParser.matindex_return matindex23 = null;

        InterpParser.matscaladd_return matscaladd25 = null;


        object ASSIGNMENT24_tree=null;
        object END_OF_STATEMENT26_tree=null;


            retval.ret = new MatScalAssignment();

        try 
    	{
            // Interp.g:86:1: ( matindex ASSIGNMENT matscaladd END_OF_STATEMENT )
            // Interp.g:88:1: matindex ASSIGNMENT matscaladd END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matindex_in_matscalassignment367);
            	matindex23 = matindex();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matindex23.Tree);
            	 retval.ret.setLhs(((matindex23 != null) ? matindex23.ret : null)); 
            	ASSIGNMENT24=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matscalassignment373); 
            		ASSIGNMENT24_tree = (object)adaptor.Create(ASSIGNMENT24);
            		adaptor.AddChild(root_0, ASSIGNMENT24_tree);

            	PushFollow(FOLLOW_matscaladd_in_matscalassignment376);
            	matscaladd25 = matscaladd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matscaladd25.Tree);
            	 retval.ret.setRhs(((matscaladd25 != null) ? matscaladd25.ret : null));  
            	END_OF_STATEMENT26=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matscalassignment380); 
            		END_OF_STATEMENT26_tree = (object)adaptor.Create(END_OF_STATEMENT26);
            		adaptor.AddChild(root_0, END_OF_STATEMENT26_tree);


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
    // $ANTLR end "matscalassignment"

    public class matscaladd_return : ParserRuleReturnScope
    {
        public MatScalAdd ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matscaladd"
    // Interp.g:94:1: matscaladd returns [MatScalAdd ret] : el1= variable '+' el2= matindex ;
    public InterpParser.matscaladd_return matscaladd() // throws RecognitionException [1]
    {   
        InterpParser.matscaladd_return retval = new InterpParser.matscaladd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal27 = null;
        InterpParser.variable_return el1 = null;

        InterpParser.matindex_return el2 = null;


        object char_literal27_tree=null;


        retval.ret = new MatScalAdd();

        try 
    	{
            // Interp.g:98:1: (el1= variable '+' el2= matindex )
            // Interp.g:99:1: el1= variable '+' el2= matindex
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_matscaladd401);
            	el1 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal27=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_matscaladd405); 
            		char_literal27_tree = (object)adaptor.Create(char_literal27);
            		adaptor.AddChild(root_0, char_literal27_tree);

            	PushFollow(FOLLOW_matindex_in_matscaladd409);
            	el2 = matindex();
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
    // $ANTLR end "matscaladd"

    public class matindex_return : ParserRuleReturnScope
    {
        public MatIndex ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matindex"
    // Interp.g:104:1: matindex returns [MatIndex ret] : MATINDEX ;
    public InterpParser.matindex_return matindex() // throws RecognitionException [1]
    {   
        InterpParser.matindex_return retval = new InterpParser.matindex_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MATINDEX28 = null;

        object MATINDEX28_tree=null;


        retval.ret = new MatIndex();

        try 
    	{
            // Interp.g:108:1: ( MATINDEX )
            // Interp.g:109:1: MATINDEX
            {
            	root_0 = (object)adaptor.GetNilNode();

            	MATINDEX28=(IToken)Match(input,MATINDEX,FOLLOW_MATINDEX_in_matindex428); 
            		MATINDEX28_tree = (object)adaptor.Create(MATINDEX28);
            		adaptor.AddChild(root_0, MATINDEX28_tree);

            	 retval.ret.setText(((MATINDEX28 != null) ? MATINDEX28.Text : null));  

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
    // $ANTLR end "matindex"

    public class loop_return : ParserRuleReturnScope
    {
        public LoopElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "loop"
    // Interp.g:112:1: loop returns [ LoopElement ret ] : LOOP ;
    public InterpParser.loop_return loop() // throws RecognitionException [1]
    {   
        InterpParser.loop_return retval = new InterpParser.loop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOOP29 = null;

        object LOOP29_tree=null;


         retval.ret = new LoopElement();

        try 
    	{
            // Interp.g:116:1: ( LOOP )
            // Interp.g:117:1: LOOP
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOOP29=(IToken)Match(input,LOOP,FOLLOW_LOOP_in_loop447); 
            		LOOP29_tree = (object)adaptor.Create(LOOP29);
            		adaptor.AddChild(root_0, LOOP29_tree);

            	 retval.ret.setText(LOOP29.Text);   

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
    // $ANTLR end "loop"

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
    // Interp.g:121:1: matdecelement returns [MatDecElement ret] : matvar matval END_OF_STATEMENT ;
    public InterpParser.matdecelement_return matdecelement() // throws RecognitionException [1]
    {   
        InterpParser.matdecelement_return retval = new InterpParser.matdecelement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT32 = null;
        InterpParser.matvar_return matvar30 = null;

        InterpParser.matval_return matval31 = null;


        object END_OF_STATEMENT32_tree=null;


            retval.ret = new MatDecElement();

        try 
    	{
            // Interp.g:125:1: ( matvar matval END_OF_STATEMENT )
            // Interp.g:125:3: matvar matval END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_matdecelement470);
            	matvar30 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matvar30.Tree);
            	 retval.ret.setLhs(((matvar30 != null) ? matvar30.ret : null)); 
            	PushFollow(FOLLOW_matval_in_matdecelement478);
            	matval31 = matval();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, matval31.Tree);
            	 retval.ret.setRhs(((matval31 != null) ? matval31.ret : null)); 
            	END_OF_STATEMENT32=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matdecelement484); 
            		END_OF_STATEMENT32_tree = (object)adaptor.Create(END_OF_STATEMENT32);
            		adaptor.AddChild(root_0, END_OF_STATEMENT32_tree);


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
    // Interp.g:129:1: matvar returns [MatVar ret] : MATVAR ;
    public InterpParser.matvar_return matvar() // throws RecognitionException [1]
    {   
        InterpParser.matvar_return retval = new InterpParser.matvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MATVAR33 = null;

        object MATVAR33_tree=null;


        retval.ret = new MatVar();

        try 
    	{
            // Interp.g:133:1: ( MATVAR )
            // Interp.g:134:1: MATVAR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	MATVAR33=(IToken)Match(input,MATVAR,FOLLOW_MATVAR_in_matvar501); 
            		MATVAR33_tree = (object)adaptor.Create(MATVAR33);
            		adaptor.AddChild(root_0, MATVAR33_tree);

            	 retval.ret.setText(((MATVAR33 != null) ? MATVAR33.Text : null)); 

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
    // Interp.g:136:1: matval returns [MatVal ret] : MATVAL ;
    public InterpParser.matval_return matval() // throws RecognitionException [1]
    {   
        InterpParser.matval_return retval = new InterpParser.matval_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MATVAL34 = null;

        object MATVAL34_tree=null;


        retval.ret = new MatVal();

        try 
    	{
            // Interp.g:140:1: ( MATVAL )
            // Interp.g:141:1: MATVAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	MATVAL34=(IToken)Match(input,MATVAL,FOLLOW_MATVAL_in_matval519); 
            		MATVAL34_tree = (object)adaptor.Create(MATVAL34);
            		adaptor.AddChild(root_0, MATVAL34_tree);

            	 retval.ret.setText(((MATVAL34 != null) ? MATVAL34.Text : null)); 

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
    // Interp.g:144:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable35 = null;

        InterpParser.int_literal_return int_literal36 = null;



        try 
    	{
            // Interp.g:145:3: ( ( variable | int_literal ) )
            // Interp.g:145:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:145:6: ( variable | int_literal )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == VARIABLE) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == INT_LITERAL) )
            	{
            	    alt5 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Interp.g:145:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal538);
            	        	variable35 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable35.Tree);
            	        	 retval.ret = ((variable35 != null) ? variable35.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:146:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal549);
            	        	int_literal36 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal36.Tree);
            	        	retval.ret = ((int_literal36 != null) ? int_literal36.ret : null); 

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
    // Interp.g:149:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE37 = null;

        object VARIABLE37_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:153:3: ( VARIABLE )
            // Interp.g:153:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE37=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable573); 
            		VARIABLE37_tree = (object)adaptor.Create(VARIABLE37);
            		adaptor.AddChild(root_0, VARIABLE37_tree);

            	 retval.ret.setText(((VARIABLE37 != null) ? VARIABLE37.Text : null)); 

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
    // Interp.g:155:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL38 = null;

        object INT_LITERAL38_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:159:3: ( INT_LITERAL )
            // Interp.g:159:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL38=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal594); 
            		INT_LITERAL38_tree = (object)adaptor.Create(INT_LITERAL38);
            		adaptor.AddChild(root_0, INT_LITERAL38_tree);

            	 retval.ret.setText(((INT_LITERAL38 != null) ? INT_LITERAL38.Text : null)); 

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
    // Interp.g:161:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal39 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal39_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:165:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:165:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition617);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal39=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition626); 
            		char_literal39_tree = (object)adaptor.Create(char_literal39);
            		adaptor.AddChild(root_0, char_literal39_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition635);
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
    // Interp.g:169:1: multiplication returns [MultiplicationOperationElement ret] : el1= var_or_int_literal '*' el2= var_or_int_literal ;
    public InterpParser.multiplication_return multiplication() // throws RecognitionException [1]
    {   
        InterpParser.multiplication_return retval = new InterpParser.multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal40 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal40_tree=null;


                retval.ret = new MultiplicationOperationElement();

        try 
    	{
            // Interp.g:173:1: (el1= var_or_int_literal '*' el2= var_or_int_literal )
            // Interp.g:173:3: el1= var_or_int_literal '*' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication657);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal40=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplication663); 
            		char_literal40_tree = (object)adaptor.Create(char_literal40);
            		adaptor.AddChild(root_0, char_literal40_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication671);
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
    // Interp.g:177:1: matmultiplication returns [MatMultiplication ret] : el1= matvar '*' el2= matvar ;
    public InterpParser.matmultiplication_return matmultiplication() // throws RecognitionException [1]
    {   
        InterpParser.matmultiplication_return retval = new InterpParser.matmultiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal41 = null;
        InterpParser.matvar_return el1 = null;

        InterpParser.matvar_return el2 = null;


        object char_literal41_tree=null;


        retval.ret = new MatMultiplication();

        try 
    	{
            // Interp.g:181:1: (el1= matvar '*' el2= matvar )
            // Interp.g:182:1: el1= matvar '*' el2= matvar
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_matmultiplication691);
            	el1 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null));   
            	char_literal41=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_matmultiplication700); 
            		char_literal41_tree = (object)adaptor.Create(char_literal41);
            		adaptor.AddChild(root_0, char_literal41_tree);

            	PushFollow(FOLLOW_matvar_in_matmultiplication704);
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

    public class mataddition_return : ParserRuleReturnScope
    {
        public MatAddition ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mataddition"
    // Interp.g:187:1: mataddition returns [ MatAddition ret] : el1= matvar '+' el2= matvar ;
    public InterpParser.mataddition_return mataddition() // throws RecognitionException [1]
    {   
        InterpParser.mataddition_return retval = new InterpParser.mataddition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal42 = null;
        InterpParser.matvar_return el1 = null;

        InterpParser.matvar_return el2 = null;


        object char_literal42_tree=null;


        retval.ret = new MatAddition();

        try 
    	{
            // Interp.g:191:1: (el1= matvar '+' el2= matvar )
            // Interp.g:192:1: el1= matvar '+' el2= matvar
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_matvar_in_mataddition726);
            	el1 = matvar();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal42=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_mataddition730); 
            		char_literal42_tree = (object)adaptor.Create(char_literal42);
            		adaptor.AddChild(root_0, char_literal42_tree);

            	PushFollow(FOLLOW_matvar_in_mataddition735);
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
    // $ANTLR end "mataddition"

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
    // Interp.g:197:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal43 = null;
        IToken END_OF_STATEMENT45 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal44 = null;


        object string_literal43_tree=null;
        object END_OF_STATEMENT45_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:201:3: ( 'print' var_or_int_literal END_OF_STATEMENT )
            // Interp.g:201:5: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal43=(IToken)Match(input,18,FOLLOW_18_in_print757); 
            		string_literal43_tree = (object)adaptor.Create(string_literal43);
            		adaptor.AddChild(root_0, string_literal43_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print759);
            	var_or_int_literal44 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal44.Tree);
            	retval.ret.setChildElement(((var_or_int_literal44 != null) ? var_or_int_literal44.ret : null)); 
            	END_OF_STATEMENT45=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print767); 
            		END_OF_STATEMENT45_tree = (object)adaptor.Create(END_OF_STATEMENT45);
            		adaptor.AddChild(root_0, END_OF_STATEMENT45_tree);


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

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000042842UL});
    public static readonly BitSet FOLLOW_assignment_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matdecelement_in_expr109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matmul_in_expr119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallel_in_expr131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment157 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment165 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment173 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment184 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_multiplication_in_assignment194 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_matmul227 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matmul232 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_matmultiplication_in_matmul260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mataddition_in_matmul272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARALLEL_in_parallel295 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_loop_in_parallel297 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_OPENBRACE_in_parallel322 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matscalassignment_in_parallel331 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_CLOSEBRACE_in_parallel346 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallel348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matindex_in_matscalassignment367 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matscalassignment373 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_matscaladd_in_matscalassignment376 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matscalassignment380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matscaladd401 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_matscaladd405 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matindex_in_matscaladd409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MATINDEX_in_matindex428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOOP_in_loop447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_matdecelement470 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_matval_in_matdecelement478 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matdecelement484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MATVAR_in_matvar501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MATVAL_in_matval519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition617 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition626 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition635 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication657 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplication663 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_matmultiplication691 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_matmultiplication700 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_matvar_in_matmultiplication704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matvar_in_mataddition726 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_mataddition730 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_matvar_in_mataddition735 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_print757 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print759 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print767 = new BitSet(new ulong[]{0x0000000000000002UL});

}
