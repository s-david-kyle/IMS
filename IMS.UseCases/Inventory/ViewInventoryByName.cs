using IMS.Business;
using IMS.UseCases.Inventory.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventory;


public class ViewInventoryByName : IViewInventoryByName
{
    private readonly IInventoryRepository _inventoryRepository;
    public ViewInventoryByName(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    public async Task<IEnumerable<InventoryItem>> ExecuteAsync(string name = "")
    {
        return await _inventoryRepository.GetInventoryByNameAsync(name);


    }
}
