using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int count = 0;
        bool digit = false;

        int value;
        int maxCaracters = 6;
        int[] binary = new int[6];
        
        string[] operations = new string[4] { "+","-","/","*"};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void goToInsturctions(object sender, EventArgs e)
        {
            menuTittle.Visible = false;
            howButton.Visible = false;
            instructionsTittle.Visible = true;
            instructionsText.Visible = true;
            backToMenuButton.Visible = true;
        }

        private void beginGame(object sender, EventArgs e)
        {
            menuTittle.Visible = false;
            howButton.Visible = false;
            instructionsTittle.Visible = false;
            instructionsText.Visible = false;
            startButton.Visible = false;

            count = 0;
            digit = false;
            binaryBox1.Visible = true;
            binaryBox1.Text = "";
            operationLabel.Visible = true;
            operationLabel.Text = "operation";
            binaryBox2.Visible = true;
            binaryBox2.Text = "";
            digit0Button.Visible = true;
            digit1Button.Visible = true;
            doButton.Visible = true;
            decimalLabel.Visible = true;
            decimalTextBox.Visible = true;
            decimalTextBox.Text = "";
            backToMenuButton.Visible = true;
        }

        private void backToMenu(object sender, EventArgs e)
        {
            menuTittle.Visible = true;
            howButton.Visible = true;
            instructionsTittle.Visible = false;
            instructionsText.Visible = false;
            startButton.Visible = true;

            binaryBox1.Visible = false;
            operationLabel.Visible = false;
            binaryBox2.Visible = false;
            digit0Button.Visible = false;
            digit1Button.Visible = false;
            doButton.Visible = false;
            decimalLabel.Visible = false;
            decimalTextBox.Visible = false;
            backToMenuButton.Visible = false;
        }

        private void doIt(object sender, EventArgs e)
        {
            switch (operationLabel.Text)
            { 
                case "+":
                    //GameDefault.doSum()
                    break;

                case "-":

                    break;

                case "/":

                    break;
                
                case "*":

                    break;

            }

            value = Convert.ToInt32(binaryBox2.Text);
            binaryBox1.Text = value.ToString();
            binaryBox2.Text = "";
            count = 0;

            decimalTextBox.Text = Convert.ToString(ConvertTo.ToDecimal(binaryBox1.Text));
            
            for (int i = 0; i < operations.Length; i++)
            {
                //i = random.Next(1, 5);
                operationLabel.Text = operations[i];
            }
        }

        private void typeIn(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            digit = true;
            count++;

            if (count > maxCaracters)
                digit = false;
            if (digit) 
                binaryBox2.Text += clicked.Text;
        }

    }
}
