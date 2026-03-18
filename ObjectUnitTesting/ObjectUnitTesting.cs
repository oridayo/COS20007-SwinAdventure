using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwinAdventure;

namespace ObjectUnitTesting
{
    [TestFixture]

    internal class ObjectUnitTesting
    {
        private IdentifiableObject obj;

        [SetUp]
        public void Setup()
        {
            obj = new IdentifiableObject(new string[] {"book", "quill"});
        }

        //test are you
        [Test]
        public void TestAreYou()
        {
            string newobj = "book";

            bool actual = obj.AreYou(newobj);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        //test if not are you
        [Test]
        public void TestAreYouNot()
        {
            string newobj = "pen";

            bool actual = obj.AreYou(newobj);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        //test if the are you is case sentitive
        [Test]
        public void TestAreYouCaseSensitive()
        {
            string newobj = "bOOk";

            bool actual = obj.AreYou(newobj);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        //test first id of the list
        [Test]
        public void TestFirstId()
        {
            string actual = obj.FirstId();
            string expected = "book";

            Assert.AreEqual(expected, actual);
        }

        //test if empty string whether will come out 
        [Test]
        public void TestEmptyString()
        {
            IdentifiableObject emptyobj = new IdentifiableObject(new string[] {});

            string actual = emptyobj.FirstId();
            string expected = "";

            Assert.AreEqual (expected, actual);
        }

        //test adding id
        [Test]
        public void TestAddId()
        {
            string newobj = "Cup";

            obj.AddIdentifier(newobj);

            bool actual = obj.AreYou(newobj);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
