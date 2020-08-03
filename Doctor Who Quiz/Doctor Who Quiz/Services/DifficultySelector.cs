using System;
using System.Collections.Generic;
using System.Text;

namespace Doctor_Who_Quiz {
    class DifficultySelector {

        public void SelectDifficulty (Player currentPlayer) {
            string[] easyQuestions = new string[] { "True or false – There have been 6 Doctors so far", "How many hearts does the Doctor have (use the number pad)?", "What is the Doctor’s species?", "What is the name of the Doctor’s time machine? The. . .", "Which two words followed the 9th Doctor and Rose?", "What is the battle cry of the Daleks?", "Who was the ninth Doctor’s first companion?", "Who played the 4th Doctor?", "How many companions has the 13th Doctor currently got (use the number pad)?", "What neck accessory did the eleventh Doctor used to wear?" };
            //Above is the easy set of questions
            string[] easyAnswers = new string[] { "FALSE", "2", "TIME LORD", "TARDIS", "BAD WOLF", "EXTERMINATE", "ROSE TYLER", "TOM BAKER", "3", "BOW TIE" };
            //Above is the answers to the questions in the easy set

            string[] mediumQuestions = new string[] { "What planet does the Doctor come from?", "Which planet do Daleks come from?", "What was the tenth Doctor’s last line?", "True or false – the first Doctor had to regenerate because he was poisoned by radiation?", "What helped the Doctor recover from his 9th regeneration? A) Toast, B) Tea or C) Banana?", "What is supposed to be used to disguise the TARDIS to allow it to fit in with its surroundings? A. . .", "What was the name of the 13th Doctor’s first episode?", "What was the name of the Doctor Who episode that was on 1st January 2019?", "Who was the first actor to play the Doctor?", "Who did the 13th Doctor think is going to run for president in 2020?" };
            //Above is the medium set of questions
            string[] mediumAnswers = new string[] { "GALLIFREY", "SKARO", "I DON'T WANT TO GO", "FALSE", "B", "CHAMELEON CIRCUIT", "THE WOMAN WHO FELL TO EARTH", "RESOLUTION", "WILLIAM HARTNELL", "ED SHEERAN" };
            //Above is the answers to the questions in the medium set, 

            string[] hardQuestions = new string[] { "Which episode did the Weeping Angels first appear in?", "In which episode was Torchwood first mentioned?", "What does K-9 call the Doctor?", "What is the Doctor known as in Dalek legend? The. . .", "Which enemy planned to enslave the Earth’s people in “The Christmas Invasion”? The. . .", "What does “TARDIS” stand for?", "Which year do the Doctor and Rose go back to in the episode “Tooth and Claw”?", "Who invented the Cybermen?", "When was the Torchwood Institute set up?", "Which episode included Brittney Spears’ track “Toxic”?" };
            //Above is the hard set of questions
            string[] hardAnswers = new string[] { "BLINK", "THE CHRISTMAS INVASION", "MASTER", "ONCOMING STORM", "SYCORAX", "TIME AND RELATIVE DIMENSION IN SPACE", "1879", "JOHN LUMIC", "1879", "THE END OF THE WORLD" };
            //Above is the answers to the questions in the hard set

            Console.Write("Please enter the difficulty (easy, medium or hard): "); //This prompts the user to input whether they want the easy, medium or hard questions
            var difficulty = Console.ReadLine(); //The user's answer is stored in the difficulty variable
            var score = 0;

            if (difficulty.ToLower() == "easy") {
                Console.ForegroundColor = ConsoleColor.Cyan; //The font colour is changed to cyan
                Console.Write("\n"); //A new line is created
                Console.WriteLine("You have selected the easy questions. Allons-y! \n"); //This shows the section that has been selected and starts a new line
                for (int counter = 0; counter < 10; counter++) //This loops 10 times
                {
                    Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                    Console.WriteLine(easyQuestions[counter]); //This outputs the question
                    Console.ForegroundColor = ConsoleColor.White; //This changes the font colour to white
                    Console.Write("Please enter your answer: "); //This prompts the user for an answer
                    var userAnswer = Console.ReadLine(); //The user's answer is stored in the userAnswer variable
                    var userAnswerUpper = userAnswer.ToUpper(); //The user's answer will be converted into uppercase

                    if (userAnswerUpper == easyAnswers[counter]) //This is selected if the user's uppercase answer matches the correct answer in the array
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan; //This changes the font colour to cyan
                        Console.WriteLine("Correct!\n"); //This shows the user was correct
                        score = score + 1; //This adds one to the user's score

                        if (score > currentPlayer.IndividualEasyHighScore) {
                            currentPlayer.IndividualEasyHighScore = score; //Updates the high score for the easy section
                        }
                    } else //This is selected if the answer is wrong
                      {
                        Console.ForegroundColor = ConsoleColor.DarkRed; //The font colour changes to dark red
                        Console.WriteLine("Incorrect -  the answer is " + easyAnswers[counter] + "\n"); //This outputs that the user is incorrect and shows the correct answer
                    }

                }
            } else if (difficulty.ToLower() == "medium") {
                Console.ForegroundColor = ConsoleColor.DarkYellow; //The font colour changes to dark yellow
                Console.Write("\n"); //A new line is created
                Console.WriteLine("You have selected the medium questions. Allons-y! \n"); //This shows the section that has been selected and starts a new line

                for (int counter = 0; counter < 10; counter++) //This loops 10 times
                {
                    Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                    Console.WriteLine(mediumQuestions[counter]); //This outputs the question
                    Console.ForegroundColor = ConsoleColor.White; //The font colour changes to white
                    Console.Write("Please enter your answer: "); //This prompts the user for an answer
                    var userAnswer = Console.ReadLine(); //The user's answer is stored in the userAnswer variable
                    var userAnswerUpper = userAnswer.ToUpper(); //The user's answer will be converted into uppercase

                    if (userAnswerUpper == mediumAnswers[counter])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;//The font colour changes to cyan
                        Console.WriteLine("Correct!\n");//This shows the user was correct
                        score = score + 1; //This adds one to the user's score

                        if (score > currentPlayer.IndividualMediumHighScore) {
                            currentPlayer.IndividualMediumHighScore = score; //Updates the high score for the medium section
                        }
                    } 
                    else {
                        Console.ForegroundColor = ConsoleColor.DarkRed; //The font colour changes to dark red
                        Console.WriteLine("Incorrect -  the answer is " + mediumAnswers[counter] + "\n"); //This outputs that the user is incorrect and shows the correct answer
                    }
                } 
                else if (difficulty.ToLower() == "hard") 
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
                        var userAnswer = Console.ReadLine(); //The user's answer is stored in the userAnswer variable
                        var userAnswerUpper = userAnswer.ToUpper(); //The user's answer will be converted into uppercase

                        if (userAnswerUpper == hardAnswers[counter])//This is selected if the user's uppercase answer matches the correct answer in the array
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan; //The font colour changes to cyan
                            Console.WriteLine("Correct!\n"); //This shows the user was correct
                            score = score + 1; //This adds one to the user's score

                            if (score > currentPlayer.IndividualHardHighScore) 
                                {
                                currentPlayer.IndividualHardHighScore = score; //Updates the high score for the hard section
                            }
                        } 
                        else {
                            Console.ForegroundColor = ConsoleColor.Black; //The font colour changes to dark grey
                            Console.WriteLine("You needed to select easy, medium or hard."); //This shows the user what they should have selected - their input did not match
                        }
                    }
                }
            }
        }
    }
}
