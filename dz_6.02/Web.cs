using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6._02
{
    public class Web
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public Web()
        {

        }
        public Web(string n,string u,string d, string i)
        {
            name = n;
            url = u;
            description = d;
            ip = i;
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
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
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
        public string Ip
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name};\nUrl: {url};\nDescription: {description};\nIp: {ip}");
        }
        public override string ToString()
        {
            return $"Name: {name};\nUrl: {url}\nDescription: {description}\nIp: {ip}";
        }
    }
}
