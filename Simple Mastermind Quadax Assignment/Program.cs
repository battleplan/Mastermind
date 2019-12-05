using System;

namespace Simple_Mastermind_Quadax_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Title
            Console.WriteLine(@"$$\      $$\                       $$\                         $$\      $$\ $$\                 $$\ 
$$$\    $$$ |                      $$ |                        $$$\    $$$ |\__|                $$ |
$$$$\  $$$$ | $$$$$$\   $$$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  $$$$\  $$$$ |$$\ $$$$$$$\   $$$$$$$ |
$$\$$\$$ $$ | \____$$\ $$  _____|\_$$  _|  $$  __$$\ $$  __$$\ $$\$$\$$ $$ |$$ |$$  __$$\ $$  __$$ |
$$ \$$$  $$ | $$$$$$$ |\$$$$$$\    $$ |    $$$$$$$$ |$$ |  \__|$$ \$$$  $$ |$$ |$$ |  $$ |$$ /  $$ |
$$ |\$  /$$ |$$  __$$ | \____$$\   $$ |$$\ $$   ____|$$ |      $$ |\$  /$$ |$$ |$$ |  $$ |$$ |  $$ |
$$ | \_/ $$ |\$$$$$$$ |$$$$$$$  |  \$$$$  |\$$$$$$$\ $$ |      $$ | \_/ $$ |$$ |$$ |  $$ |\$$$$$$$ |
\__|     \__| \_______|\_______/    \____/  \_______|\__|      \__|     \__|\__|\__|  \__| \_______|

____________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Lets Play....You Have 10 guesses");
            #endregion

            #region declarations
            bool endGame = false;
            bool win = false;
            int attempts = 0;
            #endregion

            #region create a random 4 digit answer
            int[] answer = new int[4];

            Random randNum = new Random();
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = randNum.Next(0, 7);
            }
            #endregion

            #region simple game loop
            while (endGame == false)
            {
                 
                string GuessInput = Console.ReadLine();
                string tempGuess = GuessInput;
                char[] ch = tempGuess.ToCharArray();
                Char rep = '9';

                #region Win Check
                int one = int.Parse(ch[0].ToString());
                int two = int.Parse(ch[1].ToString());
                int three = int.Parse(ch[2].ToString());
                int four = int.Parse(ch[3].ToString());

                if (one == answer[0])
                {
                    if (two == answer[1])
                    {
                        if (three == answer[2])
                        {
                            if (four == answer[3])
                            {
                                win = true;
                            }
                        }
                    }
                }

                #endregion

                #region Plus check 

                if (one == answer[0])
                {
                    Console.WriteLine("+");
                    ch[0] = rep;
                }
                if (two == answer[1])
                {
                    Console.WriteLine("+");
                    ch[1] = rep;
                }
                if (three == answer[2])
                {
                    Console.WriteLine("+");
                    ch[2] = rep;
                }
                if (four == answer[3])
                {
                    Console.WriteLine("+");
                    ch[3] = rep;
                }
                #endregion
                
                #region Minus Check
                foreach (char guessDigit in ch)
                {
                    int digit = int.Parse(guessDigit.ToString());
                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (answer[i] == digit)
                        {
                            Console.Write("-");
                        }
                    }
                }
                #endregion

                attempts++;

                #region win condion/endgame and try again prompt
               
                if(attempts == 10 || win == true)
                {
                    endGame = true;
                }
                else if (attempts <= 9)
                {
                    Console.WriteLine("try again");
                }
                #endregion
            }
            #endregion

            #region End game message based on win/loss
            if (win == true)
            {
                Console.WriteLine("You Won The Game");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The Game Has Ended, You Lost.... Thanks For Playing");
                Console.ReadLine();
            }
            #endregion
        }
    }
}
