using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassProject02.Maps;

namespace ClassProject02.Object
{
    public class DoorObj : GameObject
    {
        Map startPoint, endPoint;
        bool isRocked;
        ItemObj key;

        public override void Interact() {
            // 조사 텍스트를 출력한다.

            // 만약 잠겨있으며 사용자의 Inventory에 key가 있을 경우
            //  상호작용 여부 확인 후
            //  item을 인벤토리에서 삭제한다.
            //  문을 연다.
            // 만약 잠겨 있지 않을 경우
            //  문을 연다.
        }
        public void Open(ItemObj item) {
            // startPoint에서 endPoint로 맵을 변경한다.
            // 사용자의 위치를 변경한다.
        }
        public void SwapEntryPoint(Map currentRoom)
        {
            // endPoint가 currentRoom일 경우 start와 end를 변경한다.
        }
    }
}
