using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankLibrary
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main( string[] args )
      {
         Application.EnableVisualStyles();
         Application.Run(new BankUIForm());
      }
   }
}