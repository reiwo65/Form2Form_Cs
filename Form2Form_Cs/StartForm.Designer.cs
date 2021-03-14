
namespace Form2Form_Cs
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartForm2 = new System.Windows.Forms.Button();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.lbxAntwort = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Info-Text";
            // 
            // btnStartForm2
            // 
            this.btnStartForm2.Location = new System.Drawing.Point(291, 131);
            this.btnStartForm2.Name = "btnStartForm2";
            this.btnStartForm2.Size = new System.Drawing.Size(94, 23);
            this.btnStartForm2.TabIndex = 4;
            this.btnStartForm2.Text = "Form 2 erstellen";
            this.btnStartForm2.UseVisualStyleBackColor = true;
            this.btnStartForm2.Click += new System.EventHandler(this.btnStartForm2_Click);
            // 
            // tbxInfo
            // 
            this.tbxInfo.Location = new System.Drawing.Point(40, 50);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(236, 20);
            this.tbxInfo.TabIndex = 3;
            // 
            // lbxAntwort
            // 
            this.lbxAntwort.FormattingEnabled = true;
            this.lbxAntwort.Location = new System.Drawing.Point(40, 100);
            this.lbxAntwort.Name = "lbxAntwort";
            this.lbxAntwort.Size = new System.Drawing.Size(181, 56);
            this.lbxAntwort.TabIndex = 6;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 251);
            this.Controls.Add(this.lbxAntwort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartForm2);
            this.Controls.Add(this.tbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "StartForm C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartForm2;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.ListBox lbxAntwort;
    }
}

