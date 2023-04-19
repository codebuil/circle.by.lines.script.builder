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

        string fileName = "output.bat";
        StreamWriter sw = new StreamWriter(fileName);


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

            sw.WriteLine("line," + xx.ToString() + "," + yy.ToString() + "," + xx2.ToString() + "," + yy2.ToString());
        }


        sw.Close();

        Console.WriteLine("File created: " + fileName);
    }
}
