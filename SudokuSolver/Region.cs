using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Region
    {
        public Array[] squareRefs;
        public RegionType regionType;
        public int ordinal;

        public enum RegionType
        {
            Column = 1,
            Row = 2,
            Block = 3
        }

        public Region(int arraySize, RegionType regionType, int ordinal)
        {
            this.squareRefs = new Array[arraySize];
            this.regionType = regionType;
            this.ordinal = ordinal;
        }
    }

}
