using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedicaTrader
{
    public partial class FormChartsSetting : MetroForm
    {
        private FormChartsSetting _form;
        private SettingChart _setting;
        public FormChartsSetting()
        {
            InitializeComponent();
            _form = this;
            _setting = SettingChart.Load<SettingChart>();
            if(_setting == null)
            {
                _setting = new SettingChart();
            }
        }
        private void FormChartsSetting_Load(object sender, EventArgs e)
        {
            this.PixelSizeNumUpDown.Value = _setting.CellSize;
            this.Ref1NumUpDown.Value =_setting.FirstRefColumn;
            this.Ref2NumUpDown.Value = _setting.SecondRefColumn;
            this.PlaySoundCheckBox.Checked = _setting.PlaySoundOnUpdate;
            this.EnableZoomCheckBox.Checked = _setting.EnabelZoom;
            this.ShowDTCheckBox.Checked = !_setting.DoNotShowDate;
            this.ShowOSDTCheckBox.Checked = _setting.ShowSignalDate;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _form.DialogResult = DialogResult.Cancel;
            _form.Close();
        }

        private void PlaySoundCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            _setting.PlaySoundOnUpdate = this.PlaySoundCheckBox.Checked;
        }

        private void EnableZoomCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            _setting.EnabelZoom = EnableZoomCheckBox.Checked;
        }

        private void PixelSizeNumUpDown_ValueChanged(object sender, EventArgs e)
        {

            _setting.CellSize = (int)this.PixelSizeNumUpDown.Value;
        }

        private void Ref1NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _setting.FirstRefColumn = (int)this.Ref1NumUpDown.Value;
        }

        private void Ref2NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            _setting.SecondRefColumn = (int)this.Ref2NumUpDown.Value;
        }

        private void OKsfButton1_Click(object sender, EventArgs e)
        {
            _setting.Save();
            _form.DialogResult = DialogResult.OK;
            _form.Close();
        }

        private void ShowDTCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            _setting.DoNotShowDate = !this.ShowDTCheckBox.Checked;
        }

        private void ShowOSDTCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            _setting.ShowSignalDate = this.ShowOSDTCheckBox.Checked;
        }
    }
}
