using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class UIButton
    {
        public event EventHandler OnClickEventHandler;

        //public void AddListener(EventHandler call)
        //{
        //    OnClickEventHandler = call;
        //}

        public UIButton()
        {

        }

        public void Click()
        {
            //이벤트 발생
            this.OnClickEvent(EventArgs.Empty);
        }

        private void OnClickEvent(EventArgs e)
        {
            EventHandler handler = OnClickEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
