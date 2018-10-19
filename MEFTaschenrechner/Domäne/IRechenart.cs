namespace Domäne
{
    public interface IRechenart
    {
        char Operator { get; }
        int Berechne(int z1, int z2);
    }
}
