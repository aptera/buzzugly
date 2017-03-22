namespace sustainable
{
    using NUnit.Framework;

    [TestFixture]
    public class The_fizz_buzz_player
    {
        FizzBuzzPlayer _player;

        [TestCase(1, ExpectedResult = "1", TestName = "given 1, returns 1")]
        [TestCase(2, ExpectedResult = "2", TestName = "given 2, returns 2")]
        [TestCase(3, ExpectedResult = "fizz", TestName = "given 3, returns fizz")]
        [TestCase(5, ExpectedResult = "buzz", TestName = "given 5, returns buzz")]
        [TestCase(9, ExpectedResult = "fizz", TestName = "given 9, returns fizz")]
        [TestCase(10, ExpectedResult = "buzz", TestName = "given 10, returns buzz")]
        [TestCase(15, ExpectedResult = "fizzbuzz", TestName = "given 15, returns fizzbuzz")]
        [TestCase(90, ExpectedResult = "fizzbuzz", TestName = "given 90, returns fizzbuzz")]
        public string play(int i)
        {
            Arrange();
            return _player.Play(i);
        }

        void Arrange()
        {
            _player = new FizzBuzzPlayer();
        }
    }
}
