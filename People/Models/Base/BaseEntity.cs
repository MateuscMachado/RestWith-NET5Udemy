using System.ComponentModel.DataAnnotations.Schema;

namespace People.Models.Base
{
    public class BaseEntity
    {
        [Column]
        public long Id { get; set; }
    }
}