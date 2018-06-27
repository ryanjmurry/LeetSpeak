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

        [TestMethod]
        public void CharacterSwap_SwapLowerO_0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('0', testLeetSpeak.CharacterSwap('o'));
        }

        [TestMethod]
        public void CharacterSwap_SwapUpperO_0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('0', testLeetSpeak.CharacterSwap('O'));
        }

        [TestMethod]
        public void CharacterSwap_SwapUpperI_1()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('1', testLeetSpeak.CharacterSwap('I'));
        }

        [TestMethod]
        public void CharacterSwap_SwaplowerT_7()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('7', testLeetSpeak.CharacterSwap('t'));
        }

        [TestMethod]
        public void CharacterSwap_SwapUpperT_7()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('7', testLeetSpeak.CharacterSwap('T'));
        }

        [TestMethod]
        public void CharacterSwap_Swaplowers_Z()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('z', testLeetSpeak.CharacterSwap('s'));
        }

        [TestMethod]
        public void CharacterSwap_SwapUpperS_Z()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('z', testLeetSpeak.CharacterSwap('S'));
        }

        [TestMethod]
        public void CharacterSwap_NoSwap_Letter()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual('g', testLeetSpeak.CharacterSwap('g'));
        }

        [TestMethod]
        public void ArrayReplace_SwapSpecificCharacters_LeetSpeak()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("3pic07uz1", testLeetSpeak.ArrayReplace("EpicotusI"));
        }

        [TestMethod]
        public void ArrayReplace_IgnoreSAtBeginning_SkipLetterS()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("S0, d0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0, \"s0r7a!\"", testLeetSpeak.ArrayReplace("So, don't you love these 'String' exercises? I do, \"sorta!\""));
        }
    }
}
