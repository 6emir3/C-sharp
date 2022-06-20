using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public string pol;
        public string opit;
        public string graphic;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelGod_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1950; i <= 2022; i++)
            {
                comboBoxGod.Items.Add(i);
            }
           
                
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            opit = radioButtonOpit3.Text;
        }

        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOchistit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonSohranit_Click(object sender, EventArgs e)
        {
            string file = "D:\\колледж\\КПиЯП-практика\\-----\\Задания\\task22\\task3\\file.txt";

            string text = $"Фамилия: {textFam.Text}\n" +
                $"Имя: {textName.Text}\n" +
                $"Отчество: {textOt.Text}\n" +
                $"Пол: {pol}\n" +
                $"Дата рождения: {comboBoxDay.SelectedItem} {comboBoxMes.SelectedItem} {comboBoxGod.SelectedItem}\n" +
                $"Место проживания: {comboBoxCity.SelectedItem}\n" +
                $"Адрес электронной почты: {textBoxAdres.Text}\n" +
                $"Мобильный телефон: {textPhone.Text}({comboBoxOper.SelectedItem})\n" +
                $"Опыт работы: {opit}\n" +
                $"Другие сведения:\n" +
                $"Наличие личного авто: {checkBoxDrogoe1.Checked}\n" +
                $"Водительское удостоверение: {checkBoxDrogoe2.Checked}\n" +
                $"Категория прав: A-{checkBoxA.Checked}, B-{checkBoxB.Checked}, C-{checkBoxC.Checked}, D-{checkBoxD.Checked}\n" +
                $"Объем заработной платы: от {numericUpDown1.Value} до {numericUpDown2.Value}\n" +
                $"Предпочитаемый график работы: {graphic}\n" +
                $"Краткое резюме:\n{textBoxKrat.Text}";

            File.WriteAllText(file, text);
        }

        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            pol = "Мужской";
        }

        private void radioButtonW_CheckedChanged(object sender, EventArgs e)
        {
            pol = "Женский";
        }

        private void radioButtonOpit1_CheckedChanged(object sender, EventArgs e)
        {
            opit = radioButtonOpit1.Text;
        }

        private void radioButtonOpit2_CheckedChanged(object sender, EventArgs e)
        {
            opit = radioButtonOpit2.Text;
        }

        private void radioButtonOpit4_CheckedChanged(object sender, EventArgs e)
        {
            opit = radioButtonOpit4.Text;
        }

        private void radioButtonOpit5_CheckedChanged(object sender, EventArgs e)
        {
            opit = radioButtonOpit5.Text;
        }

        private void radioButtonGr1_CheckedChanged(object sender, EventArgs e)
        {
            graphic = radioButtonGr1.Text;
        }

        private void radioButtonGr2_CheckedChanged(object sender, EventArgs e)
        {
            graphic = radioButtonGr2.Text;
        }

        private void radioButtonGr3_CheckedChanged(object sender, EventArgs e)
        {
            graphic = radioButtonGr3.Text;
        }

        private void radioButtonGr4_CheckedChanged(object sender, EventArgs e)
        {
            graphic = radioButtonGr4.Text;
        }
    }
}
