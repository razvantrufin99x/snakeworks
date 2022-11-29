namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        
        public Game ga = new Game();
        public snake sn = new snake();

        private void Form1_Load(object sender, EventArgs e)
        {
          g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.Focus();

            ga.f = this;

            sn.TheSnake.Add(new Cell(10, 10, Color.Red, 20, 20));
            sn.XPos.Add(sn.TheSnake[0].x);
            sn.YPos.Add(sn.TheSnake[0].y);

            for (int i = 0; i < sn.TheSnake.Count; i++)
            {
                g.DrawRectangle(new Pen(Color.Black), sn.TheSnake[i].x, sn.TheSnake[i].y, sn.TheSnake[i].width, sn.TheSnake[i].height);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Text = e.KeyChar.ToString();
            if (Text == "s" || Text == "S") { sn.TheSnake[0].y += 21; }
            else if (Text == "a" || Text == "A") { sn.TheSnake[0].x -= 21; }
            else if (Text == "d" || Text == "D") { sn.TheSnake[0].x += 21; }
            else if (Text == "w" || Text == "W") { sn.TheSnake[0].y -= 21; }
            else if (Text == "l" || Text == "L") { sn.CreateNewCell(); }
            else { }

            sn.XPos.Add(sn.TheSnake[0].x);
            sn.YPos.Add(sn.TheSnake[0].y);


           
            sn.MoveAllSnakeCells();


            g.Clear(Color.White);
            g.DrawRectangle(new Pen(Color.Black), sn.TheSnake[0].x, sn.TheSnake[0].y, sn.TheSnake[0].width, sn.TheSnake[0].height);
            for (int i = 0; i < sn.TheSnake.Count; i++)
            {
                //g.DrawRectangle(new Pen(Color.Black), sn.TheSnake[i].x, sn.TheSnake[i].y, sn.TheSnake[i].width, sn.TheSnake[i].height);
                //g.DrawRectangle(new Pen(Color.Black), sn.XPos[i], sn.YPos[i], 10,10);

            }
           for (int i = sn.XPos.Count - sn.TheSnake.Count; i< sn.XPos.Count; i++)
            {
                try
                {
                    g.DrawRectangle(new Pen(Color.Black), sn.XPos[i] + 5, sn.YPos[i] + 5, 7, 7);
                }
                catch{ }
            }

        }
    }
}