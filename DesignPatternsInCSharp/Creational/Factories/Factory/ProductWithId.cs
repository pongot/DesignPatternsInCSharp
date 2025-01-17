using Microsoft.Extensions.Logging;

namespace DesignPatternsInCSharp.Creational.Factories.Factory;

public class ProductWithId
{
    private readonly ILogger<ProductWithId> _logger;

    public int Id { get; }

    public ProductWithId(int id, ILogger<ProductWithId> logger)
    {
        Id = id;
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public string Operation() => nameof(ProductWithId);
}
