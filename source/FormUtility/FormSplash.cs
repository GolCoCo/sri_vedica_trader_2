
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM = System.Timers;

namespace VedicaTrader
{
    public partial class FormSplash : Form
    {
        private TM.Timer tmClose = new TM.Timer();
        private bool _isflag = true;
        public FormSplash()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQ0OTkxQDMxMzkyZTMzMmUzMEMvVGtJblFTaXRkUlU0WUhkVnVnb0hobjNSa1B4SThVcFJ2N0hiWm9ZOG89;NTQ0OTkyQDMxMzkyZTMzMmUzMElNR2Zobjk2ZlozYTFKOGtrMXFERU9BNER0Q3BUMSt5YzFRbUErVkU2dnM9;NTQ0OTkzQDMxMzkyZTMzMmUzMEREdWRCK2xuaWlmSXgrdVBRbWQxbG5Bb1p2ZHc3aXl1SmRoRFZJTC93ZHM9;NTQ0OTk0QDMxMzkyZTMzMmUzMEsxRmQ0eURqYlZpM055T1dTN2dWbGZIemYrenB1VlBWZnZtSFVkZUtWaTQ9;NTQ0OTk1QDMxMzkyZTMzMmUzMG1OVFExVDYwVHYwemQ1NS84RDN5U1RrUFg2WkZCTERVY2VibkRzajZMakE9;NTQ0OTk2QDMxMzkyZTMzMmUzMEowcnBEdjFCQVF0SXlNckhaZ1EyRC85MzNPdXFSV0pGL0hnK2lDV2JFU2c9;NTQ0OTk3QDMxMzkyZTMzMmUzMEtxYTlXWHNSSXl6WnBOMWl4cUE2Qmk1OTJZb2RZd1B0ZzFkSVZQS1lOZVE9;NTQ0OTk4QDMxMzkyZTMzMmUzMEREVFFqSzE1dEJML0s3Z2grbWo5VUswanlNN2hyK2FKNzBPcFUyaWVDWnM9;NTQ0OTk5QDMxMzkyZTMzMmUzMExENkxON2x0RGNxQ3MwTkJFU3dLbmszVVVnM0RzbVZqMzNFUUZWcDY3ZGs9;NTQ1MDAwQDMxMzkyZTMzMmUzMFFzQUlvSDFHZ1Fycy80S3pFOHgrTi9QNGR4cE1MTStMQy9qeUM0aFJQY0U9;NTQ1MDAxQDMxMzkyZTMzMmUzMFV0Z2FsK1Nab3RTdUd0V0krSGJyVHZCZG1JeGFjTnB1U3JUeVpwRzBYSTA9");
        }

        public FormSplash(bool isflag)
        {
            _isflag = isflag;
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQ0OTkxQDMxMzkyZTMzMmUzMEMvVGtJblFTaXRkUlU0WUhkVnVnb0hobjNSa1B4SThVcFJ2N0hiWm9ZOG89;NTQ0OTkyQDMxMzkyZTMzMmUzMElNR2Zobjk2ZlozYTFKOGtrMXFERU9BNER0Q3BUMSt5YzFRbUErVkU2dnM9;NTQ0OTkzQDMxMzkyZTMzMmUzMEREdWRCK2xuaWlmSXgrdVBRbWQxbG5Bb1p2ZHc3aXl1SmRoRFZJTC93ZHM9;NTQ0OTk0QDMxMzkyZTMzMmUzMEsxRmQ0eURqYlZpM055T1dTN2dWbGZIemYrenB1VlBWZnZtSFVkZUtWaTQ9;NTQ0OTk1QDMxMzkyZTMzMmUzMG1OVFExVDYwVHYwemQ1NS84RDN5U1RrUFg2WkZCTERVY2VibkRzajZMakE9;NTQ0OTk2QDMxMzkyZTMzMmUzMEowcnBEdjFCQVF0SXlNckhaZ1EyRC85MzNPdXFSV0pGL0hnK2lDV2JFU2c9;NTQ0OTk3QDMxMzkyZTMzMmUzMEtxYTlXWHNSSXl6WnBOMWl4cUE2Qmk1OTJZb2RZd1B0ZzFkSVZQS1lOZVE9;NTQ0OTk4QDMxMzkyZTMzMmUzMEREVFFqSzE1dEJML0s3Z2grbWo5VUswanlNN2hyK2FKNzBPcFUyaWVDWnM9;NTQ0OTk5QDMxMzkyZTMzMmUzMExENkxON2x0RGNxQ3MwTkJFU3dLbmszVVVnM0RzbVZqMzNFUUZWcDY3ZGs9;NTQ1MDAwQDMxMzkyZTMzMmUzMFFzQUlvSDFHZ1Fycy80S3pFOHgrTi9QNGR4cE1MTStMQy9qeUM0aFJQY0U9;NTQ1MDAxQDMxMzkyZTMzMmUzMFV0Z2FsK1Nab3RTdUd0V0krSGJyVHZCZG1JeGFjTnB1U3JUeVpwRzBYSTA9");


        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            if (!_isflag)
            {
                tmClose.Interval = 1;
            }
            else
            {
                tmClose.Interval = 2000;
            }

            tmClose.Elapsed += TmClose_Elapsed;
            tmClose.Start();
        }

        private void TmClose_Elapsed(object sender, TM.ElapsedEventArgs e)
        {
            tmClose.Stop();
            this.InvokeIfRequired(p => p.Close());
        }
    }
}
