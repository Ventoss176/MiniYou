using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace xxx.aaa.bbb
{
    class a1 { };
    class a2 { };
}

//等于这样

namespace xxx
{
    namespace aaa
    {
        namespace ccc
        {

        }
    }
}
namespace MiniYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Game game = new Game();
            game.M_isRunning = true;

            bool Gin = game.Initialize();
            game.M_isRunning = true;
            if (Gin) {
                game.RunLoop();
            }

            game.ShutDown();

            //TestClass.Test();


            //int health = 120;
            //Count(ref health);
            //Console.WriteLine(health);
            //bool test = game.M_isRunning;
            Console.ReadLine();
            /**
             * 1.创建模拟GameObject
             * 
             * 
             * 
             * 
             * */
        }

        static int Count(ref int health) {
            health = 100;
            Console.WriteLine(health);
            return 0;
        }
    }
}
