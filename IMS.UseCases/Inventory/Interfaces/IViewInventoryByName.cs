using IMS.Business;

namespace IMS.UseCases.Inventory.Interfaces;

public interface IViewInventoryByName
{
    Task<IEnumerable<InventoryItem>> ExecuteAsync(string name = "");
}