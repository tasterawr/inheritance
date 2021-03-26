using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public static class BookValidator
    {
        private static string error_message;

        public static bool ValidateBookData(int num_of_pages, int publ_date, int completion_date)
        {
            try
            {
                if (num_of_pages < 0 || completion_date > publ_date)
                {
                    throw new Exception("Указаны некорректные числовые параметры.");
                }

                return true;
            }
            catch (Exception e)
            {
                error_message = "Указаны некорректные числовые параметры.";
                return false;
            }
        }

        public static void DisplayError()
        {
            Console.WriteLine("Ошибка: {0}", error_message);
        }
    }
}
