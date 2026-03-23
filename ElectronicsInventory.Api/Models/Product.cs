namespace ElectronicsInventory.Api.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ManufacturerName { get; set; } = string.Empty;
    public string WarrantyInformation { get; set; } = string.Empty;
    public string ProductDescription { get; set; } = string.Empty;
    public int QuantityAtHand { get; set; }
}
