using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface ICategories
    {
        IEnumerable<Categories> GetAllCategories { get; }
    }
}