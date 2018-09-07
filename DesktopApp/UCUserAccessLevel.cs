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
    public partial class UCUserAccessLevel : UserControl
    {
        public UCUserAccessLevel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCRegisterUser user = new UCRegisterUser();
            panel4.Controls.Add(user);
            user.BringToFront();
            user.Dock = DockStyle.Fill;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UCAddAccessLevel accessLevel = new UCAddAccessLevel();
            panel4.Controls.Add(accessLevel);
            accessLevel.BringToFront();
            accessLevel.Dock = DockStyle.Fill;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCMaintainUser maintainUser = new UCMaintainUser();
            panel4.Controls.Add(maintainUser);
            maintainUser.BringToFront();
            maintainUser.Dock = DockStyle.Fill;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            UCMaintainAccessLevel maintainAccessL = new UCMaintainAccessLevel();
            panel4.Controls.Add(maintainAccessL);
            maintainAccessL.BringToFront();
            maintainAccessL.Dock = DockStyle.Fill;
        }
    }
}
