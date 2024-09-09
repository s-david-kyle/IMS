using IMS.Business;

namespace IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task AddInventoryAsync(InventoryItem inventoryItem);
    Task<IEnumerable<InventoryItem>> GetInventoryByNameAsync(string name);
}
