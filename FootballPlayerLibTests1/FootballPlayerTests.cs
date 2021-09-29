using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayerLib.Tests
{

    

    [TestClass()]
    public class FootballPlayerTests
    {

        private FootballPlayer _footballPlayer;

        [TestInitialize]
        public void Start()
        {
            _footballPlayer = new FootballPlayer(1, "Peter", 100, 1);
        }


        [TestMethod()]
        public void ConsTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Peter", 100, 1);
            Assert.AreEqual("Peter", footballPlayer.Name);
            Assert.AreEqual(1, footballPlayer.Id);
            Assert.AreEqual(100, footballPlayer.Price);
            Assert.AreEqual(1, footballPlayer.ShirtNumber);

        }


        [TestMethod()]
        public void NameTest()
        {
            _footballPlayer.Name = "Peter";
            Assert.AreEqual("Peter", _footballPlayer.Name);


            Assert.ThrowsException<ArgumentNullException>(() => _footballPlayer.Name = null);
            Assert.ThrowsException<ArgumentException>(() => _footballPlayer.Name = "");
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => _footballPlayer.Price = 0);

            _footballPlayer.Price = 100;
            Assert.AreEqual(100, _footballPlayer.Price);
        }

        [TestMethod()]
        public void ShirtTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 0);

            _footballPlayer.ShirtNumber = 1;
            Assert.AreEqual(1, _footballPlayer.ShirtNumber);

            _footballPlayer.ShirtNumber = 100;
            Assert.AreEqual(100, _footballPlayer.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 101);
        }

    }
}