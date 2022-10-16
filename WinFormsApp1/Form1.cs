namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
            {
                textBox_result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text = textBox_result.Text + button.Text;

                }
            }
            else
                textBox_result.Text = textBox_result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button23.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}