using System.ComponentModel.DataAnnotations;

namespace Ejemplo.Models
{
    public class EsParAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int i = Convert.ToInt32(value);
            return i % 2 == 0;
        }
    }
}
