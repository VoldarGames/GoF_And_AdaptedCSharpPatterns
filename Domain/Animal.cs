namespace Domain
{
    public abstract class Animal : EntityBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public abstract string DoSound();
    }
}