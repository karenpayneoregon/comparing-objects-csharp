using System.Collections.Generic;
using System.Reflection;

namespace ApplicationDataLibrary
{
    public class PropertyComparer<T> : IEqualityComparer<T>
    {
        private readonly PropertyInfo propertyToCompare;

        public PropertyComparer(string propertyName)
        {
            propertyToCompare = typeof(T).GetProperty(propertyName);
        }
        public bool Equals(T x, T y)
        {
            object xValue = propertyToCompare.GetValue(x, null);
            object yValue = propertyToCompare.GetValue(y, null);
            return xValue.Equals(yValue);
        }

        public int GetHashCode(T source)
        {
            object objValue = propertyToCompare.GetValue(source, null);
            return objValue.GetHashCode();
        }
    }
}