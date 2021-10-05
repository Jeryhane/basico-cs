using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0.0, n2 = 0.0, res = 0.0;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);

            MessageBox.Show("Propriedade SelectedItem" + cboOperacoes.SelectedItem);
            MessageBox.Show("Propriedade SelectedIndex" + cboOperacoes.SelectedIndex);

            switch (cboOperacoes.SelectedIndex)
            {
                case 0:
                    res = n1 + n2;
                    MessageBox.Show(res.ToString());
                    break;

                case 1:
                    res = n1 - n2;
                    MessageBox.Show(res.ToString());
                    break;

                case 2:
                    res = n1 * n2;
                    MessageBox.Show(res.ToString());
                    break;

                case 3:
                    
                    if (n2 == 0)
                    {
                        MessageBox.Show("Tá loca fia?!");
                        txtN1.Select();//focar na caixa de texto txtN1
                    } else
                    {
                        res = n1 / n2;
                        MessageBox.Show(res.ToString());
                    }
                    break;

                default:
                    MessageBox.Show("Nenhhuma operação selecionada fia!");
                    break;
            }
        }
    }
}
