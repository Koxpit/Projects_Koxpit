using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Interop.PowerPoint;
using System.Windows.Forms;

namespace SlideShow
{
    public static class PowerPointWork
    {
        static public void OpenPPTXPresentation(string pptxPath)
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

        public static void SavePresentationAsIMGs(string folderForImages, string pptxFile)
        {
            PowerPoint.Application pptxApplication = new PowerPoint.Application();
            Presentation pptxPresentation = pptxApplication.Presentations.Open(pptxFile,
                MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
            pptxPresentation.SaveAs(folderForImages,
                PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoFalse);
            pptxPresentation.Close();

            MessageBox.Show("Сохранение завершено!");
        }
    }
}
