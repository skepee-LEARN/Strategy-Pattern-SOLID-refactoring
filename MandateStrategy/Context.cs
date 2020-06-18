using Shared;

namespace MandateStrategy
{
    public class Context
    {
        IMandate _mandate;

        public Context(IMandate mandate)
        {
            this._mandate = mandate;
        }

        public string ContextInterface(Portfolio portfolio)
        {
            return _mandate.RunKYCMandate(portfolio);
        }


    }
}
