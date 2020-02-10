using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        //string path = @"D:/b.txt";
        FileStream f = new FileStream("D:\\b.txt", FileMode.OpenOrCreate);//creating file stream  
        for (int i = 65; i <= 90; i++)
        {
            f.WriteByte((byte)i);
        }  //writing byte into stream  
        f.Close();//closing stream  


        //StreamWriter s = File.AppendText(path);       
        //     {
        //         s.WriteLine("hi this is rohith");
        //     }
        // s.Close();
        //StreamReader sr = File.OpenText(path);
        //    {
        //        string s1 = "";
        //        while ((s1 = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(s1);
        //        }
        //    }
        
        //sr.Close();
        Console.ReadKey();
    }
}