using System;

namespace Test
{
    class Program
    {
	    delegate string myDelegate(int x);
        static void Main(string[] args)
        {
		myDelegate myfunc = q => {
			string retVal = "My Num = " + q;
			return retVal;
		};
            Console.WriteLine("Hello World! " + myfunc(Convert.ToInt32(args[0])));
        }
    }
}
