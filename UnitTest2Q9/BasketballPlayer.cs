using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q9
{
    public abstract class BasketballPlayer
    {
        private string playerName;
        private int playerNumber;

        public string PlayerName
        {
            get { return playerName; } 
            set { playerName = value; }  
        }

        public int PlayerNumber
        { get { return playerNumber; } 
          set { playerNumber = value; } 
        }

        public abstract void play();

        public abstract void notPlay();

        public virtual void run()
        {

        }

        public void myMethod(object obj)
        {
            if (obj is Big)
            {
                Big bigMan = new Big();
                bigMan.shoot();
            }
        }



    }
}
