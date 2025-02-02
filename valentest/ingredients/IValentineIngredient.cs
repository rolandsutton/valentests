namespace valentest;

public interface IValentineIngredient
{
    string Name { get; }
    int Impact { get; }
    void ApplyTo(IPathOfLove pathOfLove);
}