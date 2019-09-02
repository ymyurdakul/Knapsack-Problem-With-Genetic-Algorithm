using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Knapsack_Problem_Convergence
{
    class Population
    {
        private Chromosome[] chromosomes;
        private Chromosome best;
        public Population()
        {
           chromosomes = new Chromosome[Form1.CHROMOSOME_COUNT];
        }
        public void initialize()
        {
            for (int i = 0; i < Form1.CHROMOSOME_COUNT; i++)
            {
                Chromosome temp = new Chromosome();
                temp.random();
                temp.setFitness();
                temp.setWeight();
                chromosomes[i] = temp;
            }
        }
        public void setBest()
        {
            Chromosome bestOne = chromosomes[0];
            for (int i = 0; i < Form1.CHROMOSOME_COUNT; i++)
            {
                if (chromosomes[i].Fitness > bestOne.Fitness)
                {
                    bestOne = chromosomes[i];
                }
            }
            this.best = bestOne;
        }
        public void print(ListBox lb)
        {
            foreach (Chromosome item in chromosomes)
            {
                item.print(lb);
            }
        }
        public Chromosome Best
        {
            get { return best; }
            set { this.best = value; }
        }
        public Chromosome[] Kromozomlar
        {
            get { return this.chromosomes; }
            set { this.chromosomes = value; }

        }

    }
}
