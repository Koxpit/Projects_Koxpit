using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace SlideShow
{
    public partial class SlideShowForm : Form
    {
        private Галерея galleryForm;
        private WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private string dirPath, pptxPath, musPath = null;
        private string[] imgJpg = null, imgPng = null, imgJpeg = null;
        private int current;
        public int Current { get { return current; } }
        private List<string> images;
        public List<string> Images { get { return images; } set { images = value; } }

        public SlideShowForm()
        {
            InitializeComponent();
        }

        private void SlideShowForm_Load(object sender, EventArgs e)
        {
            labelNext.BackColor = Color.Transparent;
            LabelPrev.BackColor = Color.Transparent;
            SetPrevNextLabelsEnable(false, false);
            PauseButton.Enabled = false;
            checkStartBegin.Checked = true;
            aroundShowCheckBox.Checked = false;
            SecIntervalComboBox.SelectedIndex = 0;
        }

        private void SetPrevNextLabelsEnable(bool nextIsEnabled, bool prevIsEnabled)
        {
            labelNext.Enabled = nextIsEnabled;
            LabelPrev.Enabled = prevIsEnabled;
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

                        SetPrevNextLabelsEnable(true, false);
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
                        galleryButton.Enabled = false;
                        ShowSlideButton.Enabled = false;
                        ShowOnAllScreenButton.Enabled = false;
                        pictureBox.Image = null;
                        labelNext.Enabled = false;
                        trackBar.Enabled = false;
                        MessageBox.Show("Папка не содержала фотографий, выберите другую!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Загрузка музыки
        private void LoadMusic_Click(object sender, EventArgs e)
        {
            isOpenFile(FormatsFile.MP3);
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
            imgJpg = Directory.GetFiles(dirPath, "*jpg", SearchOption.AllDirectories);
            imgJpeg = Directory.GetFiles(dirPath, "*jpeg", SearchOption.AllDirectories);
            imgPng = Directory.GetFiles(dirPath, "*png", SearchOption.AllDirectories);

            images = new List<string>();

            if (imgJpg != null) { images.AddRange(imgJpg); }
            if (imgJpeg != null) { images.AddRange(imgJpeg); }
            if (imgPng != null) { images.AddRange(imgPng); }
        }

        // Извлекает картинки из презентации
        private async void сохранитьВJPGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isOpenFolder() && isOpenFile(FormatsFile.PPTX))
                await Task.Run(() => PowerPointWork.SavePresentationAsIMGs(dirPath, pptxPath));
        }

        private bool isOpenFile(FormatsFile formatFile)
        {
            try
            {
                OpenFileDialog dialog;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        // Запуск слайд шоу
        private void ShowSlide_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowSlideButton.Text == "Старт")
                {
                    if (images == null)
                        MessageBox.Show("Добавте изображения!");
                    else
                    {
                        SetPrevNextLabelsEnable(false, false); ;
                        labelNext.Visible = false;
                        LabelPrev.Visible = false;
                        SecIntervalComboBox.Enabled = false;
                        LoadImage.Enabled = false;
                        LoadMusic.Enabled = false;
                        checkStartBegin.Enabled = false;
                        aroundShowCheckBox.Enabled = false;
                        PauseButton.Enabled = true;
                        trackBar.Enabled = false;

                        SetCurrentValue();
                        timer.Interval = int.Parse(SecIntervalComboBox.Text) * 1000;
                        WMP.settings.setMode("loop", true);
                        WMP.URL = musPath;
                        WMP.controls.play();
                        timer.Start();
                        ShowSlideButton.Text = "Стоп";
                    }
                }
                else
                {
                    SetPrevNextLabelsEnable(true, true);
                    labelNext.Visible = true;
                    LabelPrev.Visible = true;
                    SecIntervalComboBox.Enabled = true;
                    LoadImage.Enabled = true;
                    LoadMusic.Enabled = true;
                    checkStartBegin.Enabled = true;
                    aroundShowCheckBox.Enabled = true;
                    PauseButton.Enabled = false;
                    trackBar.Enabled = true;

                    WMP.controls.stop();
                    timer.Stop();
                    ShowSlideButton.Text = "Старт";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCurrentValue()
        {
            if (checkStartBegin.Checked == true)
                current = 0;
            else current = trackBar.Value;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        current++;
                        SetPrevNextLabelsEnable(true, true);
                        trackBar.Value = current;
                        pictureBox.ImageLocation = images[current];
                    }
                    else if (current + 1 == images.Count)
                    {
                        if (aroundShowCheckBox.Checked == true)
                        {
                            current = 0;
                            SetPrevNextLabelsEnable(true, false);
                            trackBar.Value = current;
                            pictureBox.ImageLocation = images[current];
                        }
                        else
                        {
                            SetPrevNextLabelsEnable(false, true);
                            trackBar.Value = current;
                            WMP.controls.stop();
                            timer.Stop();
                            ShowSlideButton.Text = "Старт";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                if (images != null && images.Count != 0)
                {
                    if (current - 1 >= 0)
                    {
                        LabelPrev.Enabled = true;
                        trackBar.Value = --current;
                        if (current == 0)
                            LabelPrev.Enabled = false;
                        pictureBox.ImageLocation = images[current];
                    }
                    else
                        LabelPrev.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PauseButton.Text == "Пауза")
                {
                    PauseButton.Text = "Продолжить";
                    WMP.controls.pause();
                    timer.Stop();
                    ShowSlideButton.Enabled = false;
                }
                else
                {
                    PauseButton.Text = "Пауза";
                    ShowSlideButton.Text = "Стоп";
                    WMP.controls.play();
                    timer.Start();
                    ShowSlideButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Запускает слайд шоу на весь экран
        private void ShowOnAllScreenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (images != null)
                {
                    Показ_слайдов form = new Показ_слайдов();

                    if (aroundShowCheckBox.Checked == true)
                        form.around = true;
                    else
                        form.around = false;

                    if (checkStartBegin.Checked == true)
                        form.Current = 0;
                    else
                        form.Current = current;

                    form.BackColor = Color.Black;
                    form.Img = images;
                    form.Current = current;
                    form.pictureBoxAllScreen.ImageLocation = form.Img[current];
                    form.Interval = int.Parse(SecIntervalComboBox.Text);
                    form.Show();
                }
                else
                    MessageBox.Show("Добавьте изображениия!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Открывает галерею
        private void galleryButton_Click(object sender, EventArgs e)
        {
            try
            {
                galleryForm = new Галерея();

                if (images != null)
                {
                    SetGallerySettings(ref galleryForm);
                    LoadGalleryImages(ref galleryForm);
                }
                galleryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetGallerySettings(ref Галерея galleryForm)
        {
            galleryForm.DirName = dirPath;
            galleryForm.Imgs = images;
        }

        private void LoadGalleryImages(ref Галерея galleryForm)
        {
            for (int i = 0; i < images.Count; i++)
                galleryForm.listBoxGallery.Items.Add(Path.GetFileName(images[i]));

            galleryForm.pictureBoxGallery.ImageLocation = galleryForm.Imgs[0];
        }

        // Загружает и выводит на экран презентацию
        private async void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOpenFile(FormatsFile.PPTX))
                    await Task.Run(() => PowerPointWork.OpenPPTXPresentation(pptxPath));
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Печать текущего изображения
        private async void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintWork printWork = new PrintWork(Images, Current);
            await Task.Run(() => printWork.PrintImage(printDialog));
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
            Application.Exit();
        }
    }

    public enum FormatsFile {
        PPTX,
        MP3
    }
}
