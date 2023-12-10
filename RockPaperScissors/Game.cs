using System.Text.RegularExpressions;

namespace RockPaperScissors
{
    public class Game
    {
        public List<(PlayerMoves, PlayerMoves)> winningScenarios = new(){

                (PlayerMoves.Rock, PlayerMoves.Scissors),
                (PlayerMoves.Scissors, PlayerMoves.Paper),
                (PlayerMoves.Paper, PlayerMoves.Rock)
            };
        public object Play(PlayerMoves PlayerMove, PlayerMoves opponetMove)
        {
            var scenario = (PlayerMove, opponetMove);


            if (winningScenarios.Contains(scenario))
                return Outcomes.PlayerWins;

           

            if (PlayerMove == opponetMove) return Outcomes.Tie;

            if (PlayerMove == PlayerMoves.Spock && opponetMove == PlayerMoves.Scissors)
                return Outcomes.smashes;
            if (PlayerMove == PlayerMoves.Paper && opponetMove == PlayerMoves.Spock)
                return Outcomes.disproves;
            if (PlayerMove == PlayerMoves.Rock && opponetMove == PlayerMoves.Lizard)
                return Outcomes.crushes;
            if (PlayerMove == PlayerMoves.Lizard && opponetMove == PlayerMoves.Spock)
                return Outcomes.poisons;
            if (PlayerMove == PlayerMoves.Scissors && opponetMove == PlayerMoves.Lizard)
                return Outcomes.decapitates;
            if (PlayerMove == PlayerMoves.Lizard && opponetMove == PlayerMoves.Paper)
                return Outcomes.eats;
            if (PlayerMove == PlayerMoves.Spock && opponetMove == PlayerMoves.Rock)
                return Outcomes.vaporizes;


            return Outcomes.PlayerLoses;
        }
    }

    public enum PlayerMoves
    {

        Paper,
        Rock,
        Scissors,
        Spock,
        Lizard
    }

    public enum Outcomes
    {

        PlayerLoses,
        PlayerWins,
        Tie,
        smashes,
        disproves,
        crushes,
        poisons,
        decapitates,
        eats,
        vaporizes
    }
}