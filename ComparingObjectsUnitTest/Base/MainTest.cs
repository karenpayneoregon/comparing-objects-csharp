﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDataLibrary;


// ReSharper disable once CheckNamespace - do not change
namespace ComparingObjectsUnitTest
{
    public partial class MainTest
    {
        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }

        public static List<Person> ReadPeopleFromFile => PersonOperations.Read("Data\\people.json");
        public static List<Person> TwoPersons => 
            new()
            {
                new() { FirstName = "Karen", LastName = "Payne" }, 
                new() { FirstName = "Karen", LastName = "Payne" }
            };


    }

}