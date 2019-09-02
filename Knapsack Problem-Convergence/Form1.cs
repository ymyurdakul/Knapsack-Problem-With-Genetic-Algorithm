using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knapsack_Problem_Convergence
{
    public partial class Form1 : Form
    {
        public static int GENE_COUNT = 10;
        public static int CHROMOSOME_COUNT = 50;
        public static int BOUND = 20;
        public static int ITERATION_COUNT = 0;
        public static int[] benefit = new int[] { 30, 40, 20, 20, 30, 15, 25, 30, 35, 20 };
        public static int[] weights = new int[] { 15, 6, 2, 19, 18, 14, 13, 8, 11, 17 };
        private Population pop;
        public static Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pop = new Population();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pop.initialize();
            pop.setBest();
            listBox1.Items.Clear();
            chart1.Series["Fitness"].Points.Clear();
            Form1.BOUND = (int)nmrUpDownBound.Value;
            Form1.ITERATION_COUNT = (int)nmrUpDownIterCount.Value;
            int[] array = new int[ITERATION_COUNT];
            pop.Best.print(listBox1);
            for (int i = 0; i < ITERATION_COUNT; i++)
            {
                pop = Algorithm.evolvePopulation(pop);
                //   pop.print();
                pop.setBest();
                array[i] = pop.Best.Fitness;
                pop.Best.print(listBox1);
            }
            for (int i = 0; i < ITERATION_COUNT; i++)
            {
                chart1.Series["Fitness"].Points.Add(array[i]);
            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
