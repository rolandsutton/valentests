using NSubstitute;

namespace valentest.test.solution.unit;

public class LoveMachineTests
{
    private IIngredientProvider _ingredientProvider;
    private IPathOfLove _pathOfLove;
    private LoveMachine _loveMachine;

    [SetUp]
    public void Setup()
    {
        _ingredientProvider = Substitute.For<IIngredientProvider>();
        _pathOfLove = Substitute.For<IPathOfLove>();
        _loveMachine = new LoveMachine(_ingredientProvider, _pathOfLove);
    }
    
    [Test]
    public void Test1()
    {
        // Arrange
        
        // Act
        _loveMachine.WithIngredient("Deluxe Meal");
        _loveMachine.Finish();
        
        // Assert
        _ingredientProvider.Received(1).GetIngredient("Deluxe Meal");
        _pathOfLove.Received(1).Reset();
        _pathOfLove.Received(1).AddIngredient(Arg.Any<IValentineIngredient>());
    }
}