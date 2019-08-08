// Fig. 12.12: Invoice.cs
// Invoice class implements IPayable.
using System;

public class Invoice : IPayable
{
   public string PartNumber { get; }
   public string PartDescription { get; }
   private int quantity;
   private decimal pricePerItem;

   // four-parameter constructor
   public Invoice(string partNumber, string partDescription, int quantity,
      decimal pricePerItem)
   {
      PartNumber = partNumber;
      PartDescription = partDescription;
      Quantity = quantity; // validate quantity 
      PricePerItem = pricePerItem; // validate price per item 
   }

   // property that gets and sets the quantity on the invoice
   public int Quantity
   {
      get
      {
         return quantity;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Quantity)} must be >= 0");
         }

         quantity = value;
      }
   }

   // property that gets and sets the price per item
   public decimal PricePerItem
   {
      get
      {
         return pricePerItem;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(PricePerItem)} must be >= 0");
         }

         pricePerItem = value;
      }
   }

   // return string representation of Invoice object
   public override string ToString() =>
      $"invoice:\npart number: {PartNumber} ({PartDescription})\n" +
      $"quantity: {Quantity}\nprice per item: {PricePerItem:C}";

   // method required to carry out contract with interface IPayable
   public decimal GetPaymentAmount() => Quantity * PricePerItem;
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
