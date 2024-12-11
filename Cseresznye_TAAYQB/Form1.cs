namespace Cseresznye_TAAYQB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                form2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            if (form3.DialogResult == DialogResult.OK) { form3.Close(); }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan kilépsz, nem biztos, hogy újra mûködni fog!?", "Kilépés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}