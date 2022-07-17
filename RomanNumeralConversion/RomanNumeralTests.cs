namespace RomanNumeralConversion
{
    public class RomanNumeralTests
    {
        [Fact]
        public void Should_convert_1_to_I()
        {
            var expectedOutput = "I";
            var input = 1;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_3_to_III()
        {
            var expectedOutput = "III";
            var input = 3;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_4_to_IV()
        {
            var expectedOutput = "IV";
            var input = 4;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_5_to_V()
        {
            var expectedOutput = "V";
            var input = 5;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_7_to_VII()
        {
            var expectedOutput = "VII";
            var input = 7;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_9_to_IV()
        {
            var expectedOutput = "IX";
            var input = 9;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_10_to_X()
        {
            var expectedOutput = "X";
            var input = 10;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_12_to_XII()
        {
            var expectedOutput = "XII";
            var input = 12;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_15_to_XV()
        {
            var expectedOutput = "XV";
            var input = 15;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_17_to_XV()
        {
            var expectedOutput = "XVII";
            var input = 17;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_19_to_XIX()
        {
            var expectedOutput = "XIX";
            var input = 19;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_20_to_XX()
        {
            var expectedOutput = "XX";
            var input = 20;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_23_to_XXIII()
        {
            var expectedOutput = "XXIII";
            var input = 23;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_25_to_XXIII()
        {
            var expectedOutput = "XXV";
            var input = 25;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_26_to_XXVI()
        {
            var expectedOutput = "XXVI";
            var input = 26;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_29_to_XXIX()
        {
            var expectedOutput = "XXIX";
            var input = 29;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_30_to_XXX()
        {
            var expectedOutput = "XXX";
            var input = 30;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_40_to_XL()
        {
            var expectedOutput = "XL";
            var input = 40;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_46_to_XLVI()
        {
            var expectedOutput = "XLVI";
            var input = 46;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_50_to_L()
        {
            var expectedOutput = "L";
            var input = 50;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_67_to_LXVII()
        {
            var expectedOutput = "LXVII";
            var input = 67;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_90_to_XC()
        {
            var expectedOutput = "XC";
            var input = 90;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_99_to_XCIX()
        {
            var expectedOutput = "XCIX";
            var input = 99;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_100_to_C()
        {
            var expectedOutput = "C";
            var input = 100;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_110_to_CX()
        {
            var expectedOutput = "CX";
            var input = 110;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_200_to_CC()
        {
            var expectedOutput = "CC";
            var input = 200;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_246_to_CCXLVI()
        {
            var expectedOutput = "CCXLVI";
            var input = 246;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_284_to_CCXLVI()
        {
            var expectedOutput = "CCLXXXIV";
            var input = 284;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_500_to_D()
        {
            var expectedOutput = "D";
            var input = 500;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_650_to_DCL()
        {
            var expectedOutput = "DCL";
            var input = 650;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_1000_to_M()
        {
            var expectedOutput = "M";
            var input = 1000;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_2956_to_MMCMLVI()
        {
            var expectedOutput = "MMCMLVI";
            var input = 2956;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Should_convert_3999_to_MMMCMXCIX()
        {
            var expectedOutput = "MMMCMXCIX";
            var input = 3999;
            var output = input.ConvertToRomanNumeral();

            Assert.Equal(expectedOutput, output);
        }
    }
}