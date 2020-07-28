using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Square
    {
        public int squareNumber;
        public int xPos;
        public int yPos;
        public int? value;
        public List<int> potentialValues;

        public Square(int i, int j, int counter)
        {
            this.xPos = i;
            this.yPos = j;
            this.squareNumber = counter;
            this.value = null;

            this.potentialValues = new List<int>();

            this.potentialValues.Add(1);
            this.potentialValues.Add(2);
            this.potentialValues.Add(3);
            this.potentialValues.Add(4);
            this.potentialValues.Add(5);
            this.potentialValues.Add(6);
            this.potentialValues.Add(7);
            this.potentialValues.Add(8);
            this.potentialValues.Add(9);
        }
    }
}