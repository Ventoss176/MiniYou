using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou {
    class GameObject {
         private List<Component> m_comps= new List<Component>();

        public GameObject() {
            Console.WriteLine("GameObject : Construction");
        }
        public void AddComponent(Component comp) {
            m_comps.Add(comp);
           
        }

        public void RemoveComponent(Component comp) {
            m_comps.Remove(comp);
        }

        public Component GetComponent(String compName) {
            foreach (var comp in m_comps) {
                if (comp.ToString() == compName) {
                    return comp;
                }
            }

            return null;
        }

        public void Start() {
            foreach (var comp in m_comps) {
                comp.Start();
            }

            SonOfComponent sc = null;

            sc = (SonOfComponent)GetComponent("MiniYou.SonOfComponent");

            if (sc != null) {
                sc.OnBeginTrigger += OnEnterTrigger2D;
            }

            
            //for (int i = 0; i < m_comps.Count; i++) {
            //    m_comps[i].Start();
                    //break;//只能跳出一层循环
            //}
        }

        public void Update() {
            foreach (var comp in m_comps) {
                comp.Update();
            }

        }

        void OnEnterTrigger2D(int val) {
            Console.WriteLine("OnEnterTrigger2D {0}", val);
        }

    }
}
