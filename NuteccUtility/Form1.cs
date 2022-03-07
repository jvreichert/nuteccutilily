using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
//using System.Windows.Forms.DataVisualization.Charting;

namespace NuteccUtility
{
    public partial class frmnuteccutility : Form
    {
        public frmnuteccutility()
        {
            InitializeComponent();
        }

        private void btnOpenTxt_Click(object sender, EventArgs e)
        {
            var ofdfc = new OpenFileDialog();

            int count = 0;
            string line;
            double somaFc = 0;
            double temp = 0;
            double media = 0;
            double variancia = 0;
            double dp = 0;
            string diretorio = "";

            //Criando listas para armazenar frequencia cardiaca, desvio, quadrado do desvio
            List<double> vetvfc = new List<double>();
            List<double> desvio = new List<double>();
            List<double> qdesvio = new List<double>();

            //Open File Dialog para abrir o arquivo txt a ser lido
            ofdfc.Filter = "Text Files|*.txt";
            ofdfc.Title = "Selecione o Arquivo da FC";

            //Abrindo o File dialog para ler o arquivo txt
            if (ofdfc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                diretorio = ofdfc.FileName;


                //Armazenando todo o arquivo txt lido no objeto StreamReader file
                System.IO.StreamReader file = new System.IO.StreamReader(@diretorio);

                chartFC.DataSource = new List<int>();
                chartFC.Series.Clear();
                chartFC.Series.Add("FC");
                chartFC.Series["FC"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                //Carregando a lista e a list box(grafica) com a frequencia cardiaca lida
                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        listBox1.Items.Add(line);
                        //Somando todas as frequencias cardiacas
                        somaFc += Double.Parse(line.ToString());
                        vetvfc.Add(Double.Parse(line.ToString()));
                        count++;

                    }
                }
                //Calculando a média das frequencias cardiacas lidas e armazenadas
                media = somaFc / count;

                lblGini.Text = String.Format("{0:0.0000}", CalculaGini(vetvfc));

                chartFC.ChartAreas[0].AxisY.Minimum = vetvfc.Min() - 20;
                chartFC.ChartAreas[0].AxisY.Maximum = vetvfc.Max() + 20;


                //Calculando o Desvio e o quadrado do desvio para então chegar no desvio padrão
                for (int i = 0; i < count; i++)
                {
                    desvio.Add(vetvfc[i] - media);
                    qdesvio.Add(Math.Pow(desvio[i], 2));
                    listBox2.Items.Add(desvio[i]);
                    listBox3.Items.Add(qdesvio[i]);

                    chartFC.Series["FC"].Points.AddXY(i + 1, Convert.ToInt32(vetvfc[i]));
                }

                //Calculando a variancia
                for (int i = 0; i < count; i++)
                {
                    temp = temp + qdesvio[i];
                }
                variancia = temp / count;

                //Calculando e mostrando o Desvio Padrão(SDNN)
                dp = Math.Sqrt(variancia);
                lblsdnn.Text = dp.ToString();

                //Calculando a variavel RMSSD
                double somatorio = 0;
                double resrmssd = 0;
                for (int i = 0; i < vetvfc.Count - 1; i++)
                {
                    somatorio += Math.Pow((vetvfc[i + 1] - vetvfc[i]), 2);
                }
                //  MessageBox.Show(somatorio.ToString());

                resrmssd = somatorio / (count - 1);
                //    MessageBox.Show(resrmssd.ToString());
                lblrmssd.Text = Math.Sqrt(resrmssd).ToString();
                //Calcula SD1 SD2
                //Calcula D(min) e SD1


                double somatdmin = 0;
                for (int i = 0; i < vetvfc.Count - 1; i++)
                {
                    somatdmin += Math.Pow((vetvfc[i + 1] - vetvfc[i]) / Math.Sqrt(2), 2);
                }

                lblsd1.Text = Math.Sqrt(somatdmin / (count - 1)).ToString();


                //calcula NN50
                double countnn = 0;
                for (int i = 0; i < vetvfc.Count - 1; i++)
                {
                    if ((vetvfc[i + 1] - vetvfc[i]) >= 50 || (vetvfc[i + 1] - vetvfc[i]) <= -50)
                    {
                        countnn++;
                    }
                }
                double result = (100.0 * countnn) / vetvfc.Count;
                Program.pnn50 = result;
                lblpnn50.Text = result.ToString() + "%";


                //Calcula a medida de tendencia Central

                List<double> codigo = new List<double>();
                List<double> draio = new List<double>();
                double somatoriodraio = 0;
                int raio = 5;
                for (int i = 0; i < vetvfc.Count - 2; i++)
                {
                    if ((Math.Pow(Math.Pow(vetvfc[i + 2] - vetvfc[i + 1], 2) + Math.Pow(vetvfc[i + 1] - vetvfc[i], 2), 0.5)) < raio)
                    {
                        draio.Add(1);
                    }
                    else
                        draio.Add(0);

                    somatoriodraio += draio[i];
                }

                lblmtc.Text = (somatoriodraio / (vetvfc.Count - 2)).ToString();

            }
            else
            {
                MessageBox.Show("Arquivo inválido");
            }
        }

        private double CalculaGini(List<double> list)
        {
            var listSort = list.OrderBy(d => d).ToList();
            var listSortArray = listSort.ToArray();

            var total = list.Count();

            var x1 = new List<double>()
            {
                0.02,
                0.18,
                0.3,
                0.5
            };

            var x2 = new List<double>()
            {
                  Percentile(listSortArray, x1[0]) + 0.1,
                  Percentile(listSortArray, x1[0] + x1[1]) + 0.1,
                  Percentile(listSortArray, x1[0] + x1[1] + x1[2]) + 0.1,
                  Percentile(listSortArray, x1[0] + x1[1] + x1[2]+ x1[3]),
            };

            var x3 = new List<double>()
            {
                listSort.Where(x => x <= x2[0]).Count(),
                listSort.Where(x => x > x2[0] && x < x2[1] - 0.1).Count(),
                listSort.Where(x => x >= x2[1] - 0.1 && x <= x2[2] - 0.1).Count(),
                listSort.Where(x => x > x2[2]).Count()
            };

            var x4 = new List<double>()
            {
                x3[0] / total,
                x3[1] / total,
                x3[2] / total,
                x3[3] / total
            };

            var x5 = new List<double>()
            {
                x4[0],
                x4[0] + x4[1],
                x4[0] + x4[1] + x4[2],
                x4[0] + x4[1] + x4[2] + x4[3],
            };

            var x6 = new List<double>()
            {
                1 - x5[0],
                1 - x5[1],
                1 - x5[2],
                1 - x5[3],
            };

            var x7 = new List<double>()
            {
                x1[0] * (x4[0] + 2 * x6[0]),
                x1[1] * (x4[1] + 2 * x6[1]),
                x1[2] * (x4[2] + 2 * x6[2]),
                x1[3] * (x4[3] + 2 * x6[3])
            };

            var somatorio = x7.Sum();

            //Grafico Gini

            chartGini.DataSource = new List<double>();
            chartGini.Series.Clear();
            chartGini.Series.Add("G");
            chartGini.Series.Add("G1");
            chartGini.Series["G"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartGini.Series["G1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chartGini.Series["G"].Points.AddXY(x4[0] * 10, 0.1);

            chartGini.Series["G"].Points.AddXY(x4[1] * 10, 0.18);

            chartGini.Series["G"].Points.AddXY(x4[2] * 10, 0.3);

            chartGini.Series["G"].Points.AddXY(x4[3] * 10, 0.5);

            chartGini.Series["G1"].Points.AddXY(x4[0] * 10, 0.1);
            chartGini.Series["G1"].Points.AddXY(x4[3] * 10, 0.5);

            //################

            return 1 - somatorio;
        }

        public double Percentile(double[] sequence, double excelPercentile)
        {
            Array.Sort(sequence);
            int N = sequence.Length;
            double n = (N - 1) * excelPercentile + 1;
            // Another method: double n = (N + 1) * excelPercentile;
            if (n == 1d) return sequence[0];
            else if (n == N) return sequence[N - 1];
            else
            {
                int k = (int)n;
                double d = n - k;
                return sequence[k - 1] + d * (sequence[k] - sequence[k - 1]);
            }
        }
    }
}
