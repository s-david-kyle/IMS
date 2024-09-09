using IMS.Business;
using IMS.UseCases.Inventory.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventory;

public class AddInventory : IAddInventory
{
    private readonly IInventoryRepository _inventoryRepository;

    public AddInventory(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;

    }
    public async Task ExecuteAsync(InventoryItem inventoryItem)
    {
        await _inventoryRepository.AddInventoryAsync(inventoryItem);

    }

}
