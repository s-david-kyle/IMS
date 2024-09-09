using IMS.Business;

namespace IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task<IEnumerable<InventoryItem>> GetInventoryByNameAsync(string name);
}
