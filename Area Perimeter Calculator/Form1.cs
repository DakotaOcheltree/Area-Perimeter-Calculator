namespace Area_Perimeter_Calculator
{
    public partial class FormAreaPerimeterCalc : Form
    {
        public FormAreaPerimeterCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double Length = Convert.ToDouble(txtLength.Text);//Convert.ToDouble converts String to Double
            double Width = Convert.ToDouble(txtWidth.Text);

            //Calculate Perimeter
            double Perimeter = (Width + Width) + (Length + Length);

            //Display Perimeter
            txtPerimeter.Text = Perimeter.ToString();

            //Calculate Area
            double Area = Width * Length;

            //Display Area
            txtArea.Text = Area.ToString();
        }
    }
}