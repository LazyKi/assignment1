using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 从文本框中获取输入的数字
                double num1 = double.Parse(textBoxNum1.Text);
                double num2 = double.Parse(textBoxNum2.Text);

                // 根据所选择的运算符执行相应的运算
                double result = 0;
                switch (operatorComboBox.SelectedItem.ToString())
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("除数不能为0！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                // 显示结果
                resultLabel.Text = "结果：" + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入有效的数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            operatorComboBox.Items.Clear();
            //清除之前产生的四则运算，防止冗余出现
            operatorComboBox.Items.Add("+");
            operatorComboBox.Items.Add("-");
            operatorComboBox.Items.Add("*");
            operatorComboBox.Items.Add("/");
            // 设置默认选项为 "+"
            operatorComboBox.SelectedItem = "+";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
