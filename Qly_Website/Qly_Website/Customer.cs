using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_Website
{
    public class Customer
    {
        private string name;
        private string address;
        private string phone;

        public Customer(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        
        public void order(Computer computer)
        {
            if (computer.CheckStatus() == "Còn hàng")
            {
                Computer mycom = (Computer)computer.Clone();
                Console.WriteLine($"Đã đặt hàng thành công:");
                computer.quantity--;// không nên bỏ thuộc tính của lớp khác 
                // In ra bảng thông tin sản phẩm đã đặt
                Console.WriteLine($"\n{"ID",-8} {"Tên",-20} {"Màu sắc",-10} {"Nước SX",-12} {"Hãng",-10} {"Giá",-10} {"Số lượng",-10} {"Bảo hành",-10} {"OS Setup",-10}");
                Console.WriteLine(new string('-', 110));
                Console.WriteLine(mycom);
            }
            else
            {
                Console.WriteLine($"\nSản phẩm '{computer.title}' hiện đã hết hàng.");
            }
        }
    }
}

