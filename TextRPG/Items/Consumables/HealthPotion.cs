﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Consumables
{
    class HealthPotion : ConsumableItem
    {
        public HealthPotion(ItemGrade grade, string name, string description, int quantity, int price)
            : base(grade, name, description, quantity, price)
        {

        }
    }
}
