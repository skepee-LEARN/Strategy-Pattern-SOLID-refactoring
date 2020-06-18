namespace Shared
{
    public enum MandateTypes
    {
        PrivateJoint,
        Corporation
    }

    public static class KYCMandate
    {
        public static string Header(Portfolio SelectedPortfolio)
        {
            string content = "";
            content += $"ID: {SelectedPortfolio.Id} \n";
            content += $"Name: {SelectedPortfolio.Name} \n";
            content += $"Company: {SelectedPortfolio.Company} \n";
            content += $"Currency: {SelectedPortfolio.Currency} \n";
            content += $"Mandate type: {SelectedPortfolio.MandateType} \n";
            return content;
        }

        public static string CorporationAddSection1()
        {
            string content = "";
            content += "------------------------------" + "\n";
            content += "Section 1 for mandate type Corporate" + "\n";
            content += "------------------------------" + "\n";
            return content;
        }

        public static string PrivateJointAddSection1()
        {
            string content = "";
            content += "------------------------------" + "\n";
            content += "Section 1 for mandate type Private (Joint)" + "\n";
            content += "------------------------------" + "\n";
            return content;
        }


        public static string CorporationAddSection2()
        {
            string content = "";
            content += "*******************************" + "\n";
            content += "Section 2 for mandate type Corporate" + "\n";
            content += "*******************************" + "\n";
            return content;
        }

        public static string PrivateJointAddSection2()
        {
            string content = "";
            content += "*******************************" + "\n";
            content += "Section 2 for mandate type Private (Joint)" + "\n";
            content += "*******************************" + "\n";
            return content;
        }


    }
}
