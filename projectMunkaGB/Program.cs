
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
                HP = 100;
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
                Console.Clear();
                Console.WriteLine("A játékban a döntéseid befolyásolják a történet alakulását, ezért figyelj jól a választásaidra!\n\n");   
                string kezdo = "Egy szép őszi napon te és a barátaid elkezdtetek egy túrán gondolkozni a Cuha-völgybe. \r\n Viszont egyik haverod egy csavart rakott a túrába: ő azt mondta, este menjetek, mert az sokkal viccesebb. \r\n Ti az elején hezitáltatok, de végül belementetek.\r\n Rá egy hétre el is indultatok! \r\n Kocsival mentetek, fél órát utaztatok, már sötét volt, és elég ijesztő volt, hogy csak ti vagytok az utakon.\r\n";

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

                string kezdo2 = "Mikor odaértetek a Cuha-völgybe, elkezdtetek túrázni.\n\r\nEgyre mélyebbre mentetek a völgybe.\n\r\nFél óra után elkezdtetek rakni egy kis tábortüzet, mindenki szedett faágakat.\n\r\nMiután megettétek az ennivalót, eloltottátok a tüzet és indultatok tovább.\n\r\nViszont neked kikötődött a cipőd, ezért megálltál bekötni.\n\r\nViszont amikor felnéztél, már nem volt ott senki... egyedül maradtál...\n\n";

                string[] szavakBeve2 = kezdo2.Split(' ');

                foreach (string szo in szavakBeve2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }

                string kezdo3 = $"\nA sötétségben,csak 1 zseblámpád van és egy telefonod..de persze nincs térerőd...\r\n Mit teszel {nev}?\n Előre,Jobbra vagy Balra?\n";

                string[] szavakBeve3 = kezdo3.Split(' ');

                foreach (string szo in szavakBeve3)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }


                // ELSŐ VÁLASZTÁS: ELŐRE
                do
                {
                    elagazasElso = Console.ReadKey(true).Key;

                    if (elagazasElso != ConsoleKey.UpArrow &&
                        elagazasElso != ConsoleKey.LeftArrow &&
                        elagazasElso != ConsoleKey.RightArrow)
                    {
                        Console.WriteLine(
                            "\nHibás választás! Használd a nyilakat!"
                        );
                    }
                } while (elagazasElso != ConsoleKey.UpArrow &&
         elagazasElso != ConsoleKey.LeftArrow &&
         elagazasElso != ConsoleKey.RightArrow);

                Console.Clear();
                if (elagazasElso == ConsoleKey.UpArrow)
                {
                    string egy = $"Elindultál előre. Körülbelül 10 perc után elértél a völgy mélyében egy kis tavat és egy újabb elágazást.\n {nev} merre mész?\r\n Jobbra vagy Balra?\n";

                    string[] szavakEgy = egy.Split(' ');

                    foreach (string szo in szavakEgy)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(150);
                    }


                    do
                    {
                        elagazas1 = Console.ReadKey(true).Key;

                        if (elagazas1 != ConsoleKey.RightArrow &&
                            elagazas1 != ConsoleKey.LeftArrow)
                        {
                            Console.WriteLine(
                                "\nHibás választás! Használd a balra vagy jobbra nyilat!"
                            );
                        }

                    } while (elagazas1 != ConsoleKey.RightArrow &&
                             elagazas1 != ConsoleKey.LeftArrow);

                    Console.Clear();
                    // MÁSODIK VÁLASZTÁS: JOBBRA
                    if (elagazas1 == ConsoleKey.RightArrow)
                    {
                        string jobbra1 = "Elindultál jobbra, egy kis tisztásra értél, ahol egy kis kunyhót találtál.\r\n A kunyhóban egy idős bácsi lakott, aki elmondta, hogy a völgyet kívül-belül ismeri, viszont csak akkor vezet ki, ha jó választ adsz.\r\n";

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
                        Console.WriteLine("\nAdy Endre melyik kötetével indult el hivatalosan a magyar irodalmi modernség 1906-ban?\r\n (1: Új versek | 2: Vér és arany)");

                        ConsoleKey valasztas = Console.ReadKey(true).Key;

                        if (valasztas == ConsoleKey.D1 || valasztas == ConsoleKey.NumPad1)
                        {
                            goto veg;
                        }
                        else if (valasztas == ConsoleKey.D2 || valasztas == ConsoleKey.NumPad2)
                        {
                            HP = HP - 50;
                            Console.WriteLine($"HP: {HP}");
                            Console.Clear();
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
                        Console.WriteLine("\nArany János melyik híres történelmi balladájában jelenik meg a bűn és bűnhődés lélektani drámája a megőrülésen keresztül?\r\n (1: Tetemre hívás | 2: Ágnes asszony)");

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
                            Console.Clear();
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
                        Thread.Sleep(50);
                        HP = HP - 100;

                        goto veg2;
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen választási lehetőség.");
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto jatekVegeCiklus;
                    }
                }
                // ELSŐ VÁLASZTÁS: BALRA
                else if (elagazasElso == ConsoleKey.LeftArrow)
                {
                    Console.Clear();

                    string bal= ($"Elindultál balra.\r\nA völgyben egyre messzebb és messzebb sétálsz, amikor meglátsz egy érdekes alakot. \r\nMit teszel, {nev}?");
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
                        string alakFelé = ($"Elindulsz az alak felé... Ahogy közeledsz, az alak egyre inkább felismerhetővé válik... a hideg ráz ki, de felismered: csak egy idős néni.\r\nA néninek beakadt a ruhája.\r\nMit teszel, {nev}?");
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
                            string segit = ("Segítesz az idős hölgynek. \r\n Az idős hölgy megköszinni és ad neked egy varázsitalt és ezzel együtt ki is vezet a völgyből.");
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
                            string otthagy = ("Otthagyod az idős hölgyet, és továbbmész.\r\n Hirtelen zajt hallasz a fák közül, és rájössz, hogy eltévedtél... Látsz veled szemben egy hatalmas árnyat, de mire felfognád, rád támad, menekülni sem tudsz.");
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
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto valasz1;
                        }
                    }
                    // ELSŐ VÁLASZTÁS: VISSZAFELÉ MÉSZ
                    else if (elagazas2 == ConsoleKey.D2 || elagazas2 == ConsoleKey.NumPad2)
                    {
                        string vissza = ("Visszafelé indulsz... viszont rossz irányba mész, de nagy csodálkozásodra megtaláltad a barátaidat, akik egy tűz körül ültek.");

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(@"                .
            (                 ,&&&.
             )                .,.&&
            (  (              \=__/
                )             ,'-'.
          (    (  ,,      _.__|/ /|
           ) /\ -((------((_|___/ |
         (  // | (`'      ((  `'--|
       _ -.;_/ \\--._      \\ \-._/.
      (_;-// | \ \-'.\    <_,\_\`--'|
      ( `.__ _  ___,')      <_,-'__,'
       `'(_ )_)(_)_)'
");

                        Console.ResetColor();


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
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto irany1;

                    }

                    
                }

                // ELSŐ VÁLASZTÁS: JOBBRA
                else if (elagazasElso == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                valasztas6:

                    string templom = $"Elindulsz jobbra.\r\n Nem sokkal később meglátsz egy hatalmas templomot, amiből fény jön ki.\r\n Mit teszel, {nev}? \r\n1: Felmész a templomba? | 2: Megdobod egy kővel azt az ablakot, ahol világos van";
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
                        string fel = ($"Felmész a templomba.\r\n Legfelül meglátsz egy szép kis erdőt, tele fákkal.\r\n Az egyik fából kijön egy kis tündér, aki azt mondta: „Felteszek neked egy kérdést, ha tudod a választ, ifjú ember, kisegítünk a völgyből!”\r\n Íme a kérdés: \r\n Petőfi Sándor melyik híres elbeszélő költeményének a főhőse Kukorica Jancsi, aki a történet végén Tündérország fejedelme lesz? \r\n");

                        string[] szavakKetto1 = fel.Split(' ');

                        foreach (string szo in szavakKetto1)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }
                    tunderkerdes:
                        string kerdes = ($"Mi a helyes válasz, {nev}? 1: János vitéz | 2: Toldi");  
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine(@"                .
                              _                           _
     / `._        \+O+/        _.' \
    ( @ : `.      //`\\      .' : @ )
     \  `.  `.   ((a a))   .'  .'  /
      \;' `.  `.((( - ))).'  .' `;/
       \`.  `.  ((()=()))  .'  .'/
        ) :-._`/`((""Y""))`\'_.-: (
        (`..../ /(_ * _)\ \....')
         >---/ /  )   (  \ \---<
        / .'.\ \_/\\_//\_/ /.'. \
        |o _.-\/_) '*' (_\/-._ o|
        |`'   ;/         \;   `'|
        "".o_.-/           \-._o.""
          ""._/             \_.""
            /               \
           /                 \
          /                   \
         /                     \
        /                       \
        `----....._____.....----'
------------------------------------------------

");
                        Console.ResetColor();
                        Console.WriteLine(kerdes);
                        Console.ResetColor();
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
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto tunderkerdes;
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
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(@"                .
       _
       ///-._
      ////////-._
     /////////////-.
    ////////////////`.
   //////////////// .'`.
  //////////////// . '.'`.
 '|`'//////////// . .'.::|`
  :    `'///////   . '.':|
  |  .   . `'//  ' _|- ::|
  |.  .-._  . | .   | .'::
  |   |:|:|   |  ' ' '.::|
  |   |:|:|   :.  . .'.':|
  | . |:|:| . |    .._.:::
  :    `':|   |  ' ////-:|
  |.    .     |  '/////////-._
  |   .     . : .//////////////-._
  :           : ///////////////////-._
  |.          |////////////////////////-._
  |    .  .   :`'//////////////////////////-._
  | .       _.-\\\\``'//////////////////////////-._
  |        /\\\\\\\\..``'//////////////////////////"".
  :  .  . /. \\\\\\\\\.  .``'///////////////////// .'`.
  :      /  _ \\\\\\\\\.      ``'//////////////// .  .'`.
  | .   /  (@) \\\\\\\\\.  . .    ``'/////////// .  '.'::|.
 {`)._ '|  _`  .\\\\\\\-`:|#|  .  .   ``'//////   '. .'.:|
  `-{_/`| ||::.  \\'`.:|:.|#| |#|  .      ``'/  ' .##:':::
      `-| |||||  |`.'::|::|#| |#| |#|  .  . '| . .|##|'.:|
        | |||||  : .'::|:.'#| |#| |#| |#|    |    |##|'::|
        | ||||| .| .'.:|::.'' '#| |#| |#| .  :  ' |##|'.:|
       {`\:||||  : .'::|:_.:.  .  '#| |#|    |   .|##|':::
        `-{_/'|_ |_.-'/}_/'-._        '#|    :.   |##:'.:|
           `'{._('}_)-'  `-}_}(-._ .    .    |  ' '` .'::|
                `-'          `-.} /-._    .  :   .'.'_:-'\
                                 `-}_}(-._   | . _.-')_(-'
                                     `-/_)`-.:.-{ \{-'
                                         `-{_'_)-''

");
                        
                        Console.ResetColor();
                        Console.WriteLine("\n\nNyomj meg egy billentyűt a folytatáshoz...");
                        bilo = Console.ReadKey(true).Key;
                        goto veg9;
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen választási lehetőség.");
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto valasztas6;

                    }

                }
                else
                {
                    Console.WriteLine("Nincs ilyen választási lehetőség.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto jatekVegeCiklus;
                }

            veg:
                Console.Clear();
                string veg = ("Ügyes vagy, eltaláltad! \r\n A bácsi kivezetett a völgyből, és a barátaid már kint vártak!");
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
                string veg2 = ($"Meghaltál a medve által...\r\n Elfogytak a pontjaid. HP: {HP}");
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
                string veg3 = ($"Meghaltál a bácsi által... Elfogytak a pontjaid. HP: {HP}");
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
                string veg4 = ("Az idős hölgy kivezetett a völgyből veled együtt, elmondta neked, hogy ő egy boszi, és ha megiszod az italát, te is az lehetsz.");
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
                string veg5 = ("El sem tudtál futni az árnyék elől, így magával vitt a sötétségbe.");
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
                string veg6 = ("A barátaid nagyon megijedtek tőled, egyik hozzád hajított egy botot.\r\n Viszont amikor felismertek, rettentően megörültek neked.\r\n Eloltottátok a tüzet, és együtt hazamentetek.");
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
                string veg7 = ("A tündér felkapott, és kirepített a völgyből.");
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
                string veg8 = ("Egyedül maradtál a templomban.\r\n Ahogy elindultál lefelé, hatalmas pókok támadtak rád.\r\n Nem élted túl.");
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
                string veg9 = ("Amikor felérsz a templom tetejére, egy csomó kis tündér mérgesen vár téged, és rád támadnak... Sikerült elfutnod előlük, viszont rengeteg sebed maradt. \r\nSok séta után megtaláltad a kocsitokat, amivel jöttetek, és ott vártad a barátaidat..");
                string[] szavakKetto12 = veg9.Split(' ');

                foreach (string szo in szavakKetto12)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                Thread.Sleep(150);
                goto jatekVegeCiklus;


            jatekVegeCiklus:
                Console.WriteLine();
                string ujraJatszani = "Szeretnél újra játszani? \r\n ENTER - Igen\r\n ESCAPE - Nem";
                string[] szavakKetto19 = ujraJatszani.Split(' ');

                foreach (string szo in szavakKetto19)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }

                do
                {
                    billentyu = Console.ReadKey(true).Key;

                } while (billentyu != ConsoleKey.Enter &&
                         billentyu != ConsoleKey.Escape);

            } while (billentyu != ConsoleKey.Escape);

            Console.Clear();
            Console.WriteLine("Köszönöm, hogy játszottál!");
        }
    }
}
