using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCategories : ICategories
    {
        public IEnumerable<Categories> GetAllCategories
        {
            get
            {
                return new List<Categories>()
                {
                    new Categories() { Id = 1, Name = "Бытовая техника", Description = "Микроволновки, холодильники и другая техника" },
                    new Categories() { Id = 2, Name = "Смартфоны", Description = "Мобильные телефоны и аксессуары" },
                    new Categories() { Id = 3, Name = "Гаджеты", Description = "Умные часы, фитнес-браслеты" },
                    new Categories() { Id = 4, Name = "Телевизоры", Description = "LED, OLED, 4K телевизоры" },
                    new Categories() { Id = 5, Name = "Игровые консоли", Description = "PlayStation, Xbox, Nintendo" },
                    new Categories() { Id = 6, Name = "Периферия", Description = "Клавиатуры, мыши, гарнитуры" },
                    new Categories() { Id = 7, Name = "Фототехника", Description = "Камеры, объективы" },
                    new Categories() { Id = 8, Name = "Аудио", Description = "Колонки, наушники" }
                };
            }
        }
    }
}