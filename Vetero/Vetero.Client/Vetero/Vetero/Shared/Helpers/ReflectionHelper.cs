namespace Vetero.Shared.Helpers
{
    public static class ReflectionHelper
    {
        public static List<string> GetPropertiesNames(object pObject)
        {
            List<string> propertyList = new List<string>();
            if (pObject != null)
            {
                foreach (var prop in pObject.GetType().GetProperties())
                {
                    propertyList.Add(prop.Name);
                }
            }
            return propertyList;
        }
    }
}
