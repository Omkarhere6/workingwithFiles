using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace workingwithFiles
{
    internal class Xmlmethods
    {
        public void CreateXml()
        {
            Console.WriteLine("\t\t\t\tWhere do you want to create the file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to create : ");
                string path = Console.ReadLine();
                Console.WriteLine("\t\t\t\tEnter the file name you want to create : ");
                string Fname = Console.ReadLine();
                string Fpath = path + "/" + Fname + ".xml";
                using (XmlWriter writer = XmlWriter.Create(Fpath))
                {
                    Console.WriteLine("\t\t\t\tFile created successfully");
                    Console.WriteLine("\t\t\t\t" + Fpath);
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\XML";
                Console.WriteLine("\t\t\t\tEnter the file name you want to create : ");
                string file = Console.ReadLine();
                string filepath = userpath + "/" + file + ".xml";
                
                using (XmlWriter writer = XmlWriter.Create(filepath))
                {
                    Console.WriteLine("\t\t\t\tFile created successfully At");
                    Console.WriteLine("\t\t\t\t" + filepath);
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

        }

        public void WriteXml()
        {
            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Write : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".xml";
                if (File.Exists(filename))
                {
                    Console.WriteLine("\t\t\t\t" + filename);
                    Console.WriteLine("Enter the number of Empoyee you want to add");
                    string inp = Console.ReadLine();
                    int no = Convert.ToInt32(inp);
                    if (no == 0)
                    {
                        Console.WriteLine("Enter the appropriate number of employes you want to add ");

                    }
                    else
                    {
                        XElement element = new XElement("Employees");
                        element.Save(filename);

                        XElement doc = XElement.Load(filename);
                        for (int i = 1; i <= no; i++)
                        {
                            //Empclass E = new Empclass();
                            Console.WriteLine("Enter the Name of the employee");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the Designation of the employee");
                            string Designation = Console.ReadLine();
                            Console.WriteLine("Enter the ID of the employee");
                            string ID = Console.ReadLine();
                            Console.WriteLine("Enter the Email of the employee");
                            string Email = Console.ReadLine();

                            XElement employee = new XElement("Employees",
                                                            new XElement("Employee",
                                                                                        new XElement("Name",
                                                                                                    name),
                                                                                        new XElement("Designation",
                                                                                                    Designation),
                                                                                        new XElement("EmployeeID",
                                                                                                    ID),
                                                                                        new XElement("Email",
                                                                                                    Email)));
                            doc.Add(employee);

                        }
                        doc.Save(filename);
                        Console.WriteLine("\t\t\t\tWritten to file Successfully");
                    }

                }
                else
                {
                    Console.WriteLine("File doesnot exists at the path");
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\XML";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
                string str = "";
                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = userpath + "/" + file + ".xml";
                if (!File.Exists(filename))
                {
                    Console.WriteLine("\t\t\t\t\tFile doesnot exist");
                }
                else
                {
                    Console.WriteLine("\t\t\t\t" + filename);
                    Console.WriteLine("Enter the number of Empoyee you want to add");
                    string inp = Console.ReadLine();
                    int no = Convert.ToInt32(inp);
                    if (no == 0)
                    {
                        Console.WriteLine("Enter the appropriate number of employes you want to add ");

                    }
                    else
                    {
                        XElement element = new XElement("Employees");
                        //element.Save(filename);

                        XElement doc = XElement.Load(filename);
                        for (int i = 1; i <= no; i++)
                        {
                            //Empclass E = new Empclass();
                            Console.WriteLine("Enter the Name of the employee");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the Designation of the employee");
                            string Designation = Console.ReadLine();
                            Console.WriteLine("Enter the ID of the employee");
                            string ID = Console.ReadLine();
                            Console.WriteLine("Enter the Email of the employee");
                            string Email = Console.ReadLine();

                            XElement employee = new XElement("Employees",
                                                            new XElement("Employee",
                                                                                        new XElement("Name",
                                                                                                    name),
                                                                                        new XElement("Designation",
                                                                                                    Designation),
                                                                                        new XElement("EmployeeID",
                                                                                                    ID),
                                                                                        new XElement("Email",
                                                                                                    Email)));
                            doc.Add(employee);

                        }
                        doc.Save(filename);
                        Console.WriteLine("\t\t\t\tWritten to file Successfully");
                    }

                }
            }
        }

        public void ReadXml()
        {
            Console.WriteLine("\t\t\t\tWhere do you want to create the file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to create : ");
                string path = Console.ReadLine();
                Console.WriteLine("\t\t\t\tEnter the file name you want to create : ");
                string Fname = Console.ReadLine();
                string Fpath = path + "/" + Fname + ".xml";
                Console.WriteLine("\t\t\t\tThe Contents of the file are : ");
                using (XmlReader reader = XmlReader.Create(Fpath))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "Name":
                                    Console.WriteLine("Name of the Employee is : " + reader.ReadString());
                                    break;
                                case "Designation":
                                    Console.WriteLine("Designation of the Employee is : " + reader.ReadString());
                                    break;
                                case "EmployeeID":
                                    Console.WriteLine("ID of the Employee is : " + reader.ReadString());
                                    break;
                                case "Email":
                                    Console.WriteLine("Email of the Employee is : " + reader.ReadString());
                                    break;

                            }
                        }
                        Console.WriteLine("");
                    }
                }
                Console.ReadKey();
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\XML";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
                string str = "";
                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = userpath + "/" + file + ".xml";
                if (!File.Exists(filename))
                {
                    Console.WriteLine("\t\t\t\t\tFile doesnot exist");
                }
                else
                {
                    Console.WriteLine("\t\t\t\tThe Contents of the file are : ");
                    using (XmlReader reader = XmlReader.Create(filename))
                    {
                        while (reader.Read())
                        {
                            if (reader.IsStartElement())
                            {
                                //return only when you have START tag  
                                switch (reader.Name.ToString())
                                {
                                    case "Name":
                                        Console.WriteLine("Name of the Employee is : " + reader.ReadString());
                                        break;
                                    case "Designation":
                                        Console.WriteLine("Designation of the Employee is : " + reader.ReadString());
                                        break;
                                    case "EmployeeID":
                                        Console.WriteLine("ID of the Employee is : " + reader.ReadString());
                                        break;
                                    case "Email":
                                        Console.WriteLine("Email of the Employee is : " + reader.ReadString());
                                        break;
                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                    Console.ReadKey();
                }

            }
        }

        public void DeleteXml()
        {
            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Delete : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to delete  : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".xml";

                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    Console.WriteLine("\t\t\t\tFile deleted.");
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\tFile not found");
                }

            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\XML";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to delete : ");
                string file = Console.ReadLine();
                string filename = file + ".xml";
                if (File.Exists(Path.Combine(userpath, filename)))
                {

                    File.Delete(Path.Combine(userpath, filename));
                    Console.WriteLine("\t\t\t\tFile deleted.");
                }
                else Console.WriteLine("\t\t\t\t\tFile not found");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }

        public void CopyXml()
        {
            Console.WriteLine("\t\t\t\tEnter the path of the file you want to Copy from : ");
            string sourcepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(sourcepath);
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                Console.WriteLine("\t\t\t\t\t" + str);
            }

            Console.WriteLine("\t\t\t\tEnter the file name you want to copy from : ");
            string srcfile = Console.ReadLine();
            string srcfilename = srcfile + ".xml";
            string source = sourcepath + "/" + srcfilename;
            if (!File.Exists(source))
            {
                Console.WriteLine("\t\t\t\t\tFile doesnot exist");
            }
            else
            {

                Console.WriteLine("\t\t\t\t\tEnter the path of the file you want to Copy to : ");
                string destinationpath = Console.ReadLine();
                string desfilename = srcfile + ".xml";
                string destination = destinationpath + "/" + desfilename;
                File.Copy(source, destination, true);
                Console.WriteLine("\t\t\t\t\tCopied successfully");
            }
        }

        public void MoveXml()
        {
            Console.WriteLine("\t\t\t\tEnter the path of the file you want to move from : ");
            string sourcepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(sourcepath);
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                Console.WriteLine("\t\t\t\t\t" + str);

            }

            Console.WriteLine("\t\t\t\tEnter the file name you want to move  : ");
            string srcfile = Console.ReadLine();
            string srcfilename = srcfile + ".xml";
            string source = sourcepath + "/" + srcfilename;
            if (!File.Exists(source))
            {
                Console.WriteLine("\t\t\t\tFile doesnot exist");
            }
            else
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to move to : ");
                string destinationpath = Console.ReadLine();
                string desfilename = srcfile + ".xml";
                string destination = destinationpath + "/" + desfilename;
                if (File.Exists(destination))
                    File.Delete(destination);

                File.Move(source, destination);
                Console.WriteLine("\t\t\t\t\tMoved successfully");
            }

        }
    }
}








