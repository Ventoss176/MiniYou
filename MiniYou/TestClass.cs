using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou {

    enum MainPlayerState {
        MPS_Idle, 
        MPS_Walk, 
        MPS_Attack, 
        MPS_Dead
    }

    interface ICustom {
        void Fun();
    }

    class TestClass {
        static public void Test() {
            //ACustom a = new ACustom();
            //a.Fun();

            //MainPlayerState mps = MainPlayerState.MPS_Idle;

            //switch (mps) {
            //case MainPlayerState.MPS_Idle:
            //        break;
            //case MainPlayerState.MPS_Walk:
            //        break;
            //case MainPlayerState.MPS_Attack:
            //        break;
            //case MainPlayerState.MPS_Dead:
            //        break;
            // default:
            //        break;
            //}

            Erable ers = new Erable();
            foreach (var er in ers) {
                //Console.WriteLine(er);
            }


        }

    }

    class Erable : IEnumerable {
        public IEnumerator GetEnumerator() {
            return TestYield();
        }

        IEnumerator TestYield() {
            for (int index = 0; index < 10; index++) {
                Console.WriteLine("TestYield-------------" + index);
                yield return index;
            }

           
        }
    }

    class Erator : IEnumerator {

        private int index = -1;
        public object Current {
            get {
                return index;
            }
        }

        public bool MoveNext() {
            if (index < 10) {
                return true;
            }
            return false;
        }

        public void Reset() {
            index = -1;
        }
    }

    class ACustom : ICustom {
        public void Fun() {
            Console.WriteLine("实现ICustom接口");
        }
    }
}
