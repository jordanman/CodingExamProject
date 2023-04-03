using Xunit;

namespace ExamProProject.Tests
{
    public class TestValidAngleBrackets
    {
        [Fact]
        public bool Return_True_When_Data_IsValid_With_Matching_OpenCloseBracket()
        {
            //Arrange
            var input = "<>";

            //Act
            var result = DataValidator.IsMatchAngleBrackets(input);

            //Assert
            return true == result;
        }

        [Fact]
        public bool Return_False_When_Data_IsInvalid_Without_Matching_OpenAndCloseBracket()
        {
            //Arrange
            var input = "><";

            //Act
            var result = DataValidator.IsMatchAngleBrackets(input);

            //Assert
            return false == result;
        }

        [Fact]
        public bool Return_False_When_Data_IsInvalid_One_Bracket_Was_Not_Closed()
        {
            //Arrange
            var input = "<<>";

            //Act
            var result = DataValidator.IsMatchAngleBrackets(input);

            //Assert
            return false == result;
        }


        [Fact]
        public bool Return_True_When_Data_IsValid_No_Brackets_At_All()
        {
            //Arrange
            var input = "";

            //Act
            var result = DataValidator.IsMatchAngleBrackets(input);

            //Assert
            return true == result;
        }

        [Fact]
        public bool Return_True_When_Data_IsValid_And_None_Bracket_Characters_Ignored()
        {
            //Arrange
            var input = "<abc...xyz>";

            //Act
            var result = DataValidator.IsMatchAngleBrackets(input);

            //Assert
            return true == result;
        }
    }
}
