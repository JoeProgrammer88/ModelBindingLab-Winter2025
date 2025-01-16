using System.ComponentModel.DataAnnotations;

namespace ModelBindingLab.Models;

/// <summary>
/// Represents a single Video Game
/// for sale
/// </summary>
public class VideoGame : Product
{
    /// <summary>
    /// Target platform
    /// </summary>
    public required string SupportedPlatform { get; set; }

    /// <summary>
    /// ESRB rating of the game
    /// </summary>
    public required string ESRBRating { get; set; }
}

public class Product
{
    /// <summary>
    /// A unique identifier for the product
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Type of product. Ex: Console, peripheral, game
    /// </summary>
    public required string Category { get; set; }

    /// <summary>
    /// The user facing title of the product
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// The cost to the business for this product
    /// </summary>
    public double Overhead { get; set; }

    /// <summary>
    /// Price the product sells for
    /// </summary>
    [Range(0.01, double.MaxValue)]
    [DataType(DataType.Currency)]
    public double SalesPrice { get; set; }

    /// <summary>
    /// Universal Product Code. This is a 
    /// 12 digit unique identifier. These may
    /// start with 0
    /// </summary>
    [RegularExpression(@"^\d{12}$", ErrorMessage = "The UPC must be a 12 digit code")]
    public required string UPC { get; set; }
}
