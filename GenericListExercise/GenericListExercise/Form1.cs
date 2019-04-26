// Author: Harley Veillette
// Date: 2019-04-26
// Exercise: ArrayLists and Structures 1
// Notes: This is our first exercise to give back
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListExercise
{
    public struct Score
    {
        public long MaxPoints;
        public string Grade;
    }
    public partial class Form1 : Form
    {
        private Score score;
        private ArrayList scoreGet = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            //Code a form that allows Professor Carver to display a grade 
            //based on the number of points she enters. 
            try
            {
                //Get the string from the textbox and assigning it in the array
                score.MaxPoints = Convert.ToInt64(txtScore.Text.Trim());

                scoreGet.Add(score);
                MessageBox.Show($"Grade added to list {score.MaxPoints}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }
    }
}
