using Shared;

namespace MandateStrategy
{
    public class MandatePrivateJoint:IMandate
    {
        public string RunKYCMandate(Portfolio portfolio)
        {
            string res = KYCMandate.Header(portfolio);
            res += KYCMandate.PrivateJointAddSection1();
            res += KYCMandate.PrivateJointAddSection2();
            return res;
        }

    }
}
