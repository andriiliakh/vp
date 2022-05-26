using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Student
    {
        public string surname { get; }
        public string name { get; }
        public string city { get; }
        public int ukr { get; }
        public int math { get; }
        public int eng { get; }

        public Student()
        {
            surname = "";
            name = "";
            city = "";
            ukr = -1;
            math = -1;
            eng = -1;
        }

        public Student(string surname, string name, string city, int ukr, int math, int eng)
        {
            this.surname = surname;
            this.name = name;
            this.city = city;
            this.ukr = ukr;
            this.math = math;
            this.eng = eng;
        }

        public Student(string input)
        {
            String ttry;
            Console.WriteLine("Construct worker from: " + input);
            if (input.Length < 9)
            {
                surname = "";
                name = "";
                city = "";
                ukr = -1;
                math = -1;
                eng = -1;
            }
            else
            {
                int index;

                index = input.IndexOf("|");
                surname = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                name = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                city = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                ttry = input.Substring(0, index);
                if (!ttry.Equals(""))
                {
                    ukr = Int32.Parse(ttry);
                }
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                ttry = input.Substring(0, index);
                if (!ttry.Equals(""))
                {
                    math = Int32.Parse(ttry);
                }
                input = input.Substring(index + 1);

                if (!input.Equals(""))
                {
                    eng = Int32.Parse(ttry.Replace("|",""));
                }
            }
        }

        public override string ToString()
        {
            return surname + "|" + name + "|" + city + "|" + ukr + "|" + math + "|" + eng;
        }

        public bool isEmpty()
        {
            if (this.ToString().Equals(new Student().ToString()))
            {
                return true;
            }
            return false;
        }

        public double avg()
        {
            return (ukr + math + eng) / 3.0;
        }
    }
}
