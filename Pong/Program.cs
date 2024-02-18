namespace Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            const int tennisCourtLength = 50, tennisCourtWidth = 20;
            char[] keys = PongUtil.chooseControls();
            char leftUp = keys[0];
            char leftDown = keys[1];
            char rightUp = keys[2];
            char rightDown = keys[3];
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