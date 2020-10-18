using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array size is 82 because I'm an edgelord who don't need no zero indexing
            Square[] sudokuSquares = new Square[82];
            Region[] regions = new Region[27];
            

            int height = 9;
            int width = 9;
            int noOfBlocks = 9;
            int counter = 1;

            //Assuing a classic 9x9 sudoku, this will generate the basic 'grid'

            for (int i = 1; i < (height + 1); i++)
            {
                
                for (int j = 1; j < (width + 1); j++)
                {                 
                    Square sq = new Square(i, j, counter);

                    sudokuSquares[sq.squareNumber] = sq;
                    Console.WriteLine("Added square " + sq.squareNumber);

                    counter++;
                }
            }

            //Assuming a classic 9x9 sudoku, this will assign a sudokuSquare to the appropriate region

            for (int i = 1; i < height + 1; i++)
            {
                Region rg = new Region(9, Region.RegionType.Row, i);

                foreach (var squarerefs in rg.squareRefs)
                {

                }

                regions[i - 0] = rg;
            }

            for (int i = 1; i < width + 1; i++)
            {
                Region rg = new Region(9, Region.RegionType.Column, i);
                regions[i + 8] = rg;
            }

            for (int i = 1; i < noOfBlocks + 1; i++)
            {
                Region rg = new Region(9, Region.RegionType.Block, i);
                regions[i + 17] = rg;
            }

            Console.ReadLine();
        }
    }
}
