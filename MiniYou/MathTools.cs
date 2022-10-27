using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou {
    struct Vector2 {
        public float x;
        public float y;

        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }

    }
    class MathTools {
        static public Vector2 AddVector(Vector2 v1, Vector2 v2) {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static void DelVoid(int val) { 
        
        }
    public void Test() { 
        
    }

    }

}
