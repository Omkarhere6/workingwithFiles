using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingwithFiles
{
    internal class TextMethods
    {
        public void createFile()
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
                string Fpath = path + "/" + Fname + ".txt";

                Console.WriteLine("\t\t\t\t" + Fpath);
                using (StreamWriter sw = File.CreateText(Fpath))
                {
                    Console.WriteLine("\t\t\t\tFile created successfully");
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\Text";
                Console.WriteLine("\t\t\t\tEnter the file name you want to create : ");
                string file = Console.ReadLine();
                string filename = userpath + "/" + file + ".txt";
                Console.WriteLine("\t\t\t\t" + userpath);
                using (StreamWriter sw = File.CreateText(filename))
                {
                    Console.WriteLine("\t\t\t\tFile created successfully");
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

        }

        public void WriteFile()
        {
            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Write : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".txt";
                if (File.Exists(filename))
                {
                    Console.WriteLine("\t\t\t\t" + filename);
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        Console.WriteLine("\t\t\t\tEnter the text you want to add to the file");
                        string st = Console.ReadLine();
                        writer.WriteLine(st);
                        Console.WriteLine("\t\t\t\tWritten successfully to the file : " + file + ".txt");

                    }

                }
                else
                {
                    Console.WriteLine("\t\t\t\t\tFile doesnot exist");
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\Text";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "";
                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to write to : ");
                string file = Console.ReadLine();
                string filename = userpath + "/" + file + ".txt";
                if (!File.Exists(userpath))
                {
                    Console.WriteLine("\t\t\t\t\tFile doesnot exist");
                }
                else
                {
                    Console.WriteLine("\t\t\t\t" + filename);
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        Console.WriteLine("\t\t\t\tEnter the text you want to add to the file");
                        string st = Console.ReadLine();
                        writer.WriteLine(st);
                        Console.WriteLine("\t\t\t\tWritten successfully to the file : " + file + ".txt");

                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid choice ");
            }
        }

        public void ReadFile()
        {
            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Read : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to Read  : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".txt";
                if (!File.Exists(filename))
                {
                    Console.WriteLine("\t\t\t\t\tFile doesnot exist");
                }
                else
                {
                    Console.WriteLine("\t\t\t\tThe pathe you entered is :" + filename);
                    if (File.Exists(filename))
                    {
                        Console.WriteLine("\t\t\t\tThe text avaliable in file is : \r\n");
                        string readText = File.ReadAllText(filename);
                        Console.WriteLine("\t\t\t[" + readText + "]");
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t\t\tInvalid path");
                    }
                }
            }
            else if (ch == 2)
            {
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\Text";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to read : ");
                string file = Console.ReadLine();
                string filename = userpath + "/" + file + ".txt";
                if (!File.Exists(filename))
                {
                    Console.WriteLine("\t\t\t\t\tFile doesnot exist");
                }
                else
                {
                    Console.WriteLine("\t\t\t\tThe pathe you entered is :" + filename);
                    if (File.Exists(filename))
                    {
                        Console.WriteLine("\t\t\t\tThe text avaliable in file is : \r\n");
                        string readText = File.ReadAllText(filename);
                        Console.WriteLine("\t\t\t[\n" + readText + "\n]");
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t\t\tInvalid path");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        public void Deletefile()
        {
            Console.WriteLine("\t\t\t\tWhere is your  file ?");
            Console.WriteLine("\t\t\t\t1.Specify the directory\n \t\t\t\t2.In the Default directory");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to Delete : ");
                string path = Console.ReadLine();
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to delete : ");
                string file = Console.ReadLine();
                string filename = path + "/" + file + ".txt";

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
                string userpath = "C:\\Users\\OHawaldar\\Documents\\WorkingWithFiles\\Text";
                DirectoryInfo d = new DirectoryInfo(userpath);
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "";

                foreach (FileInfo f in Files)
                {
                    str = f.Name;
                    Console.WriteLine("\t\t\t\t\t" + str);
                }
                Console.WriteLine("\t\t\t\tEnter the file name you want to delete : ");
                string file = Console.ReadLine();
                string filename = file + ".txt";
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

        public void CopyTextFile()
        {
            Console.WriteLine("\t\t\t\tEnter the path of the file you want to Copy from : ");
            string sourcepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(sourcepath);
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                Console.WriteLine("\t\t\t\t\t" + str);
            }

            Console.WriteLine("\t\t\t\tEnter the file name you want to copy from : ");
            string srcfile = Console.ReadLine();
            string srcfilename = srcfile + ".txt";
            string source = sourcepath + "/" + srcfilename;
            if (!File.Exists(source))
            {
                Console.WriteLine("\t\t\t\t\tFile doesnot exist");
            }
            else
            {

                Console.WriteLine("\t\t\t\t\tEnter the path of the file you want to Copy to : ");
                string destinationpath = Console.ReadLine();
                string desfilename = srcfile + ".txt";
                string destination = destinationpath + "/" + desfilename;
                File.Copy(source, destination, true);
                Console.WriteLine("\t\t\t\t\tCopied successfully");
            }


        }

        public void MoveTextFile()
        {
            Console.WriteLine("\t\t\t\tEnter the path of the file you want to move from : ");
            string sourcepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(sourcepath);
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                Console.WriteLine("\t\t\t\t\t" + str);

            }

            Console.WriteLine("\t\t\t\tEnter the file name you want to move  : ");
            string srcfile = Console.ReadLine();
            string srcfilename = srcfile + ".txt";
            string source = sourcepath + "/" + srcfilename;
            if (!File.Exists(source))
            {
                Console.WriteLine("\t\t\t\tFile doesnot exist");
            }
            else
            {
                Console.WriteLine("\t\t\t\tEnter the path of the file you want to move to : ");
                string destinationpath = Console.ReadLine();
                string desfilename = srcfile + ".txt";
                string destination = destinationpath + "/" + desfilename;
                if (File.Exists(destination))
                    File.Delete(destination);

                File.Move(source, destination);
                Console.WriteLine("\t\t\t\t\tMoved successfully");
            }
        }
    }
}
