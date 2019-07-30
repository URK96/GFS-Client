using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class GFSHelp : Form
    {
        public GFSHelp()
        {
            InitializeComponent();

            InitProcess();
        }

        private async void InitProcess()
        {
            await Task.Delay(100);

            try
            {
                EquipmentDicExampleType1.Image = EquipmentDicExampleImage.Images["EquipmentDicExampleIcon1"];
                EquipmentDicExampleType2.Image = EquipmentDicExampleImage.Images["EquipmentDicExampleIcon2"];
                EquipmentDicExampleType3.Image = EquipmentDicExampleImage.Images["EquipmentDicExampleIcon3"];
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
    }
}
