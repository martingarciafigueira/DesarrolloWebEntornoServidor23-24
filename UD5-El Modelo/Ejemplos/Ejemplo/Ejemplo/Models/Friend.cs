using System.ComponentModel.DataAnnotations;

namespace Ejemplo.Models
{
    [MetadataType(typeof(FriendMetadata))]
    public class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
    }

}
