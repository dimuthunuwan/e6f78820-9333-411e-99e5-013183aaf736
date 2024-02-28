using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFinder.Logic.Interfaces;
using StringFinder.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFinder.Logic.Services.Tests
{
    [TestClass()]
    public class FindingServiceTests
    {
        private readonly IFindingService _findingService;

        /// <summary>
        /// Consutructor
        /// </summary>
        /// <param name="findingService"></param>
        public FindingServiceTests(IFindingService findingService)
        {
            _findingService = findingService;
        }


        /// <summary>
        /// Test method for empty input with SubsequenceFinder method
        /// </summary>
        [TestMethod()]
        public void EmptyInput()
        {
            string strInput = "";
            string strExpectedOutput = "";

            string strActualOutput = _findingService.SubsequenceFinder(strInput);

            Assert.AreEqual(strExpectedOutput, strActualOutput);
        }

        /// <summary>
        /// Test method for single element with SubsequenceFinder method
        /// </summary>
        [TestMethod]
        public void SingleElement()
        {
            string strInput = "1";
            string strExpectedOutput = "1";

            string strActualOutput = _findingService.SubsequenceFinder(strInput);

            Assert.AreEqual(strExpectedOutput, strActualOutput);
        }

        /// <summary>
        /// Test method for multiple elements with SubsequenceFinder method
        /// </summary>
        [TestMethod]
        public void MultipleElements()
        {
            string strInput = "923 11613 30483 19569 24201 13461 1189 30793 8848 16914 16053 21700 22116 3852 20909 5231 31469 3862 16353 22813 28735 4421" +
                " 3618 32303 9932 31892 7823 22547 28888 11143 11695 3339 2094 11023 9661 27440 7186 24750 15427 24502 31606 23515 3563 29553 12145 22184" +
                " 11409 28824 6636 10658 21404 5578 27807 14073 13967 31310 3132 4321 7643 1951 13289 24375 17912 11304";

            string strExpectedOutput = "3862 16353 22813 28735";

            string strActualOutput = _findingService.SubsequenceFinder(strInput);

            Assert.AreEqual(strExpectedOutput, strActualOutput);
        }
    }
}