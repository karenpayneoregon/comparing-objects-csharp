using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationDataLibrary;
using ApplicationDataLibrary.ComparerHelpers;

using ComparingObjectsUnitTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComparingObjectsUnitTest
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.ReadPerson)]
        public void Validate_Read_PeopleFromFile()
        {
            var people = ReadPeopleFromFile;
            Assert.IsTrue(people.Count == 50);
        }
        
        /// <summary>
        /// Validate <see cref="FirstNameLastNameEqualityComparer"/> Distinct
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Distinct)]
        public void FirstNameLastName_Equality_Comparer()
        {
            var people = ReadPeopleFromFile;
            people.Add(people[0]);
            Assert.AreEqual(people.Count, 51);
            
            var distinct = people.Distinct(new FirstNameLastNameEqualityComparer());
            
            Assert.IsTrue(distinct.Count() == 50);
        }

        /// <summary>
        /// Validate <see cref="FirstNameComparer"/> Distinct
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Distinct)]
        public void FirstName_Comparer()
        {
            var people = ReadPeopleFromFile;

            people[1].FirstName = people[2].FirstName;
            people[4].FirstName = people[2].FirstName;
            
            var distinct = people.Distinct(new FirstNameComparer());

            Assert.IsTrue(distinct.Count() == 48);

            
        }
        [TestMethod]
        [TestTraits(Trait.GenericWrappers)]
        public void FirstName_Generic_Comparer()
        {
            var people = ReadPeopleFromFile;

            people[1].FirstName = people[2].FirstName;
            people[4].FirstName = people[2].FirstName;


            var distinct = people.Distinct(Wrappers.FirstNamEqualityComparer);

            Assert.IsTrue(distinct.Count() == 48);

        }

        [TestMethod]
        [TestTraits(Trait.GenericWrappers)]
        public void LambdaEquals()
        {

            var people = TwoPersons;
            Assert.IsTrue(Wrappers.FirstNameLambda.Equals(people[0], people[1]));

            people[1].FirstName = "Mary";
            Assert.IsFalse(Wrappers.FirstNameLambda.Equals(people[0], people[1]));

        }

    }
}
