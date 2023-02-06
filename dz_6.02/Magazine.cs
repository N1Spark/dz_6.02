using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6._02
{
   public class Magazine
    {
        private string name;
        private int year;
        private string description;
        private int tel;
        private string email;

        public Magazine()
        {

        }
        public Magazine(string n, int y, string d, int t,string e)
        {
            name = n;
            year = y;
            description = d;
            tel = t;
            email = e;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public int Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name};\nYear: {year};\nDescription: {description};\nTel: {tel};\nEmail: {email}");
        }
        public override string ToString()
        {
            return $"Name: {name};\nYear: {year};\n Description: {description};\nTel: {tel};\nEmail: {email}";
        }
    }
}
