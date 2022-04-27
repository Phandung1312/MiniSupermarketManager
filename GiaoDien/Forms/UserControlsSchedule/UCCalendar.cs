using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Forms
{
    public partial class UCCalendar : UserControl
    {
        private int month;
        private int year;
        private List<Button> buttons;
        private Button buttonDay;
        public UCCalendar()
        {
            InitializeComponent();
           
        }

        private void setButtonDay()
        {
            buttonDay.Size = new System.Drawing.Size(110, 55);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void Display()
        {
            DateTime now =DateTime.Now;
            month = now.Month;
            year = now.Year;
            AddUC_Days();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }

            this.dayContainer.Controls.Clear();
            AddUC_Days();
            this.Refresh();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if(month == 1)
            {
                month=12;
                year--;
            }
            else
            {
                month--;
            }
            this.dayContainer.Controls.Clear();
            AddUC_Days();
            this.Refresh();
        }
        private void AddUC_Days()
        {
            buttons=new List<Button>();
            DateTime startOfMonth = new DateTime(year, month, 1);

            int dayOfMonth = DateTime.DaysInMonth(year, month);

            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfWeek; i++)
            {
                buttonDay = new Button();
                setButtonDay();
                buttonDay.Enabled = false;
                this.dayContainer.Controls.Add(buttonDay);
                
                buttons.Add(buttonDay);
                
            }
            for (int i = 1; i <= dayOfMonth; i++)
            {
                buttonDay=new Button();
                setButtonDay();
                if (DateTime.Now.Date == new DateTime(year, month, i)) 
                {
                    buttonDay.BackColor=Color.Blue;
                }
                buttons.Add(buttonDay);
                buttonDay.Click += new EventHandler(Show);
                buttonDay.Text = i.ToString();
                this.dayContainer.Controls.Add(buttonDay);
            }
        }


        private void Reload()
        {
            this.Visible = true;
            this.Refresh();
        }

        private void Show(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var uc= new UCAddPlan();
            
            this.Visible = false;
            uc.Del=new UCAddPlan.AddPlan_Del(Reload);
            this.Parent.Controls.Add((uc));
            uc.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uc = new UCSceduleSale();
            this.Visible = false;
            uc.DelSch = new UCSceduleSale.ScheduleDel(Reload);
            this.Parent.Controls.Add(uc);
            uc.Dock=DockStyle.Fill;
        }
    }
}
