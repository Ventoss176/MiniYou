using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou {
    class SonOfComponent : Component{

        public DelTrigger OnBeginTrigger;
        private int count = 0;
        public SonOfComponent(GameObject owner) :base(owner){
            Console.WriteLine("SonOfComponent: Construction");
            OnBeginTrigger = new DelTrigger(MathTools.DelVoid);
        }

        override public void Start() {
            //base.Start();
            Console.WriteLine("SonOfComponent: Start");
        }

        override public void Update() {
            //base.Start();
            //Console.WriteLine("SonOfComponent: Update");
            count++;
            if (count % 20000 == 0) {
                OnBeginTrigger(10);
            }

        }
    }
}
