using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstApp
{
    class usedItemStruct
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public int unitCost { get; set; }
        public int usedQuantity { get; set; }
        public int totalCost { get; set; }

        public usedItemStruct(int id,string name, int uCost,int quantity,int tCost)
        {
            itemID = id;
            itemName = name;
            unitCost = uCost;
            usedQuantity = quantity;
            totalCost = tCost;
        }

        public usedItemStruct()
        {

        }

    }
}
