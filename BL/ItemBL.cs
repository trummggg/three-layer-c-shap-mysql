﻿using System.Collections.Generic;
using Persistence;
using DAL;

namespace BL
{
    public class ItemBL
    {
        private ItemDAL idal = new ItemDAL();
        public Item GetItemById(int itemId)
        {
            return idal.GetItemById(itemId);
        }
        public List<Item> GetAll()
        {
            return idal.GetItems(ItemFilter.GET_ALL, null);
        }
        public List<Item> GetByName(string itemName)
        {
            return idal.GetItems(ItemFilter.FILTER_BY_ITEM_NAME, new Item{ItemName=itemName});
        }
        
    }
}
