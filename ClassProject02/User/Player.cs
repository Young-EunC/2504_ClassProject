using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ClassProject02;

namespace ClassProject02.User
{    
    public class Player
    {
        // move, rotate, interact
        // 문자 프리셋: ▲ ▼ ◀ ▶
        public char playerShape;
        public Direction direction;
        public Vector2 position;
        public Inventory inventory;
        public PlayerState state { get; set; }

        public Player() 
        {
            this.playerShape = '▲';
            this.direction = Direction.Up;
            this.position = new Vector2(21, 8);
            this.inventory = new Inventory();
            this.state = PlayerState.Normal;
        }

        public void Move(Direction moveDirection, Maps.Map map) 
        {
            Vector2 nextPos = this.position;
            Rotate(moveDirection);
            switch (moveDirection)
            {
                case Direction.Up:
                    nextPos.Y--;
                    break;
                case Direction.Down:
                    nextPos.Y++;
                    break;
                case Direction.Left:
                    nextPos.X--;
                    break;
                case Direction.Right:
                    nextPos.X++;
                    break;
            }

            bool canMove = map.CheckMovable(nextPos);
            if (canMove)
            {
                Print(nextPos, map);
                this.position = nextPos;
            }
            else 
            {
                Print();
            }
        }
        public void Rotate(Direction moveDirection) 
        {
            switch (moveDirection)
            {
                case Direction.Up:
                    this.playerShape = '▲';
                    break;
                case Direction.Down:
                    this.playerShape = '▼';
                    break;
                case Direction.Left:
                    this.playerShape = '◀';
                    break;
                case Direction.Right:
                    this.playerShape = '▶';
                    break;
            }
        }
        public void Print(Vector2 nextPos, Maps.Map map)
        {
            // 기존 위치의 플레이어를 삭제(원본 맵의 타일로 교체)
            Console.SetCursorPosition((int)this.position.X, (int)this.position.Y);
            Console.Write(map.GetSingleTile(this.position));

            // 다음 위치에 플레이어를 출력
            Console.SetCursorPosition((int)nextPos.X, (int)nextPos.Y);
            Console.Write(this.playerShape);
        }
        public void Print()
        {
            // 현재 위치에 플레이어를 출력
            Console.SetCursorPosition((int)this.position.X, (int)this.position.Y);
            Console.Write(this.playerShape);
        }

        //// 상호작용 좌표 구하기
        //public Vector2 GetInteractCoord()
        //{
        //    float x, y;
        //    switch (this.direction)
        //    {
        //        case Direction.Left:
        //            x = this.position.X - 1;
        //            y = this.position.Y;
        //            break;
        //        case Direction.Right:
        //            x = this.position.X + 1;
        //            y = this.position.Y;
        //            break;
        //        case Direction.Down:
        //            x = this.position.X;
        //            y = this.position.Y + 1;
        //            break;
        //        case Direction.Up:
        //        default:
        //            x = this.position.X;
        //            y = this.position.Y - 1;
        //            break;
        //    }
        //    Vector2 interactionCoord = new Vector2(x, y);
        //    return interactionCoord;
        //}
        //// 상호작용
        //public void Interact(GameObject.GameObject obj)
        //{

        //}
    }
}
