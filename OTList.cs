using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DDMAgent
{
    public partial class frmOTList : Form
    {
        private frmMain frmParent;
        OTManager otMgr;
        public string otItem = "";

        public frmOTList()
        {
            InitializeComponent();
        }

        public frmOTList(frmMain frmMain)
        {
            // TODO: Complete member initialization
            this.frmParent = frmMain;

            InitializeComponent();



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxOTList.Items.Add("1123");
        }



        public void AddOTList()
        {
            listBoxOTList.Items.Add(otItem);
        }

        public delegate void AddOTList_dl();

        public void CallDelegate()
        {
            this.BeginInvoke(new AddOTList_dl(AddOTList));
        }

        private void frmOTList_Load(object sender, EventArgs e)
        {
            otMgr = new OTManager(this);
            otMgr.Run(9999);
        }

        private void frmOTList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }



    }
}
