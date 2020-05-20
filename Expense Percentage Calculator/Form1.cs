using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Percentage_Calculator
{
    public partial class Form1 : Form
    {
        int p1=0, p2=0, p3=0, totalPercent=0;
        public Form1()
        {
            InitializeComponent();
            ClearAll();
        }

        public void ClearAll()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            MonthlySalaryTextBox.Text = "";
            DomesticExpensesPercentageTextBox.Text = "0";
            DomesticExpensesTotalTextBox.Text = "";
            PersonalExpensesPercentageTextBox.Text = "0";
            PersonalExpensesTotalTextBox.Text = "";
            SavingsPercentageTextBox.Text = "0";
            SavingsTotalTextBox.Text = "";
            DomesticExpensesPercentageTextBox.Enabled = false;
            PersonalExpensesPercentageTextBox.Enabled = false;
            SavingsPercentageTextBox.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton4.Checked = false;
                DomesticExpensesPercentageTextBox.Text = "50";
                PersonalExpensesPercentageTextBox.Text = "30";
                SavingsPercentageTextBox.Text = "20";
                DomesticExpensesPercentageTextBox.Enabled = false;
                PersonalExpensesPercentageTextBox.Enabled = false;
                SavingsPercentageTextBox.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton4.Checked = false;
                DomesticExpensesPercentageTextBox.Text = "50";
                PersonalExpensesPercentageTextBox.Text = "20";
                SavingsPercentageTextBox.Text = "30";
                DomesticExpensesPercentageTextBox.Enabled = false;
                PersonalExpensesPercentageTextBox.Enabled = false;
                SavingsPercentageTextBox.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                DomesticExpensesPercentageTextBox.Enabled = true;
                PersonalExpensesPercentageTextBox.Enabled = true;
                SavingsPercentageTextBox.Enabled = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MonthlySalaryTextBox.Text == "")
            {
                MessageBox.Show("Wrong Input for Monthly Salary", "Error");
            }
            else
            {
                if (TotalCurrentPercentage.Text == "100")
                {
                    double MS = Convert.ToDouble(MonthlySalaryTextBox.Text);
                    double DEP = Convert.ToDouble(DomesticExpensesPercentageTextBox.Text);
                    double PEP = Convert.ToDouble(PersonalExpensesPercentageTextBox.Text);
                    double SVP = Convert.ToDouble(SavingsPercentageTextBox.Text);
                    double DE, PE, SV;
                    DE = MS * DEP / 100;
                    PE = MS * PEP / 100;
                    SV = MS * SVP / 100;
                    DomesticExpensesTotalTextBox.Text = Math.Round(DE, 2).ToString();
                    PersonalExpensesTotalTextBox.Text = Math.Round(PE, 2).ToString();
                    SavingsTotalTextBox.Text = Math.Round(SV, 2).ToString();

                }
                else MessageBox.Show("Total percentage is not equal to 100.\nPlease make sure that the total percentage is equal to 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DomesticExpensesPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DomesticExpensesPercentageTextBox.Text == "")
                DomesticExpensesPercentageTextBox.Text = "0";
            p1 = Convert.ToInt32(DomesticExpensesPercentageTextBox.Text);
            CalculateCurrentPercent();
        }

        private void PersonalExpensesPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PersonalExpensesPercentageTextBox.Text == "")
                PersonalExpensesPercentageTextBox.Text = "0";
            p2 = Convert.ToInt32(PersonalExpensesPercentageTextBox.Text);
            CalculateCurrentPercent();
        }

        private void SavingsPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SavingsPercentageTextBox.Text == "")
                SavingsPercentageTextBox.Text = "0";
            p3 = Convert.ToInt32(SavingsPercentageTextBox.Text);
            CalculateCurrentPercent();
        }

        private void CalculateCurrentPercent()
        {
            totalPercent = 0;
            
           
           
            totalPercent = p1 + p2 + p3;
            TotalCurrentPercentage.Text = totalPercent.ToString();
        }

        private void DomesticExpensesPercentageTextBox_Click(object sender, EventArgs e)
        {
            DomesticExpensesPercentageTextBox.SelectAll();
        }

        private void PersonalExpensesPercentageTextBox_Click(object sender, EventArgs e)
        {
            PersonalExpensesPercentageTextBox.SelectAll();
        }

        private void SavingsPercentageTextBox_Click(object sender, EventArgs e)
        {
            SavingsPercentageTextBox.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void TotalCurrentPercentage_TextChanged(object sender, EventArgs e)
        {
            if (TotalCurrentPercentage.Text == "100")
            {
                TotalCurrentPercentage.ForeColor = Color.Green;
            }
            else TotalCurrentPercentage.ForeColor = Color.Red;
        }
    }
}
