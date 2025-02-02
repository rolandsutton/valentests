namespace valentest;

public class PathOfLove : IPathOfLove
{
    List<IValentineIngredient> _recipe = new List<IValentineIngredient>();
    private int _chanceOfSuccess;

    public void Reset()
    {
        _recipe.Clear();
        _chanceOfSuccess = 0;
    }

    public void AddIngredient(IValentineIngredient ingredient)
    {
        _recipe.Add(ingredient);
        _chanceOfSuccess += ingredient.Impact;
    }

    public int ChanceOfSuccess => _chanceOfSuccess;
}