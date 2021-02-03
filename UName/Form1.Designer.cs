
namespace UName
{
	partial class frmMeinName
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMeinName = new System.Windows.Forms.Button();
			this.btnEnde = new System.Windows.Forms.Button();
			this.lblMeinName = new System.Windows.Forms.Label();
			this.btnGrößeÄndern = new System.Windows.Forms.Button();
			this.btnHoch = new System.Windows.Forms.Button();
			this.btnRunter = new System.Windows.Forms.Button();
			this.btnMeineInformationen = new System.Windows.Forms.Button();
			this.btnFarbeÄndern = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMeinName
			// 
			this.btnMeinName.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnMeinName.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnMeinName.Location = new System.Drawing.Point(25, 94);
			this.btnMeinName.Name = "btnMeinName";
			this.btnMeinName.Size = new System.Drawing.Size(191, 58);
			this.btnMeinName.TabIndex = 0;
			this.btnMeinName.Text = "Mein Name";
			this.btnMeinName.UseVisualStyleBackColor = false;
			this.btnMeinName.Click += new System.EventHandler(this.btnMeinName_Click);
			// 
			// btnEnde
			// 
			this.btnEnde.Location = new System.Drawing.Point(293, 94);
			this.btnEnde.Name = "btnEnde";
			this.btnEnde.Size = new System.Drawing.Size(171, 60);
			this.btnEnde.TabIndex = 1;
			this.btnEnde.Text = "Ende";
			this.btnEnde.UseVisualStyleBackColor = true;
			this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
			// 
			// lblMeinName
			// 
			this.lblMeinName.AutoSize = true;
			this.lblMeinName.Location = new System.Drawing.Point(31, 266);
			this.lblMeinName.Name = "lblMeinName";
			this.lblMeinName.Size = new System.Drawing.Size(51, 20);
			this.lblMeinName.TabIndex = 2;
			this.lblMeinName.Text = "label1";
			// 
			// btnGrößeÄndern
			// 
			this.btnGrößeÄndern.Location = new System.Drawing.Point(293, 217);
			this.btnGrößeÄndern.Name = "btnGrößeÄndern";
			this.btnGrößeÄndern.Size = new System.Drawing.Size(171, 69);
			this.btnGrößeÄndern.TabIndex = 3;
			this.btnGrößeÄndern.Text = "Größe btnMeinName ändern";
			this.btnGrößeÄndern.UseVisualStyleBackColor = true;
			this.btnGrößeÄndern.Click += new System.EventHandler(this.btnGrößeÄndern_Click);
			// 
			// btnHoch
			// 
			this.btnHoch.Location = new System.Drawing.Point(293, 306);
			this.btnHoch.Name = "btnHoch";
			this.btnHoch.Size = new System.Drawing.Size(171, 61);
			this.btnHoch.TabIndex = 4;
			this.btnHoch.Text = "Hoch";
			this.btnHoch.UseVisualStyleBackColor = true;
			this.btnHoch.Click += new System.EventHandler(this.btnHoch_Click);
			// 
			// btnRunter
			// 
			this.btnRunter.Location = new System.Drawing.Point(293, 391);
			this.btnRunter.Name = "btnRunter";
			this.btnRunter.Size = new System.Drawing.Size(171, 63);
			this.btnRunter.TabIndex = 5;
			this.btnRunter.Text = "Runter";
			this.btnRunter.UseVisualStyleBackColor = true;
			this.btnRunter.Click += new System.EventHandler(this.btnRunter_Click);
			// 
			// btnMeineInformationen
			// 
			this.btnMeineInformationen.Location = new System.Drawing.Point(25, 168);
			this.btnMeineInformationen.Name = "btnMeineInformationen";
			this.btnMeineInformationen.Size = new System.Drawing.Size(191, 64);
			this.btnMeineInformationen.TabIndex = 6;
			this.btnMeineInformationen.Text = "Meine Informationen";
			this.btnMeineInformationen.UseVisualStyleBackColor = true;
			this.btnMeineInformationen.Click += new System.EventHandler(this.btnMeineInformationen_Click);
			// 
			// btnFarbeÄndern
			// 
			this.btnFarbeÄndern.Location = new System.Drawing.Point(293, 475);
			this.btnFarbeÄndern.Name = "btnFarbeÄndern";
			this.btnFarbeÄndern.Size = new System.Drawing.Size(171, 62);
			this.btnFarbeÄndern.TabIndex = 7;
			this.btnFarbeÄndern.Text = "Farbe ändern";
			this.btnFarbeÄndern.UseVisualStyleBackColor = true;
			this.btnFarbeÄndern.Click += new System.EventHandler(this.btnFarbeÄndern_Click);
			// 
			// frmMeinName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 625);
			this.Controls.Add(this.btnFarbeÄndern);
			this.Controls.Add(this.btnMeineInformationen);
			this.Controls.Add(this.btnRunter);
			this.Controls.Add(this.btnHoch);
			this.Controls.Add(this.btnGrößeÄndern);
			this.Controls.Add(this.lblMeinName);
			this.Controls.Add(this.btnMeinName);
			this.Controls.Add(this.btnEnde);
			this.Name = "frmMeinName";
			this.Text = "UName";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMeinName;
		private System.Windows.Forms.Button btnEnde;
		private System.Windows.Forms.Label lblMeinName;
		private System.Windows.Forms.Button btnGrößeÄndern;
		private System.Windows.Forms.Button btnHoch;
		private System.Windows.Forms.Button btnRunter;
		private System.Windows.Forms.Button btnMeineInformationen;
		private System.Windows.Forms.Button btnFarbeÄndern;
	}
}

