using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ClassProject02.User;
using ClassProject02.Object;

namespace ClassProject02.Maps
{
    public abstract class Map
    {        
        // 문자 프리셋: ■ □ ▣ ▤ ▥ ▨ ▧ ▦ ▩
        public string[] map = new string[11];
        public Vector2 printStartPoint = new Vector2(2, 1);
        public List<GameObject> objList = new List<GameObject>();

        public delegate void MapEventHandler<T>(GameObject obj);
        public MapEventHandler<Map> OnPickedUp, OnDropDown;

        // 맵 출력 함수
        public void PrintMap() {
            for (int lineCnt = 0; lineCnt < map.Length; lineCnt++)
            {
                Console.SetCursorPosition((int)printStartPoint.X, (int)printStartPoint.Y + lineCnt);
                Console.WriteLine(map[lineCnt]);
            }
        }
        public void PrintItem()
        {
            foreach (ItemObj item in this.objList)
            {
                Console.SetCursorPosition((int)(item.position.X + this.printStartPoint.X - 1), (int)(item.position.Y + this.printStartPoint.Y));
                Console.Write(item.appearance);
            }
        }
        public char GetSingleTile(Vector2 pos) {
            char returnTile;
            if (GetMapObject(pos) is not null)
            {
                returnTile = GetMapObject(pos).appearance;
            }
            else 
            {
                returnTile = this.map[(int)(pos.Y - printStartPoint.Y)][(int)(pos.X - printStartPoint.X)];
            }
            return returnTile;
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
        public GameObject GetMapObject(Vector2 targetPos) {
            GameObject? returnObj = null;
            foreach (GameObject obj in this.objList) {
                if (new Vector2((obj.position.X + this.printStartPoint.X - 1), (obj.position.Y + this.printStartPoint.Y)) == targetPos) {
                    returnObj = obj;
                }
            }
            return returnObj;
        }
        public void RemoveMapObject(GameObject obj) {
            if (this.objList.Contains(obj))
            {
                this.objList.Remove(obj);
                Console.SetCursorPosition((int)obj.position.X, (int)obj.position.Y);
                Console.Write(GetSingleTile(obj.position));
            }
        }
        public void AddMapObject(GameObject obj) {
            this.objList.Add(obj);
        }
    }                                              
}
