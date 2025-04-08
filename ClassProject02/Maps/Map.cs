using ClassProject02.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject02.Maps
{
    public abstract class Map
    {
        
        // 문자 프리셋: ■ □ ▣ ▤ ▥ ▨ ▧ ▦ ▩
        public string[] map = new string[11];
        public Vector2 printStartPoint = new Vector2(2, 1);
        // mapObject List가 필요

        // 맵 출력 함수
        public void PrintMap() {
            for (int lineCnt = 0; lineCnt < map.Length; lineCnt++)
            {
                Console.SetCursorPosition((int)printStartPoint.X, (int)printStartPoint.Y + lineCnt);
                Console.WriteLine(map[lineCnt]);
            }
        }
        public char GetSingleTile(Vector2 pos) {
            return this.map[(int)(pos.Y - printStartPoint.Y)][(int)(pos.X - printStartPoint.X)];
        }
        public bool CheckMovable(Vector2 targetPos) {
            bool isMovable;
            char targetTile = this.GetSingleTile(targetPos); 
            switch (targetTile) {
                case '■':
                case '□':
                case '▣':
                case '▤':
                case '▥':
                case '▨':
                case '▧':
                case '▦':
                case '▩':
                    isMovable = false;
                    break;
                case ' ':
                    isMovable = true;
                    break;
                default:
                    isMovable = true;
                    break;
            }
            return isMovable;
        }
    }                                              
}
