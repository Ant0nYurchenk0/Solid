using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    /** було порушено принцип The Single Responsibility Principle**/
    class Item
    {

    }
    class Order
    {
        protected List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

    }
    class OrderManager : Order
    {


        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}

    }
    class OrderRepositor : Order
    {

        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    class OrderChanger : Order
    {

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
