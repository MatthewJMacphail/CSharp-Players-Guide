// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
string itemName = Console.ReadLine(); // The name of the Item in question
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string descriptiveOfItem = Console.ReadLine(); /* Stores the condition/property of the item e.g. Large, Azure etc. */
string itemFlairName = "of Doom"; // A 'flair' to add aura to the item
string itemVersion = "3000"; // Stores the item version (?)
Console.WriteLine("The " + descriptiveOfItem + " " + itemName + " " + itemFlairName + " " + itemVersion + "!");