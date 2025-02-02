namespace valentest;

public class IngredientProvider : IIngredientProvider
{
    private readonly List<IValentineIngredient> _ingredients;

    public IngredientProvider(IEnumerable<IValentineIngredient> ingredients)
    {
        _ingredients = [ .. ingredients];
    }
    public IValentineIngredient GetIngredient(string name)
    {
        return _ingredients.FirstOrDefault(i => i.Name == name);
    }
}