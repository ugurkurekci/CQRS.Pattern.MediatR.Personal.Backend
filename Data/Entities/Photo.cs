using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class Photo : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required, MinLength(1)]
    public string ImagePath { get; set; }

    public DateTime CreationDate { get; set; } = DateTime.Now;

    [DefaultValue(typeof(DateTime), "2021-01-01")]
    public DateTime UpdateDate { get; set; }
}