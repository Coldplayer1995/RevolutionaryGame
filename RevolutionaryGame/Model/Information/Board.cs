using RevolutionaryGame.Enums;
using System.Collections.Generic;

namespace RevolutionaryGame.Model.Information
{
    public class Board
    {
        public ICollection<Coordinates> Coordinates { get; set; }
        private readonly int XMax = 5;
        private readonly int YMax = 5;

        public Board()
        {
            Coordinates = new List<Coordinates>();
        }

        public void Init()
        {
            for (int x = 0; x < XMax; x++)
            {
                for (int y = 0; y < YMax; y++)
                {
                    Coordinates.Add(new Coordinates()
                    {
                        X = x,
                        Y = y
                    });
                }
            }
        }

        public bool IsInBoardArea(Position currentPosition, Directions currentDirection)
        {
            switch (currentDirection)
            {
                case Directions.South:
                    if (currentPosition.Y-- > 0) return true;
                    return false;
                case Directions.North:
                    if (currentPosition.Y-- < YMax) return true;
                    return false;
                case Directions.East:
                    if (currentPosition.X-- < XMax) return true;
                    return false;
                case Directions.West:
                    if (currentPosition.X-- > 0) return true;
                    return false;
                default:
                     return false;
            }
        }

    }
}
