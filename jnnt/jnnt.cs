using System;
using Robocode;
using Robocode.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jnnt
{
    public class jnnt : Robot
    {
        bool zoiao;
        
double QuantidadeMovimento;

        public override void Run()
        {

            BaseMovimentoRight();

            while (true)
            {
                
                
                MovimentatankRight();
                

            }

            void BaseMovimentoRight()
            {
                QuantidadeMovimento = Math.Max(BattleFieldWidth, BattleFieldHeight);
                zoiao = false;
                TurnLeft(Heading % 90);
                Ahead(QuantidadeMovimento);

                zoiao = true;
                TurnGunRight(90);
                TurnRight(90);
            }

            void MovimentatankRight()
            {
                zoiao = true;
              
                Ahead(QuantidadeMovimento);
                
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
            TurnLeft(90 - e.Bearing);
        }

       


    }



    
}
