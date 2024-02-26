namespace RecapDamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            int number = 1;
            int top = 0;
            int left = 0;
            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {

                left = 0;
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    Button button = new Button();

                    button.Text = number++.ToString();
                    button.Width = 50;
                    button.Height = 50;
                    button.Left = left;
                    button.Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        button.BackColor = Color.Black;
                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.White;
                        button.ForeColor = Color.Black;

                    }


                    buttons[i, j] = button;
                    this.Controls.Add(buttons[i, j]);
                    left += 50;

                }
                top += 50;
            }
        }
    }
}
