using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou {
    class Component {

        private GameObject m_owner;
        public Component(GameObject owner) {
            Console.WriteLine("Component :Construction");
            m_owner = owner;
            m_owner.AddComponent(this);
        }

        virtual public void Start() {
            Console.WriteLine("Component :Start");

        }
        virtual public void Update() {
            Console.WriteLine("Component :Update！！");

        }

    }
}
