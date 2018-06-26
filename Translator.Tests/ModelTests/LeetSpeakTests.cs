using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Translator;

namespace Translator.Tests
{
    [TestClass]
    public class LeetSpeakTests
    {
        [TestMethod]
        public void CharacterSwap_SwapLowerE_3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('3', testLeetSpeak.CharacterSwap('e'));
        }

        [TestMethod]
        public void CharacterSwap_SwapUpperE_3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('3', testLeetSpeak.CharacterSwap('E'));
        }

    }
}
