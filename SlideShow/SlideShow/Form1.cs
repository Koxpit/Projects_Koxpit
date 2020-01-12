using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Interop.PowerPoint;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace SlideShow
{
    public partial class Form1 : Form
    {
        private Галерея galleryForm;
        private WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private string dirPath;
        private string pptxPath;
        private string musPath = null;
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
            labelNext.BackColor = Color.Transparent;
            LabelPrev.BackColor = Color.Transparent;
            labelNext.Enabled = false;
            LabelPrev.Enabled = false;
            PauseButton.Enabled = false;

            checkStartBegin.Checked = true;
            aroundShowCheckBox.Checked = false;

            SecIntervalComboBox.SelectedIndex = 0;
        }

        // Загрузка изображений
        private void LoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if(isOpenFolder())
                {
                    SetImagesToImgList();

                    if (images.Count != 0)
                    {
                        current = 0;
                        pictureBox.ImageLocation = images[current];

                        labelNext.Enabled = true;
                        LabelPrev.Enabled = false;
                        ShowSlideButton.Enabled = true;
                        ShowOnAllScreenButton.Enabled = true;
                        galleryButton.Enabled = true;

                        trackBar.Enabled = true;
                        trackBar.Minimum = 0;
                        trackBar.Maximum = images.Count-1;
                        trackBar.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    else
                    {
                        ShowSlideButton.Enabled = false;
                        galleryButton.Enabled = false;
                        ShowOnAllScreenButton.Enabled = false;
                        pictureBox.Image = null;
                        labelNext.Enabled = false;
                        trackBar.Enabled = false;
                        MessageBox.Show("Папка не содержала фотографий, выберите другую!");
                    }
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool isOpenFolder()
        {
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                dirPath = folderBrowserDialog.SelectedPath;
                return true;
            }

            return false;
        }

        private void SetImagesToImgList()
        {
            images = new List<string>();

            imgJpg = Directory.GetFiles(dirPath, "*jpg", SearchOption.AllDirectories);
            imgJpeg = Directory.GetFiles(dirPath, "*jpeg", SearchOption.AllDirectories);
            imgPng = Directory.GetFiles(dirPath, "*png", SearchOption.AllDirectories);


            if (imgJpg != null) { images.AddRange(imgJpg); }
            if (imgJpeg != null) { images.AddRange(imgJpeg); }
            if (imgPng != null) { images.AddRange(imgPng); }
        }

        // Извлекает картинки из презентации
        private async void сохранитьВJPGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isOpenFolder() && isOpenFile(FormatsFile.PPTX))
                await Task.Run(() => SavePresentationAsIMGs(dirPath, pptxPath));
        }

        private bool isOpenFile(FormatsFile formatFile)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                switch (formatFile)
                {
                    case FormatsFile.MP3:
                        WMP.close();
                        dialog = new OpenFileDialog()
                        {
                            Filter = "(*.mp3)|*.mp3"
                        };
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            musPath = dialog.FileName;
                            return true;
                        }
                        break;
                    case FormatsFile.PPTX:
                        dialog = new OpenFileDialog()
                        {
                            Filter = "(*.pptx)|*.pptx"
                        };
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            pptxPath = dialog.FileName;
                            return true;
                        }
                        break;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void SavePresentationAsIMGs(string folderForImages, string pptxFile)
        {
            PowerPoint.Application pptxApplication = new PowerPoint.Application();
            Presentation pptxPresentation = pptxApplication.Presentations.Open(pptxFile,
                MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
            pptxPresentation.SaveAs(folderForImages,
                PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoFalse);
            pptxPresentation.Close();

            MessageBox.Show("Сохранение завершено!");
        }

        // Запуск слайд шоу
        private void ShowSlide_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowSlideButton.Text == "Старт")
                {
                    if (images == null)
                    {
                        MessageBox.Show("Добавте изображения!");
                    }
                    else
                    {
                        labelNext.Enabled = false;
                        labelNext.Visible = false;
                        LabelPrev.Enabled = false;
                        LabelPrev.Visible = false;
                        SecIntervalComboBox.Enabled = false;
                        LoadImage.Enabled = false;
                        LoadMusic.Enabled = false;
                        checkStartBegin.Enabled = false;
                        aroundShowCheckBox.Enabled = false;
                        PauseButton.Enabled = true;

                        SetCurrentValue();

                        trackBar.Enabled = false;
                        ShowSlideButton.Text = "Стоп";
                        timer.Interval = int.Parse(SecIntervalComboBox.Text) * 1000;
                        WMP.settings.setMode("loop", true);
                        WMP.URL = musPath;
                        timer.Start();
                        WMP.controls.play();
                    }
                }
                else
                {
                    labelNext.Enabled = true;
                    labelNext.Visible = true;
                    LabelPrev.Enabled = true;
                    LabelPrev.Visible = true;
                    SecIntervalComboBox.Enabled = true;
                    LoadImage.Enabled = true;
                    LoadMusic.Enabled = true;
                    checkStartBegin.Enabled = true;
                    aroundShowCheckBox.Enabled = true;
                    PauseButton.Enabled = false;
                    trackBar.Enabled = true;
                    timer.Stop();
                    WMP.controls.stop();
                    ShowSlideButton.Text = "Старт";
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SetCurrentValue()
        {
            if (checkStartBegin.Checked == true)
                current = 0;
            else current = trackBar.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextImage();
        }

        // Листает к следующему изображению
        private void NextImage()
        {
            try
            {
                if (images != null || images.Count != 0)
                {
                    if (current + 1 < images.Count)
                    {
                        labelNext.Enabled = true;
                        LabelPrev.Enabled = true;
                        current++;
                        trackBar.Value = current;
                        pictureBox.ImageLocation = images[current];
                    }
                    else if (current + 1 == images.Count)
                    {
                        if (aroundShowCheckBox.Checked == true)
                        {
                            labelNext.Enabled = true;
                            LabelPrev.Enabled = false;
                            current = 0;
                            trackBar.Value = current;
                            pictureBox.ImageLocation = images[current];
                        }
                        else
                        {
                            labelNext.Enabled = false;
                            trackBar.Value = current;
                            LabelPrev.Enabled = true;
                            WMP.controls.stop();
                            timer.Stop();
                            ShowSlideButton.Text = "Старт";
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void LabelPrev_Click(object sender, EventArgs e)
        {
            PrevImage();
        }

        // Листает к предыдущему изображению
        private void PrevImage()
        {
            try
            {
                if (images != null || images.Count != 0)
                {
                    if (current - 1 >= 0)
                    {
                        LabelPrev.Enabled = true;
                        current--;
                        trackBar.Value = current;
                        if (current == 0)
                            LabelPrev.Enabled = false;
                        pictureBox.ImageLocation = images[current];
                    }
                    else
                        LabelPrev.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Загрузка музыки
        private void LoadMusic_Click(object sender, EventArgs e)
        {
            isOpenFile(FormatsFile.MP3);
        }

        // Открывает галерею
        private void galleryButton_Click(object sender, EventArgs e)
        {
            try
            {
                galleryForm = new Галерея();

                if (images != null)
                {
                    galleryForm.DirName = dirPath;
                    galleryForm.Imgs = images;

                    for (int i = 0; i < images.Count; i++)
                        galleryForm.listBox1.Items.Add(Path.GetFileName(images[i]));

                    galleryForm.pictureBox1.ImageLocation = galleryForm.Imgs[0];
                }
                galleryForm.ShowDialog();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Загружает и выводит на экран выбранную презентацию
        private async void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOpenFile(FormatsFile.PPTX))
                    await Task.Run(() => OpenPPTXPresentation());
                else
                    return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void OpenPPTXPresentation()
        {
            PowerPoint.Application pptxApplicatoin = new PowerPoint.Application();
            pptxApplicatoin.Visible = MsoTriState.msoTrue;
            Presentations pptxPresentations = pptxApplicatoin.Presentations;
            Presentation presentation = pptxPresentations.Open(pptxPath,
                MsoTriState.msoFalse, MsoTriState.msoTrue, MsoTriState.msoTrue);
            Slides objSlides = presentation.Slides;
            SlideShowWindows SSWindows;
            SlideShowSettings objSSS;
            objSSS = presentation.SlideShowSettings;
            objSSS.Run();
            SSWindows = pptxApplicatoin.SlideShowWindows;
            pptxApplicatoin.Quit();
        }

        private void animationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PauseButton.Text == "Пауза")
                {
                    PauseButton.Text = "Продолжить";
                    WMP.controls.pause();
                    ShowSlideButton.Enabled = false;
                    timer.Stop();
                }
                else
                {
                    timer.Start();
                    ShowSlideButton.Enabled = true;
                    ShowSlideButton.Text = "Стоп";
                    PauseButton.Text = "Пауза";
                    WMP.controls.play();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Запускает слайд шоу на весь экран
        private void ShowOnAllScreenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (images!=null)
                {
                    Показ_слайдов form = new Показ_слайдов();
                    form.BackColor = Color.Black;
                    form.Img = images;
                    form.Current = current;

                    if (aroundShowCheckBox.Checked == true)
                        form.around = true;
                    else
                        form.around = false;

                    if (checkStartBegin.Checked == true)
                    {
                        form.Current = 0;
                        form.pictureBox1.ImageLocation = form.Img[current];
                    }
                    else
                    {
                        form.Current = current;
                        form.pictureBox1.ImageLocation = form.Img[current];
                    }

                    form.Interval = int.Parse(SecIntervalComboBox.Text);
                    form.Show();
                }
                else { MessageBox.Show("Добавьте изображениия!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                current = trackBar.Value;
                if (trackBar.Value == 0)
                    LabelPrev.Enabled = false;
                else
                    LabelPrev.Enabled = true;

                pictureBox.ImageLocation = images[trackBar.Value];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Печать текущего изображения
        private async void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Print());
        }

        public void Print()
        {
            if (images != null)
            {
                if (images.Count != 0)
                {
                    try
                    {
                        PrintDocument Document = new PrintDocument();
                        Document.PrintPage += new PrintPageEventHandler(Document_PrintPage);

                        DialogResult result = printDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Document.Print();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("Добавьте изображение!"); }
            }
            else { MessageBox.Show("Добавьте изображение!"); }
        }

        void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(images[current]), e.PageBounds);
        }


        private void labelNext_MouseMove(object sender, MouseEventArgs e)
        {
            labelNext.ForeColor = Color.Black;
        }

        private void LabelPrev_MouseMove(object sender, MouseEventArgs e)
        {
            LabelPrev.ForeColor = Color.Black;
        }

        private void labelNext_MouseLeave(object sender, EventArgs e)
        {
            labelNext.ForeColor = Color.FromArgb(160, 160, 160);
        }

        private void LabelPrev_MouseLeave(object sender, EventArgs e)
        {
            LabelPrev.ForeColor = Color.FromArgb(160, 160, 160);
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

    public enum FormatsFile {
        PPTX,
        MP3
    }
}
