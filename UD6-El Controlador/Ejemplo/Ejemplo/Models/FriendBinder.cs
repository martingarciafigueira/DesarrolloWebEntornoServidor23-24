using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Models
{
    public class FriendBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext,
        ModelBindingContext
        bindingContext)
        {
            // First, execute the default logic
            Friend friend = (Friend)base.BindModel(controllerContext, bindingContext);
            // And now, bind the BirthDate
            try
            {
                // Obtains the Value Provider which will get the values
                // from the request context...

                IValueProvider valueProvider = bindingContext.ValueProvider;


                // Get the values and perform type conversions...
                int year = (int)valueProvider.GetValue("year").ConvertTo(typeof(int));
                int month = (int)valueProvider.GetValue("month").ConvertTo(typeof(int));
                int day = (int)valueProvider.GetValue("day").ConvertTo(typeof(int));

                friend.BirthDate = new DateTime(year, month, day);

            }
            catch
            {
                friend.BirthDate = null;
            }
            return friend;
        }
    }
}
