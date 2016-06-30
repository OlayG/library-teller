using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Media
    {
        public override int RentalLength
        {
            get
            {
                return 7;
            }

            set { }
        }

        public override void PrintMediaDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Book {0} ({1})", Title, Length);
            Console.WriteLine("Rented on: {0}",RentedDate);
            Console.WriteLine("Due on: {0}",ReturnDueDate());
            Console.ResetColor();
        }

        public override DateTime ReturnDueDate()
        {
            return RentedDate.AddDays(RentalLength);
        }
    }
}
