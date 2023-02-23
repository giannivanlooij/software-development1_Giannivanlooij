// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");

public enum bell
{
    cyclebell,
    airhorn
}

public enum color
{
    black,
    yellow,
    blue,
    green,
    red,
}




public class bike
{
    color color;
    int frameheight;
    bell bell;
   

    public bike(color color, int frameheight, bell bell)
    {
        this.color = color;
        this.frameheight = frameheight;
        this.bell = bell;
    }


    //afdrukken?

    readonly List<bike> bikes = new List<bike>
    {
    readonly bike blackbike = new(color.black, 10, bell.airhorn);
    readonly bike yellowbike = new(color.yellow, 8, bell.cyclebell);
    readonly bike bluebike = new(color.blue, 9, bell.airhorn);
    };

    // You can convert it back to an array if you would like to
    //bike[] bikes = bikes.ToArray();



static void Main()
    {
        
    }


    

}

