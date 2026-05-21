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
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/wm/0/0/d3136d0800646b0b8a3",
                        Price = 3699,
                        Category = categories.FirstOrDefault(x => x.Id == 1)
                    },
                    new Items()
                    {
                        Id = 2,
                        Name = "Samsung Galaxy S23",
                        Description = "Флагманский смартфон с мощным процессором и отличной камерой",
                        Img = "https://example.com/samsung-s23.jpg",
                        Price = 69999,
                        Category = categories.FirstOrDefault(x => x.Id == 2)
                    },
                    new Items()
                    {
                        Id = 3,
                        Name = "Apple iPhone 15",
                        Description = "Новейший iPhone с динамическим островом и USB-C",
                        Img = "https://example.com/iphone-15.jpg",
                        Price = 79999,
                        Category = categories.FirstOrDefault(x => x.Id == 2)
                    },
                    new Items()
                    {
                        Id = 4,
                        Name = "Xiaomi Mi Band 8",
                        Description = "Умные часы с отслеживанием сна и активности",
                        Img = "https://example.com/mi-band-8.jpg",
                        Price = 3499,
                        Category = categories.FirstOrDefault(x => x.Id == 3)
                    }
                };
            }
        }
    }
}