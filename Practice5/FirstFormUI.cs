using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice5
{
	public partial class FirstFormUI : Form
	{
		public FirstFormUI()
		{
			InitializeComponent();
			m_SecondForm = new SecondFormUI();
			m_SecondForm.TriggerEvent += new SecondFormUI.TriggerEventClickHandler( ShowTriggerEvent );
		}
	}

	public partial class FirstFormUI : Form
	{
		SecondFormUI m_SecondForm;

		private void ShowForm2_Click( object sender, EventArgs e )
		{
			m_SecondForm.Show();
		}

		private void End_Click( object sender, EventArgs e )
		{
			Close();
			Environment.Exit( Environment.ExitCode );
		}

		private void ShowTriggerEvent( string szEventString )
		{
			// Event Trigger
			m_lblDisplay.Text = szEventString;
		}

	}
}