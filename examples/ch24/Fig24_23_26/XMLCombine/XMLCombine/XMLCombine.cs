// Fig. 26.23: XMLCombine.cs
// Transforming an XML document and splicing its contents with another.
using System;
using System.Linq;
using System.Xml.Linq;

class XMLCombine
{
   // namespaces used in XML files
   private static readonly XNamespace employeesOld =
      "http://www.deitel.com/employeesold";
   private static readonly XNamespace employeesNew =
      "http://www.deitel.com/employeesnew";

   static void Main(string[] args)
   {
      // load files from disk
      XDocument newDocument = XDocument.Load("employeesNew.xml");
      XDocument oldDocument = XDocument.Load("employeesOld.xml");

      // convert from old to new format
      oldDocument = TransformDocument(oldDocument);

      // combine documents and write to output file
      SaveFinalDocument(newDocument, oldDocument);

      // tell user we have finished
      Console.WriteLine("Documents successfully combined.");
   }

   // convert the given XDocument in the old format to the new format
   private static XDocument TransformDocument(XDocument document)
   {
      // use a LINQ query to fill the new XML root with the correct data
      var newDocumentRoot = new XElement(employeesNew + "employeelist",
         from employee in document.Root.Elements()
         select TransformEmployee(employee));

      return new XDocument(newDocumentRoot); // return new document
   }

   // transform a single employee's data from old to new format
   private static XElement TransformEmployee(XElement employee)
   {
      // retrieve values from old-format XML document
      XNamespace old = employeesOld; // shorter name
      string firstName = employee.Element(old + "firstname").Value;
      string lastName = employee.Element(old + "lastname").Value;
      string salary = employee.Element(old + "salary").Value;

      // return new-format element with the correct data
      return new XElement(employeesNew + "employee",
         new XAttribute("name", firstName + " " + lastName),
         new XAttribute("salary", salary));
   }

   // take two new-format XDocuments and combine
   // them into one, then save to output.xml
   private static void SaveFinalDocument(XDocument document1,
      XDocument document2)
   {
      // create new root element
      var root = new XElement(employeesNew + "employeelist");

      // fill with the elements contained in the roots of both documents
      root.Add(document1.Root.Elements());
      root.Add(document2.Root.Elements());

      root.Save("output.xml"); // save document to file
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
