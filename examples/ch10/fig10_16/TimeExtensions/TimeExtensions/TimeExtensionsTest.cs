// Fig. 10.16: TimeExtensionsTest.cs
// Demonstrating extension methods.
using System;

class TimeExtensionsTest
{
   static void Main()
   {
      var myTime = new Time2(); // call Time constructor
      myTime.SetTime(11, 34, 15); // set the time to 11:34:15

      // test the DisplayTime extension method
      Console.Write("Use the DisplayTime extension method: ");
      myTime.DisplayTime();

      // test the AddHours extension method
      Console.Write("Add 5 hours with the AddHours extension method: ");
      var timeAdded = myTime.AddHours(5); // add five hours
      timeAdded.DisplayTime(); // display the new Time2 object

      // add hours and display the time in one statement
      Console.Write("Add 15 hours with the AddHours extension method: ");
      myTime.AddHours(15).DisplayTime(); // add hours and display time

      // use fully qualified extension-method name to display the time
      Console.Write("Use fully qualified extension-method name: ");
      TimeExtensions.DisplayTime(myTime);
   }
}

// extension-methods class
static class TimeExtensions
{
   // display the Time2 object in console
   public static void DisplayTime(this Time2 aTime)
   {
      Console.WriteLine(aTime.ToString());
   }

   // add the specified number of hours to the time
   // and return a new Time2 object
   public static Time2 AddHours(this Time2 aTime, int hours)
   {
      // create a new Time object
      var newTime = new Time2() {
         Minute = aTime.Minute, Second = aTime.Second};

      // add the specified number of hours to the given time
      newTime.Hour = (aTime.Hour + hours) % 24;

      return newTime; // return the new Time2 object
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

