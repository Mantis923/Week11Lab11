using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Lab11
{
    /// Lab-Week2(Graded Assignment)    
    /// File Name: Week11Lab11
    /// Student: Samuel Peppetta
    /// Miracosta college fall 2021
    /// Professor Mark Aokola
    class Program
    {
        ///  class a class is define named Document that contains an instance variable of type string named 
        //  text that stores any textual content for the document.
        // A method is created named ToString() that returns the text field and also include a //method to set this value.
        //Next,A class is defined for Email that is derived from Document and includes instance variables 
        // for the sender, recipient,
        //and title of an email message.An appropriate define setter and getter methods are implemented.
        //The body of the email message is  stored in the inherited variable text.
        //ToString() method is defined is used to concatenate all text fields.
        //Similarly, A class is defined for File that is derived from Document and includes a instance variable for the pathname.
        //The textual contents of the file is stored in the inherited variable text. 
        //Redefine the ToString() method to concatenate all text fields.
        //Finally  2 Email are created and Fileobjects (4 total objects) in the  Main method.
        //The objects Tested by passing them to the following subroutine that returns 
        //true if the object contains the specified keyword in the text property.

        public static bool ContainsKeyword(Document docObject, string keyword) //it takes in a document (look at notes)

        {

            if (docObject.ToString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;

        }
        static void Main(string[] args)
        {

            Email email1 = new Email();
            Email email2 = new Email();

            File file1 = new File();
            File file2 = new File();

            email1.SetText("This is our first text");
            Console.WriteLine(ContainsKeyword(email1, "This is our first text"));

            email2.SetText("This is a email test run");
            email2.SetSender("This is Mike's email");
            email2.SetRecipient(" This is going to Mike's brother");
            email2.Settitle(" Come back home!!!");
            Console.WriteLine();
            Console.WriteLine(ContainsKeyword(email2, "email"));
            Console.WriteLine(ContainsKeyword(email2, "Mike"));
            Console.WriteLine(ContainsKeyword(email2, "going"));
            Console.WriteLine(ContainsKeyword(email2, "home"));
            Console.WriteLine("");
            file1.SetText("This is our first text");
            Console.WriteLine(ContainsKeyword(file1, "text"));

            file2.SetpathName("This Jonathan");
            Console.WriteLine(ContainsKeyword(file2,"Jonathan"));




            Console.ReadLine();
        }
    }
}
