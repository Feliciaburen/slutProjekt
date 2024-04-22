using System.ComponentModel;
using System.Linq.Expressions;

namespace slutProjekt;

class Program
{
    static void Main(string[] args)
    {
        // create the cart, library, admin and borrower 
        Cart cart = new Cart();
        Library library = new Library();
        Admin admin = new Admin();
        Borrower borrower = new Borrower(library);

        // loop the log in menu
        while true
        {
            Console.WriteLine("Login\n");
            Console.WriteLine("1. Cart");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Borrower");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Write the number of your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    cart.CartMenu();
                    break;

                case 2: 
                    Console.Clear();
                    admin.AdminMenu();
                    break;

                case 3:
                    Console.Clear();
                    borrower.BorrowerMenu();
                    break;

                case 4: 
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
        
    }
}
