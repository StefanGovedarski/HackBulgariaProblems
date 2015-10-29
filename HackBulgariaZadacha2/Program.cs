using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgariaZadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You are given a rectangular table filled with characters and a word. Your task is to count 
             * the occurences of the word in the table.
             * The word can be found horizontaly, vertically and across both left to right and right to left.

For example, find the word ivan in the table:
i 	v 	a 	n
e 	v 	n 	h
i 	n 	a 	v
m 	v 	v 	n
q 	r 	i 	t

Result:

3
*/
            //vuvejdane na tablica 
            int counter = 0;//promenliva koqto broi sre6taniqta na dumata v tablicata
            Console.WriteLine("Input the number of rows of your table");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of colomns of your table");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The table is (" + n + ", " + m + ") big");
            char[,] table = new char[n, m];
            Console.WriteLine("input your table of character line by line(row by row)");
            for (int i = 0; i < n; i++ )
            {
                string inputLine = Console.ReadLine();
                char[] inputCharLine = inputLine.ToCharArray();
                for(int col = 0; col<table.GetLength(1) ; col++)
                {
                    table[i, col] = inputCharLine[col];
                }
                
            }

                Console.WriteLine("Your table filled with characters looks like this : ");
            for(int i=0;i<table.GetLength(0);i++)
            {
                for(int j=0; j<table.GetLength(1);j++)
                {
                    Console.Write(table[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Now input the word you want to search for and count : ");
            string word =Convert.ToString( Console.ReadLine());
            int lenght = word.Length;
            //izvikvane na metoda
            for(int row=0 ; row< table.GetLength(0);row++)
            {
                for(int col=0;col<table.GetLength(1);col++)
                {
                    if(table[row,col]==word[0])
                    {
                        if (CheckHorizontally( table,word,row,col))
                            counter++;
                        if (CheckVertically(table, word, row, col))
                            counter++;
                        if (CheckAcrossFromLeftToRight(table, word, row, col))
                            counter++;
                        if (CheckAcrossFromRightToLeft(table, word, row, col))
                            counter++;
                        if (CheckHorizontallyFromRightToLeft(table, word, row, col))
                            counter++;
                        if (CheckVerticallyFromBottomToTop(table, word, row, col))
                            counter++;
                    }
                }
            }

            Console.WriteLine("The word " + word + " is in the table " +counter + " times!");
        }
        //suzdavane na broq4 za sre6taniqta na dumata
        static bool CheckHorizontally(char[,] matrix , string word , int i , int j)
        {
            bool isIt = true;
            for (int k = 1; k < word.Length; k++)
            {
                if (j + k >= matrix.GetLength(1) || matrix[i, j + k] != word[k])
                {
                    isIt = false;
                    break;
                }

            }

            return isIt;
        }
        static bool CheckVertically(char[,] matrix , string word , int i , int j)
        {
             bool isIt = true;
            for (int k = 1; k < word.Length; k++)
            {
                if (i + k >= matrix.GetLength(0) || matrix[i + k, j] != word[k])
                {
                    isIt = false;
                    break;
                }
            }
            return isIt;
        }
        static bool CheckAcrossFromLeftToRight(char[,] matrix , string word , int i , int j)
        {
             bool isIt = true;
            for (int k = 1; k < word.Length; k++)
            {
                if (i + k >= matrix.GetLength(0) || j + k >= matrix.GetLength(1) || matrix[i + k, j + k] != word[k])
                {
                    isIt = false;
                    break;
                }
            }

            return isIt;
        }

        static bool CheckAcrossFromRightToLeft(char[,] matrix , string word , int i , int j)
        {
             bool isIt = true;
            for (int k = 1; k < word.Length; k++)
            {
                if (i + k >= matrix.GetLength(0) || j - k <= 0 || matrix[i + k, j - k] != word[k])
                {
                    isIt = false;
                    break;
                }
            }

            return isIt;
        }

        static bool CheckHorizontallyFromRightToLeft (char[,] matrix , string word , int i , int j)
        {
            bool isIt = true;
            for(int k=1;k<word.Length;k++)
            {
                if (j - k < 0 || matrix[i,j-k]!=word[k]) 
                {
                    isIt = false;
                    break;
                }

            }
            return isIt;
        }


        static bool CheckVerticallyFromBottomToTop(char[,] matrix , string word , int i , int j)
        {
            bool isIt = true;
            for(int k=1;k<word.Length;k++)
            {
                if(i-k<0 || matrix[i-k,j ] != word[k])
                {
                    isIt=false;
                    break;
                }

            }
            return isIt;
        }



      }

    }


