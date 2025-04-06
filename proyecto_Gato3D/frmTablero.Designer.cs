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
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // bntMenu
            // 
            bntMenu.BackColor = Color.Black;
            bntMenu.FlatStyle = FlatStyle.Flat;
            bntMenu.Font = new Font("Rockwell", 20F);
            bntMenu.ForeColor = Color.White;
            bntMenu.Location = new Point(10, 627);
            bntMenu.Margin = new Padding(3, 2, 3, 2);
            bntMenu.Name = "bntMenu";
            bntMenu.Size = new Size(270, 52);
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
            btnExit.Location = new Point(10, 691);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(270, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Black;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Rockwell", 20F);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(10, 557);
            btnReiniciar.Margin = new Padding(3, 2, 3, 2);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(270, 52);
            btnReiniciar.TabIndex = 4;
            btnReiniciar.Text = "Restart";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // frmTablero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(903, 752);
            Controls.Add(btnReiniciar);
            Controls.Add(btnExit);
            Controls.Add(bntMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTablero";
            Text = "Gato 3D";
            ResumeLayout(false);
        }

        #endregion

        private Button bntMenu;
        private Button btnExit;
        private Button btnReiniciar;
    }
}
