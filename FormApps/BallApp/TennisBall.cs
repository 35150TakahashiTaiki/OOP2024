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

        public override bool Move() {
            if (PosX >= 750 || PosX < 0) {
                MoveX = -MoveX;
            }
            if (PosY >= 500 || PosY < 0) {
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;

            return true;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
