using System;

static class CharacterSelection
{
	// Methode om een karakter te selecteren
	public static void SelectCharacter()
	{
		bool characterChosen = false; // Vlag om bij te houden of een karakter gekozen is
		int characterChoice = 0; // Variabele om de keuze van de speler op te slaan

		while (!characterChosen)
		{
			Console.Clear();
			Console.WriteLine("Kies een karakter:\n1. Aric\n2. Lyra\n3. Galen");

			// Probeer de keuze van de speler te parseren naar een integer
			if (int.TryParse(Console.ReadLine(), out characterChoice))
			{
				// Behandel de keuze van de speler
				switch (characterChoice)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Aric:\nAric begon als een bescheiden leerling in een afgelegen dorp en ontwikkelde zijn vaardigheden in stormmagie. Ondanks zijn nederige afkomst, zette hij zijn magische talenten in om de vloek van Eldoria te bestrijden. Na een mislukte poging werd hij verbannen. Nu zoekt hij naar een manier om zijn naam te herstellen en de vloek te stoppen.");
						Console.WriteLine("Vaardigheden\n- Magie\n- Veel kennis\n- Intellect");
						Console.WriteLine("Wil je dit karakter spelen? y/n");
						if (Console.ReadLine().ToLower() == "y")
						{
							Console.Clear();
							Console.WriteLine("Je hebt Aric gekozen. Veel succes met je avontuur!");
							Aric.StartAvontuur(); // Start direct het avontuur voor Aric
							characterChosen = true;
						}
						break;

					case 2:
						Console.Clear();
						Console.WriteLine("Lyra:\nLyra groeide op als een ranger in de uitgestrekte bossen rond Eldoria. Ze leerde overleven in de wildernis, met een scherp oog en een onfeilbare hand met de boog. Toen de vloek zijn tol eiste, verloor ze mensen waar ze om gaf. Nu zoekt ze een manier hun te wreken.");
						Console.WriteLine("Wil je dit karakter spelen? y/n");
						if (Console.ReadLine().ToLower() == "y")
						{
							Console.Clear();
							Console.WriteLine("Je hebt Lyra gekozen. Veel succes met je avontuur!");
							Lyra.StartAvontuur(); // Start direct het avontuur voor Lyra
							characterChosen = true;
						}
						break;

					case 3:
						Console.Clear();
						Console.WriteLine("Galen:\nGalen was een bekwame krijger en smid die zijn leven wijdde aan het maken van sterke wapens en het vechten tegen de vijanden van Eldoria. Tijdens de opkomst van de vloek nam hij het op zich om de oorsprong ervan te onderzoeken en te bestrijden.");
						Console.WriteLine("Wil je dit karakter spelen? y/n");
						if (Console.ReadLine().ToLower() == "y")
						{
							Console.Clear();
							Console.WriteLine("Je hebt Galen gekozen. Veel succes met je avontuur!");
							Galen.StartAvontuur(); // Start direct het avontuur voor Galen
						}
						break;
				}
			}
		}
	}
}


