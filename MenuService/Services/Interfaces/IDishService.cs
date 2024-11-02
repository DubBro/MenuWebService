using MenuWebService.Models;

namespace MenuWebService.Services.Interfaces;

public interface IDishService
{
    DishModel Get(int id);

    ICollection<DishModel> GetAll();

    public int Add(DishModel dish);

    public int Update(DishModel dish);

    public int Delete(int id);
}
