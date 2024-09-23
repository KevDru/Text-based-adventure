using System;
using TBA_PraL3;

class Program
{
	static void Main()
	{
		// Toon de spelinstructies
		Instructions.ShowInstructions();

		// Toon het introductiescherm
		IntroScreen.ShowIntro();

		// Laat de speler een karakter kiezen
		CharacterSelection.SelectCharacter();
	}
}
