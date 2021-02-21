using System;
public class BinaryConverter
{
    public static void Main()
    {
        //variables section
        string binary;

        string result;

        //input section
        Console.Write("Yek Adad Vared Konid : ");
        binary = Console.ReadLine();

        //convert and result section
        int num = Convert.ToInt32(binary);
        result = "";
        while (num > 1)
        {
            int reminder = num % 2;
            result = Convert.ToString(reminder) + result;
            num /= 2;
        }
        result = Convert.ToString(num) + result;
        Console.WriteLine("Converted To Binary: {0}", result);


        Console.ReadKey();
        //developed by : Amirabbas Dorasay
    }
}
