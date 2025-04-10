using ClassProject02.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject02.Maps
{
    public class Room01 : Map
    {
        public Room01() {
            this.map = [
                "                                        ",
                "   ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■   ",
                "   ■                                ■   ",
                "   ■                                ■   ",
                "   ■                                ■   ",
                "   ■                                ■   ",
                "   ■                                ■   ",
                "   ■                                ■   ",
                "   ■                                ■   ",
                "   ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■   ",
                "                                        ",
            ];
            ItemBuilder itemMaker = new ItemBuilder();
            ItemObj key = itemMaker
                .SetName("열쇠")
                .SetPosition(new Vector2(7, 4))
                .SetInvstText("한글은 한 글자당 두 칸의 간격을 가지나 띄어쓰기가 포함되니 알 수 없어졌다. 그냥 모든 텍스트 출력을 확인하며 간격을 조정하자.")
                .SetAppearance('K')
                .Build();
            this.objList.Add(key);

            this.OnPickedUp = RemoveMapObject;
            this.OnDropDown = AddMapObject;
        }    
    }
}
