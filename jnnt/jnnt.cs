using System;
using Robocode;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jnnt
{
    public class jnnt : Robot
    {
        public override void Run()
        {

                
            while (true)
            {
                Ahead(200);
                TurnLeft(90);
                Ahead(200);
                TurnRight(90);
                TurnRadarLeft(25);
                TurnRadarRight(25);
                         
                FireBullet(1);

               
                
              
            }

            


        }
    }
}
