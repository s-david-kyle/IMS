using IMS.Business;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory;

public class InventoryRepository : IInventoryRepository
{
    private readonly List<InventoryItem> _inventoryItems;

    public InventoryRepository()
    {
        _inventoryItems = new List<InventoryItem>
        {
            new InventoryItem { Id = 1, Name = "Bike Seat", Quantity = 10, Price = 2 },
            new InventoryItem { Id = 2, Name = "Bike Body", Quantity = 10, Price = 15 },
            new InventoryItem { Id = 3, Name = "Bike Wheel", Quantity = 20, Price = 8 },
            new InventoryItem { Id = 3, Name = "Bike Pedal", Quantity = 20, Price = 1 }
        };

    }

    public Task AddInventoryAsync(InventoryItem inventoryItem)
    {
        if (_inventoryItems.Any(x => string.Equals(x.Name, inventoryItem.Name, StringComparison.OrdinalIgnoreCase)))
            return Task.CompletedTask;

        var maxId = _inventoryItems.Max(x => x.Id);
        inventoryItem.Id = maxId + 1;

        _inventoryItems.Add(inventoryItem);

        return Task.CompletedTask;
    }

    public async Task<IEnumerable<InventoryItem>> GetInventoryByNameAsync(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return await Task.FromResult(_inventoryItems);
        }
        return await Task.FromResult(_inventoryItems.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
    }
}
