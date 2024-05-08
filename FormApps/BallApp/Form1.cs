namespace BallApp {
    public partial class Form1 : Form {
        Obj obj;
        PictureBox pb;
        

        private double posX;//x���W
        private double posY;//y���W
        private double moveX;//�ړ���(x����)
        private double moveY;//�ړ���(y����)


        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
        }
        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
           
        }

        private void timer1_Tick(object sender, EventArgs e) {
            
            obj.Move();
            pb.Location = new Point((int)obj.PosX, (int)obj.PosY);
            
        }

            private void Form1_MouseClick(object sender, MouseEventArgs e) {
                pb = new PictureBox();//�摜��\������
                
            if (e.Button == MouseButtons.Left) {
                pb.Size = new Size(50, 50);
                obj = new SoccerBall(e.X-25, e.Y-25);
                pb.Image = obj.Image;
                pb.Location = new Point((int)obj.PosX, (int)obj.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
                timer1.Start();
            }else if(e.Button == MouseButtons.Right) {
                pb.Size = new Size(25, 25);
                obj = new TennisBall(e.X-12.5, e.Y-12.5);
                pb.Image = obj.Image;
                pb.Location = new Point((int)obj.PosX, (int)obj.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
                timer1.Start();
            }
        }
    }
}
