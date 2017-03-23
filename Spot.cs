using System;
using System.Collections.Generic;
using System.Text;

namespace bfsPackan
{
    class Spot
    {
       
        public Spot(int i, int j, Boolean Accessible)
        {
            I = i;
            J = j;
            f = 0;
            g = 0;
            h = 0;
            neighbors = null; 
            accessible = Accessible;
            discovered = false;
            parent = null;
        }

        public int I { get; set; }
        public int J { get; set; }
        public double f { get; set; }   //cost function
        public double h { get; set; }   // heuristics
        public double g { get; set; }   //cost
        public Queue<Spot> neighbors { get; set; }
        public Boolean accessible { get; set; }
        public Boolean discovered { get; set; }
        public Spot parent { get; set; }

        public void addNeighbors(Spot[,] grid, int c, int r) => 
            neighbors = new Queue<Spot>(new List<Spot> { grid[I - 1, J], grid[I, J - 1], grid[I, J + 1], grid[I + 1, J] });        
    }
}
