using MenuWebService.Models;
using MenuWebService.Services.Interfaces;

namespace MenuWebService.Services;

public class MenuService : IMenuService
{
    private readonly IDishService _dishService;

    public MenuService(IDishService dishService)
    {
        _dishService = dishService;
    }

    public DishModel GetDish(int id)
    {
        return _dishService.Get(id);
    }

    public ICollection<DishModel> GetAllDishes()
    {
        return _dishService.GetAll();
    }

    public int AddDish(DishModel dish)
    {
        return _dishService.Add(dish);
    }

    public int UpdateDish(DishModel dish)
    {
        return _dishService.Update(dish);
    }

    public int DeleteDish(int id)
    {
        return _dishService.Delete(id);
    }
}
