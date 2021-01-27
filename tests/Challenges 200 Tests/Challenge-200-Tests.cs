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

        #region 205
        private Challenge_205 challenge_205 = new();

        [TestMethod]
        public void TestEncode()
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
        public void TestDecode()
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
