using System;
using System.Linq;

namespace GoF_CSharp.Patterns.Strategy.GenericDynamicStrategy
{
    public static class GenericDynamicLabeledStrategyHandler<T> 
    {
        /// <summary>
        /// Executes the labeled selected Strategy,
        ///  if label is null executes first,
        ///  if label doesnt exist it does nothing
        ///  if any strategy of Type T exists throws StrategyNotFoundException
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="strategyLabel"></param>
        /// <exception cref="StrategyNotFoundException"></exception>
        public static void Handle(T entity, string strategyLabel = null)
        {
            var assembly = typeof(GenericDynamicLabeledStrategyHandler<>).Assembly;
            var strategies = assembly.DefinedTypes.Where(info => info.IsClass && typeof(IGenericStrategy<T>).IsAssignableFrom(info)).ToList();

            if (!strategies.Any()) throw new StrategyNotFoundException();

            if (string.IsNullOrEmpty(strategyLabel))
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                ((IGenericStrategy<T>) Activator.CreateInstance(strategies.FirstOrDefault())).Execute(entity);
                return;
            }

            foreach (var strategy in strategies)
            {
                var strategyInstance = (IGenericStrategy<T>)Activator.CreateInstance(strategy);
                if(strategyLabel.Equals(strategyInstance.StrategyLabel)) strategyInstance.Execute(entity);
            }
        }
      
    }

    public class StrategyNotFoundException : Exception{}
}