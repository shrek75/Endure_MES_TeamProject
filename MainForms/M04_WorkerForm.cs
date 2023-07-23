using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class M04_WorkerForm : MetroFramework.Forms.MetroForm
    {
        public M04_WorkerForm()
        {
            InitializeComponent();
        }

        public M04_WorkerForm(string sUsername)
        {
            InitializeComponent();
            Tag = false;
        }


        private void M04_WorkerForm_Load(object sender, EventArgs e)
        {
            DataTable dtTemp = new DataTable();

            dtTemp.Columns.Add("WORKID", typeof(string));  
            dtTemp.Columns.Add("WORKTIME", typeof(string));
            dtTemp.Columns.Add("CONTENTS", typeof(string));
            dtTemp.Columns.Add("GOAL", typeof(string));
            dtTemp.Columns.Add("WORKFLAG", typeof(string));
            dtTemp.Columns.Add("WORKERNAME", typeof(string));




            //2. 컬럼이 설정된 데이터 테이블을 그리드뷰에 셋팅(매핑)
            //DataSource : DataTable 의 내용을 기반으로 그리드에 행과 열의 디자인을 표현하는 속성
            Grid1.DataSource = dtTemp;

            //3. 그리드에 표현될 헤더 (컬럼의 제목) 의 명칭을 설정.

            Grid1.Columns["WORKID"].HeaderText = " 작업구분";
            Grid1.Columns["WORKTIME"].HeaderText = "작업시간";
            Grid1.Columns["CONTENTS"].HeaderText = "내용";
            Grid1.Columns["GOAL"].HeaderText = "목표 작업량";
            Grid1.Columns["WORKFLAG"].HeaderText = "작업 여부";
            Grid1.Columns["WORKERNAME"].HeaderText = "작업자";


            // 컬럼의 폭 지정
            Grid1.Columns[0].Width = 150;
            Grid1.Columns[1].Width = 200;
            Grid1.Columns[2].Width = 200;
            Grid1.Columns[3].Width = 150;
            Grid1.Columns[4].Width = 150;
            Grid1.Columns[5].Width = 150;

            dtTemp.Rows.Add("수리", "7/4(화) 08:00~09:00", "A설비 소모품 교체", "50EA", "O", "박선혁");
            dtTemp.Rows.Add("생산", "7/4(화) 09:00~13:00", "선박용 미션A생산", "50EA", "O", "이유진");
            dtTemp.Rows.Add("생산", "7/4(화) 13:00~18:00", "선박용 미션B생산", "200EA", "O", "김태욱");

            dtTemp.Rows.Add("생산", "7/5(수) 08:00~09:00", "선박용미션 A생산", "100EA", "-", "");
            dtTemp.Rows.Add("예방점검", "7/6(목) 08:00~09:00", "A설비 예방점검", "50EA", "-", "");
            Grid1.DataSource = dtTemp;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (Result == DialogResult.Yes)
            {


                this.Tag = true;
                this.Close();
            }
        }



        }
    }

