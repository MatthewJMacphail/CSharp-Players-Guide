// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
string itemName = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string descriptiveOfItem = Console.ReadLine();
string itemFlairName = "of Doom";
string itemVersion = "3000";
Console.WriteLine("The " + descriptiveOfItem + " " + itemName + " of " + itemFlairName + " " + itemVersion + "!");