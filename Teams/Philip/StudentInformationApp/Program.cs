using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
namespace StudentInformationApp
{
    class StudentInfo
    {
        private int id; //fields
        public int ID // Properties
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        private string lname;
        public string LastName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        private string fname; 
        public string FirstName //property
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        private string mname;
        public string MiddleName
        {
            get
            {
                return mname;
            }
            set
            {
                mname = value;
            }
        }
        private DateTime dob;
        public DateTime DateofBirth
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }
        private string gender;
        public string Gender //property
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Full Name: " + LastName + "," + " " + FirstName + " " + MiddleName);
        }
        public void DisplayAll()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Full Name: " + LastName + "," + " " + FirstName + " " + MiddleName);
            Console.WriteLine("Date of Birth: " + DateofBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Gender: " + gender);
            
        }

    }
    
    class Address
    {
        private int Aid; //fields
        public int aID // Properties
        {
            get
            {
                return Aid;
            }

            set
            {
                Aid = value;
            }
        }
        //Unit/Floor/Room No.
        private string UFR;
        public string UnitFloorRoom
        {
            get
            {
                return UFR;
            }
            set
            {
                UFR = value;
            }
        }
        //Building
        private string building;
        public string BuildingName
        {
            get
            {
                return building;
            }
            set
            {
                building = value;
            }
        }
        //Block No.
        private string bn;
        public string BlockNumber
        {
            get
            {
                return bn;
            }
            set
            {
                bn = value;
            }
        }
        //Lot No.
        private string ln;
        public string LotNumber
        {
            get
            {
                return ln;
            }
            set
            {
                ln = value;
            }
        }
        //Phase No.
        private string pn;
        public string PhaseNum
        {
            get
            {
                return pn;
            }
            set
            {
                pn = value;
            }
        }
        //House No.
        private string hn;
        public string HouseNumber
        {
            get
            {
                return hn;
            }
            set
            {
                hn = value;
            }
        }
        //Street
        private string st;
        public string StreetNumber
        {
            get
            {
                return st;
            }
            set
            {
                st = value;
            }
        }
        //Subdivision
        private string subd;
        public string Subdivision
        {
            get
            {
                return subd;
            }
            set
            {
                subd = value;
            }
        }
        //Barangay
        private string brgy;
        public string Barangay
        {
            get
            {
                return brgy;
            }
            set
            {
                brgy = value;
            }
        }
        //City/Municipality
        private string cm;
        public string CityMunicipality
        {
            get
            {
                return cm;
            }
            set
            {
                cm = value;
            }
        }
        //State
        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        //Zip Code
        private string zc;
        public string ZipCode
        {
            get
            {
                return zc;
            }
            set
            {
                zc = value;
            }
        }
        public void DisplayAdd()
        {
            Console.WriteLine("-------Address Information-------");
            Console.WriteLine("Complete Address: " + UnitFloorRoom);
            Console.WriteLine("Building: " + BuildingName);
            Console.WriteLine("Block Number: " + BlockNumber);
            Console.WriteLine("Lot Number: " + LotNumber);
            Console.WriteLine("Phase Number: " + PhaseNum);
            Console.WriteLine("House Number: " + HouseNumber);
            Console.WriteLine("Street Number: " + StreetNumber);
            Console.WriteLine("Subdivision: " + Subdivision);
            Console.WriteLine("Barangay: " + Barangay);
            Console.WriteLine("City/Municipality: " + CityMunicipality);
            Console.WriteLine("State: " + State);
            Console.WriteLine("Zipcode: " + ZipCode);
        }
        

    }
    class Program
    {
        static Dictionary<int, StudentInfo> listDictionary = new Dictionary<int, StudentInfo>();
        static Dictionary<int, Address> AddressDictionary = new Dictionary<int, Address>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("| STUDENTS MANAGEMENT SYSTEM |");
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("|1. Insert new Student       |");
                Console.WriteLine("|2. View list of Students    |");
                Console.WriteLine("|3. Search Students          |");
                Console.WriteLine("|4. Update Student Info      |");
                Console.WriteLine("|5. Remove Student Record    |");
                Console.WriteLine("|6. Exit                     |");
                Console.WriteLine("+----------------------------+");
               
                        Console.Write("Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            // if user choose 1 it will call the StudentInfo class
                            case 1:
                                InsertStudent();
                                break;

                            case 2:
                                ViewList();
                                break;
                            case 3:
                                Search();
                                break;
                            case 4:
                                Update();
                                break;
                            case 5:
                                Remove();
                                break;
                            case 6:
                                return;
                            default:
                                Console.WriteLine("Invalid Input!");
                                break;
                        }
                    }

        }
        //This Shows The values from the Method Display under StudentInfo Class 
        private static void ViewList()
        {
            foreach (StudentInfo i in listDictionary.Values)
            {
                Console.WriteLine("----------------------------");
                i.Display();
            }
            
        }
        private static void SelectionUpdate()
        {

            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|Choose Option # for Update|");
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|1. Last Name              |");
            Console.WriteLine("|2. First Name             |");
            Console.WriteLine("|3. Middle Name            |");
            Console.WriteLine("|4. Date of Birth          |");
            Console.WriteLine("|5. Gender                 |");
            Console.WriteLine("|6. Home Phone #           |");
            Console.WriteLine("|7. Mobile #               |");
            Console.WriteLine("|8. Email Address          |");
            Console.WriteLine("|9. Civil Status           |");
            Console.WriteLine("|10. Religion              |");
            Console.WriteLine("|11. Address               |");
            Console.WriteLine("|12. Exit                  |");
            Console.WriteLine("+--------------------------+");

        }
        private static void AddressUpdate()
        {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|Choose Option # for Update|");
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|1. Unit/Floor/Room        |");
            Console.WriteLine("|2. Building               |");
            Console.WriteLine("|3. Block Number           |");
            Console.WriteLine("|4. Lot Number             |");
            Console.WriteLine("|5. Phase Number           |");
            Console.WriteLine("|6. House Number           |");
            Console.WriteLine("|7. Street                 |");
            Console.WriteLine("|8. Subdivision            |");
            Console.WriteLine("|9. Barangay               |");
            Console.WriteLine("|10. City/Municipality     |");
            Console.WriteLine("|11. State                 |");
            Console.WriteLine("|12. Zip Code              |");
            Console.WriteLine("+--------------------------+");
            
        }
        private static void Update()
        {
            bool found = false;
            Console.Write("Input ID: ");
            //This method is used to converts the specified string representation of a number to an equivalent 32-bit signed integer
            int search = Convert.ToInt32(Console.ReadLine());
            foreach (StudentInfo student in listDictionary.Values)
            {
                if (student.ID.Equals(search))
                {
                    SelectionUpdate();
                    Console.Write("Enter Option #: ");
                    int sel = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        switch (sel)
                        {
                            // if user choose 1 it will call the StudentInfo class
                            case 1:
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Enter New Last Name: ");
                                        student.LastName = Console.ReadLine();
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Invalid Data!");
                                    }
                                }
                            case 2:
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Enter New First Name: ");
                                        student.FirstName = Console.ReadLine();
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Invalid Data!");
                                    }
                                }
                            case 3:
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Enter New Middle Name: ");
                                        student.MiddleName = Console.ReadLine();
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Invalid Data!");
                                        
                                    }
                                }
                                
                                
                            case 4:
                                while (true)
                                {
                                    Console.Write("Enter New Date of Birth: Ex. (01/01/2021) : ");
                                    //DateTime dDate;
                                    try
                                    {
                                        student.DateofBirth = DateTime.Parse(Console.ReadLine());
                                        
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("The date is not in the correct format!");
                                        
                                    }
                                }
                                
                            case 5:
                                while (true)
                                {
                                    
                                    try
                                    {
                                        Console.Write("Enter New Gender: ");
                                        student.Gender = Console.ReadLine();
                                       
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Invalid Data!");

                                    }
                                }
                                
                            case 11:
                                foreach (Address iadd in AddressDictionary.Values)
                                {
                                    if (iadd.aID.Equals(search))
                                    {
                                        AddressUpdate();
                                        Console.Write("Enter Option #: ");
                                        int sel1 = int.Parse(Console.ReadLine());
                                        while (true)
                                        {
                                            switch (sel1)
                                            {
                                                // Address Update
                                                case 1:
                                                    Console.Write("Enter New Unit/Floor/Room: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                
                                                case 2:
                                                    Console.Write("Enter New Building: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 3:
                                                    Console.Write("Enter New Block Number: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 4:
                                                    Console.Write("Enter New Lot Number: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 5:
                                                    Console.Write("Enter New Phase Number: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 6:
                                                    Console.Write("Enter New House Number: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 7:
                                                    Console.Write("Enter New Street: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 8:
                                                    Console.Write("Enter New Subdivision: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 9:
                                                    Console.Write("Enter New Barangay: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 10:
                                                    Console.Write("Enter New City/Municipality: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 11:
                                                    Console.Write("Enter New State: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                case 12:
                                                    Console.Write("Enter New Zip Code: ");
                                                    iadd.UnitFloorRoom = Console.ReadLine();
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input!");
                                                    break;
                                            }

                                            break;
                                        }

                                        found = true;
                                    }
                                }
                                Console.WriteLine("Successfully Update!");
                                
                                break;
                            default:
                                Console.WriteLine("Invalid Input!");
                                break;
                        }

                        break;
                    }
                    
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
        }
        private static void Remove()
        {
            bool found = false;
            Console.Write("Input ID: ");
            //This method is used to converts the specified string representation of a number to an equivalent 32-bit signed integer
            int search = Convert.ToInt32(Console.ReadLine());
            foreach (StudentInfo student in listDictionary.Values)
            {
                if (student.ID.Equals(search))
                {
                    listDictionary.Remove(search);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
        }
        private static void Search()
        {
            bool found = false;
            Console.Write("Input ID: ");
            //This method is used to converts the specified string representation of a number to an equivalent 32-bit signed integer
            int search = Convert.ToInt32(Console.ReadLine());
            foreach (StudentInfo student in listDictionary.Values)
            {
                if (student.ID.Equals(search))
                {
                    Console.WriteLine("----------------------------");
                    student.DisplayAll();
                    
                    found = true;
                }
            }
            foreach (Address iadd in AddressDictionary.Values)
            {
                if (iadd.aID.Equals(search))
                {
                    
                    iadd.DisplayAdd();

                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
           
        }
        //This Insert Student Information to the Dictionary
        private static void InsertStudent()
        {
            
            //USING DICTIONARY STUDENTINFO
            StudentInfo student = new StudentInfo();
            //Generate Mock ID for the ViewList Method
            student.ID = listDictionary.Count + 1;
            //Input name
            Console.Write("Enter Last Name: ");
            student.LastName = Console.ReadLine();
            Console.Write("Enter First Name: ");
            student.FirstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            student.MiddleName = Console.ReadLine();
            //Input date
            while (true)
            {
                Console.Write("Enter Date of Birth: Ex. (01/01/2021) : ");
                //DateTime dDate;
                try
                {
                    student.DateofBirth = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The date is not in the correct format!");
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write("Enter Gender (M/F): ");
            student.Gender = Console.ReadLine();
            listDictionary.Add(student.ID, student);

            //USING DICTIONARY ADDRESS
            Address iadd = new Address();
            //Generate Mock ID for the ViewList Method
            iadd.aID = AddressDictionary.Count + 1;
            //Address
            Console.WriteLine("--------Address Information------");
            Console.WriteLine("Please Put N/A if Not Applicable!");
            Console.Write("Enter Unit/Floor/Room No. : ");
            iadd.UnitFloorRoom = Console.ReadLine();
            Console.Write("Enter Building : ");
            iadd.BuildingName = Console.ReadLine();
            Console.Write("Enter Block No. : ");
            iadd.BlockNumber = Console.ReadLine();
            Console.Write("Enter Lot No. : ");
            iadd.LotNumber = Console.ReadLine();
            Console.Write("Enter Phase No. : ");
            iadd.PhaseNum = Console.ReadLine();
            Console.Write("Enter House No. : ");
            iadd.HouseNumber = Console.ReadLine();
            Console.Write("Street : ");
            iadd.StreetNumber = Console.ReadLine();
            Console.Write("Subdivision : ");
            iadd.Subdivision = Console.ReadLine();
            Console.Write("Barangay : ");
            iadd.Barangay = Console.ReadLine();
            Console.Write("City/Municipality : ");
            iadd.CityMunicipality = Console.ReadLine();
            Console.Write("State : ");
            iadd.State = Console.ReadLine();
            Console.Write("Zip Code : ");
            iadd.ZipCode = Console.ReadLine();
            //Added Invisible ID to Dictionary
            AddressDictionary.Add(iadd.aID, iadd);
            Console.WriteLine("Successfully inserted a student!");

        }
        
    }
    }

