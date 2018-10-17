namespace HalloDekorator
{
    //Root-Element
    class Pizza : IComponent
    {
        public string Text => "Pizza";

        public decimal Preis => 4.99m;
    }
}
