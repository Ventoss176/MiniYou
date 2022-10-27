using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou {
    class DaughterOfComponent : Component {

        private IEnumerator e = null;

        public DaughterOfComponent(GameObject owner) : base(owner){
            Console.WriteLine("DaughterOfComponent: Construction");
        }

        override public void Start() {
            //base.Start();
            Console.WriteLine("DaughterOfComponent: Start");
            Vector2 v1 = new Vector2(2.0f, 4.0f);
            Vector2 v2 = new Vector2(3.0f, 5.0f);
            Vector2 res = MathTools.AddVector(v1, v2);
            Console.WriteLine("XXXXXXX{0}{1}", res.x, res.y);
            StartCoroutine();
        }

        override public void Update() {
            //base.Start();
            //Console.WriteLine("DaughterOfComponent: Update");
            RunCoroutine();
        }

        void StartCoroutine() {
            e = TestCoroutine();
        }

        void RunCoroutine() {
            if (e!= null) {
                if (!e.MoveNext()) {
                    e = null;
                }
            
            }
        }

        IEnumerator TestCoroutine() {

            for (int index = 0; index < 10000; index++) {

                Console.WriteLine("TestCoroutine--------------------- {0} ", index);
                yield return index;
            }
        }
    }
}
