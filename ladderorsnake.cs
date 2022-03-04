using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder
{
    public class ladderorsnake
    {
        public static void opition()
        {
            int player1, playerposition;
            playerposition = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine(" number on dice :" + dice);

            

               


             
                switch (dice)
                {

                    case 1:
                        dice = 1;
                        Console.WriteLine("The player1 has no play");
                        break;
                    case 2:
                        dice = 2;
                        player1 = playerposition - dice;
                        Console.WriteLine("Oops it snake");
                        break;
                    case 3:
                        dice = 3;
                        Console.WriteLine("The player1 has no play");
                        break;
                    case 4:
                        dice = 4;
                        player1 = playerposition + dice;
                        Console.WriteLine("Hurray! Its ladder time");
                        break;
                    case 5:
                        dice = 5;
                        player1 = playerposition - dice;
                        Console.WriteLine("Oops it snake");
                        break;
                    case 6:
                        dice = 6;
                        player1 = playerposition + dice;
                        Console.WriteLine("Hurray! Its ladder time");
                        break;
                }

            }
        }
    }




        
