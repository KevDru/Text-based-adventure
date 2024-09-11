static class CharacterSelection
{
	public static void SelectCharacter()
	{
		bool characterChosen = false;
		int characterChoice = 0;

		while (!characterChosen)
		{
			Console.Clear();
			Console.WriteLine("Kies een karakter:\n1. Aric\n2. Lyra\n3. Galen");

			if (int.TryParse(Console.ReadLine(), out characterChoice))
			{
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
							Aric.StartAvontuur(); // Roep direct de methode aan
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
							Lyra.StartAvontuur();
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
							Galen.StartAvontuur();
							characterChosen = true;
						}
						break;

					default:
						Console.WriteLine("Ongeldige keuze. Probeer het opnieuw.");
						break;
				}
			}
		}
	}
}
