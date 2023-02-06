using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6._02
{
    public class Store
    {
        private string name;
        private string address;
        private string description;
        private int tel;
        private string email;

        public Store()
        {

        }
        public Store(string n, string a, string d, int t, string e)
        {
            name = n;
            address = a;
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
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
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
            Console.WriteLine($"Name: {name};\nAddress: {address};\nDescription: {description};\nTel: {tel}\nEmail: {email}");
        }
        public override string ToString()
        {
            return $"Name: {name};\nAddress: {address};\nDescription: {description};\nTel: {tel}\nEmail: {email}";
        }
    }
}
