using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class EquipmentSelector : Form
    {
        int Number = 1;

        public EquipmentSelector(int num)
        {
            InitializeComponent();

            Number = num;
            InitProcess();
        }

        private async void InitProcess()
        {
            await Task.Delay(100);

            try
            {
                await ListEquipmentProcess();
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async Task ListEquipmentProcess()
        {
            await Task.Delay(100);

            try
            {
                EquipmentSelectorListView.Items.Clear();

                for (int i = 0; i < ETC.EquipmentList.Rows.Count; ++i)
                {
                    DataRow dr = ETC.EquipmentList.Rows[i];

                    string g = "";

                    switch ((int)dr["Grade"])
                    {
                        case 2:
                            g = "☆☆";
                            break;
                        case 3:
                            g = "☆☆☆";
                            break;
                        case 4:
                            g = "☆☆☆☆";
                            break;
                        case 5:
                            g = "☆☆☆☆☆";
                            break;
                        case 0:
                            g = "★";
                            break;
                    }
                    EquipmentSelectorListView.Items.Add(new ListViewItem(new string[] { (string)dr["Name"], (string)dr["Type"], (string)dr["Category"], g, ETC.CalcTime((int)dr["ProductTime"]) }));
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void SelectCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectOK_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedEquipmentName = EquipmentSelectorListView.SelectedItems[0].SubItems[0].Text;

                DataRow dr = ETC.FindDataRow(ETC.EquipmentList, "Name", SelectedEquipmentName);

                if (dr != null)
                {
                    ((MainForm)Owner).SelectedEquipmentDataRow[Number - 1] = dr;
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
    }
}
