// Math Application 
// user decides which type of arithmetic to do
// prompts user for answer and tracks score
// Author: nate nolting
// Date: 3/01/21


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {
        int questionsAsked = 0;
        int correctAnswers = 0;
        int cal = 0;
        double finalScore = 0;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addRadio.Checked = true;  //form loads with add radio selected
        }

       
        private void BeginBtn_Click(object sender, EventArgs e)
        {
            if (addRadio.Checked == true)  //Addition
            {
                addOperation();
            }
            if (subRadio.Checked == true) //Subtract
            {
                subtractOperation();
            }
            if (multiRadio.Checked == true) //multiplication 
            {
                multiplicationOperation();
            }
            if (divRadio.Checked == true) //division 
            {
                divisionOperation();
            }
            

        }

        public void addOperation()
        {

            Random rand = new Random();
            int firstValue = rand.Next(1, 9);   //change values here to change questions
            int secondValue = rand.Next(1, 12);  // change vals here as well

            int calculate = firstValue + secondValue;
            cal = calculate;
            lblMath.Text = firstValue + " + " + secondValue + " = ?";
        }

        public void subtractOperation()
        {
            Random rand = new Random();
            int firstValue = rand.Next(9, 20);   //change values here to change questions
            int secondValue = rand.Next(1, 6);  // change vals here as well

            int calculate = firstValue - secondValue;
            cal = calculate;
            lblMath.Text = firstValue + " - " + secondValue + " = ?";
        }

        public void multiplicationOperation()
        {
            Random rand = new Random();
            int firstValue = rand.Next(1, 5);   //change values here to change questions
            int secondValue = rand.Next(1, 9);  // change vals here as well

            int calculate = firstValue * secondValue;
            cal = calculate;
            lblMath.Text = firstValue + " * " + secondValue + " = ?";
        }

        public void divisionOperation()
        {
            Random rand = new Random();
            int firstValue = rand.Next(10, 25);   //change values here to change questions
            int secondValue = rand.Next(1, 4);  // change vals here as well

            int calculate = firstValue / secondValue;
            cal = calculate;
            lblMath.Text = firstValue + " / " + secondValue + " = ?";
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            string response = answerTxtBox.Text;
            try
            {


                if (Int32.Parse(response).Equals(cal))
                {
                    MessageBox.Show("Your answer is correct!");
                    
                    if (addRadio.Checked == true)  //Addition
                    {
                        addOperation();
                    }
                    if (subRadio.Checked == true) //Subtract
                    {
                        subtractOperation();
                    }
                    if (multiRadio.Checked == true) //multiplication 
                    {
                        multiplicationOperation();
                    }
                    if (divRadio.Checked == true) //division 
                    {
                        divisionOperation();
                    }
                    questionsAsked++;
                    correctAnswers++;
                    quesAskLbl.Text = "Number of questions asked: " + questionsAsked;
                    correctLbl.Text = "Correct answers: " + correctAnswers;
                  
                }
                else
                {
                    questionsAsked++;
                    quesAskLbl.Text = "Number of questions asked: " + questionsAsked;
                    
                    MessageBox.Show("Your answer is wrong.");
                    
                }
                finalScore = ((double)correctAnswers / questionsAsked) * 100;
                finalScoreLbl.Text = finalScore.ToString("0.00");

            } //end try
            catch (Exception wrongInput)
            {
                MessageBox.Show("Please use integers only. Try again");
                answerTxtBox.Clear();
            }
        }
    }
}

