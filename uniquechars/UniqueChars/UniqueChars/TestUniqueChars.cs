using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueChars;

namespace UniqueChars
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
    }
}