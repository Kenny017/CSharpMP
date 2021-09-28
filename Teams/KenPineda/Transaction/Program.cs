using System;
using System.Collections.Generic;


            // Write a Java program that simulates a point-of-sales system that has at least 5 different products. 
            // The program should be able to display all products with their prices and current available stock.
            // DONE

            // The program should also be able to display all transaction records of each product, 
            // including the product name, date/timestamp of the transaction and the stock that was transacted. 


            // The program should also have the functionality to modify/adjust the current stock stock 
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
            // string productname, date, time;
            // double productprice;
            // int stock;

            List<SchoolProduct> SchProduct = new List<SchoolProduct>(){
                new SchoolProduct(){ProductName = "Pencil",     ProductPrice = 10.55, stock = 4},
                new SchoolProduct(){ProductName = "TextBook",   ProductPrice = 10.25, stock = 7},
                new SchoolProduct(){ProductName = "Eraser",     ProductPrice = 10.65, stock = 21},
                new SchoolProduct(){ProductName = "Ballpen",    ProductPrice = 10.78, stock = 10},
                new SchoolProduct(){ProductName = "Notebook",   ProductPrice = 10.87, stock = 7},
            };
       
            foreach(var prod in SchProduct){

                Console.WriteLine($"Product Name: {prod.ProductName} \nProduct Price: {prod.ProductPrice} \nStock: {prod.stock}");

            }
        
        }
    }

    class SchoolProduct
    {
        public string ProductName;
        public double ProductPrice;
        public int stock;
    }

    class DateAndTime
    {
        public string Date;
        public string time;
    }
}
