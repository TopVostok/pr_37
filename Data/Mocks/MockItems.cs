using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategories _category = new MockCategories();

        public IEnumerable<Items> AllItems
        {
            get
            {
                var categories = _category.GetAllCategories.ToList();

                return new List<Items>()
                {
                    new Items()
                    {
                        Id = 1,
                        Name = "DEXP MS-70",
                        Description = "Благодаря черному корпусу с лаконичным дизайном микроволновка станет отличным дополнением любой кухни",
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/760/600/25926359fb3f68e0ade4c41f02bc0336/q93_6ed1d891fe8b2070fe2f279d0b29c26c9bf7e40ed2dcccbcfce9d5206bfce60e.jpg",
                        Price = 3699,
                        Category = categories.FirstOrDefault(x => x.Id == 1)
                    },
                    new Items()
                    {
                        Id = 2,
                        Name = "Samsung Galaxy S23",
                        Description = "Флагманский смартфон с мощным процессором и отличной камерой",
                        Img = "https://irecommend.ru/sites/default/files/imagecache/copyright1/user-images/860283/5QobVD4AkYHoCvvbKnGxQ.jpg",
                        Price = 69999,
                        Category = categories.FirstOrDefault(x => x.Id == 2)
                    },
                    new Items()
                    {
                        Id = 3,
                        Name = "Apple iPhone 15",
                        Description = "Новейший iPhone с динамическим островом и USB-C",
                        Img = "https://i2019.otzovik.com/2019/06/06/8298727/img/1200768_82308433.jpeg",
                        Price = 79999,
                        Category = categories.FirstOrDefault(x => x.Id == 2)
                    },
                    new Items()
                    {
                        Id = 4,
                        Name = "Xiaomi Mi Band 8",
                        Description = "Умные часы с отслеживанием сна и активности",
                        Img = "https://i2019.otzovik.com/2019/11/16/9025021/img/1200768_49296220.jpeg",
                        Price = 3499,
                        Category = categories.FirstOrDefault(x => x.Id == 3)
                    }
                };
            }
        }
    }
}