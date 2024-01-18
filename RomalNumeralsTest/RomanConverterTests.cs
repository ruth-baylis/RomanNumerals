namespace RomalNumeralsTest
{
    public class RomanConverterTests
    {
        RomanConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new RomanConverter();
        }

        [Test]
        public void Large_Input_Throws_ArgumentOutOfRangeException()
        {
            var input = 2001;

            Assert.Throws<ArgumentOutOfRangeException>(() => _converter.FromInteger(input));
        }

        [Test]
        public void Zero_Input_Throws_ArgumentOutOfRangeException()
        {
            var input = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => _converter.FromInteger(input));
        }

        [Test]
        public void Negative_Input_Throws_ArgumentOutOfRangeException()
        {
            var input = -5;

            Assert.Throws<ArgumentOutOfRangeException>(() => _converter.FromInteger(input));
        }

        [Test]
        public void Input_42_Is_Correctly_Converted()
        {
            var input = 42;

            var result = _converter.FromInteger(input);

            Assert.That(result, Is.EqualTo("XLII"));
        }

        [Test]
        public void Input_1_Is_Correctly_Converted()
        {
            var input = 1;

            var result = _converter.FromInteger(input);

            Assert.That(result, Is.EqualTo("I"));
        }

        [Test]
        public void Input_2000_Correctly_Converted()
        {
            var input = 2000;

            var result = _converter.FromInteger(input);

            Assert.That(result, Is.EqualTo("MM"));
        }

        [Test]
        public void Input_492_Correctly_Converted()
        {
            var input = 492;

            var result = _converter.FromInteger(input);

            Assert.That(result, Is.EqualTo("CDXCII"));
        }

        [Test]
        public void Input_63_Correctly_Converted()
        {
            var input = 63;

            var result = _converter.FromInteger(input);

            Assert.That(result, Is.EqualTo("LXIII"));
        }
    }
}