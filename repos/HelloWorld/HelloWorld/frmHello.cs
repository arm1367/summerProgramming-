using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * My first C# Windows Form app.
 * It Illustrates customizing the FORM and using labels, text boxes and buttons.
 * Author: Alejandro ROjas 
 * Date: 26/08/2020
 * */

namespace HelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }
        // Customize greeting
        private void btnGreet_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello " + txtName.Text;
        }
    }
}
