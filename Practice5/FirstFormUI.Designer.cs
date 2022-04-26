namespace Practice5
{
	partial class FirstFormUI
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
			this.m_btnShowForm2 = new System.Windows.Forms.Button();
			this.m_lblDisplay = new System.Windows.Forms.Label();
			this.m_btnEnd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ShowForm2
			// 
			this.m_btnShowForm2.Location = new System.Drawing.Point( 415, 51 );
			this.m_btnShowForm2.Name = "ShowForm2";
			this.m_btnShowForm2.Size = new System.Drawing.Size( 75, 23 );
			this.m_btnShowForm2.TabIndex = 0;
			this.m_btnShowForm2.Text = "Show Form2";
			this.m_btnShowForm2.UseVisualStyleBackColor = true;
			this.m_btnShowForm2.Click += new System.EventHandler( this.ShowForm2_Click );
			// 
			// label1
			// 
			this.m_lblDisplay.AutoSize = true;
			this.m_lblDisplay.Location = new System.Drawing.Point( 436, 149 );
			this.m_lblDisplay.Name = "label1";
			this.m_lblDisplay.Size = new System.Drawing.Size( 33, 12 );
			this.m_lblDisplay.TabIndex = 1;
			this.m_lblDisplay.Text = "label1";
			// 
			// End
			// 
			this.m_btnEnd.Location = new System.Drawing.Point( 415, 322 );
			this.m_btnEnd.Name = "End";
			this.m_btnEnd.Size = new System.Drawing.Size( 75, 23 );
			this.m_btnEnd.TabIndex = 2;
			this.m_btnEnd.Text = "End";
			this.m_btnEnd.UseVisualStyleBackColor = true;
			this.m_btnEnd.Click += new System.EventHandler( this.End_Click );
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 556, 398 );
			this.Controls.Add( this.m_btnEnd );
			this.Controls.Add( this.m_lblDisplay );
			this.Controls.Add( this.m_btnShowForm2 );
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnShowForm2;
		private System.Windows.Forms.Label m_lblDisplay;
		private System.Windows.Forms.Button m_btnEnd;
	}
}

