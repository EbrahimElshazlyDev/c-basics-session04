using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Ass._2.C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1
            //int Pages = 464;
            //if (Pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //} 
            #endregion

            #region Q.2
            //int Pages = 464;
            //bool isAvailable = true;
            //if( Pages>300 && isAvailable ==true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Q.3
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //        default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Q.4
            //int Pages = 464;
            //string label = Pages>300 ? "Long Book" : "Short Book";
            //Console.WriteLine(label);
            #endregion

            #region Q.5
            //string[] Books = { "Clean Code","The Pragmatic Programmer" ,"Refactoring" };

            //for (int i = 0; i < Books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} = {Books[i]}");
            //}

            #endregion

            #region Q.6
            // string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < Books.Length)
            //{
            //    Console.WriteLine($"{i + 1} = {Books[i]}");
            //    i++;
            //}


            #endregion

            #region Q.7
            //int Counter = 0;
            //do 
            //{
            // Console.WriteLine("Checking book...");
            //    Counter++;
            //}while (Counter<3);
            #endregion

            #region Q.8
            //string [] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach(string book in Books)
            //{
            //    Console.WriteLine(book);
            //}

            #endregion

            #region Q.9
            //string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < Books.Length; i++)
            //{ 
            // if (Books[i]== "Refactoring")
            // {
            //        break;
            // }
            // Console.WriteLine(Books[i]);

            //}

            #endregion

            #region Q.10
            //string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i=0;  i<Books.Length ; i++ )
            //{
            //    if (Books[i]== "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(Books[i]);
            //}

            #endregion

            #region Q.11
            // string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //   void printfirstBook()
            //   {
            //    if (Books.Length == 0)
            //    {
            //        return;

            //    }
            //    Console.WriteLine(Books[0]);

            //   }
            //printfirstBook();

            #endregion

        }
    }
}
