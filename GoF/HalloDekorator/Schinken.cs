namespace HalloDekorator
{
    class Schinken : Dekorator
    {
        public Schinken(IComponent parent) : base(parent)
        {
        }

        public override string Text => parent.Text + " Schinken";
        public override decimal Preis => 0.33m + parent.Preis;
    }
}
