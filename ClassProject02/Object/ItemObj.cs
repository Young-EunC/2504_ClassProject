using ClassProject02.Maps;
using ClassProject02.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject02.Object
{
    public class ItemObj : GameObject
    {
        // public string description;
        public ItemObj() { }
        public override void Interact(Player player, Map map) {
            //this.PrintScript(this.ConvertTextToScript(this.invstText));
            // player의 인벤토리에 자리가 남았을 경우
            if (player.inventory.Count < 4)
            {
                this.PickedUp(player, map);
            }
        }

        public void PickedUp(Player player, Map map) {
            // 아이템 오브젝트를 맵에서 삭제하고 => event
            map.OnPickedUp?.Invoke(this);
            // player의 인벤토리에 추가한다. => event
            player.inventory.Add(this);
        }

        public void Use(Player player)
        {
            // player의 인벤토리에서 삭제한다.
            player.inventory.Remove(this);
        }

        public void Drop(Player player, Map map)
        {
            // 아이템 오브젝트를 맵에서 추가하고 => event
            map.OnDropDown?.Invoke(this);
            // player의 인벤토리에서 삭제한다. => event
            player.inventory.Remove(this);
        }
    }
    public class ItemBuilder : ItemObj {
        public ItemBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public ItemBuilder SetInvstText(string text)
        {
            this.invstText = text;
            return this;
        }
        public ItemBuilder SetConfirmText(string text)
        {
            this.confirmText = text;
            return this;
        }
        public ItemBuilder SetPosition(Vector2 pos)
        {
            this.position = pos;
            return this;
        }
        public ItemBuilder SetAppearance(char singleChar)
        {
            this.appearance = singleChar;
            return this;
        }
        public ItemObj Build()
        {
            ItemObj item = new ItemObj();
            item.name = this.name;
            item.invstText = this.invstText;
            item.confirmText = this.confirmText;
            item.position = this.position;
            item.appearance = this.appearance;
            return item;
        }
    }
}
