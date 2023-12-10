using NUnit.Framework;
using RockPaperScissors;

namespace RockPaperScissors_Test
{
    [TestFixture]
    public class GameTests
    {
        [TestFixture]
        public class Play
        {


/*            [TestFixture]
            public class PaperBeatsRock
            {

                [Test]

                public void GivenPlayerPaper_OpponetRock_ShouldReturnPlayerWins()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Paper, PlayerMoves.Rock);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerWins, actual);
                }

                [Test]

                public void GivenPlayerRock_OpponetPaper_ShouldReturnPlayerLoses()
                {
                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Rock, PlayerMoves.Paper);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerLoses, actual);
                }


            }




            [TestFixture]
            public class RockBeatsScissors
            {

                [Test]

                public void GivenPlayerRock_OpponetScissors_ShouldReturnPlayerLoses()
                {
                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Rock, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerWins, actual);
                }

                [Test]

                public void GivenPlayerScissors_OpponetRock_ShouldReturnPlayerLoses()
                {
                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Rock);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerLoses, actual);
                }


            }

            [TestFixture]
            public class ScissorsBeatsPaper
            {

                [Test]

                public void GivenPlayerScissors_OpponetPaper_ShouldReturnPlayerWins()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Paper);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerWins, actual);
                }


                [Test]

                public void GivenPlayerPaper_OpponetScissors_ShouldReturnPlayerLoses()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Paper, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerLoses, actual);
                }


            }


            [TestFixture]
            public class Tie
            {

                [Test]

                public void GivenPlayerScissors_OpponetScissors_ShouldReturnPlayerTie()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.Tie, actual);
                }


                [Test]

                public void GivenPlayerPaper_OpponetPaper_ShouldReturnPlayerTie()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.Tie, actual);
                }

                [Test]

                public void GivenPlayerRock_OpponetRock_ShouldReturnPlayerTie()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.Tie, actual);
                }


            }*/



            [TestFixture]
            public class SpockScissorsLizardRockPaper
            {

                [Test]
                public void GivenPlayerSpock_OpponetScissors_ShouldReturnSmashes()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Spock, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.Smashes, actual);
                }

                [Test]
                public void GivenPlayerPaper_OpponetSpock_ShouldReturnDisproves()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Paper, PlayerMoves.Spock);
                    //Assert
                    Assert.AreEqual(Outcomes.Disproves, actual);
                }


                [Test]
                public void GivenPlayerRock_OpponetLizard_ShouldReturnCrushes()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Rock, PlayerMoves.Lizard);
                    //Assert
                    Assert.AreEqual(Outcomes.Crushes, actual);
                }

                [Test]
                public void GivenPlayerLizard_OpponetSpock_ShouldReturnPoisons()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Lizard, PlayerMoves.Spock);
                    //Assert
                    Assert.AreEqual(Outcomes.Poisons, actual);
                }

                [Test]
                public void GivenPlayerScissors_OpponetLizard_ShouldReturnDescapitates()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Lizard);
                    //Assert
                    Assert.AreEqual(Outcomes.Decapitates, actual);
                }

                [Test]
                public void GivenPlayerLizard_OpponetPaper_ShouldReturnEats()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Lizard, PlayerMoves.Paper);
                    //Assert
                    Assert.AreEqual(Outcomes.Eats, actual);
                }

                [Test]
                public void GivenPlayerSpock_OpponetRock_ShouldReturnVaporizes()
                {

                    //Arrange
                    Game sut = CreateGame();

                    //Act
                    var actual = sut.Play(PlayerMoves.Spock, PlayerMoves.Rock);
                    //Assert
                    Assert.AreEqual(Outcomes.Vaporizes, actual);
                }



            }

        }
        private static Game CreateGame()
        {
            return new Game();
        }
    }


}