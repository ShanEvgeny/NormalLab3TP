namespace Лаб3нормальнаяТП
{
    public partial class Form1 : Form
    {
        private Set set1 = new Set(new List<int>());
        private Set set2 = new Set(new List<int>());
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Calculate()
        {
            try
            {
                int number;
                var resultSet = new Set(new List<int>());
                switch (comboBox2.Text)
                {
                    case "добавить":
                        number = int.Parse(textBox3.Text);
                        set1 = set1 + number;
                        textBox1.Text = set1.ToString();
                        break;
                    case "удалить":
                        number = int.Parse(textBox3.Text);
                        set1 = set1 - number;
                        textBox1.Text = set1.ToString();
                        break;
                }
                switch (comboBox3.Text)
                {
                    case "добавить":
                        number = int.Parse(textBox4.Text);
                        set2 = set2 + number;
                        textBox2.Text = set2.ToString();
                        break;
                    case "удалить":
                        number = int.Parse(textBox4.Text);
                        set2 = set2 - number;
                        textBox2.Text = set2.ToString();
                        break;
                }
                switch (comboBox1.Text)
                {
                    case "+":
                        resultSet = set1 + set2;
                        break;
                    case "-":
                        resultSet = set1 - set2;
                        break;
                    case "*":
                        resultSet = set1 * set2;
                        break;
                }
                textBox5.Text = resultSet.ToString();
            }
            catch (FormatException)
            {

            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var number = Int32.Parse(textBox4.Text);
            switch (comboBox3.Text)
            {
                case "добавить":
                    set2 = set2.AddNumber(number);
                    break;
                case "удалить":
                    set2 = set2.DeleteNumber(number);
                    break;
            }
            textBox2.Text = set1.ToString();*/
            Calculate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}