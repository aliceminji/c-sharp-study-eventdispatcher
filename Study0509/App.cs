using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{

    class App
    {
        //public event EventHandler ThresholdReached;
        private GameLauncher gameLauncher;

        public void Start()
        {
            //var dieEventArgs = new DieEventArgs();

            ////1
            //this.OnThresholdReached(dieEventArgs);
            ////2
            //this.OnThresholdReached(EventArgs.Empty);
            this.gameLauncher = new GameLauncher();
            gameLauncher.Init();
            gameLauncher.Start();

        }

        //protected virtual void OnThresholdReached(EventArgs e)
        //{
        //    EventHandler handler = ThresholdReached;

        //    //Invoke 이벤트 발생시킴 
        //    handler?.Invoke(this, e); // ?. 연산자 null검사
        //    handler.Invoke(this, e); //이렇게 써도 됨
        //}
    }
}
