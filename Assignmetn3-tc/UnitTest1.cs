using System;
using Xunit;
using C_Assignment3;
namespace Assignmetn3_tc
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            C_Assignment3.Math objMath1 = new C_Assignment3.Math(1,2,3);
            float result1 = objMath1.CalculatePerimeter(1,2,3);
            Assert.IsType<float>(result1);
            Assert.Equal(6,result1);

        }
        [Fact]
        public void Test2()
        {
            C_Assignment3.Math objMath2 = new C_Assignment3.Math(2,3);
            float result2 =objMath2.CalculatePerimeter(2,3);
            Assert.IsType<float>(result2);
            Assert.Equal(10,result2);

        }
        [Fact]
        public void Test3()
        {
            C_Assignment3.Math objMath3 = new C_Assignment3.Math(1);
            float result3 = objMath3.CalculatePerimeter(1);
            Assert.IsType<float>(result3);
            Assert.Equal(4,result3);

        }
    }
}
