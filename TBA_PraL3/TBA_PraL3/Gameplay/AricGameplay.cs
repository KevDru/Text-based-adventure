using System;

class Aric
{
    // Entry point of the adventure
    public static void StartAvontuur()
    {
        // Introduction to the adventure
        Console.WriteLine("Welkom bij het avontuur van Aric in het vervloekte Koninkrijk Eldoria!");
        Console.WriteLine("Aric, een magiër die stormmagie beheerst, staat voor een gevaarlijke missie: de eeuwenoude vloek van Eldoria verbreken.");
        Console.WriteLine("Jouw keuzes zullen het lot van Aric en Eldoria bepalen. Kies wijs!");
        Console.WriteLine();

        // Start the main adventure
        BeginAvontuur();
    }

    // First main decision point in the adventure
    static void BeginAvontuur()
    {
        Console.Clear(); // Clear the console for a cleaner UI
        Console.WriteLine("Aric staat aan de rand van de ruïnes van de oude hoofdstad, waar het mysterieuze artefact verborgen ligt.");
        Console.WriteLine("Hij kan ervoor kiezen om alleen verder te gaan of hulp te zoeken bij een oude vriend.");
        Console.WriteLine("Wat wil je doen?");
        Console.WriteLine("1. Alleen verdergaan.");
        Console.WriteLine("2. Hulp zoeken bij een oude vriend.");
        Console.WriteLine("Type ? voor een hint");

        // Take user's input for the first choice
        string keuze1 = Console.ReadLine();

        // Branching logic based on user's choice
        if (keuze1 == "1")
        {
            AlleenVerder(); // User chooses to go alone
        }
        else if (keuze1 == "2")
        {
            HulpZoeken(); // User chooses to seek help
        }
        else if (keuze1 == "?")
        {
            // Hint for the user if they type ?
            Console.WriteLine("Hulp zoeken bij een vriend kan je extra ondersteuning bieden in deze gevaarlijke missie.");
            Console.ReadKey();
            BeginAvontuur(); // Return to the initial choices
        }
        else
        {
            // Invalid choice, prompt the user to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            BeginAvontuur();
        }
    }

    // The branch where Aric goes alone
    static void AlleenVerder()
    {
        Console.Clear(); // Clear the console
        Console.WriteLine("Aric besluit alleen de ruïnes binnen te gaan. De vervloekte wezens sluipen in de schaduwen.");
        Console.WriteLine("Plots verschijnt er een groot beest voor hem. Wat doet hij?");
        Console.WriteLine("1. Aanvallen met stormmagie.");
        Console.WriteLine("2. Zich verbergen in de ruïnes.");
        Console.WriteLine("Type ? voor een hint");

        // Take user's input for the second decision
        string keuze2 = Console.ReadLine();

        // Branching based on the user's second choice
        if (keuze2 == "1")
        {
            AanvallenBeest(); // User chooses to attack the beast
        }
        else if (keuze2 == "2")
        {
            VerbergenBeest(); // User chooses to hide from the beast
        }
        else if (keuze2 == "?")
        {
            // Hint for the user
            Console.WriteLine("Aanvallen kan snel resultaat opleveren, maar kan je ook kwetsbaar maken. Verbergen kan je de tijd geven om een beter plan te maken.");
            Console.ReadKey();
            AlleenVerder(); // Return to the second decision
        }
        else
        {
            // Invalid choice, prompt to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            AlleenVerder();
        }
    }

    // The branch where Aric seeks help from a friend
    static void HulpZoeken()
    {
        Console.Clear(); // Clear the console
        Console.WriteLine("Aric zoekt hulp bij zijn oude vriend, een wijze magiër genaamd Lorian.");
        Console.WriteLine("Lorian waarschuwt Aric voor de gevaren van de ruïnes, maar biedt aan mee te gaan.");
        Console.WriteLine("Samen gaan ze op pad. Onderweg komen ze een spreuk tegen die hen eenmalige toegang geeft tot het artefact.");
        Console.WriteLine("Wat wil je doen?");
        Console.WriteLine("1. Gebruik de spreuk meteen.");
        Console.WriteLine("2. Bewaar de spreuk voor later.");
        Console.WriteLine("Type ? voor een hint");

        // Take user's input for the second decision in this branch
        string keuze2 = Console.ReadLine();

        // Branching based on user's choice
        if (keuze2 == "1")
        {
            SpreukGebruiken(); // User chooses to use the spell immediately
        }
        else if (keuze2 == "2")
        {
            SpreukBewaren(); // User chooses to save the spell for later
        }
        else if (keuze2 == "?")
        {
            // Hint for the user
            Console.WriteLine("De spreuk kan een belangrijke rol spelen in je avontuur. Gebruik hem verstandig of bewaar hem voor een strategisch moment.");
            Console.ReadKey();
            HulpZoeken(); // Return to the decision point
        }
        else
        {
            // Invalid choice, prompt to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            HulpZoeken();
        }
    }

    // User attacks the beast with storm magic
    static void AanvallenBeest()
    {
        Console.Clear();
        Console.WriteLine("Aric roept een storm op en valt het beest aan met zijn magie.");
        Console.WriteLine("Het beest stort ineen, maar Aric voelt zijn kracht afnemen.");
        Console.WriteLine("Voor hem ligt de ingang naar de ondergrondse tempel, maar hij is verzwakt.");
        Console.WriteLine("Wat doet hij?");
        Console.WriteLine("1. Betreed de tempel ondanks zijn zwakte.");
        Console.WriteLine("2. Keer terug naar het dorp om te herstellen.");
        Console.WriteLine("Type ? voor een hint");

        // Take user's input for the next decision
        string keuze3 = Console.ReadLine();

        // Branching based on user's choice
        if (keuze3 == "1")
        {
            Eind1(); // User chooses to enter the temple despite weakness (leads to a bad ending)
        }
        else if (keuze3 == "2")
        {
            Eind2(); // User chooses to return to the village (neutral ending)
        }
        else if (keuze3 == "?")
        {
            // Hint for the user
            Console.WriteLine("Als je verzwakt de tempel betreedt, kan dat gevaarlijk zijn. Terugkeren om te herstellen kan je voorbereiden voor een betere aanpak.");
            Console.ReadKey();
            AanvallenBeest(); // Return to the decision point
        }
        else
        {
            // Invalid choice, prompt to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            AanvallenBeest();
        }
    }

    // User chooses to hide from the beast
    static void VerbergenBeest()
    {
        Console.Clear();
        Console.WriteLine("Aric besluit zich te verbergen in de ruïnes. Het beest snuift rond, maar vindt hem niet.");
        Console.WriteLine("Na enige tijd sluipt hij verder en vindt de ingang naar de ondergrondse tempel.");
        Console.WriteLine("Wat doet hij?");
        Console.WriteLine("1. Betreed de tempel.");
        Console.WriteLine("2. Keer terug naar het dorp om een betere voorbereiding te treffen.");
        Console.WriteLine("Type ? voor een hint");

        // Take user's input for the next decision
        string keuze3 = Console.ReadLine();

        // Branching based on user's choice
        if (keuze3 == "1")
        {
            Eind3(); // User enters the temple (leads to a good ending)
        }
        else if (keuze3 == "2")
        {
            Eind2(); // User returns to the village (neutral ending)
        }
        else if (keuze3 == "?")
        {
            // Hint for the user
            Console.WriteLine("De tempel betreden zonder voorbereiding kan riskant zijn. Terugkeren om je voor te bereiden kan je kansen verbeteren.");
            Console.ReadKey();
            VerbergenBeest(); // Return to the decision point
        }
        else
        {
            // Invalid choice, prompt to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            VerbergenBeest();
        }
    }

    // User uses the spell immediately (bad ending)
    static void SpreukGebruiken()
    {
        Console.Clear();
        Console.WriteLine("Aric gebruikt de spreuk en de toegang tot het artefact wordt onthuld.");
        Console.WriteLine("Maar de spreuk was vervloekt, en het artefact ontplooit een duistere kracht.");
        Console.WriteLine("Aric realiseert zich te laat dat hij in de val is gelopen.");
        Eind1(); // Leads to bad ending
    }

    // User saves the spell for later (good ending)
    static void SpreukBewaren()
    {
        Console.Clear();
        Console.WriteLine("Aric bewaart de spreuk voor later gebruik. Dit blijkt een wijs besluit, want verderop komen ze een krachtig wezen tegen.");
        Console.WriteLine("Met de spreuk weten ze het wezen te overmeesteren en bereiken de tempel.");
        Console.WriteLine("Binnen wacht hen het mysterieuze artefact.");
        Eind3(); // Leads to good ending
    }

    // Bad ending
    static void Eind1()
    {
        Console.Clear();
        Console.WriteLine("Einde 1: Aric wordt geconfronteerd met het artefact, maar hij is niet sterk genoeg om de vloek te verbreken.");
        Console.WriteLine("De vloek neemt Eldoria volledig over, en het koninkrijk is voor altijd verloren in de duisternis.");
        Console.WriteLine("Slecht einde.");
    }

    // Neutral ending
    static void Eind2()
    {
        Console.Clear();
        Console.WriteLine("Einde 2: Aric keert terug naar het dorp om zich te herstellen en voor te bereiden.");
        Console.WriteLine("Hoewel hij zijn avontuur niet heeft voltooid, leeft hij nog en kan hij op een dag terugkeren om de vloek opnieuw te bestrijden.");
        Console.WriteLine("Neutraal einde.");
    }

    // Good ending
    static void Eind3()
    {
        Console.Clear();
        Console.WriteLine("Einde 3: Aric en zijn bondgenoot bereiken het artefact en gebruiken hun gecombineerde krachten om de vloek te verbreken.");
        Console.WriteLine("Eldoria ziet eindelijk weer het licht van de zon, en het koninkrijk wordt hersteld.");
        Console.WriteLine("Goed einde.");
    }
}
