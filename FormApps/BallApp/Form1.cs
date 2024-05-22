using System.Diagnostics;

namespace BallApp {
    public partial class Form1 : Form {

        private int soccerCount = 0;

        //Listコレクション
        private List<Obj> balls = new List<Obj>();//ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();//表示用
        //bar用
        private Bar bar;
        private PictureBox pbBar;



        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "BallApp SoccerBall:0 TennisBall:0";
            score.Text = "スコア："+this.soccerCount;

            bar = new Bar(340, 500);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Size = new Size(150, 0);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBar.Parent = this;
        }

        private void timer1_Tick(object sender, EventArgs e) {

            // ball.Move();
            // pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            for (int i = 0; i < balls.Count; i++) {
                int ret = balls[i].Move(pbBar, pbs[i]);
                if (ret==1) {
                    score.Text = "スコア：" + this.soccerCount--;
                    pbs[i].Location = new Point(900,900);
                    //落下したボールインスタンスを削除
                    balls.RemoveAt(i);
                    pbs.RemoveAt(i);
                    

                } else if(ret == 2){
                    //バーに当たった
                    score.Text ="スコア："+ this.soccerCount++;
                    pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                } else {
                    //移動OK
                    pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                }
            }
        }
        //マウスクリックイベントハンドラ
        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            PictureBox pb = new PictureBox();//画像を表示する
            Obj? ball = null;
            if (e.Button == MouseButtons.Left) {
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X - 25, e.Y - 25);
            } else if (e.Button == MouseButtons.Right) {
                pb.Size = new Size(25, 25);
                ball = new TennisBall(e.X - 12.5, e.Y - 12.5);
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();

            balls.Add(ball);
            pbs.Add(pb);

            this.Text = "BallApp SoccerBall:" + SoccerBall.Count + " TennisBall:" + TennisBall.Count;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyCode);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
