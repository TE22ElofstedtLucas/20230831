﻿using System.Runtime.InteropServices;
using System.Xml.Serialization;

string choice = "";

Console.WriteLine("Du står i slutet av en labyrint");
Console.WriteLine("Till höger är det en mörk korridår");
Console.WriteLine("Till vänster är det en upplyst gång med en röd matta och en dörr som säger EXIT");
Console.WriteLine("Vart går du? höger eller vänster?");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "höger")
{
    Console.WriteLine("Du går in i den mörka korridåren och du ser ingenting.");
    Console.WriteLine("Du fortsätter gå och det blir ljusare och till slut ser du vägen ut");
    Console.WriteLine("Grattis du klarade labyrinten!");
}
else if (choice == "vänster")
{
    Console.WriteLine("Du går igenom den fina upplysta korridåren");
    Console.WriteLine("Du kommer närmare och närmare den sista dörren");
    Console.WriteLine("Du märker att det inte bara är en dörr utan två dörrar!");
    Console.WriteLine("Väljer du dörr nummer 1 eller dörr nummer 2?");

    

}
else if (choice == "nej")
{
    Console.WriteLine("Du skiter i de hela och går hem...");
    Console.WriteLine("Så smart!");
}


choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "1")
{
    Console.WriteLine("Du springer till dörr nummer 1");
    Console.WriteLine("Grattis! Du klarade dig!");
}
else if (choice == "2")
{
    Console.WriteLine("Du springer till dörr nummerr 2");
    Console.WriteLine("Åh nej! Du halkade på en dörrmatta och dog!");
    Console.WriteLine("Lite sämst...");
    Console.WriteLine("GAME OVER");
}


Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();