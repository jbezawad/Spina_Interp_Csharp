// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-09-27 22:54:37


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
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

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
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
    // $ANTLR end "T__13"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:142:17: ( ';' )
            // Interp.g:142:19: ';'
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
            // Interp.g:143:11: ( '=' )
            // Interp.g:143:13: '='
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
            // Interp.g:144:5: ( '+' )
            // Interp.g:144:7: '+'
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
            // Interp.g:145:9: ( '*' )
            // Interp.g:145:11: '*'
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
            // Interp.g:146:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:146:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:146:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
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
            // Interp.g:147:12: ( ( '0' .. '9' )+ )
            // Interp.g:147:14: ( '0' .. '9' )+
            {
            	// Interp.g:147:14: ( '0' .. '9' )+
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
            			    // Interp.g:147:15: '0' .. '9'
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
            // Interp.g:148:11: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:148:13: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:148:13: ( ' ' | '\\t' | '\\n' | '\\r' )+
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
            // Interp.g:149:7: ( VARIABLE ( '[' ']' )+ )
            // Interp.g:149:9: VARIABLE ( '[' ']' )+
            {
            	mVARIABLE(); 
            	// Interp.g:149:18: ( '[' ']' )+
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
            			    // Interp.g:149:19: '[' ']'
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
            // Interp.g:150:7: ( ( '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']' )+ )
            // Interp.g:150:9: ( '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']' )+
            {
            	// Interp.g:150:9: ( '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']' )+
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
            			    // Interp.g:150:10: '[' ( ( '0' .. '9' ) | ( ',' ) )+ ']'
            			    {
            			    	Match('['); 
            			    	// Interp.g:150:13: ( ( '0' .. '9' ) | ( ',' ) )+
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
            			    			    // Interp.g:150:14: ( '0' .. '9' )
            			    			    {
            			    			    	// Interp.g:150:14: ( '0' .. '9' )
            			    			    	// Interp.g:150:15: '0' .. '9'
            			    			    	{
            			    			    		MatchRange('0','9'); 

            			    			    	}


            			    			    }
            			    			    break;
            			    			case 2 :
            			    			    // Interp.g:150:25: ( ',' )
            			    			    {
            			    			    	// Interp.g:150:25: ( ',' )
            			    			    	// Interp.g:150:26: ','
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

    override public void mTokens() // throws RecognitionException 
    {
        // Interp.g:1:8: ( T__13 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | WHITESPACE | MATVAR | MATVAL )
        int alt7 = 10;
        alt7 = dfa7.Predict(input);
        switch (alt7) 
        {
            case 1 :
                // Interp.g:1:10: T__13
                {
                	mT__13(); 

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

        }

    }


    protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	}

    const string DFA7_eotS =
        "\x01\uffff\x01\x0b\x04\uffff\x01\x0b\x03\uffff\x01\x0b\x02\uffff"+
        "\x02\x0b\x01\x10\x01\uffff";
    const string DFA7_eofS =
        "\x11\uffff";
    const string DFA7_minS =
        "\x01\x09\x01\x41\x04\uffff\x01\x41\x03\uffff\x01\x41\x02\uffff"+
        "\x03\x41\x01\uffff";
    const string DFA7_maxS =
        "\x02\x7a\x04\uffff\x01\x7a\x03\uffff\x01\x7a\x02\uffff\x03\x7a"+
        "\x01\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01\x07\x01"+
        "\x08\x01\x0a\x01\uffff\x01\x06\x01\x09\x03\uffff\x01\x01";
    const string DFA7_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x02\x08\x02\uffff\x01\x08\x12\uffff\x01\x08\x09\uffff\x01"+
            "\x05\x01\x04\x04\uffff\x0a\x07\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x03\x03\uffff\x1a\x06\x01\x09\x05\uffff\x0f\x06\x01\x01\x0a"+
            "\x06",
            "\x1a\x06\x01\x0c\x05\uffff\x11\x06\x01\x0a\x08\x06",
            "",
            "",
            "",
            "",
            "\x1a\x06\x01\x0c\x05\uffff\x1a\x06",
            "",
            "",
            "",
            "\x1a\x06\x01\x0c\x05\uffff\x08\x06\x01\x0d\x11\x06",
            "",
            "",
            "\x1a\x06\x01\x0c\x05\uffff\x0d\x06\x01\x0e\x0c\x06",
            "\x1a\x06\x01\x0c\x05\uffff\x13\x06\x01\x0f\x06\x06",
            "\x1a\x06\x01\x0c\x05\uffff\x1a\x06",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__13 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | WHITESPACE | MATVAR | MATVAL );"; }
        }

    }

 
    
}
