using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_system
{
    public class Salelist
    {
        ClientNode HeadNodeClient;
        ProductNode HeadNodeProduct;
        SaleNode HeadNodeSale;

        Sale[] sales = new Sale[50];
        int saleCount = 0;


        public void AddSSale(Sale newSale)
        {
            sales[saleCount] = newSale;
            saleCount++;
        }


        public void AddToClient(Client NewClientToAdd)
        {
            ClientNode NewClientNode = new ClientNode();
            NewClientNode.client = NewClientToAdd;

           


            if (HeadNodeClient == null)
            {
                HeadNodeClient = NewClientNode;
            }
            else
            {
                ClientNode last = HeadNodeClient;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = NewClientNode;
            }
        }

        public void AddToProduct(Product NewProductToAdd)
        {
            ProductNode NewProductNode = new ProductNode();
            NewProductNode.product = NewProductToAdd;

            if (HeadNodeProduct == null)
            {
                HeadNodeProduct = NewProductNode;
            }
            else
            {
                ProductNode last = HeadNodeProduct;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = NewProductNode;
            }
        }

        public void AddToSale(Sale NewSaleToAdd)
        {
            SaleNode NewProductNode = new SaleNode();
            NewProductNode.sale = NewSaleToAdd;

            if (HeadNodeSale == null)
            {
                HeadNodeSale = NewProductNode;
            }
            else
            {
                SaleNode last = HeadNodeSale;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = NewProductNode;
            }
        }

        public double Total()
        {
            double totalAmountP = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalAmountP = totalAmountP + sales[i].Product.totalGet();
            }
            return totalAmountP;
        }

        public Sale MostImportantProduct()
        {
            Sale sale = sales[0];
            string product = sales[0].Product.Name;
            for (int i = 0; i < saleCount; i++)
            {
                if (sales[i].TotalSale > sale.Totalsale())
                {
                    sale = sales[i];
                    product = sales[i].Product.Name;
                }
            }
            return sale;
        }
        public double Saless()
        {
            double totalAmount = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalAmount = totalAmount + sales[i].TotalSale;
            }
            return totalAmount;
        }

        public Sale getTotalSales()
        {
            Sale sale = sales[0];
            string product = sales[0].Product.Name;
            for (int i = 0; i < saleCount; i++)
            {
                if (sales[i].TotalSale > sale.Totalsale())
                {
                    sale = sales[i];
                    product = sales[i].Product.Name;
                }
            }
            return sale;
        }

        public Sale MostImpClient()
        {
           Sale sale = sales[0];
            string client = sales[0].Client.NameClient;
           for (int i = 0; i < saleCount; i++)
           {
               if (sales[i].TotalSale > sale.Totalsale())
               {
                    sale = sales[i];
                    client = sales[i].Client.NameClient;
              }
           }
           return sale;
        }

        public double AverageSale()
        {
            double totalUnits = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalUnits = totalUnits + sales[i].Product.Unist();
            }
            return totalUnits;
        }

        public void InsertAfterClient(Client newClient, Client after)
        {
            ClientNode client = HeadNodeClient;
            while (client != null && client.client != after)
            {
                client = client.Next;
            }

            ClientNode NewClientNode = new ClientNode();
            NewClientNode.client = newClient;

            NewClientNode.Next = client.Next;
            client.Next = NewClientNode;
        }

        public void InsertAfterProduct(Product newproduct, Product after)
        {
            ProductNode product = HeadNodeProduct;
            while (product != null && product.product != after)
            {
                product = product.Next;
            }

            ProductNode NewProductNode = new ProductNode();
            NewProductNode.product = newproduct;

            NewProductNode.Next = product.Next;
            product.Next = NewProductNode;
        }

        public void RemoveClient()
        {
            if (HeadNodeClient != null)
            {
                HeadNodeClient = HeadNodeClient.Next;
            }
        }

        public void InsertAfterClient(Product newProduct, Product after)
        {
            ProductNode pruduct = HeadNodeProduct;
            while (pruduct != null && pruduct.product != after)
            {
                pruduct = pruduct.Next;
            }
            ProductNode NewProductNode = new ProductNode();
            NewProductNode.product = newProduct;

            NewProductNode.Next = pruduct.Next;
            pruduct.Next = NewProductNode;
        }

        public void removeProduct()
        {
            HeadNodeProduct = HeadNodeProduct.Next;
        }

        public void PrintClient()
        {
            ClientNode client = HeadNodeClient;
            while (client != null)
            {
                Console.WriteLine($"Name: {client.client.NameClient} - Age: {client.client.Age} - Id: {client.client.Id} - Cell: {client.client.Cell} - Email: {client.client.Email} ");
                client = client.Next;
            }
        }

        public void PrintProduct()
        {
            ProductNode pruduct = HeadNodeProduct;

            while (pruduct != null)
            {
                Console.WriteLine($"Product name: {pruduct.product.Name} - Id: {pruduct.product.ID} - Price: {pruduct.product.Price} - Stock: {pruduct.product.Stock}");
                pruduct = pruduct.Next;
            }
        }

        public void PrintSales()
        {
            ClientNode client = HeadNodeClient;
            ProductNode pruduct = HeadNodeProduct;
            SaleNode SalE = HeadNodeSale;
            while (SalE != null && pruduct != null && SalE != null)
            {
                Console.WriteLine($"Name: {client.client.NameClient} - Age: {client.client.Age} - Id: {client.client.Id} - Cell: {client.client.Cell} - Email: {client.client.Email} ");
                client = client.Next;

                Console.WriteLine($"Product name: {pruduct.product.Name} - Id: {pruduct.product.ID} - Price: {pruduct.product.Price} - Stock: {pruduct.product.Stock}");
                pruduct = pruduct.Next;
                SalE = SalE.Next;
            }
        }
        public void PrintStock()
        {
            ProductNode pruduct = HeadNodeProduct;
            while (pruduct != null)
            {
                Console.WriteLine($"Product name: {pruduct.product.Name} - Units available: {pruduct.product.Stock}");
                pruduct = pruduct.Next;
            }
        }
    }
}
