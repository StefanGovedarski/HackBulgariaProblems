using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgariaZadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You are on a infinite 2D coordinate system.

The only thing you know is that x increases to the right and decreases to the left, while y increases downwards and decreases upwards.

You know your current position: (current-x, current-y).

You are given a string of the form:

">v<>>>v^~><><~><><" where each arrow represents a direction.

Your job is to follow the directions of the arrow and output the final position that you have arrived, starting from your own.

There is one special symbol that you should take care of - the warp symbol ~

When you get the warp symbol, the following effect triggers:

    Moving on X axis is reversed. If x is increasing to the right, after the warp symbol,x starts to increase to the left and decrease to the right. And vice versa.
    Moving on Y axis is reversed. If y is increasing downwards, after the warp symbol, y starts to increase upwards and decrease downwards. And vice versa.

Here are few examples:

Input:

Starting point: (0, 0)
>>><<<~>>>~^^^

Output:

(-3, -3)

          */


            //input starting position
            Console.WriteLine("Input starting position for X");
            int currentPositionX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input starting position for Y");
            int currentPositionY = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n The starting position for (X,Y) is: ( " + currentPositionX + ", " + currentPositionY + ") \n");
            Console.WriteLine("Input direction sequence");
            string directionString = Console.ReadLine();
            Console.WriteLine("The direction sequence is  " + directionString);
            // boolean that follows the current state of the instructions
            bool reversed = false;
            foreach (char c in directionString)
            {
                if (c == '>')
                {
                    if(reversed==true)
                        currentPositionX--;
                    else
                        currentPositionX++;

                }
                else if (c == '<')
                {
                    if (reversed == true)
                        currentPositionX++;
                    else
                        currentPositionX--;

                }
                else if (c == 'v')
                {
                    if (reversed == true)
                        currentPositionY--;
                    else
                        currentPositionY++;
                }
                else if (c == '^')
                {
                    if (reversed == true)
                        currentPositionY++;
                    else
                        currentPositionY--;
                }
                else if (c == '~')
                {
                    if (reversed == true)
                    {
                        reversed = false;
                    }
                    else
                    {
                        reversed = true;
                    }

                }
            }
            Console.WriteLine("The final position of (X,Y) is: (" + currentPositionX + ", " + currentPositionY + ") \n" );
           }
        }
    }

