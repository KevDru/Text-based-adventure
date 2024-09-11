using System;

class Galen
{
	public static void StartAvontuur()
	{
		Console.WriteLine("Welkom bij het avontuur van Galen in het vervloekte Koninkrijk Eldoria!");
		Console.WriteLine("Galen, een meester smid en krijger, is vastbesloten de vloek te verbreken met zijn brute kracht en kennis van wapens.");
		Console.WriteLine("Jouw keuzes zullen het lot van Galen en Eldoria bepalen. Kies wijs!");
		Console.WriteLine();

		BeginAvontuur();
	}

	static void BeginAvontuur()
	{
		Console.WriteLine("Galen staat in zijn smidse, zijn hamer rustend op het aambeeld.");
		Console.WriteLine("De vloek heeft zijn land geteisterd en hij moet beslissen of hij direct op zoek gaat naar het kwaadaardige artefact of eerst zijn wapens versterkt.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Ga direct op zoek naar het artefact.");
		Console.WriteLine("2. Versterk je wapens en bepantsering.");

		string keuze1 = Console.ReadLine();

		if (keuze1 == "1")
		{
			ZoekArtefact();
		}
		else if (keuze1 == "2")
		{
			WapensVersterken();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			BeginAvontuur();
		}
	}

	static void ZoekArtefact()
	{
		Console.Clear();
		Console.WriteLine("Galen besluit geen tijd te verspillen en gaat direct op zoek naar het kwaadaardige artefact.");
		Console.WriteLine("Onderweg komt hij een groep bandieten tegen die hem proberen te overvallen.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Vecht tegen de bandieten.");
		Console.WriteLine("2. Probeer de bandieten te ontwijken.");

		string keuze2 = Console.ReadLine();

		if (keuze2 == "1")
		{
			BandietenVecht();
		}
		else if (keuze2 == "2")
		{
			BandietenOntwijken();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			ZoekArtefact();
		}
	}

	static void WapensVersterken()
	{
		Console.Clear();
		Console.WriteLine("Galen besluit zijn wapens te versterken voordat hij op zijn missie vertrekt.");
		Console.WriteLine("Zijn zwaard wordt scherper en zijn harnas sterker, maar hij heeft waardevolle tijd verloren.");
		Console.WriteLine("Wanneer hij eindelijk op weg gaat, komt hij een groep gewonde dorpelingen tegen.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Help de dorpelingen.");
		Console.WriteLine("2. Laat ze achter en ga verder.");

		string keuze2 = Console.ReadLine();

		if (keuze2 == "1")
		{
			DorpelingenHelpen();
		}
		else if (keuze2 == "2")
		{
			GaVerder();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			WapensVersterken();
		}
	}

	static void BandietenVecht()
	{
		Console.Clear();
		Console.WriteLine("Galen trekt zijn zwaard en gaat de strijd aan met de bandieten. Zijn brute kracht overweldigt hen.");
		Console.WriteLine("Na de strijd vindt hij een kaart die de locatie van het artefact onthult.");
		Eind3();  // Goed einde
	}

	static void BandietenOntwijken()
	{
		Console.Clear();
		Console.WriteLine("Galen probeert de bandieten te ontwijken, maar ze merken hem toch op.");
		Console.WriteLine("Hij wordt in een hinderlaag gelokt en gevangen genomen. Zonder hulp kan hij niet ontsnappen.");
		Eind1();  // Slecht einde
	}

	static void DorpelingenHelpen()
	{
		Console.Clear();
		Console.WriteLine("Galen helpt de gewonde dorpelingen. Als dank geven ze hem informatie over een geheime doorgang naar het artefact.");
		Console.WriteLine("Met deze nieuwe kennis gaat hij verder op zijn missie.");
		Eind3();  // Goed einde
	}

	static void GaVerder()
	{
		Console.Clear();
		Console.WriteLine("Galen laat de dorpelingen achter en vervolgt zijn weg.");
		Console.WriteLine("Hoewel hij snel vordert, loopt hij in een valstrik en raakt ernstig gewond.");
		Eind2();  // Neutraal einde
	}

	static void Eind1()
	{
		Console.Clear();
		Console.WriteLine("Einde 1: Galen wordt gevangen door bandieten en faalt zijn missie te voltooien.");
		Console.WriteLine("De vloek blijft Eldoria teisteren. Slecht einde.");
	}

	static void Eind2()
	{
		Console.Clear();
		Console.WriteLine("Einde 2: Galen overleeft zijn avontuur, maar slaagt er niet in de vloek te verbreken.");
		Console.WriteLine("Het kwaad blijft aanwezig, maar Galen leeft nog om het op een dag opnieuw te proberen. Neutraal einde.");
	}

	static void Eind3()
	{
		Console.Clear();
		Console.WriteLine("Einde 3: Galen weet het artefact te vinden en vernietigt het met zijn versterkte wapens.");
		Console.WriteLine("De vloek wordt opgeheven en Eldoria wordt bevrijd. Goed einde.");
	}
}
