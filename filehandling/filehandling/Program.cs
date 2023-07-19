using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex-1

            //string path = " F:\\Day - 8\\Demo";
            //string fname;
            //Console.WriteLine("enter file name");
            //fname = Console.ReadLine();
            //string fPath = path + fname;
            //if (File.Exists(fPath))
            //{
            //    Console.WriteLine("the file is already exist!!");
            //}
            //else
            //{
            //    File.Create(fPath);
            //    Console.WriteLine("file created!!");

            //}
            //Console.ReadKey();


            //ex- 2

            //Console.WriteLine("enter file path");
            //string fPath = Console.ReadLine();
            //if (File.Exists(fPath))
            //{
            //    Console.WriteLine("file already there!!");
            //}
            //else
            //{
            //    StreamWriter sw = File.AppendText(fPath);
            //    sw.WriteLine("Welcome to stream writing example");
            //    sw.Dispose();
            //    sw.Close();

            //    Console.WriteLine("created and text is written!!");

            //}
            //Console.ReadKey();


            //ex- 3

            //StreamReader sr;
            //try
            //{
            //    string fpath = "F:\\Day - 8\\viya.txt";
            //    sr = new StreamReader(fpath);
            //    string text = "";
            //    while ((text = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(text);
            //    }
            //    sr.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.ReadKey();
            //}



            //ex- 4

            //try
            //{
            //    string path = "F:\\";
            //    Console.WriteLine("enter file name to read out from");
            //    string fName = Console.ReadLine();
            //    string fpath = path + fName;
            //    if (File.Exists(fpath))
            //    {
            //        string[] lines = File.ReadAllLines(fpath);
            //        foreach (string line in lines)
            //        {

            //            Console.WriteLine(line);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("file does not exist");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error!! " + ex.Message);

            //}
            //finally
            //{

            //    Console.ReadKey();
            //}




            //ex - 5

            try
            {
                string path = "F:\\";
                Console.WriteLine("enter file name to delete");
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (File.Exists(fpath))
                {
                    File.Delete(fpath);
                    Console.WriteLine("File delete permanently");
                }

                else
                {
                    Console.WriteLine("file does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error!! " + ex.Message);

            }
            finally
            {

                Console.ReadKey();
            }
        }
    }
}

