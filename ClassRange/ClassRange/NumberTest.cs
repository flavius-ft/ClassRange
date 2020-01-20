﻿using Xunit;

namespace ClassRange
{
    public class NumberTest
    {
        [Fact]
        public void VerifyJsonNUmbersReturningRemainingText()
        {
            var number = new Number();

            Assert.Equal(" ab", number.Match("123 ab").RemainingText());
        }

        [Fact]
        public void CheckNegativeSimpleNumber()
        {
            var number = new Number();

            Assert.Equal("", number.Match("-123").RemainingText());
        }

        [Fact]
        public void UseNumberClassOnExponentNumberWithZecimalNumber()
        {
            var number = new Number();

            Assert.Equal("", number.Match("-12.33e+2").RemainingText());
        }

        [Fact]
        public void UseNumberClassOnSimpleExponentNumber()
        {
            var number = new Number();

            Assert.Equal("", number.Match("12e2").RemainingText());
        }
    }
}
