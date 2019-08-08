// Fig. 6.12: AutoPolicyTest.java
// Demonstrating strings in switch.
using System;

class AutoPolicyTest
{
   static void Main()
   {
      // create two AutoPolicy objects
      AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
      AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");

      // display whether each policy is in a no-fault state
      PolicyInNoFaultState(policy1);
      PolicyInNoFaultState(policy2);
   }

   // method that displays whether an AutoPolicy 
   // is in a state with no-fault auto insurance 
   public static void PolicyInNoFaultState(AutoPolicy policy)
   {
      Console.WriteLine("The auto policy:");
      Console.Write($"Account #: {policy.AccountNumber}; ");
      Console.WriteLine($"Car: {policy.MakeAndModel};");
      Console.Write($"State {policy.State}; ");
      Console.Write($"{(policy.IsNoFaultState ? "is": " is not")}");
      Console.WriteLine(" a no-fault state\n");
   }
}
