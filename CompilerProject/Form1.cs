using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerProject
{

    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThcolor()
        {
            int index = random.Next(Tabs.Colorlist.Count);
            while (tempIndex == index)
            {
               index= random.Next(Tabs.Colorlist.Count);
            }
            tempIndex = index;
            string color = Tabs.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender) {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableBtn();
                    Color color = SelectThcolor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
                    panelTitleBar.BackColor = color;
                    panalLogo.BackColor = Tabs.ChangeColorBrightness(color, -0.3);
                    Tabs.PrimaryColor = color;
                    Tabs.SecondaryColor = Tabs.ChangeColorBrightness(color, -0.3);
                    
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void DisableBtn()
        {
             foreach(Control previousBtn in panalMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(87, 96, 111);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }     
            
            }
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormScanner(), sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormParser(), sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableBtn();
           // lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panalLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            button1.Visible = false;
        }

    }
}
