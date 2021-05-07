using System.Collections.Generic;
using System.Linq;

namespace ApplicationDataLibrary
{
    public static class ComparerExtensions
    {
        /// <summary>
        /// Wrapper for <see cref="FirstNameLastNameEqualityComparer"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static IEnumerable<Person> DistinctFirstLastName(this IEnumerable<Person> sender)
        {
            return sender.Distinct(new FirstNameLastNameEqualityComparer());
        }
        /// <summary>
        /// Wrapper for <see cref="FirstNameComparer"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static IEnumerable<Person> DistinctFirstName(this IEnumerable<Person> sender)
        {
            return sender.Distinct(new FirstNameComparer());
        }

        public static IEnumerable<T> WithDistinctProperty<T>(this IEnumerable<T> sender, string propertyName)
        {
            return sender.Distinct(new PropertyComparer<T>(propertyName));
        }
    }
}