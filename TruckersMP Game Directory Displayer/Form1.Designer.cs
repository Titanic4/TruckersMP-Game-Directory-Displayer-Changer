namespace TruckersMP_Game_Directory_Displayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameVer = new System.Windows.Forms.TextBox();
            this.InstallDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DirChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameVer
            // 
            this.GameVer.Location = new System.Drawing.Point(309, 12);
            this.GameVer.Name = "GameVer";
            this.GameVer.ReadOnly = true;
            this.GameVer.Size = new System.Drawing.Size(102, 20);
            this.GameVer.TabIndex = 0;
            this.GameVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InstallDir
            // 
            this.InstallDir.Location = new System.Drawing.Point(12, 12);
            this.InstallDir.Name = "InstallDir";
            this.InstallDir.ReadOnly = true;
            this.InstallDir.Size = new System.Drawing.Size(291, 20);
            this.InstallDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Installation Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version";
            // 
            // GameSelect
            // 
            this.GameSelect.FormattingEnabled = true;
            this.GameSelect.Location = new System.Drawing.Point(100, 69);
            this.GameSelect.Name = "GameSelect";
            this.GameSelect.Size = new System.Drawing.Size(121, 21);
            this.GameSelect.TabIndex = 4;
            this.GameSelect.SelectionChangeCommitted += new System.EventHandler(this.GameSelect_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select game";
            // 
            // DirChange
            // 
            this.DirChange.Location = new System.Drawing.Point(272, 66);
            this.DirChange.Name = "DirChange";
            this.DirChange.Size = new System.Drawing.Size(102, 25);
            this.DirChange.TabIndex = 6;
            this.DirChange.Text = "Change directory";
            this.DirChange.UseVisualStyleBackColor = true;
            this.DirChange.Click += new System.EventHandler(this.DirChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(437, 114);
            this.Controls.Add(this.DirChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GameSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstallDir);
            this.Controls.Add(this.GameVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TruckersMP Game Directory Changer/Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GameVer;
        private System.Windows.Forms.TextBox InstallDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GameSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DirChange;
    }
}

