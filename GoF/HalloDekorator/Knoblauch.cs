namespace HalloDekorator
{
    class Knoblauch : Dekorator
    {
        public Knoblauch(IComponent parent) : base(parent)
        {
        }

        public override string Text => parent.Text + " Knoblauch";
        public override decimal Preis => 5m + parent.Preis;
    }
}
