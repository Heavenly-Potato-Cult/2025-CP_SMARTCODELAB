using MaterialSkin;
using MaterialSkin.Controls;
using SmartCodeLab.CustomComponents.Pages;

namespace SmartCodeLab
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            //var skin = MaterialSkinManager.Instance;
            //skin.AddFormToManage(this);
            //skin.Theme = MaterialSkinManager.Themes.DARK;
            //skin.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void openFile1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Select a file";
                openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFile.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonitoringForm monitoringForm = new MonitoringForm();
            monitoringForm.ShowDialog();
        }
    }
}
