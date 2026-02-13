using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private TaskSolver _solver = new TaskSolver();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcTask1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);

                double result = _solver.SolveTask1(x, y);

                lblResult1.Text = $"Результат: {result:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcTask2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                string result = _solver.SolveTask2(a, b, c);

                lblResult2.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні числа.");
            }
        }

        private void btnCalcTask3_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxN.Text);

                bool result = _solver.SolveTask3(n);

                if (result)
                {
                    lblResult3.Text = "True (Істина)";
                    lblResult3.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResult3.Text = "False (Брехня)";
                    lblResult3.ForeColor = System.Drawing.Color.Red;   
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть ціле число (не дробове).");
            }
        }

        private void btnCalcTask4_Click(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(textBoxCost.Text);
                double money = double.Parse(textBoxMoney.Text);

                if (cost < 0 || money < 0)
                {
                    MessageBox.Show("Суми не можуть бути від'ємними!");
                    return;
                }

                string result = _solver.SolveTask4(cost, money);

                lblResult4.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні суми (цифри).");
            }
        }

        private void btnCalcTask5_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxN5.Text);

                if (n <= 1)
                {
                    MessageBox.Show("Введіть число більше 1.");
                    return;
                }

                string perfectNumbers = _solver.SolveTask5(n);

                lblResult5.Text = $"Досконалі числа: {perfectNumbers}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректне ціле число.");
            }
        }

        private void btnCalcTask6_Click(object sender, EventArgs e)
        {
            try
            {
                string rawArray = textBoxArray.Text;

                int k = int.Parse(textBoxK.Text);

                if (k < 0 || k > 9)
                {
                    MessageBox.Show("k має бути цифрою від 0 до 9!");
                    return;
                }

                string result = _solver.SolveTask6(rawArray, k);

                lblResult6.Text = $"Новий масив: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте коректність введених даних.");
            }
        }

        private void btnCalcTask7_Click(object sender, EventArgs e)
        {
            string text = textBoxText.Text;

            string result = _solver.SolveTask7(text);

            lblResult7.Text = result;
        }
    }
}