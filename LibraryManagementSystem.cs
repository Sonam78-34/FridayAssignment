using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryManagementSystem
    {
       //for borrower information of login

        public void BorrowerInformation(int numberOfBorrower,string[] borrowerName)
        {
            
            Dictionary<int, string> borrowerList = new Dictionary<int, string>();
           
            for (int i = 0; i <numberOfBorrower; i++)
            {
                if (numberOfBorrower > 1)
                {
                    
                    borrowerList.Add(i+1, borrowerName[i]);
                }

            }
            Console.WriteLine("The borrowers are : ");
            foreach (KeyValuePair<int, string> keyValue in borrowerList)
            {
                Console.WriteLine("{0}  {1}",keyValue.Key,keyValue.Value);
            }
        }


        public void IssuerInformation(string issuerName, string issuerCode)
        {
            Console.WriteLine("The issuer name is {0} and the code of issuer is {1}", issuerName, issuerCode);


        }



        //Books information
        public void BooksAvailableInLibrary(Dictionary<string,int> books, string borrowerBookName)
        {
            Console.WriteLine(" ");
            Console.WriteLine("The books available in the library are :");
            foreach(KeyValuePair<string, int> book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine(" ");

            
            foreach(var book in books.Keys)
            {
                
                if(book==borrowerBookName)
                {
                    Console.WriteLine("The book is availabe borrower can borrow the book");
                }


            }

            foreach (var count in books.Values)
            {
                
                if (count == 0 && books.ContainsKey(borrowerBookName)) 
                {
                    Console.WriteLine("The book is already taken");
                    
                }
            }

        }

    }
}
