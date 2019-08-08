// Fig. 10.5: Time2.cs
// Time2 class declaration with overloaded constructors.  
using System; // for class ArgumentOutOfRangeException

public class Time2
{
   private int hour; // 0 - 23
   private int minute; // 0 - 59
   private int second; // 0 - 59

   // constructor can be called with zero, one, two or three arguments
   public Time2(int hour = 0, int minute = 0, int second = 0)
   {
      SetTime(hour, minute, second); // invoke SetTime to validate time
   }

   // Time2 constructor: another Time2 object supplied as an argument
   public Time2(Time2 time)
      : this(time.Hour, time.Minute, time.Second) { }

   // set a new time value using universal time; invalid values
   // cause the properties' set accessors to throw exceptions
   public void SetTime(int hour, int minute, int second)
   {
      Hour = hour; // set the Hour property
      Minute = minute; // set the Minute property
      Second = second; // set the Second property
   }

   // property that gets and sets the hour
   public int Hour
   {
      get
      {
         return hour;
      }
      set
      {
         if (value < 0 || value > 23)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Hour)} must be 0-23");
         }

         hour = value;
      }
   }

   // property that gets and sets the minute
   public int Minute
   {
      get
      {
         return minute;
      }
      set
      {
         if (value < 0 || value > 59)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Minute)} must be 0-59");
         }

         minute = value;
      }
   }

   // property that gets and sets the second
   public int Second
   {
      get
      {
         return second;
      }
      set
      {
         if (value < 0 || value > 59)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Second)} must be 0-59");
         }

         second = value;
      }
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
