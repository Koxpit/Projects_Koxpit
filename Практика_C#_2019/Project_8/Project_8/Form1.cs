using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numBag = new int[5];
            int[] colTh = new int[10];
            double[] passangerMassBag = new double[5];
            int[] passColTH = new int[5];
            string path = @"F:\src\Project_8\File_Info.txt";
            try
            {
                BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.Default);
                for (int i = 1; i<=5; i++)
                {
                    bw.Write("Пассажир "+i+Environment.NewLine);
                    for (int j = 1; j<=5; j++)
                    {
                        DialogResult result1 = MessageBox.Show(j+"?"+Environment.NewLine+"Максимум: 5", "Пассажир "+i+" Номер багажа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1==DialogResult.Yes)
                        {
                            bw.Write("Номер багажа "+Convert.ToInt32("0")+j+Environment.NewLine);
                            numBag[j]=j;
                            break;
                        }
                    }
                    for (double j = 0.5; j<=2.5; j+=0.5)
                    {
                        DialogResult result2 = MessageBox.Show(j+"?"+Environment.NewLine+"Максимум: 2.5кг", "Пассажир "+i+" Вес багажа(кг)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result2==DialogResult.Yes)
                        {
                            bw.Write("Вес багажа(кг) "+j+Environment.NewLine);
                            switch (j)
                            {
                                case 0.5:
                                    passangerMassBag[i-1]=j;
                                    break;
                                case 1:
                                    passangerMassBag[i-1]=j;
                                    break;
                                case 1.5:
                                    passangerMassBag[i-1]=j;
                                    break;
                                case 2:
                                    passangerMassBag[i-1]=j;
                                    break;
                                case 2.5:
                                    passangerMassBag[i-1]=j;
                                    break;
                            }
                            break;
                        }
                    }
                    for (int j = 1; j<=10; j++)
                    {
                        DialogResult result3 = MessageBox.Show(j+"?"+Environment.NewLine+"Максимум: 10", "Пассажир "+i+" Количество вещей", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result3==DialogResult.Yes)
                        {
                            bw.Write("Количество вещей "+j+Environment.NewLine);
                            colTh[j]=j;
                            passColTH[i-1]=colTh[j];
                            break;
                        }
                    }
                    bw.Write(Environment.NewLine);
                }

                Boolean res = false;
                for (int j = 0; j<=4; j++)
                {
                    for (int k = j+1; k<=4; k++)
                    {
                        if (numBag[j]==numBag[k])
                        {
                            res=true;
                        }
                        if (res==true) break;
                    }
                    if (res==true)
                    {
                        bw.Write("Ошибка: багажи имеют одинаковый номер."+Environment.NewLine);
                        break;
                    }
                }
                res=false;
                int sumPasMore2 = 0;
                int sumPasMoreSR = 0;
                double srValTH = 0;

                for (int i = 0; i<colTh.Length; i++)
                {
                    srValTH+=colTh[i];
                    if (colTh[i]>2) sumPasMore2+=1;
                }
                srValTH/=colTh.Length;
                for (int i = 0; i<colTh.Length; i++)
                    if (colTh[i]>srValTH) sumPasMoreSR+=1;

                bw.Write("Число пассажиров, имеющих более 2-х вещей: "+sumPasMore2+Environment.NewLine);
                bw.Write("Число пассажиров, количество вещей которых превосходит среднее число вещей: "+(sumPasMoreSR-1)+Environment.NewLine);

                for (int i = 0; i<5; i++)
                {
                    for (int j = i+1; j<5; j++)
                    {
                        if ((passColTH[i]==passColTH[j])&&(((passangerMassBag[i]-passangerMassBag[j]<=0.5)&&(passangerMassBag[i]-passangerMassBag[j]>=0))||((passangerMassBag[j]-passangerMassBag[i]<=0.5)&&(passangerMassBag[j]-passangerMassBag[i]>=0))))
                        {
                            bw.Write("Имеются два пассажира с одинкоавым количеством вещей и различие в весе не более чем 0.5кг");
                            res=true;
                        }
                        if (res==true) break;
                    }
                    if (res==true) break;
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show("Ошибка записи в файл. Вероятно его не существует.");
            }
        }
    }
}
