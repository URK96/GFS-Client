using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girls_FrontierLine_Updater
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (args.Length > 0)
                {
                   

                    switch (args[0])
                    {
                        case "Client":
                            ETC.Mode = ETC.UpdateMode.Client;
                            break;
                        case "DB":
                            ETC.Mode = ETC.UpdateMode.DB;
                            break;
                        default:
                            ETC.Mode = ETC.UpdateMode.None;
                            break;
                    }
                    
                    Application.Run(new Updater());
                }
                else
                {
                    MessageBox.Show("업데이터 인수가 잘못되었습니다. 정상적인 방법으로 실행하시기 바랍니다.", "업데이트 실행 불가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                ETC.ErrorMessage(ex.StackTrace);
            }
        }
    }
}
