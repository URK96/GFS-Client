using System;
using System.Data;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class DollAbilityChartViewer : Form
    {
        public DollAbilityChartViewer(DataRow dr, int mod_index)
        {
            InitializeComponent();

            InitProcess(dr, mod_index);
        }

        private void InitProcess(DataRow DollDR, int mod_index)
        {
            string[] Abilities = { "HP", "화력", "회피", "명중", "공속" };
            string[] Index_Abilities = { "HP", "FireRate", "Evasion", "Accuracy", "AttackSpeed" };

            try
            {
                string type = (string)DollDR["Type"];
                int[] D_Ability = new int[Index_Abilities.Length];

                for (int i = 0; i < Index_Abilities.Length; ++i)
                {
                    switch (mod_index)
                    {
                        case 0:
                            D_Ability[i] = int.Parse(((string)DollDR[Index_Abilities[i]]).Split(';')[mod_index].Split('/')[1]);
                            break;
                        case 1:
                        case 2:
                        case 3:
                            D_Ability[i] = int.Parse(((string)DollDR[Index_Abilities[i]]).Split(';')[mod_index]);
                            break;
                    }
                }

                int[] Avg_Ability = new int[Index_Abilities.Length];
                int DollCount = 0;

                foreach (DataRow t_dr in ETC.DollList.Rows)
                {
                    if ((string)t_dr["Type"] != type) continue;

                    for (int i = 0; i < Index_Abilities.Length; ++i)
                    {
                        switch ((bool)t_dr["HasMod"])
                        {
                            case true:
                                Avg_Ability[i] += int.Parse(((string)t_dr[Index_Abilities[i]]).Split(';')[0].Split('/')[1]);
                                break;
                            case false:
                                Avg_Ability[i] += int.Parse(((string)t_dr[Index_Abilities[i]]).Split('/')[1]);
                                break;
                        }


                    }

                    DollCount += 1;
                }

                for (int i = 0; i < Index_Abilities.Length; ++i)
                {
                    Avg_Ability[i] = Convert.ToInt32(Math.Round((Double)Avg_Ability[i] / DollCount));
                }

                DollAbilityChartBig.Series["인형"].Points.DataBindXY(Abilities, D_Ability);
                DollAbilityChartBig.Series["평균"].Points.DataBindXY(Abilities, Avg_Ability);
                DollAbilityChartBig.Series["인형"].Name = (string)DollDR["Name"];
                DollAbilityChartBig.Series["평균"].Name = (string)DollDR["Type"] + " 평균";
            }
            catch (Exception ex)
            {
                ETC.LogError(ex.ToString());
                ETC.ErrorMessage(ex.Message);
            }
        }
    }
}
