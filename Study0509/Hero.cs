using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class Hero
    {
        public string Name { get; private set; }

        public void Init(string name)
        {
            this.Name = name;
        }

        public void ActiveSkill()
        {
            Console.WriteLine("스킬을 시전하였습니다.");
        }
    }
}
