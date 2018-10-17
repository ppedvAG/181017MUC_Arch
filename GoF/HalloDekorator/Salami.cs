namespace HalloDekorator
{
    class Salami : Dekorator
    {
        public Salami(IComponent parent) : base(parent)
        {
        }

        public override string Text => parent.Text + " Salami";
        public override decimal Preis => 1.5m + parent.Preis;
    }
}
