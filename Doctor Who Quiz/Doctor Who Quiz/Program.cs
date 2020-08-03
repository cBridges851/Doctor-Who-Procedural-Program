using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_Who_Quiz {
    class Program {
        static void Main (string[] args) {
            var currentPlayer = new Player();
            currentPlayer.IndividualEasyHighScore = 0;
            currentPlayer.IndividualMediumHighScore = 0;
            currentPlayer.IndividualHardHighScore = 0;

            Console.Write("Enter your name: ");
            currentPlayer.Name = Console.ReadLine();

            Console.WriteLine("Hello {0}!", currentPlayer.Name);
            

            Console.BackgroundColor = ConsoleColor.Blue; //This changes the background colour to blue
            Console.Clear(); //This leads to all of the background to blue


            Console.ForegroundColor = ConsoleColor.Black; //This changes the font colour to grey
            Console.WriteLine("          ######      #####      #####  ########  #####    #######            ");
            Console.WriteLine("          ##   ##    ##   ##    ##   ##    ##    ##   ##   ##    ##          ");
            Console.WriteLine("          ##    ##  ##     ##  ##          ##   ##     ##  ##    ##         ");
            Console.WriteLine("          ##    ##  ##     ##  ##          ##   ##     ##  ## ###          ");
            Console.WriteLine("          ##   ##    ##   ##    ##   ##    ##    ##   ##   ##    ##       ");
            Console.WriteLine("############ ########### ########################### ########    ############ ");
            Console.WriteLine("                                                                           ## ");
            Console.WriteLine(" ############     #####     ###########     #####################         ##  ");
            Console.WriteLine(" ##     #####     #####     ###########     #######################       ##  ");
            Console.WriteLine("  ##     #####   #######   #####  #####     #####    ###############     ##   ");
            Console.WriteLine("  ##     #####   #######   #####  #####     #####   #####       #####    ##   ");
            Console.WriteLine("   ##     ##### ######### #####   #####     #####  #####         #####  ##    ");
            Console.WriteLine("   ##     ##### ######### #####   ###############  #####         #####  ##    ");
            Console.WriteLine("    ##     ######### #########    ###############  #####         ##### ##     ");
            Console.WriteLine("    ##     ######### #########    #####     #####  #####         ##### ##     ");
            Console.WriteLine("     ##     #######   #######     #####     #####   #####       ##### ##      ");
            Console.WriteLine("     ##     #######   #######     #####     #####    ###############  ##      ");
            Console.WriteLine("      ##     #####     #####      #####     #####     #############  ##       ");
            Console.WriteLine("      ##     #####     #####      #####     #####       #########    ##       ");
            Console.WriteLine("       ##                                                           ##        ");
            Console.WriteLine("       ###############################################################\n");

            Console.WriteLine("                     #####    ##     ## ###### #########   ");
            Console.WriteLine("                   ##     ##  ##     ##   ##          # ");
            Console.WriteLine("                   ##     ##  ##     ##   ##       ###");
            Console.WriteLine("                   ##   # ##  ##     ##   ##     ##");
            Console.WriteLine("                   ##    ##   ##     ##   ##    #");
            Console.WriteLine("                     #### ###   #####   ###### ######### \n");

            Console.WriteLine("        ----------------------------------------------------------------");
            Console.WriteLine("                                  Version 1.0                           ");
            Console.WriteLine("        ----------------------------------------------------------------\n");
            //Above is the header

            
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("This will be regenerating soon with more questions, more flexibility in your answers and, of course, more fun!");
            Console.Write("Press a key to exit "); //This prompts the user to press a key to exit. This is shown when play = false, so the while loop stops
            Console.ReadKey(); //This closes the program when the user presses a key
        }
    }
}
