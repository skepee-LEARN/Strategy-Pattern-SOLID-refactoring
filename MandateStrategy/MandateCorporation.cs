using Shared;

namespace MandateStrategy
{
    public class MandateCorporation:IMandate
    {
        public string RunKYCMandate(Portfolio portfolio)
        {
            string res = KYCMandate.Header(portfolio);
            res += KYCMandate.CorporationAddSection1();
            res += KYCMandate.CorporationAddSection2();
            return res;
        }
    }
}
