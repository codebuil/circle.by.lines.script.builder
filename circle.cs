using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.White;
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: program.exe x y raio");
            return;
        }
        int xx = 0;
        int yy = 0;
        int xx2 = 0;
        int yy2 = 0;
        double x = Double.Parse(args[0]);
        double y = Double.Parse(args[1]);
        double raio = Double.Parse(args[2]);

        string fileName = "output.svg";
        StreamWriter sw = new StreamWriter(fileName);

        sw.WriteLine("<svg xmlns='http://www.w3.org/2000/svg' version='1.1'>\r\n <rect width=\"100%\" height=\"100%\" fill=\"#00f\"/>\r\n");

        double delta = Math.PI / 12;
        for (int i = 0; i < 24; i++)
        {
            double angle = i * delta;
            double x1 = x + raio * Math.Cos(angle);
            double y1 = y + raio * Math.Sin(angle);
            angle = (i+1) * delta;
            if(i==23) angle =0 * delta;
            double x2 = x + raio * Math.Cos(angle);
            double y2 = y + raio * Math.Sin(angle);
            xx =(int) x1;
            yy = (int)y1;
            xx2 = (int)x2;
            yy2 = (int)y2;

            sw.WriteLine("<line x1='" + xx + "' y1='" + yy + "' x2='" + xx2 + "' y2='" + yy2 + "' stroke='black' stroke-width='2'/>");
        }

        sw.WriteLine("</svg>");
        sw.Close();

        Console.WriteLine("File created: " + fileName);
    }
}
