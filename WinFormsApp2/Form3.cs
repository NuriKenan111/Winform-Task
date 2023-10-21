using winformTask1.Properties;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Image = Resources.flame_towers_by_HOK_illuminate_baku_s_historic_waterfront;
            button1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Image = Resources.london;
            button2.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
        }
    }
}
