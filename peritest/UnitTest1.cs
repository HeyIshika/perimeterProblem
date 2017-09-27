using System;
using Xunit;
using Perimeter;

namespace peritest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            //Arrange
            math obj1=new math(12,13,15);
            math obj2=new math(12,13);
            math obj3=new math(12);

            //Act
            var result1=obj1.CalculatePerimeter(12,13,15);
            var result2=obj1.CalculatePerimeter(12,13);
            var result3=obj1.CalculatePerimeter(12);

            //Assert
            Assert.IsType<int>(result1);
            Assert.Equal(40,result1);


            Assert.IsType<int>(result1);
            Assert.Equal(50,result2);


            Assert.IsType<int>(result1);
            Assert.Equal(48,result3);

        }
    }
}
