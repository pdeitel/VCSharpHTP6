// Fig. 10.7: Date.cs 
// Date class declaration.
using System;

public class Date
{
   private int month; // 1-12
   private int day; // 1-31 based on month
   public int Year { get; private set; } // auto-implemented property Year

   // constructor: use property Month to confirm proper value for month; 
   // use property Day to confirm proper value for day
   public Date(int month, int day, int year)
   {
      Month = month; // validates month
      Year = year; // could validate year
      Day = day; // validates day
      Console.WriteLine($"Date object constructor for date {this}");
   }

   // property that gets and sets the month
   public int Month
   {
      get
      {
         return month;
      }
      private set // make writing inaccessible outside the class
      {
         if (value <= 0 || value > 12) // validate month
         {
            throw new ArgumentOutOfRangeException(
               nameof(value), value, $"{nameof(Month)} must be 1-12");
         }

         month = value;
      }
   }

   // property that gets and sets the day
   public int Day
   {
      get
      {
         return day;
      }
      private set // make writing inaccessible outside the class
      {
         int[] daysPerMonth =
            {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

         // check if day in range for month
         if (value <= 0 || value > daysPerMonth[Month])
         {
            throw new ArgumentOutOfRangeException(nameof(value), value,
               $"{nameof(Day)} out of range for current month/year");
         }
         // check for leap year
         if (Month == 2 && value == 29 &&
            !(Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
         {
            throw new ArgumentOutOfRangeException(nameof(value), value,
               $"{nameof(Day)} out of range for current month/year");
         }

         day = value;
      }
   }

   // return a string of the form month/day/year
   public override string ToString() => $"{Month}/{Day}/{Year}";
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
