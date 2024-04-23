namespace lab2miniraknare
{
    public partial class Form1 : Form
    {
        double ResultValue = 0;
        String Operationperformed = "";
        bool istheoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (istheoperationperformed))
            {
                Result.Clear();
            }
                istheoperationperformed = false;
                Button button = (Button)sender;

            if (Result.Text.Length < 9)
            {
                Result.Text = Result.Text + button.Text;
            }
            else { MessageBox.Show($" cant add more than 9 numbers{double.MaxValue}"); }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                button15.PerformClick();
                Operationperformed = button.Text;
                label1.Text = ResultValue + " " + Operationperformed;
                istheoperationperformed = true;
            }
            else
            {
                Operationperformed = button.Text;
                ResultValue = Double.Parse(Result.Text);
                label1.Text = ResultValue + " " + Operationperformed;
                istheoperationperformed = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            ResultValue= 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (Operationperformed)
            {
                  
                case "+":
                    if (Result.Text.Length < 9)
                    {
                        Result.Text = (ResultValue + Double.Parse(Result.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show($" cant add more than 9 numbers"); 
                    }
                    break;
                case "-":
                    if (Result.Text.Length < 9)
                    {
                        Result.Text = (ResultValue - Double.Parse(Result.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show($" cant add more than 9 numbers");
                    }
                    break;
                case "x":
                    if (Result.Text.Length < 9)
                    {
                        Result.Text = (ResultValue * Double.Parse(Result.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show($" cant add more than 9 numbers");
                    }
                    break;
                case "/":
                    if (Result.Text.Length < 9)
                    {
                        if (Double.Parse(Result.Text) != 0)
                        {
                            Result.Text = (ResultValue / Double.Parse(Result.Text)).ToString();
                        }
                        else
                        {
                            Result.Text = "0";
                            ResultValue = 0;
                            MessageBox.Show($" cant divide by 0 ");
                        }
                    }
                    else
                    {
                        MessageBox.Show($" cant add more than 9 numbers");
                    }
                    break;
                default:
                    break;
           

        }
                ResultValue = Double.Parse(Result.Text);
                label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}