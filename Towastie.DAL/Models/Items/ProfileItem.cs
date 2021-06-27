using Towastie.DAL.Models.Profiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace Towastie.DAL.Models.Items
{
    public class ProfileItem : Entity
    {

        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public ProfileItem Profile { get; set; }
        public int ItemId { get; set;}
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}