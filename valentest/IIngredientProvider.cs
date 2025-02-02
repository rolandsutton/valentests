namespace valentest;

public interface IIngredientProvider
{
    IValentineIngredient GetIngredient(string name);
}