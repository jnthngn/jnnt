using System;
using Robocode;
using Robocode.Util;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace jnnt
{
   
    public class jnnt : Robot

    {
        
        public bool zoiao;
        public double QuantidadeMovimentoRight;

        public override void Run()
        {

            SetColors(Color.Black, Color.Black, Color.Black);
            BaseMovimentoRight();

            while (true)
            {
                
                MovimentatankRight();     
                
                

            }

            void BaseMovimentoRight()
            {
                QuantidadeMovimentoRight = Math.Max(BattleFieldWidth, BattleFieldHeight);
                zoiao = false;
                TurnLeft(Heading % 90);
                Ahead(QuantidadeMovimentoRight);

                zoiao = true;
                TurnGunRight(90);
                TurnRight(90);
            }

            void MovimentatankRight()
            {
                zoiao = true;
                Ahead(QuantidadeMovimentoRight);
                zoiao = false;
                TurnRight(90);
                return;
            }
        }

        
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(2);
        }
        public override void OnHitByBullet(HitByBulletEvent e)
        {
            TurnRight(90 - e.Bearing);
           

        }


        





    }



    
}
