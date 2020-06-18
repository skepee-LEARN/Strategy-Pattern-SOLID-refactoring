using Shared;
using System.Collections.Generic;

namespace MandateClass
{
    public class MandatePrivateJoint
    {
        public List<Portfolio> Portfolios { get; set; }

        public MandatePrivateJoint(List<Portfolio> portfolios)
        {
            Portfolios = new List<Portfolio>();
            Portfolios.AddRange(portfolios);
        }

        public string RunKYCMandate(Portfolio portfolio)
        {
            string res = KYCMandate.Header(portfolio);
            res += KYCMandate.PrivateJointAddSection1();
            res += KYCMandate.PrivateJointAddSection2();
            return res;
        }

    }
}
