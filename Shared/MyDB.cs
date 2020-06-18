using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class MyDB
    {
        public List<Portfolio> portfolios { get; set; }

        public MyDB()
        {
            portfolios = new List<Portfolio>();

            portfolios.Add(new Portfolio
            {
                Company="Company X",
                Currency="EUR",
                Id=1,
                MandateType=MandateTypes.Corporation,
                Name="Portofolio a"
            });

            portfolios.Add(new Portfolio
            {
                Company = "Company X",
                Currency = "GBP",
                Id = 2,
                MandateType = MandateTypes.PrivateJoint,
                Name = "Portofolio b"
            });
        }

    }
}
