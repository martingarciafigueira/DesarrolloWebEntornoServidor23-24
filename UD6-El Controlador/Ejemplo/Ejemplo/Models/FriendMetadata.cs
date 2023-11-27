using System.ComponentModel.DataAnnotations;

namespace Ejemplo.Models
{
    // File: FriendMetadata.cs

    public class FriendMetadata
    {
        [Required, StringLength(50)] public string Name { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        [Required, StringLength(100)] public string Email { get; set; }

        [Range(18, 99)]
        public int Age { get; set; }
    }

}
