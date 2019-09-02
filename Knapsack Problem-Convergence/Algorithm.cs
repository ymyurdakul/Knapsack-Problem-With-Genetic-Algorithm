using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack_Problem_Convergence
{
    class Algorithm
    {
        public static Population evolvePopulation(Population pop)
        {
            pop.setBest();
            Population newPop = new Population();
            newPop.Kromozomlar[0] = new Chromosome();
            for (int i = 0; i < Form1.GENE_COUNT; i++)
            {
                newPop.Kromozomlar[0].Genes[i] = new Gene(pop.Best.Genes[i].Value);
            }
            newPop.Kromozomlar[0].setFitness();
            newPop.Kromozomlar[0].setWeight();

            for (int i = 1; i <Form1.CHROMOSOME_COUNT; i++)
            {
                Chromosome child1 = selection(pop);
                Chromosome child2 = selection(pop);
                Chromosome offspring = crossOver(child1, child2);
                mutate(offspring);
                offspring.setFitness();
                offspring.setWeight();

                newPop.Kromozomlar[i] = offspring;
            }
            return newPop;
        }
        public static Chromosome selection(Population pop)
        {
            Chromosome k1 = pop.Kromozomlar[Form1.random.Next(0, Form1.CHROMOSOME_COUNT)];
            Chromosome k2 = pop.Kromozomlar[Form1.random.Next(0, Form1.CHROMOSOME_COUNT)];
            if (k1.Fitness > k2.Fitness)
            {
                return k1;
            }
            else return k2;

        }
        public static void mutate(Chromosome kro)
        {
            for (int i = 0; i < 1; i++)
            {
                int y = Form1.random.Next(0, Form1.GENE_COUNT);
                if (kro.Genes[i].Value == '1')
                    kro.Genes[i].Value = '0';
                else kro.Genes[i].Value = '1';
            }


        }
        public static Chromosome crossOver(Chromosome k1, Chromosome k2)
        {
            Chromosome child1 = new Chromosome();
            Array.Copy(k1.Genes, child1.Genes, k1.Genes.Length);
            Chromosome child2 = new Chromosome();
            Array.Copy(k2.Genes, child2.Genes, k2.Genes.Length);
            int point = Form1.random.Next(0, Form1.GENE_COUNT);

            for (int i = 0; i < point; i++)
            {
                child1.Genes[i] = new Gene(k2.Genes[i].Value);
                child2.Genes[i] = new Gene(k1.Genes[i].Value);
            }


            child1.setFitness();
            child2.setFitness();
            child1.setWeight();
            child2.setWeight();
            if (child1.Fitness > child2.Fitness)
            {
                return child1;
            }
            else
                return child2;

        }
    }
}
