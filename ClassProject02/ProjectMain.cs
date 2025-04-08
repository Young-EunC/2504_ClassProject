using ClassProject02.User;
using ClassProject02.Maps;
using ClassProject02.Object;

namespace ClassProject02
{
    public enum Direction
    {
        Up, Down, Left, Right
    }
    public enum PlayerState
    {
        Normal, Interact
    }
    internal class ProjectMain
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Room01 test = new Room01();
            bool isInputValid = true;

            ScreenClear();
            test.PrintMap();
            player.Print(player.position, test);

            do {
                ClearInputBuffer();
                ConsoleKey userInput = Console.ReadKey(true).Key;
                switch (userInput) {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        player.Move(Direction.Up, test);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        player.Move(Direction.Down, test);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        player.Move(Direction.Left, test);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        player.Move(Direction.Right, test);
                        break;
                    case ConsoleKey.E:
                        GameObject obj = test.GetMapObject(player.GetInteractCoord());
                        player.Interact(obj);
                        break;
                    default:
                        // 반복문 탈출
                        isInputValid = false;
                        break;
                }
            } while (isInputValid);

            // 프로그램 종료 텍스트 때문에 화면이 다 안보임
            Console.SetCursorPosition(0, 16);
        }

        static void ScreenClear() {
            //Console.WriteLine("============================================");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||                                        ||");
            //Console.WriteLine("||----------------------------------------||");
            //Console.WriteLine("|| 한글은 한 글자당 두 칸의 간격을 가지나 띄 ||");
            //Console.WriteLine("|| 어쓰기가 포함되니 알 수 없어졌다. 그냥 모 ||");
            //Console.WriteLine("|| 든 텍스트 출력을 확인하며 간격을 조정하자 ||");
            //Console.WriteLine("||========================================||");
            //Console.WriteLine("|| E 조사 ||       |       |       |      ||");
            //Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||========================================||");
            Console.WriteLine("|| E 조사 ||       |       |       |      ||");
            Console.WriteLine("============================================");
        }
        static void ClearInputBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }
    }
}
