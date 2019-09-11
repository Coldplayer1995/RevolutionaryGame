using RevolutionaryGame.Model.Information;

namespace RevolutionaryGame.Service
{
    public class ControlPieceService : IControlPieceService
    {
        private readonly Piece _piece;

        public ControlPieceService()
        {
            _piece = new Piece();
        }

        public void MoveLeft()
        {
            _piece.TurnLeft();
        }

        public void MoveRight()
        {
            _piece.TurnRight();
        }

        public void MoveForward()
        {
            _piece.MoveForward();
        }
    }
}
