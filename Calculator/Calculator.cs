namespace Calculator
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (inputDisplayBox.Text == "0")
            {
                inputDisplayBox.Clear();
            }

            Button btn = (Button)sender;
            inputDisplayBox.Text += btn.Text;
        }


        private void btnBackspace_Click(object sender, EventArgs e)
        {
            inputDisplayBox.Clear();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            resultValue = Double.Parse(inputDisplayBox.Text);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            inputDisplayBox.Text = "0";
            resultValue = 0;
        }

        private void equatTo_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    inputDisplayBox.Text = (resultValue + Double.Parse(inputDisplayBox.Text)).ToString();
                    break;

                case "-":
                    inputDisplayBox.Text = (resultValue - Double.Parse(inputDisplayBox.Text)).ToString();
                    break;

                case "*":
                    inputDisplayBox.Text = (resultValue * Double.Parse(inputDisplayBox.Text)).ToString();
                    break;

                case "/":
                    inputDisplayBox.Text = (resultValue / Double.Parse(inputDisplayBox.Text)).ToString();
                    break;

                case "sqrt":

                    break;

                case "pow":

                    break;

                case "%":

                    break;
                default:
                    break;
            }
        }
    }
}