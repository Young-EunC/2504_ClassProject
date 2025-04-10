using ClassProject02.User;
using ClassProject02.Maps;
using ClassProject02.Object;

namespace ClassProject02
{
    //public delegate void MapEventHandler<T>(GameObject obj);
    internal class ProjectMain
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Room01 test = new Room01();
            bool isInputValid = true;

            Console.CursorVisible = false;
            ScreenClear();
            test.PrintMap();
            test.PrintItem();
            player.Print(player.position, test);
            //PrintScript();
            //PrintActionKey();

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
                        if (obj is not null)
                        {
                            player.Interact(obj, test);
                        }
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
            Console.SetCursorPosition(0, 0);
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
            Console.WriteLine("||        ||       |       |       |      ||");
            Console.WriteLine("============================================");
        }        
        static void PrintActionKey() {
            // 사용자가 상호작용이 가능한 상태일 경우 좌측 하단에 도움말처럼 출력함
            char actionKey = 'E';
            string actionKeyDesc = "조사";
            Console.SetCursorPosition(3, 13);
            Console.Write($"{actionKey} {actionKeyDesc}");
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
