using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack_Problem_Convergence
{
    class Gene
    {
        private char value;
        public char Value { get { return this.value; } set { this.value = value; } }
        public Gene(char value)
        {
            this.value = value;
        }
    }
}
