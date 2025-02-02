namespace valentest;

public class SendInvite : ValentineIngredientBase
{
    public override string Name =>"Send Invite";
    public override int Impact => 5;
    public override void ApplyTo(IPathOfLove pathOfLove)
    {
        pathOfLove.AddIngredient(this);
    }
}