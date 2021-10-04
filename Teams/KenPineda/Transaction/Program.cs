using System;
using System.Collections;
using System.Collections.Generic;


// Write a Java program that simulates a point-of-sales system that has at least 5 different products. 
// The program should be able to display all products with their prices and current available stock.
// DONE

// The program should also be able to display all transaction records of each product, 
// including the product name, date/timestamp of the transaction and the stock that was transacted. 
// DONE


// The program should also have the functionality to modify/adjust the current stock
// and record the date/timestamp the stock was adjusted. Feel free to decide on everything 
// that's not included in the requirement, 
// as long as the final program you submit runs properly. 
// You will be graded using the following criteria:


// 25 - Working Program
// 25 - Correctness of Program Logic
// 25 - Complete Implementation of Requirements
// 25 - Full use of Object-Oriented Design

// For a total of 100 points.


namespace Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialized Products
            List<SchoolProduct> SchProduct = new List<SchoolProduct>(){
                new SchoolProduct(){ProductName = "Pencil",     ProductPrice = 10.55, stock = 4},
                new SchoolProduct(){ProductName = "TextBook",   ProductPrice = 10.25, stock = 7},
                new SchoolProduct(){ProductName = "Eraser",     ProductPrice = 10.65, stock = 21},
                new SchoolProduct(){ProductName = "Ballpen",    ProductPrice = 10.78, stock = 10},
                new SchoolProduct(){ProductName = "Notebook",   ProductPrice = 10.87, stock = 7},
            };
            List<TransacRecords> TransactedProductList = new List<TransacRecords>();

            Console.WriteLine("Welcome To My Humble Shop \n");

            //Calls Display function for Products
            SchoolProduct.ProductDisplay(SchProduct);

            var response = "yes";
            var prodstock = 0;
            var prodName = "";

            // Ask User what to buy
            while (response == "y" || response == "yes")
            {
             
                Console.WriteLine("\nWhat would you like to buy?");
                prodName = Console.ReadLine();

                Console.WriteLine("How Many would you like to buy?");
                prodstock = Convert.ToInt32(Console.ReadLine());

                while (prodstock <= 0)
                {
                    if (prodstock <= 0)
                    {
                        Console.WriteLine("\nYou cannot input negative values");
                        Console.WriteLine("Please Try Again!\n");
                    }
                    prodstock = Convert.ToInt32(Console.ReadLine());
                }

                foreach (var product in SchProduct)
                {
                    if (product.ProductName.ToLower() == prodName.ToLower())
                    {
                        product.stock = product.stock - prodstock;

                        //Date Formatting
                        DateTime now = DateTime.Now;
                        string DateTimeString = now.ToString("dd MMMM yyyy hh:mm:ss tt");

                        var transactedrecord = new TransacRecords(prodName, prodstock, DateTimeString);
                        transactedrecord.ProdName = prodName;
                        transactedrecord.TransactedStock = prodstock;
                        transactedrecord.Date = DateTimeString;

                        //Adding Transacted Product to the List of Transactions
                        TransactedProductList.Add(new TransacRecords(prodName, prodstock, DateTimeString));
                    }
                }

                // Ask Response from User to buy again
                Console.WriteLine("Would You like to buy again?");
                response = Console.ReadLine();

            }
            Console.WriteLine("\nTransactions:");
            TransacRecords.TransactionDisplay(TransactedProductList);

            Console.WriteLine("\nProducts:");
            SchoolProduct.ProductDisplay(SchProduct);

            Console.WriteLine("Would you like to add your stocks?");
            var editResponse = Console.ReadLine();

            var StockName = "";
            var StockNumber = 0;
            var Response = "yes";
            if (editResponse == "yes" || editResponse == "y")
            {
                while (Response == "yes" || Response == "y")
                {
                    Console.WriteLine("What Stock?");
                    StockName = Console.ReadLine();

                    Console.WriteLine("How Many?");
                    StockNumber = Convert.ToInt32(Console.ReadLine());

                    // Adding stock
                    foreach (var stock in SchProduct)
                    {
                        if (stock.ProductName.ToLower() == StockName.ToLower())
                        {
                            stock.stock = stock.stock + StockNumber;
                            DateTime now = DateTime.Now;
                            string DateTimeString = now.ToString("dd MMMM yyyy hh:mm:ss tt");
                            stock.Date = DateTimeString;

                        }
                    }

                    Console.WriteLine("\nProducts:");
                    SchoolProduct.ProductDisplay(SchProduct);

                    Console.WriteLine("Would You like to add again?");
                    Response = Console.ReadLine();
                }
                Console.WriteLine("Thank You");
            }
            else
            {
                Console.WriteLine("Thank You!");
                Console.WriteLine("\nProducts:");
                SchoolProduct.ProductDisplay(SchProduct);
            }
        }
    }

    class SchoolProduct
    {
        public string ProductName;
        public double ProductPrice;
        public int stock;
        public string Date;


        // Display Method for Product
        public static void ProductDisplay(List<SchoolProduct> SchProduct)
        {

            foreach (var prod in SchProduct)
            {
                Console.WriteLine($"Product Name: {prod.ProductName} \nProduct Price: {prod.ProductPrice} \nStock: {prod.stock} \nStock Updated: {prod.Date}\n");

            }
        }
    }

    class TransacRecords
    {
        public string ProdName;
        public int TransactedStock;
        public string Date;

        public TransacRecords(string prodname, int transactedstock, string date)
        {
            ProdName = prodname;
            TransactedStock = transactedstock;
            Date = date;
        }


        // Display Method for Transaction History
        public static void TransactionDisplay(List<TransacRecords> TransacProduct)
        {
            foreach (var Transactions in TransacProduct)
            {
                Console.WriteLine($"Product Name: {Transactions.ProdName} \nSold Stocks: {Transactions.TransactedStock} \nDate: {Transactions.Date} \n");
            }
        }

    }
}
    

