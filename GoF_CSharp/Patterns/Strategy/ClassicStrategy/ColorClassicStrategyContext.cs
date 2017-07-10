using Domain;

namespace GoF_CSharp.Patterns.Strategy.ClassicStrategy
{
    public class ColorClassicStrategyContext
    {
        private readonly IColorClassicStrategy _context;
        private readonly Color _color;

        public ColorClassicStrategyContext(IColorClassicStrategy context, Color color)
        {
            _context = context;
            _color = color;
        }

        public string DefineStrategy()
        {
            return _context.Execute(_color);
        }
    }
}