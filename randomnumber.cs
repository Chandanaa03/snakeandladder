using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder
{
    public class randomnumber
    {
        public static void dice()
        {
            int player1, playerposition;

            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("player1 dice value is:" + die);
        }
    }
}
