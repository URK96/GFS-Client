using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class ProductTimeTable : Form
    {
        public ProductTimeTable(int mode)
        {
            InitializeComponent();

            InitProcess(mode);
        }

        private async void InitProcess(int ListMode)
        {
            await Task.Delay(100);

            try
            {
                ProductTimeListView.Items.Clear();

                switch (ListMode)
                {
                    case (int)ETC.TimeTableMode.Doll:
                        this.Text = "인형 제조 시간표";
                        for (int i = 0; i < ETC.DollList.Rows.Count; ++i)
                        {
                            DataRow dr = ETC.DollList.Rows[i];
                            if ((int)dr["ProductTime"] > 0)
                            {
                                string tTime = ETC.CalcTime((int)dr["ProductTime"]);
                                if (((string)dr["DropEvent"]).Split(',')[0] == "중형제조") tTime += " (중형)";
                                ProductTimeListView.Items.Add(new ListViewItem(new string[] { tTime, (string)dr["Name"] }));
                            }
                        }
                        /*Sorter sorter = new Sorter();
                        sorter.Order = ProductTimeListView.Sorting;
                        sorter.ColumnIndex = 0;
                        ProductTimeListView.ListViewItemSorter = sorter;
                        ProductTimeListView.Sort();*/
                        break;
                    case (int)ETC.TimeTableMode.Equipment:
                        this.Text = "장비 제조 시간표";
                        for (int i = 0; i < ETC.EquipmentList.Rows.Count; ++i)
                        {
                            DataRow dr = ETC.EquipmentList.Rows[i];
                            if ((int)dr["ProductTime"] > 0)
                            {
                                string tTime = ETC.CalcTime((int)dr["ProductTime"]);
                                ProductTimeListView.Items.Add(new ListViewItem(new string[] { tTime, (string)dr["Name"] }));
                            }
                        }
                        break;
                    case (int)ETC.TimeTableMode.Fairy:
                        this.Text = "요정 제조 시간표";
                        for (int i = 0; i < ETC.FairyList.Rows.Count; ++i)
                        {
                            DataRow dr = ETC.FairyList.Rows[i];
                            if ((int)dr["ProductTime"] > 0)
                            {
                                string tTime = ETC.CalcTime((int)dr["ProductTime"]);
                                ProductTimeListView.Items.Add(new ListViewItem(new string[] { tTime, (string)dr["Name"] }));
                            }
                        }
                        break;
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
