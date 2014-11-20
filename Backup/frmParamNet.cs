using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDMAgent
{
	public partial class frmParamNet : Form
	{
		// 父窗口, 用来传递父窗口并更新变更
		private frmMain m_frmParent;

		public frmParamNet(frmMain parent)
		{
			m_frmParent = parent;

			InitializeComponent();

			txtIP.Text = m_frmParent.m_serverIP;
			txtPort.Text = Convert.ToString(m_frmParent.m_serverPort);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string serverIP = txtIP.Text;
			int serverPort = Convert.ToInt32(txtPort.Text);
			if (serverIP != m_frmParent.m_serverIP)
				m_frmParent.m_serverIP = serverIP;
			if (serverPort != m_frmParent.m_serverPort)
				m_frmParent.m_serverPort = serverPort;
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
