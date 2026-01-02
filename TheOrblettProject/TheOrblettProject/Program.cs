using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace TheOrblettProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NAME = "Orion";
            int REP = 0; //general reputation
            int REP2 = 0; //Reputation with CAPTAIN
            int Health = 0; //dont die
            //
            GAMEINTRO();
            //
            Console.WriteLine("\n~~~\n");
            Console.WriteLine("[THE ORBLETT PROJECT - a text-based adventure]\nBy Olisun.\nPress ENTER to begin.");
            Console.ReadLine();
            Console.WriteLine("~~~\n");

            //GAME MAIN!
            Console.Write("You awoke in your cabin to the sound of knocking at your door.\nYou look around, the room only newly familiar. You joined the Orblett ACCEL team only yesterday, with today being your first real day of work.\n");
            Console.WriteLine("[CAPTAIN]: Wakey wakey new recruit! Time to get moving, kay?");
            Console.WriteLine("\n [[Enter 'OK' to 'wakey wakey']]:");
            string FILLER = Console.ReadLine();
            if (FILLER == "OK" || FILLER == "ok" || FILLER == "Ok")
            {
                REP++;
                Console.WriteLine("You jump out of bed, swiping your hand at the side of the door.\nIt opens, and you're met with your team captain- coincidentally, really, named Captain; A green boy, slightly taller than you- his uniform only slightly fancier than yours.\nYou'd heard about him before, he was considered the most perfect Orblett of the current century- kind, efficient, smart.\nYou were admittedly a little jealous at such a title, but it couldn't be helped.");
                Console.WriteLine("[CAPTAIN]: There you are! 'hope you rested well.");
                Console.ReadLine();
                Console.WriteLine("You nodded, fixing your uniform.");
            }
            else
            {
                Console.WriteLine("..."); Thread.Sleep(1000); Console.WriteLine("After a moment, the door opened. Your Captain entered with a soft expression.");
                Console.WriteLine("[Captain]: Hey, there you are! First day is always the scariest, I know. But...\n[CAPTAIN]: you gotta start at some point!");
                Console.ReadLine();
                Console.WriteLine("You reluctantly nodded, leaving your bed to meet him-\nYour captain- actually named Captain- was a green boy, slightly taller than you- his uniform only slightly fancier than yours.\nYou'd heard about him before, he was considered the most perfect Orblett of the current century- kind, efficient, smart.\nYou were admittedly a little jealous at such a title, but it couldn't be helped");
            }
            Console.WriteLine("[Captain]: take this, I believe they forgot to give this to you yesterday.");
            Console.WriteLine("Captain untucked a folder from under his arm and held it out to you.\nYou took it, examining it curiously.\nIt was a white binder, the contents included a prospectus, a pamphlet on ACCEL history and some other, boring general stuff. Like paperwork.\n\nThe label on the cover read your name.\nYour name, of course, being...\n    [[Please enter your name!]]");
            
            NAME = Console.ReadLine();
            Console.WriteLine("You entered: "+NAME+"\nIs this correct?\n    [[ENTER 'Y' or 'N']]");
            FILLER = Console.ReadLine();
            while (FILLER == "N" || FILLER == "n")
            {
                Console.WriteLine(" [[Please enter your name!]]");
                NAME = Console.ReadLine();
                Console.WriteLine("You entered: " + NAME + "\nIs this correct?\n    [[ENTER 'Y' or 'N']]");
                FILLER = Console.ReadLine();
            }

            if (NAME == "Orion")
            {
                REP++;
                REP2 = REP2 + 3;
            }

            Console.WriteLine("[CAPTAIN]: "+NAME+", I look forward to working with you!");
            Console.ReadLine();
            Console.WriteLine("You nod and give him your thanks.");
            Console.WriteLine("[CAPTAIN]: Come, we'll introduce you to everyone then head to breakfast! Everyone's waiting for you in the hangar right now.");
            Console.WriteLine("He looked around your cabin a moment, smiling before turning and gesturing for you to follow him out.\nWhen you did so, the cabin door closed behind you.");
            Console.ReadLine();
            Console.WriteLine("The dormitory hallways were lined with metals- above you were exposed tubes and foil pipes.\nStill, it remained fancy and impressive to you as your standards were on the floor, having lived your life amongst water wells and crop fields.\nYou and Captain turned a corner before he spoke again.");
            Console.WriteLine("[CAPTAIN]: just to jog your memory a bit, all you'll be doing for now is going around and assisting your fellow Orbletts on the ship. Think, like, an everythingman!");
            Console.ReadLine();
            Console.WriteLine("You nodded.");
            Console.WriteLine("[CAPTAIN]: Today, after introductions and breakfast, you'll be assigned to help with the hangar, the medic ward and finally the control room.");
            Thread.Sleep(5000);
            Console.WriteLine("[CAPTAIN]: Don't worry, i'll be with you most of the day to supervise you.");
            Console.WriteLine("You and Captain turned another corner, the corridor splitting into two different paths.\nIn the middle was a set of double doors labelled 'spacecraft hangar'.\nBoth you and Captain opened your mouths to speak again when a loud BANG! caught you off guard.");
            Console.ReadLine();
            Console.WriteLine("You looked between eachother, confused before hurriedly heading inside.");
            Console.ReadLine();

            Console.WriteLine("End of Build 1");
        }



        //
        static void GAMEINTRO()
        {
            Console.Write("Welcome to the Orblett Project DEMO! [Build 1]\nCreated by Olisun\n//\nPlease abide by the game's instructions as to not break the game, there are no saves and errors will result in starting from the beginning.\nThank you!\n[In areas with no input direction, please just press enter to continue.]");
            Console.ReadLine();
            Console.WriteLine("\nWould you like to skip the intro?\n  [[ENTER 'Y' or 'N']]:");
            string FILLER = Console.ReadLine();
            if (FILLER == "N" || FILLER == "n")
            {
                INTRO();
            }
        }
        static void INTRO()
        {
            Console.WriteLine("//\nThe Orbletts are a peaceful race.\nBoth tribal and advanced.\nTheir fleets conquer and live amongst foreign galaxies and stars.");
            Console.ReadLine();
            Console.WriteLine("Their colonies however, are left to fend with spears and shields.\nTheir purpose: to produce. And to mine. And to grow.");
            Console.ReadLine();
            Console.WriteLine("The arguably better life is considered on their ships, in uniform, amongst the high and mighty Accel Squads\n(Accel Squads: the exploration and colonization teams)\nAnd so you, a little farmer Orblett, dropped your woven baskets and studied your ass off for a seat on the next arriving ship...");
            Console.ReadLine();
            Console.WriteLine("Your nights were spent face-first in a revision book. When you weren't hunting, you were working out.\nFinally, you did the interview. You did the physical challenge. And you did the final exam.");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("A letter at your door.");
            Console.ReadLine();
            Console.WriteLine("You open it with caution, it reads:\n'CONGRATULATIONS!\nYou are our newest trainee! From applications in the millions, you've been selected to join the ACCEL team for your intellegence and skills.\nPlease prepare a bag and await your pickup...'");
            Console.ReadLine();
            Console.WriteLine("OH MY GOD YOU DID IT! YOU ESCAPED THE DECCEL LIFE!\n(DECCEL: Orbletts who live domestic lives on planets)\nYou could hardly believe it!\n\nThe day the ship came and you boarded was a day you'd never forget- it was everything you imagined it was-\nWhite uniforms. Clean halls. Fancy, modern food.");
            Console.ReadLine();
            Console.WriteLine("You were shown your cabin, immediately dropping into your bunk and nestling up amongst the puffy duvet.\nYou drifted off to sleep, excited for your first set of tasks the next day...");
            Console.ReadLine();
        }
    }
}
