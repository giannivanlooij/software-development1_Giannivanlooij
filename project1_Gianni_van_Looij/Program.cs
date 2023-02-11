// See https://aka.ms/new-console-template for more information
Console.WriteLine("challenge 1: ");
Console.WriteLine("first enter name.");
string name1 = Console.ReadLine();
Console.WriteLine("now enter age.");
int age1 = int.Parse(Console.ReadLine());

Console.WriteLine(Environment.NewLine +"Hello " + name1 + " nice to meet you, you are " + age1 + " old. ");
Console.WriteLine(name1 + " will be " + (age1 + 10) + " years old in 10 years. " + Environment.NewLine);
Console.WriteLine("challenge 2:");
Console.WriteLine("first enter name.");
string name2 = Console.ReadLine();
Console.WriteLine("now enter lastname.");
string lastname2 = Console.ReadLine();
Console.WriteLine("now enter age.");
int age2 = int.Parse(Console.ReadLine());

Console.WriteLine(Environment.NewLine +"geachte heer/mevrouw " + lastname2  + "," + Environment.NewLine + "beste " + name2 + ", over " + (65 - age2) + " jaar" + " kunt u de 65+ pas aanvragen." + Environment.NewLine);