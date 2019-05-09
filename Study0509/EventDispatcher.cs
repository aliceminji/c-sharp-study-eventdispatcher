using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class EventDispatcher
    {
        private Dictionary<string, EventHandler<EventArgs>> dicEventHandler = new Dictionary<string, EventHandler<EventArgs>>();
        private static EventDispatcher Instance;

        private EventDispatcher()
        {
            if(EventDispatcher.Instance!=null)
            {
                throw new Exception("EventDispatcher는 싱글톤 패턴입니다.");
            }
            //eventHandler             
        }

        public static EventDispatcher GetInstance()
        {
            if(EventDispatcher.Instance==null)
            {
                EventDispatcher.Instance = new EventDispatcher();
            }
            return EventDispatcher.Instance;
        }

        //이벤트 핸들러 등록
        public void AddEventHandler(string eventName, EventHandler<EventArgs>executeHandler)
        {
            if(!this.dicEventHandler.ContainsKey(eventName))
            {
                this.dicEventHandler.Add(eventName, executeHandler);
                
                Console.WriteLine("이벤트 {0}가 {1}등록되었습니다.", eventName, executeHandler);
                Console.WriteLine("{0}", this.dicEventHandler.Count);
            }
        }

        //이벤트 발생
        public void DispatchEvent(string eventName,EventArgs e)
        {
            var handler = this.dicEventHandler[eventName];
            Console.WriteLine("HANDLER:{0}", handler);
            handler?.Invoke(EventDispatcher.GetInstance(),e);
        }
    }
}
