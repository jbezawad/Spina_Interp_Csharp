                       Small Parallel Interpreter For Numerical Analysis
                       -------------------------------------------------

The spina program contains the following syntax supporting the given features.


1) Loads and saves the spina file.
2) Allows the user to input text if he wants so.
3) Supports the variable and matrix input.
4) supports the scalar variable multiplication.
5) supports the matrix multiplication and matrix addition
6) performs the task of matrix multiplication and matrix addition using threads.
7) performs the task of parallel_for using threads.
8) supports the task of 7 for a single dimension array 

and only the following kind of assignment 
matindex = scalar + matindex

9) The project is developed using C# and antlr3 parser code.
10) Uses winforms for the front end.
11) Contains a sample program second.spina which can be loaded and executed in the interpreter
which allows all the above features.
12) reports errors in dimensions to the users.


                                        Syntax Support
                                        --------------

1. variable = scalar value;
2. variable = variable + variable;
3. matvariable[][]  [ (INT_LITERAL ',' )+ ]+... // matrix declaration or input
4. matvariable[][] = matvariable[][] *  matvariable[][];
5. matvariable[][] = matvariable[][] +  matvariable[][];
6. print matvariable;
7. print scalar;
8. parallel_for (var lowerlimit..upperlimit){ mat[var] = scalarvariable + mat[var]; }
9. variable = variable * variable;

                                       Sample Program
                                        ------------

  The sample program is "Second.spina" that is present in the project folder itself.

                                       TestStub
                                       ---------

The test stub is present in MatMultiplicationOperationElement.cs    file.
 
  



