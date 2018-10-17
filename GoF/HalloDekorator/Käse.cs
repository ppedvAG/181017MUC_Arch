namespace HalloDekorator
{
    // Dekoratoren:

    class Käse : Dekorator
    {
        public Käse(IComponent parent) : base(parent)
        {
        }

        public override string Text => parent.Text + " Käse";
        public override decimal Preis => 0.5m + parent.Preis;
    }
}
