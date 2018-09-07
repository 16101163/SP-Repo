using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class UCNotification1 : UserControl
    {
        

        
        public UCNotification1()
        {
            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCCreateTemplate CreateTemplate = new UCCreateTemplate();
            //panel4.Controls.Add(CreateTemplate);
            CreateTemplate.BringToFront();
            CreateTemplate.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCSearchTemplate SearchTemplate = new UCSearchTemplate("Maintain Template");
            //panel4.Controls.Add(SearchTemplate);
            SearchTemplate.BringToFront();
            SearchTemplate.Dock = DockStyle.Fill;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UCSearchTemplate notification = new UCSearchTemplate("Publish Template");
            //panel4.Controls.Add(notification);
            notification.BringToFront();
            notification.Dock = DockStyle.Fill;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCNotification1_Load(object sender, EventArgs e)
        {

        }
    }
}
