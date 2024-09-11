using System;

namespace TBA_PraL3
{
	public static class Instructions
	{
		public static void ShowInstructions()
		{
			Console.Clear();
			Console.WriteLine("Welkom bij het tekst-gebaseerde avontuur in het mystieke land Eldoria!");
			Console.WriteLine();
			Console.WriteLine("Hier is hoe je kunt beginnen en het meeste uit je avontuur kunt halen:");
			Console.WriteLine();
			Console.WriteLine("1. **Karakterselectie**: Aan het begin van het spel krijg je de mogelijkheid om een karakter te kiezen.");
			Console.WriteLine("   Je kunt kiezen uit Aric, Lyra of Galen. Elk karakter heeft unieke vaardigheden en een eigen achtergrondverhaal.");
			Console.WriteLine("   Kies het karakter dat je wilt spelen door het bijbehorende nummer in te voeren.");
			Console.WriteLine();
			Console.WriteLine("2. **De Wereld Verkennen**: Terwijl je door het spel navigeert, zul je verschillende scenario's tegenkomen en keuzes maken");
			Console.WriteLine("   die de uitkomst van het avontuur zullen beïnvloeden. Let goed op de beschrijvingen en opties die worden gepresenteerd.");
			Console.WriteLine();
			Console.WriteLine("3. **Keuzes Maken**: Je krijgt meerdere keuze-opties gepresenteerd. Typ het nummer dat overeenkomt met");
			Console.WriteLine("   jouw keuze en druk op Enter. Jouw beslissingen bepalen de richting van het verhaal en de uitdagingen die je tegenkomt.");
			Console.WriteLine();
			Console.WriteLine("4. **Het Einde van het Spel**: Je avontuur zal leiden tot verschillende eindes op basis van jouw keuzes.");
			Console.WriteLine("   Of je nu slaagt in het verbreken van de vloek, faalt in je missie, of een middenweg vindt, elk einde zal de uitkomsten van jouw reis weerspiegelen.");
			Console.WriteLine();
			Console.WriteLine("Geniet van je avontuur in Eldoria en moge jouw keuzes leiden tot een triomfantelijke conclusie!");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
