class Lyra
{
    public static void StartAvontuur() // This is the method that starts Lyra's adventure.
    {
        Console.WriteLine("Welkom bij het avontuur van Lyra in het vervloekte Koninkrijk Eldoria!");
        // Display the introductory message of the game.
        Console.WriteLine("Lyra, een ervaren ranger en meester in overleving, gaat de strijd aan met de vloek van Eldoria.");
        // Introduction of Lyra's character as a skilled ranger.
        Console.WriteLine("Jouw keuzes zullen het lot van Lyra en Eldoria bepalen. Kies wijs!");
        // Warning the player that their choices will affect the outcome.
        Console.WriteLine();

        BeginAvontuur(); // Calls the method that kicks off the main part of the adventure.
    }

    static void BeginAvontuur() // First decision point in the game.
    {
        Console.Clear(); // Clear the console to avoid clutter.
        Console.WriteLine("Lyra staat aan de rand van het donkere bos dat ooit haar thuis was, nu vervloekt door duistere magie.");
        // Describes the setting and situation.
        Console.WriteLine("Ze kan direct naar de stad gaan om antwoorden te zoeken of eerst haar vaardigheden testen door op verkenning te gaan.");
        // The player must choose between two options.
        Console.WriteLine("Wat wil je doen?");
        Console.WriteLine("1. Ga direct naar de stad.");
        Console.WriteLine("2. Verken het bos voor gevaren en middelen.");
        // Display choices.
        Console.WriteLine("Type ? voor een hint");

        string keuze1 = Console.ReadLine(); // Get player input.

        if (keuze1 == "1") // If the player chooses to go to the city.
        {
            NaarDeStad(); // Go to the city path.
        }
        else if (keuze1 == "2") // If the player chooses to explore the forest.
        {
            BosVerkennen(); // Go to the forest exploration path.
        }
        else if (keuze1 == "?") // If the player asks for a hint.
        {
            Console.WriteLine("Het bos verkennen kan je voorbereiden op wat je te wachten staat, en je kunt middelen vinden.");
            // Provide a hint about exploring the forest.
            Console.ReadKey();
            BeginAvontuur(); // Return to the main choice menu.
        }
        else
        {
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            BeginAvontuur(); // Handle invalid input and repeat the decision point.
        }
    }

    static void NaarDeStad() // Path if the player chooses to go to the city.
    {
        Console.Clear(); // Clear console.
        Console.WriteLine("Lyra gaat direct naar de stad. De wegen zijn verlaten en spookachtig stil.");
        // Description of the eerie city environment.
        Console.WriteLine("Op een plein staat een mysterieus figuur. Wat wil je doen?");
        Console.WriteLine("1. Benader het figuur.");
        Console.WriteLine("2. Blijf verborgen en observeer.");
        Console.WriteLine("Type ? voor een hint");

        string keuze2 = Console.ReadLine(); // Get player input.

        if (keuze2 == "1")
        {
            BenaderFiguur(); // Proceed to the choice of approaching the figure.
        }
        else if (keuze2 == "2")
        {
            VerborgenBlijven(); // Option to stay hidden.
        }
        else if (keuze2 == "?")
        {
            Console.WriteLine("De stad lijkt vol geheimen te zitten. Misschien moet je eerst meer leren over je omgeving voordat je handelt.");
            // Provide a hint about the mysterious figure.
            Console.ReadKey();
            NaarDeStad(); // Return to the choice menu.
        }
        else
        {
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            NaarDeStad(); // Handle invalid input and repeat the decision point.
        }
    }

    static void BosVerkennen() // Path if the player chooses to explore the forest.
    {
        Console.Clear();
        Console.WriteLine("Lyra besluit het bos in te gaan, op zoek naar middelen om de strijd aan te gaan.");
        // Description of exploring the forest.
        Console.WriteLine("Onderweg vindt ze oude vallen en sporen van vreemde wezens.");
        Console.WriteLine("Ze kan een val opzetten voor mogelijke gevaren of verder verkennen
