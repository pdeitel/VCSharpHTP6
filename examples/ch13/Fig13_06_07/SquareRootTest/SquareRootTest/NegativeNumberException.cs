// Fig. 13.6: NegativeNumberException.cs
// NegativeNumberException represents exceptions caused by
// illegal operations performed on negative numbers.
using System;

public class NegativeNumberException : Exception
{
   // default constructor                                
   public NegativeNumberException()
      : base("Illegal operation for a negative number")
   {
      // empty body                                      
   }

   // constructor for customizing error message         
   public NegativeNumberException(string messageValue)
      : base(messageValue)
   {
      // empty body                                     
   }

   // constructor for customizing the exception's error
   // message and specifying the InnerException object 
   public NegativeNumberException(string messageValue, Exception inner)
      : base(messageValue, inner)
   {
      // empty body                                    
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
