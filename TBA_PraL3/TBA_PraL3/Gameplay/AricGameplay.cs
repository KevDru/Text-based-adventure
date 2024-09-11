using System;

class Aric
{
	public static void StartAvontuur()
	{
		Console.WriteLine("Welkom bij het avontuur van Aric in het vervloekte Koninkrijk Eldoria!");
		Console.WriteLine("Aric, een magiër die stormmagie beheerst, staat voor een gevaarlijke missie: de eeuwenoude vloek van Eldoria verbreken.");
		Console.WriteLine("Jouw keuzes zullen het lot van Aric en Eldoria bepalen. Kies wijs!");
		Console.WriteLine();

		Console.WriteLine("Aric staat aan de rand van de ruïnes van de oude hoofdstad, waar het mysterieuze artefact verborgen ligt.");
		Console.WriteLine("Hij kan ervoor kiezen om alleen verder te gaan of hulp te zoeken bij een oude vriend.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Alleen verdergaan.");
		Console.WriteLine("2. Hulp zoeken bij een oude vriend.");

		string keuze1 = Console.ReadLine();

		if (keuze1 == "1")
		{
			AlleenVerder();
		}
		else if (keuze1 == "2")
		{
			HulpZoeken();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			StartAvontuur();
		}
	}

	static void AlleenVerder()
	{
		Console.WriteLine("Aric besluit alleen de ruïnes binnen te gaan. De vervloekte wezens sluipen in de schaduwen.");
		Console.WriteLine("Plots verschijnt er een groot beest voor hem. Wat doet hij?");
		Console.WriteLine("1. Aanvallen met stormmagie.");
		Console.WriteLine("2. Zich verbergen in de ruïnes.");

		string keuze2 = Console.ReadLine();

		if (keuze2 == "1")
		{
			AanvallenBeest();
		}
		else if (keuze2 == "2")
		{
			VerbergenBeest();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			AlleenVerder();
		}
	}

	static void HulpZoeken()
	{
		Console.Clear();
		Console.WriteLine("Aric zoekt hulp bij zijn oude vriend, een wijze magiër genaamd Lorian.");
		Console.WriteLine("Lorian waarschuwt Aric voor de gevaren van de ruïnes, maar biedt aan mee te gaan.");
		Console.WriteLine("Samen gaan ze op pad. Onderweg komen ze een spreuk tegen die hen eenmalige toegang geeft tot het artefact.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Gebruik de spreuk meteen.");
		Console.WriteLine("2. Bewaar de spreuk voor later.");

		string keuze2 = Console.ReadLine();

		if (keuze2 == "1")
		{
			SpreukGebruiken();
		}
		else if (keuze2 == "2")
		{
			SpreukBewaren();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			HulpZoeken();
		}
	}

	static void AanvallenBeest()
	{
		Console.Clear();
		Console.WriteLine("Aric roept een storm op en valt het beest aan met zijn magie.");
		Console.WriteLine("Het beest stort ineen, maar Aric voelt zijn kracht afnemen.");
		Console.WriteLine("Voor hem ligt de ingang naar de ondergrondse tempel, maar hij is verzwakt.");
		Console.WriteLine("Wat doet hij?");
		Console.WriteLine("1. Betreed de tempel ondanks zijn zwakte.");
		Console.WriteLine("2. Keer terug naar het dorp om te herstellen.");

		string keuze3 = Console.ReadLine();

		if (keuze3 == "1")
		{
			Eind1();
		}
		else if (keuze3 == "2")
		{
			Eind2();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			AanvallenBeest();
		}
	}

	static void VerbergenBeest()
	{
		Console.Clear();
		Console.WriteLine("Aric besluit zich te verbergen in de ruïnes. Het beest snuift rond, maar vindt hem niet.");
		Console.WriteLine("Na enige tijd sluipt hij verder en vindt de ingang naar de ondergrondse tempel.");
		Console.WriteLine("Wat doet hij?");
		Console.WriteLine("1. Betreed de tempel.");
		Console.WriteLine("2. Keer terug naar het dorp om een betere voorbereiding te treffen.");

		string keuze3 = Console.ReadLine();

		if (keuze3 == "1")
		{
			Eind3();
		}
		else if (keuze3 == "2")
		{
			Eind2();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			VerbergenBeest();
		}
	}

	static void SpreukGebruiken()
	{
		Console.Clear();
		Console.WriteLine("Aric gebruikt de spreuk en de toegang tot het artefact wordt onthuld.");
		Console.WriteLine("Maar de spreuk was vervloekt, en het artefact ontplooit een duistere kracht.");
		Console.WriteLine("Aric realiseert zich te laat dat hij in de val is gelopen.");
		Eind1();
	}

	static void SpreukBewaren()
	{
		Console.Clear();
		Console.WriteLine("Aric bewaart de spreuk voor later gebruik. Dit blijkt een wijs besluit, want verderop komen ze een krachtig wezen tegen.");
		Console.WriteLine("Met de spreuk weten ze het wezen te overmeesteren en bereiken de tempel.");
		Console.WriteLine("Binnen wacht hen het mysterieuze artefact.");
		Eind3();
	}

	static void Eind1()
	{
		Console.Clear();
		Console.WriteLine("Einde 1: Aric wordt geconfronteerd met het artefact, maar hij is niet sterk genoeg om de vloek te verbreken.");
		Console.WriteLine("De vloek neemt Eldoria volledig over, en het koninkrijk is voor altijd verloren in de duisternis.");
		Console.WriteLine("Slecht einde.");
	}

	static void Eind2()
	{
		Console.Clear();
		Console.WriteLine("Einde 2: Aric keert terug naar het dorp om zich te herstellen en voor te bereiden.");
		Console.WriteLine("Hoewel hij zijn avontuur niet heeft voltooid, leeft hij nog en kan hij op een dag terugkeren om de vloek opnieuw te bestrijden.");
		Console.WriteLine("Neutraal einde.");
	}

	static void Eind3()
	{
		Console.Clear();
		Console.WriteLine("Einde 3: Aric en zijn bondgenoot bereiken het artefact en gebruiken hun gecombineerde krachten om de vloek te verbreken.");
		Console.WriteLine("Eldoria ziet eindelijk weer het licht van de zon, en het koninkrijk wordt hersteld.");
		Console.WriteLine("Goed einde.");
	}
}
