using System.Threading.Channels;
namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibraryManagementSystem libraryManagementSystem = new LibraryManagementSystem();
            Console.WriteLine("Enter the number of borrower");
            int numberOfBorrower= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the borrower name");
            string[] borrowerName= new string[numberOfBorrower];
            for(int i = 0; i < numberOfBorrower; i++)
            {
                borrowerName[i] = Console.ReadLine();
            }

            libraryManagementSystem.BorrowerInformation(numberOfBorrower,borrowerName);


            //for issuer information
            Console.WriteLine("Enter the issuer name");
            string issuerName = Console.ReadLine();
            Console.WriteLine("Enter the issuer code");
            string issuerCode = Console.ReadLine();
            libraryManagementSystem.IssuerInformation(issuerName, issuerCode);



            //for making the taken or not







            //creating book collection in library
            Dictionary<string,int> books = new Dictionary<string, int> ();
            books.Add("BhagawatGita", 2);
            books.Add("Ramayan",1);
            books.Add("atomic habit", 0);


            Console.WriteLine("Enter the book name which borrower want");
            string borrowerBookName = Console.ReadLine();


            libraryManagementSystem.BooksAvailableInLibrary(books,borrowerBookName);



           



            // information about book issued already or not available

            //Console.WriteLine("Enter the book name which borrower want");
            //string borrowerBookName= Console.ReadLine();

            //libraryManagementSystem.displayBookIssuedOrNotAvailable(borrowerBookName);


        }
    }
}