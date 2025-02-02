namespace valentest;

public abstract class ValentineIngredientBase: IValentineIngredient
{
    public abstract string Name { get; }
    public abstract int Impact { get; }
    public virtual void ApplyTo(IPathOfLove pathOfLove)
    {
        if(pathOfLove.ChanceOfSuccess> 0)
        {
            pathOfLove.AddIngredient(this);
        }
    }
}