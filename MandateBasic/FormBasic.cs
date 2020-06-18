using Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MandateBasic
{
    public partial class FormBasic : Form
    {
        MyDB mydb;

        public FormBasic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mydb = new MyDB();           
            PortfolioItems.Items.AddRange(mydb.portfolios.Select(x=>x.Name).ToArray());
        }

        private void Basic_Click(object sender, EventArgs e)
        {
            if (PortfolioItems.SelectedIndex >= 0)
            {
                Portfolio SelectedPortfolio = mydb.portfolios.FirstOrDefault(x => x.Name == PortfolioItems.SelectedItem.ToString());

                switch (SelectedPortfolio.MandateType)
                {
                    case MandateTypes.PrivateJoint:
                        lblOutput.Text= PrivateJointCreate(SelectedPortfolio);
                        break;

                    case MandateTypes.Corporation:
                        lblOutput.Text = CorporationCreate(SelectedPortfolio);
                        break;
                }
            }
        }

        private string CorporationCreate(Portfolio SelectedPortfolio)
        {
            string res=KYCMandate.Header(SelectedPortfolio);
            res += KYCMandate.CorporationAddSection1();
            res += KYCMandate.CorporationAddSection2();
            return res;
        }

        private string PrivateJointCreate(Portfolio SelectedPortfolio)
        {
            string res = KYCMandate.Header(SelectedPortfolio);
            res += KYCMandate.PrivateJointAddSection1();
            res += KYCMandate.PrivateJointAddSection2();
            return res;
        }

    
    }
}
