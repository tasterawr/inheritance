using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Man
    {
        private string name;
        private int age;
        private int weight;
        private int height;

        public Man(string name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public override string ToString()
        {
            string result = "Имя: " + Name + '\n';
            result += "Возраст: " + Age + '\n';
            result += "Вес: " + Weight + '\n';
            result += "Рост: " + Height + '\n';
            return result;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }
    }
}
