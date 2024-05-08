namespace BallApp {
    public partial class Form1 : Form {
        Obj ball;
        PictureBox pb;
        

        private double posX;//x座標
        private double posY;//y座標
        private double moveX;//移動量(x方向)
        private double moveY;//移動量(y方向)


        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
           
        }

        private void timer1_Tick(object sender, EventArgs e) {
            
            ball.Move();
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            
        }

            private void Form1_MouseClick(object sender, MouseEventArgs e) {
                pb = new PictureBox();//画像を表示する
                
            if (e.Button == MouseButtons.Left) {
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X-25, e.Y-25);
               
            }else if(e.Button == MouseButtons.Right) {
                pb.Size = new Size(25, 25);
                ball = new TennisBall(e.X-12.5, e.Y-12.5);
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();
        }
    }
}
