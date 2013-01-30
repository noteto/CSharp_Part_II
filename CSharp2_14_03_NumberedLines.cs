using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//3. Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

class NumberedLines
{
    static void Main()
    {
        StreamReader fileFirst = new StreamReader("../../nonumber.txt"); //the file is in the main folder of \Task_03

        using (fileFirst)
        {
            StreamWriter concat = new StreamWriter("../../numbered.txt"); //the file is in the main folder of \Task_03 and it's empty before starting the program
            using (concat)
            {
                string lineFile1;
                int number = 1;
                while ((lineFile1 = fileFirst.ReadLine()) != null)
                {
                    concat.Write(number + "." + " ");
                    concat.WriteLine(lineFile1);
                    number++;
                }
            }
        }

        Console.WriteLine("File lines have been numbered!!!\nCheck in \\HomeWork_C_14_TextFiles\\Task_03\\numbered.txt");
    }
}
