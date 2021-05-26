using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class exceptionhandling
    {
        public void trycatchmethod(int a,int b)
        {
            try
            { 
                int x = a;
                int y = b;
                Console.WriteLine("RESULT IS:{0}",x/y);
            }
            catch(FormatException )
            {
                Console.WriteLine("Input was not in correct format");
            }
            catch(InvalidOperationException )
            {
                Console.WriteLine("Given input is not valid to perform operation");
            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }
    }
}
