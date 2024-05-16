using DependencyInjection;

namespace DependencyInjectionTest2
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void RockBeatsScissors()
        {
            GameManager gm = new GameManager(new TestPlayer(Choice.Rock), new TestPlayer(Choice.Scissors));

            Assert.AreEqual(RoundResult.Player1Wins, gm.PlayRound());
       }
    }
}