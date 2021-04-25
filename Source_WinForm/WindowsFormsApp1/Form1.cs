using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b1t = double.Parse(txt꽃3.Text);
            double b2t = double.Parse(txt깃털3.Text);
            double b3t = double.Parse(txt시계3.Text);
            double b4t = double.Parse(txt잔3.Text);
            double b5t = double.Parse(txt모자3.Text);
            double b6t = double.Parse(txt세트3.Text);

            double b1f = double.Parse(txt꽃4.Text);
            double b2f = double.Parse(txt깃털4.Text);
            double b3f = double.Parse(txt시계4.Text);
            double b4f = double.Parse(txt잔4.Text);
            double b5f = double.Parse(txt모자4.Text);
            double b6f = double.Parse(txt세트4.Text);

            double a = double.Parse(txt총공격력.Text);
            double g = double.Parse(txt추가공격력.Text);
            double temp = a - g;        //총공격력 - 추가공격력

            double w1 = 0;
            double w2 = 0;



            if (txt웨폰1.Text != "")
            {
                w1 = double.Parse(txt웨폰1.Text);      //무기 공격력
            }
            if (txt웨폰2.Text != "")
            {
                w2 = double.Parse(txt웨폰2.Text);      //무기 공격력 퍼센트
            }

            lbl웨폰.Text = "+" + (temp * w2 / 100 + w1);           //(총공격력 - 추가공격력) * 무기 공격력 퍼센트 + 무기 공격력

            double b1 = double.Parse(txt꽃1.Text);
            double b1r = double.Parse(txt꽃2.Text);
            lbl꽃.Text = "+" + (temp * b1r / 100 +b1);

            double b2 = double.Parse(txt깃털1.Text);
            double b2r = double.Parse(txt깃털2.Text);
            double t = (temp * b2r / 100 + b2);
            lbl깃털.Text = "+" + (temp * b2r / 100 + b2);         //(총공격력 - 추가공격력) * 깃털 공격력 퍼센트 + 깃털 공격력

            double b3 = double.Parse(txt시계1.Text);
            double b3r = double.Parse(txt시계2.Text);
            lbl시계.Text = "+" + (temp * b3r / 100 + b3); 

            double b4 = double.Parse(txt잔1.Text);
            double b4r = double.Parse(txt잔2.Text);
            lbl잔.Text = "+" + (temp * b4r / 100 + b4); 

            double b5 = double.Parse(txt모자1.Text);
            double b5r = double.Parse(txt모자2.Text);
            lbl모자.Text = "+" + (temp * b5r / 100 + b5);

            double b6 = double.Parse(txt세트1.Text);
            double b6r = double.Parse(txt세트2.Text);
            lbl세트.Text = "+" + (temp * b6r / 100 + b6);

            lbl기초공격력.Text = temp - w1 + "";     //총공격력 - 추가공격력 - 무기공격력


            double Critical1 = double.Parse(txt치확.Text);
            double Critical2 = double.Parse(txt치피.Text);
            double Element = double.Parse(txt원소마스터리.Text);
            double Damage = double.Parse(txt피해증가.Text);
            double x5 = double.Parse(txt방어력감면.Text);
            double x6 = double.Parse(txt증뎀.Text);
            lblResult.Text = a * Damage * Critical2 * Element * x5 * x6 + "";


            lbl공격력.Text = b1 + b2 + b3 + b4 + b5 + b6 + "";
            lbl퍼센트.Text = b1r + b2r + b3r + b4r + b5r + b6r + "";
            lbl치확.Text = b1t + b2t + b3t + b4t + b5t + b6t + "";
            lbl치피.Text = b1f + b2f + b3f + b4f + b5f + b6f + "";

            lblWB1.Text = double.Parse(txt웨폰1.Text) + double.Parse(lbl공격력.Text) + "";
            lblWB2.Text = double.Parse(txt웨폰2.Text) + double.Parse(lbl퍼센트.Text) + "";
            lblWB3.Text = double.Parse(txt웨폰3.Text) + double.Parse(lbl치확.Text) + "";
            lblWB4.Text = double.Parse(txt웨폰4.Text) + double.Parse(lbl치피.Text) + "";
        }


    }
}
