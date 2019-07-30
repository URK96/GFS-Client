using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Supporter
{
    public partial class SkillViewer : Form
    {
        DataRow DollDR = null;
        PrivateFontCollection pfc = new PrivateFontCollection();

        const string ImagePath = @"Data\Image";
        private int ModIndex = 0;

        public SkillViewer(string name, int modindex)
        {
            InitializeComponent();

            DollDR = ETC.FindDataRow(ETC.DollList, "Name", name);
            ModIndex = modindex;

            Text = (string)DollDR["Name"] + " - 스킬 정보";

            if (ModIndex < 2)
            {
                SkillInfoTabControl.TabPages.Remove(ModSkill);
            }

            ConfirmFonts();
            LoadSkillInfo();
        }

        private void ConfirmFonts()
        {
            string[] FontFiles = { "H2MKPB.TTF", "H2PORL.TTF", "H2SA1M.TTF", "NanumSquareRoundL.ttf" };
            const string FontPath = @"Data\System\Fonts";

            try
            {
                foreach (string s in FontFiles)
                {
                    string path = Path.Combine(FontPath, s);
                    if (File.Exists(path) == true) pfc.AddFontFile(path);
                }

                for (int i = 0; i < pfc.Families.Length; ++i)
                {
                    switch (pfc.Families[i].Name)
                    {
                        case "나눔스퀘어라운드 Light":
                            SkillInfoExplain.Font = new Font(pfc.Families[i], 11);
                            break;
                        case "HY목각파임B":
                            SkillInfoName.Font = new Font(pfc.Families[i], 15);
                            ModSkillInfoName.Font = new Font(pfc.Families[i], 15);
                            break;
                        case "HY엽서L":
                            SkillInfoDetailTable.Font = new Font(pfc.Families[i], 12);
                            ModSkillInfoDetailTable.Font = new Font(pfc.Families[i], 12);
                            break;
                        case "HY얕은샘물M":
                            ModSkillInfoExplain.Font = new Font(pfc.Families[i], 13);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ETC.ErrorMessage(ex.Message);
                ETC.LogError(ex.Message + "\n\n" + ex.StackTrace);
                return;
            }
        }

        private async void LoadSkillInfo()
        {
            await Task.Delay(100);

            try
            {
                string SkillIconPath = Path.Combine(ImagePath, "SkillIcon", (string)DollDR["Skill"] + ".png");
                if (File.Exists(SkillIconPath) == true) SkillInfoIcon.ImageLocation = SkillIconPath;
                SkillInfoName.Text = (string)DollDR["Skill"];
                SkillInfoExplain.Text = (string)DollDR["SkillExplain"];

                string[] skill_effects = ((string)DollDR["SkillEffect"]).Split(';');
                string[] skill_mags = null;

                if (ModIndex == 0) skill_mags = ((string)DollDR["SkillMag"]).Split(',');
                else skill_mags = ((string)DollDR["SkillMagAfterMod"]).Split(',');

                TableLayoutPanel tlp = SkillInfoDetailTable;

                for (int i = 0; i < skill_effects.Length; ++i)
                {
                    if (tlp.RowCount < (i + 1))
                    {
                        tlp.RowCount += 1;
                    }

                    Label lb1 = new Label
                    {
                        Name = "Effect" + (i + 1),
                        Text = skill_effects[i],
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label lb2 = new Label
                    {
                        Name = "Mag" + (i + 1),
                        Text = skill_mags[i],
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    tlp.Controls.Add(lb1);
                    tlp.Controls.Add(lb2);
                }

                if (ModIndex >= 2)
                {
                    /*string SkillIconPath = Path.Combine(ImagePath, "SkillIcon", (string)DollDR["Skill"] + ".png");
                    if (File.Exists(SkillIconPath) == true) SkillInfoIcon.ImageLocation = SkillIconPath;*/

                    ModSkillInfoName.Text = (string)DollDR["ModSkill"];
                    ModSkillInfoExplain.Text = (string)DollDR["ModSkillExplain"];

                    string[] modskill_effects = ((string)DollDR["ModSkillEffect"]).Split(';');
                    string[] modskill_mags = ((string)DollDR["ModSkillMag"]).Split(',');

                    TableLayoutPanel mod_tlp = ModSkillInfoDetailTable;

                    for (int i = 0; i < modskill_effects.Length; ++i)
                    {
                        if (mod_tlp.RowCount < (i + 1))
                        {
                            mod_tlp.RowCount += 1;
                        }

                        Label lb1 = new Label
                        {
                            Name = "Effect" + (i + 1),
                            Text = modskill_effects[i],
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        Label lb2 = new Label
                        {
                            Name = "Mag" + (i + 1),
                            Text = modskill_mags[i],
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        mod_tlp.Controls.Add(lb1);
                        mod_tlp.Controls.Add(lb2);
                    }
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
