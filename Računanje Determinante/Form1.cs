using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Računanje_Determinante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSize.SelectedIndex = 0;
            IzracunajDetMatrice();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (cbSize.SelectedIndex <= -1)
                return;

            var redMatrice = cbSize.SelectedIndex + 2;
            NacrtajMatricu(redMatrice);
        }

        public void NacrtajMatricu(int redMatrice)
        {
            var sirina = 70;
            var visina = 55;

            for (var j = 0; j < redMatrice; j++)
            {
                for (var i = 0; i < redMatrice; i++)
                {
                    var txt = new TextBox
                    {
                        Text = "" + Convert.ToByte(i == j),
                        Name = "txt" + i + j,
                        Location = new System.Drawing.Point(i * sirina + 10, j * visina + 10),
                        Size = new System.Drawing.Size(sirina - 5, visina - 5),
                        Font = new Font(DefaultFont.FontFamily, 15),
                        TextAlign = HorizontalAlignment.Center
                    };
                    panel1.Controls.Add(txt);
                }
            }
            panel1.Size = new Size(redMatrice * sirina + 20, redMatrice * visina);
            panel1.Location = new Point((panelKontener.Width - panel1.Size.Width) / 2, (panelKontener.Height - panel1.Size.Height) / 2);
        }

        public float[,] UcitajMatricu()
        {
            if (cbSize.SelectedIndex <= -1)
                return null;

            var size = cbSize.SelectedIndex + 2;
            var matrica = new float[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var txt = (TextBox)panel1.Controls.Find("txt" + i + j, false)[0];
                    var val = 0f;
                    try
                    {
                        val = float.Parse(txt.Text.Replace('.', ','));
                    }
                    finally
                    {
                        matrica[i, j] = val;
                    }
                }
            }
            return matrica;
        }

        public float Det2x2Matrica(float[,] matrica)
        {
            return matrica[0, 0] * matrica[1, 1] - matrica[1, 0] * matrica[0, 1];
        }


        public float IzracunajDeterminantuMatriceVisegStupnja(float[,] matrica)
        {
            var size = (int)Math.Sqrt(matrica.Length);

            if (size == 2)
                return Det2x2Matrica(matrica);

            var det = 0f;
            var col = size - 1;
            for (var row = 0; row < size; row++)
            {
                var subMatrica = new float[size - 1, size - 1];
                var sub_i = 0;

                for (var i = 0; i < size; i++)
                {
                    for (var j = 0; j < size - 1; j++)
                        if (i != row)
                            subMatrica[sub_i, j] = matrica[i, j];
                    sub_i = i != row ? sub_i + 1 : sub_i;
                }

                // '+' ILI '-'
                var predznak = (-(row % 2) | 1) * (-(col % 2) | 1);
                det += (predznak * matrica[row, col]) * IzracunajDeterminantuMatriceVisegStupnja(subMatrica);
            }

            return det;
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            IzracunajDetMatrice();
        }

        public void IzracunajDetMatrice()
        {
            var matrica = UcitajMatricu();
            if (matrica == null)
            {
                MessageBox.Show("Dogodila se greška. \nMolim provjerite je li unos ispravan.");
                return;
            }
            var det = IzracunajDeterminantuMatriceVisegStupnja(matrica);
            lblDeterminanta.Text = "det [A]: " + det + "";
            lblTipDeterminante.Text = "Matrica je: " +
                                      (det == 0 ? "singularna" : "regularna");
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://kraljic.xyz");
        }
    }
}
