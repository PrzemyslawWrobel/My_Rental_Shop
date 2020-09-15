using MyRentalShop.App.Abstract;
using MyRentalShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public BaseService()
        {
            Items = new List<T>();
        }

        public int AddItem(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(T item)
        {
            throw new NotImplementedException();
        }

        public int UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
