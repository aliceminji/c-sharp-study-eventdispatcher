using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class GameLauncher
    {
        public InGameUI inGameUI;
        private Hero hero;
        private Monster monster;

        public GameLauncher()
        {
            this.inGameUI = new InGameUI();

            //이벤트 등록
            EventDispatcher.GetInstance().AddEventHandler("MONSTER_DIE",(sender,e)=> {
                Console.WriteLine("sender: {0} e: {1}", sender, e);
                var eventArgs = (GameEvent.MonsterEventArgs)e;
                Console.WriteLine("eventArgs:{0}", eventArgs);
            });

            //버튼 이벤트
            this.inGameUI.btnHeroSkill.OnClickEventHandler += BtnHeroSkill_OnClickEventHandler;

            //사용자가 눌렀다고 치면
            this.inGameUI.btnHeroSkill.Click();

        }

        public void Init()
        {
            this.hero = new Hero();
            this.monster = new Monster();

            this.hero.Init("박민지");
            this.monster.Init("몬스터");
        }

        public void BtnHeroSkill_OnClickEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("sender:{0} e:{1}", sender, e);
            this.hero.ActiveSkill();
            this.monster.TakeDamage(5);
        }

    

        public void Start()
        {
            Console.WriteLine("게임시작");
            this.inGameUI.btnHeroSkill.Click();
        }
        
    }
}
