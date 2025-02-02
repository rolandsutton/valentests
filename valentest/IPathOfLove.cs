namespace valentest;

public interface IPathOfLove
{
    void Reset();
    void AddIngredient(IValentineIngredient ingredient);
    int ChanceOfSuccess { get; }
}