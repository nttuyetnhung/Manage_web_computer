using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_Website
{
    public class Program
    {
        public static void PrintComputers(List<Computer> computers)
        {
            if (computers.Count == 0)
            {
                Console.WriteLine("Không có sản phẩm nào trong danh sách.");
                return;
            }

            // In tiêu đề bảng
            Console.WriteLine($"{"ID",-8} {"Tên",-20} {"Màu sắc",-10} {"Nước SX",-12} {"Hãng",-10} {"Giá",-10} {"Số lượng",-10} {"Bảo hành",-10} {"OS Setup",-10}");
            Console.WriteLine(new string('-', 110));
            foreach (Computer computer in computers)
                Console.WriteLine(computer);
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Store store = new Store();
            store.computers.Add(new Computer("Com01", "Dell XPS 2020","white", "Indonesia", "Dell", 24000000, 0,12, true));
            store.computers.Add(new Computer("Com02", "LG gram 2022","black", "Vietnam", "LG", 17000000, 17,12, true));
            store.computers.Add(new Computer("Com03", "Lenovo ThinkBook", "silver", "China", "Lenovo", 17000000, 17, 12, true));


            // In ra danh sách tất cả các sản phẩm
            Console.WriteLine("*** Danh sách sản phẩm trong cửa hàng ");
            PrintComputers(store.computers);

            // Tìm kiếm sản phẩm theo tên
            Console.WriteLine("\n*** Tìm kiếm sản phẩm với từ khóa 'Dell' ");
            List<Computer> searchResult = store.find("Dell");
            PrintComputers(searchResult);

            // Tìm kiếm sản phẩm theo khoảng giá
            //Console.WriteLine("\n*** Tìm kiếm sản phẩm có giá trên 15tr ");
            //searchResult = store.find(15000000,30);
            //PrintComputers(searchResult);

            // Thêm sản phẩm mới
            Console.WriteLine("\n*** Thêm sản phẩm mới ");
            store.add(new Computer("Com04", "MacBook Pro 2023", "silver", "USA", "Apple", 35000000, 10, 24, true));
            PrintComputers(store.computers);

            // Xóa sản phẩm
            Console.WriteLine("\n*** Xóa sản phẩm Com02 (LG gram 2022) ");
            foreach (Computer c in store.computers)
            {
                if (c.find("LG gram 2022"))
                {
                    store.remove(c);
                    break;
                }
            }
            PrintComputers(store.computers);
            Customer customer = new Customer("Taylor Swift", "USA", "0375830495");

            // Khách hàng đặt hàng
            Console.WriteLine("\n*** Đặt hàng ");
            customer.order(store.computers[0]); 
            customer.order(store.computers[2]);
            Console.WriteLine("\n***Danh sách máy tính sau khi mua");
            PrintComputers(store.computers);
            Console.ReadKey();
        }
    }
}

        
    

