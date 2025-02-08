namespace valentest;

public class PathOfLove : IPathOfLove
{
    List<IValentineIngredient> _recipe = new List<IValentineIngredient>();
    private readonly ISuccessotron _successotron;

    public PathOfLove(ISuccessotron successotron)
    {
        _successotron = successotron;
    }

    public void Reset()
    {
        _recipe.Clear();
        _successotron.Reset();
    }

    public void AddIngredient(IValentineIngredient ingredient)
    {
        _recipe.Add(ingredient);
        _successotron.AddImpact(ingredient.Impact);
    }

    public int ChanceOfSuccess => _successotron.ChanceOfSuccess;
}