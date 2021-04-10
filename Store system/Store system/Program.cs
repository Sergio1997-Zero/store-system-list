using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Salelist salelist = new Salelist();

            Product P1 = new Product();
            P1.Name = "Asus";
            P1.Price = 500000;
            P1.ID = 01;
            P1.Stock = 30;
            salelist.AddToProduct(P1);

            Product P2 = new Product();
            P2.Name = "Mac";
            P2.Price = 70000;
            P2.ID = 02;
            P2.Stock = 15;
            salelist.AddToProduct(P2);

            Product P3 = new Product();
            P3.Name = "Samsung";
            P3.Price = 3423242;
            P3.ID = 03;
            P3.Stock = 20;
            salelist.AddToProduct(P3);

            Product P4 = new Product();
            P4.Name = "One plus";
            P4.Price = 200000;
            P4.ID = 04;
            P4.Stock = 5;
            salelist.AddToProduct(P4);

            Product P5 = new Product();
            P5.Name = "Huawie";
            P5.Price = 500;
            P5.ID = 05;
            P5.Stock = 100000;
            salelist.AddToProduct(P5);

            Client C1 = new Client();
            C1.NameClient = "Leo";
            C1.Age = 20;
            C1.Id = 123234;
            C1.Cell = 32356483;
            C1.Email = "LeoGay@Umanizales.edu.co";
            salelist.AddToClient(C1);

            Client C2 = new Client();
            C2.NameClient = "Isa";
            C2.Age = 19;
            C2.Id = 1054870645;
            C2.Cell = 323792343;
            C2.Email = "Issa@Umanizales.edu.co";
            salelist.AddToClient(C2);

            Client C3 = new Client();
            C3.NameClient = "Daniel";
            C3.Age = 10;
            C3.Id = 10327382;
            C3.Cell = 3232342;
            C3.Email = "Daniel@Umanizales.edu.co";
            salelist.AddToClient(C3);

            Client C4 = new Client();
            C4.NameClient = "Eli";
            C4.Age = 24;
            C4.Id = 1023244;
            C4.Cell = 383022432;
            C4.Email = "Ili@Umanizales.edu.co";
            salelist.AddToClient(C4);

            Client C5 = new Client();
            C5.NameClient = "Nuevo";
            C5.Age = 55;
            C5.Id = 1000023;
            C5.Cell = 300234248;
            C5.Email = "nuevo@Umanizales.edu.co";
            salelist.AddToClient(C5);

            Sale S1 = new Sale();
            S1.Product = P1;
            S1.Client = C1;
            salelist.AddToSale(S1);

            Sale S2 = new Sale();
            S2.Product = P2;
            S2.Client = C2;
            salelist.AddToSale(S2);

            Sale S3 = new Sale();
            S3.Product = P4;
            S3.Client = C2;
            salelist.AddToSale(S3);

            Sale S4 = new Sale();
            S4.Product = P5;
            S4.Client = C4;
            salelist.AddToSale(S4);

            Sale S5 = new Sale();
            S5.Product = P2;
            S5.Product = P1;
            S5.Client = C2;
            salelist.AddToSale(S5);

            Console.WriteLine("---------- CLIENTS ----------");
            salelist.PrintClient();

            Console.WriteLine("---------- PRODUCTS ----------");
            salelist.PrintProduct();

            Console.WriteLine("---------- SALES ----------");
            salelist.PrintSales();

            double totalCost = salelist.Total();
            double TotalPriceAverage = salelist.AverageSale();
            Sale ImportantSale = salelist.MostImportantProduct();
            Sale ImportantClient = salelist.MostImpClient();

            Console.WriteLine("---------- TOTAL SALES AMOUNT ----------");
            Console.WriteLine(totalCost);

            Console.WriteLine("---------- MOST IMPORTANT SALE MADE BY ----------");
            Console.WriteLine(ImportantClient.Client.NameClient);

            Console.WriteLine("---------- BEST SELLING PRODUCT ----------");
            Console.WriteLine(ImportantSale.Product.Name);

            Console.WriteLine("---------- TOTAL PRICES AVERAGE ----------");
            Console.WriteLine(totalCost / TotalPriceAverage);

            Console.WriteLine("---------- PRODUCTS STOCK ----------");
            salelist.PrintStock();

            Console.WriteLine("---------- INSERT C5 AFTER C3 ----------");
            salelist.InsertAfterClient(C5, C3);
            salelist.PrintClient();

            Console.WriteLine("---------- REMOVE C1  ----------");
            salelist.RemoveClient();
            salelist.PrintClient();

            Console.WriteLine("---------- INSERT P5 AFTER P3 ----------");
            salelist.InsertAfterProduct(P5, P3);
            salelist.PrintProduct();

            Console.WriteLine("---------- REMOVE P1  ----------");
            salelist.removeProduct();
            salelist.PrintProduct();


            Console.ReadKey();
        }
    }
}
