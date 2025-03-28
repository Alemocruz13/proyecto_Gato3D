namespace proyecto_Gato3D
{
    public partial class frmTablero : Form
    {
        int turno = 0;
        public frmTablero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            for (int i = 0; i < 3; i++)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = new Size(300, 300);
                panel.Location = new Point(50 + (i * 300), 50 + (i * 300));
                panel.Name = "panel" + i;
                panel.BackColor = Color.Black;
                this.Controls.Add(panel);

                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 100);
                    btn.Name = "p" + i + "btn" + j;
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                    btn.Margin = new Padding(0);
                    btn.Font = new Font("Bauhaus 93", 40);
                    btn.Click += new EventHandler(this.Btn_Click);
                    panel.Controls.Add(btn);
                }
            }

            this.FormClosing += new FormClosingEventHandler(this.frmTablero_FormClosing);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (turno == 0 && btn.Text == "" && btn.Name != "p1btn4")
            {
                btn.Text = "O";
                turno = 1;
            }
            else if (turno == 1 && btn.Text == "" && btn.Name != "p1btn4")
            {
                btn.Text = "X";
                turno = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            Form menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void frmTablero_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}