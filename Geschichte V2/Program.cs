using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Geschichte_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Title = "Meine Lerngeschichte";
            //Abschnitt für das Titelbild
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************************************************************************************");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                             Das Lerndilemma                              ");
                        Console.WriteLine();
            Console.WriteLine("Du musst eine Arbeit pünktlich um 18 Uhr abgeben. Jedoch treten ständig Konflikte auf, \nwelche du bewältigen musst. Viel Erfolg!");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

            //Starteingabe für Spiel
            Console.WriteLine("Game mit der Taste <S> starten!");
            string starteingabe = Console.ReadLine();
            if (starteingabe.ToLower() == "s")
            {
                //s wurde eingegeben. Die Überprüfung startet.
                System.Console.Clear();
                //Szene 1
                // Einführungstext schreiben
                Console.WriteLine("Dein Wecker reisst dich an einem schönen Sonntagmorgen aus dem Schlaf. Dir fällt ein, dass du heute noch deine Arbeit für die Uni fertigstellen musst.Deshalb musst du dich sofort aus dem Bett erheben und mit der Arbeit beginnen.");
                //Option A
                Console.WriteLine("A: Du fühlst dich noch sehr müde. Deshalb schaltest du den Wecker aus und schläfst noch eine Runde. Du wirst schon noch rechtzeitig fertig.");
                //Option B
                Console.WriteLine("B: Du weisst, dass du jetzt sofort aufstehen musst, um pünktlich mit der Arbeit fertig zu werden. Deshalb gehst du unter die Dusche und isst anschliessend ein kleines Frühstück.");
                Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste.");
                //Eingabe auslesen
                string eingabe = Console.ReadLine();
                //Eingabe überprüfen
                //Wenn man a eingegeben hat...
                if (eingabe.ToLower() == "a")
                {
                    Console.WriteLine("Szene 2A");
                    Console.WriteLine("Leider die Aufgabe nicht bestanden!");
                    Console.ReadKey();
                }
                //falls nicht, dann...
                else if (eingabe.ToLower() == "b")
                {
                    Console.WriteLine("Szene 2B");

                    //Szene 2
                    // Einführungstext schreiben
                    Console.WriteLine("Du hast nun geduscht und gefrühstückt. Du siehst aber das wunderschöne Wetter draussen. Langsam kommen die ersten Zweifel auf, ob du dich jetzt wirklich schon an die Arbeit setzen willst.");
                    //Option A
                    Console.WriteLine("A: Du willst vor dem Lernen noch eine Runde Sport machen und verschiebe deshalb die Arbeit um ein paar Stunden.");
                    //Option B
                    Console.WriteLine("B: Trotz dem schönen Wetter setzt du dich pflichtbewusst an deinen Pult und beginnst mit der Arbeit.");
                    string eingabe2 = Console.ReadLine();
                    //Wenn man a eingegeben hat...
                    if (eingabe2.ToLower() == "a")
                    {
                        Console.WriteLine("Szene 3A");
                        Console.WriteLine("Du hast nicht bestanden");
                    }
                    //falls b, dann...
                    else if (eingabe2.ToLower() == "b")
                    {
                        Console.WriteLine("Szene 3B");

                        //Szene 3
                        // Einführungstext schreiben
                        Console.WriteLine("Nach 2 konzentrierten Stunden raucht dir der Kopf. Du gehst in die Küche und holst dir einen Kaffee. Du setzt dich damit auf das Sofa vor den TV. Dabei fällt dir ein, dass du die neu angefangene Netflix Serie weiterschauen könntest.");
                        //Option A
                        Console.WriteLine("A: Du hast schon 2 Stunden konzentriert gearbeitet. Jetzt ist Zeit für eine Netflix Pause. Also stellst du den TV an und schaust deine Serie weiter.");
                        //Option B
                        Console.WriteLine("B: Du kennst dich und weisst, dass es meist nicht bei einer Folge bleibt. Deshalb entscheidest du dich vorbildlich für das Öffnen des Fensters, um den Kopf zu lüften und schreibst an der Arbeit weiter.");
                        string eingabe3 = Console.ReadLine();
                        //Wenn man a eingegeben hat...
                        if (eingabe3.ToLower() == "a")
                        {
                            Console.WriteLine("Szene 4A");
                            Console.WriteLine("Leider nein");
                        }
                        else if (eingabe3.ToLower() == "b")
                        {
                            Console.WriteLine("Szene 4B");
                            //Szene 4
                            // Einführungstext schreiben
                            Console.WriteLine("Gerade als du ein Kapitel abgeschlossen hast, kommt dein kleiner Bruder ins Zimmer und will mit dir spielen. Du erklärst ihm, dass du jetzt keine Zeit hast.");
                            //Option A
                            Console.WriteLine("A: Er beginnt zu weinen und will unbedingt mit dir spielen. Du gibst seinem Betteln nach und einigst dich, dass ihr ein kurzes Fussballspiel im Garten absolviert.");
                            //Option B
                            Console.WriteLine("B: Du bleibst standhaft und versprichst ihm ein Fussballspiel im Anschluss an das Fertigstellen der Arbeit und setzt deine Arbeit fort.");
                            string eingabe4 = Console.ReadLine();
                            //Wenn man a eingegeben hat...
                            if (eingabe4.ToLower() == "a")
                            {
                                Console.WriteLine("Szene 5A");
                                Console.WriteLine("Das war nichts. Du bist durchgefallen");
                            }
                            //Wenn man b eingegeben hat...
                            else if (eingabe4.ToLower() == "b")
                            {
                                Console.WriteLine("Szene 5B");
                                //Szene 5
                                // Einführungstext schreiben
                                Console.WriteLine("Plötzlich klingelt dein Telefon und reisst dich aus dem vertieften Arbeiten. Dein bester Kollege will mit dir ein Eis essen gehen.");
                                //Option A
                                Console.WriteLine("A: Es ist so heiss in deinem Zimmer und du benötigst sowieso eine Pause, dass du dich auf eine «kurze» Eispause» einlässt.");
                                //Option B
                                Console.WriteLine("B: Du erklärst deinem Freund, dass du jetzt nicht kannst. Du gehst aber gerne im Anschluss an die Abgabe ein Bier mit ihm trinken. Also verabredet ihr euch für den Abend und du kannst in Ruhe weiterarbeiten.");
                                string eingabe5 = Console.ReadLine();
                                //Wenn man a eingegeben hat...
                                if (eingabe5.ToLower() == "a")
                                {
                                    Console.WriteLine("Szene 6A");
                                    Console.WriteLine("Falsche Entscheidung. Du hast die Arbeit nicht bestanden.");
                                }
                                else if (eingabe5.ToLower() == "b")
                                {
                                    Console.WriteLine("Szene 6B");
                                    //Szene 6
                                    //Einführungstext schreiben
                                    Console.WriteLine("Du hast deine Arbeit pünktlich abgegeben und möchtest nun mit einem Kollegen Abendessen kochen. Also gehst du in den Coop und überlegst dir, was du kochen möchtest und was du dafür benötigst.");
                                    //Option 1
                                    Console.WriteLine("1 -> Kategorie G");
                                    //Option 2
                                    Console.WriteLine("2 -> Kategorie M ");
                                    //Option 3
                                    Console.WriteLine("3 -> Kategorie A1-45 ");
                                    //Option 4
                                    Console.WriteLine("4 -> Kategorie A1");
                                    //Option 5
                                    Console.WriteLine("5 -> Kategorie A-");
                                    //Option 6
                                    Console.WriteLine("6 -> Kategorie A");
                                    //Option 7
                                    Console.WriteLine("7 -> Kategorie B");
                                    //Option 8
                                    Console.WriteLine("8 -> keine Führerscheinkategoriem ersichtlich");
                                    int Menüwahl = Convert.ToInt32(Console.ReadLine());
                                    switch (Menüwahl)
                                    {
                                        case 1:
                                            Console.WriteLine("Pizza");
                                            {
                                                Console.WriteLine("Szene 7.1");
                                                Console.WriteLine("Super Wahl! Bitte kaufe Käse, Tomaten und Pepperoni.");
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("Spaghetti");
                                            {
                                                Console.WriteLine("Szene 7.2");
                                                Console.WriteLine("Super Wahl! Bitte kaufe Teigwaren, Tomaten und Hackfleisch.");
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("Reis mit Sauce");
                                            {
                                                Console.WriteLine("Szene 7.3");
                                                Console.WriteLine("Super Wahl! Bitte kaufe Reis und Sauce.");
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine("Suppe");
                                            {
                                                Console.WriteLine("Szene 7.4");
                                                Console.WriteLine("Super Wahl! Bitte kaufe Reis und Sauce.");
                                            }
                                            break;
                                        case 5:
                                            Console.WriteLine("Salat");
                                            {
                                                Console.WriteLine("Szene 7.5");
                                                Console.WriteLine("Super Wahl! Bitte kaufe Salat, Tomate und Sauce.");
                                            }
                                            break;
                                        case 6:
                                            Console.WriteLine("Brot");
                                            {
                                                Console.WriteLine("Szene 7.6");
                                                Console.WriteLine("Super Wahl! Bitte kaufe Brot und Butter.");
                                            }
                                            break;
                                        case 7:
                                            Console.WriteLine("Lieferdienst");
                                            {
                                                Console.WriteLine("Szene 7.7");
                                                Console.WriteLine("Perfekt! Das Essen wird nach dem strengen Tag zu dir geliefert und die Küche bleibt sauber!");
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Ungültiger Wert! Alle anderen Essen hat dein Kollege leider nicht gerne...");
                                            break;
                                    }
                                    Console.ReadLine();
                                }
                                //Bei ungültiger Eingabe aus Szene 5
                                else
                                {
                                    Console.WriteLine("Ungültiger Wert");
                                    Console.ReadLine();
                                }

                            }
                            //Bei ungültiger Eingabe aus Szene 4
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                Console.ReadLine();
                            }
                        }
                        //Bei ungültiger Eingabe aus Szene 3
                        else
                        {
                            Console.WriteLine("Ungültiger Wert");
                            Console.ReadLine();
                        }

                    }
                    //Bei ungültige Eingabe aus Szene 2
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadLine();
                    }
                    Console.ReadKey();
                }
                //Bei ungültige Eingabe aus Szene 1
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                    Console.ReadLine();
                }
            }
            else
            {
                //Falsche Eingabe. Überprüfung kann nicht gestartet werden.
                Console.WriteLine("Es wurde eine falsche Eingabe und zwar " + starteingabe + " eingegeben. Die Überprüfung muss neu gestartet werden.");
                Console.ReadLine();
            }


          
        }
    }
}
