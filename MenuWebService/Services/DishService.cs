using MenuWebService.Models;
using MenuWebService.Services.Interfaces;

namespace MenuWebService.Services;

public class DishService : IDishService
{
    private readonly ICollection<DishModel> _dishes = new List<DishModel>()
    {
        new DishModel()
        {
            Id = 1,
            Name = "Borscht",
            Description = "Delicious ukrainian borscht",
            Price = 50
        },
        new DishModel()
        {
            Id = 2,
            Name = "Salo",
            Description = "Delicious ukrainian salo",
            Price = 30
        },
        new DishModel()
        {
            Id = 3,
            Name = "Borscht",
            Description = "Delicious ukrainian borscht",
            Price = 50
        },
    };

    public DishModel Get(int id)
    {
        return _dishes.First(d => d.Id == id);
    }

    public ICollection<DishModel> GetAll()
    {
        return _dishes;
    }

    public int Add(DishModel dish)
    {
        var lastDishId = _dishes.Max(d => d.Id);

        dish.Id = ++lastDishId;
        _dishes.Add(dish);

        return dish.Id;
    }

    public int Update(DishModel dish)
    {
        var oldDish = Get(dish.Id);

        oldDish.Name = dish.Name;
        oldDish.Description = dish.Description;
        oldDish.Price = dish.Price;

        return oldDish.Id;
    }

    public int Delete(int id)
    {
        var dish = _dishes.FirstOrDefault(d => d.Id == id);

        if (dish == null)
        {
            return 0;
        }
        else
        {
            _dishes.Remove(dish);
            return id;
        }
    }
}
