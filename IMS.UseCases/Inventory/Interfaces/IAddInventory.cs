using IMS.Business;

namespace IMS.UseCases.Inventory.Interfaces
{
    public interface IAddInventory
    {
        Task ExecuteAsync(InventoryItem inventoryItem);
    }
}