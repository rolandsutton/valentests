using NSubstitute;

namespace valentest.test.solution.integration;

public class LoveMachineTests
{
    private IIngredientProvider _ingredientProvider;
    private IPathOfLove _pathOfLove;
    private LoveMachine _loveMachine;

    [SetUp]
    public void Setup()
    {
        var possibilities = new List<IValentineIngredient>
        {
            new CandleLightDinner(),
            new Chocolate(),
            new Dancing(),
            new DeluxeMeal(),
            new FineWine(),
            new MoonLitNight(),
            new LovePoem(),
            new Oysters(), 
            new RomanticMusic(),
            new Roses(),
            new Stargazing(),
            new SendInvite(),
            new SmartClothes(),
            new WalkOnBeach(),
            new WittyConversation()
            
            
        }; 
        
        _ingredientProvider = new IngredientProvider(possibilities);
        _pathOfLove = new PathOfLove();
        _loveMachine = new LoveMachine(_ingredientProvider, _pathOfLove);
    }
    
    [Test]
    public void GivenIngredients_whenRunWithScenario_thenChanceOfSuccessIsGreaterThanZero()
    {
        // Act
        _loveMachine
            .WithIngredient("Send Invite")
            .WithIngredient("Candle Light Dinner")
            .WithIngredient("Fine Wine")
            .WithIngredient("Romantic Music")
            .WithIngredient("Walk On Beach")
            .WithIngredient("Witty Conversation")
            .WithIngredient("Stargazing")
            .Finish();
        
        // Assert
        Assert.That(_loveMachine.ChanceOfSuccess, Is.GreaterThan(0));
    }
}