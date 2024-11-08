using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command_project_girls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (comboBox1.SelectedItem.ToString() == "Веселий")
            {
                label3.Text = "Стан радості та щастя, коли людина відчуває піднесеність і внутрішнє тепло.\n" +
                    " Цей настрій часто супроводжується усмішкою та бажанням ділитися позитивом з іншими.";

                pictureBox1.Image = Image.FromFile(@"D:\ЛОКАЛЬНИЙ ДИСК С\Videos\Знімок екрана 2024-10-22 092428.png");
                pictureBox1.Refresh();

                dataGridView1.Rows.Clear();
                try
                {
                    foreach (var line in File.ReadLines("1Happy.txt"))
                    {
                        var array = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        dataGridView1.Rows.Add(array);
                    }
                }
                catch (Exception ex){  }
            }

            if (comboBox1.SelectedItem.ToString() == "Сумний")
            {
                label3.Text = "Настрій меланхолії чи смутку.\n" +
                    " Людина може відчувати себе відокремленою від світу, переживати втрату чи розчарування.\n" +
                    "Цей стан часто спонукає до роздумів або усамітнення.";

                pictureBox1.Image = Image.FromFile(@"D:\ЛОКАЛЬНИЙ ДИСК С\Videos\2memy.jpeg");
                pictureBox1.Refresh();
                dataGridView1.Rows.Clear();

                try
                {
                    foreach (var line in File.ReadLines("2Sad.txt"))
                    {
                        var array = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        dataGridView1.Rows.Add(array);
                    }
                }
                catch (Exception ex) { }

            }

            if (comboBox1.SelectedItem.ToString() == "Енергійний")
            {
                label3.Text = "Відчуття припливу сил та енергії.\n" +
                    " Людина повна бажання діяти, вирішувати завдання і зосереджуватися на активній діяльності.";

                pictureBox1.Image = Image.FromFile(@"D:\ЛОКАЛЬНИЙ ДИСК С\Videos\images (1).jfif");
                pictureBox1.Refresh();
            }

        }
    }

   
}
