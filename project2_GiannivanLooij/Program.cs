// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");

enum bell
{
    cyclebell,
    airhorn
}

enum color
{
    black,
    yellow,
    blue,
    green,
    red,
}




public class bike
{
    string color;
    int frameheight;
    string bell;
   

    public bike(string color, int frameheight, string bell)
    {
        this.color = color;
        this.frameheight = frameheight;
        this.bell = bell;
    }

    static void Main()
    {
        blackbike = new bike(color.black, 12, bell.cyclebell);
    }


    

}

