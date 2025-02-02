namespace valentest;

public class LoveMachine : ILoveMachine
{
    private readonly IIngredientProvider _ingredientProvider;
    private List<IValentineIngredient> _ingredients;
    private readonly IPathOfLove _pathOfLove;

    public LoveMachine(IIngredientProvider ingredientProvider,
        IPathOfLove pathOfLove)
    {
        _ingredientProvider = ingredientProvider;
        _ingredients = new List<IValentineIngredient>();
        _pathOfLove = pathOfLove;
    }
    
    public IDateBuilder WithIngredient(string name)
    {
        var ingredient = _ingredientProvider.GetIngredient(name);
        if (ingredient != null)
        {
            _ingredients.Add(ingredient);
        }
        
        return this;
    }

    public void Finish()
    {
        _pathOfLove.Reset();
        foreach (var ingredient in _ingredients)
        {
            ingredient.ApplyTo(_pathOfLove);
        }
        
    }

    public int ChanceOfSuccess => _pathOfLove.ChanceOfSuccess;
}