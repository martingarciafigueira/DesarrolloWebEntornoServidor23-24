//Declaro las variables
float precio, precioFinal;
int descuentoAplicable;
//Pido las variables por pantalla
Console.Write("Dame el precio del producto: ");
precio = float.Parse(Console.ReadLine());

//Compruebo qué descuento aplicar
if (precio < 100)
{
    descuentoAplicable = 10;
}
else
{
    descuentoAplicable = 15;
}

precioFinal = precio * ((100 - descuentoAplicable) / 100f);

Console.WriteLine("El precio inicial del producto era {0}, se le aplica un descuento del {1}% y el precio final es: {2}", precio, descuentoAplicable, precioFinal);

Console.ReadLine();