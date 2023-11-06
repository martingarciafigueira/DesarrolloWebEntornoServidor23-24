using System.ComponentModel.DataAnnotations;

namespace Ejemplo.Models
{
    public static class ValidacionesPersonalizadas
    {
        public static ValidationResult EsPar(int valor)
        {
            if (valor % 2 == 0) return ValidationResult.Success;
            else return new ValidationResult("Debería ser un número par");
        }
    }
}
