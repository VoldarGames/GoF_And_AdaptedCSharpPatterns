namespace GoF_CSharp.Patterns.Strategy.GenericDynamicStrategy
{
    public interface IGenericStrategy<in T> 
    {
        string StrategyLabel { get; set; }
        void Execute(T entity);
    }

   
}