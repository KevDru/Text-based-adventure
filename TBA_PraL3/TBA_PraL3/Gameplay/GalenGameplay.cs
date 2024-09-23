using System;

class Galen
{
    // Entry point of the adventure
    public static void StartAvontuur()
    {
        // Introduction to the adventure
        Console.WriteLine("Welkom bij het avontuur van Galen in het vervloekte Koninkrijk Eldoria!");
        Console.WriteLine("Galen, een meester smid en krijger, is vastbesloten de vloek te verbreken met zijn brute kracht en kennis van wapens.");
        Console.WriteLine("Jouw keuzes zullen het lot van Galen en Eldoria bepalen. Kies wijs!");
        Console.WriteLine();

        // Start the main adventure
        BeginAvontuur();
    }

    // First decision point in the adventure
    static void BeginAvontuur()
    {
        // Scenario setup and choice
        Console.WriteLine("Galen staat in zijn smidse, zijn hamer rustend op het aambeeld.");
        Console.WriteLine("De vloek heeft zijn land geteisterd en hij moet beslissen of hij direct op zoek gaat naar het kwaadaardige artefact of eerst zijn wapens versterkt.");
        Console.WriteLine("Wat wil je doen?");
        Console.WriteLine("1. Ga direct op zoek naar het artefact.");
        Console.WriteLine("2. Versterk je wapens en bepantsering.");
        Console.WriteLine("Type ? voor een hint");

        // User input for decision
        string keuze1 = Console.ReadLine();

        // Branching based on user's choice
        if (keuze1 == "1")
        {
            ZoekArtefact();  // User chooses to search for the artifact
        }
        else if (keuze1 == "2")
        {
            WapensVersterken();  // User chooses to strengthen weapons and armor
        }
        else if (keuze1 == "?")
        {
            // Providing a hint
            Console.WriteLine("Het versterken van je wapens kan je voordeel geven in de strijd die je te wachten staat.");
            Console.ReadKey();
            BeginAvontuur();  // Return to the first decision
        }
        else
        {
            // Invalid input, prompt the user to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            BeginAvontuur();
        }
    }

    // Branch where Galen immediately searches for the artifact
    static void ZoekArtefact()
    {
        Console.Clear();  // Clear the console for a cleaner experience
        Console.WriteLine("Galen besluit geen tijd te verspillen en gaat direct op zoek naar het kwaadaardige artefact.");
        Console.WriteLine("Onderweg komt hij een groep bandieten tegen die hem proberen te overvallen.");
        Console.WriteLine("Wat wil je doen?");
        Console.WriteLine("1. Vecht tegen de bandieten.");
        Console.WriteLine("2. Probeer de bandieten te ontwijken.");
        Console.WriteLine("Type ? voor een hint");

        // User input for next decision
        string keuze2 = Console.ReadLine();

        // Branching based on user's decision
        if (keuze2 == "1")
        {
            BandietenVecht();  // User chooses to fight the bandits
        }
        else if (keuze2 == "2")
        {
            BandietenOntwijken();  // User chooses to avoid the bandits
        }
        else if (keuze2 == "?")
        {
            // Hint for the user
            Console.WriteLine("Je kracht kan nuttig zijn bij een confrontatie, maar soms kan het vermijden van een gevecht ook voordeel opleveren.");
            Console.ReadKey();
            ZoekArtefact();  // Return to the decision
        }
        else
        {
            // Invalid input, prompt to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            ZoekArtefact();
        }
    }

    // Branch where Galen strengthens his weapons first
    static void WapensVersterken()
    {
        Console.Clear();
        Console.WriteLine("Galen besluit zijn wapens te versterken voordat hij op zijn missie vertrekt.");
        Console.WriteLine("Zijn zwaard wordt scherper en zijn harnas sterker, maar hij heeft waardevolle tijd verloren.");
        Console.WriteLine("Wanneer hij eindelijk op weg gaat, komt hij een groep gewonde dorpelingen tegen.");
        Console.WriteLine("Wat wil je doen?");
        Console.WriteLine("1. Help de dorpelingen.");
        Console.WriteLine("2. Laat ze achter en ga verder.");
        Console.WriteLine("Type ? voor een hint");

        // User input for decision after strengthening weapons
        string keuze2 = Console.ReadLine();

        // Branching based on the decision
        if (keuze2 == "1")
        {
            DorpelingenHelpen();  // User helps the villagers
        }
        else if (keuze2 == "2")
        {
            GaVerder();  // User continues the journey without helping
        }
        else if (keuze2 == "?")
        {
            // Providing a hint
            Console.WriteLine("Je wapens zijn nu sterker, maar het helpen van anderen kan je ook waardevolle informatie opleveren.");
            Console.ReadKey();
            WapensVersterken();  // Return to the decision
        }
        else
        {
            // Invalid input, prompt to try again
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            WapensVersterken();
        }
    }

    // Fighting the bandits
    static void BandietenVecht()
    {
        Console.Clear();
        Console.WriteLine("Galen trekt zijn zwaard en gaat de strijd aan met de bandieten. Zijn brute kracht overweldigt hen.");
        Console.WriteLine("Na de strijd vindt hij een kaart die de locatie van het artefact onthult.");
        Eind3();  // Leads to a good ending
    }

    // Avoiding the bandits (leads to bad ending)
    static void BandietenOntwijken()
    {
        Console.Clear();
        Console.WriteLine("Galen probeert de bandieten te ontwijken, maar ze merken hem toch op.");
        Console.WriteLine("Hij wordt in een hinderlaag gelokt en gevangen genomen. Zonder hulp kan hij niet ontsnappen.");
        Eind1();  // Leads to a bad ending
    }

    // Helping the villagers (leads to a good ending)
    static void DorpelingenHelpen()
    {
        Console.Clear();
        Console.WriteLine("Galen helpt de gewonde dorpelingen. Als dank geven ze hem informatie over een geheime doorgang naar het artefact.");
        Console.WriteLine("Met deze nieuwe kennis gaat hij verder op zijn missie.");
        Eind3();  // Leads to a good ending
    }

    // Continuing the journey without helping the villagers (leads to neutral ending)
    static void GaVerder()
    {
        Console.Clear();
        Console.WriteLine("Galen laat de dorpelingen achter en vervolgt zijn weg.");
        Console.WriteLine("Hoewel hij snel vordert, loopt hij in een valstrik en raakt ernstig gewond.");
        Eind2();  // Leads to a neutral ending
    }

    // Bad ending: Galen is captured
    static void Eind1()
    {
        Console.Clear();
        Console.WriteLine("Einde 1: Galen wordt gevangen door bandieten en faalt zijn missie te voltooien.");
        Console.WriteLine("De vloek blijft Eldoria teisteren. Slecht einde.");
    }

    // Neutral ending: Galen survives but fails to lift the curse
    static void Eind2()
    {
        Console.Clear();
        Console.WriteLine("Einde 2: Galen overleeft zijn avontuur, maar slaagt er niet in de vloek te verbreken.");
        Console.WriteLine("Het kwaad blijft aanwezig, maar Galen leeft nog om het op een dag opnieuw te proberen. Neutraal einde.");
    }

    // Good ending: Galen destroys the artifact and lifts the curse
    static void Eind3()
    {
        Console.Clear();
        Console.WriteLine("Einde 3: Galen weet het artefact te vinden en vernietigt het met zijn versterkte wapens.");
        Console.WriteLine("De vloek wordt opgeheven en Eldoria wordt bevrijd. Goed einde.");
    }
}
