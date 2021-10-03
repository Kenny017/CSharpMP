using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static List<Product> ListOfProducts;
        static void Main(string[] args)
        {
            ListOfProducts = new List<Product>() { new Product("Chocolate", 10), 
                                                                new Product("Dark Chocolate", 15),

            }; //Adding Product

            foreach (var product in ListOfProducts)
            {
                product.AddStock(new StockDetails(20)); //Adding Stocks
                product.AddTransactionRecord(new TransactionRecord(5)); //Adding a New Record for each Product with a Quantity of 5

            }


            while (true)
            {

                Console.WriteLine("\n+++++++++++++++++++POINT-OF-SALE+++++++++++++++++++");
                Console.WriteLine("\n(1) ADD A PRODUCT");
                Console.WriteLine("(2) DISPLAY ALL PRODUCTS");
                Console.WriteLine("(3) DISPLAY TRANSACTION RECORDS OF EACH PRODUCT");
                Console.WriteLine("(4) ADD STOCK");
                Console.WriteLine("(5) STOCK HISTORY");
                Console.WriteLine("(6) BUY A PRODUCT");

                Console.Write("Select: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {

                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            DisplayAllProducts();
                            break;
                        case 3:
                            DisplayAllTransactions();
                            break;
                        case 4:
                            AddStock();
                            break;
                        case 5:
                            ProductStockHistory();
                            break;
                        case 6:
                            BuyProduct();
                            break;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Error!"); ;
                }

            }


        }
        public static void ProductStockHistory()
        {
            Console.WriteLine("STOCK HISTORY\n");
            foreach (var item in ListOfProducts)
            {
                

                item.DisplayProductStockHistory();
            }







        }
        public static void BuyProduct()
        {
            Console.Write("What Product do you like to buy: ");
            string productName = Console.ReadLine() ?? throw new ArgumentNullException();


            foreach (var item in ListOfProducts)
            {
                if (item.Name == productName)
                {
                    Console.Write("How many Quantity? ");
                    int quantity = int.Parse(Console.ReadLine());
                    
                    if (quantity > item.AvailableStock())
                    {
                        Console.WriteLine("error: more than the available stock.");
                        return;
                    }
                    else
                    {
                        item.CurrentStock = item.CurrentStock - quantity;
                        item.AddTransactionRecord(new TransactionRecord(quantity));
                        Console.WriteLine("BUYING SUCCESS!!!");

                    }              
                    return;
                }

            }

        }

        public static void AddProduct()
        {
            Console.WriteLine("\nAdd a Product");
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine() ?? throw new ArgumentNullException();
            Console.Write("Enter Product Price: ");
            int productPrice = int.Parse(Console.ReadLine());

            ListOfProducts.Add(new Product(productName, productPrice));

            Console.WriteLine("Add Product SUCCESS");

        }

        public static void DisplayAllProducts()
        {
            Console.WriteLine("\nALL PRODUCTS\n");
            Console.WriteLine("Product Name\tProduct Price\tCurrent Stock Quantity\t");
            foreach (var item in ListOfProducts)
            {
                item.DisplayProductNamePricesStock();
            }

        }

        public static void DisplayAllTransactions()
        {
            Console.WriteLine("\nTRANSACTION RECORDS");
            //Console.WriteLine($"Transaction Record\tTime Stamp\t\tQuantity Transacted\tPrice");
            foreach (var item in ListOfProducts)
            {
                item.DisplayTransactionRecord();
            }

        }

        public static void AddStock()
        {
            Console.WriteLine("\nAdd STOCK");
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine() ?? throw new ArgumentNullException();

            foreach (var item in ListOfProducts)
            {
                if (item.Name == productName)
                {
                    Console.Write($"How much Quantity for Product {item.Name}: ");
                    int quantity = int.Parse(Console.ReadLine());

                    item.AddStock(new StockDetails(quantity));

                    Console.WriteLine("Adding Stock SUCCESS!!!");
                    return;
                }
            }

            Console.WriteLine("Product Not Found.");

        }
    }



    class Product
    {

        List<StockDetails> StockQuantityHistory = new List<StockDetails>();
        List<TransactionRecord> ProductTransactionHistory = new List<TransactionRecord>();
        public int CurrentStock { set; get; } = 0;

        public string Name { private set; get; }
        public int Prices { set; get; }

        public Product(string name, int prices)
        {
            Name = name;
            Prices = prices;
        }


        public void AddTransactionRecord (TransactionRecord addTransactionRecord)
        {

            if (addTransactionRecord == null)
            {

                throw new NullReferenceException();

            }

            ProductTransactionHistory.Add(addTransactionRecord);


        }

        public void DisplayTransactionRecord()
        {

            if (ProductTransactionHistory.Count == 0)
            {
                Console.WriteLine($"Product Name: {Name}, No Record");

            } else
            {

                Console.WriteLine($"\nProduct Name: {Name}\n");
                Console.WriteLine($"Transaction Record\tTime Stamp\t\tQuantity Transacted\tPrice");
                foreach (var item in ProductTransactionHistory)
                {
                    //Console.WriteLine($"Transaction Record\tTime Stamp\t\tQuantity Transacted\tPrice");
                    Console.WriteLine($"{item.TransactionRecordNum}\t\t\t{item.timeStamp}\t{item.Quantity}\t\t\t{Prices * item.Quantity}");
                }


            }
        }


        public void DisplayProductNamePricesStock ()
        {
            
            Console.WriteLine($"{Name}\t{Prices}\t\t{AvailableStock()}");

        }

        public void AddStock (StockDetails addStock)
        {
            if (addStock == null)
            {
                throw new NullReferenceException();
            }
            StockQuantityHistory.Add(addStock);

            //foreach (var item in StockQuantityHistory)
            //{
            CurrentStock = CurrentStock + addStock.Quantity;

            //}

        }

        public int AvailableStock ()
        {
            //if (StockQuantityHistory.Count == 0)
            //{
            //    return 0;

            //}
            //else
            //{
            //    int available = 0;
            //    foreach (var item in StockQuantityHistory)
            //    {
            //        available = available + item.Quantity;

            //    }
            //    return available;

            //}

            return CurrentStock;


        }

        public void DisplayProductStockHistory()
        {
            Console.WriteLine($"\nProduct Name: {Name}");
            Console.WriteLine($"STOCK QUANTITY\tDATE ADDED");
            foreach (var item in StockQuantityHistory)
            {
                Console.WriteLine($"{item.Quantity}\t\t{item.dateAdded}");
            }


        }
  

    }


    class StockDetails
    {
    //  public string Name { private set; get; }

        public StockDetails(int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Stock cannot be set to zero or below");
            }
            
            Quantity = quantity;
            dateAdded = DateTime.Now;

        }
        public int Quantity { set; get; }

        public DateTime dateAdded; 




    }

    class TransactionRecord
    {
        static int noOfTransactions = 0;
        public TransactionRecord(int quantity)
        {
            TransactionRecordNum = ++noOfTransactions;
            timeStamp = DateTime.Now;
            Quantity = quantity;
        }
        public int TransactionRecordNum { private set; get; }

        //public string Name { set; get; }

        public DateTime timeStamp { set; get; }

        public int Quantity { set; get; }

    }


}
