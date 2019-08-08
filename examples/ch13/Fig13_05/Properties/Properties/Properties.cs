// Fig. 13.5: Properties.cs
// Stack unwinding and Exception class properties.
// Demonstrates using properties Message, StackTrace and InnerException.
using System;

class Properties
{
   static void Main()
   {
      // call Method1; any Exception generated is caught
      // in the catch block that follows
      try
      {
         Method1();
      }
      catch (Exception exceptionParameter)
      {
         // output the string representation of the Exception, then output
         // properties Message, StackTrace and InnerException
         Console.WriteLine("exceptionParameter.ToString: \n" +
            exceptionParameter);
         Console.WriteLine("\nexceptionParameter.Message: \n" +
            exceptionParameter.Message);
         Console.WriteLine("\nexceptionParameter.StackTrace: \n" +
            exceptionParameter.StackTrace);
         Console.WriteLine("\nexceptionParameter.InnerException: \n" +
            exceptionParameter.InnerException);
      }
   }

   // calls Method2
   static void Method1()
   {
      Method2();
   }

   // calls Method3
   static void Method2()
   {
      Method3();
   }

   // throws an Exception containing an InnerException
   static void Method3()
   {
      // attempt to convert string to int
      try
      {
         int.Parse("Not an integer");
      }
      catch (FormatException formatExceptionParameter)
      {
         // wrap FormatException in new Exception
         throw new Exception("Exception occurred in Method3",
            formatExceptionParameter);
      }
   }
}



/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/
