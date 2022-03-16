using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    namespace T1
    {
        internal class AutomatedTransport
        {
            protected string Manufacture;
            protected string Model;
            protected int Price;

            public AutomatedTransport()
            {
                Manufacture = "None";
                Model = "None";
                Price = 0;
            }

            public AutomatedTransport(string man, string mod, int pr)
            {
                Manufacture = man;
                Model = mod;
                Price = pr;
            }

            public virtual void AddInfo()
            {
                Console.WriteLine("| Enter manufacture: ");
                Manufacture = Console.ReadLine();
                Console.WriteLine("| Enter model: ");
                Model = Console.ReadLine();
                Console.WriteLine("| Enter price:");
                Price = Int32.Parse(Console.ReadLine());
            }

            public virtual void OutInfo()
            {
                Console.WriteLine("| " + Manufacture + " | " + Model + " | " + Price + " |" );
            }

            public virtual string return_(int s)
            {
                switch (s)
                {
                    case 2: return Model;
                    case 3: return Price.ToString();
                    default: return Manufacture;
                }
            }
        }

        internal class Train : AutomatedTransport
        {
            protected int Number;
            public Train()
            {
                Manufacture = "None";
                Model = "None";
                Price = 0;
                Number = 1;
            }
            public Train(string man, string mod, int pr, int num)
            {
                Manufacture = man;
                Model = mod;
                Price = pr;
                Number = num;
            }

            public override void AddInfo()
            {
                base.AddInfo();
                Console.WriteLine("| Enter number:");
                Number = Int32.Parse(Console.ReadLine());
            }

            public override void OutInfo()
            {
                Console.WriteLine("| " + Manufacture + "-" + Model + " | " + Price + " | N:" + Number + " |");
            }

            
        }

        internal class Auto : AutomatedTransport
        {
            public String NumOnPlate;
            public Auto()
            {
                Manufacture = "None";
                Model = "None";
                Price = 0;
                NumOnPlate = "AT0001AT";
            }

            public Auto(string man, string mod, int pr, string numbpl)
            {
                Manufacture = man;
                Model = mod;
                Price = pr;
                NumOnPlate = numbpl;
            }

            public override void AddInfo()
            {
                base.AddInfo();
                Console.WriteLine("| Enter number:");
                NumOnPlate = Console.ReadLine();
            }

            public override void OutInfo()
            {
                Console.WriteLine("| " + Manufacture + " | " + Model + " | " + Price + " | " + NumOnPlate + " |");
            }
        }

        internal class Express : Train
        {
            public Express()
            {
                Manufacture = "None";
                Model = "None";
                Price = 0;
                Number = 1;
            }

            public Express(string man, string mod, int pr, int num)
            {
                Manufacture = man;
                Model = mod;
                Price = pr;
                Number = num;
            }

            public override void AddInfo()
            {
                base.AddInfo();
                Console.WriteLine("| Enter number:");
                Number = Int32.Parse(Console.ReadLine());
            }

        }
    }


}
