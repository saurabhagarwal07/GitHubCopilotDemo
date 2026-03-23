using ElectronicsInventory.Api.Models;

namespace ElectronicsInventory.Api.Data;

public static class ProductStore
{
    private static int _nextId = 11;

    public static List<Product> Products { get; } = new()
    {
        new Product
        {
            Id = 1,
            Name = "Ultra HD Smart TV 55\"",
            ManufacturerName = "Samsung",
            WarrantyInformation = "2-year manufacturer warranty",
            ProductDescription = "55-inch 4K Ultra HD Smart LED TV with HDR10+ and built-in streaming apps.",
            QuantityAtHand = 25
        },
        new Product
        {
            Id = 2,
            Name = "Wireless Noise-Cancelling Headphones",
            ManufacturerName = "Sony",
            WarrantyInformation = "1-year manufacturer warranty",
            ProductDescription = "Over-ear wireless headphones with active noise cancellation and 30-hour battery life.",
            QuantityAtHand = 150
        },
        new Product
        {
            Id = 3,
            Name = "Gaming Laptop 15.6\"",
            ManufacturerName = "ASUS",
            WarrantyInformation = "2-year manufacturer warranty with accidental damage protection",
            ProductDescription = "15.6-inch gaming laptop with RTX 4070, Intel i7 processor, 16GB RAM, and 1TB SSD.",
            QuantityAtHand = 40
        },
        new Product
        {
            Id = 4,
            Name = "Smartphone Pro Max 256GB",
            ManufacturerName = "Apple",
            WarrantyInformation = "1-year limited warranty; AppleCare+ available",
            ProductDescription = "6.7-inch Super Retina XDR display, A17 Pro chip, 48MP camera system, 256GB storage.",
            QuantityAtHand = 200
        },
        new Product
        {
            Id = 5,
            Name = "Bluetooth Portable Speaker",
            ManufacturerName = "JBL",
            WarrantyInformation = "1-year manufacturer warranty",
            ProductDescription = "Waterproof portable Bluetooth speaker with 12-hour playtime and deep bass.",
            QuantityAtHand = 300
        },
        new Product
        {
            Id = 6,
            Name = "Mechanical Gaming Keyboard",
            ManufacturerName = "Logitech",
            WarrantyInformation = "2-year manufacturer warranty",
            ProductDescription = "RGB mechanical keyboard with tactile switches, programmable keys, and USB-C connectivity.",
            QuantityAtHand = 85
        },
        new Product
        {
            Id = 7,
            Name = "4K Action Camera",
            ManufacturerName = "GoPro",
            WarrantyInformation = "1-year limited warranty; GoPro subscription extends coverage",
            ProductDescription = "Waterproof 4K action camera with HyperSmooth stabilization and voice control.",
            QuantityAtHand = 60
        },
        new Product
        {
            Id = 8,
            Name = "Wireless Charging Pad",
            ManufacturerName = "Anker",
            WarrantyInformation = "18-month manufacturer warranty",
            ProductDescription = "15W fast wireless charging pad compatible with Qi-enabled devices.",
            QuantityAtHand = 500
        },
        new Product
        {
            Id = 9,
            Name = "27\" 4K Monitor",
            ManufacturerName = "Dell",
            WarrantyInformation = "3-year limited hardware warranty with Advanced Exchange Service",
            ProductDescription = "27-inch 4K UHD IPS monitor with USB-C hub, 99% sRGB, and adjustable stand.",
            QuantityAtHand = 45
        },
        new Product
        {
            Id = 10,
            Name = "Robot Vacuum Cleaner",
            ManufacturerName = "iRobot",
            WarrantyInformation = "1-year manufacturer warranty",
            ProductDescription = "Smart robot vacuum with mapping technology, self-emptying base, and app control.",
            QuantityAtHand = 70
        }
    };

    public static int GetNextId() => _nextId++;
}
