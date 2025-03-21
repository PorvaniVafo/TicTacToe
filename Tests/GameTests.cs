using NUnit.Framework;

namespace TicTacToe.Tests
{
    public class GameTests
    {
        [Test]
        public void CheckWinner_PlayerXWinsHorizontally_ReturnsTrue()
        {
            Game game = new Game();
            game.TestSetBoard(new char[,] { { 'X', 'X', 'X' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } });
            Assert.IsTrue(game.TestCheckWinner());
        }

        [Test]
        public void CheckWinner_NoWinner_ReturnsFalse()
        {
            Game game = new Game();
            game.TestSetBoard(new char[,] { { 'X', 'O', 'X' }, { 'O', 'X', 'O' }, { 'O', 'X', 'O' } });
            Assert.IsFalse(game.TestCheckWinner());
        }

        [Test]
        public void IsBoardFull_FullBoard_ReturnsTrue()
        {
            Game game = new Game();
            game.TestSetBoard(new char[,] { { 'X', 'O', 'X' }, { 'O', 'X', 'O' }, { 'O', 'X', 'O' } });
            Assert.IsTrue(game.TestIsBoardFull());
        }
    }
}
