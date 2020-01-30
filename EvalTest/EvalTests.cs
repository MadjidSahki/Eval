using Eval;
using System;
using Xunit;

namespace EvalTest
{
    public class EvalTests
    {
        [Theory]
        [InlineData("abcadabdfad", "abcdf")]
        [InlineData("zddzuiizix", "zduix")]
        public void TestExo1(string str1, string str2)
        {
            Assert.Equal(EvalAlgo.Exo1(str1), str2);
        }



        [Fact]
        public void TestExo2()
        {
            //Arrange
            int[] arrange1 = new int[] { 4 };
            int[] arrange2 = new int[] { 5, 2, 14, 2, -8, 5, 2, 8, 2, 2, 7, 2, 2 };
            int[] arrange3 = new int[] { 5, 2, 14, 2, -8, 5, 2, 8, 2, 2, 7, 2, 2, 1 };

            //Act
            var act1 = EvalAlgo.Exo2(arrange1);
            var act2 = EvalAlgo.Exo2(arrange2);
            var act3 = EvalAlgo.Exo2(arrange3);

            //Assert
            Assert.Equal(4, act1);
            Assert.Equal(2, act2);
            Assert.Null(act3);

        }


        [Theory]
        [InlineData(new int[] {4}, new int[] {4}, 8)]
        [InlineData(new int[] { 15, 4, 32, 7, 1 }, new int[] { 4, 7, 1, 32, 15 }, 8)]
        [InlineData(new int[] { 15, 4, 32, 7, 1 }, new int[] { 4, 1, 7, 15, 32 }, 6)]


        public void TestExo3(int[] intArray, int[] intArrayOutput, int nb)
        {
            EvalAlgo.Exo3(intArray, nb);
            Assert.Equal(intArray, intArrayOutput);
        }



    }
}
