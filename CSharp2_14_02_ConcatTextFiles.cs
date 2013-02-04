using System;
using System.IO;
using System.Text;
     
//Write a program that concatenates two text files into another text file.

public class Program
{
    static void Main()
    {
        StreamReader readFirstFile = new StreamReader("text.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader readSecondFile = new StreamReader("numbers.txt", Encoding.GetEncoding("windows-1251"));
        StreamWriter outputFile = new StreamWriter("new.txt");

        using (readFirstFile)
        {
            using (readSecondFile)
            {
                using (outputFile)
                {
                    string file1 = readFirstFile.ReadToEnd();
                    string file2 = readSecondFile.ReadToEnd();
                    string concat = file1 + file2;
                    outputFile.WriteLine(concat);
                }
            }
        }
    }
}
