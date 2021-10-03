using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
public class Example
{
    public static int[,] ID ={
        {1, 2, 3, 4, 5 }
    };
    public static string[,] products ={
            {"Ryzen 3 3200G Bundle" , "Ryzen 5 2400G Bundle" , "Ryzen 5 2600  Bundle" , "Ryzen 5 3500  Bundle" , "Ryzen 5 3600  Bundle" }
        };
    public static int[,] QTY = {
            { 20, 5, 25 , 20 , 7}
        };
    public static double[,] price ={
            { 12449.00 , 18400.00 , 28499.00 , 30199.00 , 37499.00}
    };
    class Employee
    {
        public DateTime HiringDate { get; set; }
    }
    public static void Main()
    {

        while (true)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("---------------------------JPpc Sulit Bundles---------------------------");
            Display();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("What Do you want?");

            Menu();
            Console.WriteLine("--------------------------------------");
            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Item Number you want to buy: ");
                    int a = int.Parse(Console.ReadLine());
                    //For Item 1
                    if (a == 1)
                    {
                        Console.WriteLine("You Have Chosen: " + products[0, 0] + "\tQuantity Available: " + QTY[0, 0] + "pcs" + "\tPrice: P" + "{0:N}", price[0, 0]);
                        Console.Write("How Many you want? ");
                        int a1 = int.Parse(Console.ReadLine());
                        //If you enter greater than the Quantity of the ITEM
                        if (a1 > QTY[0, 0])
                        {
                            Console.WriteLine("Limited Stock Only!");
                            break;
                        }
                        else if (a1 == 0)
                        {
                            Console.WriteLine("Quantity cannot be 0!");
                        }
                        else
                        {
                            Console.Write("Sold to: ");
                            string name1 = Console.ReadLine();
                            Console.Write("Enter Cash Amount: ");
                            int amount1 = int.Parse(Console.ReadLine());
                            if (amount1 < price[0, 0] * a1)
                            {
                                Console.WriteLine("You dont have enough Money to Purchase!");
                            }

                            else
                            {
                                Console.WriteLine("Thank you for Purchasing");
                                Console.WriteLine("Here is your Receipt");
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Sold to: " + name1);
                                Console.WriteLine("Transaction Date: " + now);
                                int total1 = Convert.ToInt32(a1 * price[0, 0]);
                                Console.WriteLine("Total: P" + total1 + ".00");
                                Console.WriteLine("Change: P" + (amount1 - total1) + ".00");
                                Console.WriteLine("--------------------------------------");
                                QTY[0, 0] = QTY[0, 0] - a1;
                                if (QTY[0, 0] <= 0)
                                {
                                    Console.WriteLine("You Need To Re-Stock " + products[0, 0] + " Stock down to 0!");
                                }

                            }
                        }


                    }

                    //For Item 2
                    if (a == 2)
                    {
                        Console.WriteLine("You Have Chosen: " + products[0, 1] + "\tQuantity Available: " + QTY[0, 1] + "pcs" + "\tPrice: P" + "{0:N}", price[0, 1]);
                        Console.Write("How Many you want? ");
                        int a2 = int.Parse(Console.ReadLine());
                        //If you enter greater than the Quantity of the ITEM
                        if (a2 > QTY[0, 1])
                        {
                            Console.WriteLine("Limited Stock Only!");
                            break;
                        }
                        else if (a2 == 0)
                        {
                            Console.WriteLine("Quantity cannot be 0!");
                        }
                        else
                        {
                            Console.Write("Sold to: ");
                            string name2 = Console.ReadLine();
                            Console.Write("Enter Cash Amount: ");
                            int amount2 = int.Parse(Console.ReadLine());
                            if (amount2 < price[0, 1] * a2)
                            {
                                Console.WriteLine("You dont have enough Money to Purchase!");
                            }
                            else
                            {
                                Console.WriteLine("Thank you for Purchasing");
                                Console.WriteLine("Here is your Receipt");
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Sold to: " + name2);
                                Console.WriteLine("Transaction Date: " + now);
                                int total2 = Convert.ToInt32(a2 * price[0, 1]);
                                Console.WriteLine("Total: P" + total2 + ".00");
                                Console.WriteLine("Change: P" + (amount2 - total2) + ".00");
                                Console.WriteLine("--------------------------------------");
                                QTY[0, 1] = QTY[0, 1] - a2;
                                if (QTY[0, 1] <= 0)
                                {
                                    Console.WriteLine("You Need To Re-Stock " + products[0, 1] + " Stock down to 0!");
                                }

                            }
                        }


                    }

                    // Item 3
                    if (a == 3)
                    {
                        Console.WriteLine("You Have Chosen: " + products[0, 2] + "\tQuantity Available: " + QTY[0, 2] + "pcs" + "\tPrice: P" + "{0:N}", price[0, 2]);
                        Console.Write("How Many you want? ");
                        int a3 = int.Parse(Console.ReadLine());
                        //If you enter greater than the Quantity of the ITEM
                        if (a3 > QTY[0, 2])
                        {
                            Console.WriteLine("Limited Stock Only!");
                            break;
                        }
                        else if (a3 == 0)
                        {
                            Console.WriteLine("Quantity cannot be 0!");
                        }
                        else
                        {
                            Console.Write("Sold to: ");
                            string name3 = Console.ReadLine();
                            Console.Write("Enter Cash Amount: ");
                            int amount3 = int.Parse(Console.ReadLine());
                            if (amount3 < price[0, 2] * a3)
                            {
                                Console.WriteLine("You dont have enough Money to Purchase!");
                            }
                            else
                            {
                                Console.WriteLine("Thank you for Purchasing");
                                Console.WriteLine("Here is your Receipt");
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Sold to: " + name3);
                                Console.WriteLine("Transaction Date: " + now);
                                int total3 = Convert.ToInt32(a3 * price[0, 2]);
                                Console.WriteLine("Total: P" + total3 + ".00");
                                Console.WriteLine("Change: P" + (amount3 - total3) + ".00");
                                Console.WriteLine("--------------------------------------");
                                QTY[0, 2] = QTY[0, 2] - a3;
                                if (QTY[0, 2] <= 0)
                                {
                                    Console.WriteLine("You Need To Re-Stock " + products[0, 2] + " Stock down to 0!");
                                }

                            }
                        }


                    }

                    // Item 4
                    if (a == 4)
                    {
                        Console.WriteLine("You Have Chosen: " + products[0, 3] + "\tQuantity Available: " + QTY[0, 3] + "pcs" + "\tPrice: P" + "{0:N}", price[0, 3]);
                        Console.Write("How Many you want? ");
                        int a4 = int.Parse(Console.ReadLine());
                        //If you enter greater than the Quantity of the ITEM
                        if (a4 > QTY[0, 3])
                        {
                            Console.WriteLine("Limited Stock Only!");
                            break;
                        }
                        else if (a4 == 0)
                        {
                            Console.WriteLine("Quantity cannot be 0!");
                        }
                        else
                        {
                            Console.Write("Sold to: ");
                            string name4 = Console.ReadLine();
                            Console.Write("Enter Cash Amount: ");
                            int amount4 = int.Parse(Console.ReadLine());
                            if (amount4 < price[0, 3] * a4)
                            {
                                Console.WriteLine("You dont have enough Money to Purchase!");
                            }
                            else
                            {
                                Console.WriteLine("Thank you for Purchasing");
                                Console.WriteLine("Here is your Receipt");
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Sold to: " + name4);
                                Console.WriteLine("Transaction Date: " + now);
                                int total4 = Convert.ToInt32(a4 * price[0, 3]);
                                Console.WriteLine("Total: P" + total4 + ".00");
                                Console.WriteLine("Change: P" + (amount4 - total4) + ".00");
                                Console.WriteLine("--------------------------------------");
                                QTY[0, 3] = QTY[0, 3] - a4;
                                if (QTY[0, 3] <= 0)
                                {
                                    Console.WriteLine("You Need To Re-Stock " + products[0, 3] + " Stock down to 0!");
                                }

                            }
                        }


                    }

                    // Item 5
                    if (a == 5)
                    {
                        Console.WriteLine("You Have Chosen: " + products[0, 4] + "\tQuantity Available: " + QTY[0, 4] + "pcs" + "\tPrice: P" + "{0:N}", price[0, 4]);
                        Console.Write("How Many you want? ");
                        int a5 = int.Parse(Console.ReadLine());
                        //If you enter greater than the Quantity of the ITEM
                        if (a5 > QTY[0, 4])
                        {
                            Console.WriteLine("Limited Stock Only!");
                            break;
                        }
                        else if (a5 == 0)
                        {
                            Console.WriteLine("Quantity cannot be 0!");
                        }
                        else
                        {
                            Console.Write("Sold to: ");
                            string name5 = Console.ReadLine();
                            Console.Write("Enter Cash Amount: ");
                            int amount5 = int.Parse(Console.ReadLine());
                            if (amount5 < price[0, 4] * a5)
                            {
                                Console.WriteLine("You dont have enough Money to Purchase!");
                            }
                            else
                            {
                                Console.WriteLine("Thank you for Purchasing");
                                Console.WriteLine("Here is your Receipt");
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Sold to: " + name5);
                                Console.WriteLine("Transaction Date: " + now);
                                int total5 = Convert.ToInt32(a5 * price[0, 4]);
                                Console.WriteLine("Total: P" + total5 + ".00");
                                Console.WriteLine("Change: P" + (amount5 - total5) + ".00");
                                Console.WriteLine("--------------------------------------");
                                QTY[0, 4] = QTY[0, 4] - a5;
                                if (QTY[0, 4] <= 0)
                                {
                                    Console.WriteLine("You Need To Re-Stock " + products[0, 4] + " Stock down to 0!");
                                }

                            }
                        }


                    }
                    break;
                // FOR UPDATING STOCK
                case 2:
                    Console.Write("Enter Item number for QTY update: ");
                    int b = int.Parse(Console.ReadLine());
                    if (b == 1)
                    {
                        Console.Write("Enter New QTY: ");
                        int b1 = int.Parse(Console.ReadLine());
                        QTY[0, 0] = b1;
                        Console.WriteLine("Item: " + ID[0, 0] + " " + products[0, 0] + "\tUpdated to: " + QTY[0, 0] + "pcs" + " Date/Time Updated is " + now);

                    }
                    if (b == 2)
                    {
                        Console.Write("Enter New QTY: ");
                        int b2 = int.Parse(Console.ReadLine());
                        QTY[0, 1] = b2;
                        Console.WriteLine("Item: " + ID[0, 1] + " " + products[0, 1] + "\tUpdated to: " + QTY[0, 1] + "pcs" + " Date/Time Updated is " + now);

                    }
                    if (b == 3)
                    {
                        Console.Write("Enter New QTY: ");
                        int b3 = int.Parse(Console.ReadLine());
                        QTY[0, 2] = b3;
                        Console.WriteLine("Item: " + ID[0, 2] + " " + products[0, 2] + "\tUpdated to: " + QTY[0, 2] + "pcs" + " Date/Time Updated is " + now);

                    }
                    if (b == 4)
                    {
                        Console.Write("Enter New QTY: ");
                        int b4 = int.Parse(Console.ReadLine());
                        QTY[0, 3] = b4;
                        Console.WriteLine("Item: " + ID[0, 3] + " " + products[0, 3] + "\tUpdated to: " + QTY[0, 3] + "pcs" + " Date/Time Updated is " + now);

                    }
                    if (b == 5)
                    {
                        Console.Write("Enter New QTY: ");
                        int b5 = int.Parse(Console.ReadLine());
                        QTY[0, 4] = b5;
                        Console.WriteLine("Item: " + ID[0, 4] + " " + products[0, 4] + "\tUpdated to: " + QTY[0, 4] + "pcs" + " Date/Time Updated is " + now);

                    }
                    break;
                case 3:
                    return;
                default:
                    break;
            }
        }

    }
    public static void Display()
    {
        Console.WriteLine("Item # \t\tProduct Description \t\tQTY \t\tPrice");
        Console.WriteLine(ID[0, 0] + " \t\t" + products[0, 0] + "\t\t" + QTY[0, 0] + " pcs" + "\t\t" + "P{0:N}", price[0, 0]);
        Console.WriteLine(ID[0, 1] + " \t\t" + products[0, 1] + "\t\t" + QTY[0, 1] + " pcs" + "\t\t" + "P{0:N}", price[0, 1]);
        Console.WriteLine(ID[0, 2] + " \t\t" + products[0, 2] + "\t\t" + QTY[0, 2] + " pcs" + "\t\t" + "P{0:N}", price[0, 2]);
        Console.WriteLine(ID[0, 3] + " \t\t" + products[0, 3] + "\t\t" + QTY[0, 3] + " pcs" + "\t\t" + "P{0:N}", price[0, 3]);
        Console.WriteLine(ID[0, 4] + " \t\t" + products[0, 4] + "\t\t" + QTY[0, 4] + " pcs" + "\t\t" + "P{0:N}", price[0, 4]);

    }
    public static void Menu()
    {
        var menu = new List<Choices>() {
                new Choices(){ Id = 1, Name="Purchase Item" },
                new Choices(){ Id = 2, Name="Update Inventory" },
                new Choices(){ Id = 3, Name="Exit" }
        };

        //get all students whose name is Bill
        foreach (var student in menu)
            Console.WriteLine(student.Id + ". " + student.Name);
    }
    public class Choices
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
