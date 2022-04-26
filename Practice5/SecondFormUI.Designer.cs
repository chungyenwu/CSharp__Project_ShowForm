namespace Practice5
{
	partial class SecondFormUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnTriggerEvent1 = new System.Windows.Forms.Button();
			this.m_btnTriggerEvent2 = new System.Windows.Forms.Button();
			this.m_btnHide = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_TriggerEvent1
			// 
			this.m_btnTriggerEvent1.Location = new System.Drawing.Point( 82, 32 );
			this.m_btnTriggerEvent1.Name = "btn_TriggerEvent1";
			this.m_btnTriggerEvent1.Size = new System.Drawing.Size( 123, 46 );
			this.m_btnTriggerEvent1.TabIndex = 0;
			this.m_btnTriggerEvent1.Text = "TriggerEvent1";
			this.m_btnTriggerEvent1.UseVisualStyleBackColor = true;
			this.m_btnTriggerEvent1.Click += new System.EventHandler( this.btn_TriggerEvent1_Click );
			// 
			// btn_TriggerEvent2
			// 
			this.m_btnTriggerEvent2.Location = new System.Drawing.Point( 82, 102 );
			this.m_btnTriggerEvent2.Name = "btn_TriggerEvent2";
			this.m_btnTriggerEvent2.Size = new System.Drawing.Size( 123, 46 );
			this.m_btnTriggerEvent2.TabIndex = 1;
			this.m_btnTriggerEvent2.Text = "TriggerEvent2";
			this.m_btnTriggerEvent2.UseVisualStyleBackColor = true;
			this.m_btnTriggerEvent2.Click += new System.EventHandler( this.btn_TriggerEvent2_Click );
			// 
			// btn_Hide
			// 
			this.m_btnHide.Location = new System.Drawing.Point( 82, 171 );
			this.m_btnHide.Name = "btn_Hide";
			this.m_btnHide.Size = new System.Drawing.Size( 123, 49 );
			this.m_btnHide.TabIndex = 2;
			this.m_btnHide.Text = "Hide";
			this.m_btnHide.UseVisualStyleBackColor = true;
			this.m_btnHide.Click += new System.EventHandler( this.btn_Hide_Click );
			// 
			// SecondFormUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 284, 261 );
			this.Controls.Add( this.m_btnHide );
			this.Controls.Add( this.m_btnTriggerEvent2 );
			this.Controls.Add( this.m_btnTriggerEvent1 );
			this.Name = "SecondFormUI";
			this.Text = "Form2";
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Button m_btnTriggerEvent1;
		private System.Windows.Forms.Button m_btnTriggerEvent2;
		private System.Windows.Forms.Button m_btnHide;
	}
}