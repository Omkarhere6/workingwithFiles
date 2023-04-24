using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static workingwithFiles.TextMethods;

namespace workingwithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool M = true;
            while (M)
            {
                Console.WriteLine("\t\t\t\tWhere do you want to create the file ?");
                Console.WriteLine("\t\t\t\t\t1.Working with TEXT files\n \t\t\t\t\t2.Working with XML files\n \t\t\t\t\t3.Working with JSON files\n \t\t\t\t\t4.EXIT FILE SYSTEM");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    TextMethods txtfl = new TextMethods();
                    bool A = true;
                    while (A)
                    {
                        Console.WriteLine("---------------------------------------- Working With Text Files -----------------------------------------------------");
                        Console.WriteLine("                         PLEASE SELECT THE CHOICE FROM THE BELOW OPTIONS                          ");
                        Console.WriteLine("\t\t\t\t\t1.CREATE TEXT FILE\r\n" + "\t\t\t\t\t2.WRITE TEXT FILE\r\n" + "\t\t\t\t\t3.READ TEXT FILE\r\n" + "\t\t\t\t\t4.DELETE TEXT FILE\r\n" + "\t\t\t\t\t5.COPY TO TEXT FILE\r\n" + "\t\t\t\t\t6.MOVE TEXT FILE\r\n" + "\t\t\t\t\t7.EXIT\r\n");
                        Console.WriteLine("\t\t\t\t\tEnter Your Choice : ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0 || choice > 7)
                        {
                            Console.WriteLine("\t\t\t\t\tEnter the correct choice ");
                        }
                        else
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                            switch (choice)
                            {
                                case 1:
                                    txtfl.createFile();
                                    break;
                                case 2:
                                    txtfl.WriteFile();
                                    break;
                                case 3:
                                    txtfl.ReadFile();
                                    break;
                                case 4:
                                    txtfl.Deletefile();
                                    break;
                                case 5:
                                    txtfl.CopyTextFile();
                                    break;
                                case 6:
                                    txtfl.MoveTextFile();
                                    break;
                                case 7:
                                    A = false;
                                    break;
                            }
                        }
                    }
                }
                else if (ch == 2)
                {
                    Xmlmethods Xmlfl = new Xmlmethods();
                    bool A = true;
                    while (A)
                    {
                        Console.WriteLine("\t\t\tNOTE : Only the employee Details can be created for mow will give further updates");
                        Console.WriteLine("---------------------------------------- Working With XML Files -----------------------------------------------------");
                        Console.WriteLine("                         PLEASE SELECT THE CHOICE FROM THE BELOW OPTIONS                          ");
                        Console.WriteLine("\t\t\t\t\t1.CREATE XML FILE\r\n" + "\t\t\t\t\t2.WRITE XMl FILE\r\n" + "\t\t\t\t\t3.READ XML FILE\r\n" + "\t\t\t\t\t4.DELETE\r\n" + "\t\t\t\t\t5.COPY XML FILE\r\n" + "\t\t\t\t\t6.MOVE XML FILE\r\n" + "\t\t\t\t\t7.EXIT\r\n");
                        Console.WriteLine("\t\t\t\t\tEnter Your Choice : ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0 || choice > 7)
                        {
                            Console.WriteLine("\t\t\t\t\tEnter the correct choice ");
                        }
                        else
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                            switch (choice)
                            {
                                case 1:
                                    Xmlfl.CreateXml();
                                    break;
                                case 2:
                                    Xmlfl.WriteXml();
                                    break;
                                case 3:
                                    Xmlfl.ReadXml();
                                    break;
                                case 4:
                                    Xmlfl.DeleteXml();
                                    break;
                                case 5:
                                    Xmlfl.CopyXml();
                                    break;
                                case 6:
                                    Xmlfl.MoveXml();
                                    break;
                                case 7:
                                    A = false;
                                    break;
                            }
                        }
                    }
                }
                else if (ch == 3)
                {
                    JsonMethods Xmlfl = new JsonMethods();
                    bool A = true;
                    while (A)
                    {
                        Console.WriteLine("\t\t\tNOTE : Only the employee Details can be created for mow will give further updates");
                        Console.WriteLine("---------------------------------------- Working With JSON Files -----------------------------------------------------");
                        Console.WriteLine("                         PLEASE SELECT THE CHOICE FROM THE BELOW OPTIONS                          ");
                        Console.WriteLine("\t\t\t\t\t1.CREATE JSON FILE\r\n" + "\t\t\t\t\t2.WRITE JSON FILE\r\n" + "\t\t\t\t\t3.READ JSON FILE\r\n" + "\t\t\t\t\t4.DELETE\r\n" + "\t\t\t\t\t5.COPY JSON FILE\r\n" + "\t\t\t\t\t6.MOVE JSON FILE\r\n" + "\t\t\t\t\t7.EXIT\r\n");
                        Console.WriteLine("\t\t\t\t\tEnter Your Choice : ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0 || choice > 7)
                        {
                            Console.WriteLine("\t\t\t\t\tEnter the correct choice ");
                        }
                        else
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                            switch (choice)
                            {
                                case 1:
                                    Xmlfl.CreateJson();
                                    break;
                                case 2:
                                    Xmlfl.WriteJson();
                                    break;
                                case 3:
                                    Xmlfl.ReadJson();
                                    break;
                                case 4:
                                    Xmlfl.DeleteJson();
                                    break;
                                case 5:
                                    Xmlfl.CopyJson();
                                    break;
                                case 6:
                                    Xmlfl.MoveJson();
                                    break;
                                case 7:
                                    A = false;
                                    break;
                            }
                        }
                    }
                }
                else if (ch == 4)
                {
                    M = false;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\tINVALID CHOICE !!!!!!!");
                }
            }
        }
    }
}
