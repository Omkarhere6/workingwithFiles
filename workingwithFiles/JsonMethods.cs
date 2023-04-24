using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace workingwithFiles
{
    internal class JsonMethods
    {
        public void CreateJson()
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
                string Fpath = path + "/" + Fname + ".json";
                using (var tw = new StreamWriter(Fpath))
                {
                    Console.WriteLine("\t\t\t\tFile created successfully");
                    Console.WriteLine("\t\t\t\t" + Fpath);
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\JSON";
                Console.WriteLine("\t\t\t\tEnter the file name you want to create : ");
                string file = Console.ReadLine();
                string filepath = userpath + "/" + file + ".json";

                using (var tw = new StreamWriter(filepath))
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

        public void WriteJson()
        {

            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Write : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".json";
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

                        for (int i = 1; i <= no; i++)
                        {
                            Empclass emp = new Empclass();

                            Console.WriteLine("Enter the Employee Name");
                            emp.E_Name = Console.ReadLine();
                            Console.WriteLine("Enter the Employee ID");
                            emp.E_Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Employee Designation");
                            emp.E_Designation = Console.ReadLine();
                            Console.WriteLine("Enter the Employee Email id");
                            emp.E_Email = Console.ReadLine();
                            string JSONresult = JsonConvert.SerializeObject(emp);
                            using (var tw = new StreamWriter(filename, true))
                            {
                                tw.WriteLine(JSONresult.ToString());
                                tw.Close();
                                Console.WriteLine("\t\t\t\tWritten to file successfully");
                            }
                        }
                    }
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\JSON";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
                string str = "";
                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = userpath + "/" + file + ".json";
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
                        for (int i = 1; i <= no; i++)
                        {
                            Empclass emp = new Empclass();

                            Console.WriteLine("Enter the Employee Name");
                            emp.E_Name = Console.ReadLine();
                            Console.WriteLine("Enter the Employee ID");
                            emp.E_Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Employee Designation");
                            emp.E_Designation = Console.ReadLine();
                            Console.WriteLine("Enter the Employee Email id");
                            emp.E_Email = Console.ReadLine();
                            string JSONresult = JsonConvert.SerializeObject(emp);
                            using (var tw = new StreamWriter(filename, true))
                            {
                                tw.WriteLine(JSONresult.ToString());
                                tw.Close();
                                Console.WriteLine("\t\t\t\tWritten to file successfully");
                            }
                        }

                    }
                }
            }

        }

        public void ReadJson()
        {
            Console.WriteLine("\t\t\t\tWhere is your file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to read : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
                string str = "";
                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to read : ");
                string Fname = Console.ReadLine();
                string Fpath = path + "/" + Fname + ".json";
                Console.WriteLine("\t\t\t\tThe contents of the file are");
                String getStrinFromFile = File.ReadAllText(Fpath);
                Console.WriteLine(getStrinFromFile);
               
            }
            else if(ch == 2)
            {
                string path = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\JSON"; 
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
                string str = "";
                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to read : ");
                string Fname = Console.ReadLine();
                string Fpath = path + "/" + Fname + ".json";
                Console.WriteLine("\t\t\t\tThe contents of the file are");
                String getStrinFromFile = File.ReadAllText(Fpath);
                Console.WriteLine(getStrinFromFile);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }

        public void DeleteJson()
        {
            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Delete : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to delete  : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".json";

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
                FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to delete : ");
                string file = Console.ReadLine();
                string filename = file + ".json";
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
    

        public void CopyJson()
        {
            Console.WriteLine("\t\t\t\tEnter the path of the file you want to Copy from : ");
            string sourcepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(sourcepath);
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                Console.WriteLine("\t\t\t\t\t" + str);
            }

            Console.WriteLine("\t\t\t\tEnter the file name you want to copy from : ");
            string srcfile = Console.ReadLine();
            string srcfilename = srcfile + ".json";
            string source = sourcepath + "/" + srcfilename;
            if (!File.Exists(source))
            {
                Console.WriteLine("\t\t\t\t\tFile doesnot exist");
            }
            else
            {

                Console.WriteLine("\t\t\t\t\tEnter the path of the file you want to Copy to : ");
                string destinationpath = Console.ReadLine();
                string desfilename = srcfile + ".json";
                string destination = destinationpath + "/" + desfilename;
                File.Copy(source, destination, true);
                Console.WriteLine("\t\t\t\t\tCopied successfully");
            }

        }

        public void MoveJson()
        {
            Console.WriteLine("\t\t\t\tEnter the path of the file you want to move from : ");
            string sourcepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(sourcepath);
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                Console.WriteLine("\t\t\t\t\t" + str);

            }

            Console.WriteLine("\t\t\t\tEnter the file name you want to move  : ");
            string srcfile = Console.ReadLine();
            string srcfilename = srcfile + ".json";
            string source = sourcepath + "/" + srcfilename;
            if (!File.Exists(source))
            {
                Console.WriteLine("\t\t\t\tFile doesnot exist");
            }
            else
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to move to : ");
                string destinationpath = Console.ReadLine();
                string desfilename = srcfile + ".json";
                string destination = destinationpath + "/" + desfilename;
                if (File.Exists(destination))
                    File.Delete(destination);
                File.Move(source, destination);
                Console.WriteLine("\t\t\t\t\tMoved successfully");
            }

        }
    }
}
