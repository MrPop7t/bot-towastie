using System.ComponentModel.DataAnnotations;

namespace Towastie.DAL
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}