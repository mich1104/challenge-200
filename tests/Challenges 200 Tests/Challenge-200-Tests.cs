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

        [TestMethod]
        public void Test_201_Masking()
        {
            /*
             From the challenge we have the following examples:

            Maskify("4556364607935616") ➞ "############5616"
            Maskify("64607935616") ➞ "#######5616"
            Maskify("1") ➞ "1"
            Maskify("") ➞ ""

             */

            Challenge_201 challenge = new();

            Assert.AreEqual("############5616", challenge.Maskify("4556364607935616"));
            Assert.AreEqual("#######5616", challenge.Maskify("64607935616"));
            Assert.AreEqual("1", challenge.Maskify("1"));
            Assert.AreEqual("", challenge.Maskify(""));
        }
        #endregion

        #region 202
        /**
         * Had to read up on prime factors, probably gonna use recursion to solve it though I'd prefer to use a loop since C# is optimized for that.
         * 
         */
        [TestMethod]
        public void Test_202_PrimeFactors()
        {
            /*
             * Examples from the challenge:
                ExpressFactors(2) ➞ "2"
                ExpressFactors(4) ➞ "2^2"
                ExpressFactors(10) ➞ "2 x 5"
                ExpressFactors(60) ➞ "2^2 x 3 x 5"
             */

            Challenge_202 challenge = new();

            Assert.AreEqual("2", challenge.ExpressFactors(2));
            Assert.AreEqual("2^2", challenge.ExpressFactors(4));
            Assert.AreEqual("2 x 5", challenge.ExpressFactors(10));
            Assert.AreEqual("2^2 x 3 x 5", challenge.ExpressFactors(60));
        }
        #endregion

        #region 203
        /*
         * Implementing a binary search algorithm seems a little excessive when the list is finite, would recommend using a HashSet instead.
         * Also not going to create my own binary search algorithm but rather use an existing one from a library. 
         * Another note, why not just return a bool?
         * Or have the function calculate prime numbers up until the parameter, cache them for future use, to avoid the list being finite.
         */
        [TestMethod]
        public void Test_203_IsPrime()
        {
            Challenge_203 challenge = new();

            Assert.AreEqual("yes", challenge.IsPrime(3));
            Assert.AreEqual("yes", challenge.IsPrime(7));
            Assert.AreEqual("yes", challenge.IsPrime(11));
            Assert.AreEqual("yes", challenge.IsPrime(67));
            Assert.AreEqual("yes", challenge.IsPrime(83));
            Assert.AreEqual("yes", challenge.IsPrime(97));

            Assert.AreEqual("no", challenge.IsPrime(4));
            Assert.AreEqual("no", challenge.IsPrime(9));
            Assert.AreEqual("no", challenge.IsPrime(25));
            Assert.AreEqual("no", challenge.IsPrime(27));
            Assert.AreEqual("no", challenge.IsPrime(56));
            Assert.AreEqual("no", challenge.IsPrime(98));
        }

        #endregion

        #region 204
        [TestMethod]
        public void Test_204_PotatoCount()
        {
            Challenge_204 challenge = new();
            Assert.AreEqual(1, challenge.Potato("Potato-Potahto"));
            Assert.AreEqual(0, challenge.Potato("Fried-Potahto"));
            Assert.AreEqual(1, challenge.Potato("Fried-Potato"));
            Assert.AreEqual(2, challenge.Potato("Potato-Potato"));
        }
        #endregion

        #region 205

        [TestMethod]
        public void Test_205_Encode()
        {
            // from the example we know the following strings and their encryptions: 
            //the string "Hello" should be encrypted to[72, 29, 7, 0, 3]
            //the string "Hi there!" should be encrypted to [72, 33, -73, 84, -12, -3, 13, -13, -68]
            //the string "Sunshine" should be encrypted to [83, 34, -7, 5, -11, 1, 5, -9]

            Challenge_205 challenge = new();

            var helloStr = "Hello";
            var helloExpected = new[] { 72, 29, 7, 0, 3 };

            var helloResult = challenge.Encode(helloStr);

            CollectionAssert.AreEqual(helloExpected, helloResult);


            var hiThereStr = "Hi there!";
            var hiThereExpected = new[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 };

            var hiThereResult = challenge.Encode(hiThereStr);

            CollectionAssert.AreEqual(hiThereExpected, hiThereResult);


            var sunshineStr = "Sunshine";
            var sunshineExpected = new[] { 83, 34, -7, 5, -11, 1, 5, -9 };

            var sunshineResult = challenge.Encode(sunshineStr);

            CollectionAssert.AreEqual(sunshineExpected, sunshineResult);
        }

        [TestMethod]
        public void Test_205_Decode()
        {
            // from the example we know the following strings and their encryptions: 
            //the array [72, 29, 7, 0, 3] should be decrypted to "Hello"
            //the array [72, 33, -73, 84, -12, -3, 13, -13, -68] should be decrypted to "Hi there!"
            //the array [83, 34, -7, 5, -11, 1, 5, -9] should be decrypted to "Sunshine"

            Challenge_205 challenge = new();

            var helloEncrypted = new[] { 72, 29, 7, 0, 3 };
            var helloExpected = "Hello";

            var helloResult = challenge.Decode(helloEncrypted);

            Assert.AreEqual(helloExpected, helloResult);


            var hiThereEncrypted = new[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 };
            var hiThereExpected = "Hi there!";

            var hiThereResult = challenge.Decode(hiThereEncrypted);

            Assert.AreEqual(hiThereExpected, hiThereResult);


            var sunshineEncrypted = new[] { 83, 34, -7, 5, -11, 1, 5, -9 };
            var sunshineExpected = "Sunshine";

            var sunshineResult = challenge.Decode(sunshineEncrypted);

            Assert.AreEqual(sunshineExpected, sunshineResult);
        }
        #endregion
    }
}
