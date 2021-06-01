using System;
using System.IO;

namespace Files_hw
{
    class Client
    {
        private int id;
        private string pasNumber;
        private double payment;

        public int Id
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
        public string PasNumber
        {
            get
            {
                return pasNumber;
            }
            set
            {
                pasNumber = value;
            }
        }
        public double Payment
        {
            get
            {
                return payment;
            }
            set
            {
                payment = value;
            }
        }

        public Client (int id, string pasNumber, double payment)
        {
            Id = id;
            PasNumber = pasNumber;
            Payment = payment;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            do
            {
                Console.WriteLine("Choose 1 for Windows or 2 for MacOS");
                int switcher = ForIdCheck();
                switch (switcher)
                {
                    case 1:
                        {
                            //Console.Write("Type ID number: ");
                            //int id = Convert.ToInt32(Console.ReadLine());
                            //Console.Write("Type passport Number: ");
                            //string pasNumber = CheckerForPas();
                            //Console.WriteLine("Type Payment amount");
                            //double payment = Convert.ToDouble(Console.ReadLine());
                            //Client client = new Client(id, pasNumber, payment);
                            break;
                        }
                    case 2:
                        {
                            string catalog = "/Users/firat/FileName/";
                            int id = 001;
                            int id1 = 025;
                            int id2 = 034;

                            string pasNumber = "AZE12345678";
                            string pasNumber1 = "AZE87652134";
                            string pasNumber2 = "AZE81622144";

                            double payment = 22.30;
                            double payment1 = 50.00;
                            double payment2 = 12.35;

                            Client client = new Client(id, pasNumber, payment);
                            Client client1 = new Client(id1, pasNumber1, payment1);
                            Client client2 = new Client(id2, pasNumber2, payment2);

                            DirectoryInfo pathInfo = new DirectoryInfo(catalog);
                            if (!pathInfo.Exists)
                            {
                                pathInfo.Create();
                            }
                            using (StreamWriter fileWriter = new StreamWriter($"{catalog}\nSomething.txt", false, System.Text.Encoding.Default))
                            {

                                fileWriter.WriteLine($"{client.Id}; {client.PasNumber}; {client.Payment}" +
                                    $"\n{client1.Id}; {client1.PasNumber}; {client1.Payment}" +
                                    $"\n{client2.Id}; {client2.PasNumber}; {client2.Payment}");
                            }

                            using (StreamReader fileReader = new StreamReader($"{catalog}\nSomething.txt"))
                            {
                                Console.WriteLine(fileReader.ReadToEnd());
                            }


                            Console.Write("Choice the user to change payment(1-2-3): ");
                            bool checker2 = true;
                            int choice = ForIdCheck();
                            do
                            {
                                switch (choice)
                                {
                                    case 1:
                                        {
                                            Console.Write("Type new Payment amount to change: ");
                                            client.Payment = ForPaymentCheck();
                                            using (StreamWriter fileWriter2 = new StreamWriter($"{catalog}\nSomethingCopy.txt", false, System.Text.Encoding.Default))
                                            {
                                                fileWriter2.WriteLine($"\n Your Payment amount was changed - {client.Id} {client.PasNumber} { client.Payment }");
                                                fileWriter2.WriteLine($"\n Nothing was changed - {client1.Id} {client1.PasNumber} { client1.Payment }");
                                                fileWriter2.WriteLine($"\n Nothing was changed - {client2.Id} {client2.PasNumber} { client2.Payment }");
                                            }
                                            using (StreamReader fileReader = new StreamReader($"{catalog}\nSomethingCopy.txt"))
                                            {
                                                Console.WriteLine(fileReader.ReadToEnd());
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Type new Payment amount to change: ");
                                            client1.Payment = ForPaymentCheck();
                                            using (StreamWriter fileWriter2 = new StreamWriter($"{catalog}\nSomethingCopy.txt", false, System.Text.Encoding.Default))
                                            {
                                                fileWriter2.WriteLine($"\nNothing was changed - {client.Id} {client.PasNumber} { client.Payment }");
                                                fileWriter2.WriteLine($"\nYour Payment amount was changed - {client1.Id} {client1.PasNumber} { client1.Payment }");
                                                fileWriter2.WriteLine($"\nNothing was changed - {client2.Id} {client2.PasNumber} { client2.Payment }");
                                            }
                                            using (StreamReader fileReader = new StreamReader($"{catalog}\nSomethingCopy.txt"))
                                            {
                                                Console.WriteLine(fileReader.ReadToEnd());
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Type new Payment amount to change: ");
                                            client2.Payment = ForPaymentCheck();
                                            using (StreamWriter fileWriter2 = new StreamWriter($"{catalog}\nSomethingCopy.txt", false, System.Text.Encoding.Default))
                                            {
                                                fileWriter2.WriteLine($"\nNothing was changed - {client.Id} {client.PasNumber} { client.Payment }");
                                                fileWriter2.WriteLine($"\nNothing was changed - {client1.Id} {client1.PasNumber} { client1.Payment }");
                                                fileWriter2.WriteLine($"\nYour Payment amount was changed - {client2.Id} {client2.PasNumber} { client2.Payment }");
                                            }
                                            using (StreamReader fileReader = new StreamReader($"{catalog}\nSomethingCopy.txt"))
                                            {
                                                Console.WriteLine(fileReader.ReadToEnd());
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Write("You have only 3 choices, pls try agains: ");
                                            checker2 = false;
                                            break;
                                        }
                                }
                            } while (checker2 == false);



                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You can choose only 1st or 2nd number");
                            result = false;
                            break;
                        }
                }

            } while (result == false);
            Console.ReadKey();
        }

        

        //public static string CheckerForPas()
        //{
        //    string forPassCheck;

        //    bool checker;
        //    do
        //    {
        //        forPassCheck = Console.ReadLine();
        //        if (forPassCheck[0] != 'A' || forPassCheck[1] != 'Z' || forPassCheck[2] != 'E' || forPassCheck.Length <= 0)
        //        {
        //            Console.Write("You wrote the wrong symbol, try again: ");
        //            checker = false;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    } while (checker == false);
        //    return forPassCheck;
        //}

        static int ForIdCheck()
        {

            for (; ; )
            {
                string checkingNumber = Console.ReadLine();
                if (Int32.TryParse(checkingNumber, out int number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("You wrote the wrong symbol or digits aren't 3, try again: ");
                }
            }
        }

        static double ForPaymentCheck()
        {

            for (; ; )
            {
                string checkingNumber = Console.ReadLine();
                if (Double.TryParse(checkingNumber, out double number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("You wrote the wrong symbol, try again: ");
                }
            }
        }
    }
}
