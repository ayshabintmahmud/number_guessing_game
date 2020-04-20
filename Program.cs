using System;

namespace numberguessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int chooselevel = 0;   //variable that allows user choose level from list
            int guesseasy = 0;   // Variable that gives chances for 6guesses for easy level
            int guessTryEasy= 6;      //variable that stores number of guesses in easy level
            int guessTryMedium= 4;     //variable that stores number of guesses in medium level
            int guessTryHard= 3;       //variable that stores number of guesses in hard level
            int easy = 10; //variable with the number to guess against for easy level
            int medium = 15; //variable with the number to guess against for medium level
            int hard = 36;     //variable with the number to guess against for hard level
           // String guess ="";
             int guessMedium = 0;
             int guessHard = 0;
            //If user enters anything other than number, user should be told

            Console.WriteLine("Welcome to Number Guessing Game");
            Console.WriteLine("Select Level Below:");
     
            //printing out levels and comand for user to  access each level

            string[] level = {"\n press 1 for Easy Level.", "\nPress 2 for Medium Level.","\nPress 3 for Hard Level.","",};
            
            Console.WriteLine(level[0]);
            Console.WriteLine(level[1]);
            Console.WriteLine(level[2]);
            Console.WriteLine(level[3]);


            chooselevel = int.Parse(Console.ReadLine());
            
    /*  ****** Proceess for user game when he choose easy level ******   */
            if (chooselevel == 1)
            {
                Console.WriteLine("Welcome to Easy Level: You have to guess a number from 1 to 10. And you have 6 guesses");
                Console.WriteLine("Go Ahead! Guess the number: ");
                    guesseasy = int.Parse(Console.ReadLine());
                    //if (!int.TryParse(guess, out easy)) {
           // Console.WriteLine(" That is not a number");
               //     }
                    if (guesseasy != easy){
                    guessTryEasy--;
                    Console.WriteLine("That was wrong! Guess again you have " + guessTryEasy +" more guesses left.");
                    }else {
                         Console.WriteLine("You got it right! That was too Quick. Congratulations!");

                    }
                    
                    if (guesseasy != easy){
                        while(guessTryEasy >= 1){
                        Console.WriteLine("Guess the number Again: ");
                        guesseasy = int.Parse(Console.ReadLine());
                        guessTryEasy--;
                        Console.WriteLine("That was wrong! Guess again you have " + guessTryEasy +" more guesses left.");
                        if(guesseasy > 10){
                            Console.WriteLine("Please Choose Number only from 1-10 ");
                            Console.WriteLine("Guess the number Again: ");
                            guesseasy = int.Parse(Console.ReadLine());
                            guessTryEasy--;
                            Console.WriteLine("That was wrong! Guess again you have " + guessTryEasy +" more guesses left.");
                        
                        } else if (guesseasy == easy){
                        Console.WriteLine("You got it right! Congratulations!");
                        break;
                    }else if (guessTryEasy == 0){
                            Console.WriteLine("You have Used up all your chance. \n GAME OVER!!!");

                        }

                    } 
                    }
                    
                }



                /*  ****** Proceess for user game when he choose medium level ******   */

                else if (chooselevel == 2)
            {
                  Console.WriteLine("Welcome to Medium Level: You have to guess a number from 1 to 20. And you have 4 guesses");
                Console.WriteLine("Go Ahead! Guess the number: ");
                    guessMedium = int.Parse(Console.ReadLine());
                    if (guessMedium != medium){
                    guessTryMedium--;
                    Console.WriteLine("That was wrong! Guess again you have " + guessTryMedium +" more guesses left.");
                    } else{
                         Console.WriteLine("You got it right! That was too Quick. Congratulations!");

                    }
                    
                    if (guessMedium != medium){
                        while(guessTryMedium >= 1){
                        Console.WriteLine("Guess the number Again: ");
                        guessMedium = int.Parse(Console.ReadLine());
                        guessTryMedium--;
                        Console.WriteLine("That was wrong! Guess again you have " + guessTryMedium +" more guesses left.");
                        if(guessMedium > 20){
                            Console.WriteLine("Please Choose Number only from 1-20");
                            Console.WriteLine("Guess the number Again: ");
                            guessMedium = int.Parse(Console.ReadLine());
                            guessTryMedium--;
                            Console.WriteLine("That was wrong! Guess again you have " + guessTryMedium +" more guesses left.");
                        
                        }else if (guessMedium == medium){
                        Console.WriteLine("You got it right! Congratulations!");
                        break;
                    } else if (guessTryMedium == 0){
                            Console.WriteLine("You have Used up all your chance. \n GAME OVER!!!");

                        }
                    
                    }

                    }    
            }




      /*  ****** Proceess for user game when he choose Hard level ******   */
      

            else if (chooselevel == 3)
            {

                  Console.WriteLine("Welcome to Hard Level: You have to guess a number from 1 to 50. And you have 3 guesses");
                Console.WriteLine("Go Ahead! Guess the number: ");
                    guessHard = int.Parse(Console.ReadLine());
                    if (guessHard != hard){
                    guessTryHard--;
                    Console.WriteLine("That was wrong! Guess again you have " + guessTryHard +" more guesses left.");
                    }else {
                        Console.WriteLine("You got it right! That was too Quick. Congratulations!");

                    }                    
                    if (guessHard != hard){
                        while(guessTryHard >= 1){
                        Console.WriteLine("Guess the number Again: ");
                        guessHard = int.Parse(Console.ReadLine());
                        guessTryHard--;
                        Console.WriteLine("That was wrong! Guess again you have " + guessTryHard +" more guesses left.");
                        if(guessHard > 50){
                            Console.WriteLine("Please Choose Number only from 1-20");
                            Console.WriteLine("Guess the number Again: ");
                            guessHard = int.Parse(Console.ReadLine());
                            guessTryHard--;
                            Console.WriteLine("That was wrong! Guess again you have " + guessTryHard +" more guesses left.");
                        
                        }else if (guessHard == hard){
                        Console.WriteLine("You got it right! Congratulations!");
                        break;
                    } else if (guessTryHard == 0){
                            Console.WriteLine("You have Used up all your chance. \n GAME OVER!!!");

                        }
                    
                    }

                    } 
                    
            }

            else{
                Console.WriteLine("Invalid Command. Please follow instructions.");

            }
            Console.WriteLine("Thank you for playing");
            } catch (Exception)
      {
        Console.WriteLine("Only Numeric input are Allowed.");
      }   finally
{
  Console.WriteLine("Restart the Game otherwise Thank you for playing.");
}
        }
        
        }
    }

