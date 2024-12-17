using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace smartFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            #region C#걸음마
            //textBox1.Text = "안녕\r\n반가워";

            //double sample = 1;

            //textBox1.Text = sample.ToString();
            #endregion

            #region 자료형 실습
            // byte My_age = 24;
            // short earth_underground_depth = -12000;
            // int blueWhale_day_meal = 600000000;
            // float my_height = 176.5f;
            // double converting_1micro_to_km = 0.000000001;
            //decimal solar_energy_emitted_per_day = 1000000000000000000000000000m;

            // textBox1.Text = My_age.GetType().ToString() + " My_age " + My_age + "\r\n";
            // textBox1.Text += $"{My_age.GetType()}"+" "+ "my_age"+$"{My_age}"+"\r\n";
            // textBox1.Text += earth_underground_depth.GetType().ToString() + "  earth_underground_depth " + earth_underground_depth + "\r\n";
            // textBox1.Text += blueWhale_day_meal.GetType().ToString() + "  blueWhale_day_meal " + blueWhale_day_meal + "\r\n";
            // textBox1.Text += my_height.GetType().ToString() + "  my_height " + my_height + "\r\n";
            // textBox1.Text += converting_1micro_to_km.GetType().ToString() + "  converting_1micro_to_km " + converting_1micro_to_km + "\r\n";
            // textBox1.Text += solar_energy_emitted_per_day.GetType().ToString() + " solar_energy_emitted_per_day " + solar_energy_emitted_per_day + "\r\n";

            #endregion

            #region 변수 실습1
            //            string[] test = {
            //    "동해 물과 백두산이",
            //    "토요일에 먹는 토마토",
            //    "질서 있는 퇴장",
            //    "그 사람의 그림자는 그랬다",
            //    "삼성 갤럭시",
            //    "오늘은 왠지 더 배고프다",
            //    "이름,나이,전화번호",
            //    "우리 나라 만세"
            //};

            //            string[] result = new string[10];

            //            result[0] = test[0].IndexOf("백두산").ToString();   // 백두산을 찾아아
            //            result[1] = test[1].LastIndexOf("토").ToString();  // 마지막부터 토를 찾아서 반환
            //            result[2] = test[2].Contains("퇴").ToString();   // 있으면 true / false
            //            result[3] = test[3].Replace("그", "이").ToString();  // 어떤 문자를 뭐로 바꿀거냐
            //            result[4] = test[4].Insert(3, "애플").ToString();   // 몇번째의 글자부터 어떤문자열을 넣을거냐
            //            result[5] = test[5].Remove(7, 1).ToString();       // remove 몇번째의 글자부터 몇개를 지울거냐
            //            string[] test7 = test[6].Split(',');      // 스트링 배열 이니까 맞춰줘야함함
            //            result[6] = test7[0];
            //            result[7] = test7[1];
            //            result[8] = test7[2];


            //            result[9] = test[7].Substring(3, 2).ToString();      // substring 4번쨰 인덱스부터 두개를 출력

            #endregion

            #region 변수 실습2

            // 실습 2
            string paragraph = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

            // 1번
            int specialChar = paragraph.IndexOf("-");
            string result1 = paragraph.Remove(specialChar, 3);

            // 2번
            int serch1 = paragraph.IndexOf("얼");
            int serch2 = paragraph.LastIndexOf("는");
            string question2 = paragraph.Substring(serch1, serch2-serch1);
            string[] result2 = question2.Split(' ');

            // 3번 
            int removeSpecialChar1 = paragraph.IndexOf(".");
            string removeparagraph1 = paragraph.Remove(removeSpecialChar1, 1);
            int removeSpecialChar2 = removeparagraph1.IndexOf("-");
            string removeparagraph = removeparagraph1.Remove(removeSpecialChar2, 1);
            string result3 = removeparagraph.Replace(" ", ",");
           

            textBox_00.Text = result1 + "\r\n";
            textBox_00.Text += result2[0] + "\r\n" + result2[1] + "\r\n" + result2[2] + "\r\n";
            textBox_00.Text += result3 + "\r\n";

            #endregion


        }
    }
}
