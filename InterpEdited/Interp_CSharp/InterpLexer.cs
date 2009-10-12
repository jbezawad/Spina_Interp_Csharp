// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-12 16:05:43


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
    public const int MATVAR = 11;
    public const int OPENBRACE = 7;
    public const int INT_LITERAL = 14;
    public const int T__18 = 18;
    public const int MATVAL = 12;
    public const int VARIABLE = 13;
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

    public InterpLexer() 
    {
		InitializeCyclicDFAs();
    }
    public InterpLexer(ICharStream input)
		: this(input, null) {
    }
    public InterpLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Interp.g";} 
    }

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( 'print' )
            // Interp.g:11:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:208:17: ( ';' )
            // Interp.g:208:19: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END_OF_STATEMENT"

    // $ANTLR start "ASSIGNMENT"
    public void mASSIGNMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:209:11: ( '=' )
            // Interp.g:209:13: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGNMENT"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:210:5: ( '+' )
            // Interp.g:210:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MULTIPLY"
    public void mMULTIPLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTIPLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:211:9: ( '*' )
            // Interp.g:211:11: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTIPLY"

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:212:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:212:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:212:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


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

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VARIABLE"

    // $ANTLR start "INT_LITERAL"
    public void mINT_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:213:12: ( ( '0' .. '9' )+ )
            // Interp.g:213:14: ( '0' .. '9' )+
            {
            	// Interp.g:213:14: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Interp.g:213:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:214:11: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:214:13: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:214:13: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	_channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "MATVAR"
    public void mMATVAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MATVAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:215:7: ( VARIABLE ( '[' ']' )+ )
            // Interp.g:215:9: VARIABLE ( '[' ']' )+
            {
            	mVARIABLE(); 
            	// Interp.g:215:18: ( '[' ']' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == '[') )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // Interp.g:215:19: '[' ']'
            			    {
            			    	Match('['); 
            			    	Match(']'); 

            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MATVAR"

    // $ANTLR start "MATVAL"
    public void mMATVAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MATVAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:216:7: ( ( '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']' )+ )
            // Interp.g:216:9: ( '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']' )+
            {
            	// Interp.g:216:9: ( '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']' )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == '[') )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // Interp.g:216:10: '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']'
            			    {
            			    	Match('['); 
            			    	// Interp.g:216:13: ( ( '0' .. '9' ) | ( ',' ) )+
            			    	int cnt5 = 0;
            			    	do 
            			    	{
            			    	    int alt5 = 3;
            			    	    int LA5_0 = input.LA(1);

            			    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            			    	    {
            			    	        alt5 = 1;
            			    	    }
            			    	    else if ( (LA5_0 == ',') )
            			    	    {
            			    	        alt5 = 2;
            			    	    }


            			    	    switch (alt5) 
            			    		{
            			    			case 1 :
            			    			    // Interp.g:216:14: ( '0' .. '9' )
            			    			    {
            			    			    	// Interp.g:216:14: ( '0' .. '9' )
            			    			    	// Interp.g:216:15: '0' .. '9'
            			    			    	{
            			    			    		MatchRange('0','9'); 

            			    			    	}


            			    			    }
            			    			    break;
            			    			case 2 :
            			    			    // Interp.g:216:25: ( ',' )
            			    			    {
            			    			    	// Interp.g:216:25: ( ',' )
            			    			    	// Interp.g:216:26: ','
            			    			    	{
            			    			    		Match(','); 

            			    			    	}


            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt5 >= 1 ) goto loop5;
            			    		            EarlyExitException eee5 =
            			    		                new EarlyExitException(5, input);
            			    		            throw eee5;
            			    	    }
            			    	    cnt5++;
            			    	} while (true);

            			    	loop5:
            			    		;	// Stops C# compiler whining that label 'loop5' has no statements

            			    	Match(']'); 

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MATVAL"

    // $ANTLR start "PARALLEL"
    public void mPARALLEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARALLEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:217:9: ( ( 'parallel_for' ) )
            // Interp.g:217:11: ( 'parallel_for' )
            {
            	// Interp.g:217:11: ( 'parallel_for' )
            	// Interp.g:217:12: 'parallel_for'
            	{
            		Match("parallel_for"); 


            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARALLEL"

    // $ANTLR start "LOOP"
    public void mLOOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LOOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:218:5: ( ( '(' VARIABLE ' ' INT_LITERAL '..' INT_LITERAL ')' ) )
            // Interp.g:218:7: ( '(' VARIABLE ' ' INT_LITERAL '..' INT_LITERAL ')' )
            {
            	// Interp.g:218:7: ( '(' VARIABLE ' ' INT_LITERAL '..' INT_LITERAL ')' )
            	// Interp.g:218:8: '(' VARIABLE ' ' INT_LITERAL '..' INT_LITERAL ')'
            	{
            		Match('('); 
            		mVARIABLE(); 
            		Match(' '); 
            		mINT_LITERAL(); 
            		Match(".."); 

            		mINT_LITERAL(); 
            		Match(')'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LOOP"

    // $ANTLR start "OPENBRACE"
    public void mOPENBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPENBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:219:10: ( ( '{' ) )
            // Interp.g:219:12: ( '{' )
            {
            	// Interp.g:219:12: ( '{' )
            	// Interp.g:219:13: '{'
            	{
            		Match('{'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPENBRACE"

    // $ANTLR start "CLOSEBRACE"
    public void mCLOSEBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLOSEBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:220:11: ( ( '}' ) )
            // Interp.g:220:12: ( '}' )
            {
            	// Interp.g:220:12: ( '}' )
            	// Interp.g:220:13: '}'
            	{
            		Match('}'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLOSEBRACE"

    // $ANTLR start "MATINDEX"
    public void mMATINDEX() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MATINDEX;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:221:9: ( ( VARIABLE ( '[' ( INT_LITERAL | VARIABLE ) ']' )+ ) )
            // Interp.g:221:11: ( VARIABLE ( '[' ( INT_LITERAL | VARIABLE ) ']' )+ )
            {
            	// Interp.g:221:11: ( VARIABLE ( '[' ( INT_LITERAL | VARIABLE ) ']' )+ )
            	// Interp.g:221:12: VARIABLE ( '[' ( INT_LITERAL | VARIABLE ) ']' )+
            	{
            		mVARIABLE(); 
            		// Interp.g:221:21: ( '[' ( INT_LITERAL | VARIABLE ) ']' )+
            		int cnt8 = 0;
            		do 
            		{
            		    int alt8 = 2;
            		    int LA8_0 = input.LA(1);

            		    if ( (LA8_0 == '[') )
            		    {
            		        alt8 = 1;
            		    }


            		    switch (alt8) 
            			{
            				case 1 :
            				    // Interp.g:221:22: '[' ( INT_LITERAL | VARIABLE ) ']'
            				    {
            				    	Match('['); 
            				    	// Interp.g:221:26: ( INT_LITERAL | VARIABLE )
            				    	int alt7 = 2;
            				    	int LA7_0 = input.LA(1);

            				    	if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
            				    	{
            				    	    alt7 = 1;
            				    	}
            				    	else if ( ((LA7_0 >= 'A' && LA7_0 <= 'Z') || (LA7_0 >= 'a' && LA7_0 <= 'z')) )
            				    	{
            				    	    alt7 = 2;
            				    	}
            				    	else 
            				    	{
            				    	    NoViableAltException nvae_d7s0 =
            				    	        new NoViableAltException("", 7, 0, input);

            				    	    throw nvae_d7s0;
            				    	}
            				    	switch (alt7) 
            				    	{
            				    	    case 1 :
            				    	        // Interp.g:221:27: INT_LITERAL
            				    	        {
            				    	        	mINT_LITERAL(); 

            				    	        }
            				    	        break;
            				    	    case 2 :
            				    	        // Interp.g:221:41: VARIABLE
            				    	        {
            				    	        	mVARIABLE(); 

            				    	        }
            				    	        break;

            				    	}

            				    	Match(']'); 

            				    }
            				    break;

            				default:
            				    if ( cnt8 >= 1 ) goto loop8;
            			            EarlyExitException eee8 =
            			                new EarlyExitException(8, input);
            			            throw eee8;
            		    }
            		    cnt8++;
            		} while (true);

            		loop8:
            			;	// Stops C# compiler whining that label 'loop8' has no statements


            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MATINDEX"

    override public void mTokens() // throws RecognitionException 
    {
        // Interp.g:1:8: ( T__18 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | WHITESPACE | MATVAR | MATVAL | PARALLEL | LOOP | OPENBRACE | CLOSEBRACE | MATINDEX )
        int alt9 = 15;
        alt9 = dfa9.Predict(input);
        switch (alt9) 
        {
            case 1 :
                // Interp.g:1:10: T__18
                {
                	mT__18(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 3 :
                // Interp.g:1:33: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 4 :
                // Interp.g:1:44: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 5 :
                // Interp.g:1:49: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 6 :
                // Interp.g:1:58: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 7 :
                // Interp.g:1:67: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 8 :
                // Interp.g:1:79: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;
            case 9 :
                // Interp.g:1:90: MATVAR
                {
                	mMATVAR(); 

                }
                break;
            case 10 :
                // Interp.g:1:97: MATVAL
                {
                	mMATVAL(); 

                }
                break;
            case 11 :
                // Interp.g:1:104: PARALLEL
                {
                	mPARALLEL(); 

                }
                break;
            case 12 :
                // Interp.g:1:113: LOOP
                {
                	mLOOP(); 

                }
                break;
            case 13 :
                // Interp.g:1:118: OPENBRACE
                {
                	mOPENBRACE(); 

                }
                break;
            case 14 :
                // Interp.g:1:128: CLOSEBRACE
                {
                	mCLOSEBRACE(); 

                }
                break;
            case 15 :
                // Interp.g:1:139: MATINDEX
                {
                	mMATINDEX(); 

                }
                break;

        }

    }


    protected DFA9 dfa9;
	private void InitializeCyclicDFAs()
	{
	    this.dfa9 = new DFA9(this);
	}

    const string DFA9_eotS =
        "\x01\uffff\x01\x0f\x04\uffff\x01\x0f\x06\uffff\x02\x0f\x02\uffff"+
        "\x02\x0f\x02\uffff\x02\x0f\x01\x19\x01\x0f\x01\uffff\x03\x0f\x01"+
        "\uffff";
    const string DFA9_eofS =
        "\x1e\uffff";
    const string DFA9_minS =
        "\x01\x09\x01\x41\x04\uffff\x01\x41\x06\uffff\x02\x41\x01\uffff"+
        "\x01\x30\x02\x41\x02\uffff\x04\x41\x01\uffff\x03\x41\x01\uffff";
    const string DFA9_maxS =
        "\x01\x7d\x01\x7a\x04\uffff\x01\x7a\x06\uffff\x02\x7a\x01\uffff"+
        "\x03\x7a\x02\uffff\x04\x7a\x01\uffff\x03\x7a\x01\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0c\x01\x0d\x01\x0e\x02\uffff\x01\x06\x03\uffff"+
        "\x01\x09\x01\x0f\x04\uffff\x01\x01\x03\uffff\x01\x0b";
    const string DFA9_specialS =
        "\x1e\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x02\x08\x02\uffff\x01\x08\x12\uffff\x01\x08\x07\uffff\x01"+
            "\x0a\x01\uffff\x01\x05\x01\x04\x04\uffff\x0a\x07\x01\uffff\x01"+
            "\x02\x01\uffff\x01\x03\x03\uffff\x1a\x06\x01\x09\x05\uffff\x0f"+
            "\x06\x01\x01\x0a\x06\x01\x0b\x01\uffff\x01\x0c",
            "\x1a\x06\x01\x10\x05\uffff\x01\x0e\x10\x06\x01\x0d\x08\x06",
            "",
            "",
            "",
            "",
            "\x1a\x06\x01\x10\x05\uffff\x1a\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1a\x06\x01\x10\x05\uffff\x08\x06\x01\x11\x11\x06",
            "\x1a\x06\x01\x10\x05\uffff\x11\x06\x01\x12\x08\x06",
            "",
            "\x0a\x14\x07\uffff\x1a\x14\x02\uffff\x01\x13\x03\uffff\x1a"+
            "\x14",
            "\x1a\x06\x01\x10\x05\uffff\x0d\x06\x01\x15\x0c\x06",
            "\x1a\x06\x01\x10\x05\uffff\x01\x16\x19\x06",
            "",
            "",
            "\x1a\x06\x01\x10\x05\uffff\x13\x06\x01\x17\x06\x06",
            "\x1a\x06\x01\x10\x05\uffff\x0b\x06\x01\x18\x0e\x06",
            "\x1a\x06\x01\x10\x05\uffff\x1a\x06",
            "\x1a\x06\x01\x10\x05\uffff\x0b\x06\x01\x1a\x0e\x06",
            "",
            "\x1a\x06\x01\x10\x05\uffff\x04\x06\x01\x1b\x15\x06",
            "\x1a\x06\x01\x10\x05\uffff\x0b\x06\x01\x1c\x0e\x06",
            "\x1a\x06\x01\x10\x03\uffff\x01\x1d\x01\uffff\x1a\x06",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__18 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | WHITESPACE | MATVAR | MATVAL | PARALLEL | LOOP | OPENBRACE | CLOSEBRACE | MATINDEX );"; }
        }

    }

 
    
}
