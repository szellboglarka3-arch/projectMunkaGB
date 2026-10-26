
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace projectMunkaGB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey billentyu = ConsoleKey.NoName;
            ConsoleKey bilo = ConsoleKey.NoName;
            ConsoleKey elagazasElso = ConsoleKey.NoName;
            ConsoleKey elagazas1 = ConsoleKey.NoName;
            ConsoleKey elagazas2 = ConsoleKey.NoName;
            ConsoleKey valasztas2 = ConsoleKey.NoName;
            ConsoleKey valasztas3 = ConsoleKey.NoName;
            ConsoleKey elagazas3 = ConsoleKey.NoName;
            ConsoleKey valasztas4 = ConsoleKey.NoName;



            int HP = 100;
            string nev = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Üdvözlünk a kalandjátékunkban!");

            nev:
                Console.Write("Kérlek add meg a Neved: ");
                nev = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nev))
                {
                    Console.Clear();
                    goto nev;
                }

                Console.Clear();
                Console.WriteLine($"Név: {nev}");
                Console.WriteLine($"HP: {HP}");
                Console.WriteLine("Előre:felső nyíl \n Balra:bal nyíl \n Jobbra:jobb nyíl");

                Console.WriteLine("\nNyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.Clear();

            bevevezto:
                string kezdo = "Egy szép őszi napon te és a barátaid elkezdtetek egy túrán gondolkozni Cuha-völgybe.. \n Viszont egyik haverod egy csavart rakott a túrába,ő azt mondta este menjetek,mert az sokkal viccesebb. \n Ti az elején hezitáltatok,de végül bele mentetek.\n Rá egy hétre el is indultattok! Kocsival mentettek fél órát utaztattok,már sötétt volt és elég ijesztő volt hogy csak ti vagytok az utakon.\n";

                string[] szavakBeve = kezdo.Split(' ');

                foreach (string szo in szavakBeve)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine(@"   
    o_______________}o{
   |              |   \
   |              |____\_____
   | _____        |    |_o__ |
   [/ ___ \       |   / ___ \|
  []_/.-.\_\______|__/_/.-.\_[]
     |(O)|             |(O)|
      '-'               '-'
---   ---   ---   ---   ---   --- ");

                Console.ResetColor();

                Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;

                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                string kezdo2 = "Mikor oda értetek a Cuha-völgybe,elkezdtetek túrázni.\n Egyre mélyebbre mentettek a völgybe.\n Fél óra után elkezdtettek rakni egy kis tábor tüzet,mindeki szedett faágakat.\n Miután megettétek az ennivalókat, eloltottátok a tüzet és indultattok tovább.\n Viszont neked ki kötődött a cipőd,ezért megálltál bekötni.\n Viszont amikor felnéztél már nem volt ott senki...egyedül maradtál...\n";

                string[] szavakBeve2 = kezdo2.Split(' ');

                foreach (string szo in szavakBeve2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }

                string kezdo3 = $"\nA sötétségben,csak 1 zseblámpád van és egy telefonod..de persze nincs térerőd...Mit teszel {nev}?\n Előre,Jobbra vagy Balra?\n";

                string[] szavakBeve3 = kezdo3.Split(' ');

                foreach (string szo in szavakBeve3)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }

                elagazasElso = Console.ReadKey(true).Key;
                Console.Clear();

                // ELSŐ VÁLASZTÁS: ELŐRE
                if (elagazasElso == ConsoleKey.UpArrow)
                {
                    string egy = $"Elindultál előre. Körülbelül 10 perc után elértél a völgy mélyében egy kis tavat és egy újabb elágazást.\n {nev} merre mész?\n Jobbra vagy Balra?\n";

                    string[] szavakEgy = egy.Split(' ');

                    foreach (string szo in szavakEgy)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(150);
                    }

                    elagazas1 = Console.ReadKey(true).Key;
                    Console.Clear();

                    // MÁSODIK VÁLASZTÁS: JOBBRA
                    if (elagazas1 == ConsoleKey.RightArrow)
                    {
                        string jobbra1 = "Elindultál jobbra, egy kis tisztásra értél, ahol egy kis kunyhót találtál.\n A kunyhóban egy idős bácsi lakott, aki elmondta hogy a völgyet kívül belül ismeri, viszont csak ha jó választ adsz akkor vezet ki.\n";

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine(@"                .
        ('
        '|
        |'
       [::]
       [::]   _......_
       [::].-'      _.-`.
       [:.'    .-. '-._.-`.
       [/ /\   |  \        `-..
       / / |   `-.'      .-.   `-.
      /  `-'            (   `.    `.
     |           /\      `-._/      \
     '    .'\   /  `.           _.-'|
    /    /  /   \_.-'        _.':;:/
  .'     \_/             _.-':;_.-'
 /   .-.             _.-' \;.-'
/   (   \       _..-'     |
\    `._/  _..-'    .--.  |
 `-.....-'/  _ _  .'    '.|

          | |_|_| |      | \  (o)
     (o)  | |_|_| |      | | (\'/)
    (\'/)/  ''''' |     o|  \;:;
     :;  |        |      |  |/)
   ;: `-.._    /__..--'\.' ;:
          :;  `--' :;   :; 
");

                        Console.ResetColor();

                        string[] szavakKetto = jobbra1.Split(' ');

                        foreach (string szo in szavakKetto)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }

                    kerdes:
                        Console.WriteLine("\nAdy Endre melyik kötetével indult el hivatalosan a magyar irodalmi modernség 1906-ban? (1: Új versek | 2: Vér és arany)");

                        ConsoleKey valasztas = Console.ReadKey(true).Key;

                        if (valasztas == ConsoleKey.D1 || valasztas == ConsoleKey.NumPad1)
                        {
                            goto veg;
                        }
                        else if (valasztas == ConsoleKey.D2 || valasztas == ConsoleKey.NumPad2)
                        {
                            HP = HP - 50;
                            Console.WriteLine($"HP: {HP}");
                            goto kerdes1;
                        }
                        else
                        {
                            Console.WriteLine("\nNincs ilyen választási lehetőség. Próbáld újra.");
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto kerdes;
                        }

                    kerdes1:
                        Console.Clear();
                        Console.WriteLine("Hibás válasz!");
                        Console.WriteLine($"Jelenlegi HP: {HP}");
                        Console.WriteLine("\nArany János melyik híres történelmi balladájában jelenik meg a bűn és bűnhődés lélektani drámája a megőrülésen keresztül? (1: Tetemre hívás | 2: Ágnes asszony)");

                        valasztas2 = Console.ReadKey(true).Key;

                        if (valasztas2 == ConsoleKey.D1 || valasztas2 == ConsoleKey.NumPad1)
                        {
                            HP = HP - 50;
                            Console.WriteLine($"HP: {HP}");

                            if (HP <= 0)
                            {
                                goto veg3;
                            }

                            goto kerdes1;
                        }
                        else if (valasztas2 == ConsoleKey.D2 || valasztas2 == ConsoleKey.NumPad2)
                        {
                            goto veg;
                        }
                        else
                        {
                            Console.WriteLine("\nNincs ilyen választási lehetőség. Próbáld újra.");
                            Thread.Sleep(1500);
                            goto kerdes1;
                        }
                    }

                    // MÁSODIK VÁLASZTÁS: BALRA
                    else if (elagazas1 == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();

                        string balra2 = "Elindultál balra, viszont egy sötét barlangba értél,ahol érdekes hangokat hallotál...\n";

                        string[] szavakKetto1 = balra2.Split(' ');

                        foreach (string szo in szavakKetto1)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }

                        Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                        bilo = Console.ReadKey(true).Key;
                        Thread.Sleep(5000);
                        HP = HP - 100;

                        goto veg2;
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen választási lehetőség.");
                        Thread.Sleep(1500);
                        goto jatekVegeCiklus;
                    }
                }
                // ELSŐ VÁLASZTÁS: BALRA
                else if (elagazasElso == ConsoleKey.LeftArrow)
                {
                    Console.Clear();

                    string bal= ($"Elindultál balra. A völgyben egyre messzebb és messzebb sétálsz, amikor meglátsz egy érdekes alakot. Mit teszel, {nev}?");
                    string[] szavakKetto = bal.Split(' ');

                    foreach (string szo in szavakKetto)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(150);
                    }
                irany1:
                    string irany1 = ("1: Előre mész és odamész az alakhoz? | 2: Visszafelé mész?");
                    string[] szavakKetto1 = irany1.Split(' ');

                    foreach (string szo in szavakKetto1)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(150);
                    }

                    elagazas2 = Console.ReadKey(true).Key;
                    Console.Clear();
                    // ELSŐ VÁLASZTÁS: ELŐRE MÉSZ AZ ALAKHOZ
                    if (elagazas2 == ConsoleKey.D1 || elagazas2 == ConsoleKey.NumPad1)
                    {
                        string alakFelé = ($"Elindulsz az alak felé...Ahogy közeledsz, az alak egyre inkább felismerhetővé válik... a hideg ráz ki, de felismered: csak egy idős néni.\nA néninek beakadt a ruhája. Mit teszel, {nev}?");
                        string[] szavakKetto2 = alakFelé.Split(' ');

                        foreach (string szo in szavakKetto2)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }

                    valasz1:
                        string valasz1 = ("1: Segítesz az idős hölgynek? | 2: Ott hagyod és mész előre?");
                        string[] szavakKetto3 = valasz1.Split(' ');

                        foreach (string szo in szavakKetto3)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }


                        valasztas3 = Console.ReadKey(true).Key;
                        Console.Clear();

                        if (valasztas3 == ConsoleKey.D1 || valasztas3 == ConsoleKey.NumPad1)
                        {
                            string segit = ("Segítesz az idős hölgynek,az idős hölgy megköszinni és ad neked egy varázsitalt és ezzel együtt ki is vezet a völgyből.");
                            string[] szavakKetto18 = segit.Split(' ');

                            foreach (string szo in szavakKetto18)
                            {
                                Console.Write(szo + " ");
                                Thread.Sleep(150);
                            }
                            Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                            bilo = Console.ReadKey(true).Key;

                            goto veg4;
                        }
                        else if (valasztas3 == ConsoleKey.D2 || valasztas3 == ConsoleKey.NumPad2)
                        {
                            string otthagy = ("Otthagyod az idős hölgyet, és továbbmész.\n Hirtelen zajt hallasz a fák közül, és rájössz, hogy eltévedtél..látsz veled szemben egy hatalmas árnyat de mire felfognád rád támad,menekülni sem tudsz");
                            string[] szavakKetto15 = otthagy.Split(' ');

                            foreach (string szo in szavakKetto15)
                            {
                                Console.Write(szo + " ");
                                Thread.Sleep(150);
                            }
                            Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                            bilo = Console.ReadKey(true).Key;
                            goto veg5;

                        }
                        else
                        {
                            Console.WriteLine("Nincs ilyen választási lehetőség.");
                            goto valasz1;
                        }
                    }
                    // ELSŐ VÁLASZTÁS: VISSZAFELÉ MÉSZ
                    else if (elagazas2 == ConsoleKey.D2 || elagazas2 == ConsoleKey.NumPad2)
                    {
                        string vissza = ("Visszafelé indulsz..viszont rossz irányba mész,de nagy csodálkozásodra megtaláltad a barátaidat akik egy tűz körül ültek");
                        string[] szavakKetto16 = vissza.Split(' ');

                        foreach (string szo in szavakKetto16)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }
                        Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                        bilo = Console.ReadKey(true).Key;
                        goto veg6;
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen választási lehetőség.");
                        goto irany1;

                    }

                    
                }

                // ELSŐ VÁLASZTÁS: JOBBRA
                else if (elagazasElso == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                valasztas6:

                    string templom = $"Elindulsz jobbra.\n Nem sokkal később meglátsz egy hatalmas templomot,amiból fény jön ki. \n Mit teszel{nev}? \n 1:Felmész a templomba? | 2: Megdobod egy kővel azt az ablakot ahol világos van";
                    string[] szavakKetto17 = templom.Split(' ');

                    foreach (string szo in szavakKetto17)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(150);
                    }



                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine(@"                .
                        _|_
                   |
                  / \
                 //_\\
                //(_)\\
                 |/^\| 
       ,%%%%     // \\    ,@@@@@@@,
     ,%%%%/%%%  //   \\ ,@@@\@@@@/@@,
 @@@%%%\%%//%%%// === \\ @@\@@@/@@@@@
@@@@%%%%\%%%%%// =-=-= \\@@@@\@@@@@@;%#####,
@@@@%%%\%%/%%//   ===   \\@@@@@@/@@@%%%######,
@@@@@%%%%/%%//|         |\\@\\//@@%%%%%%#/####
'@@@@@%%\\/%~ |         | ~ @|| %\\//%%%#####;
  @@\\//@||   |  __ __  |    || %%||%%'######
   '@||  ||   | |  |  | |    ||   ||##\//####
     ||  ||   | | -|- | |    ||   ||'#||###'
     ||  ||   |_|__|__|_|    ||   ||  ||
     ||  ||_/`  =======  `\__||_._||  ||
   __||_/`      =======            `\_||___

");

                    Console.ResetColor();


                    elagazas3 = Console.ReadKey(true).Key;
                    Console.Clear();

                    if (elagazas3 == ConsoleKey.D1 || elagazas3 == ConsoleKey.NumPad1)
                    {
                        string fel = ($"Felmész a templomba.\n Legfelül meglátsz egy szép kis erdőt,tele fákkal\n Az egyik fából kijön egy kis tündér,aki azt mondta:'Felteszek neked egy kérdes,ha tudod a választ ifjú ember,kisegítünk a völgyből!\n'Ime a kérdés: \n   Petőfi Sándor melyik híres elbeszélő költeményének a főhőse Kukorica Jancsi, aki a történet végén Tündérország fejedelme lesz?' Mi a helyes válasz {nev}? 1:János vitéz | 2:Toldi ");
                        string[] szavakKetto1 = fel.Split(' ');

                        foreach (string szo in szavakKetto1)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }
                        valasztas4 = Console.ReadKey(true).Key;
                        Console.Clear();
                        if (valasztas4 == ConsoleKey.D1 || valasztas4 == ConsoleKey.NumPad1)
                                                    {
                            Console.WriteLine("Helyes válasz!");
                            Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                            bilo = Console.ReadKey(true).Key;
                            goto veg7;
                        }
                        else if (valasztas4 == ConsoleKey.D2 || valasztas4 == ConsoleKey.NumPad2)
                        {
                            Console.WriteLine("Helytelen válasz. A tündér vissza ment a lakhelyére.");

                            Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                            bilo = Console.ReadKey(true).Key;
                            goto veg8;
                        }
                        else
                        {
                            Console.WriteLine("Nincs ilyen választási lehetőség.");
                        }

                    }
                    else if (elagazas3 == ConsoleKey.D2 || elagazas3 == ConsoleKey.NumPad2)
                    {
                        string bedob = ("Bedobtad a világító ablakot.Viszont semmi sem történt ezért bemész a templomba.");
                        string[] szavakKetto18 = bedob.Split(' ');

                        foreach (string szo in szavakKetto18)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }
                        Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                        bilo = Console.ReadKey(true).Key;
                        goto veg9;
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen választási lehetőség.");
                        goto valasztas6;

                    }

                }
                else
                {
                    Console.WriteLine("Nincs ilyen választási lehetőség.");
                    Thread.Sleep(1500);
                    goto jatekVegeCiklus;
                }

            veg:
                Console.Clear();
                string veg = ("Ügyes vagy eltaláltad! A bácsi kivezetett a völgyből és a barátaid már kint vártak!");
                string[] szavakKetto4 = veg.Split(' ');

                foreach (string szo in szavakKetto4)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;

            veg2:
                Console.Clear();
                string veg2 = ($"Meghaltál a medve által..\n Elfogytak a pontjaid. HP: {HP}");
                string[] szavakKetto5 = veg2.Split(' ');

                foreach (string szo in szavakKetto5)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;

            veg3:
                Console.Clear();
                string veg3 = ($"Meghaltál a bácsi által..\n Elfogytak a pontjaid. HP: {HP}");
                string[] szavakKetto6 = veg3.Split(' ');

                foreach (string szo in szavakKetto6)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;
            veg4:
                Console.Clear();
                string veg4 = ("Az idős hölgy kivezetett a völgyböl veled együtt, elmondta neked hogy ő egy boszi és ha megiszod az italát te is az lehetel.");
                string[] szavakKetto7 = veg4.Split(' ');

                foreach (string szo in szavakKetto7)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;
            veg5:
                Console.Clear();
                string veg5 = ("Elsem tudtál futni az árnytól így magával vitt a sötétségbe.");
                string[] szavakKetto8 = veg5.Split(' ');

                foreach (string szo in szavakKetto8)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;
            veg6:
                Console.Clear();
                string veg6 = ("A barátaid nagyon megijedtek tőled,egyik hozzád hajított egy botot.\n Viszont amikor felismertek rettentően megörültek neked.\n Eloltottátok a tüzet és együtt haza mentettek.");
                string[] szavakKetto9 = veg6.Split(' ');

                foreach (string szo in szavakKetto9)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;
            veg7:
                Console.Clear();
                string veg7 = ("A tündér felkapott és kirepültettek a völgyből.");
                string[] szavakKetto10 = veg7.Split(' ');

                foreach (string szo in szavakKetto10)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;
            veg8:
                Console.Clear();
                string veg8 = ("Egyedül maradtál a templomba.\n Ahogy elindultál lefelé hatalmas pókok támadtak rád..nem élted túl.");
                string[] szavakKetto11 = veg8.Split(' ');

                foreach (string szo in szavakKetto11)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus    ;
            veg9:
                Console.Clear();
                string veg9 = ("Amikor felérsz a templom tetejére,egy csomó kis tündér mérgesen vár téged és rád támadtak..sikerült elfutnod előlül viszont rengeteg sebed marad.\n Sok séta után megtaláltad a kocsittokat amivel jötettek és ott vártad a barátaidat.");
                string[] szavakKetto12 = veg9.Split(' ');

                foreach (string szo in szavakKetto12)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;

            jatekVegeCiklus:
                Console.WriteLine("\nNyomj meg egy gombot a menühöz (Kilépés: ESC)");
                billentyu = Console.ReadKey(true).Key;

            } while (billentyu != ConsoleKey.Escape);
        }
    }
}
