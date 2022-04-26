using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice5
{
	public partial class SecondFormUI : Form
	{
		// Delegate for Click Trigger 
		public delegate void TriggerEventClickHandler( string szString );
		// Event for Click Trigger
		public event TriggerEventClickHandler TriggerEvent;
		
		public SecondFormUI()
		{
			InitializeComponent();
			m_SecondFuncCore = new SecondFormFunc();
			m_SecondFuncCore.TriggerEvent += new SecondFormFunc.TriggerEventClickHandler( HandleTrigger );
		}
	}

	public partial class SecondFormUI : Form
	{
		SecondFormFunc m_SecondFuncCore;

		private void btn_TriggerEvent1_Click( object sender, EventArgs e )
		{
			m_SecondFuncCore.TriggerEvent1();
		}

		private void btn_TriggerEvent2_Click( object sender, EventArgs e )
		{
			m_SecondFuncCore.TriggerEvent2();
		}

		private void btn_Hide_Click( object sender, EventArgs e )
		{
			Hide();
		}

		public void HandleTrigger( string szString )
		{
			TriggerEvent( szString );
		}
	}
}
