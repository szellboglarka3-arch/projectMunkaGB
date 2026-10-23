using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

            int HP = 100;
            string nev = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Üdvözlünk a kalandjátékunkban!");
            nev:
                Console.Write("Kérlek add meg a Neved: ");
                nev = Console.ReadLine();
                if (nev == "")
                {
                    Console.Clear();
                    goto nev;
                }
                Console.Clear();
                Console.WriteLine($"Név: {nev}");
                Console.WriteLine($"HP: {HP}");

                Console.WriteLine("\nNyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.Clear();

            bevevezto:
                string kezdo = "Egy szép őszi napon te és a barátai elkezdettek egy túrán gondolkozni Cuha-völgybe.. \n Viszont egyik haverod egy csavart rakott a túrára,ő azt mondta este menjetek,mert az sokkal viccesebb. \n Ti az elején hezitáltattok,de végül bele mentettek.\n Rá egy hétre el is indultattok! Kocsival mentettek fél órát utaztattok,már sötétt volt és elég ijesztő volt hogy csak ti vagytok az utakon.\n";
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
                string kezdo2 = "Mikor oda értetek a Cuha-völgybe,elkezdtetek túrázni.\n Egyre mélyebbre mentettek a völgybe.\n Fél óra után elkezdtettek rakni egy kis tábor tüzet,mindeki szedett faágakat.\n Miután megettétek aennivalókat, eloltottátok a tüzet és indultattok tovább.\n Viszont neked ki kötődött a cipőd,ezért megálltál bekötni.\n Viszont amikor felnéztél már nem volt ott senki...egyedül maradtál...\n";
                string[] szavakBeve2 = kezdo2.Split(' ');
                foreach (string szo in szavakBeve2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }

                string kezdo3 = $"\nA sötétségben,csak 1 zseblámpád van és egy telefonod..de nincs térerő...Mit {nev} teszel?\n Előre,Jobbra vagy Balra?\n";
                string[] szavakBeve3 = kezdo3.Split(' ');
                foreach (string szo in szavakBeve3)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(150);
                }
                elagazasElso = Console.ReadKey(true).Key;
                Console.Clear();

                if (elagazasElso == ConsoleKey.UpArrow)
                {
                    string egy = $"Elindultál előre. Körülbelül 10 perc után elértél a völgy mélyében egy kis tót és egy újabb elágazást.\n {nev} merre mész?\n Jobbra vagy Balra?\n";
                    string[] szavakEgy = egy.Split(' ');
                    foreach (string szo in szavakEgy)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(150);
                    }
                    elagazas1 = Console.ReadKey(true).Key;
                    Console.Clear();

                    if (elagazas1 == ConsoleKey.RightArrow)
                    {
                    ketto:
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

                        Console.WriteLine("\nAdy Endre melyik kötetével indult el hivatalosan a magyar irodalmi modernség 1906-ban? (1: Új versek | 2: Vér és arany)");
                        ConsoleKey valasztas = Console.ReadKey(true).Key;

                        if (valasztas == ConsoleKey.D1 || valasztas == ConsoleKey.NumPad1)
                        {
                            goto veg;
                        }
                        else if (valasztas == ConsoleKey.D2 || valasztas == ConsoleKey.NumPad2)
                        {
                            HP = HP - 50;
                            Console.WriteLine($"HP:{HP}");
                            goto ketto;
                        }
                        else
                        {
                            Console.WriteLine("\nNincs ilyen választási lehetőség. Próbáld újra.");
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto ketto;
                        }
                    }

                    if (elagazas1 == ConsoleKey.LeftArrow)
                    {
                        string balra2 = "Elindultál balra, viszont egy sötét barlangba értél,ahol érdekes hangokat hallotál...\n";
                        string[] szavakKetto1 = balra2.Split(' ');
                        foreach (string szo in szavakKetto1)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(150);
                        }
                        Thread.Sleep(3000);
                        HP = HP - 100;
                        goto veg2;
                    }
                }

                goto jatekVegeCiklus;

            veg:
                Console.Clear();
                Console.WriteLine("Ügyes vagy eltaláltad! A bácsi kivezetett a völgyből és a barátaid már kint vártak!");
                Thread.Sleep(150);
                goto jatekVegeCiklus;

            veg2:
                Console.Clear();
                Console.WriteLine("Meghaltál a medve által..");
                Console.WriteLine($"\nElfogytak a pontjaid. HP: {HP}");
                Thread.Sleep(150);
                goto jatekVegeCiklus;

            jatekVegeCiklus:
                Console.WriteLine("\nNyomj meg egy gombot a menühöz (Kilépés: ESC)");
                billentyu = Console.ReadKey(true).Key;

            } while (billentyu != ConsoleKey.Escape);
        }
    }
}
