using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Man
    {
        private int year;
        private int course;
        private int gr_number;

        public Student(string name, int age, int weight, int height, 
            int year, int course, int gr_number) : base(name, age, weight, height)
        {
            this.year = year;
            this.course = course;
            this.gr_number = gr_number;
        }

        public override string ToString()
        {
            string result = "Имя: " + Name + '\n';
            result += "Возраст: " + Age + '\n';
            result += "Вес: " + Weight + '\n';
            result += "Рост: " + Height + '\n';
            result += "Год поступления: " + Year + '\n';
            result += "Курс: " + Course + '\n';
            result += "Номер группы: " + GroupNumber + '\n';
            return result;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public int Course
        {
            get => course;
            set => course = value;
        }

        public int GroupNumber
        {
            get => gr_number;
            set => gr_number = value;
        }
    }
}
