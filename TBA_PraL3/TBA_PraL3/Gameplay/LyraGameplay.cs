using System;

class Lyra
{
	public static void StartAvontuur()
	{
		Console.WriteLine("Welkom bij het avontuur van Lyra in het vervloekte Koninkrijk Eldoria!");
		Console.WriteLine("Lyra, een ervaren ranger en meester in overleving, gaat de strijd aan met de vloek van Eldoria.");
		Console.WriteLine("Jouw keuzes zullen het lot van Lyra en Eldoria bepalen. Kies wijs!");
		Console.WriteLine();

		BeginAvontuur();
	}

	static void BeginAvontuur()
	{
		Console.Clear();
		Console.WriteLine("Lyra staat aan de rand van het donker bos dat ooit haar thuis was, nu vervloekt door duistere magie.");
		Console.WriteLine("Ze kan direct naar de stad gaan om antwoorden te zoeken of eerst haar vaardigheden testen door op verkenning te gaan.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Ga direct naar de stad.");
		Console.WriteLine("2. Verken het bos voor gevaren en middelen.");

		string keuze1 = Console.ReadLine();

		if (keuze1 == "1")
		{
			NaarDeStad();
		}
		else if (keuze1 == "2")
		{
			BosVerkennen();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			BeginAvontuur();
		}
	}

	static void NaarDeStad()
	{
		Console.Clear();
		Console.WriteLine("Lyra gaat direct naar de stad, de wegen zijn verlaten en spookachtig stil.");
		Console.WriteLine("Op een plein staat een mysterieus figuur. Wat wil je doen?");
		Console.WriteLine("1. Benader het figuur.");
		Console.WriteLine("2. Blijf verborgen en observeer.");

		string keuze2 = Console.ReadLine();

		if (keuze2 == "1")
		{
			BenaderFiguur();
		}
		else if (keuze2 == "2")
		{
			VerborgenBlijven();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			NaarDeStad();
		}
	}

	static void BosVerkennen()
	{
		Console.Clear();
		Console.WriteLine("Lyra besluit het bos in te gaan, op zoek naar middelen om de strijd aan te gaan.");
		Console.WriteLine("Onderweg vindt ze oude vallen en sporen van vreemde wezens.");
		Console.WriteLine("Ze kan een val opzetten voor mogelijke gevaren of verder verkennen.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Zet een val op.");
		Console.WriteLine("2. Verken verder.");

		string keuze2 = Console.ReadLine();

		if (keuze2 == "1")
		{
			ValOpzetten();
		}
		else if (keuze2 == "2")
		{
			VerderVerkennen();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			BosVerkennen();
		}
	}

	static void BenaderFiguur()
	{
		Console.Clear();
		Console.WriteLine("Lyra besluit het figuur te benaderen. Het blijkt een oude, vervloekte magiër te zijn.");
		Console.WriteLine("Hij biedt aan om informatie te delen, maar alleen als Lyra een dienst voor hem verricht.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Accepteer zijn aanbod.");
		Console.WriteLine("2. Weiger en ga verder.");

		string keuze3 = Console.ReadLine();

		if (keuze3 == "1")
		{
			MagierHelpen();
		}
		else if (keuze3 == "2")
		{
			ZelfVerder();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			BenaderFiguur();
		}
	}

	static void VerborgenBlijven()
	{
		Console.Clear();
		Console.WriteLine("Lyra blijft verborgen en observeert de mysterieuze figuur van een afstand.");
		Console.WriteLine("Ze merkt dat het figuur een krachtige artefact bij zich draagt, dat mogelijk de sleutel tot de vloek bevat.");
		Console.WriteLine("Wat wil je doen?");
		Console.WriteLine("1. Probeer het artefact te stelen.");
		Console.WriteLine("2. Blijf nog langer observeren.");

		string keuze3 = Console.ReadLine();

		if (keuze3 == "1")
		{
			ArtefactStelen();
		}
		else if (keuze3 == "2")
		{
			LangdurigObserveren();
		}
		else
		{
			Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
			VerborgenBlijven();
		}
	}

	static void ValOpzetten()
	{
		Console.Clear();
		Console.WriteLine("Lyra zet een val op en wacht geduldig.");
		Console.WriteLine("Na een tijdje wordt de val geactiveerd en vangt ze een gevaarlijk beest dat haar later van dienst kan zijn.");
		Console.WriteLine("Ze voelt zich zelfverzekerder en gaat verder naar de stad.");
		Eind3();  // Goed einde
	}

	static void VerderVerkennen()
	{
		Console.Clear();
		Console.WriteLine("Lyra blijft verder het bos verkennen, maar komt onverwacht in een hinderlaag van vervloekte wezens.");
		Console.WriteLine("Ze vecht dapper, maar de wezens zijn te sterk.");
		Eind1();  // Slecht einde
	}

	static void MagierHelpen()
	{
		Console.Clear();
		Console.WriteLine("Lyra accepteert de opdracht van de magiër en krijgt waardevolle informatie in ruil.");
		Console.WriteLine("Ze leert hoe ze de vloek kan verbreken en de duistere magie kan omzeilen.");
		Eind3();  // Goed einde
	}

	static void ZelfVerder()
	{
		Console.Clear();
		Console.WriteLine("Lyra besluit de magiër niet te helpen en haar eigen pad te volgen.");
		Console.WriteLine("Zonder cruciale informatie loopt ze later in een val en de vloek overweldigt haar.");
		Eind2();  // Neutraal einde
	}

	static void ArtefactStelen()
	{
		Console.Clear();
		Console.WriteLine("Lyra probeert het artefact te stelen, maar wordt betrapt door de magiër.");
		Console.WriteLine("Hij vervloekt haar, en ze wordt gevangen in een eindeloze nachtmerrie.");
		Eind1();  // Slecht einde
	}

	static void LangdurigObserveren()
	{
		Console.Clear();
		Console.WriteLine("Lyra observeert de magiër nog langer en ontdekt een zwakte in zijn verdediging.");
		Console.WriteLine("Ze weet het artefact veilig te bemachtigen zonder betrapt te worden.");
		Eind3();  // Goed einde
	}

	static void Eind1()
	{
		Console.Clear();
		Console.WriteLine("Einde 1: Lyra wordt overweldigd door de vloek en faalt in haar missie.");
		Console.WriteLine("De duisternis neemt Eldoria volledig over. Slecht einde.");
	}

	static void Eind2()
	{
		Console.Clear();
		Console.WriteLine("Einde 2: Lyra faalt haar missie te voltooien, maar overleeft.");
		Console.WriteLine("Ze trekt zich terug om op een dag sterker terug te keren. Neutraal einde.");
	}

	static void Eind3()
	{
		Console.Clear();
		Console.WriteLine("Einde 3: Lyra weet de vloek te doorbreken en Eldoria wordt bevrijd van de duisternis.");
		Console.WriteLine("Het koninkrijk ziet weer het licht. Goed einde.");
	}
}
