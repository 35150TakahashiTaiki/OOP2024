using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BallApp {
    internal class TennisBall : Obj{
        public static int Count { get; set; }
        public TennisBall(double xp, double yp)
           : base(xp, yp, @"Picture\tennis_ball.png") {
            var rand = new Random();
            MoveX = rand.Next(-20, 20);//移動量設定
            MoveY = rand.Next(-20, 20);
            Count++;
        }
        //戻り値：０・・移動OK　１・・落下した　２・・バーに当たった
        public override int Move(PictureBox pdBar, PictureBox pdBall) {

            int ret = 0;
            Rectangle rBar = new Rectangle(pdBar.Location.X, pdBar.Location.Y, pdBar.Width, pdBar.Height);
            Rectangle rBall = new Rectangle(pdBall.Location.X, pdBall.Location.Y, pdBall.Width, pdBall.Height);
            if (PosX >= 750 || PosX < 0) {
                MoveX = -MoveX;
            }
            if (PosY < 0 ) {
                MoveY = -MoveY;
            }
            if (rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;
                PosX += MoveX;
                PosY += MoveY;
                ret = 2;
            }

            PosX += MoveX;
            PosY += MoveY;

            if (PosY > 500) {//落下判定
                ret = 1;
            }
            //バーに当たったか
            
            //移動完了
            return ret;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
