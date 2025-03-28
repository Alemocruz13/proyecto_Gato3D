namespace proyecto_Gato3D
{
    public partial class Form1 : Form
    {
        int turno = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1050, 1050);
            this.BackColor = Color.Black;
            this.Text = "Gato 3D";

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
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (turno == 0 && btn.Text=="" && btn.Name !="p1btn4")
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
    }
}
