using LoggingKata.Classes;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth...", -84.683302)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth...", -84.575512)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.22997,-86.805275,Taco Bell Alabaste...", -86.805275)]
        [InlineData("31.570771,-84.10353,Taco Bell Albany...", -84.10353)]
        [InlineData("31.597099,-84.176122,Taco Bell Albany...", -84.176122)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]          
        [InlineData("34.071477,-84.296345,Taco Bell Alpharett...", -84.296345)]
        [InlineData("34.047374,-84.223918,Taco Bell Alpharetta...", -84.223918)]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta...", -84.283254)]
        [InlineData("32.072974,-84.222921,Taco Bell Americu...", -84.222921)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto...", -85.826674)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", -86.503055)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...", -86.841402)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", -86.97191)]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...", -86.079099)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", -85.499655)]
        [InlineData("32.609135,-85.479907,Taco Bell Auburn...", -85.479907)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel...", -84.60189)]
        
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO:
            // Complete the test with Arrange, Act, Assert steps below.
            // Note: "line" string represents input data we will Parse 
            // to extract the Longitude.  
            // Each "line" from your .csv file
            // represents a TacoBell location

            //Arrange
              var tacoParser = new TacoParser();

            //Act
              var actual = tacoParser.Parse(line).Location.Longitude;
            
            //Assert
              Assert.Equal(expected, actual);
        }


        // TODO:
        // Create a test called ShouldParseLatitude
        
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth...", 34.035985)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth...", 34.087508)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", 34.376395)]
        [InlineData("33.22997,-86.805275,Taco Bell Alabaste...", 33.22997)]
        [InlineData("31.570771,-84.10353,Taco Bell Albany...", 31.570771)]
        [InlineData("31.597099,-84.176122,Taco Bell Albany...", 31.597099)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("34.071477,-84.296345,Taco Bell Alpharett...", 34.071477)]
        [InlineData("34.047374,-84.223918,Taco Bell Alpharetta...", 34.047374)]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta...", 34.039588)]
        [InlineData("32.072974,-84.222921,Taco Bell Americu...", 32.072974)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto...", 33.671982)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", 34.324462)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...", 34.992219)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", 34.795116)]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...", 34.018008)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", 32.571331)]
        [InlineData("32.609135,-85.479907,Taco Bell Auburn...", 32.609135)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel...", 33.858498)]

        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO:
            // Complete the test with Arrange, Act, Assert steps below.
            // Note: "line" string represents input data we will Parse 
            // to extract the Longitude.  
            // Each "line" from your .csv file
            // represents a TacoBell location

            //Arrange
              var tacoParser = new TacoParser();
            
              //Act
              var actual = tacoParser.Parse(line).Location.Latitude;
            
              //Assert
              Assert.Equal(expected, actual);
        }

    }
}
