using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsTileMaker.Forms
{
    public partial class FrmNewGridForm : Form
    {
        private int iD;

        /// <summary>
        /// returns TypeID
        /// </summary>
        public int ID
        {
            get { return this.iD; }
        }

        public FrmNewGridForm()
        {
            InitializeComponent();
        }

        #region CheckChanged
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.iD = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.iD = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.iD = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.iD = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.iD = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.iD = 6;
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
