using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class ConcreteBuilder: Builder
    {
        private CP Checkpoint;
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Checkpoint = new CP();
        }

        public void GiveNumber()
        {
            this.Checkpoint.num = 1;
        }

        public void GiveName(string name)
        {
            this.Checkpoint.name = name;
        }

        public void GiveCoord()
        {
            Checkpoint.width = 1;
            Checkpoint.longth = 1;
        }

        public void GiveTime()
        {
            if (!Checkpoint.IsRequired)
            {
                Checkpoint.time = "N/A";
            }
            else Checkpoint.time = "00:00";
            
        }

        public CP GetCP()
        {
            CP res = this.Checkpoint;
            this.Reset();
            return res;
        }
    }
}
