using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_Website
{
    public class Computer : ICloneable
    {
        string id;
        public string title;
        string color;
        string country;
        string company;
        uint price;
        public byte quantity;
        byte expired;
        bool OS_setup;

        public Computer(string id, string title, string color, string country,
          string company, uint price, byte quantity,
          byte expired, bool OS_setup)
        {
            this.id = id;
            this.title = title;
            this.color = color;
            this.country = country;
            this.company = company;
            this.price = price;
            this.quantity = quantity;
            this.expired = expired;
            this.OS_setup = OS_setup;
        }
        public string CheckStatus()
        {
            return quantity > 0 ? "Còn hàng" : "Hết hàng";
        }
        public override string ToString()
        {
            return $"{id,-8} {title,-20} {color,-10} {country,-12} {company,-10} {price,-10} {quantity,-10} {expired,-10} {OS_setup,-10}";
        }
        public bool find(string kw)
        {
            return title.IndexOf(kw) >= 0 || country.Equals(kw);
        }
        public bool find(uint fr, uint to)
        {
            return price >= fr && quantity <= to;
        }

        public object Clone()
        {
            return new Computer(id, title, color, country, company,price, quantity, expired, OS_setup);
        }
    }
}
