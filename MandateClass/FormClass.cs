using MandateStrategyPattern;
using Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MandateClass
{
    public partial class FormClass : Form
    {
        MyDB mydb;
        MandateCorporation PortfoliosCorporation { get; set; }
        MandatePrivateJoint PortfoliosPrivateJoint { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            mydb = new MyDB();
            PortfoliosCorporation = new MandateCorporation(mydb.portfolios.Where(x => x.MandateType == MandateTypes.Corporation).ToList());
            PortfoliosPrivateJoint = new MandatePrivateJoint(mydb.portfolios.Where(x => x.MandateType == MandateTypes.PrivateJoint).ToList());
            PortfolioItems.Items.AddRange(mydb.portfolios.Select(x => x.Name).ToArray());
        }

        public FormClass()
        {
            InitializeComponent();
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            if (PortfolioItems.SelectedIndex >= 0)
            {
                Portfolio SelectedPortfolio = mydb.portfolios.FirstOrDefault(x => x.Name == PortfolioItems.SelectedItem.ToString());

                switch (SelectedPortfolio.MandateType)
                {
                    case MandateTypes.PrivateJoint:
                        lblOutput.Text = PortfoliosPrivateJoint.RunKYCMandate(SelectedPortfolio);
                        break;

                    case MandateTypes.Corporation:
                        lblOutput.Text = PortfoliosCorporation.RunKYCMandate(SelectedPortfolio);
                        break;
                }
            }
        }

    }
}
