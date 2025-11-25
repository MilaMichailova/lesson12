using System.ComponentModel.DataAnnotations;

namespace lesson12.Dto;

public class ProductDto
{
    [Required(ErrorMessage = "Название товара обязательно.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Название должно быть от 2 до 100 символов.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Описание обязательно.")]
    [StringLength(500, MinimumLength = 5, ErrorMessage = "Описание должно быть от 5 до 500 символов.")]
    public string? Description { get; set; }

    [Range(0.01, 1000000, ErrorMessage = "Цена должна быть от 0.01 до 1 000 000.")]
    public decimal Price { get; set; }

    [Range(0, 10000, ErrorMessage = "Остаток должен быть от 0 до 10 000.")]
    public int Stock { get; set; }

    [Required(ErrorMessage = "Категория обязательна.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Категория должна быть от 2 до 50 символов.")]
    public string? Category { get; set; }
}