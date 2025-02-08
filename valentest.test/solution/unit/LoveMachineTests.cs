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
    public void GivenUnknownIngredient_WhenWithIngredient_ThenNothing()
    {
        // Arrange
        _ingredientProvider.GetIngredient("Deluxe Meal").Returns((IValentineIngredient)null);
        
        // Act
        _loveMachine.WithIngredient("Deluxe Meal");
        _loveMachine.Finish();
        
        // Assert
        _ingredientProvider.Received(1).GetIngredient("Deluxe Meal");
        _pathOfLove.Received(1).Reset();
    }
    
    [Test]
    public void GivenSimpleIngredient_WhenWithIngredient()
    {
        // Arrange
        var ingredient = Substitute.For<IValentineIngredient>();
        _ingredientProvider.GetIngredient("Deluxe Meal").Returns(ingredient);
        
        // Act
        _loveMachine.WithIngredient("Deluxe Meal");
        _loveMachine.Finish();
        
        // Assert
        _ingredientProvider.Received(1).GetIngredient("Deluxe Meal");
        _pathOfLove.Received(1).Reset();
        ingredient.Received(1).ApplyTo(_pathOfLove);
    }
}