using Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MandateStrategy
{
    public partial class FormClass : Form
    {
        MyDB mydb;
        Context context;

        private void Form1_Load(object sender, EventArgs e)
        {
            mydb = new MyDB();
            PortfolioItems.Items.AddRange(mydb.portfolios.Select(x => x.Name).ToArray());
        }

        public FormClass()
        {
            InitializeComponent();
        }

        private void Strategy_Click(object sender, EventArgs e)
        {
            if (PortfolioItems.SelectedIndex >= 0)
            {
                Portfolio SelectedPortfolio = mydb.portfolios.FirstOrDefault(x => x.Name == PortfolioItems.SelectedItem.ToString());

                switch (SelectedPortfolio.MandateType)
                {
                    case MandateTypes.PrivateJoint:
                        context = new Context(new MandatePrivateJoint());
                        lblOutput.Text = context.ContextInterface(SelectedPortfolio);
                        break;

                    case MandateTypes.Corporation:
                        context = new Context(new MandateCorporation());
                        lblOutput.Text = context.ContextInterface(SelectedPortfolio);
                        break;
                }
            }
        }

    }
}
