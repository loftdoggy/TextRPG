﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Consumables
{
    class SpiritPotion : ConsumableItem
    {
        public SpiritPotion(ItemGrade grade, string name, string description, int quantity, int price)
             : base(grade, name, description, quantity, price)
        {

        }
    }
}
