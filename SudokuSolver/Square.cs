using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Square
    {
        public int xPos;
        public int yPos;
        public int? value;
        public List<int> potentialValues;
    }
}
