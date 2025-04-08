using ClassProject02.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject02.Object
{
    public class ItemObj : GameObject
    {
        public string description;
        public override void Interact() {
            // 조사 텍스트를 출력한다.
            // player의 인벤토리에 자리가 남았을 경우
            //  아이템을 인벤토리에 넣는다.
        }

        public void PickedUp(Player player) {
            // 아이템 오브젝트를 맵에서 삭제하고 => event
            // player의 인벤토리에 추가한다.
        }
    }
}
