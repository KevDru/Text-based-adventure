using System;

static class IntroScreen
{
	public static void ShowIntro()
	{
		string WelcomeTitle = "Eldoria's schaduw";
		string PressToPlay = "--Klik op een knop om te spelen--";
		string Intro = "Het koninkrijk Eldoria, ooit een baken van magie en welvaart, wordt nu verteerd door een eeuwenoude vloek. Eeuwige duisternis bedekt het land; de zon is verdwenen achter een sluier van wolken, en vervloekte wezens dwalen door de verlaten steden. De rivieren zijn vergiftigd, en de velden dor en verlaten.\r\n\r\nDiep onder de ruïnes van de oude hoofdstad ligt een mysterieus artefact verborgen, dat volgens legendes de kracht heeft om de vloek te verbreken of het land voorgoed te verdoemen. Terwijl Eldoria in schaduwen gehuld blijft, wachten de geheimen van de vloek op degenen die moedig genoeg zijn om ze te ontrafelen. Zal Eldoria ooit het licht weer zien, of zal het voor altijd in duisternis gehuld blijven?";

		Console.SetCursorPosition((Console.WindowWidth - WelcomeTitle.Length) / 2, Console.WindowHeight / 2 - 5);
		Console.WriteLine(WelcomeTitle);

		Console.SetCursorPosition((Console.WindowWidth - PressToPlay.Length) / 2, Console.WindowHeight / 2 - 4);
		Console.WriteLine(PressToPlay);

		Console.ReadKey();
		Console.Clear();

		Console.WriteLine(Intro);

		Console.WriteLine("\nKlik op een knop om door te gaan");
		Console.ReadKey();
		Console.Clear();
	}
}
