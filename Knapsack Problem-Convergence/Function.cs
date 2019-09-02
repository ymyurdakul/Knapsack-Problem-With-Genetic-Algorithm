using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack_Problem_Convergence
{
    class Function
    {

        public static int setFitness(Chromosome kro)
        {
            int weight = 0, benefit = 0;
            for (int i = 0; i < Form1.GENE_COUNT; i++)
            {
                if (kro.Genes[i].Value == '1')
                {
                    weight += Form1.weights[i];
                    benefit += Form1.benefit[i];
                }

            }
            int cost = benefit;
            if (weight > Form1.BOUND)
            {
                cost = cost - (cost * 10);
            }
            return cost;
        }
        public static int setWeight(Chromosome kro)
        {

            int weight = 0;
            for (int i = 0; i < Form1.GENE_COUNT; i++)
            {
                if (kro.Genes[i].Value == '1')
                {
                    weight += Form1.weights[i];

                }

            }
            return weight;
        }
    }
}
