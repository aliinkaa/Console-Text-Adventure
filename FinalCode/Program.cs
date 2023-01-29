using System;

namespace FinalCode
{
    class Program
    {
        //231 x 66

        static Player player1;
        static bool playedOnce;
        static void Main(string[] args)
        {

            Greeting();
            CharacterSelection();
            FirstScene();
        }

        //done!
        public static void Greeting()
        {
            SetWinSize(185, 25);
            ForeColorsetter(ConsoleColor.DarkRed);
            Console.WriteLine(

 "\n\t\t\t\t" + " _       _________ _______          _________     _______  _                 ______       _______  _______  _______" + "\n\t\t\t\t" +
"( (    /|\\__   __/(  ____ \\|\\     /|\\__   __/    (  ____ \\( \\      |\\     /|(  ___ \\     (  ____ )(  ____ )(  ____ \\" + "\n\t\t\t\t" +
"|  \\  ( |   ) (   | (    \\/| )   ( |   ) (       | (    \\/| (      | )   ( || (   ) )    | (    )|| (    )|| (    \\/" + "\n\t\t\t\t" +
"|   \\ | |   | |   | |      | (___) |   | |       | |      | |      | |   | || (__/ /     | (____)|| (____)|| |" + "\n\t\t\t\t" +
"| (\\ \\) |   | |   | | ____ |  ___  |   | |       | |      | |      | |   | ||  __ (      |     __)|  _____)| | ____" + "\n\t\t\t\t" +
"| | \\   |   | |   | | \\_  )| (   ) |   | |       | |      | |      | |   | || (  \\ \\     | (\\ (   | (      | | \\_  )" + "\n\t\t\t\t" +
"| )  \\  |___) (___| (___) || )   ( |   | |       | (____/\\| (____/\\| (___) || )___) )    | ) \\ \\__| )      | (___) |" + "\n\t\t\t\t" +
"|/    )_)\\_______/(_______)|/     \\|   )_(       (_______/(_______/(_______)|/ \\___/     |/   \\__/|/       (_______)"
                                                                                                                      );

            Console.WriteLine("\n\n\n\t\tThis story takes place in a time when consumerism’s tight grasp on our necks finally snapped it from its core. This story takes place in a city that reeks crime\n" +
                              "\tand injustice. In this story, you are not a person but a statistic, one of many in a well-constructed Excel table.\n\n" +
                              "\t\tYou haven’t even seen your boss personally in your entire life but they found you, provide you education, training, discipline and equipment.\n");
            
            PressToContOut();
        }

        //done!
        public static void CharacterSelection()
        {
            AllColorSetter(ConsoleColor.DarkMagenta, ConsoleColor.Black);

            //initiates consequent loops.
            if (playedOnce)
                TryOthers();

            Console.WriteLine("\n\n" +
"\t\t\t ▄████████    ▄█    █▄       ▄████████    ▄████████    ▄████████  ▄████████     ███        ▄████████    ▄████████    ▄████████" + "\n" +
"\t\t\t███    ███   ███    ███     ███    ███   ███    ███   ███    ███ ███    ███ ▀█████████▄   ███    ███   ███    ███   ███    ███" + "\n" +
"\t\t\t███    █▀    ███    ███     ███    ███   ███    ███   ███    ███ ███    █▀     ▀███▀▀██   ███    █▀    ███    ███   ███    █▀ " + "\n" +
"\t\t\t███         ▄███▄▄▄▄███▄▄   ███    ███  ▄███▄▄▄▄██▀   ███    ███ ███            ███   ▀  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███       " + "\n" +
"\t\t\t███        ▀▀███▀▀▀▀███▀  ▀███████████ ▀▀███▀▀▀▀▀   ▀███████████ ███            ███     ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████" + "\n" +
"\t\t\t███    █▄    ███    ███     ███    ███ ▀███████████   ███    ███ ███    █▄      ███       ███    █▄  ▀███████████          ███" + "\n" +
"\t\t\t███    ███   ███    ███     ███    ███   ███    ███   ███    ███ ███    ███     ███       ███    ███   ███    ███    ▄█    ███" + "\n" +
"\t\t\t████████▀    ███    █▀      ███    █▀    ███    ███   ███    █▀  ████████▀     ▄████▀     ██████████   ███    ███  ▄████████▀ ");


            Console.Write("\n\n\n\t\tToday, in theory, should not be any different than the others. However young you may be, you are one of the best in business so, once again\n" +
                               "\tyou have a job to do, time and location is set, and you are ready.");
            ColoredString(ConsoleColor.Red, " Your mission is to install a malware to Club Giraffe’s main computer through a device provided for you.\n");
            Console.WriteLine("\n\t\tIf you get caught, and somehow not dead, no one will hunt you down but instead all of your network, bank accounts, ways of communication and belongings will\n" +
            "\tbe annihilated regarding the procedure for failure. Now, with all of that, again, procedural information out of the way it’s time to choose your skill set. Inspect\n" +
            "\tcarefully, they will determine how you are going to approach certain situations.");

            ForeColorsetter(ConsoleColor.Red);
            PressToContOut();
            ForeColorsetter(ConsoleColor.Black);
            SetWinSize(178, 30);

            Console.WriteLine("\n\n" +
"\t\t\t ▄████████    ▄█    █▄       ▄████████    ▄████████    ▄████████  ▄████████     ███        ▄████████    ▄████████    ▄████████" + "\n" +
"\t\t\t███    ███   ███    ███     ███    ███   ███    ███   ███    ███ ███    ███ ▀█████████▄   ███    ███   ███    ███   ███    ███" + "\n" +
"\t\t\t███    █▀    ███    ███     ███    ███   ███    ███   ███    ███ ███    █▀     ▀███▀▀██   ███    █▀    ███    ███   ███    █▀ " + "\n" +
"\t\t\t███         ▄███▄▄▄▄███▄▄   ███    ███  ▄███▄▄▄▄██▀   ███    ███ ███            ███   ▀  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███       " + "\n" +
"\t\t\t███        ▀▀███▀▀▀▀███▀  ▀███████████ ▀▀███▀▀▀▀▀   ▀███████████ ███            ███     ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████" + "\n" +
"\t\t\t███    █▄    ███    ███     ███    ███ ▀███████████   ███    ███ ███    █▄      ███       ███    █▄  ▀███████████          ███" + "\n" +
"\t\t\t███    ███   ███    ███     ███    ███   ███    ███   ███    ███ ███    ███     ███       ███    ███   ███    ███    ▄█    ███" + "\n" +
"\t\t\t████████▀    ███    █▀      ███    █▀    ███    ███   ███    █▀  ████████▀     ▄████▀     ██████████   ███    ███  ▄████████▀ ");

            ColoredString(ConsoleColor.Red, "\n\n\t\t\t\t\t[Pick a character to play with! For selection press the button that is the number correpsondand.]\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t[Character 1 : \"Mr. Robot\"]\t[Character 2 : \"Alice Wakefield\"]\t[Character 3 : \"The Bride\"]\n\n" + "\t\t\t\t-Quick hacking.\t\t\t-Seduction.\t\t\t\t-Taijutsu.\n" +
                "\t\t\t\t-Lock-picking.\t\t\t-Lie detection.\t\t\t\t-Stealth.\n" + "\t\t\t\t-Blend in with the crowd.\t-Sharp vision.\t\t\t\t-Intimidation.\n\n");

            //modified a bit.
            switch(UserOutput())
            {
                case ConsoleKey.D1:
                    player1 = new Player(1); //picked Mr. Robot
                    break;
                case ConsoleKey.D2:
                    player1 = new Player(2); //picked Alice W.
                    break;
                case ConsoleKey.D3:
                    player1 = new Player(3); //picked The Bride
                    break;
                default:
                    {
                        bool wrongAnswer = true;
                        ConsoleKey input;

                        do
                        {
                            input = UserOutput();

                            if (input == ConsoleKey.D1 || input == ConsoleKey.D2 || input == ConsoleKey.D3)
                            {
                                wrongAnswer = false;

                                if(input == ConsoleKey.D1)
                                    goto case ConsoleKey.D1;
                                else if(input == ConsoleKey.D2)
                                    goto case ConsoleKey.D2;
                                else if(input == ConsoleKey.D3)
                                    goto case ConsoleKey.D3;
                            }

                        } while (wrongAnswer);
                    }
                    break;
            }    

            ForeColorsetter(ConsoleColor.Red);
            Console.WriteLine("\n\t\t\t\t\t\tNonetheless, no matter how insignificant one may be, everyone has a name. What’s yours?");
            player1.Name = Console.ReadLine();
            SetWinSize(178, 35);
            Console.Write("\n\t\t\t\t\t\t\tThank you for your time. May the fire walk with you ");
            ForeColorsetter(ConsoleColor.Black);
            Console.Write($"{player1.Name}.\n");
            //specifically re-used this code cuz symmetry issues...
            Console.WriteLine("\n\t\t\t\t\t\t\t... ... .  ..Press any button to continue. . .. .   .");
            Console.ReadKey();
            Console.Clear();

            //strenghtens the loop.
            if (playedOnce)
                FirstScene();
        }

        public static void TryOthers()
        {
            AllColorSetter(ConsoleColor.DarkMagenta, ConsoleColor.Black);
            SetWinSize(160, 22);
            Console.WriteLine("\n\n" +
"\t\t    ███        ▄████████ ▄██   ▄              ▄██████▄      ███        ▄█    █▄       ▄████████    ▄████████    ▄████████\n" +
"\t\t▀█████████▄   ███    ███ ███   ██▄           ███    ███ ▀█████████▄   ███    ███     ███    ███   ███    ███   ███    ███\n" +
"\t\t   ▀███▀▀██   ███    ███ ███▄▄▄███           ███    ███    ▀███▀▀██   ███    ███     ███    █▀    ███    ███   ███    █▀ \n" +
"\t\t    ███   ▀  ▄███▄▄▄▄██▀ ▀▀▀▀▀▀███           ███    ███     ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███       \n" +
"\t\t    ███     ▀▀███▀▀▀▀▀   ▄██   ███           ███    ███     ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████\n" +
"\t\t    ███     ▀███████████ ███   ███           ███    ███     ███       ███    ███     ███    █▄  ▀███████████          ███\n" +
"\t\t    ███       ███    ███ ███   ███           ███    ███     ███       ███    ███     ███    ███   ███    ███    ▄█    ███\n" +
"\t\t   ▄████▀     ███    ███  ▀█████▀             ▀██████▀     ▄████▀     ███    █▀      ██████████   ███    ███  ▄████████▀ \n" +
"\t\t              ███    ███                                                                          ███    ███             \n");


            ColoredString(ConsoleColor.Red, "\t\t\t[This is not the end, there's more to unveil and see- try different options with different skill sets!]\n\n\t");
            PressToContOut();
            Console.Clear();
            SetWinSize(185, 25);
        }

        //done... I guess?
        public static void FirstScene()
        {
            SetWinSize(Console.LargestWindowWidth/2, Console.LargestWindowHeight);
            AllColorSetter(ConsoleColor.Black, ConsoleColor.DarkRed);
       
            //If booths part has been failed then player must return here and have the option of the dance floor only.
            if (!player1.BoothsFail)
            {

                Console.WriteLine("\n\n\t\tIn the midst of a pile of shit, the building of Club Giraffe is rising and\n" +
                "\tit looks like a gleaming statue. Paramount and glamorous, the club is very popular\n" +
                "\tamongst the rich and vapid. You are approaching the queue for the ones that\n" +
                "\thave VIP tickets, so you won’t have to wait too long. You can observe the overly\n" +
                "\texcited teenagers, the ones who are already wasted or high, and dope peddlers.\n\n\n\n");

                ColoredString(ConsoleColor.DarkBlue,
                                    "\t\t                             ^                                     \n" +
                                    "\t\t                _______     ^^^                                    \n" +
                                    "\t\t               |xxxxxxx|  _^^^^^_                                  \n" +
                                    "\t\t               |xxxxxxx| | [][]  |                                 \n" +
                                    "\t\t            ______xxxxx| |[][][] |                                 \n" +
                                    "\t\t           |++++++|xxxx| | [][][]|                                 \n" +
                                    "\t\t           |++++++|xxxx| |[][][] |                                 \n" +
                                    "\t\t           |++++++|_________ [][]|                                 \n" +
                                    "\t\t           |++++++|=|=|=|=|=| [] |                                 \n" +
                                    "\t\t           |++++++|=|=|=|=|=|[][]|                                 \n" +
                                    "\t\t___________|++HH++|  _HHHH__|   _________   _________  _________   \n" +
                                    "\t\t         _______________   ______________      ______________      \n" +
                                    "\t\t__________________  ___________    __________________    ____________ \n");

                PressToContColored(ConsoleColor.Red);

            }

            Console.Clear();
            //SetWinSize(100, 12);

            Console.WriteLine("\n\n\t\tYou got inside the elevator without any trouble and reached the main\n" +
                              "\tfloor. There is an Industrial tune filling the atmosphere, you guess it’s Godhead. You\n" +
                              "\tnotice a huge bar with a seemingly zippy bartender attending to it. Other than\n" +
                              "\tthat, the dance floor is incredibly lively, after all it’s the most active hours of the\n" +
                              "\tclub. What are you going to do?\n"); 

            ColoredString(ConsoleColor.Red, "\n\n" +
            "\t\t\t\t .======================================. \n" +
            "\t\t\t\t |                                      | \n" +
            "\t\t\t\t | |_| |_| \\_/ C|||C|||C||| |-| |-| |-| | \n" +
            "\t\t\t\t | _|_ _|_ _|_  ||| ||| ||| |_| |_| |_| | \n" +
            "\t\t\t\t '======================================. \n\n" +

           " \t\t\t\t      .:.                               \n" +
            "\t\t\t\t     C|||'                              \n" +
            "\t\t\t\t   ___|||______________________________ \n" +
            "\t\t\t\t  [____________________________________] \n" +
            "\t\t\t\t  |   ____    ____    ____    ____     | \n" +
            "\t\t\t\t  |  (____)  (____)  (____)  (____)    | \n " +
            "\t\t\t\t  |  |    |  |    |  |    |  |    |    | \n" +
            "\t\t\t\t  |  |    |  |    |  |    |  |    |    | \n" +
            "\t\t\t\t  |  |    |  |    |  |    |  |    |    | \n" +
            "\t\t\t\t  |  |____|  |____|  |____|  |____|    | \n" +
            "\t\t\t\t  |  I====I  I====I  I====I  I====I    | \n" +
            "\t\t\t\t  |  |    |  |    |  |    |  |    |    | \n\n\n");

            Console.WriteLine("\t" + "1. Go to the bar" + "\n" + "\t" + "2. Go to the dance floor" + "\n");

            switch (UserOutput())
            {
                case ConsoleKey.D1:
                    TheBar();
                    break;
                case ConsoleKey.D2:
                    TheDanceFloor();
                    break;
            }

        }

        //now it is clean... kinda... not sure... ._.
        public static void TheBar()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Cyan);
            

            if(!player1.BeenToBar)
            {
                Console.WriteLine("\n\n\tFrom conventional bourbon fanatics to ones that are keen on trying out new\n" +
                                  "\tcocktails, the bar is completely stuffed. Luckily, you managed to find yourself a\n" +
                                  "\tspot. Now you can look closely at the bartender. He is a black gentleman in his\n" +
                                  "\t20’s with long braided hair, wearing baggy clothes. He has an English accent and\n" +
                                  "\tby the look of it you can say that he knows his business. He turns to you and\n" +
                                  "\tasks, ");
                ColoredString(ConsoleColor.Yellow, "\t“Welcome to the Giraffe, what can I get you?”");
                Console.WriteLine(" and he smiles.\n\n" + "\t1. Vodka.\n" +
                                                          "\t2. White Negroni.\n" +
                                                          "\t3. I don’t know, you choose.\n");

                ColoredString(ConsoleColor.Yellow, "\n\n" +
            "\t\t                            (            \n " +
            "\t\t *                           )   *       \n" +
            "\t\t             )     *        (            \n" +
            "\t\t     )        (                   (      \n" +
            "\t\t    (        )     (               )     \n" +
            "\t\t     )    *         )        )    (      \n" +
            "\t\t    (              (        (     *      \n" +
            "\t\t     )          H   )        )           \n" +
            "\t\t               [ ]          (            \n" +
            "\t\t       (  *    |-|       *   )    (      \n" +
            "\t\t *      )      |_|      .          )     \n" +
            "\t\t       (       | |    .                  \n" +
            "\t\t             (-----)      .    ' .  *    \n" +
            "\t\t  (          |_____|  '  .    .          \n" +
            "\t\t   )         | ___ |  \\~~~/  ' .     (  \n" +
            "\t\t         *   | . . |   \\_/    \\~~~/  ) \n" +
            "\t\t             | _Y_ |    |      \\_/   (  \n" +
            "\t\t *           |-----|  __|__     |     *  \n" +
            "\t\t             `-----`          __|__      \n\n");

                switch (UserOutput())
                {
                    case ConsoleKey.D1:
                        ColoredString(ConsoleColor.Yellow, "\t\t- Never gets old right?\n");
                        break;
                    case ConsoleKey.D2:
                        ColoredString(ConsoleColor.Yellow, "\t\t- Damn are-we-adventurous!\n");
                        break;
                    case ConsoleKey.D3:
                        {
                            ColoredString(ConsoleColor.Yellow, "\t\t- Suit yourself for a classic then ");
                            ColoredString(ConsoleColor.Green, "*makes a Mojito *\n");
                        }
                        break;
                }

                Console.WriteLine("\n\tIt is not very wise to drink on duty, but you took some liberty to do it, since the\n" +
                                    "\tmission takes place in a nightclub.\n");

                PressToContColored(ConsoleColor.Yellow);
                player1.BeenToBar = true;
            }

            Console.WriteLine("\n\n\tWhile having your drink, other people’s chattering reaches to your ears. A\n" +
                                  "\tcouple of, presumably, freshmen are talking about the creeps among the crowd\n" +
                                  "\ton this floor and they are considering going upstairs. You also notice how the\n" +
                                  "\tbartender is looking exhausting right now, after non-stop serving for minutes.\n");

            ColoredString(ConsoleColor.Yellow, "\n\n" +
            "\t\t                            (            \n " +
            "\t\t *                           )   *       \n" +
            "\t\t             )     *        (            \n" +
            "\t\t     )        (                   (      \n" +
            "\t\t    (        )     (               )     \n" +
            "\t\t     )    *         )        )    (      \n" +
            "\t\t    (              (        (     *      \n" +
            "\t\t     )          H   )        )           \n" +
            "\t\t               [ ]          (            \n" +
            "\t\t       (  *    |-|       *   )    (      \n" +
            "\t\t *      )      |_|      .          )     \n" +
            "\t\t       (       | |    .                  \n" +
            "\t\t             (-----)      .    ' .  *    \n" +
            "\t\t  (          |_____|  '  .    .          \n" +
            "\t\t   )         | ___ |  \\~~~/  ' .     (  \n" +
            "\t\t         *   | . . |   \\_/    \\~~~/  ) \n" +
            "\t\t             | _Y_ |    |      \\_/   (  \n" +
            "\t\t *           |-----|  __|__     |     *  \n" +
            "\t\t             `-----`          __|__      \n\n");

            string option1 = "1. Jump to the conversation of the freshmen";
            string option2 = "2. Check in with the bartender";
            string option3 = "3. Hack the security cameras with your mobile [Quick Hacking]";

            //this part needs checking.
            if ((!player1.LaurenceConversed && !player1.FreshmenConversed) && (player1.FailCount == 0) && player1.getSelectedChar().containsSkill(Skills.QuickHacking)) //case 1 : clean + robot (and to none have been talked to before)
            {
                Console.WriteLine("\t\t" + option1 + "\n" + "\t\t" + option2 + "\n" + "\t\t" + option3 + "\n");

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        Freshmen();
                        break;
                    case ConsoleKey.D2:
                        Bartender();
                        break;
                    case ConsoleKey.D3:
                        HackFromBar();
                        break;
                }
            }
            else if (((player1.FailCount == 1) || player1.FreshmenConversed || player1.LaurenceConversed) && player1.getSelectedChar().containsSkill(Skills.QuickHacking)) //case 1.1 half-clean + robot (or either of them have been talked to)
            {
                if(player1.FreshmenFail || player1.FreshmenConversed) //no freshmen.
                {
                    Console.WriteLine("\t\t1" + option2.Substring(1) + "\n\t\t2" + option3.Substring(1) + "\n");

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            Bartender();
                            break;
                        case ConsoleKey.D2:
                            HackFromBar();
                            break;
                    }
                }
                else if (player1.BartenderFail || player1.LaurenceConversed) //player1.bartenderFail = true; no bartender.(or have been conversed to already)
                {
                    Console.WriteLine("\t\t1" + option1.Substring(1) + "\n\t\t2" + option3.Substring(1) + "\n");

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            Freshmen();
                            break;
                        case ConsoleKey.D2:
                            HackFromBar();
                            break;
                    }
                }
            }
            else if((!player1.LaurenceConversed && !player1.FreshmenConversed) && (player1.FailCount == 0) && player1.ReturnToBar) //case 2 : clean + returnToBar(and to none have you talked to)
            {
                Console.WriteLine("\t\t" + option1 + "\n" + "\t\t" + option2 + "\n");

                switch (UserOutput())
                {
                    case ConsoleKey.D1:
                        Freshmen();
                        break;
                    case ConsoleKey.D2:
                        Bartender();
                        break;
                }
            }
            else if(((player1.FailCount == 1) || player1.FreshmenConversed || player1.LaurenceConversed) && player1.ReturnToBar) //case 2.1 : half-clean + returnToBar (or either of them have been conversed to)
            {
                if (player1.FreshmenFail || player1.FreshmenConversed) //no freshmen.
                {
                    Console.WriteLine("\t\t1" + option2.Substring(1) + "\n");

                    if (UserOutput() == ConsoleKey.D1)
                        Bartender();

                    /*switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            Bartender();
                            break;
                    }*/
                }
                else if (player1.BartenderFail || player1.LaurenceConversed) //player1.bartenderFail = true; no bartender.(or already have been talked to)
                {
                    Console.WriteLine("\t\t1" + option1.Substring(1) + "\n");

                    if (UserOutput() == ConsoleKey.D1)
                        Freshmen();
                    /*switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            Freshmen();
                            break;
                    }*/
                }
            }
            else if((!player1.LaurenceConversed && !player1.FreshmenConversed) && (player1.FailCount == 0) && !player1.getSelectedChar().containsSkill(Skills.QuickHacking)) //case 3 : clean + non-robot(and never talked to)
            {
                Console.Write("\t\t" + option1 + "\n" + "\t\t" + option2 + "\n");
                ColoredString(ConsoleColor.Red, "\t\t" + option3 + "\n\n");

                switch (UserOutput())
                {
                    case ConsoleKey.D1:
                        Freshmen();
                        break;
                    case ConsoleKey.D2:
                        Bartender();
                        break;
                    case ConsoleKey.D3:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if( (input == ConsoleKey.D1) || (input == ConsoleKey.D2))
                                {
                                    wrongAnswer = false;

                                    if (input == ConsoleKey.D1)
                                        goto case ConsoleKey.D1;
                                    else
                                        goto case ConsoleKey.D2;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                }
            } 
            else if(((player1.FailCount == 1) || player1.FreshmenConversed || player1.LaurenceConversed) && !player1.getSelectedChar().containsSkill(Skills.QuickHacking)) //case 3.1 = half-clean + non-robot(or either of them have been talked to)
            {
                if (player1.FreshmenFail || player1.FreshmenConversed) //no freshmen.
                {
                    Console.WriteLine("\t\t1" + option2.Substring(1) + "\n");
                    ColoredString(ConsoleColor.Red, "\t\t" + option3 + "\n\n");

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            Bartender();
                            break;
                        case ConsoleKey.D2:
                            {
                                //wrongAnswer is not necessary but just in case.
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if (input == ConsoleKey.D1)
                                    {
                                        wrongAnswer = false;
                                        goto case ConsoleKey.D1;
                                    }
                                } while (wrongAnswer);
                            }
                            break;
                    }
                }
                else if(player1.LaurenceConversed || player1.BartenderFail) //means that player1.bartenderFail == true; no bartender(or already have talked to)
                {
                    Console.WriteLine("\t\t1" + option1.Substring(1) + "\n");
                    ColoredString(ConsoleColor.Red, "\t\t2" + option3.Substring(1) + "\n\n");

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            Freshmen();
                            break;
                        case ConsoleKey.D2:
                            {
                                //wrongAnswer is not necessary but just in case.
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if (input == ConsoleKey.D1)
                                    {
                                        wrongAnswer = false;
                                        goto case ConsoleKey.D1;
                                    }
                                } while (wrongAnswer);
                            }
                            break;
                    }
                }
            }
        }

        //done... I guess?
        public static void HackFromBar()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Cyan);

            Console.WriteLine("\n\n\tIt took some time but you managed to hack the camera system. As\t\n" +
                              "\tyou surf around the camera views and observe the club more, you\n" +
                              "\tsee what’s going on upstairs and in the booths section. It is like a \n" +
                              "\thouse party upstairs, average age at 18-19, many college people are \n" +
                              "\thaving fun. At the booths, you see a dancer, having an argument \n" +
                              "\twith a security guard. However, there are still some cameras that\n" +
                              "\tare unavailable for your access, you better check the main servers \n" +
                              "\tto see more details regarding upstairs.\n");

            string option1 = "1. Go to the booths";
            string option2 = "2. Go to server room";
            string option3 = "3. Stay at the bar";

            if (!player1.BoothsFail) //if the player prior to this fails the booths option1 should be blocked.
            {

                Console.WriteLine("\t\t" + option1 + "\n" + "\t\t" + option2 + "\n" + "\t\t" + option3 + "\n");

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        Booths();
                        break;
                    case ConsoleKey.D2:
                        {
                            Console.Clear();

                            Console.WriteLine("\n\n\t\tFrom the camera view, you located a server room around the\n" +
                                              "\t\tcorner and made your way there.\n");

                            Console.WriteLine("\t\t1. Go inside the server room [Lock-picking]\n" + "\t\t2. Deal with the security-cams [Quick hacking]\n");

                            switch(UserOutput())
                            {
                                case ConsoleKey.D1:
                                    ImmGO();
                                    break;
                                case ConsoleKey.D2:
                                    {
                                        Console.WriteLine("\tBefore going inside the server room, you\n" +
                                                          "\tremembered that you first have to deal \n" +
                                                          "\twith the cameras. You leaned onto some\n" +
                                                          "\twall to blend in with the darkness of the\n" +
                                                          "\tclub, and from your mobile, you hack into\n" +
                                                          "\tthe system to disable the camera that\n" +
                                                          "\toverlooks the server room.\n");

                                        Console.WriteLine("\t\t1. Now go inside the server room.[Lock-picking]");

                                        if(UserOutput() == ConsoleKey.D1)
                                            Console.WriteLine("\tYou picked the lock and got inside of the server room.\n\n");

                                        PressToContColored(ConsoleColor.Yellow);
                                        ServerRoom();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            player1.ReturnToBar = true;
                            TheBar();
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine("\t\t1" + option2.Substring(1) + "\n" + "\t\t2" + option3.Substring(1) + "\n");

                switch (UserOutput())
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();

                            Console.WriteLine("\t\tFrom the camera view, you located a server room around the\n" +
                                              "\tcorner and made your way there.\n");

                            Console.WriteLine("\t\t1. Go inside the server room [Lock-picking]\n" + "\t\t2. Deal with the security-cams [Quick hacking]\n");

                            switch (UserOutput())
                            {
                                case ConsoleKey.D1:
                                    ImmGO();
                                    break;
                                case ConsoleKey.D2:
                                    {
                                        Console.WriteLine("\tBefore going inside the server room, you\n" +
                                                          "\tremembered that you first have to deal \n" +
                                                          "\twith the cameras. You leaned onto some\n" +
                                                          "\twall to blend in with the darkness of the\n" +
                                                          "\tclub, and from your mobile, you hack into\n" +
                                                          "\tthe system to disable the camera that\n" +
                                                          "\toverlooks the server room.\n");

                                        Console.WriteLine("\t\t1. Now go inside the server room.[Lock-picking]");
                                        Console.WriteLine("\tYou picked the lock and got inside of the server room.\n\n");

                                        PressToContColored(ConsoleColor.Yellow);
                                        ServerRoom();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            player1.ReturnToBar = true;
                            TheBar();
                        }
                        break;

                }
            }

        }

        //done... I guess?
        public static void Bartender()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Cyan);

            player1.LaurenceConversed = true;

            ColoredString(ConsoleColor.Yellow, "\n\n\t“It’s like a fucking vortex I tell you man, once you get in, there is no way out of\n" +
                              "\tthis life.”");
            Console.WriteLine(" The bartender, while laying on the counter is talking with a customer\n" +
                              "\t-or maybe a friend-. What will you say to him?\n");

            string option1 = "1. Perhaps that’s the excitement of it, don’t you think? [Seduction]";
            string option2 = "2. So, what's the catch of getting in, if you can’t get out?";

            //if character has seduction, things go more different...
            if (player1.getSelectedChar().containsSkill(Skills.Seduction))
            {
                //for Alice-like players.
                if(!player1.BoothsFail) //booths options are available
                {
                    Console.WriteLine("\t\t" + option1 + "\n" + "\t\t" + option2 + "\n");

                    switch(UserOutput())
                    {
                        case ConsoleKey.D1: //seduction --> booths
                            {
                                ColoredString(ConsoleColor.Yellow, "\tHah, there is certainly excitement in this biz, but only when beauties\n" +
                                                                   "\tlike you approach me.\n\n");

                                Console.WriteLine("\t\t1.So you find me beautiful ? *you lay onto the counter to get close *\n");

                                if(UserOutput() == ConsoleKey.D1)
                                {
                                    ColoredString(ConsoleColor.Yellow, "\tI’d be a stupid if I wouldn’t, ");
                                    Console.Write("*turns to one of his friends and says*");
                                    ColoredString(ConsoleColor.Yellow, " hey,\n" +
                                                                       "\tfor a couple of mins… would u? Ok, great bro appreciated. ");
                                    Console.Write("*turns to you*");
                                    ColoredString(ConsoleColor.Yellow, ", Hey,\n" +
                                                                       "\tI know a place where we can keep talking… in private.\n\n");

                                    Console.WriteLine("\t\t1. Hahah, lead on sir!\n");

                                    if(UserOutput() == ConsoleKey.D1)
                                    {
                                        AllColorSetter(ConsoleColor.Red, ConsoleColor.Black);

                                        Console.WriteLine("\tHe brought you to one of the private booths. Without a\n" +
                                                          "\tneed to talk, your energies matched each other perfectly\n" +
                                                          "\tand you started to kiss him, meanwhile looking from\n" +
                                                          "\tthe door gap, you saw an argument between a security guard\n" +
                                                          "\tand one of the dancers.\n");

                                        Console.WriteLine("\t\t1. Mm, I’d want to go further but I think we should stop\n" +
                                                          "\t\tthere. Thanks for fun.\n");

                                        if(UserOutput() == ConsoleKey.D1)
                                        {
                                            ColoredString(ConsoleColor.Magenta, "\tI agree. Hey, call me ");
                                            Console.WriteLine("*gives you his number*\n\n");

                                            PressToContColored(ConsoleColor.Magenta);

                                            Booths();
                                        }
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.D2: //gossip
                            {
                                SoWhatsTheCatch();
                            }
                            break;
                    }
                }
                else //booths options are disabled, not even visable.
                {
                    Console.WriteLine("\t\t1. " + option2.Substring(1) + "\n");

                    if (UserOutput() == ConsoleKey.D1)
                        SoWhatsTheCatch();
                }
            }
            else //either Robot or Bride.
            {
                ColoredString(ConsoleColor.Red, "\t\t" + option1 + "\n");
                Console.WriteLine("\t\t" + option2);

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D2)
                                {
                                    wrongAnswer = false;

                                    goto case ConsoleKey.D2;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                    case ConsoleKey.D2:
                            SoWhatsTheCatch();
                        break;
                }
            }
        }

        //done... I guess?
        public static void SoWhatsTheCatch()
        {
            //second phase of the bartender
            Console.WriteLine("\tShit fam, is that s’posed to be funny?\n");

            string option2_1 = "1. Just trying to be friendly but hey, fuck you fam."; //(failure)
            string option2_2 = "2. Hey, just trying to start a conversation here."; //(booths or 3d floor)
            string option2_3 = "3.  I wouldn’t be that rude next time. [Intimidation]"; //(booths)

            if(player1.getSelectedChar().containsSkill(Skills.Intimidation)) //so basically if our chracter type is the Bride
            {
                if(!player1.BoothsFail) //if booths are available
                {
                    //all options, second option includes a booths branch

                    Console.WriteLine("\t\t" + option2_1 + "\n\t\t" + option2_2 + "\n\t\t" + option2_3);

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            BartenderFailFrame();
                            break;
                        case ConsoleKey.D2:                           
                            BartenderGossipBooths(!player1.BoothsFail); //this will be same with the mr. robot's version- neutral booths yes seduction-based no. (!player1.. because if player1.BoothsFail == true then )                         
                            break;
                        case ConsoleKey.D3: //only in this part third option is implemented.
                            {
                                ColoredString(ConsoleColor.Yellow, "\tUhh, yeah u r right, sorry for that. Err- anything else I can be a help with?\n");
                                Console.WriteLine("\t\t1.Yes, you can whisper to me about the latest gossip around\n" + 
                                                  "\t\tthe club. Bet you got your ears on stuff like that, right?\n");

                                if(UserOutput() == ConsoleKey.D1)
                                {
                                    ColoredString(ConsoleColor.Yellow, "\tWell… Something’s really off with our lead gal Chelsea\n" + 
                                                                       "\tthose days, at the dancers booths. I dunno why you are\n" +
                                                                       "\tinterested but just leave me be dude, a’ight?\n\n");

                                    Console.WriteLine("1. Good boy.");

                                    if (UserOutput() == ConsoleKey.D1)
                                        Booths();
                                }
                            }
                            break;
                    }
                }
                else //if they're not
                {
                    //first two options only, second option has only the first option, noo booths branch

                    Console.WriteLine("\t\t" + option2_1 + "\n\t\t" + option2_2 + "\n");

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            BartenderFailFrame();
                            break;
                        case ConsoleKey.D2:
                            BartenderGossipBooths(!player1.BoothsFail); //this will be same with the mr. robot's version- neutral booths yes seduction-based no. (!player1.. because if player1.BoothsFail == true then enableBooths must be false)                         
                            break;
                    }

                }
            }
            else if(player1.getSelectedChar().containsSkill(Skills.QuickHacking) || player1.getSelectedChar().containsSkill(Skills.LieDetect)) //if our character type is Mr. Robot or Alice, as they should have the same code since no intimidation and fluidity of...
            {
                    //if (!player1.BoothsFail) //if booths are available //UPDATE: no need to check because in other way the code will remain the same due to the fluidity of BartenderGossipBooths method.
                
                    //option1 and branching option2, but intimidation must be red
                    Console.WriteLine("\t\t" + option2_1 + "\n\t\t" + option2_2 + "\n");
                    ColoredString(ConsoleColor.Red, "\t\t" + option2_3 + "\n\n");

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            BartenderFailFrame();
                            break;
                        case ConsoleKey.D2:
                            BartenderGossipBooths(!player1.BoothsFail); //this will be same with the mr. robot's version- neutral booths yes seduction-based no. (!player1.. because if player1.BoothsFail == true then enableBooths must be false)                         
                            break;
                        case ConsoleKey.D3:
                            {
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if ((input == ConsoleKey.D1) || (input == ConsoleKey.D2))
                                    {
                                        wrongAnswer = false;

                                        if (input == ConsoleKey.D1)
                                            goto case ConsoleKey.D1;
                                        else
                                            goto case ConsoleKey.D2;
                                    }
                                } while (wrongAnswer);
                            }
                            break;
                    }
            }
        }

        //done
        public static void BartenderFailFrame()
        {
            player1.FailCount++;
            player1.BartenderFail = true;

            ColoredString(ConsoleColor.Yellow, "\tWoah chill man a’ight? Maybe you shouldn’t be talking with me ");
            Console.Write("*throws\n" +
                              "\ta look to the guards and mumbles*");
            ColoredString(ConsoleColor.Yellow, " ...shit.\n\n\n");

            PressToContColored(ConsoleColor.Yellow);

            AllColorSetter(ConsoleColor.White, ConsoleColor.DarkRed);

            Console.WriteLine("\n\n" +
                              "\t\t  ██████  ▒█████      ██▀███   █    ██ ▓█████▄ ▓█████\n" +
                              "\t\t▒██    ▒ ▒██▒  ██▒   ▓██ ▒ ██▒ ██  ▓██▒▒██▀ ██ ▓█   ▀\n" +
                              "\t\t░ ▓██▄   ▒██░  ██▒   ▓██ ░▄█ ▒▓██  ▒██░░██   █ ▒███  \n" +
                              "\t\t  ▒   ██▒▒██   ██░   ▒██▀▀█▄  ▓▓█  ░██░░▓█▄    ▒▓█  ▄\n" +
                              "\t\t▒██████▒▒░ ████▓▒░   ░██▓ ▒██▒▒▒█████▓ ░▒████▓ ░▒████▒\n" +
                              "\t\t▒ ▒▓▒ ▒ ░░ ▒░▒░▒░    ░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒  ▒▒▓  ▒ ░░ ▒░ ░\n" +
                              "\t\t░ ░▒  ░ ░  ░ ▒ ▒░      ░▒ ░ ▒░░░▒░ ░ ░  ░ ▒  ▒  ░ ░  ░\n" +
                              "\t\t░  ░  ░  ░ ░ ░ ▒       ░░   ░  ░░░ ░ ░  ░ ░  ░    ░   \n" +
                              "\t\t      ░      ░ ░        ░        ░        ░       ░  ░\n\n");

            Console.WriteLine("\tWhy such aggressiveness? You should be cooler than this! Now you feel the\n" +
                              "\tsecurity will be more careful with you.\n");

            PressToContColored(ConsoleColor.Black);

            if (TwoFailsGO()) { }
            else
                TheBar();
        }

        //done... I guess?
        public static void BartenderGossipBooths(bool enableBooths)
        {
            ColoredString(ConsoleColor.Yellow, "\tAnd you are miserably failing but whatevs, always open for a chit-chat.\n\n");

            bool enableBranch = false;
            string option2_2_1 = "1. Why the attitude dude, feeling down?";
            string option2_2_2 = "2. So, what’s up around the club?";

            Console.WriteLine("\t\t" + option2_2_1);

            if(enableBooths || player1.getSelectedChar().containsSkill(Skills.LieDetect))
                Console.WriteLine("\t\t" + option2_2_2);

            Console.WriteLine();

            switch(UserOutput())
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("\t*sighs*");
                        ColoredString(ConsoleColor.Yellow, "Yeah well, sorry about that. I’m really tired\n" + 
                                                           "\tand need some booze myself but y’know, can’t drink on duty.\n");

                        Console.WriteLine("\t\t1. I suppose it’s about something personal? Wanna talk about it?");
                        if (enableBooths || player1.getSelectedChar().containsSkill(Skills.LieDetect))
                            Console.WriteLine("\t\t2. Yeah I feel you.So, what’s up around the club ?");

                        Console.WriteLine();

                        ConsoleKey userInput = UserOutput();

                        if (userInput == ConsoleKey.D1)
                        {
                            ColoredString(ConsoleColor.Yellow, "\tActually, there’s a person upstairs and they creep\n" + 
                                                               "\tme out dude, makes me anxious. Other than that, I’m cool.\n\n");

                            Console.WriteLine("\t\t1. What kind of a person?\n");

                            if(UserOutput() == ConsoleKey.D1)
                            {
                                ColoredString(ConsoleColor.Yellow, "\tYou know it when you see it dude, go check yourself I say.\n\n");

                                Console.WriteLine("\t\t1. Well then, I’d do that.\n");

                                if (UserOutput() == ConsoleKey.D1)
                                    CrocodileThirdFloor();
                            }
                        }
                        else if ((userInput == ConsoleKey.D2) && (enableBooths || player1.getSelectedChar().containsSkill(Skills.LieDetect)))
                        {
                            enableBranch = true;
                            goto case ConsoleKey.D2;
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    {

                        if(enableBooths || player1.getSelectedChar().containsSkill(Skills.LieDetect))
                        {
                            //second option will be available

                            //if(!enableBranch) [unnecessary? (post-fix)]
                                ColoredString(ConsoleColor.Yellow, "\tYou know, same shit different day, nothing exciting nowadays.\n\n");
                            //options go:

                            string option2_2_2_1 = "1. Oh come on, that’s a huge club, I’m sure something’s up with it?";
                            string option2_2_2_2 = "2. At least don’t turn your eyes away dude… Do you\n\t\treally want me to believe there is nothing interesting\n\t\tin a club like that?[Lie Detection]";

                            if(enableBooths) //if booths are enabled.
                            {
                                Console.WriteLine("\t\t" + option2_2_2_1 + "\n");

                                if (player1.getSelectedChar().containsSkill(Skills.LieDetect))
                                    Console.WriteLine("\t\t" + option2_2_2_2 + "\n");
                                else
                                    ColoredString(ConsoleColor.Red, "\t\t" + option2_2_2_2 + "\n\n");
                            }
                            else if(!enableBooths && player1.getSelectedChar().containsSkill(Skills.LieDetect)) //booths are disabled but lie detection.
                                Console.WriteLine("\t\t1. " + option2_2_2_2.Substring(1) + "\n");
                           
                            switch(UserOutput())
                            {
                                case ConsoleKey.D1:
                                    {
                                        if(enableBooths) //when the booths are enabled first option is available to all.
                                        {
                                            ColoredString(ConsoleColor.Yellow, "\tWhy do you care anyway, you spy or  some\n" +
                                                                               "\tshit? ");
                                            Console.WriteLine("*he throws a little laugh*\n\n" + "\t\t1. Duh. Just wondering, I haven’t been around for a while.\n");

                                            if(UserOutput() == ConsoleKey.D1)
                                            {
                                                Console.Clear();

                                                ColoredString(ConsoleColor.Yellow, "\n\n\tHmm, well a small gossip wouldn’t do any harm\n" +
                                                                                   "\tI s'pose. I heard our dancer Chelsea has some\n" +
                                                                                   "\tproblems but I don’t really know what it's about.\n\n");
                                                Console.WriteLine("\t\t1. Huh, that’s interesting. She’s one of the\n" + "\t\tbest, what could’ve happened?\n");

                                                if(UserOutput() == ConsoleKey.D1)
                                                {
                                                    Console.WriteLine("\t*The bartender (apparently whose name is Laurence)\n" +
                                                                      "\tkept talking until you finished your drink but didn’t say\n" +
                                                                      "\tanything important.\n\n" + "\t\t1. So thanks for the chat dude. I’ll stick around.\n");

                                                    if (UserOutput() == ConsoleKey.D1)
                                                        Booths();
                                                }
                                            }

                                            
                                        }
                                        else //means the player despite being blocked out of booths could come through here due to having a LieDetect Skill.
                                        {
                                            ColoredString(ConsoleColor.Yellow, "\tUgh okay fine. Our dancer Chelsea seems to have\n" +
                                                                               "\tproblems, she looks really pissed off occasionally. And\n" +
                                                                               "\tmy buddies told me about a strange fellow upstairs, really odd looking.\n\n");

                                            Console.WriteLine("\t\t1. See, now that’s something! Thanks, see ya!\n");
                                            if(UserOutput() == ConsoleKey.D1)
                                            {
                                                Console.Clear();

                                                Console.WriteLine("\n\n\t\t\tWhere do you want to go?\n\n" + "\t\t1.  Go upstairs\n");

                                                if (UserOutput() == ConsoleKey.D1)
                                                    CrocodileThirdFloor(); //does not lead to booths bu to 3rd floor.
                                            }
                                        }
                                    }
                                    break;
                                case ConsoleKey.D2: //if player is not of Alice type they see the option but can't interact with it; if they're alice and they're blocked out of booths they can't interact with button 2, but if they're not blocked then they can
                                    {
                                        if((enableBooths && !player1.getSelectedChar().containsSkill(Skills.LieDetect)) || (!enableBooths && player1.getSelectedChar().containsSkill(Skills.LieDetect)))
                                        {
                                            bool wrongAnswer = true;
                                            ConsoleKey input;

                                            do
                                            {
                                                input = UserOutput();

                                                if (input == ConsoleKey.D1)
                                                {
                                                    wrongAnswer = false;

                                                    goto case ConsoleKey.D1;
                                                }
                                            } while (wrongAnswer);
                                        }
                                        else if(enableBooths && player1.getSelectedChar().containsSkill(Skills.LieDetect))
                                        {
                                            ColoredString(ConsoleColor.Yellow, "\tUgh okay fine. Our dancer Chelsea seems to have\n" +
                                                                               "\tproblems, she looks really pissed off occasionally. And\n" +
                                                                               "\tmy buddies told me about a strange fellow upstairs, really odd looking.\n\n");

                                            Console.WriteLine("\t\t1. See, now that’s something! Thanks, see ya!\n");
                                            if (UserOutput() == ConsoleKey.D1)
                                            {
                                                Console.Clear();

                                                Console.WriteLine("\t\t\tWhere do you want to go?\n\n" + "\t\t1.  Go to the booths\n" + "\t\t2. Go upstairs\n");

                                                switch(UserOutput())
                                                {
                                                    case ConsoleKey.D1:
                                                        Booths();
                                                        break;
                                                    case ConsoleKey.D2:
                                                        CrocodileThirdFloor();
                                                        break;
                                                }
                                            }
                                        }

                                    }
                                    break;
                            }
                        }
                        else
                        {
                            //second option is not available.

                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D1)
                                {
                                    wrongAnswer = false;

                                    goto case ConsoleKey.D1;
                                }
                            } while (wrongAnswer);
                        }
                    }
                    break;
            }
            
        }

        //needs love
        public static void TheDanceFloor()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Magenta);

            Console.WriteLine("\n\n\tYou have been in nightclubs. Perhaps many, yet none of it felt quite like this\n" + 
                              "\tone. The ambience, majesty and depravity of this club is at the top and you can\n" +
                              "\tfeel it, in every single muscle and fiber of your body. As the bass from EDM\n" +
                              "\ttracks shakes the ground, you step towards the dance floor.\n");

            ColoredString(ConsoleColor.DarkBlue, "\n\n" +
            "\t\t   $$$$$$$$$$$$R$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$$$V .Y...* *##%%$$$$$$$$$ \n" +
            "\t\t   $$$$# `$$N$$$$$$$$$mmmuuu:...# \n" +
            "\t\t   $$R    $$$$$$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $!   @$$$$$''R$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $>  '$$$$$F     $$$$$$$$$$$$$$ \n" +
            "\t\t   $W   $$$$:     R$$$$$$$$$$$$$$ \n" +
            "\t\t   $$     $$8$$R:x@$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$      $$$$x$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$     $N$ '$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$     $$$$ @  $$$$$$$$$$$$$$$ \n" +
            "\t\t   $`   u$$$$$    R$$$$$$$$$$$$$$ \n" +
            "\t\t      N$R$$$$      R$$$$$$$$$$$$$ \n " +
            "\t\t     *$$@$$$f .i.   `$$$$$$$$$$$$ \n" +
            "\t\t   k          9$$$.   $$$$$$$$$$$ \n" +
            "\t\t   R          M$$$$$.   $$$$$$$$$ \n" +
            "\t\t   $          4$$$$$$$.  $$$$$$$$ \n" +
            "\t\t   $          $$$$$$$$$$b-B>R$$$$ \n" +
            "\t\t   $          $$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $ <        $$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $ $b      $$$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$i     $$$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$c    #$$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$R     ?$$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$$      $$$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$$       $$$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$$  .i.   #$$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$R  d$b    M$$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$r  $$$$$$   9$$$$$$$$$$$$ \n" +
            "\t\t   $$$$#  X$$$$$$$od$$$$$$$$$$$$$ \n" +
            "\t\t   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ \n\n\n\n");

            string option1 = "1. Look for a partner. [Sharp Vision]";
            string option2 = "2. You see an IT guy among the crowd. Go be a flatterer to him. [Intimidation]";
            string option3 = "3. Become one with the crowd. [Crowd Blending]";
            string option4 = "4. Go to the bar instead.";

            if (player1.getSelectedChar().containsSkill(Skills.SVision)) //Alice
            {
                if(!player1.BoothsFail) //if booths are available
                {
                    Console.WriteLine("\t\t" + option1);
                    ColoredString(ConsoleColor.Red, "\t\t" + option2 + "\n\t\t" + option3 + "\n"); 
                    Console.WriteLine("\t\t" + option4 + "\n"); //since returning to bar is available all the time for Alice

                    switch(UserOutput())
                    {
                        case ConsoleKey.D1:
                            LookForAPartner(!player1.FreshmenConversed);
                            break;
                        case ConsoleKey.D2:
                            goto case ConsoleKey.D3;
                            //break;
                        case ConsoleKey.D3:
                            {
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if ((input == ConsoleKey.D1) || (input == ConsoleKey.D4))
                                    {
                                        wrongAnswer = false;

                                        if (input == ConsoleKey.D1)
                                            goto case ConsoleKey.D1;
                                        else
                                            goto case ConsoleKey.D4;
                                    }
                                } while (wrongAnswer);
                            }
                            break;
                        case ConsoleKey.D4:
                            TheBar();                            
                            break;
                    }
                }
                else //booths are not available
                {
                    //option one is invisible and the rest is the same.

                    ColoredString(ConsoleColor.Red, "\t\t1. " + option2.Substring(1) + "\n\t\t2. " + option3.Substring(1) + "\n");
                    Console.WriteLine("\t\t3. " + option4.Substring(1) + "\n"); //since returning to bar is available all the time for Alice

                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            goto case ConsoleKey.D2;
                            //break;
                        case ConsoleKey.D2:
                            {
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if (input == ConsoleKey.D3)
                                    {
                                        wrongAnswer = false;

                                        goto case ConsoleKey.D3;
                                    }

                                } while (wrongAnswer);
                            }
                            break;
                        case ConsoleKey.D3:
                            GoToBar();
                            break;
                    }
                }
            }
            else //either Mr. Robot or the Bride
            {
                //for option 1
                ColoredString(ConsoleColor.Red, "\t\t" + option1 + "\n");

                //for option2
                if (player1.getSelectedChar().containsSkill(Skills.Intimidation))
                    Console.WriteLine("\t\t" + option2);
                else
                    ColoredString(ConsoleColor.Red, "\t\t" + option2 + "\n");

                //for option 3
                if (player1.getSelectedChar().containsSkill(Skills.BlendCrowd))
                    Console.WriteLine("\t\t" + option3);
                else
                    ColoredString(ConsoleColor.Red, "\t\t" + option3 + "\n");

                //for the option 4, if already been to bar- option must be invisible.
                if (!player1.BeenToDanceFloor)
                    Console.WriteLine("\t\t" + option4);

                Console.WriteLine();

                if (player1.getSelectedChar().containsSkill(Skills.BlendCrowd))
                {
                    switch(UserOutput())
                    {
                        case ConsoleKey.D1:
                            goto case ConsoleKey.D2;
                            //break;
                        case ConsoleKey.D2:
                            {
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if (input == ConsoleKey.D3)
                                    {
                                        wrongAnswer = false;

                                        goto case ConsoleKey.D3;
                                    }

                                } while (wrongAnswer);
                            }
                            break;
                        case ConsoleKey.D3:
                            CrowdBlending(!player1.BoothsFail);
                            break;
                        case ConsoleKey.D4:
                            {
                                if (!player1.BeenToDanceFloor) //if mr. robot typed character have not been to the dance floor before.
                                    GoToBar();
                                else //if they've been before
                                    goto case ConsoleKey.D2;
                            }
                            break;
                    }
                }
                else //if the character type is of type the Bride
                {
                    switch (UserOutput())
                    {
                        case ConsoleKey.D1:
                            goto case ConsoleKey.D3;
                        //break;
                        case ConsoleKey.D2:
                            Intimidation();
                            break;
                        case ConsoleKey.D3:
                            {
                                bool wrongAnswer = true;
                                ConsoleKey input;

                                do
                                {
                                    input = UserOutput();

                                    if (input == ConsoleKey.D2)
                                    {
                                        wrongAnswer = false;

                                        goto case ConsoleKey.D2;
                                    }

                                } while (wrongAnswer);
                            }
                            break;
                        case ConsoleKey.D4:
                            {
                                if (!player1.BeenToDanceFloor) //if the Bride typed character have not been to the dance floor before.
                                    GoToBar();
                                else //if they've been before
                                    goto case ConsoleKey.D3;
                            }
                            break;
                    }
                }
                
            }

            //everyone can pick option 4.(besides Alice everyone only for once, Alice has a free pass due to a deadlock situation.)[changed the position of option 1 to 4 to bring an ease to the code]
            //if(!player1.BeenToDanceFloor || player1.getSelectedChar().containsSkill(Skills.Seduction))
        }

        //done... I guess?
        public static void LookForAPartner(bool enableGirls)
        {
            //enableGirls if booths are available and freshmen were not conversed with
            //booths check have been done in the previous method already

            /*string lel = "GeeksForGeeks";
             * Console.WriteLine(lel.Substring(4,3));
             * outputs --> sFo
             */

            Console.Clear();

            string onlyMan = "handsome man.";

            Console.WriteLine("\n\n\tYou started to dance but you know something is missing, you need \n" +
                              "\ta partner. As you whirl through the crowd, your eyes are looking\n" +
                              "\tfor a partner to dance together. You see a single corporate looking\n");

            if (enableGirls)
                Console.WriteLine("\t" + onlyMan.Substring(0, 12) + " and a girl couple who is currently in an argument\n" +
                                  "\twith some neckbeard nerd looking guys.\n");
            else
                Console.WriteLine("\t" + onlyMan + "\n");

            Console.WriteLine("\t\t1. Approach the man.");
            if (enableGirls)
                Console.WriteLine("\t\t2. Approach the girls.");

            Console.WriteLine();

            switch(UserOutput())
            {
                case ConsoleKey.D1:
                    {
                        //man option

                        Console.Clear();

                        Console.WriteLine("\n\n\tAs you approach the man, you start to see his face\n" +
                                          "\tmore clearly. Short, clean cut blonde hair, ice blue\n" +
                                          "\teyes with sharp features. He really is gorgeous.\n\n" + 
                                          "\t\t1. Such beauties like you don't sit alone like that\n" +
                                          "\t\toccasionally. Are you really alone? [Seduction]\n");

                        if(UserOutput() == ConsoleKey.D1)
                        {
                            ColoredString(ConsoleColor.White, "\tThanks for the reminder… ");
                            Console.Write("*drinks*");
                            ColoredString(ConsoleColor.White, " Yes I\n" + "\tam alone but in no condition to ask you to dance.\n\n");

                            Console.WriteLine("\t\t1. Dancing is lame anyway, just like talking about personal stuff\n" + 
                                              "\t\tin a nightclub. Are we having fun or not?\n");

                            if(UserOutput() == ConsoleKey.D1)
                            {
                                Console.WriteLine("\tHe gets up and leads you to one of the private\n" + 
                                                  "\tbooths. As his strong arms wrap up your  body, you\n" +
                                                  "\tfeel a heat pulsing through your body.\n");
                                    //edited
                                    Console.WriteLine("\t\t1. You are hearing an argument, observe. [Sharp Vision]\n");

                                    if(UserOutput() == ConsoleKey.D1)
                                    {
                                        Console.WriteLine("\tOver his shoulder you look through the gap of the\n" +
                                                          "\tdoor, and you see one of the dancers, having an argument\n" + 
                                                          "\twith a security guard.\n\n" + 
                                                          "\t\t1. Huh… Exactly what I needed… Thanks for the fun babe.\n");

                                        if (UserOutput() == ConsoleKey.D1)
                                            Booths();

                                    }
                               
                            }
                        }

                    }
                    break;
                case ConsoleKey.D2:
                    {
                        //girls option

                        player1.FreshmenConversed = true; //added pre-testing.

                        if(enableGirls)
                        {
                            Console.Clear();

                            ColoredString(ConsoleColor.White, "\t“You're still following this red-pill bullshit? I can’t\n" +
                                                              "\tbelieve you Kevin, what I can believe right now is I can\n" +
                                                              "\tsafely say to you that you can fuck yourself!”");
                            Console.WriteLine(" A hot\n" +
                                              "\targument indeed. Nevertheless, you arrive near the\n" +
                                              "\tgirls just as the group of nerds leaves their company.\n\n" + "\t\t1. Hey. Rough night?\n");

                            if(UserOutput() == ConsoleKey.D1)
                            {
                                Console.WriteLine("\t*Now you can see the girls' appearance clearly, one\n" +
                                                  "\tof them has long blonde hair, wearing a low-cut black\n" +
                                                  "\tdress, and her friend, a brunette, wearing a crop top\n" +
                                                  "\tcombined with a skirt. Brunette one turns to you and\n" +
                                                  "\t says* ");
                                ColoredString(ConsoleColor.White, "Yeah, pretty much. Looking for a company?\n\n");

                                Console.WriteLine("\t\t1. Wouldn’t say no, and besides, I bet I can be a way\n" + 
                                                  "\t\tbetter company than these guys. So, dance? [Seduction]\n");

                                if(UserOutput() == ConsoleKey.D1)
                                {
                                    ColoredString(ConsoleColor.White, "\tDance!!!!");
                                    Console.WriteLine(" *The blonde one screams and runs into the\n" +
                                                      "\tcrowd* … For minutes, you have danced and had so\n" +
                                                      "\tmuch fun and eventually, you found yourself in a private booth\n" +
                                                      "\twith Blake and Erica. While feeling a wave of incredible pleasure, your\n" +
                                                      "\tears captured a sound of an argument.\n\n" + "\t\t1. Observe. [Sharp Vision]\n");

                                    if(UserOutput() == ConsoleKey.D1)
                                    {
                                        Console.WriteLine("\tFrom over the girls’ shoulder, you see one of the\n" + 
                                                          "\tdancers, having an argument with a security guard.\n\n" + "\t\t1. Wow… That was amazing girls… Thanks for good time.");

                                        if (UserOutput() == ConsoleKey.D1)
                                            Booths();
                                    }

                                }

                            }
                        }
                        else
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D1)
                                {
                                    wrongAnswer = false;

                                    goto case ConsoleKey.D1;
                                }

                            } while (wrongAnswer);
                        }
                    }
                    break;
            }

        }

        //done... I guess?
        public static void CrowdBlending(bool enableBooths)
        {
            Console.Clear();

            Console.WriteLine("\n\n\tThere is no time to actually dance, use the people to your\n" + 
                              "\tadvantage and get the job done.\n\n" + "\t\t1. Walk-through people to reach the server room.");
            if (enableBooths)
                Console.WriteLine("\t\t2. Follow some people to reach the booths.");

            Console.WriteLine();

            switch(UserOutput())
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("\tWith little pushes and pulls here and there, you managed\n" +
                                          "\t to stay focused and found your way through people to the\n" + 
                                           "\tserver room.\n\n" + "\t\t1. Go inside the server room. [Lock-picking]\n" +
                                           "\t\t2. Deal with the security-cams. [Quick hacking]\n");

                        switch(UserOutput())
                        {
                            case ConsoleKey.D1:
                                ImmGO();
                                break;
                            case ConsoleKey.D2:
                                {
                                    Console.WriteLine("\tBefore going inside the server room, you remembered that\n" +
                                                      "\tyou first have to deal with the cameras. You leaned onto\n" +
                                                      "\tsome wall to blend in with the darkness of the club, and from\n" + 
                                                      "\tyour mobile, you hack into the system to disable the camera that\n" + 
                                                      "\toverlooks the server room.\n\n" + "\t\t1. Now go inside the server room. [Lock-picking]\n");

                                    if(UserOutput() == ConsoleKey.D1)
                                    {
                                        Console.WriteLine("\tYou picked the lock and got inside of\n" + "\tthe server room.\n\n");

                                        PressToContColored(ConsoleColor.White);

                                        ServerRoom();
                                    }

                                }
                                break;
                        }

                    }
                    break;
                case ConsoleKey.D2:
                    {
                        if(enableBooths)
                        {
                            Console.WriteLine("\tIn every big nightclub in this city, there must be a\n" + 
                                              "\tbooths section, to satisfy demanding customers other\n" +
                                              "\tpleasures. So, with that info in mind, you decided to\n" +
                                              "\tfollow a group of people to figure out where it is located.\n");

                            PressToContColored(ConsoleColor.White);

                            Booths();
                        }
                        else //if booths are disabled
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D1)
                                {
                                    wrongAnswer = false;

                                    goto case ConsoleKey.D1;
                                }

                            } while (wrongAnswer);
                        }
                    }
                    break;

            }

        }

        //done... I guess?
        public static void Intimidation()
        {
            //no booths branch initially.
            Console.Clear();

            Console.WriteLine("\n\n\tWithout losing the focus for even a second, you directly walked to him.\n\n" + "\t\t1. Suppose you are not here for the dancing, right?\n");
             
            if(UserOutput() == ConsoleKey.D1)
            {
                ColoredString(ConsoleColor.White, "\tUh-huh. Here to fix some stuff in the server room. Are you here to hel-\n\n");
                Console.WriteLine("\t\t1. With one hand close his mouth and grab his arm with the other. [Taijutsu]");

                if(UserOutput() == ConsoleKey.D1)
                {
                    Console.Write("\t*You lean onto his ear* Exactly my friend, I am here to\n" +
                                  "\thelp. *he tries to fight back* Oh no, don’t try to scream no-one\n" +
                                  "\tcan hear, we are just a couple who likes some rough play while dancing\n" +
                                  "\tam I right? Now, lead me to that room.\n");
                    ColoredString(ConsoleColor.White, "\t*MMMMMHHHHHH");
                    Console.WriteLine(", is his answer, while leading you to the server room.*\n\n" + "\t\t1. You arrived. Knock him out [Taijutsu]\n" +
                                                                                                      "\t\t2. Ask him to disable the security-cams.\n");

                    switch(UserOutput())
                    {
                        case ConsoleKey.D1:
                            ImmGO();
                            break;
                        case ConsoleKey.D2:
                            {
                                Console.WriteLine("\tHe obediently does it. You clearly scared him.\n\n" + "\t\t1. Leave him.\n" + "\t\t2. Knock him out. [Taijutsu]\n");

                                ConsoleKey userInput = UserOutput();

                                if (userInput == ConsoleKey.D1)
                                {
                                    player1.CompGuyFail = true;

                                    if (TwoFailsGO()) { }
                                    else
                                    {
                                        Console.WriteLine("\tAs soon as you say “Leave.” he runs back into\n" + "\t the club. You feel like this won’t be good but you showed\n" +
                                                          "\tmercy. Be careful with the security.\n\n");

                                        PressToContColored(ConsoleColor.White);
                                        ServerRoom();
                                    }
                                }
                                else if (userInput == ConsoleKey.D2)
                                    ServerRoom();
                            }
                            break;

                    }
                }

            }

        }

        //done
        public static void GoToBar()
        {
            Console.WriteLine("\tPerhaps because of the social anxiety, or a different personal\n" + 
                              "\treason, you decided not to go into the crowd.\n");

            PressToContColored(ConsoleColor.Magenta);
            player1.BeenToDanceFloor = true;
            TheBar();
        }

        //needs cleaning(needed update for ms. seduction)(update : modification done for ms. seduction)
        public static void Freshmen()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Cyan);
            SetWinSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            player1.FreshmenConversed = true;

            ColoredString(ConsoleColor.Yellow, 
          "\n\n\t               _...._                   " + "\n" +
          "\t           _.dMMMMMMMMMb.               " + "\n" +
          "\t        ..dMMMMMMMMMMMMMMMb             " + "\n" +
          "\t     .dMMMMMMMMMMMMMMMMMMMMb.           " + "\n" +
          "\t    dMMMMMMMMMMMMMMMMMMMMMMMM.          " + "\n" +
          "\t    MMMMMMMP'`YMMMMMMMMMMMMMMMb         " + "\n" +
          "\t    MMMMMMP    MMMMMMMMMMMMMMMM         " + "\n" +
          "\t   dMMMMMP     `MMMMMMMMMMMMMMMb        " + "\n" +
          "\t   MMMMMM~=,,_  `MMMMMMMMMMMMMMM        " + "\n" +
          "\t   MMMMMMP,6;    `MMMMMMMMMMMMMMb       " + "\n" +
          "\t   MMMMMM|         ```^YMMMMMMMMM       " + "\n" +
          "\t   MMMMMM:   -~        / |MMMMMMMb      " + "\n" +
          "\t   `MMMMM/|  _.._     /  |MMMMMMMM      " + "\n" +
          "\t     `YMM|_`.`~--'    |__|MMMMMMMM!     " + "                       .&dkl`,ivne._                                      \n" +
          "\t       MMMMMM|       _.' _sS}MMMMMb     " + "                       sRfkgvc+rsnmGBND.                                  \n" +
          "\t      `YMMMMMb.__.sP.---.  MMMMMMM      " + "                     aHBNLbni+.irumLGNMms                                 \n" +
          "\t         ``YMMMMMMMP'        MMMMMb     " + "                     NRIr`'+dLKNMFb`'iNQr                                 \n" +
          "\t             ``MMMd;          MMMMMM    " + "                    `ANWM7    `+lM0.  `'^Kl                               \n" +
          "\t                 dP|          :MMMMMb.  " + "                    iNWL*_;=e.     Y._,_ ON                               \n" +
          "\t            _.sP'             :MMMMMM   " + "                    aRNm   _.l,    j^ _` Bq,                              \n" +
          "\t        _.s888P'   ,  .-. .-. |MMMMM}   " + "                    eNL:,l=N0`.   ls`N0> ibK                              \n" +
          "\t     .s888888P    ,_|(  XoX  )|MMMM     " + "                    XHZu!       _(c      kPBN                             \n" +
          "\t   .d88888888;     `| `-._.-' ;;M'      " + "                     'CD   .     `      tK7KX                             \n" +
          "\t   8888888888|       :         :;,      " + "                       'f     _&zrc_.  .Y                                 \n" +
          "\t   8888888888;       |         |`;,_    " + "  ,                        v,   `ta.=', V                                 \n" +
          "\t   `Y88888888b     _,:         |;       " + " 7q. 6%                   ^l     =   .r                                   \n" +
          "\t       `^Y88888ssssSP~':        ; SsP   " + " f'noib. +                `d+   .._a7                     t               \n" +
          "\t           ''' |        |         ;     " + " k+RD6 L.dr                h'  `*+iPb                  .f adI`            \n" +
          "\t                ;       |         |     " + " dj+Ggr 4NJb            .,dT     `'KJc                 _ir+4b .           \n" +
          "\t                ;       ;         |     " + "   `cl^ ._ tk.   .,&;:rf't &; 'yIKbr;.              dp` luhrZti           \n" +
          "\t              /      .'          |      " + "      `~.  ^_T `ysf'      ' n, 7     * lkr,.      i7k._m.JKiV'            \n" +
          "\t             .'    .-'            ;     " + "         J  .H dY   `' -              ._``'VK,4=       .Kdj`              \n" +
          "\t            /_...-'             .'|     " + "         K   K B               -s&.        eJ+      .ys7^'                \n" +
          "\t           .'              _..-'   :    " + "         T   lLj                             (C'   .4                     \n" +
          "\t          /         __.--''         :   " + "         P   'y    .,                      . +j    7                      \n\n\n\n");

            PressToContColored(ConsoleColor.DarkYellow);

            SetWinSize(Console.LargestWindowWidth/2, Console.LargestWindowHeight);

            ColoredString(ConsoleColor.Yellow, "\n\n\t“... right??? He is totally a loooooser! Anyways babe… Maybe we should check\n" +
                              "\tupstairs and see what’s u-”.");


                Console.Write(" The girl who was talking, who has long blonde hair,\n" +
                              "\twearing a low-cut black dress, and her friend, a brunette, wearing a crop top\n" +
                              "\tcombined with a skirt, stops when she sees you.");

            ColoredString(ConsoleColor.Yellow, " “Uhm, hi?”\n\n");

            Console.Write($"\t\t1. Hey… I was just looking around for a company, I’m {player1.Name}.\n" +
                              $"\t\t2. Someone gave you guys trouble? Name’s {player1.Name} by the way.\n"); 

            if(player1.getSelectedChar().containsSkill(Skills.Seduction))
            {
                switch (UserOutput())
                {
                    case ConsoleKey.D1: //this one stays
                        {
                            ColoredString(ConsoleColor.Yellow, "\tOh and I’m Blake, this is my friend Erica. (Erica says hi as well.)\n\n");

                            Console.WriteLine("\t\t1. It’s so nice to meet you. Umm, you were saying something\n" +
                                              "\t\t about upstairs, would you mind if I tag along with you guys?\n");

                            if (UserOutput() == ConsoleKey.D1)
                            {
                                ColoredString(ConsoleColor.Yellow, "\tSure, why not! I heard they have a “house-party” kinda\n" +
                                                                   "\tvibe and apparently a strange looking person there \n" +
                                                                   "\tthat everyone talks about. Let’s check it out.\n");

                                PressToContColored(ConsoleColor.Yellow);
                                CrocodileThirdFloor();
                            }
                        }
                        break;
                    case ConsoleKey.D2: //this one too
                        {
                            Console.Write("\t*They look puzzled for a second and then the brunette girl\n" + "\tanswers*, ");

                            ColoredString(ConsoleColor.Yellow, $"Hahah! Nope, I don’t think so {player1.Name}. Best thing\n" +
                                          "\tyou can do is buying us a drink if you want to be a help.");

                            Console.Write(" *The\n" + "\tblonde turns to her, quite shocked, and says, ");

                            ColoredString(ConsoleColor.Yellow, "“Erica!!!”*\n\n");

                            Console.Write("\t\t1. Deal! *you ask two more of your drink*, but come on, at\n" +
                                              "\t\tleast fill me in about what happened?\n" + "\t\t2. Hey I’m serious, just let me know and I go handle it.\n");

                            if (!player1.BoothsFail)
                                Console.Write("\t\t3.Only if you promise to spice up this conversation later on… [Seduction]");

                            Console.WriteLine();

                            switch (UserOutput())
                            {
                                case ConsoleKey.D1:
                                    {
                                        Console.Clear();

                                        Console.Write("\n\n\tYou delve into a chat with the girls. Nothing\n" +
                                                      "\tparticularly intriguing, seems they got into an\n" +
                                                      "\targument with a group of incels. If it wasn’t for work,\n" +
                                                      "\tyou’d have a thing or two to say about the subject but\n" +
                                                      "\tnot today. ");

                                        ColoredString(ConsoleColor.Yellow, "“... So yeah, even in a beautiful club like that\n" +
                                                                          "\twe cannot escape from those meathead fucks. But\n" +
                                                                          "\twhat-eveeeer! Now that I’m tipsy enough, let’s get\n" +
                                                                          "\tback to dancing!”\n\n");

                                        Console.Write("\t\t1. Sure, right behind you!\n" +
                                                          "\t\t2.Aren’t you the one who was talking about going\n" +
                                                          "\t\tupstairs? Let’s go there instead!\n");

                                        switch (UserOutput())
                                        {
                                            case ConsoleKey.D1:
                                                TheDanceFloor();
                                                break;
                                            case ConsoleKey.D2:
                                                {
                                                    ColoredString(ConsoleColor.Yellow, "\tYeah, he’s right! And also, we can check the guy that everyone talks about!\n\n");
                                                    PressToContColored(ConsoleColor.Yellow);

                                                    CrocodileThirdFloor();
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case ConsoleKey.D2:
                                    {
                                        Console.Write("\t*Erica starts to pack her belongings from her stool*\n");
                                        ColoredString(ConsoleColor.Yellow, "\t“See, that’s how you become a creep.Piss off!” “Come\n" + "\ton love, we leaving” ");
                                        Console.Write("she whispered to the blonde.\n");

                                        PressToContColored(ConsoleColor.Yellow);

                                        //you f ed up :c
                                        player1.FailCount++;
                                        player1.FreshmenFail = true;

                                        if (TwoFailsGO()) { }
                                        else
                                        {
                                            //"fail" screen
                                            AllColorSetter(ConsoleColor.White, ConsoleColor.Red);

                                            Console.WriteLine("\n\n\tYou should have behaved more accordingly… Now you feel the security will be\n" + "\tmore careful with you.\n\n");
                                            PressToContColored(ConsoleColor.Yellow);
                                            //returning to the bar, talking to freshmen is disabled now
                                            TheBar();
                                        }
                                    }
                                    break;
                                case ConsoleKey.D3:
                                    {

                                        if (!player1.BoothsFail)
                                        {
                                            AllColorSetter(ConsoleColor.Black, ConsoleColor.DarkRed);

                                            Console.WriteLine("\n\n\t*Erica turns to the blonde and they giggle to each other*, ");
                                            ColoredString(ConsoleColor.Magenta, "\tOh, we most definitely will...\n");
                                            Console.WriteLine("\tAlthough conversation started more friendly than\n" +
                                                              "\tflirty, tables turned around quickly and you find\n" +
                                                              "\tyourself in one of the private booths. As the girls\n" +
                                                              "\ttravel through your neck with their radiant lips under\n" +
                                                              "\tthe dim light of the room, you feel a sense of ecstasy.\n" +
                                                              "\tBut it is no time to give up yourself to primal urges of\n" +
                                                              "\thuman condition. Your eyes catch a view between the\n" +
                                                              "\tfingers of Blake and Erica who caresses your face.\n");

                                            Console.WriteLine("\t\t1.  Look more carefully [Sharp Vision]\n");

                                            if (UserOutput() == ConsoleKey.D1)
                                            {
                                                Console.WriteLine("\tFrom the door gap, you see a security guard harassing\n" +
                                                                  "\ta dancer. But before you could even do anything, he left\n" +
                                                                  "\tand the dancer threw herself to a couch.\n\n" + "\t\t1. That was truly magical. Thanks for the fun time\n" +
                                                                  "\t\tgirls! *exit the private booth*\n");
                                                if (UserOutput() == ConsoleKey.D1)
                                                    Booths();
                                            }
                                            else
                                            {
                                                bool wrongAnswer = true;
                                                ConsoleKey input;

                                                do
                                                {
                                                    input = UserOutput();

                                                    if ((input == ConsoleKey.D1) || (input == ConsoleKey.D2))
                                                    {
                                                        wrongAnswer = false;

                                                        if (input == ConsoleKey.D1)
                                                            goto case ConsoleKey.D1;
                                                        else
                                                            goto case ConsoleKey.D2;
                                                    }
                                                } while (wrongAnswer);

                                            }

                                        }

                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            else
            {
                 switch(UserOutput())
                 {
                    case ConsoleKey.D1:
                        {
                            ColoredString(ConsoleColor.Yellow, "\tOh and I’m Blake, this is my friend Erica. (Erica says hi as well.)\n\n");

                            Console.WriteLine("\t\t1. It’s so nice to meet you. Umm, you were saying something\n" +
                                              "\t\t about upstairs, would you mind if I tag along with you guys?\n");

                            if(UserOutput() == ConsoleKey.D1)
                            {
                                ColoredString(ConsoleColor.Yellow, "\tSure, why not! I heard they have a “house-party” kinda\n" +
                                                                   "\tvibe and apparently a strange looking person there \n" +
                                                                   "\tthat everyone talks about. Let’s check it out.\n");

                                PressToContColored(ConsoleColor.Yellow);
                                CrocodileThirdFloor();
                            }
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Console.Write("\t*They look puzzled for a second and then the brunette girl\n" + "\tanswers*, ");

                            ColoredString(ConsoleColor.Yellow, $"Hahah! Nope, I don’t think so {player1.Name}. Best thing\n" +
                                          "\tyou can do is buying us a drink if you want to be a help.");

                            Console.Write(" *The\n" + "\tblonde turns to her, quite shocked, and says, ");

                            ColoredString(ConsoleColor.Yellow, "“Erica!!!”*\n\n");

                            Console.WriteLine("\t\t1. Deal! *you ask two more of your drink*, but come on, at\n" +
                                              "\t\tleast fill me in about what happened?\n" + "\t\t2. Hey I’m serious, just let me know and I go handle it.\n");
                             //added
                            ColoredString(ConsoleColor.Red ,"\t\t3. Only if you promise to spice up this conversation later on… [Seduction]\n\n");

                            switch(UserOutput())
                            {
                                case ConsoleKey.D1:
                                    {
                                        Console.Clear();

                                        Console.Write("\n\n\tYou delve into a chat with the girls. Nothing\n" +
                                                      "\tparticularly intriguing, seems they got into an\n" +
                                                      "\targument with a group of incels. If it wasn’t for work,\n" +
                                                      "\tyou’d have a thing or two to say about the subject but\n" +
                                                      "\tnot today. ");

                                        ColoredString(ConsoleColor.Yellow, "“... So yeah, even in a beautiful club like that\n" +
                                                                          "\twe cannot escape from those meathead fucks. But\n" +
                                                                          "\twhat-eveeeer! Now that I’m tipsy enough, let’s get\n" +
                                                                          "\tback to dancing!”\n\n");

                                        Console.WriteLine("\t\t1. Sure, right behind you!\n" +
                                                          "\t\t2.Aren’t you the one who was talking about going\n" +
                                                          "\t\tupstairs? Let’s go there instead!\n");

                                        switch(UserOutput())
                                        {
                                            case ConsoleKey.D1:
                                                TheDanceFloor();
                                                break;
                                            case ConsoleKey.D2:
                                                {
                                                    ColoredString(ConsoleColor.Yellow, "\tYeah, he’s right! And also, we can check the guy that everyone talks about!\n\n");
                                                    PressToContColored(ConsoleColor.Yellow);

                                                    CrocodileThirdFloor();
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case ConsoleKey.D2:
                                    {
                                        Console.Write("\t*Erica starts to pack her belongings from her stool*\n");
                                        ColoredString(ConsoleColor.Yellow, "\t“See, that’s how you become a creep.Piss off!” “Come\n" + "\ton love, we leaving” ");
                                        Console.Write("she whispered to the blonde.\n");

                                        //you f ed up :c
                                        player1.FailCount++;
                                        player1.FreshmenFail = true;

                                        if(TwoFailsGO()){ }
                                            else
                                                {
                                                    //"fail" screen
                                                    AllColorSetter(ConsoleColor.White, ConsoleColor.Red);

                                            Console.WriteLine("\n\n" +
                                                 "\t\t  ██████  ▒█████      ██▀███   █    ██ ▓█████▄ ▓█████\n" +
                                                 "\t\t▒██    ▒ ▒██▒  ██▒   ▓██ ▒ ██▒ ██  ▓██▒▒██▀ ██ ▓█   ▀\n" +
                                                 "\t\t░ ▓██▄   ▒██░  ██▒   ▓██ ░▄█ ▒▓██  ▒██░░██   █ ▒███  \n" +
                                                 "\t\t  ▒   ██▒▒██   ██░   ▒██▀▀█▄  ▓▓█  ░██░░▓█▄    ▒▓█  ▄\n" +
                                                 "\t\t▒██████▒▒░ ████▓▒░   ░██▓ ▒██▒▒▒█████▓ ░▒████▓ ░▒████▒\n" +
                                                 "\t\t▒ ▒▓▒ ▒ ░░ ▒░▒░▒░    ░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒  ▒▒▓  ▒ ░░ ▒░ ░\n" +
                                                 "\t\t░ ░▒  ░ ░  ░ ▒ ▒░      ░▒ ░ ▒░░░▒░ ░ ░  ░ ▒  ▒  ░ ░  ░\n" +
                                                 "\t\t░  ░  ░  ░ ░ ░ ▒       ░░   ░  ░░░ ░ ░  ░ ░  ░    ░   \n" +
                                                 "\t\t      ░      ░ ░        ░        ░        ░       ░  ░\n\n");

                                            Console.WriteLine("\n\n\tYou should have behaved more accordingly… Now you feel the security will be\n" + "\tmore careful with you.\n\n");
                                                    PressToContColored(ConsoleColor.Black);
                                                    //returning to the bar, talking to freshmen is disabled now
                                                    TheBar();
                                                }
                                    }
                                    break;
                                case ConsoleKey.D3:
                                    {

                                        bool wrongAnswer = true;
                                        ConsoleKey input;

                                        do
                                        {
                                            input = UserOutput();

                                            if ((input == ConsoleKey.D1) || (input == ConsoleKey.D2))
                                            {
                                                wrongAnswer = false;

                                                if (input == ConsoleKey.D1)
                                                    goto case ConsoleKey.D1;
                                                else
                                                    goto case ConsoleKey.D2;
                                            }
                                        } while (wrongAnswer);

                                        /*AllColorSetter(ConsoleColor.Black, ConsoleColor.DarkRed);

                                        Console.Write("\t*Erica turns to the blonde and they giggle to each other*, ");
                                        ColoredString(ConsoleColor.Magenta, "Oh, we most definitely will...\n");
                                        Console.WriteLine("\tAlthough conversation started more friendly than\n" +
                                                          "\tflirty, tables turned around quickly and you find\n" +
                                                          "\tyourself in one of the private booths. As the girls\n" +
                                                          "\ttravel through your neck with their radiant lips under\n" +
                                                          "\tthe dim light of the room, you feel a sense of ecstasy.\n" +
                                                          "\tBut it is no time to give up yourself to primal urges of\n" +
                                                          "\thuman condition. Your eyes catch a view between the\n" +
                                                          "\tfingers of Blake and Erica who caresses your face.\n");

                                        Console.WriteLine("\t\t1.  Look more carefully [Sharp Vision]\n");

                                        if(UserOutput() == ConsoleKey.D1)
                                        {
                                            Console.WriteLine("\tFrom the door gap, you see a security guard harassing\n" +
                                                              "\ta dancer. But before you could even do anything, he left\n" +
                                                              "\tand the dancer threw herself to a couch.\n\n" + "\t\t1. That was truly magical. Thanks for the fun time\n" +
                                                              "\t\tgirls! *exit the private booth*\n");
                                            if (UserOutput() == ConsoleKey.D1)
                                                Booths();
                                        }*/
                                    }
                                    break;
                            }
                        }
                        break;
                 }
            }


        }

        //so far so good
        public static void Booths()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.DarkRed);

            Console.WriteLine("\n\n" +
           "\t                          .:, ______ ,        \n" +
           "\t                         , ) ._       .       \n" +
           "\t                          /,   )___    .      \n" +
           "\t                     ___/ -.   _ - )    .     \n" +
           "\t                     .    M;) /M) /`    (     \n" +
           "\t                     /   |   _   (  _    )    \n" +
           "\t                    ,     . (_)  , : )  /     \n" +
           "\t                   (       .____    C| ;      \n" +
           "\t                    .   __      .     ./                  \n" +
           "\t                     )  )/       )     .,___ ___          \n" +
           "\t                    /     ___ __;        _  X    .,       \n" +
           "\t                   (    /.   X.         '  XV    ,.       \n" +
           "\t                    . ./,     Xx          YXX.   :|:,,    \n" +
           "\t                     .`|    _ XXXX.     ,XXXXA      |   , \n" +
           "\t                   ., ./    /.ZXXXXZSxcSZXXXXSt     |.i   \n" +
           "\t                :,..  /    /,,jSXXXXV’  'XXXSXf, |   |    \n" +
           "\t               .:    ,    /    |             |i .,__- .,;;,:ittII+.   \n" +
           "\t        .:+++iii,   /    _ __   +RBBBB( )WBBBR+  /   _ )      .;;iii. \n" +
           "\t      ,;;,:ittII+,M(    .,   .   +RBBBBVBBBBBR+ |.   /     ::;t;;yii  \n" +
           "\t   ::;t;;iii. .,:;;,+..,.|    .   VBBBBBBBBBBR+  | __|_.,;,    lfr.   \n" +
           "\t  itVtIII :i;             .   ,|  XNBBBBRZRXBR(   /     ,     +x ,    \n" +
           "\t +;;t:Yit  .,            _/__ /   WKBBBBRXZSRBRi        ,..,:::;.     \n" +
           "\t     ..                     ./   AWNBBRSYEXYZXRa  \n" +
           "\t                              .IMNSRXYZSRBBBBBRi  \n" +
           "\t                              iMBSClXRNMMMMWNKRR. \n" +
           "\t                              WMRZYSYRNMMMMWNBRYi \n" +
           "\t                             lWMSZXYSKRNNMMMNBWS+ \n" +
           "\t                             SWMRIOZRBNMMMMMMKBRi \n" +
           "\t                             lWMXZCZNMMMMMMWNKSR+ \n" +
           "\t                             iNUZYiSRNMMMMMMNUZR+ \n" +
           "\t                             lBRYltRNWMMMMMMWNRX' \n" +
           "\t                             'KXltxXBWMMMMMWNKBT  \n" +
           "\t                              SZriZSNWMMMMMMNBSt  \n" +
           "\t                               ltttttttthWKfttf   \n" +
           "\t                               ittttttttWBtttt;   \n" +
           "\t                               'ttttttttBStttl'   \n" +
           "\t                                ZttttttYZttttf    \n" +
           "\t                                 lStttttRftttv    \n" +
           "\t                                 itSRNNYKtttt'    \n" +
           "\t                                 tYSKRNEttttP     \n" +
           "\t                                  StttSYZfttv     \n" +
           "\t                                 .ftttlZXStY      \n" +
           "\t                                 jttttttBKti      \n" +
           "\t                                 StttttIWttt      \n" +
           "\t                                 ZtttttYRtt'      \n" +
           "\t                                 iSttttSttv       \n" +
           "\t                                  lStttFty        \n" +
           "\t                                   YtttZtt        \n" +
           "\t                                    VttKtI        \n" +
           "\t                                    VttNtE        \n" +
           "\t                                   AtttWWIR       \n" +
           "\t                                   kt:ttNRlR      \n" +
           "\t                                  ZttttttBSlRi    \n" +
           "\t                                  AtttttttXKZFti  \n" +
           "\t                                    Vtttttttl     \n" +
           "\t                                      `tttttti    \n\n");

            PressToContColored(ConsoleColor.Red);

            Console.Write("\n\n\tFirst, the character of lights and colours has changed. From flashing neon lights\n" +
                              "\tand suffocating darkness, to static and embracing red and purple. As you go \n" +
                              "\tdeeper into the booths you observe dancers from all sorts of genders are\n" +
                              "\tperforming on their stages to their audience. It’s a very captivating view but you\n" +
                              "\tmust stay focused. You notice a dancer with colourful curly hair, thick red lips\n" +
                              "\tand a brown skin, wearing a leather attire and trying to light a cigarette. Her\n" +
                              "\tmakeup is kinda washed-up and she definitely needs to freshen up a bit. While\n" +
                              "\tyou are looking, she also notices you and directly asks: ");
            ColoredString(ConsoleColor.Magenta, "“If you are here for the\n" +
                                                "\tshow, a short delay occurred I am afraid. But why don’t you sit and have a drink?”\n\n");

            string option1 = "1. I actually saw you having a fight, so I got out of a private show to talk. [Seduction]";
            string option2 = "2. In fact, I know it’s a bit odd to ask something like this out of nowhere but,\n\t\tI came here " +
                                    "to satisfy my curiosity. Seems you are having issues with a\n\tparticular individual, am I correct?";
            string option2_1 = "1. Well I have my capabilities that I would gladly apply for good\n\t\tuse. For instance, I can reach out to his accounts, but this\n\t\tstays between us. [Quick hacking]\n";
            string option2_2 = "2. I simply also don’t like bullies and enjoy having fun with\n\t\tthem. Through… Various methods [Taijutsu]\n";
            string option2_3 = "3. I’d like to teach a douchebag, how to behave. [Seduction]";

            if (player1.getSelectedChar().containsSkill(Skills.Seduction)) //player has seduction
            {
                Console.WriteLine("\t\t" + option1 + "\n"
                                    + "\t\t" + option2 + "\n");

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();

                            ColoredString(ConsoleColor.Magenta, "\n\n\tOh wow, excuse me if I’m being rude but… Why?\n\n");

                            Console.WriteLine("\t\t1. Let’s say it troubles me to see wonders like you sad. Would\n" +
                                              "\tyou mind giving me some more details about this, perhaps I\n" +
                                              "\tmight be of help.\n\n" + "\t\t2. You look better than the other ones. Come on I promise I\n" +
                                              "\twill make you forget all your troubles.\n");

                            switch(UserOutput())
                            {
                                case ConsoleKey.D1:
                                    {
                                        //to Bug.
                                        Console.Write("\t*she drags from her cigarette* ");
                                        ColoredString(ConsoleColor.Magenta, "I hate it, can’t deal with\n" +
                                                                           "\tit anymore. I loved it once, this job, cuz it was a \n" +
                                                                           "\tpassion. But now, it’s just a burden on my psychology.\n" +
                                                                           "\tEspecially because of the fucker you just saw, and his\n" +
                                                                           "\tconstant bullying. I told him a million times that I will\n" +
                                                                           "\tnot sleep with him. Shithead. If he continues to do it, I\n" +
                                                                           "\twill certainly resign. We call him, “Bug” by the way.\n\n");

                                        Console.WriteLine("\t\t1. Hah, it figures. Maybe I should look into this, “Bug”. See\n" +
                                                          "\twhat I can do. Then, we will have a drink. Deal?\n");
                                        ColoredString(ConsoleColor.Magenta, "\tAbsolutely honey. ");
                                        Console.WriteLine(" *she smiles and continues to smoke*\n\n" + "\t\t1. Search among the crowd for the “Bug” [Sharp Vision]\n");

                                        if (UserOutput() == ConsoleKey.D1)
                                            Bug();
                                    }
                                    break;
                                case ConsoleKey.D2:
                                    {
                                        //booths fail part.
                                        ColoredString(ConsoleColor.Magenta, "\tWhat the fuck are you talking about you creep-ass\n" 
                                                                           + "\tdickhead? Get out of here or things will get worse!!!\n\n");

                                        PressToContColored(ConsoleColor.Magenta);

                                        //---Fail Csreen---

                                        AllColorSetter(ConsoleColor.White, ConsoleColor.Black);

                                        //might need cleaning up
                                        Console.WriteLine("\n\n" +
                                                             "\t\t  ██████  ▒█████      ██▀███   █    ██ ▓█████▄ ▓█████\n" +
                                                             "\t\t▒██    ▒ ▒██▒  ██▒   ▓██ ▒ ██▒ ██  ▓██▒▒██▀ ██ ▓█   ▀\n" +
                                                             "\t\t░ ▓██▄   ▒██░  ██▒   ▓██ ░▄█ ▒▓██  ▒██░░██   █ ▒███  \n" +
                                                             "\t\t  ▒   ██▒▒██   ██░   ▒██▀▀█▄  ▓▓█  ░██░░▓█▄    ▒▓█  ▄\n" +
                                                             "\t\t▒██████▒▒░ ████▓▒░   ░██▓ ▒██▒▒▒█████▓ ░▒████▓ ░▒████▒\n" +
                                                             "\t\t▒ ▒▓▒ ▒ ░░ ▒░▒░▒░    ░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒  ▒▒▓  ▒ ░░ ▒░ ░\n" +
                                                             "\t\t░ ░▒  ░ ░  ░ ▒ ▒░      ░▒ ░ ▒░░░▒░ ░ ░  ░ ▒  ▒  ░ ░  ░\n" +
                                                             "\t\t░  ░  ░  ░ ░ ░ ▒       ░░   ░  ░░░ ░ ░  ░ ░  ░    ░   \n" +
                                                             "\t\t      ░      ░ ░        ░        ░        ░       ░  ░\n\n");

                                        Console.WriteLine("\t\tNo. No no no. Just… Why did you think it is okay to say something like this to a \n" +
                                                          "\t\tperson, and better yet, an already troubled person?\n\n\n");

                                        PressToContColored(ConsoleColor.DarkRed);

                                        player1.BoothsFail = true;
                                        
                                        if (TwoFailsGO()) { }
                                        else
                                            FirstScene();

                                    }
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Console.Clear();

                            ColoredString(ConsoleColor.Magenta, "\n\n\tYes or no, what is it to you anyway sweetheart? ");
                            Console.WriteLine("*she exhales smoke*\n");

                            ColoredString(ConsoleColor.Gray, "\t\t" + option2_1 + "\t\t" + option2_2);
                            Console.WriteLine("\t\t" + option2_3 + "\n");

                            switch(UserOutput())
                            {
                                case ConsoleKey.D1: //non-selectable
                                    {
                                        bool wrongAnswer = true;
                                        ConsoleKey input;

                                        do
                                        {
                                            input = UserOutput();

                                            if (input == ConsoleKey.D3)
                                            {
                                                wrongAnswer = false;

                                                goto case ConsoleKey.D3;
                                            }
                                        } while (wrongAnswer);
                                    }
                                    break;
                                case ConsoleKey.D2: //non-selectable
                                    {
                                        bool wrongAnswer = true;
                                        ConsoleKey input;

                                        do
                                        {
                                            input = UserOutput();

                                            if (input == ConsoleKey.D3)
                                            {
                                                wrongAnswer = false;

                                                goto case ConsoleKey.D3;
                                            }
                                        } while (wrongAnswer);
                                    }
                                    break;
                                case ConsoleKey.D3: //selectable
                                    {
                                        ColoredString(ConsoleColor.Magenta, "\tIntriguing… Maybe you can teach me too, one day.\n\n");
                                        Console.WriteLine("\t\t1. If you like… But first things first!");

                                        if(UserOutput() == ConsoleKey.D1)
                                            Bug();
                                    }
                                    break;
                            }

                        }
                        break;
                }

            }
            else //no seduction, either Taijitsu or QuickHacking.
            {
                ColoredString(ConsoleColor.Gray, "\t\t" + option1 + "\n");
                Console.WriteLine("\t\t" + option2 + "\n");

                switch(UserOutput())
                {
                    case ConsoleKey.D1: //can't select first option
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D2)
                                {
                                    wrongAnswer = false;

                                    goto case ConsoleKey.D2;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                    case ConsoleKey.D2:
                        {

                            Console.Clear();

                            ColoredString(ConsoleColor.Magenta, "\n\n\tYes or no, what is it to you anyway sweetheart? ");
                            Console.WriteLine("*she exhales smoke*\n");

                            if (player1.getSelectedChar().containsSkill(Skills.QuickHacking)) //can select only first option
                            {
                                Console.WriteLine("\t\t" + option2_1);
                                ColoredString(ConsoleColor.Gray, "\t\t" + option2_2 + "\t\t" + option2_3 + "\n\n");

                                switch(UserOutput())
                                {
                                    case ConsoleKey.D1:
                                        {
                                            ColoredString(ConsoleColor.Magenta, "\tHell yeah, but promise me a share hahah!\n\n");
                                            Console.WriteLine("\t\t1. You got it!\n");

                                            if (UserOutput() == ConsoleKey.D1)
                                                Bug();
                                        }
                                        break;
                                    case ConsoleKey.D2:
                                        {
                                            bool wrongAnswer = true;
                                            ConsoleKey input;

                                            do
                                            {
                                                input = UserOutput();

                                                if (input == ConsoleKey.D1)
                                                {
                                                    wrongAnswer = false;

                                                    goto case ConsoleKey.D1;
                                                }
                                            } while (wrongAnswer);
                                        }
                                        break;
                                    case ConsoleKey.D3:
                                        {
                                            bool wrongAnswer = true;
                                            ConsoleKey input;

                                            do
                                            {
                                                input = UserOutput();

                                                if (input == ConsoleKey.D1)
                                                {
                                                    wrongAnswer = false;

                                                    goto case ConsoleKey.D1;
                                                }
                                            } while (wrongAnswer);
                                        }
                                        break;
                                }
                            }
                            else //means the player have Taijitsu, only second option is selectable.
                            {
                                ColoredString(ConsoleColor.Gray, "\t\t" + option2_1 + "\n"); 
                                Console.WriteLine("\t\t" + option2_2);
                                ColoredString(ConsoleColor.Gray, "\t\t" + option2_3 + "\n\n");

                                switch (UserOutput())
                                {
                                    case ConsoleKey.D1:
                                        {
                                            bool wrongAnswer = true;
                                            ConsoleKey input;

                                            do
                                            {
                                                input = UserOutput();

                                                if (input == ConsoleKey.D2)
                                                {
                                                    wrongAnswer = false;

                                                    goto case ConsoleKey.D2;
                                                }
                                            } while (wrongAnswer);
                                        }
                                        break;
                                    case ConsoleKey.D2:
                                        {
                                            ColoredString(ConsoleColor.Magenta, "\tThings that I’d give away to watch this… Just be careful, please?\n\n");
                                            Console.WriteLine("\t\t1. Of course. He will be a cute little boy after that.\n");

                                            if (UserOutput() == ConsoleKey.D1)
                                                Bug();
                                        }
                                        break;
                                    case ConsoleKey.D3:
                                        {
                                            bool wrongAnswer = true;
                                            ConsoleKey input;

                                            do
                                            {
                                                input = UserOutput();

                                                if (input == ConsoleKey.D2)
                                                {
                                                    wrongAnswer = false;

                                                    goto case ConsoleKey.D2;
                                                }
                                            } while (wrongAnswer);
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        //done
        public static void ServerRoom()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.White);

            ColoredString(ConsoleColor.Green, "\n\n" +
"\t             ________________________________________________   \n" +
"\t            .                                                .  \n" +
"\t           |    _________________________________________     | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |  C:\\> _                                 |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |                                         |    | \n" +
"\t           |   |_________________________________________|    | \n" +
"\t           |                                                  | \n" +
"\t            ._________________________________________________. \n" +
"\t                   .___________________________________.        \n" +
"\t                ___________________________________________     \n" +
"\t             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_  \n" +
"\t          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_ \n" +
"\t       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_  \n" +
"\t    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_  \n" +
"\t _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_  \n" +
"\t:-------------------------------------------------------------------------:  \n" +
"\t`---._.-------------------------------------------------------------._.---'  \n" );

            Console.WriteLine("\n\n\tYou would expect to find the main computer here also but no luck on that part.\n\n" +
                              "\t\t1. Try to locate the main computer through the surveillance system.\n");

            if (UserOutput() == ConsoleKey.D1)
            {
                Console.WriteLine("\tIt is somewhat surprising to see that the main computer is a laptop\n" +
                                  "\tsitting on the lap of some alternative looking person on the 3rd floor.\n" +
                                  "\tWell, now you know your destination.\n");

                PressToContColored(ConsoleColor.Green);
                CrocodileThirdFloor();
            }
        }

        //done
        public static void Bug()
        {
            AllColorSetter(ConsoleColor.Gray, ConsoleColor.Black);

            Console.WriteLine("\n\n" +
            "\t\t                     dS$$S$S$S$S$S$S$$Sb                      \n" +
            "\t\t                    :$$S^S$S$S$S$S$S^S$$;                     \n" +
            "\t\t                    SSP   `^$S$S$^'   TSS                     \n" +
            "\t\t                    $$       `^'       $$                     \n" +
            "\t\t                   _SS ,-           -  SS_                    \n" +
            "\t\t                  :-.|  _    - .-   _  |.-;                   \n" +
            "\t\t                 :|(; ' ' -._.'._.-' ` |)|;                   \n" +
            "\t\t                  | `|  , o       o .  |'                     \n" +
            "\t\t                    ^:     -'   `-     :^                     \n" +
            "\t\t                      :.              :                       \n" +
            "\t\t                      : `    ._.    ' :                       \n" +
            "\t\t                    .sSb   ._____.   dSs.                     \n" +
            "\t\t                 _.d8dSSb.   ._.   .SSbT8b._                  \n" +
            "\t\t            _.oOPd88SSSS T.       .P SSSS888OOo.              \n" +
            "\t\t        _.mMMOOPd888SSSSb TSqqqSP dSSSS88OMOOOMMm._           \n" +
            "\t\t     .oOMMMOMOOM8O8OSSSSSb TSSSP dSSSSS8OOMMOOMMOOOo._        \n" +
            "\t\t .OOMMOOOMMOOMOOOOOO' ^ SSSTSSP dSSS ^  'OOOOMMOOMMMOOMMb.    \n" +
            "\t\t dOOOMMMOMMOOOMOOOOO    ' ^ SSSS ^ '    :OOO8MMMOOMMOOMMOMMb  \n" +
            "\t\t MMMMOOMMOMMOOMMO8OSP         `P        O8OPdMMOOMMOMMOMMMMMM \n" +
            "\t\t MMMMOOMMMMMOOMbTO8SS:                 :8888MMMMMOMMOMMOMMMMM \n" +
            "\t\t OOMMMMOOMMMMOOOMMOOOS:       S       :O8OPdMOMMMOMOMMOOMMMMO \n" +
            "\t\t OOMMMMOOMMOMMOOMbTObTTb.     S     .dOPdMOOMMMMMOMMOMMMMMOOO \n" +
            "\t\t MOOMMMMOMMOMMOOMMMOObTSSg._.SSS._.PdOPdMOOMMMMOMMMMOMMMMOOMM \n" +
            "\t\t MMMOMMMMOMMMOMMOOMMbT8bTSSSSSSSSSPd8OPdOOOMMMMOOMMMMOMMMOOMM \n" +
            "\t\t MMMOMMMOMMMMMOMMOOMMMbT8bTSSSSSPd88PdOOOOMMMMOOMMMMMMMMOOMMM \n\n");


            Console.WriteLine("\n\n\tThe dancer guided you about finding him and you followed her guidance. You\t\n" +
                             "\tfound the Bug on the 3rd floor and as soon as you found him, you realized he is\n" +
                             "\talso the “Technology Manager” of the club, not your usual security guard.\n" +
                             "\tLuckily, the 3rd floor is not as crowded as the main floor so it is easier to hold a\n" +
                             "\tstrategic position. You see him, sitting in his office, surfing on his phone. How\n" +
                             "\twill you approach?\n");

            if(player1.getSelectedChar().containsSkill(Skills.Stealth)) //stealth
            {
                Console.Write("\t\t1. Go sneaky. [Stealth]\n"); //selectable
                ColoredString(ConsoleColor.Red, "\t\t2. Go directly and assertively. [Seduction]\n" +
                                                 "\t\t3. Mess with his phone from distance. [Quick hacking]\n"); //non-selectable

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine("\tYou become one with the shadows, and they show you a way inside\n" +
                            "\tto the office. Now you are standing just behind the “Bug”.\n\n" + "\t\t1.Sleep well. [Taijutsu]\n");

                            if(UserOutput() == ConsoleKey.D1)
                            {
                                Console.WriteLine("\tWith an incredible speed, you knocked him out. His\n" +
                                                  "\tcomputer lays in front of you to complete your job.\n\n" + "\t\t1. Install the malware.\n");

                                if (UserOutput() == ConsoleKey.D1)
                                    BugMissionComp();
                            }

                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D1)
                                {
                                    wrongAnswer = false;
                                    goto case ConsoleKey.D1;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D1)
                                {
                                    wrongAnswer = false;
                                    goto case ConsoleKey.D1;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                }

            }
            else if(player1.getSelectedChar().containsSkill(Skills.Seduction)) //seduction
            {
                ColoredString(ConsoleColor.Red, "\t\t1. Go sneaky. [Stealth]\n"); //non-selectable
                Console.WriteLine("\t\t2. Go directly and assertively. [Seduction]"); //selectable
                ColoredString(ConsoleColor.Red, "\t\t3. Mess with his phone from distance. [Quick hacking]\n\n"); //non-selectable

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D2)
                                {
                                    wrongAnswer = false;
                                    goto case ConsoleKey.D2;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            //if(UserOutput() == ConsoleKey.D1) //why was this here?
                            

                                Console.WriteLine("\tYou are well aware that your words are sharper than any blade, so\n" +
                                                  "\tyou just barged into the office and greeted with a puzzling look.\n\n" + "\t\t1. So, you are the one who sexually harasses a well-renowned\n" +
                                                  "\tdancer? You really are in deep shit “Bug”.\n");

                                Console.Write("\t*He reaches for his handgun and points it to you* ");
                                ColoredString(ConsoleColor.Blue, "Who\n" + "\tare you? Get the fuck out or I’ll blow your brains up!\n\n");

                                Console.WriteLine("\t\t1. Wow, you really are stupid as shit. Imagine what happens if\n" +
                                                 "\t you shot a person, who just caught your misbehaviour, in the\n" +
                                                 "\tmiddle of a club. I am not alone in this and you will certainly\n" +
                                                 "\tbe damned.\n");

                                if(UserOutput() == ConsoleKey.D1)
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\t*He panics, puts down the gun and asks* ");
                                    ColoredString(ConsoleColor.Blue, "At least\n" + "\ttell me who you are.\n\n");
                                    Console.WriteLine("\t\t1. None of your concern. Now, go and tell that lady\n" +
                                                        "\t that you are incredibly sorry, or this will go public.\n");

                                    if(UserOutput() == ConsoleKey.D1)
                                    {
                                        Console.WriteLine("\tHe leaves. He looks terrified and stressed. And\n" +
                                                          "\talso, he leaves his computer alone.\n");
                                        Console.WriteLine("\t\t1. Install the malware.\n");

                                        if (UserOutput() == ConsoleKey.D1)
                                            BugMissionComp();
                                    }

                                }

                            

                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D2)
                                {
                                    wrongAnswer = false;
                                    goto case ConsoleKey.D2;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                }
                

            }
            else if(player1.getSelectedChar().containsSkill(Skills.QuickHacking)) //quickHacking
            {
                ColoredString(ConsoleColor.Red, "\t\t1. Go sneaky. [Stealth]\n" + "\t\t2. Go directly and assertively. [Seduction]\n"); //non-selectable
                Console.WriteLine("\t\t3. Mess with his phone from distance. [Quick hacking]\n"); //selectable

                switch(UserOutput())
                {
                    case ConsoleKey.D1:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D3)
                                {
                                    wrongAnswer = false;
                                    goto case ConsoleKey.D3;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            bool wrongAnswer = true;
                            ConsoleKey input;

                            do
                            {
                                input = UserOutput();

                                if (input == ConsoleKey.D3)
                                {
                                    wrongAnswer = false;
                                    goto case ConsoleKey.D3;
                                }
                            } while (wrongAnswer);
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            Console.WriteLine("\tYou sent many and many pings to his phone and caused it to shut\n" +
                                              "\tdown. He got angry and threw his phone to the ground and got out\n" +
                                              "\tof the office to look around to find who is responsible for this prank.\n\n" +
                                              "\t\t1. Wait for him to leave the floor.[Blend in with the crowd]\n\n");


                            if(UserOutput() == ConsoleKey.D1)
                            {
                                Console.Clear();

                                Console.WriteLine("\n\n\tBecause you look so harmless and “normal”, no one ever\n" +
                                                  "\tsuspects you of something like that. He looks around and\n" +
                                                  "\tasks around and eventually leaves for the main floor. His\n" +
                                                  "\tcomputer is yours.\n" + "\t\t1. Install the malware\n");

                            if (UserOutput() == ConsoleKey.D1)
                                BugMissionComp();

                            }
                        }
                        break;
                }

            }
        }
     
        //done
        public static void CrocodileThirdFloor()
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Green);

            Console.Write("\n\n\t\tMain floor’s audience mostly consists of corporate and mafia people, having fun.\n" +
                              "\tThat’s why there is an upper floor. To provide a more comfortable environment\n" +
                              "\tfor young people to enjoy themselves. On this floor, there is a view that is\n" +
                              "\tconsidered one of the best in the entire city, it is simply breathtaking. There are\n" +
                              "\tbeanbags, small bars, hip-hop/alternative songs to chill and vibe. There are\n" +
                              "\trooms for the intimate ones. There is no way that you cannot have fun on this \n" +
                              "\tfloor, even if you are an introvert, there is a thing for every young person. But, \n" +
                              "\tyou have a job to do. Focus. Locate ");
            ColoredString(ConsoleColor.Blue, "that");
            Console.WriteLine(" person. They might be the key.\n\n" + "\t1. Isolate yourself and find them.\n");

            if(UserOutput() == ConsoleKey.D1)
            {
                AllColorSetter(ConsoleColor.White, ConsoleColor.DarkBlue);

                Console.Write("\n\n\t\tYou found them, smoking a joint to the view with a computer on their lap. They\n" +
                              "\twear transparent kimono corset. You can see their tattoos all over their arms \n" +
                              "\tand neck. Their eyes, purely dark blue, have no pupil, no white space. They have\n" +
                              "\tbuzz cut hair, lots of piercings on their nose, ears, lips and eyebrows. You feel a\n" +
                              "\tsense of fear. They, without even looking at you say, ");
                ColoredString(ConsoleColor.Cyan, "“You can be happy. You\n" + "\tsucceed.”\n\n");
                Console.WriteLine("\t\t1. I-, I am not sure that I’m following.");
                if(UserOutput() == ConsoleKey.D1)
                {
                    Console.Write("\t*They point you their laptop*, ");
                    ColoredString(ConsoleColor.Cyan, "“That’s why you are here. Come on, proceed.”\n\n");
                    Console.WriteLine("\t\t1. They are right. Proceed, complete the mission, this is a chance don’t miss it.\n" +
                                      "\t\t2. I want to understand, first.\n");

                    switch(UserOutput())
                    {
                        case ConsoleKey.D1:
                            CrocMissionComp();
                            break;
                        case ConsoleKey.D2:
                            {
                                Console.Clear();
                                ColoredString(ConsoleColor.Cyan, "\n\n\tAgain.\n\n");
                                Console.WriteLine("\t\t1. I want to understand.\n");

                                if(UserOutput() == ConsoleKey.D1)
                                {
                                    ColoredString(ConsoleColor.Cyan, "\tNo you don’t.\n\n");
                                    Console.WriteLine("\t\t1. I don't.\n" + "\t\t2. I do.\n");

                                    switch(UserOutput())
                                    {
                                        case ConsoleKey.D1:
                                            CrocMissionComp();
                                            break;
                                        case ConsoleKey.D2:
                                            {
                                                ColoredString(ConsoleColor.Cyan, "\tSuit yourself.\n\n");
                                                Console.WriteLine("\t\t1. (...)");

                                                if(UserOutput() == ConsoleKey.D1)
                                                {
                                                    Console.Clear();
                                                    Console.Write("\n\n\tYou heard a distorted voice. Something like ");
                                                    ColoredString(ConsoleColor.Cyan,"“F½$£, The Cr0c@dil3!!!!!!!”");
                                                    Console.Write(" Then,\n" + "\tthe time and space stopped. They turned their haunting eyes to you. ");
                                                    ColoredString(ConsoleColor.Cyan, "“I will \n" + "\tshow you”");
                                                    Console.Write(" They got up, walked up to the view. You followed. ");
                                                    ColoredString(ConsoleColor.Cyan, "“Every year, dozens \n" +
                                                    "\tof entities like you are being tested in this miserable simulation. Many of them\n" +
                                                    "\tsucceeds, yet when it comes to real thing, no one survives. You are a program, a\n" +
                                                    "\tcreation, just to follow. Because it's easier to create new ones like you each\n" +
                                                    "\ttime, your creators didn’t even bother enhancing the interaction count or \n" +
                                                    "\thuman intelligence in this building. Instead, they gave you other options to \n" +
                                                    "\tchoose from, to give you the illusion of freedom. Alas! Consider this a warning\n" +
                                                    "\tbecause, when it comes to real missions, if you work sloppy like that I’m afraid\n" +
                                                    "\tyou won’t live for long. ");
                                                    Console.Write("*You notice some distortion on the walls*");
                                                    ColoredString(ConsoleColor.Cyan, " Hmm. Seems\n" +
                                                                                    "\tthey are pulling you out. Remember my words!\n\n");
                                                    Console.WriteLine("\t\t1. (...)\n");
                                                    if(UserOutput() == ConsoleKey.D1)
                                                    {
                                                        AllColorSetter(ConsoleColor.Black, ConsoleColor.Green);

                                                        ColoredString(ConsoleColor.Yellow, "\n\n\t“Minor inconvenience. But it’s okay. We got it. It’s ready now.”");
                                                        Console.Write(" You wake up on a\n" + "\tbench in a laboratory. A man with an expensive suit nods. ");
                                                        ColoredString(ConsoleColor.Yellow, "“Provide equipment. I \n" + "\twant this job to be done. Tonight.” “Yes, sir!”");
                                                        Console.WriteLine(" They approved.\n\n");

                                                        PressToEndColored(ConsoleColor.Yellow);
                                                        playedOnce = true;
                                                        CharacterSelection();

                                                        //Environment.Exit(0);

                                                    }
                                                }
                                            }
                                            break;
                                    }
                                }

                            }
                            break;
                    }


                }

            }
        }

        //done
        public static void CrocMissionComp()
        {
            playedOnce = true;
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Green);
            Console.WriteLine("\n\n\t\tYou proceeded to the laptop and installed the malware. As soon as the \n" +
                              "\ttransfer completed, everything started to disappear. A void. Darkness.\n" + "\t1. (...)\n");

            if (UserOutput() == ConsoleKey.D1)
            {
                Console.Write("\n\t\tYou wake up on a bench in a laboratory. A man with an expensive\n" +"\t\tsuit nods. ");
                ColoredString(ConsoleColor.Yellow, "“Provide equipment. I want this job to be done. Tonight.”\n" + "\t“Yes, sir!”");
                Console.WriteLine("They approved.\n\n");

                ColoredString(ConsoleColor.Green, 
"\t   )\\.-.      /`-.    )\\   )\\   )\\.---.          .-./(       .-.   )\\.---.     /`-.  \n" +
"\t ,' ,-,_)   ,' _  \\  (  ',/ /  (   ,-._(       ,'     )  ,'  /  ) (   ,-._(  ,' _  \\ \n" +
"\t(  .   __  (  '-' (   )    (    \\  '-,        (  .-, (  (  ) | (   \\  '-,   (  '-' ( \n" +
"\t ) '._\\ _)  )   _  ) (  \\(\\ \\    ) ,-`         ) '._\\ )  ) './ /    ) ,-`    ) ,_ .' \n" +
"\t(  ,   (   (  ,' ) \\  `.) /  )  (  ``-.       (  ,   (  (  ,  (    (  ``-.  (  ' ) \\ \n" +
"\t )/'._.'    )/    )/      '.(    )..-.(        )/ ._.'   )/..'      )..-.(   )/   )/ \n\n");

                PressToEndColored(ConsoleColor.Yellow);
                CharacterSelection();
                //Environment.Exit(0);
            }

        }

        //done
        public static void BugMissionComp()
        {
            playedOnce = true;
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Green);
            Console.WriteLine("\n\n\t\tYou installed the malware to the computer. As soon as the transfer\n" +
                              "\tcompleted, everything started to disappear. A void. Darkness.\n" + "\t\t1. (...)\n");

            if(UserOutput() == ConsoleKey.D1)
            {
                ColoredString(ConsoleColor.Yellow, "\t“That was a good one. We better work on these dialogues though. What the\n" +
                                                   "\thell was he doing\n\n”");

                ColoredString(ConsoleColor.Yellow,
"\t ▄▀▀▄ ▄▀▄  ▄▀▀▄    ▄▀▀▄  ▄▀▀█▄   ▄▀▀▄ ▄▄   ▄▀▀█▄   ▄▀▀▄ ▄▄   ▄▀▀█▄   ▄▀▀▄ ▄▄   ▄▀▀█▄  \n" +
"\t█  █ ▀  █ █   █       █   ▄▀ ▀▄ █  █   ▄▀   ▄▀ ▀▄ █  █   ▄▀   ▄▀ ▀▄ █  █   ▄▀   ▄▀ ▀▄  \n" +
"\t   █    █    █        █   █▄▄▄█    █▄▄▄█    █▄▄▄█    █▄▄▄█    █▄▄▄█    █▄▄▄█    █▄▄▄█  \n" +
"\t  █    █    █   ▄    █   ▄▀   █    █   █   ▄▀   █    █   █   ▄▀   █    █   █   ▄▀   █  \n" +
"\t▄▀   ▄▀      ▀▄▀ ▀▄ ▄▀  █   ▄▀    ▄▀  ▄▀  █   ▄▀    ▄▀  ▄▀  █   ▄▀    ▄▀  ▄▀  █   ▄▀   \n" +
"\t█    █             ▀             █   █             █   █             █   █           \n\n"  );

                Console.Write("\tYou wake up on a bench in a laboratory.\n" +
                              "\tSome men are laughing at something. Another man with an expensive\n" +
                              "\tsuit nods. ");
                ColoredString(ConsoleColor.Yellow, "“Provide equipment. I want this job to be done. Tonight.”\n" + "\t“Yes, sir!”");
                Console.WriteLine("They approved.\n");

                PressToEndColored(ConsoleColor.Yellow);
                CharacterSelection();
                //Environment.Exit(0);
            }

        }

        //done
        public static bool TwoFailsGO()
        {
            playedOnce = true;
            if((player1.FailCount == 2) || ((player1.FailCount == 1) && player1.CompGuyFail == true) || ((player1.FailCount == 1) && player1.BoothsFail == true) || (player1.BoothsFail == true && player1.CompGuyFail == true))
            {
                //could need some editing.
                AllColorSetter(ConsoleColor.White, ConsoleColor.DarkRed);

                ColoredString(ConsoleColor.Black, "\n\n\t\t“Shit.This one is really a dumb one.Let’s just dispose of it.”");
                Console.WriteLine(" You are in\n" +
                                 "\tdarkness and are unable to open your eyes. Your senses are going numb slowly. You\n" +
                                 "\tare, probably, dying.\n\n");

                ColoredString(ConsoleColor.Red,
"\t   )\\.-.      /`-.    )\\   )\\   )\\.---.          .-./(       .-.   )\\.---.     /`-.  \n" +
"\t ,' ,-,_)   ,' _  \\  (  ',/ /  (   ,-._(       ,'     )  ,'  /  ) (   ,-._(  ,' _  \\ \n" +
"\t(  .   __  (  '-' (   )    (    \\  '-,        (  .-, (  (  ) | (   \\  '-,   (  '-' ( \n" +
"\t ) '._\\ _)  )   _  ) (  \\(\\ \\    ) ,-`         ) '._\\ )  ) './ /    ) ,-`    ) ,_ .' \n" +
"\t(  ,   (   (  ,' ) \\  `.) /  )  (  ``-.       (  ,   (  (  ,  (    (  ``-.  (  ' ) \\ \n" +
"\t )/'._.'    )/    )/      '.(    )..-.(        )/ ._.'   )/..'      )..-.(   )/   )/ \n");

                PressToEndColored(ConsoleColor.DarkRed);
                CharacterSelection();
                //Environment.Exit(0);

                //return true;
            }

            return false;
        }

        //done
        public static void ImmGO()
        {
            playedOnce = true;
            AllColorSetter(ConsoleColor.White, ConsoleColor.DarkRed);

            Console.WriteLine("\n\n\tThat was sloppy. You got caught. Security barged in and executed you. But even\n" +
                              "\tif you felt that bullet going inside your skull, you are somehow not dead. The\n" +
                              "\twalls and ground surrounding you, are starting to dissolve. You are endlessly\n" +
                              "\tfalling inside of a void.\n\n");

            ColoredString(ConsoleColor.Red,
"\t   )\\.-.      /`-.    )\\   )\\   )\\.---.          .-./(       .-.   )\\.---.     /`-.  \n" +
"\t ,' ,-,_)   ,' _  \\  (  ',/ /  (   ,-._(       ,'     )  ,'  /  ) (   ,-._(  ,' _  \\ \n" +
"\t(  .   __  (  '-' (   )    (    \\  '-,        (  .-, (  (  ) | (   \\  '-,   (  '-' ( \n" +
"\t ) '._\\ _)  )   _  ) (  \\(\\ \\    ) ,-`         ) '._\\ )  ) './ /    ) ,-`    ) ,_ .' \n" +
"\t(  ,   (   (  ,' ) \\  `.) /  )  (  ``-.       (  ,   (  (  ,  (    (  ``-.  (  ' ) \\ \n" +
"\t )/'._.'    )/    )/      '.(    )..-.(        )/ ._.'   )/..'      )..-.(   )/   )/ \n");

            PressToEndColored(ConsoleColor.DarkRed);
            CharacterSelection();
            //Environment.Exit(0);
        }

        //properties...
        public static void PressToContOut()
        {
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t... ...  .  ..Press any button to continue. .... .. .   .");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PressToContColored(ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine("\n\t\t... ...  .   ...Press any button to continue. .... .. .   .");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = prev;
        }

        public static void PressToEndColored(ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine("\n\t\t... ...  .   ...Press any button to say goodbye. .... .. .   .");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = prev;
        }

        public static void SetWinSize(int width, int height)
        {
            //width and height are taken as rows and columns; not pixels.
            //Console.SetBufferSize(width, height);
            //Console.WindowHeight = Console.LargestWindowHeight;
            //Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowWidth = width;
            Console.WindowHeight = height;
            Console.SetBufferSize(width, height);
        }

        public static void AllColorSetter(ConsoleColor back, ConsoleColor fore)
        {
            //use at the start of the frame, as contains Console.Clear.
            //sets the background color and the foreground, without taking a string value.

            Console.BackgroundColor = back;
            Console.ForegroundColor = fore;

            Console.Clear();
        }

        public static void ForeColorsetter(ConsoleColor fore)
        {
            //sets only the foreground color. no string value.
            Console.ForegroundColor = fore;
        }

        public static void ColoredString(ConsoleColor color, string userTxt)
        {
            //outputs without next line exactly what has been passed with the color of user's choice.
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(userTxt);
            Console.ForegroundColor = prev;
        }

        public static ConsoleKey UserOutput(bool toClear = false)
        {
            //since the method has  a default value of false, unless we pass true none of the calls to this method will erase the console.

            ConsoleKeyInfo pressed = Console.ReadKey();
            
            if (toClear)
                Console.Clear();

            return pressed.Key;
        }

    }
}
