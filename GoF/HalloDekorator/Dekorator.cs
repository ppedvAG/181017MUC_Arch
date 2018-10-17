namespace HalloDekorator
{
    abstract class Dekorator : IComponent
    {
        public Dekorator(IComponent parent)
        {
            this.parent = parent;
        }
        protected IComponent parent;

        public abstract string Text { get; }
        public abstract decimal Preis { get; }
    }
}
