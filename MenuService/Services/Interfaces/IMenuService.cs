using MenuWebService.Models;
using System.ServiceModel;

namespace MenuWebService.Services.Interfaces;

[ServiceContract]
public interface IMenuService
{
    [OperationContract]
    DishModel GetDish(int id);

    [OperationContract]
    ICollection<DishModel> GetAllDishes();

    [OperationContract]
    int AddDish(DishModel dish);

    [OperationContract]
    int UpdateDish(DishModel dish);

    [OperationContract]
    int DeleteDish(int id);
}
