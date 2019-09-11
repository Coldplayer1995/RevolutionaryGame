using RevolutionaryGame.Enums;

namespace RevolutionaryGame.Model.Information
{
    public class Piece
    {
        private Position _currentPossition { get; set; }
        private Directions _currentDirection { get; set; }
        private Board _board { get; set; }

        public Piece()
        {
            _currentPossition = new Position()
            {
                X = 0,
                Y = 0
            };
            _board = new Board();

            _currentDirection = Directions.North;
        }

        public void MoveForward()
        {
            switch (_currentDirection)
            {
                case Directions.South:
                    if (_board.IsInBoardArea(_currentPossition, _currentDirection)) _currentPossition.Y--;
                    break;
                case Directions.North:
                    if (_board.IsInBoardArea(_currentPossition, _currentDirection)) _currentPossition.Y++;
                    break;
                case Directions.East:
                    if (_board.IsInBoardArea(_currentPossition, _currentDirection)) _currentPossition.X++;
                    break;
                case Directions.West:
                    if (_board.IsInBoardArea(_currentPossition, _currentDirection)) _currentPossition.X--; ;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (_currentDirection)
            {
                case Directions.South:
                    _currentDirection = Directions.East;
                    break;
                case Directions.North:
                    _currentDirection = Directions.West;
                    break;
                case Directions.East:
                    _currentDirection = Directions.North;
                    break;
                case Directions.West:
                    _currentDirection = Directions.South;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (_currentDirection)
            {
                case Directions.South:
                    _currentDirection = Directions.West;
                    break;
                case Directions.North:
                    _currentDirection = Directions.East;
                    break;
                case Directions.East:
                    _currentDirection = Directions.South;
                    break;
                case Directions.West:
                    _currentDirection = Directions.North;
                    break;
                default:
                    break;
            }
        }

    }
}
