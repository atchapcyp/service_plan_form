using Service_plan_form.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form.Mapping
{
    public static class AttributeHelper
    {
        public static List<string> GetDataNames(Type type, string propertyName)
        {
            var property = type.GetProperty(propertyName).GetCustomAttributes(false).Where(x => x.GetType().Name == "DataNamesAttribute").FirstOrDefault();
            if (property != null)
            {
                return ((DataNamesAttribute)property).ValueNames;
            }
            return new List<string>();
        }
    }
}
