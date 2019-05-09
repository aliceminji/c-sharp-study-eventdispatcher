using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class InGameUI
    {
        private UIGauge monsterHpGauge;
        private UIGauge heroHpGauge;
        public UIButton btnHeroSkill { get; private set; }

        public InGameUI()
        {
            this.monsterHpGauge = new UIGauge();
            this.heroHpGauge = new UIGauge();
            this.btnHeroSkill = new UIButton();
        }
    }
}
