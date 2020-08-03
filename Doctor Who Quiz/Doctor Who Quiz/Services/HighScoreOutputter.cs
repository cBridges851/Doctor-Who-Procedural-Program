using System;
using System.Collections.Generic;
using System.Text;

namespace Doctor_Who_Quiz.Services {
    class HighScoreOutputter {
        public void Output (Player currentPlayer) {
            Console.WriteLine("High score for the easy section: " + currentPlayer.IndividualEasyHighScore); //This outputs the high scores for the easy section
            Console.WriteLine("High score for the medium section: " + currentPlayer.IndividualMediumHighScore); //This outputs the high scores for the medium section
            Console.WriteLine("High score for the hard section: " + currentPlayer.IndividualHardHighScore); //This outputs the high scores for the hard section
        }
    }
}
