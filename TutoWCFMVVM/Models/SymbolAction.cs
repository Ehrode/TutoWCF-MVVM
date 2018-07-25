namespace TutoWCFMVVM.Models
{
    public class SymbolAction
    {
        public string Symbol { get; set; }
        public string ActionName { get; set; }

        public SymbolAction(string symbol, string actionName)
        {
            Symbol = symbol;
            ActionName = actionName;
        }
    }
}
