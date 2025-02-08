namespace valentest;

public interface ISuccessotron
{
    void Reset();
    void AddImpact(int impact);
    
    int ChanceOfSuccess {get;}
}