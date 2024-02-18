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
            int ballXCoord = tennisCourtLength / 2;
            int ballYCoord = tennisCourtWidth / 2;
            char ball = '°';
            bool isBallGoingDown = true;
            bool isBallGoingRight = true;
            while (true)
            {
                Console.SetCursorPosition(0, 0); //top outline
                Console.WriteLine(outline);
                Console.SetCursorPosition(0, tennisCourtWidth); //bottom outline
                Console.WriteLine(outline);

                Console.SetCursorPosition(ballXCoord, ballYCoord);
                Console.WriteLine(ball);
                while (!Console.KeyAvailable)
                {
                    for (int i = 0; i < racketSize; i++) //print rackets
                    {
                        Console.SetCursorPosition(0, i + 1 + leftRacketPosition); //left racket
                        Console.WriteLine(racket);
                        Console.SetCursorPosition(tennisCourtLength - 1, i + 1 + rightRacketPosition); //right racket
                        Console.WriteLine(racket);
                    }
                    Console.SetCursorPosition(ballXCoord, ballYCoord);
                    Console.WriteLine(ball);
                    Thread.Sleep(100); //Adds a timer so that the players have time to react

                    Console.SetCursorPosition(ballXCoord, ballYCoord);
                    Console.WriteLine(" "); //Clears the previous position of the ball

                    //Update ball position
                    if (isBallGoingDown)
                    {
                        ballYCoord++;
                    }
                    else
                    {
                        ballYCoord--;
                    }
                    if (isBallGoingRight)
                    {
                        ballXCoord++;
                    }
                    else
                    {
                        ballXCoord--;
                    }

                    if(ballYCoord == 1 || ballYCoord == tennisCourtWidth - 1)
                    {
                        isBallGoingDown = !isBallGoingDown;
                    }

                    if (ballXCoord == 1)
                    {
                        if ((ballYCoord <= leftRacketPosition + racketSize) && (ballYCoord >= leftRacketPosition + 1))
                        {
                            isBallGoingRight = !isBallGoingRight;
                        }
                    }
                    else if (ballXCoord == tennisCourtLength -1)
                    {
                        if ((ballYCoord <= rightRacketPosition + racketSize) && (ballYCoord >= rightRacketPosition +1))
                        {
                            isBallGoingRight = !isBallGoingRight;
                        }
                    }
                }

                for (int i = 0; i < racketSize; i++) //print rackets
                {
                    Console.SetCursorPosition(0, i + 1 + leftRacketPosition); //left racket
                    Console.WriteLine(racket);
                    Console.SetCursorPosition(tennisCourtLength - 1, i + 1 + rightRacketPosition); //right racket
                    Console.WriteLine(racket);
                } // end of racket print loop
                ConsoleKey buttonPressed;
                buttonPressed = Console.ReadKey().Key;
                if (buttonPressed.Equals(leftUp))
                {
                    if (leftRacketPosition > 0)
                    {
                        leftRacketPosition--;
                        Console.SetCursorPosition(0, leftRacketPosition + 1);
                        Console.WriteLine(" ");
                    }
                } 
                else if(buttonPressed.Equals(leftDown))
                {
                    if (leftRacketPosition < tennisCourtWidth - racketSize -1)
                    {
                        leftRacketPosition++;
                        Console.SetCursorPosition(0, leftRacketPosition - 1);
                        Console.WriteLine(" ");
                    }
                }
                if (buttonPressed.Equals(rightUp))
                {
                    if (rightRacketPosition > 0)
                    {
                        rightRacketPosition--;
                        Console.SetCursorPosition(0, rightRacketPosition + 1);
                        Console.WriteLine(" ");
                    }
                }
                else if (buttonPressed.Equals(rightDown))
                {
                    if (rightRacketPosition < tennisCourtWidth - racketSize - 1)
                    {
                        rightRacketPosition++;
                        Console.SetCursorPosition(0, rightRacketPosition - 1);
                        Console.WriteLine(" ");
                    }
                }
                for (int i = 1; i < tennisCourtWidth; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(tennisCourtLength - 1, i);
                    Console.WriteLine(" ");
                }
                
            }//end of game loop
        }
    }
}