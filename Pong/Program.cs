namespace Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            const int tennisCourtLength = 50, tennisCourtWidth = 20;

            ConsoleKey leftUp;
            ConsoleKey leftDown;
            ConsoleKey rightUp;
            ConsoleKey rightDown;
            Console.WriteLine("***********\nDefault Keys\n***********\nLeft Player\nUp : W\nDown : S");
            Console.WriteLine("***********\nRight Player\nUp : Up Arrow\nDown : Down Arrow\n***********\n");
            Console.WriteLine("Would you like to use the default keys?");
            if (!PongUtil.confirmOption())
            {
                Console.Clear();
                char[] keys = PongUtil.chooseControls();
                leftUp = (ConsoleKey)keys[0];
                leftDown = (ConsoleKey)keys[1];
                rightUp = (ConsoleKey)keys[2];
                rightDown = (ConsoleKey)keys[3];
            }
            else
            {
                leftUp = ConsoleKey.W;
                leftDown = ConsoleKey.S;
                rightUp = ConsoleKey.UpArrow;
                rightDown = ConsoleKey.DownArrow;
            }
            Console.Clear();

            const char courtOutline = '-';
            string outline = string.Concat(Enumerable.Repeat(courtOutline, tennisCourtLength));

            int racketSize = tennisCourtWidth / 4; // racket size will be 1/4 of tennis court width
            char racket = '|';
            int leftRacketPosition = 0;
            int rightRacketPosition = 0;
            while (true)
            {
                Console.SetCursorPosition(0, 0); //top outline
                Console.WriteLine(outline);
                Console.SetCursorPosition(0, tennisCourtWidth); //bottom outline
                Console.WriteLine(outline);

                for (int i = 0; i < racketSize; i++) //print rackets
                {
                    Console.SetCursorPosition(0, i + 1 + leftRacketPosition); //left racket
                    Console.WriteLine(racket);
                    Console.SetCursorPosition(tennisCourtLength - 1, i + 1 + rightRacketPosition); //right racket
                    Console.WriteLine(racket);
                } // end of racket print loop

                
            }//end of game loop
        }
    }
}