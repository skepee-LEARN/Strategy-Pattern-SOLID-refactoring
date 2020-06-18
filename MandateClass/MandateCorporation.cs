using Shared;
using System.Collections.Generic;

namespace MandateClass
{
    public class MandateCorporation 
    {
        public List<Portfolio> Portfolios { get; set; }

        public MandateCorporation(List<Portfolio> portfolios)
        {
            Portfolios = new List<Portfolio>();
            Portfolios.AddRange(portfolios);
        }

        public string RunKYCMandate(Portfolio portfolio)
        {
            string res = KYCMandate.Header(portfolio);
            res += KYCMandate.CorporationAddSection1();
            res += KYCMandate.CorporationAddSection2();
            return res;
        }
    }
}
