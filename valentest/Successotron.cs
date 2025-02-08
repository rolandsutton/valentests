namespace valentest;

public class Successotron : ISuccessotron
{
    private readonly List<IValentineIngredient> _possibilities;
    private double _cumulativeSuccess;
    private int _maxImpact;

    public Successotron(List<IValentineIngredient> possibilities)
    {
        _possibilities = possibilities;
    }

    public void Reset()
    {
        _cumulativeSuccess = 0;
        _maxImpact = _possibilities.Sum(m => m.Impact);
    }

    public void AddImpact(int impact)
    {
        _cumulativeSuccess += impact;
    }

    public int ChanceOfSuccess => (int)((_cumulativeSuccess*100)/_maxImpact);
}