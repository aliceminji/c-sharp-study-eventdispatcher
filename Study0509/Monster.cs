using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class Monster
    {
        public string Name { get; set; }
        public MonsterInfo Info { get; private set; }
        public void Init(string name)
        {
            this.Name = name;
            this.Info = new MonsterInfo() {
                id=1,hp=100
            };

        }

        public void TakeDamage(int damage)
        {
            //이벤트발송
            var eventArgs = new GameEvent.MonsterEventArgs() {
                info = this.Info
            };
            EventDispatcher.GetInstance().DispatchEvent("MONSTER_DIE", EventArgs.Empty);
        }
    }
}
