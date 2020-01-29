using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_Who_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; //This declares the name variable
            string[] easyQuestions = new string[] { "True or false – There have been 6 Doctors so far", "How many hearts does the Doctor have (use the number pad)?", "What is the Doctor’s species?", "What is the name of the Doctor’s time machine? The. . .", "Which two words followed the 9th Doctor and Rose?", "What is the battle cry of the Daleks?", "Who was the ninth Doctor’s first companion?", "Who played the 4th Doctor?", "How many companions has the 13th Doctor currently got (use the number pad)?", "What neck accessory did the eleventh Doctor used to wear?" };
            //Above is the easy set of questions
            string[] easyAnswers = new string[] { "FALSE", "2", "TIME LORD", "TARDIS", "BAD WOLF", "EXTERMINATE", "ROSE TYLER", "TOM BAKER", "3", "BOW TIE" };
            //Above is the answers to the questions in the easy set

            string[] mediumQuestions = new string[] { "What planet does the Doctor come from?", "Which planet do Daleks come from?", "What was the tenth Doctor’s last line?", "True or false – the first Doctor had to regenerate because he was poisoned by radiation?", "What helped the Doctor recover from his 9th regeneration? A) Toast, B) Tea or C) Banana?", "What is supposed to be used to disguise the TARDIS to allow it to fit in with its surroundings? A. . .", "What was the name of the 13th Doctor’s first episode?", "What was the name of the Doctor Who episode that was on 1st January 2019?", "Who was the first actor to play the Doctor?", "Who did the 13th Doctor think is going to run for president in 2020?" };
            //Above is the medium set of questions
            string[] mediumAnswers = new string[] { "GALLIFREY", "SKARO", "I DON'T WANT TO GO", "FALSE", "B", "CHAMELEON CIRCUIT", "THE WOMAN WHO FELL TO EARTH", "RESOLUTION", "WILLIAM HARTNELL", "ED SHEERAN" };
            //Above is the answers to the questions in the medium set, 

            string[] hardQuestions = new string[] {"Which episode did the Weeping Angels first appear in?", "In which episode was Torchwood first mentioned?", "What does K-9 call the Doctor?", "What is the Doctor known as in Dalek legend? The. . .", "Which enemy planned to enslave the Earth’s people in “The Christmas Invasion”? The. . .", "What does “TARDIS” stand for?", "Which year do the Doctor and Rose go back to in the episode “Tooth and Claw”?", "Who invented the Cybermen?", "When was the Torchwood Institute set up?", "Which episode included Brittney Spears’ track “Toxic”?" };
            //Above is the hard set of questions
            string[] hardAnswers = new string[] {"BLINK", "THE CHRISTMAS INVASION", "MASTER", "ONCOMING STORM", "SYCORAX", "TIME AND RELATIVE DIMENSION IN SPACE", "1879", "JOHN LUMIC", "1879", "THE END OF THE WORLD"};
            //Above is the answers to the questions in the hard set

            string difficulty; //This declares the difficulty variable
            string userAnswer; //This declares the variable that stores the user's answer
            string userAnswerUpper; //This declares the variable that stores the user's answer in upper case to allow their input to be compared with the answers

            int easyHighScore = 0, mediumHighScore = 0, hardHighScore = 0; //This declares the high score variables

            string playQuestion; //This declares the variable that will store the user's answer of whether they want to play again or not
            bool play = true; //This declares the variable that is used in the loop to define whether it carries on through the quiz or not looping or not

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

            Console.ForegroundColor = ConsoleColor.White; //This changes the font colour to white
            Console.Write("Enter your name: "); //This output prompts the user to enter their name
            name = Console.ReadLine(); //The user's answer is stored in the name variable

            

            Console.ForegroundColor = ConsoleColor.Black; //This changes the font colour to dark grey
            Console.WriteLine("Hello " + name +"!"); //This says hello to the user

            while (play == true) //This loops while the player wants to play the game
            {
                Console.WriteLine("High score for the easy section: " + easyHighScore); //This outputs the high scores for the easy section
                Console.WriteLine("High score for the medium section: " + mediumHighScore); //This outputs the high scores for the medium section
                Console.WriteLine("High score for the hard section: " + hardHighScore); //This outputs the high scores for the hard section
                int score = 0; //This declares the score variable
                Console.ForegroundColor = ConsoleColor.White; //This changes the font colour to white
                Console.Write("Please enter the difficulty (easy, medium or hard): "); //This prompts the user to input whether they want the easy, medium or hard questions
                difficulty = Console.ReadLine(); //The user's answer is stored in the difficulty variable
                
                if (difficulty == "easy" || difficulty == "EASY" || difficulty == "Easy") //This selects the easy section
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; //The font colour is changed to cyan
                    Console.Write("\n"); //A new line is created
                    Console.WriteLine("You have selected the easy questions. Allons-y! \n"); //This shows the section that has been selected and starts a new line
                    for (int counter = 0; counter < 10; counter++) //This loops 10 times
                    {
                        Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                        Console.WriteLine(easyQuestions[counter]); //This outputs the question
                        Console.ForegroundColor = ConsoleColor.White; //This changes the font colour to white
                        Console.Write("Please enter your answer: "); //This prompts the user for an answer
                        userAnswer = Console.ReadLine(); //The user's answer is stored in the userAnswer variable
                        userAnswerUpper = userAnswer.ToUpper(); //The user's answer will be converted into uppercase

                        if (userAnswerUpper == easyAnswers[counter]) //This is selected if the user's uppercase answer matches the correct answer in the array
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan; //This changes the font colour to cyan
                            Console.WriteLine("Correct!\n"); //This shows the user was correct
                            score = score + 1; //This adds one to the user's score

                            if (score > easyHighScore)
                            {
                                easyHighScore = score; //Updates the high score for the easy section
                            }
                        }

                        else //This is selected if the answer is wrong
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed; //The font colour changes to dark red
                            Console.WriteLine("Incorrect -  the answer is " + easyAnswers[counter] + "\n"); //This outputs that the user is incorrect and shows the correct answer
                        }
                        
                    }
                }

                else if (difficulty == "medium" || difficulty == "MEDIUM" || difficulty == "Medium") //This selects the medium section
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow; //The font colour changes to dark yellow
                    Console.Write("\n"); //A new line is created
                    Console.WriteLine("You have selected the medium questions. Allons-y! \n"); //This shows the section that has been selected and starts a new line
                    
                    for (int counter = 0; counter < 10; counter++) //This loops 10 times
                    {
                        Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                        Console.WriteLine(mediumQuestions[counter]); //This outputs the question
                        Console.ForegroundColor = ConsoleColor.White; //The font colour changes to white
                        Console.Write("Please enter your answer: "); //This prompts the user for an answer
                        userAnswer = Console.ReadLine(); //The user's answer is stored in the userAnswer variable
                        userAnswerUpper = userAnswer.ToUpper(); //The user's answer will be converted into uppercase

                        if (userAnswerUpper == mediumAnswers[counter])//This is selected if the user's uppercase answer matches the correct answer in the array
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;//The font colour changes to cyan
                            Console.WriteLine("Correct!\n");//This shows the user was correct
                            score = score + 1; //This adds one to the user's score

                            if (score > mediumHighScore)
                            {
                                mediumHighScore = score; //Updates the high score for the medium section
                            }
                        }


                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed; //The font colour changes to dark red
                            Console.WriteLine("Incorrect -  the answer is " + mediumAnswers[counter] + "\n"); //This outputs that the user is incorrect and shows the correct answer
                        }
                        
                    }
                    
                }

                else if (difficulty == "hard" || difficulty == "HARD" || difficulty == "Hard") //This selects the hard section
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; //The font colour changes to dark red
                    Console.Write("\n"); //A new line is created
                    Console.WriteLine("You have selected the hard questions. Allons-y! \n"); //This shows the section that has been selected and starts a new line
                    
					for (int counter = 0; counter < 10; counter++)//This loops 10 times
                    {
                        Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                        Console.WriteLine(hardQuestions[counter]); //This outputs the question
                        Console.ForegroundColor = ConsoleColor.White; //The font colour changes to white
                        Console.Write("Please enter your answer: "); //This prompts the user for an answer
                        userAnswer = Console.ReadLine(); //The user's answer is stored in the userAnswer variable
                        userAnswerUpper = userAnswer.ToUpper(); //The user's answer will be converted into uppercase

                        if (userAnswerUpper == hardAnswers[counter])//This is selected if the user's uppercase answer matches the correct answer in the array
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan; //The font colour changes to cyan
                            Console.WriteLine("Correct!\n"); //This shows the user was correct
                            score = score + 1; //This adds one to the user's score

                            if (score > mediumHighScore)
                            {
                                hardHighScore = score; //Updates the high score for the hard section
                            }
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed; //The font colour changes to dark red
                            Console.WriteLine("Incorrect -  the answer is " + hardAnswers[counter] +"\n"); //This outputs that the user is incorrect, shows the correct answer and creates a new line
                        }
                        
                    }

                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                    Console.WriteLine("You needed to select easy, medium or hard."); //This shows the user what they should have selected - their input did not match
                }

                Console.WriteLine("Let's see how you did " + name + ". . ."); //This sentence is outputted before the user finds out what their result is
                EndResult(score); //This calls the endResult function with score in the parameter, enabling the value of score to be used in the function
                Console.ForegroundColor = ConsoleColor.White; //The font colour changes to white
                Console.Write("Do you want to play again? y/n "); //This asks whether the user wants to play again
                playQuestion = Console.ReadLine(); //The user gives an answer for the previous question

                if (playQuestion == "y" || playQuestion == "Y" || playQuestion == "yes") //This block of code if the user types in "y", "Y" or "yes"
                {
                    play = true; //The bool variable "play" is assigned as true, meaning the while loop will loop again
                }

                else //This block of code is executed if their answer is not "y", "Y" or "yes"
                {
                    play = false; //The bool variable "play" assigned is assigned as false, meaning the while loop is not looping again
                }

                Console.ForegroundColor = ConsoleColor.White; //The font colour changes to white
            }
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("This will be regenerating soon with more questions, more flexibility in your answers and, of course, more fun!");
            Console.Write("Press a key to exit "); //This prompts the user to press a key to exit. This is shown when play = false, so the while loop stops
            Console.ReadKey(); //This closes the program when the user presses a key
        }
        static void EndResult(double scoreParameter) //This is the endResult function that was called in the Main function
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //The font colour changes to yellow
            Console.WriteLine("Score: " + scoreParameter); //This outputs the user's score. Transferred from main when the function was called
            double percentage; //Declares the percentage variable
            percentage = (scoreParameter / 10) * 100; //Works out the percentage that the user got correct
            Console.WriteLine("Percentage: " + percentage + "%"); //Outputs the user's percentage
			
            if (percentage >= 80)
            {
                Console.WriteLine("Absolutely Fantastic!!! \n"); //This is outputted if the user got 80% or above 
            }

            else if (percentage >= 60)
            {
                Console.WriteLine("Brilliant\n"); //This is outputted if the user got 60% or above
            }

            else if (percentage >= 40)
            {
                Console.WriteLine("Molto Bene!\n"); //This is outputted if the user got 40% or above
            }

            else if (percentage >= 20)
            {
                Console.WriteLine("Meh...\n"); //This is outputted if the user got 20% or above
            }
            else
            {
                Console.WriteLine("Worth a try though.\n"); //This is outputted if the user got less than (and not including)20%
            }
        }
    }
}
