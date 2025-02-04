
namespace PesticideSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            enemyButton0 = new Button();
            enemyButton1 = new Button();
            SuspendLayout();
            // 
            // enemyButton0
            // 
            enemyButton0.BackColor = Color.Transparent;
            enemyButton0.BackgroundImage = Properties.Resources.Enemy;
            enemyButton0.BackgroundImageLayout = ImageLayout.Stretch;
            enemyButton0.Cursor = Cursors.Hand;
            enemyButton0.FlatAppearance.BorderSize = 0;
            enemyButton0.FlatAppearance.MouseDownBackColor = Color.Transparent;
            enemyButton0.FlatAppearance.MouseOverBackColor = Color.Transparent;
            enemyButton0.FlatStyle = FlatStyle.Flat;
            enemyButton0.ForeColor = SystemColors.ControlText;
            enemyButton0.Location = new Point(212, 206);
            enemyButton0.Name = "enemyButton0";
            enemyButton0.Size = new Size(50, 50);
            enemyButton0.TabIndex = 0;
            enemyButton0.Text = " ";
            enemyButton0.UseVisualStyleBackColor = false;
            enemyButton0.Click += enemy0_Click;
            // 
            // enemyButton1
            // 
            enemyButton1.BackColor = Color.Transparent;
            enemyButton1.BackgroundImage = Properties.Resources.Enemy;
            enemyButton1.BackgroundImageLayout = ImageLayout.Stretch;
            enemyButton1.Cursor = Cursors.Hand;
            enemyButton1.FlatAppearance.BorderSize = 0;
            enemyButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            enemyButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            enemyButton1.FlatStyle = FlatStyle.Flat;
            enemyButton1.ForeColor = SystemColors.ControlText;
            enemyButton1.Location = new Point(230, 31);
            enemyButton1.Name = "enemyButton1";
            enemyButton1.Size = new Size(50, 50);
            enemyButton1.TabIndex = 1;
            enemyButton1.Text = " ";
            enemyButton1.UseVisualStyleBackColor = false;
            enemyButton1.Click += enemy1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(577, 554);
            Controls.Add(enemyButton1);
            Controls.Add(enemyButton0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesticide simulator";
            Load += Form1_Load;
            ResumeLayout(false);
        }



        #endregion

        private Button enemyButton0;
        private Button enemyButton1;
    }
}
