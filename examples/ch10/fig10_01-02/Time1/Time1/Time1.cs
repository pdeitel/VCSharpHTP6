// Fig. 10.1: Time1.cs
// Time1 class declaration maintains the time in 24-hour format.
using System; // namespace containing ArgumentOutOfRangeException

public class Time1
{
   public int Hour { get; set; } // 0 - 23  
   public int Minute { get; set; } // 0 - 59
   public int Second { get; set; } // 0 - 59

   // set a new time value using universal time; throw an 
   // exception if the hour, minute or second is invalid
   public void SetTime(int hour, int minute, int second)
   {
      // validate hour, minute and second
      if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) ||
         (second < 0 || second > 59))
      {
         throw new ArgumentOutOfRangeException();
      }

      Hour = hour;
      Minute = minute;
      Second = second;
   }

   // convert to string in universal-time format (HH:MM:SS)
   public string ToUniversalString() =>
      $"{Hour:D2}:{Minute:D2}:{Second:D2}";

   // convert to string in standard-time format (H:MM:SS AM or PM)
   public override string ToString() =>
      $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
         $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
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
