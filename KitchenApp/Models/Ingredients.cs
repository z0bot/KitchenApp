﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.Models
{
    //Properties to be held in IngredientsList
    public class Ingredients
    {
        public string _id { get; set; }
        public string name { get; set; }
        public int quantity {get; set;}
    }
}