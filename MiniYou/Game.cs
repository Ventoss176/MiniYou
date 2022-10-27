using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniYou{
    class Game{
        private int health;
        private bool m_isRunning = true;

        private List<GameObject> gameObjects = new List<GameObject>();


        public bool M_isRunning {
            get {
                return m_isRunning; 
            }
            set { 
                m_isRunning = value; 
            }
       

        }



        public Game() {
            Console.WriteLine("GameConstructor");
        }

        public void RunLoop(){
            while (M_isRunning) {
                ProcessInput();
                UpdateGame();
            }

        }
        public bool Initialize() {
            StartGame();
            return true;
        }

        public void ShutDown() {
            Console.WriteLine("Game ShutDown");
        }

        private void ProcessInput() {
            while (Console.KeyAvailable) {
                ConsoleKey ck = Console.ReadKey(true).Key;
                if(ck == ConsoleKey.Q){
                    M_isRunning = false;
                }
            }
        }

        private void UpdateGame() {
            //Console.WriteLine("GameUpdate");
            foreach (var go in gameObjects) {
                go.Update();
            }
        }
        private void StartGame() {
            Console.WriteLine("GameStart");
            LoadData();
            foreach (var go in gameObjects) {
                go.Start();
            }
            //SonOfComponent sc = new SonOfComponent();
            //DaughterOfComponent dc = new DaughterOfComponent();
            //Component cc = (Component)sc;
            //Component cc2 = new SonOfComponent();

            //sc.Start();
            //sc.Update();
            //cc.Start();

            //cc2.Start();
            //dc.Start();
            //dc.Update();
        }

        private void LoadData() {
            GameObject go1 = new GameObject();
            GameObject go2 = new GameObject();

            AddGameObject(go1);
            AddGameObject(go2);

            SonOfComponent sc1 = new SonOfComponent(go1);
            SonOfComponent sc2 = new SonOfComponent(go2);
            DaughterOfComponent dc1 = new DaughterOfComponent(go1);
            DaughterOfComponent dc2 = new DaughterOfComponent(go2);
        }

        public void AddGameObject(GameObject gameObject) {
            gameObjects.Add(gameObject);
        } 
        
        public void RemoveGameObject(GameObject gameObject) {
            gameObjects.Remove(gameObject);
        }



    }
}
