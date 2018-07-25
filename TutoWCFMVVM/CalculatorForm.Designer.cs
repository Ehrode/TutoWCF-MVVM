namespace TutoWCFMVVM
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(174, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "=";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.CustomBackground = true;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox3.Location = new System.Drawing.Point(199, 63);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(100, 35);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.TabIndex = 2;
            this.metroTextBox3.Text = "0";
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.UseStyleColors = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CustomBackground = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Location = new System.Drawing.Point(23, 63);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(51, 35);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "0";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseStyleColors = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.CustomBackground = true;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox2.Location = new System.Drawing.Point(121, 63);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(51, 35);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Text = "0";
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.UseStyleColors = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(80, 63);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(35, 35);
            this.metroComboBox1.TabIndex = 6;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 106);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.Name = "CalculatorForm";
            this.Text = "Online Calculator";
            this.Load += new System.EventHandler(this.ItemFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

