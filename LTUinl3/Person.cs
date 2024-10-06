public class Person
{
    public string Förnamn { get; set; }
    public string Efternamn { get; set; }
    public string Personnummer { get; set; }

    // Metod för att kontrollera om personnumret är giltigt enligt algoritmen
    public bool KontrolleraPersonnummer()
    {
        // Rensa eventuella bindestreck eller mellanslag i personnumret
        string num = Personnummer.Replace("-", "").Replace(" ", "");

        // Kontrollera att personnumret har rätt antal siffror (10)
        if (num.Length != 10)
            return false;

        int summa = 0;

        // Loopar igenom varje siffra
        for (int i = 0; i < num.Length; i++)
        {
            int siffra = int.Parse(num[i].ToString());

            // Varannan siffra multipliceras med 2, resten multipliceras med 1
            if (i % 2 == 0)
            {
                siffra *= 2;

                // Om produkten blir tvåsiffrig, lägg ihop siffrorna (ex. 16 -> 1 + 6 = 7)
                if (siffra > 9)
                {
                    siffra = siffra - 9;
                }
            }

            // Lägg till siffra i summan
            summa += siffra;
        }

        // Personnumret är giltigt om summan är jämnt delbar med 10
        return (summa % 10 == 0);
    }

    // Metod för att bestämma kön baserat på personnummer
    public string BestämKön()
    {
        // Kolla om personnumret är tillräckligt långt för att ha en födelsenummerdel
        if (Personnummer.Length >= 10)
        {
            // Hämta den näst sista siffran från personnumret (som avgör kön)
            int könSiffra = int.Parse(Personnummer.Substring(Personnummer.Length - 2, 1));
            return könSiffra % 2 == 0 ? "Kvinna" : "Man";
        }
        return "Okänt";
    }
}
