using AutoMapper;
using AutoAutoMapper.Test.TestResources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoAutoMapper.Test
{
    [TestFixture]
    public class AutoProfilerScanModeFixture
    {
        [SetUp]
        public void SetUp()
        {
            // remove all mappings before each test
            Mapper.Reset();
        }

        [Test]
        public void TestProfile_Will_Be_Registered_If_The_Selector_Is_StartsWith_AutoAutoMapper()
        {
            // arrange
            var scanMode = Selector.StartsWith;
            var param = "AutoAutoMapper"; // this selects the Test Assembly itself
            var classA = new ClassA() { MyProperty = "prop" };

            // act
            AutoProfiler.RegisterProfiles(scanMode, param);
            var classB = Mapper.Map<ClassA,ClassB>(classA);

            // assert
            Assert.AreEqual("prop", classB.MyProperty);
        }

        [Test]
        public void TestProfile_Will_Be_Registered_If_The_Selector_Is_Contains_Test()
        {
            // arrange
            var scanMode = Selector.Contains;
            var param = "Test"; // // this selects the Test Assembly itself
            var classA = new ClassA() { MyProperty = "prop" };

            // act
            AutoProfiler.RegisterProfiles(scanMode, param);
            var classB = Mapper.Map<ClassA, ClassB>(classA);

            // assert
            Assert.AreEqual("prop", classB.MyProperty);
        }
    }
}
