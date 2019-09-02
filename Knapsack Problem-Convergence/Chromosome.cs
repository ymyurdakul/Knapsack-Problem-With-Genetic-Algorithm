using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knapsack_Problem_Convergence
{
     class Chromosome
    {
        private Gene[] genes;
        private int fitness=0;
        private int weight = 0;
       
        public Chromosome()
        { 
            genes=new Gene[Form1.GENE_COUNT];
        }

        public void random()
        {
            for (int i = 0; i < Form1.GENE_COUNT; i++)
            {
                int r = Form1.random.Next(1,100);
                if (r%2==0)
                {
                    genes[i] = new Gene('0');
                }
                else
                {
                    genes[i] = new Gene('1');
                }
            }
        }
        public void setWeight()
        {
            this.weight = Function.setWeight(this);
        }
        public void setFitness()
        {
            this.fitness = 0;
            this.Fitness = Function.setFitness(this);
        }
        public void print(ListBox lb)
        {
            String tx = "";
            for (int i = 0; i < Form1.GENE_COUNT; i++)
            {
                tx+=(genes[i].Value);
            }
            tx+=("    fitness:::"+Fitness+"  Weight=="+weight+"\n");
            lb.Items.Add(tx);
            
        
        }
        public Gene[] Genes {
            get { return genes; }
            set { this.genes = value; }
        }
        public int Fitness{
            get { return fitness; }
            set { this.fitness = value; }

        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    
    }
}
