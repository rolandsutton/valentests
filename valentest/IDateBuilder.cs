namespace valentest;

public interface IDateBuilder
{
    IDateBuilder WithIngredient(string ingredient);
    void Finish();
}