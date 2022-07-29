namespace Loteria_nacional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Random q = new Random();
        public int n1, n2, n3, n4, n5;

        private void button1_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(txtNumero.text);
            n1 = q.Next(0, 100);
            n2 = q.Next(0, 99);
            n3= q.Next(0, 99);
            n4= q.Next(0, 99);
            n5= q.Next(0, 99);

            txtn1.Text = n1.ToString();
            txtn2.Text = n2.ToString();
            txtn3.Text = n3.ToString();
           
            private void textn1_TextChanged(object sender, EventArgs e)
        {

        }
private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        public double numero;




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}