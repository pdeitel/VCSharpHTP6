// Fig. 13.4: UsingExceptions.cs
// finally blocks always execute, even when no exception occurs.

using System;

class UsingExceptions
{
   static void Main()
   {
      // Case 1: No exceptions occur in called method
      Console.WriteLine("Calling DoesNotThrowException");
      DoesNotThrowException();

      // Case 2: Exception occurs and is caught in called method
      Console.WriteLine("\nCalling ThrowExceptionWithCatch");
      ThrowExceptionWithCatch();

      // Case 3: Exception occurs, but is not caught in called method 
      // because there is no catch block.
      Console.WriteLine("\nCalling ThrowExceptionWithoutCatch");

      // call ThrowExceptionWithoutCatch
      try
      {
         ThrowExceptionWithoutCatch();
      }
      catch
      {
         Console.WriteLine(
            "Caught exception from ThrowExceptionWithoutCatch in Main");
      }

      // Case 4: Exception occurs and is caught in called method,
      // then rethrown to caller.
      Console.WriteLine("\nCalling ThrowExceptionCatchRethrow");

      // call ThrowExceptionCatchRethrow
      try
      {
         ThrowExceptionCatchRethrow();
      }
      catch
      {
         Console.WriteLine(
            "Caught exception from ThrowExceptionCatchRethrow in Main");
      }
   }

   // no exceptions thrown
   static void DoesNotThrowException()
   {
      // try block does not throw any exceptions 
      try
      {
         Console.WriteLine("In DoesNotThrowException");
      }
      catch
      {
         Console.WriteLine("This catch never executes");
      }
      finally
      {
         Console.WriteLine("finally executed in DoesNotThrowException");
      }

      Console.WriteLine("End of DoesNotThrowException");
   }

   // throws exception and catches it locally
   static void ThrowExceptionWithCatch()
   {
      // try block throws exception
      try
      {
         Console.WriteLine("In ThrowExceptionWithCatch");
         throw new Exception("Exception in ThrowExceptionWithCatch");
      }
      catch (Exception exceptionParameter)
      {
         Console.WriteLine($"Message: {exceptionParameter.Message}");
      }
      finally
      {
         Console.WriteLine(
            "finally executed in ThrowExceptionWithCatch");
      }

      Console.WriteLine("End of ThrowExceptionWithCatch");
   }

   // throws exception and does not catch it locally
   static void ThrowExceptionWithoutCatch()
   {
      // throw exception, but do not catch it
      try
      {
         Console.WriteLine("In ThrowExceptionWithoutCatch");
         throw new Exception("Exception in ThrowExceptionWithoutCatch");
      }
      finally
      {
         Console.WriteLine(
            "finally executed in ThrowExceptionWithoutCatch");
      }

      // unreachable code; logic error 
      Console.WriteLine("End of ThrowExceptionWithoutCatch");
   }

   // throws exception, catches it and rethrows it
   static void ThrowExceptionCatchRethrow()
   {
      // try block throws exception
      try
      {
         Console.WriteLine("In ThrowExceptionCatchRethrow");
         throw new Exception("Exception in ThrowExceptionCatchRethrow");
      }
      catch (Exception exceptionParameter)
      {
         Console.WriteLine("Message: " + exceptionParameter.Message);

         // rethrow exception for further processing
         throw;

         // unreachable code; logic error
      }
      finally
      {
         Console.WriteLine(
            "finally executed in ThrowExceptionCatchRethrow");
      }

      // any code placed here is never reached
      Console.WriteLine("End of ThrowExceptionCatchRethrow");
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
