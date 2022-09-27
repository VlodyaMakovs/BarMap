using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProj
{
    public partial class Form1 : Form
    {

        UserData userData;

        public Form1()
        {
            InitializeComponent();
            userData = new UserData(-1, null, null, null, -1);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
