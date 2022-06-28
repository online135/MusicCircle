namespace MusicCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grapgics = this.panel1.CreateGraphics();

            Pen pen = new Pen(Color.Red);
            grapgics.DrawEllipse(pen, 70, 60, 170, 170);
            
        }
    }
}