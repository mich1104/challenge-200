using Challenge_200;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges_200_Tests
{
    /// <summary>
    /// Tests ensuring funtionality of methods from challenge-205
    /// </summary>
    [TestClass]
    public class Challenge_200_Tests
    {
        #region 201
        Challenge_201 challenge_201 = new();

        [TestMethod]
        public void TestMasking()
        {
            /*
             From the challenge we have the following examples:

            Maskify("4556364607935616") ➞ "############5616"
            Maskify("64607935616") ➞ "#######5616"
            Maskify("1") ➞ "1"
            Maskify("") ➞ ""

             */

            Assert.AreEqual("############5616", challenge_201.Maskify("4556364607935616"));
            Assert.AreEqual("#######5616", challenge_201.Maskify("64607935616"));
            Assert.AreEqual("1", challenge_201.Maskify("1"));
            Assert.AreEqual("", challenge_201.Maskify(""));
        }
        #endregion

        #region 203

        private Challenge_203 challenge_203 = new();

        /*
         * Implementing a binary search algorithm seems a little excessive when the list is finite, would recommend using a HashSet instead.
         * Also not going to create my own binary search algorithm but rather use an existing one from a library. 
         * Another note, why not just return a bool?
         * 
         */
        [TestMethod]
        public void Test_203()
        {
            Assert.AreEqual("yes", challenge_203.IsPrime(3));
            Assert.AreEqual("yes", challenge_203.IsPrime(7));
            Assert.AreEqual("yes", challenge_203.IsPrime(11));
            Assert.AreEqual("yes", challenge_203.IsPrime(67));
            Assert.AreEqual("yes", challenge_203.IsPrime(83));
            Assert.AreEqual("yes", challenge_203.IsPrime(97));

            Assert.AreEqual("no", challenge_203.IsPrime(4));
            Assert.AreEqual("no", challenge_203.IsPrime(9));
            Assert.AreEqual("no", challenge_203.IsPrime(25));
            Assert.AreEqual("no", challenge_203.IsPrime(27));
            Assert.AreEqual("no", challenge_203.IsPrime(56));
            Assert.AreEqual("no", challenge_203.IsPrime(98));
        }

        #endregion

        #region 205
        private Challenge_205 challenge_205 = new();

        [TestMethod]
        public void Test_205_Encode()
        {
            // from the example we know the following strings and their encryptions: 
            //the string "Hello" should be encrypted to[72, 29, 7, 0, 3]
            //the string "Hi there!" should be encrypted to [72, 33, -73, 84, -12, -3, 13, -13, -68]
            //the string "Sunshine" should be encrypted to [83, 34, -7, 5, -11, 1, 5, -9]

            var helloStr = "Hello";
            var helloExpected = new[] { 72, 29, 7, 0, 3 };

            var helloResult = challenge_205.Encode(helloStr);

            CollectionAssert.AreEqual(helloExpected, helloResult);


            var hiThereStr = "Hi there!";
            var hiThereExpected = new[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 };

            var hiThereResult = challenge_205.Encode(hiThereStr);

            CollectionAssert.AreEqual(hiThereExpected, hiThereResult);


            var sunshineStr = "Sunshine";
            var sunshineExpected = new[] { 83, 34, -7, 5, -11, 1, 5, -9 };

            var sunshineResult = challenge_205.Encode(sunshineStr);

            CollectionAssert.AreEqual(sunshineExpected, sunshineResult);
        }

        [TestMethod]
        public void Test_205_Decode()
        {
            // from the example we know the following strings and their encryptions: 
            //the array [72, 29, 7, 0, 3] should be decrypted to "Hello"
            //the array [72, 33, -73, 84, -12, -3, 13, -13, -68] should be decrypted to "Hi there!"
            //the array [83, 34, -7, 5, -11, 1, 5, -9] should be decrypted to "Sunshine"

            var helloEncrypted = new[] { 72, 29, 7, 0, 3 };
            var helloExpected = "Hello";

            var helloResult = challenge_205.Decode(helloEncrypted);

            Assert.AreEqual(helloExpected, helloResult);


            var hiThereEncrypted = new[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 };
            var hiThereExpected = "Hi there!";

            var hiThereResult = challenge_205.Decode(hiThereEncrypted);

            Assert.AreEqual(hiThereExpected, hiThereResult);


            var sunshineEncrypted = new[] { 83, 34, -7, 5, -11, 1, 5, -9 };
            var sunshineExpected = "Sunshine";

            var sunshineResult = challenge_205.Decode(sunshineEncrypted);

            Assert.AreEqual(sunshineExpected, sunshineResult);
        }
        #endregion
    }
}
