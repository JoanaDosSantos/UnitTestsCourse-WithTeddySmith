namespace UnitTestsCourse.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        //Pay attentions to naming conventions - ClassName_Method_ExpectedResult
        //Tests don't return anything, so they're always void
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString()
        {
            try
            {
                //Arrange - Go get your variables, classes, functions, whatever you need
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - Execute this function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                //Assert - Whatever ever is returned is it whats you want 
                if(result == "PIKACHU!") 
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
    }
}
