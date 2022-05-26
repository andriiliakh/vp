using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Worker
    {
        public string surname { get; }
        public string name { get; }
        public DateTime dateBirth { get; }
        public string number { get; }
        public string country { get; }
        public string city { get; }
        public string street { get; }
        public string building { get; }
        public string flat { get; }

        public Worker()
        {
            surname = "";
            name = "";
            dateBirth = new DateTime();
            number = "";
            country = "";
            city = "";
            street = "";
            building = "";
            flat = "";
        }

        public Worker(string surname, string name, DateTime dateBirth, string number, string country, string city, string street, string building, string flat)
        {
            this.surname = surname;
            this.name = name;
            this.dateBirth = dateBirth;
            this.number = number;
            this.country = country;
            this.city = city;
            this.street = street;
            this.building = building;
            this.flat = flat;
        }

        public Worker(string input)
        {
            Console.WriteLine("Construct worker from: " + input);
            if(input.Length < 9)
            {
                surname = "";
                name = "";
                dateBirth = new DateTime();
                number = "";
                country = "";
                city = "";
                street = "";
                building = "";
                flat = "";
            } else
            {
                int index;

                index = input.IndexOf("|");
                surname = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                name = input.Substring(0, index);
                input = input.Substring(index + 1);

                try
                {
                    index = input.IndexOf("|");
                    dateBirth = DateTime.Parse(input.Substring(0, index));
                    input = input.Substring(index + 1);
                } catch (FormatException e)
                {
                    dateBirth = new DateTime();
                }

                index = input.IndexOf("|");
                number = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                country = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                city = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                street = input.Substring(0, index);
                input = input.Substring(index + 1);

                index = input.IndexOf("|");
                building = input.Substring(0, index);
                input = input.Substring(index + 1);

                flat = input;
            }
        }

        public override string ToString()
        {
            return surname + "|" + name + "|" + dateBirth + "|" + number + "|" + country 
                + "|" + city + "|" + street + "|" + building + "|" + flat;
        }

        public bool isEmpty()
        {
            if (this.ToString().Equals(new Worker().ToString()))
            {
                return true;
            }
            return false;
        }
    }
}
