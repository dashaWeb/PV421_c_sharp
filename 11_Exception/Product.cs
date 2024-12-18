using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Exception
{
    internal class Product
    {
        string name;
        double price;
        DateTime dateIn;
        public string Name { get=>name;
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name must be not null or writespace");
                if(!value.All(e=>char.IsLetter(e)))
                {
                    Exception ex = new Exception("Bad name :: must has all letters");
                    ex.Data.Add("Value", value);
                    ex.Data["TimeStamp"] = DateTime.Now;
                    ex.HelpLink = @"https://google.com.ua";
                    throw ex;
                }
                name = value;
            } }
        public DateTime DateIn { get => dateIn;
            set => dateIn = value > DateTime.Now ? value : throw new BadDateProductException("Bad date of product", value);
        }
    }
}
