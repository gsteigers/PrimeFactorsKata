using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactorsKata
{
    [TestClass]
    public class PrimeFactorsTests
    {
        private PrimeFactors primeFactors;
        [TestInitialize]
        public void Init()
        {
        }

        private bool verifyPrimes(List<int> expected, List<int> actual)
        {
            if (expected.Count > 0 && expected.Count == actual.Count)
            {
                var len = expected.Count;
                for (int i = 0; i < len; i++)
                {
                    if (expected[i] != actual[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        [TestMethod]
        public void Generating_prime_factors_of_1_should_result_in_an_empty_list()
        {
            primeFactors = new PrimeFactors();
            Assert.AreEqual(0, primeFactors.generatePrimeFactors(1).Count());
        }

        [TestMethod]
        public void Generating_prime_factors_of_2_should_result_in_the_number_2()
        {
            primeFactors = new PrimeFactors();
            var primes = primeFactors.generatePrimeFactors(2);
            Assert.AreEqual(1, primes.Count);
            Assert.AreEqual(2, primes[0]);
        }

        [TestMethod]
        public void Generating_prime_factors_of_3_should_result_in_the_number_3()
        {
            primeFactors = new PrimeFactors();
            var primes = primeFactors.generatePrimeFactors(3);
            Assert.AreEqual(1, primes.Count);
            Assert.AreEqual(3, primes[0]);
        }

        [TestMethod]
        public void Generating_prime_factors_of_4_should_result_in_the_numbers_2_and_2()
        {
            primeFactors = new PrimeFactors();
            var expected = new List<int> { 2, 2 };
            var primes = primeFactors.generatePrimeFactors(4);
            
            Assert.AreEqual(2, primes.Count());
            Assert.IsTrue(verifyPrimes(expected, primes));
        }

        [TestMethod]
        public void Generating_prime_factors_of_6_should_result_in_the_numbers_2_and_3()
        {
            primeFactors = new PrimeFactors();
            var expected = new List<int> { 2, 3 };
            var primes = primeFactors.generatePrimeFactors(6);

            Assert.AreEqual(2, primes.Count());
            Assert.IsTrue(verifyPrimes(expected, primes));
        }

        [TestMethod]
        public void Generating_prime_factors_of_8_should_result_in_the_numbers_2_2_2()
        {
            primeFactors = new PrimeFactors();
            var expected = new List<int> { 2, 2, 2 };
            var primes = primeFactors.generatePrimeFactors(8);

            Assert.AreEqual(3, primes.Count());
            Assert.IsTrue(verifyPrimes(expected, primes));
        }

        [TestMethod]
        public void Generating_prime_factors_of_9_should_result_in_the_numbers_3_3()
        {
            primeFactors = new PrimeFactors();
            var expected = new List<int> { 3, 3 };
            var primes = primeFactors.generatePrimeFactors(9);

            Assert.AreEqual(2, primes.Count());
            Assert.IsTrue(verifyPrimes(expected, primes));
        }

        //extra - just for fun
        [TestMethod]
        public void Generating_prime_factors_of_432()
        {
            primeFactors = new PrimeFactors();
            var expected = new List<int> { 2, 2, 2, 2, 3, 3, 3, 3 };
            var primes = primeFactors.generatePrimeFactors(1296);

            Assert.AreEqual(8, primes.Count());
            Assert.IsTrue(verifyPrimes(expected, primes));
        }

        [TestMethod]
        public void Generating_prime_factors_of_15825810()
        {
            primeFactors = new PrimeFactors();
            var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 31 };
            var primes = primeFactors.generatePrimeFactors(15825810);

            Assert.AreEqual(8, primes.Count());
            Assert.IsTrue(verifyPrimes(expected, primes));
        }
    }
}
