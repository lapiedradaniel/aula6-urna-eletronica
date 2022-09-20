using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero = "";
        Candidato alguem;
        Candidato[] lista = new Candidato[4];
        //int branco = 0, nulo = 0;

        private void insereCandidato()
        {
            alguem = new Candidato();
            alguem.Numero = 12;
            alguem.Nome = "Antonio Silva";
            alguem.Turma = "1° ADS ";
            alguem.Foto = "Antonio.jpg";
            lista[0] = alguem;

            alguem = new Candidato();
            alguem.Numero = 23;
            alguem.Nome = "Joana Lima";
            alguem.Turma = "1° ADS ";
            alguem.Foto = "Joana.jpg";
            lista[1] = alguem;

            alguem = new Candidato();
            alguem.Numero = 13;
            alguem.Nome = "Daniel Silva";
            alguem.Turma = "1° ADS ";
            alguem.Foto = "Daniel.jpg";
            lista[2] = alguem;

            alguem = new Candidato();
            alguem.Numero = 14;
            alguem.Nome = "Nilton Nakamura";
            alguem.Turma = "1° ADS ";
            alguem.Foto = "Nilton.jpg";
            lista[3] = alguem ;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtNum1.Enabled = false; // desabilita o campo de texto
            txtNum2.Enabled = false;
            btnConfirma.Enabled = false; // desabilita o botão confirma
            lblMensagem.Visible = false; // Panel ocultada
            insereCandidato();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Preenche("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preenche("1");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Preenche("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Preenche("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Preenche("6");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Preenche("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Preenche("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Preenche("8");
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            Preenche("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Preenche("10");
        }

        private void Preenche(string n)
        {
            if (numero.Length ==0 )
            {
                txtNum1.Text = n;
                numero += n; //numero=numero+n 

            }
            else
            {
                txtNum2.Text = n;
                numero += n; //numero=numero+n 
                for (int i=0; i<4; i++)
                {
                    if(Convert.ToInt32(numero)== lista[i].Numero)
                    {
                        lblCandidato.Text = lista[i].Nome;
                        lblTurma.Text = lista[i].Turma;
                        pxFoto.Image = Image.FromFile(@"C:\Users\Aluno\Documents\Nova pasta\" + lista[i].Foto);
                        lblMensagem.Visible =true;
                        btnConfirma.Enabled = true;
                        i = 3;

                    }
                    else
                    {
                        lblCandidato.Text = "Voto Nulo";

                    }
                    lblMensagem.Visible = true;
                    btnConfirma.Enabled = true;

                }



            }
            
            




        }
    }
}
