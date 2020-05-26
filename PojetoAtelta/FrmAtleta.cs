using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoAtelta
{
    public partial class FrmAtleta : Form
    {
        public FrmAtleta()
        {
            InitializeComponent();
        }

        Atleta objeto = new Atleta();

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.Nome = txt_nome.Text;
                objeto.Altura = double.Parse(txt_altura.Text);
                objeto.Peso = double.Parse(txt_peso.Text);
                objeto.Idade = int.Parse(txt_idade.Text);
                MessageBox.Show("\n\nNome: " + objeto.Nome + "\n\nAltura: " + objeto.Altura.ToString("0.00") + "\n\nPeso: " + objeto.Peso + " kg" + "\n\nIdade: " + objeto.Idade + " anos" + "\n\nIMC: " + objeto.Calcular_IMC().ToString("0.00"));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. Valor inválido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
