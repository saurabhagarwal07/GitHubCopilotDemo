using ElectronicsInventory.Api.Data;
using ElectronicsInventory.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicsInventory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(ProductStore.Products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = ProductStore.Products.FirstOrDefault(p => p.Id == id);
        if (product is null)
            return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> Create([FromBody] Product product)
    {
        product.Id = ProductStore.GetNextId();
        ProductStore.Products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public ActionResult<Product> Update(int id, [FromBody] Product product)
    {
        var existing = ProductStore.Products.FirstOrDefault(p => p.Id == id);
        if (existing is null)
            return NotFound();

        existing.Name = product.Name;
        existing.ManufacturerName = product.ManufacturerName;
        existing.WarrantyInformation = product.WarrantyInformation;
        existing.ProductDescription = product.ProductDescription;
        existing.QuantityAtHand = product.QuantityAtHand;

        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var product = ProductStore.Products.FirstOrDefault(p => p.Id == id);
        if (product is null)
            return NotFound();

        ProductStore.Products.Remove(product);
        return NoContent();
    }
}
