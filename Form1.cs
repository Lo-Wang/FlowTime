using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowApplication
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public int second;
        public int minute;
        public int firstInputSecond = 0;
        public int firstInputMinute = 25;
        public int switchCycle = 2;
        bool firstClick = true;

        public FormMain()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SecondTextBox.Text, out second))
            {
                SecondTextBox.Text = "00";
            }
            if (!int.TryParse(MinuteTextBox.Text, out second))
            {
                MinuteTextBox.Text = "25";
            }

            minute = Convert.ToInt32(MinuteTextBox.Text);
            second = Convert.ToInt32(SecondTextBox.Text);

            if (firstClick == true)
            {
                firstInputMinute = Convert.ToInt32(MinuteTextBox.Text);
                firstInputSecond = Convert.ToInt32(SecondTextBox.Text);
                firstClick = false;
            }

            if (PauseButton.Text == ">")
            {
                Timer.Enabled = true;
                PauseButton.Text =  "||";
            }
            else
            {
                Timer.Enabled = false;
                PauseButton.Text = ">";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            second--;

            if (second == -1)
            {
                minute--;
                second = 59;
            }

            if ((minute == 0) && (second == 0))
            {
                switchCycle++;  
                Switcher(switchCycle);
            }

            if (second < 10)
            {
                SecondTextBox.Text = "0" + second.ToString();
            }
            else
            {
                SecondTextBox.Text = second.ToString();
            }
            if (minute < 10)
            {
                MinuteTextBox.Text = "0" + minute.ToString();
            }
            else
            {
                MinuteTextBox.Text = minute.ToString();
            }  
            
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChillTime()
        {
            ChillColour();
            this.Alert("Время отдыха", Form_Alert.enmType.Chill);
            ProgressBarTextBox.Text += " ◉";
            //  ◌ - сколько осталось итераций - реализовать позже
            second = 0;
            minute = 5;

            MinuteTextBox.Text = minute.ToString();
            SecondTextBox.Text = second.ToString();
        }

        private void WorkTime()
        {
            WorkColour();
            this.Alert("Время работать", Form_Alert.enmType.Work);
            ProgressBarTextBox.Text += " ○";

            second = firstInputSecond;
            minute = firstInputMinute;

            MinuteTextBox.Text = minute.ToString();
            SecondTextBox.Text = second.ToString();
        }

        private void BigChill()
        {
            BigChillColour();
            ProgressBarTextBox.Text += " ◉";
            this.Alert("Время развеятся", Form_Alert.enmType.BigChill);

            second = 0;
            minute = 35;

            MinuteTextBox.Text = minute.ToString();
            SecondTextBox.Text = second.ToString();
        }

        private void Switcher(int switchCycle)
        {
            if (switchCycle % 2 == 0)
            {
                WorkTime();
            }
            if (switchCycle % 9 == 0)
            {
                BigChill();
            }
            if ((switchCycle % 2 != 0) && (switchCycle % 9 != 0))
            {
                ChillTime();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            PauseButton.Text = ">";
            ProgressBarTextBox.Text = null;
            WorkColour();
            switchCycle = 2;
            SecondTextBox.Text = firstInputSecond.ToString();
            MinuteTextBox.Text = firstInputMinute.ToString();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (InfoTextBox.Visible == false)
            {
                InfoTextBox.Visible = true;
                ProgressBarTextBox.Visible = false;
            }
            else
            {
                InfoTextBox.Visible = false;
                ProgressBarTextBox.Visible = true;
            }
        }

        // Themes of Application

        private void ChillColour()
        {
            this.BackColor = Color.LightGreen;
            SecondTextBox.BackColor = Color.LightGreen;
            MinuteTextBox.BackColor = Color.LightGreen;
            Divide.BackColor = Color.LightGreen;
            InfoTextBox.BackColor = Color.LightGreen;
            ProgressBarTextBox.BackColor = Color.LightGreen;
            CloseApplicationButton.BackColor = Color.LightGreen;
            PauseButton.BackColor = Color.LightGreen;
        }

        private void WorkColour()
        {
            this.BackColor = Color.Tomato;
            SecondTextBox.BackColor = Color.Tomato;
            MinuteTextBox.BackColor = Color.Tomato;
            Divide.BackColor = Color.Tomato;
            InfoTextBox.BackColor= Color.Tomato;
            ProgressBarTextBox.BackColor= Color.Tomato;
            CloseApplicationButton.BackColor = Color.Tomato;
            PauseButton.BackColor = Color.Tomato;
        }

        private void BigChillColour()
        {
            this.BackColor = Color.LightSkyBlue;
            SecondTextBox.BackColor = Color.LightSkyBlue;
            MinuteTextBox.BackColor = Color.LightSkyBlue;
            Divide.BackColor = Color.LightSkyBlue;
            InfoTextBox.BackColor = Color.LightSkyBlue;
            ProgressBarTextBox.BackColor = Color.LightSkyBlue;
            CloseApplicationButton.BackColor = Color.LightSkyBlue;
            PauseButton.BackColor = Color.LightSkyBlue;
        }

        // Drag Form Methods
        
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
