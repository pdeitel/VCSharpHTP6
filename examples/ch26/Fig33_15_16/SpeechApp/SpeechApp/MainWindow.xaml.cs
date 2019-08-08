// Fig. 33.16: MainWindow.xaml.vb
// Text-To-Speech and Speech-To-Text
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Windows;
using System.Windows.Controls;

namespace SpeechApp
{
   public partial class MainWindow : Window
   {
      // listens for speech input                                
      private SpeechRecognizer listener = new SpeechRecognizer();

      // gives the listener choices of possible input
      private Grammar myGrammar;                     

      // sends speech output to the speakers                     
      private SpeechSynthesizer talker = new SpeechSynthesizer();

      // keeps track of which description is to be printed and spoken
      private string displayString;

      // maps images to their descriptions                   
      private Dictionary< Image, string > imageDescriptions =
         new Dictionary< Image, string >();                  

      // maps input phrases to their descriptions              
      private Dictionary< string, string > phraseDescriptions =
         new Dictionary< string, string >();                   

      public MainWindow()
      {
         InitializeComponent();

         // define the input phrases
         string[] phrases = { "Good Programming Practices", 
            "Software Engineering Observations", "Performance Tips",
            "Portability Tips", "Look-And-Feel Observations", 
            "Error-Prevention Tips", "Common Programming Errors" };

         // add the phrases to a Choices collection  
         Choices theChoices = new Choices( phrases );

         // build a Grammar around the Choices and set up the        
         // listener to use this grammar                             
         myGrammar = new Grammar( new GrammarBuilder( theChoices ) );
         listener.Enabled = true;                                    
         listener.LoadGrammar( myGrammar );                          
         myGrammar.SpeechRecognized += myGrammar_SpeechRecognized;   

         // define the descriptions for each icon/phrase
         string[] descriptions = {
            "Good Programming Practices highlight " +
               "techniques for writing programs that are clearer, more " +
               "understandable, more debuggable, and more maintainable.",
            "Software Engineering Observations highlight " +
               "architectural and design issues that affect the " +
               "construction of complex software systems.", 
            "Performance Tips highlight opportunities " +
               "for improving program performance.",
            "Portability Tips help students write " +
               "portable code that can execute on different platforms.",
            "Look-and-Feel Observations highlight " +
               "graphical user interface conventions. These " +
               "observations help students design their own graphical " +
               "user interfaces in conformance with industry standards.",
            "Error-Prevention Tips tell people how to " +
               "test and debug their programs. Many of the tips also " +
               "describe aspects of creating programs that " +
               "reduce the likelihood of 'bugs' and thus simplify the " +
               "testing and debugging process.", 
            "Common Programming Errors focus the " +
               "students' attention on errors commonly made by " +
               "beginning programmers. This helps students avoid " +
               "making the same errors. It also helps reduce the long " +
               "lines outside instructors' offices during " +
               "office hours!" };

         // map each image to its corresponding description
         imageDescriptions.Add( GoodPracticesImage, descriptions[ 0 ] );
         imageDescriptions.Add( ObservationsImage, descriptions[ 1 ] );
         imageDescriptions.Add( PerformanceImage, descriptions[ 2 ] );
         imageDescriptions.Add( PortabilityImage, descriptions[ 3 ] );
         imageDescriptions.Add( LookAndFeelImage, descriptions[ 4 ] );
         imageDescriptions.Add( PreventionImage, descriptions[ 5 ] );
         imageDescriptions.Add( ErrorImage, descriptions[ 6 ] );

         // loop through the phrases and descriptions and map accordingly
         for ( int index = 0; index <= 6; ++index ) 
            phraseDescriptions.Add( phrases[ index ], 
               descriptions[ index ] );

         talker.Rate = -4; // slows down the speaking rate
      } // end constructor

      // when the user clicks on the speech-synthesis button, speak the
      // contents of the related text box
      private void SpeechButton_Click( object sender, RoutedEventArgs e )
      {
         talker.SpeakAsync( SpeechBox.Text );
      } // end method SpeechButton_Click

      private void Image_MouseDown( object sender, 
         System.Windows.Input.MouseButtonEventArgs e )
      {
         // use the image-to-description dictionary to get the 
         // appropriate description for the clicked image
         displayString = imageDescriptions[ (Image) sender ];
         DisplaySpeak();
      } // end method Image_MouseDown

      // when the listener recognizes a phrase from the grammar, set the
      // display string and call DisplaySpeak
      void myGrammar_SpeechRecognized( 
         object sender, RecognitionEventArgs e )
      {
         // Use the phrase-to-description dictionary to get the 
         // appropriate description for the spoken phrase
         displayString = phraseDescriptions[ e.Result.Text ];

         // Use the dispatcher to call displayDetails
         this.Dispatcher.BeginInvoke(                
            new Action( DisplaySpeak ) );            
      } // end method myGrammar_SpeechRecognized

      // Set the appropriate text block to the display string
      // and order the synthesizer to speak it
      void DisplaySpeak()
      {
         InfoBlock.Text = displayString;
         talker.SpeakAsync( displayString );
      } // end method DisplaySpeak
   } // end class MainWindow
} // end namespace SpeechApp

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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