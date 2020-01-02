using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Interop.PowerPoint;
using System.Threading;

namespace SlideShow
{
    public partial class Form1 : Form
    {
        private Галерея gallery;
        private WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private string dirPath;
        private string pathPPTX;
        private string fMusPath = null;
        private int current;
        public int Current { get { return current; } }
        private string[] imgJpg = null, imgPng = null, imgJpeg = null;
        private List<string> images;
        public List<string> Images { get { return images; } set { images = value; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelNext.BackColor=Color.Transparent;
            LabelPrev.BackColor=Color.Transparent;
            labelNext.Enabled=false;
            LabelPrev.Enabled=false;
            animationButton.Enabled=false;

            checkStartBegin.Checked=true;
            aroundShow.Checked=false;

            SecInterval.SelectedIndex=0;
        }

        // Загрузка изображений
        private void LoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = folderBrowserDialog1.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    images = new List<string>();
                    dirPath=folderBrowserDialog1.SelectedPath;

                    imgJpg = Directory.GetFiles(dirPath, "*jpg", SearchOption.AllDirectories);
                    imgJpeg = Directory.GetFiles(dirPath, "*jpeg", SearchOption.AllDirectories);
                    imgPng = Directory.GetFiles(dirPath, "*png", SearchOption.AllDirectories);


                    if (imgJpg!=null) { images.AddRange(imgJpg); }
                    if (imgJpeg!=null) { images.AddRange(imgJpeg); }
                    if (imgPng!=null) { images.AddRange(imgPng); }

                    if (images.Count!=0)
                    {
                        current=0;
                        pictureBox1.ImageLocation=images[current];

                        labelNext.Enabled=true;
                        LabelPrev.Enabled=false;
                        ShowSlide.Enabled=true;
                        button1.Enabled=true;
                        galleryButton.Enabled=true;

                        trackBar1.Enabled=true;
                        trackBar1.Minimum=0;
                        trackBar1.Maximum=images.Count-1;
                        trackBar1.BackColor=Color.FromArgb(185, 209, 234);
                    }
                    else
                    {
                        ShowSlide.Enabled=false;
                        galleryButton.Enabled=false;
                        button1.Enabled=false;
                        pictureBox1.Image=null;
                        labelNext.Enabled=false;
                        trackBar1.Enabled=false;
                        MessageBox.Show("Папка не содержала фотографий, выберите другую!");
                    }
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Запуск слайд шоу
        private void ShowSlide_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowSlide.Text=="Старт")
                {
                    if (images==null)
                    {
                        MessageBox.Show("Добавте изображения!");
                    }
                    else
                    {
                        labelNext.Enabled=false;
                        labelNext.Visible=false;
                        LabelPrev.Enabled=false;
                        LabelPrev.Visible=false;
                        SecInterval.Enabled=false;
                        LoadImage.Enabled=false;
                        LoadMusic.Enabled=false;
                        checkStartBegin.Enabled=false;
                        aroundShow.Enabled=false;
                        animationButton.Enabled=true;

                        if (checkStartBegin.Checked==true)
                            current=0;
                        else current=trackBar1.Value;

                        trackBar1.Enabled=false;
                        ShowSlide.Text="Стоп";
                        timer1.Interval=int.Parse(SecInterval.Text)*1000;
                        WMP.settings.setMode("loop", true);
                        WMP.URL=fMusPath;
                        timer1.Start();
                        WMP.controls.play();
                    }
                }
                else
                {
                    labelNext.Enabled=true;
                    labelNext.Visible=true;
                    LabelPrev.Enabled=true;
                    LabelPrev.Visible=true;
                    SecInterval.Enabled=true;
                    LoadImage.Enabled=true;
                    LoadMusic.Enabled=true;
                    checkStartBegin.Enabled=true;
                    aroundShow.Enabled=true;
                    animationButton.Enabled=false;

                    trackBar1.Enabled=true;
                    timer1.Stop();
                    WMP.controls.stop();
                    ShowSlide.Text="Старт";
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LabelPrev_Click(object sender, EventArgs e)
        {
            PrevImage();
        }

        // Загрузка музыки
        private void LoadMusic_Click(object sender, EventArgs e)
        {
            try
            {
                WMP.close();
                OpenFileDialog dr = new OpenFileDialog()
                {
                    Filter = "(*.mp3)|*.mp3"
                };
                if (dr.ShowDialog() == DialogResult.OK)
                    fMusPath=dr.FileName;
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        // Открывает галерею загруженных картинок
        private void galleryButton_Click(object sender, EventArgs e)
        {
            try
            {
                gallery = new Галерея();

                if (images!=null)
                {
                    gallery.DirName=dirPath;


                    gallery.Imgs=images;

                    for (int i = 0; i < images.Count; i++)
                        gallery.listBox1.Items.Add(Path.GetFileName(images[i]));

                    gallery.pictureBox1.ImageLocation = gallery.Imgs[0];
                }

                gallery.ShowDialog();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // При каждом тике листает к следующему изображению
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextImage();
        }

        // Запускает слайд шоу на весь экран
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (images!=null)
                {
                    Показ_слайдов form = new Показ_слайдов();
                    form.BackColor=Color.Black;
                    form.Img=images;
                    form.Current=current;

                    if (aroundShow.Checked==true)
                        form.around=true;
                    else
                        form.around=false;

                    if (checkStartBegin.Checked==true)
                    {
                        form.Current=0;
                        form.pictureBox1.ImageLocation=form.Img[current];
                    }
                    else
                    {
                        form.Current=current;
                        form.pictureBox1.ImageLocation=form.Img[current];
                    }

                    form.Interval=int.Parse(SecInterval.Text);
                    form.Show();
                }
                else { MessageBox.Show("Добавьте изображениия!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void labelNext_MouseMove(object sender, MouseEventArgs e)
        {
            labelNext.ForeColor=Color.Black;
        }

        private void LabelPrev_MouseMove(object sender, MouseEventArgs e)
        {
            LabelPrev.ForeColor=Color.Black;
        }

        private void labelNext_MouseLeave(object sender, EventArgs e)
        {
            labelNext.ForeColor=Color.FromArgb(160, 160, 160);
        }

        private void LabelPrev_MouseLeave(object sender, EventArgs e)
        {
            LabelPrev.ForeColor=Color.FromArgb(160, 160, 160);
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // Листает к следующему изображению
        private void NextImage()
        {
            try
            {
                if (images!=null || images.Count!=0)
                {
                    if (current+1 < images.Count)
                    {
                        labelNext.Enabled=true;
                        LabelPrev.Enabled=true;
                        current++;
                        trackBar1.Value=current;
                        pictureBox1.ImageLocation=images[current];
                    }
                    else if (current+1 == images.Count)
                    {
                        if (aroundShow.Checked==true)
                        {
                            labelNext.Enabled=true;
                            LabelPrev.Enabled=false;
                            current = 0;
                            trackBar1.Value=current;
                            pictureBox1.ImageLocation=images[current];
                        }
                        else
                        {
                            labelNext.Enabled=false;
                            trackBar1.Value=current;
                            LabelPrev.Enabled=true;
                            WMP.controls.stop();
                            timer1.Stop();
                            ShowSlide.Text="Старт";
                        }
                    }
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Листает к предыдущему изображению
        private void PrevImage()
        {
            try
            {
                if (images!=null || images.Count!=0)
                {
                    if (current-1 >= 0)
                    {
                        LabelPrev.Enabled=true;
                        current--;
                        trackBar1.Value=current;
                        if (current == 0)
                            LabelPrev.Enabled=false;
                        pictureBox1.ImageLocation=images[current];
                    }
                    else
                        LabelPrev.Enabled=false;
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                current=trackBar1.Value;
                if (trackBar1.Value==0)
                    LabelPrev.Enabled=false;
                else LabelPrev.Enabled=true;
                /* if (trackBar1.Value==images.Count)
                     labelNext.Enabled=false;
                 else labelNext.Enabled=true;*/
                pictureBox1.ImageLocation=images[trackBar1.Value];
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void удалитьСлайдToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void animationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (animationButton.Text=="Пауза")
                {
                    animationButton.Text="Продолжить";
                    WMP.controls.pause();
                    ShowSlide.Enabled=false;
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                    ShowSlide.Enabled=true;
                    ShowSlide.Text="Стоп";
                    animationButton.Text="Пауза";
                    WMP.controls.play();
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Печать текущего изображения
        public void Print()
        {
            if (images!=null)
            {
                if (images.Count!=0)
                {
                    try
                    {
                        System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
                        Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
                        DialogResult result = printDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Document.Print();
                        }
                    } catch(Exception ex) { MessageBox.Show(ex.Message); }
                } else { MessageBox.Show("Добавьте изображение!"); }
            } else { MessageBox.Show("Добавьте изображение!"); }
        }

        private void загрузитьПрезентациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(images[current]), e.PageBounds); //Картинка на печать
        }

        private void сохранитьВJPGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PPTXtoImg();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPPTX();
        }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // Сохраняет презентацию в отдельные картинки
        private void PPTXtoImg()
        {
            string str1 = null;
            string str = null;

            try
            {
                DialogResult dr = folderBrowserDialog1.ShowDialog();
                if (dr!=DialogResult.Cancel)
                {
                    str1 = folderBrowserDialog1.SelectedPath;

                    OpenFileDialog path = new OpenFileDialog()
                    {
                        Filter = "(*.pptx)|*.pptx"
                    };

                    if (path.ShowDialog() == DialogResult.OK)
                    {
                        str=path.FileName;

                        PowerPoint.Application pptApplication = new PowerPoint.Application();
                        Presentation pptPresentation = pptApplication.Presentations.Open(str, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
                        pptPresentation.SaveAs(str1, PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoFalse);
                        pptPresentation.Close();

                        MessageBox.Show("Сохранение завершено!");
                    }
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Загружает и выводит на экран готовую презентацию выбранную пользователем
        private void LoadPPTX()
        {
            try
            {
                OpenFileDialog dr = new OpenFileDialog()
                {
                    Filter = "(*.pptx)|*.pptx"
                };
                if (dr.ShowDialog() == DialogResult.OK) {
                    pathPPTX=dr.FileName;

                    PowerPoint.Application ppApp = new PowerPoint.Application();
                    ppApp.Visible = MsoTriState.msoTrue;
                    Presentations ppPresens = ppApp.Presentations; Presentation objPres = ppPresens.Open(pathPPTX, MsoTriState.msoFalse, MsoTriState.msoTrue, MsoTriState.msoTrue);
                    Slides objSlides = objPres.Slides;
                    SlideShowWindows objSSWs; SlideShowSettings objSSS;
                    objSSS = objPres.SlideShowSettings;
                    objSSS.Run();
                    objSSWs = ppApp.SlideShowWindows;
                    ppApp.Quit();
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
