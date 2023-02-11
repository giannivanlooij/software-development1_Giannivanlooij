// See https://aka.ms/new-console-template for more information

static void Opdracht1()
{
    Console.WriteLine("challenge 1: ");
    Console.WriteLine("first enter name.");
    string name1 = Console.ReadLine();
    Console.WriteLine("now enter age.");
    int age1 = int.Parse(Console.ReadLine());

    Console.WriteLine(Environment.NewLine + "Hello " + name1 + " nice to meet you, you are " + age1 + " old. ");
    Console.WriteLine(name1 + " will be " + (age1 + 10) + " years old in 10 years. " + Environment.NewLine);
    Console.WriteLine("challenge 2:");
    Console.WriteLine("first enter name.");
    string name2 = Console.ReadLine();
    Console.WriteLine("now enter lastname.");
    string lastname2 = Console.ReadLine();
    Console.WriteLine("now enter age.");
    int age2 = int.Parse(Console.ReadLine());

    Console.WriteLine(Environment.NewLine + "geachte heer/mevrouw " + lastname2 + "," + Environment.NewLine + "beste " + name2 + ", over " + (65 - age2) + " jaar" + " kunt u de 65+ pas aanvragen." + Environment.NewLine);
}

//static void Opdracht2()
//{
    string path = @"C:\wamp64\www\school\windesheim\periode 3-4\software development1\project1_Gianni_van_Looij\opdracht2.txt";
    string text = File.ReadAllText(path);
    // this checks if there is text, wich means that it exists. i tried methods like:
    // Directory.EnumerateFiles(path) but it didnt like the path i used. thats why I use this method
   
    if (File.Exists(path))
    {
        Console.WriteLine("File not found.");
        return;
    }

    // stuck on the second part of the assignment
//}



//static void Main(string[] args)
//{
//    Opdracht1();
//    Opdracht2();
//}







