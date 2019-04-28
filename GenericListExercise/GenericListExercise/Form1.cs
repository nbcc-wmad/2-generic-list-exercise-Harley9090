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
                int grade = Convert.ToInt32(txtScore.Text.Trim());

                foreach(Score item in scoreGet)
                {
                    if (grade <= item.MaxPoints)
                    {
                        string msg = $"The grade is : {item.Grade}";
                        MessageBox.Show(msg);
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates the elements inside the array list
            score.MaxPoints = 299;
            score.Grade = "F"; 
            scoreGet.Add(score);

            score.MaxPoints = 349;
            score.Grade = "D";
            scoreGet.Add(score);

            score.MaxPoints = 399;
            score.Grade = "C";
            scoreGet.Add(score);

            score.MaxPoints = 449;
            score.Grade = "B";
            scoreGet.Add(score);

            score.MaxPoints = 500;
            score.Grade = "A";
            scoreGet.Add(score);
        }
    }
}
