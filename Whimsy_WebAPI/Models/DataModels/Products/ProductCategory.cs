﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.Products
{
    /// <summary>
    /// Represents a category entity.
    /// </summary>
    [Table("ProductCategories")]
    [Index(nameof(Name), IsUnique = true)]
    public class ProductCategory
    {
        /// <summary>
        /// Gets or sets the category ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the category.
        /// </summary>
        [MaxLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the ID of the parent category.
        /// Null if it's a root category.
        /// </summary>
        public int? ParentCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the parent category.
        /// </summary>
        [ForeignKey(nameof(ParentCategoryId))]
        public virtual ProductCategory? ParentCategory { get; set; }

        /// <summary>
        /// Gets or sets the display order of the category.
        /// </summary>
        public int DisplayOrder { get; set; } = 0;

        /// <summary>
        /// Gets or sets the level of the category in the hierarchy.
        /// </summary>
        public int Level { get; set; } = 0;

        /// <summary>
        /// Gets or sets the collection of subcategories associated with this category.
        /// </summary>
        public virtual ICollection<ProductCategory> SubCategories { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of products associated with the category.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of favorite categories associated with the category.
        /// </summary>
        public virtual ICollection<CategoryFavorite> CategoryFavorites { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of favorite categories associated with the category.
        /// </summary>
        public virtual ICollection<CategoryDiscount> CategoryDiscounts { get; set; } = [];
    }
}
