using RevolutionaryGame.Enums;
using RevolutionaryGame.Model.Information;
using Xunit;

namespace RevolutionaryGame.Tests.Model.Information
{
    public class BoardTest
    {
        public Board board;

        public BoardTest()
        {
            board = new Board();
        }

        [Fact(DisplayName = "Given the parameters are valid when init is called then board is initialized")]
        public void Init_ParametersAreInitiated_SetsBoardCoordinates()
        {
            board.Init();
            Assert.NotNull(board.Coordinates);
        }

        [Fact(DisplayName = "Given the parameters are valid and the coord exist when the validation is hit then true value is returned")]
        public void IsInBoardArea_ParametersAreValidDirectionOnNorth_ReturnTrueValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 2,
                Y = 0,
            }, Directions.North);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        [Fact(DisplayName = "Given the parameters are valid and the coord exist and you want to head west when the validation is hit then true value is returned")]
        public void IsInBoardArea_ParametersAreValidDirectionOnWest_ReturnTrueValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 2,
                Y = 0,
            }, Directions.West);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        [Fact(DisplayName = "Given the parameters are valid and the coord exist and you want to head east when the validation is hit then true value is returned")]
        public void IsInBoardArea_ParametersAreValidDirectionOnEast_ReturnTrueValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 2,
                Y = 0,
            }, Directions.East);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        [Fact(DisplayName = "Given coords are out of the area and you want to head south  when the validation is hit then false value is returned")]
        public void IsInBoardArea_ParametersValidDirectionOnSouth_ReturnFalseValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 2,
                Y = 5,
            }, Directions.South);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        [Fact(DisplayName = "Given coords are out of the area and you want to head west  when the validation is hit then false value is returned")]
        public void IsInBoardArea_ParametersNotValidDirectionOnWest_ReturnFalseValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 0,
                Y = 1,
            }, Directions.West);

            Assert.IsType<bool>(result);
            Assert.False(result);
        }

        [Fact(DisplayName = "Given coords are out of the area and you want to head south  when the validation is hit then false value is returned")]
        public void IsInBoardArea_ParametersNotValidDirectionOnSouth_ReturnFalseValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 3,
                Y = 0,
            }, Directions.South);

            Assert.IsType<bool>(result);
            Assert.False(result);
        }

        [Fact(DisplayName = "Given coords are out of the area and you want to head east  when the validation is hit then false value is returned")]
        public void IsInBoardArea_ParametersNotValidDirectionOnEast_ReturnFalseValue()
        {
            var result = board.IsInBoardArea(new Position()
            {
                X = 5,
                Y = 0,
            }, Directions.East);

            Assert.IsType<bool>(result);
            Assert.False(result);
        }
    }
}
