using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public static class HumanValidator
    {
        private static string error_message;
        public static bool ValidateManData(int age, int weight, int height)
        {
            try
            {
                if (age < 0 || weight < 0 || height < 0)
                {
                    throw new Exception("Указан отрицательный числовой параметр.");
                }

                return true;
            }
            catch(Exception e)
            {
                error_message = "Указан отрицательный числовой параметр.";
                return false;
            }
        }

        public static bool ValidateStudentData(int age, int weight, int height, int course)
        {
            if (!ValidateManData(age, weight, height))
                return false;
            else
                try
                {
                    if (course < 0 || course > 7)
                    {
                        throw new Exception("Указан несуществующий номер курса.");
                    }

                    return true;
                }
                catch (Exception e)
                {
                    error_message = "Указан несуществующий номер курса.";
                    return false;
                }

        }

        public static void DisplayError()
        {
            Console.WriteLine("Ошибка: {0}", error_message);
        }
    }
}
