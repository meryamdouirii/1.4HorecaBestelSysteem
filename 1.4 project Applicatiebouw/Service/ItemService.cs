using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class ItemService
    {
        ItemDao itemDao;

        public ItemService()
        {
            itemDao = new ItemDao();
        }

        public List<Item> GetItemsByMenu(Menu menu)
        {
            return itemDao.GetItemsByMenu(menu);
        }
        public List<Item> GetAllItems()
        {
            return itemDao.GetAllItems();
        }
        public void AddItem(Item item) 
        {
            itemDao.AddItem(item);
        }
        public void DeleteItem(Item item) 
        {
            itemDao.DeleteItem(item);
        }
        public void UpdateItem(Item item) 
        {
            itemDao.UpdateItem(item);
        }
        public List<Item> TotalSoldItem() 
        {
            return itemDao.TotalSoldItem();
        }
    }
}
