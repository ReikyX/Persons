namespace Personen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe();
            //Korrektur1();
            Korrektur2();
        }


        /*
        //Erstelle ein Programm in dem ein User seinen Namen angeben kann
        //Erstelle zudem eine Klasse Person mit den Feldern Name Alter und Beruf
        //Die Klasse hat zudem auch zwei Methoden, einmal die Methode <Begruessung> die den User mit seinem Namen begrüsst und sich selbst vorstellt.
        //Die zweite Methode heißt <Infos> und gibt im Format Name: ... Alter: ... Beruf: ... die Informationen über das Jeweilige Objekt aus (Person)
        //Erstelle aus der Klasse Person zwei Objekte und befühle die Felder.
        //Erstelle dann ein Menü wo man auf jedes Objekt zugreifen kann und die Metoden von diesen Objekten ausführen kann.
        */

        /*
        static void Aufgabe()
        {
            bool wiederholen = true;

            Console.WriteLine("Willkommen zur Personalregistrierung.\n");
            Console.Write("Gebe bitte deinen Namen ein:\t");
            string name = Console.ReadLine();
            Console.Write("Gebe bitte dein Beruf an:\t");
            string beruf = Console.ReadLine();
            Console.Write("Gebe bitte dein Alter an:\t");
            int alter = Convert.ToInt32(Console.ReadLine());


            Person user = new Person(name, alter, beruf);
            Person person1 = new Person("Bernd", 33, "IT");
            Person person2 = new Person("Lara", 25, "Austronautin");

            


            while (wiederholen)
            {

                Console.Clear();
                Console.WriteLine("Menü :\n\n-> Begruessung <-\n\n-> Vorstellung <-\n\n-> Beenden <-");
                string eingabe = Console.ReadLine().ToLower().Trim();
                if (eingabe == "begruessung")
                {
                    Console.Clear();
                    person1.Begruessung(name);
                    Console.WriteLine("\n\n\n\n\nDrücke eine beliebige Taste zum fortfahren.");
                    Console.ReadKey();
                }
                else if (eingabe == "vorstellung")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\n\n\n\n\nDrücke eine beliebige Taste zum fortfahren.");
                    Console.ReadKey();
                }
                else if (eingabe == "beenden")
                {
                    Console.Clear();
                    wiederholen = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Das Programm wird beendet.");
                    Thread.Sleep(5000);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    Thread.Sleep(5000);
                }

            }
        }
        */

        /*
        static void Korrektur1()
        {
            //Erstelle ein Programm in dem ein User seinen Namen angeben kann
            //Erstelle zudem eine Klasse Person mit den Feldern Name Alter und Beruf
            //Die Klasse hat zudem auch zwei Methoden, einmal die Methode <Begruessung> die den User mit seinem Namen begrüsst und sich selbst vorstellt.
            //Die zweite Methode heißt <Infos> und gibt im Format Name: ... Alter: ... Beruf: ... die Informationen über das Jeweilige Objekt aus (Person)
            //Erstelle aus der Klasse Person zwei Objekte und befühle die Felder.
            //Erstelle dann ein Menü wo man auf jedes Objekt zugreifen kann und die Metoden von diesen Objekten ausführen kann.

            Console.Write("Hallo User! bitte gib deinen Namen ein: ");
            string userName = Console.ReadLine();

            Person person1 = new Person("Maria", 31, "Metzger");
            Person person2 = new Person("Reiner", 40, "Programmierer");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Wähle eine Person aus (1 - 2):\n\n1.{person1.name}\n2.{person2.name}");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Soll die person dich begrüßen oder sollen ihre Infos ausgegeben werden (1 - 2):\n1.Begrüßung\n2.Infos");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        person1.Begruessung(userName);
                        Console.ReadKey();
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        person1.Info();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe ist Fehlerhaft!");
                        Console.ReadKey();
                    }

                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Soll die person dich begrüßen oder sollen ihre Infos ausgegeben werden (1 - 2):\n1.Begrüßung\n2.Infos");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        person2.Begruessung(userName);
                        Console.ReadKey();
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        person2.Info();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe ist Fehlerhaft!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Deine Eingabe war nicht korrekt!");
                    Console.ReadKey();
                    Console.Clear();
                }




            }
        }
        */
        static void Korrektur2()
        {
            //Erstelle ein Programm in dem ein User seinen Namen angeben kann
            //Erstelle zudem eine Klasse Person mit den Feldern Name Alter und Beruf
            //Die Klasse hat zudem auch zwei Methoden, einmal die Methode <Begruessung> die den User mit seinem Namen begrüsst und sich selbst vorstellt.
            //Die zweite Methode heißt <Infos> und gibt im Format Name: ... Alter: ... Beruf: ... die Informationen über das Jeweilige Objekt aus (Person)
            //Erstelle aus der Klasse Person zwei Objekte und befühle die Felder.
            //Erstelle dann ein Menü wo man auf jedes Objekt zugreifen kann und die Metoden von diesen Objekten ausführen kann.

            Console.Write("Hallo User! bitte gib deinen Namen ein: ");
            string userName = Console.ReadLine();

            Person person1 = new Person("Maria", 31, "Metzger");
            Person person2 = new Person("Reiner", 40, "Programmierer");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Wähle eine Person aus (1 - 2):\n\n1.{person1.name}\n2.{person2.name}");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Menu(person1, userName);
                }
                else if (input == "2")
                {
                    Menu(person2, userName);
                }
                else
                {
                    Console.WriteLine("Deine Eingabe war nicht korrekt!");
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }
        public static void Menu(Person person, string userName)
        {
            Console.Clear();
            Console.WriteLine("Soll die person dich begrüßen oder sollen ihre Infos ausgegeben werden (1 - 2):\n1.Begrüßung\n2.Infos");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                person.Begruessung(userName);
                Console.ReadKey();
            }
            else if (input == "2")
            {
                Console.Clear();
                person.Info();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Deine Eingabe ist Fehlerhaft!");
                Console.ReadKey();
            }
        }
    }
}
