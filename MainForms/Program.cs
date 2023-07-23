using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //   Application.EnableVisualStyles();
            //   Application.SetCompatibleTextRenderingDefault(false);
            //메인클래스가 실행되기전에 login 클래스 실행

            

            while ( true )
            {
                Form1 login = new Form1();
                login.ShowDialog();
                ArrayList List = login.Tag as ArrayList; //Arraylist 에 없을수도 있으니 as
                
                if (Commons.bloginFlag) break;    //클로즈버튼 누르면 무한루프 탈출

                //if ((bool)List[0]) break;


                #region <정적변수를 이용한 메인화면 호출방법>
                //로그인이 성공을 했을때
                //아래의 메인창을 오픈해야한다.
                //if (Commons.bloginFlag)
                //{
                //    Application.Run(new M03_MainForm());
                //}
                #endregion



                #region<어레이태그사용한 방법>



                if (List != null && (bool)List[0] == true && (string)List[2] == "mag")
                {
                    M03_MainForm M03 = new M03_MainForm(List[1].ToString());
                    Application.Run(M03);
                    if ((bool)M03.Tag) break;
                }

                else if (List != null && (bool)List[0] == true && (string)List[2] == "prod")
                {
                    M04_WorkerForm M04 = new M04_WorkerForm(List[1].ToString());
                    M04.ShowDialog();

                    //if (M04.Tag == null && !(bool)M04.Tag)
                    //{
                    //    break;
                    //}
                     if((bool)M04.Tag ==false)    //작업자 화면에서 트루없이 종료했을때 브레이크
                    {
                        break;
                    }
                    
                }
            }
            #endregion
        }
    }
}