// Fig. 10.6: Time2Test.cs
// Overloaded constructors used to initialize Time2 objects.
using System;

public class Time2Test
{
   static void Main()
   {
      var t1 = new Time2(); // 00:00:00            
      var t2 = new Time2(2); // 02:00:00         
      var t3 = new Time2(21, 34); // 21:34:00    
      var t4 = new Time2(12, 25, 42); // 12:25:42
      var t5 = new Time2(t4); // 12:25:42        

      Console.WriteLine("Constructed with:\n");
      Console.WriteLine("t1: all arguments defaulted");
      Console.WriteLine($"   {t1.ToUniversalString()}"); // 00:00:00
      Console.WriteLine($"   {t1.ToString()}\n"); // 12:00:00 AM

      Console.WriteLine(
         "t2: hour specified; minute and second defaulted");
      Console.WriteLine($"   {t2.ToUniversalString()}"); // 02:00:00
      Console.WriteLine($"   {t2.ToString()}\n"); // 2:00:00 AM

      Console.WriteLine(
         "t3: hour and minute specified; second defaulted");
      Console.WriteLine($"   {t3.ToUniversalString()}"); // 21:34:00
      Console.WriteLine($"   {t3.ToString()}\n"); // 9:34:00 PM

      Console.WriteLine("t4: hour, minute and second specified");
      Console.WriteLine($"   {t4.ToUniversalString()}"); // 12:25:42
      Console.WriteLine($"   {t4.ToString()}\n"); // 12:25:42 PM

      Console.WriteLine("t5: Time2 object t4 specified");
      Console.WriteLine($"   {t5.ToUniversalString()}"); // 12:25:42
      Console.WriteLine($"   {t5.ToString()}"); // 12:25:42 PM

      // attempt to initialize t6 with invalid values
      try
      {
         var t6 = new Time2(27, 74, 99); // invalid values
      }
      catch (ArgumentOutOfRangeException ex)
      {
         Console.WriteLine("\nException while initializing t6:");
         Console.WriteLine(ex.Message);
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
 *************************************************************************/
