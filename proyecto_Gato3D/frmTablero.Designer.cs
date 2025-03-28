namespace proyecto_Gato3D
{
    partial class frmTablero
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
            bntMenu = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // bntMenu
            // 
            bntMenu.BackColor = Color.Black;
            bntMenu.FlatStyle = FlatStyle.Flat;
            bntMenu.Font = new Font("Rockwell", 20F);
            bntMenu.ForeColor = Color.White;
            bntMenu.Location = new Point(12, 836);
            bntMenu.Name = "bntMenu";
            bntMenu.Size = new Size(308, 70);
            bntMenu.TabIndex = 2;
            bntMenu.Text = "Menu";
            bntMenu.UseVisualStyleBackColor = false;
            bntMenu.Click += bntMenu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Rockwell", 20F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(12, 921);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(308, 70);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmTablero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1032, 1003);
            Controls.Add(btnExit);
            Controls.Add(bntMenu);
            Name = "frmTablero";
            Text = "Gato 3D";
            ResumeLayout(false);
        }

        #endregion

        private Button bntMenu;
        private Button btnExit;
    }
}
