using NUnit.Framework;
using System.Collections.Generic;
using UniqueChars;

namespace TestUniqueChars
{
    [TestFixture]
    class TestChars
    {
        Chars chars = new Chars();

        [Test]
        public void TestUniqueCharacters()       
        {
            string word = "cat";

            List<string> output = new List<string>()
            {
                {"c"},
                {"a"},
                {"t"}
            };

            Assert.AreEqual(output, chars.UniqueCharacters(word));
        }

        [Test]
        public void TestUniqueCharactersWhenEmptyString()
        {
            string word = "";

            List<string> output = new List<string>()
            {
                {"empty"},             
            };

            Assert.AreEqual(output, chars.UniqueCharacters(word));
        }

        [Test]
        public void TestUniqueCharactersWhenNullString()
        {
            string word = null;

            List<string> output = new List<string>()
            {
                {"null"},
            };

            Assert.AreEqual(output, chars.UniqueCharacters(word));
        }
    }
}