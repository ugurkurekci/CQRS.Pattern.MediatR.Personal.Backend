using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class About : BaseEntity
    {
        public int photoID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MinLength(10)]
        public string JobTitle { get; set; }

        [Required, MinLength(10)]
        public string Description { get; set; }

        [DefaultValue(typeof(DateTime), "2021-01-01")]
        public DateTime CreationDate { get; set; }

        [DefaultValue(typeof(DateTime), "2021-01-01")]
        public DateTime UpdateDate { get; set; }

        [DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}