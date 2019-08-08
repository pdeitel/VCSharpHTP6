// Fig. 6.11: AutoPolicy.cs
// Class that represents an auto insurance policy.
class AutoPolicy
{
   public int AccountNumber { get; set; } // policy account number
   public string MakeAndModel { get; set; } // car that policy applies to
   public string State { get; set; } // two-letter state abbreviation

   // constructor
   public AutoPolicy(int accountNumber, string makeAndModel, string state)
   {
      AccountNumber = accountNumber;
      MakeAndModel = makeAndModel;
      State = state;
   }

   // returns whether the state has no-fault insurance
   public bool IsNoFaultState
   {
      get
      {
         bool noFaultState;

         // determine whether state has no-fault auto insurance           
         switch (State) // get AutoPolicy object's state abbreviation
         {
            case "MA": case "NJ": case "NY": case "PA":
               noFaultState = true;
               break;
            default:
               noFaultState = false;
               break;
         }

         return noFaultState;
      }
   }
}
