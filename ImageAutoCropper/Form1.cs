using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using ImageAutoCropperML.Model;
using System.Drawing.Imaging;
using System.Threading;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using Microsoft.WindowsAPICodePack.Shell;

namespace ImageAutoCropper
{
    public partial class Form1 : Form
    {
        public const string settingsFileName = "ImageCropperSettings.json";
        public const string folderMarker = "?-";
        public const string presetExt = ".preset";

        FileSystemWatcher fileSystemWatcher;
        public static Form1 instance;
        Settings set = new Settings();
        public static string appData = "";
        public static string presetsPath = "";
        int currentImageIndex = 0;
        int currentBCImageIndex = 0;
        AutoSettings[] autoSettings;
        bool isGrayView = true;
        string currentEdit = "";
        Settings lastUpdated;
        HelpForm helpForm;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
            presetsPath = appData + "Auto cropper presets\\";
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + "MLModel.zip");
            DoubleBuffered = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            autoSettings = JsonConvert.DeserializeObject<AutoSettings[]>(File.ReadAllText("AutoSettings.json"));

            Directory.CreateDirectory(presetsPath);
            fileSystemWatcher = new FileSystemWatcher(presetsPath,"*" + presetExt);
            fileSystemWatcher.Changed += FileSystemWatcher_Changed;
            fileSystemWatcher.Created += FileSystemWatcher_Created;
            fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
            fileSystemWatcher.Renamed += FileSystemWatcher_Renamed;
            fileSystemWatcher.EnableRaisingEvents = true;

            UpdatePresets();
            try { LoadSettings(); }
            catch { ResetButton_Click(null, null); }
            GrayPreviewButtonTextUpdate();
            UpdateImageBC();
            UpdateImage();
            //UpdateFilesExplorer();
        }
        private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e) => UpdatePresets();
        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e) => UpdatePresets();
        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e) => UpdatePresets();
        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e) => UpdatePresets();
        private void SaveSettings()
        {
            set.outputPath = OutputFolderTextBox.Text;
            set.XDist = XDistTextBox.Text;
            set.YDist = YDistTextBox.Text;
            set.borderThikness = BorderThiknessTextBox.Text;
            set.minXSize = MinXSizeTextBox.Text;
            set.minYSize = MinYSizeTextBox.Text;
            set.threshold = ThresholdTextBox.Text;
            set.imageDilating = ImageDilatingTextBox.Text;
            set.imageEroding = ImageErodingTextBox.Text;
            set.separate = SeparateCheckBox.Checked;
            set.isFolder = IsFolderCheckBox.Checked;
            set.autoSettings = AutoSettingsCheckBox.Checked;
            set.disableSeparatingInPrewiew = DisableSeparatingInPreview.Checked;
            set.smooth = SmoothTextBox.Text;
            set.brightness = BrightnessTextBox.Text;
            set.contrast = ContrastTextBox.Text;
            set.saveFormat = SaveFormatComboBox.SelectedIndex;
            set.borderColor = BorderColorDialog.Color.A + "|" + BorderColorDialog.Color.R + "|" + BorderColorDialog.Color.G + "|" + BorderColorDialog.Color.B;
            set.windowSizeX = Size.Width;
            set.windowSizeY = Size.Height;
            set.isMaximized = WindowState == FormWindowState.Maximized;
            set.autoRotate = RotateCheckBox.Checked;
            set.autoBC = AutoBCCheckBox.Checked;
            set.outputContrast = OutputContrastTextBox.Text;
            set.outputBrightness = OutputBrightnessTextBox.Text;
            set.autoContrastIntensity = AutoContrastIntensityTextBox.Text;
            set.tileGridSize = AutoContrastGridSizeTextBox.Text;
            set.EENumeration = EENumberingCheckBox.Checked;
            set.EENumerationIndex = EENumberingTextBox.Text;
            set.detectionResolution = DetectionResolutionComboBox.SelectedIndex;
            set.isGrayView = isGrayView;
            set.sortByName = FilesListView.Sorting == SortOrder.Ascending;
            set.presetIndex = SettingsPresetComboBox.SelectedIndex;
            set.saveToFolders = SaveToFoldersCheckBox.Checked;

            set.BC_autoBC = BC_AutoCorrectionCheckBox.Checked;
            set.BC_Brightness = BC_BrightnessTextBox.Text;
            set.BC_Contrast = BC_ContrastTextBox.Text;
            set.BC_isFolder = BC_IsFolderCheckBox.Checked;
            set.BC_outputPath = BC_OutputPathTextBox.Text;
            set.BC_autoContrastIntensity = BC_AutoContrastIntensityTextBox.Text;
            set.BC_tileGridSize = BC_AutoContrastGridSizeTextBox.Text;
            set.BC_saveFormat = BC_SaveFormatComboBox.SelectedIndex;

            set.Save(appData + settingsFileName);
        }
        private void LoadSettings(bool loadFromPath = true, bool loadOnlySettings = false)
        {
            if(loadFromPath)
            {
                if (!File.Exists(appData + settingsFileName))
                {
                    set = new Settings();
                    set.Save(appData + settingsFileName);
                }
                else set.Load(appData + settingsFileName);
            }
            if(!loadOnlySettings)
            {
                try { SettingsPresetComboBox.SelectedIndex = set.presetIndex; }
                catch { SettingsPresetComboBox.SelectedIndex = 0; }
            }
            try
            {
                if(!loadOnlySettings) OutputFolderTextBox.Text = set.outputPath;
                XDistTextBox.Text = set.XDist;
                YDistTextBox.Text = set.YDist;
                BorderThiknessTextBox.Text = set.borderThikness;
                MinXSizeTextBox.Text = set.minXSize;
                MinYSizeTextBox.Text = set.minYSize;
                ThresholdTextBox.Text = set.threshold;
                ImageDilatingTextBox.Text = set.imageDilating;
                ImageErodingTextBox.Text = set.imageEroding;
                SeparateCheckBox.Checked = set.separate;
                if (!loadOnlySettings) IsFolderCheckBox.Checked = set.isFolder;
                DisableSeparatingInPreview.Checked = set.disableSeparatingInPrewiew;
                SmoothTextBox.Text = set.smooth;
                BrightnessTextBox.Text = set.brightness;
                ContrastTextBox.Text = set.contrast;
                SaveFormatComboBox.SelectedIndex = set.saveFormat;
                AutoSettingsCheckBox.Checked = set.autoSettings;
                if (!loadOnlySettings) Size = new Size(set.windowSizeX, set.windowSizeY);
                if (!loadOnlySettings) WindowState = set.isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
                RotateCheckBox.Checked = set.autoRotate;
                AutoBCCheckBox.Checked = set.autoBC;
                OutputBrightnessTextBox.Text = set.outputBrightness;
                OutputContrastTextBox.Text = set.outputContrast;
                AutoContrastIntensityTextBox.Text = set.autoContrastIntensity;
                AutoContrastGridSizeTextBox.Text = set.tileGridSize;
                EENumberingCheckBox.Checked = set.EENumeration;
                EENumberingTextBox.Text = set.EENumerationIndex;
                DetectionResolutionComboBox.SelectedIndex = set.detectionResolution;
                isGrayView = set.isGrayView;
                SaveToFoldersCheckBox.Checked = set.saveToFolders;
                if (set.sortByName) SortByNameFileListViewButton_Click(null, null);
                else SortByStructureFileListViewButton_Click(null, null);

                BC_AutoCorrectionCheckBox.Checked = set.BC_autoBC;
                BC_BrightnessTextBox.Text = set.BC_Brightness;
                BC_ContrastTextBox.Text = set.BC_Contrast;
                if (!loadOnlySettings) BC_IsFolderCheckBox.Checked = set.BC_isFolder;
                if (!loadOnlySettings) BC_OutputPathTextBox.Text = set.BC_outputPath;
                BC_AutoContrastIntensityTextBox.Text = set.BC_autoContrastIntensity;
                BC_AutoContrastGridSizeTextBox.Text = set.BC_tileGridSize;
                BC_SaveFormatComboBox.SelectedIndex = set.BC_saveFormat;

                AutoBCCheckBox_CheckedChanged(null, null);
                BC_AutoCorrectionCheckBox_CheckedChanged(null, null);
                EENumberingCheckBox_CheckedChanged(null, null);

                var s = set.borderColor.Split('|');
                BorderColorDialog.Color = Color.FromArgb(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]));
            }
            catch
            {
                set = new Settings();
                set.Save(appData + settingsFileName);
            }
        }
        private void DetectButton_Click(object sender, EventArgs e) => DetectProcess();
        private void DetectProcess()
        {
            SaveSettings();
            int XDist = 0;
            int YDist = 0;
            int borderThikness = 0;
            int minXSize = 0;
            int minYSize = 0;
            int threshold = 0;
            int dilate = 0;
            int erode = 0;
            int smooth = 0;
            int brightness = 0;
            int contrast = 0;
            int outputContrast = 0;
            int outputBrightness = 0;
            int intersectThresh = 0;
            int tileGridSize = 0;
            double autoContrastIntensity = 0;
            int EENumerationIndex = 0;
            bool EENumeration = EENumberingCheckBox.Checked;
            bool separate = SeparateCheckBox.Checked;
            bool autoSettings = AutoSettingsCheckBox.Checked;
            bool autoRotate = RotateCheckBox.Checked;
            bool autoBC = AutoBCCheckBox.Checked;
            bool saveToFolders = SaveToFoldersCheckBox.Checked;
            string outputFolderPath = OutputFolderTextBox.Text;
            if (!GetInputData(out XDist, out YDist, out borderThikness, out minXSize, out minYSize, out threshold, out dilate, out erode, out smooth, out brightness, out contrast, out intersectThresh, out outputContrast, out outputBrightness, out tileGridSize, out autoContrastIntensity, out EENumerationIndex)) return;
            if (!Directory.Exists(OutputFolderTextBox.Text))
            {
                MessageBox.Show("Папка для результатов указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProcessingForm form = new ProcessingForm();
            form.Show();
            Hide();
            var cancelToken = new CancellationTokenSource();
            bool isCanceling = false;
            int formatIndex = SaveFormatComboBox.SelectedIndex;
            var files = GetFilesFromPath(PathTextBox.Text, true);
            var task = Task.Run(() =>
            {
                int totalImgs = 0;
                int totalTrashed = 0;
                try
                {
                    form.bar.Invoke((MethodInvoker)delegate () {
                        form.bar.Maximum = files.Length;
                        form.bar.Value = 0;
                    });
                    form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Обработка начата."); form.log.Lines = form.log.Lines.Append("").ToArray(); });
                    int eeIndex = EENumerationIndex;
                    foreach (var f in files)
                    {
                        string file = f.Split(new string[] { folderMarker }, StringSplitOptions.None)[0];
                        form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Обработка изображения {file}..."); form.log.Lines = form.log.Lines.Append("").ToArray(); });
                        var copy = Image.FromFile(file);
                        Image currentImg = DeepCopy(copy);
                        copy.Dispose();
                        var prevTrashed = totalTrashed;
                        var rects = Detect(file, XDist, YDist, separate, autoSettings, borderThikness, minXSize, minYSize, threshold, dilate, erode, smooth, brightness, contrast, intersectThresh, autoRotate, 1, ref totalTrashed, false);

                        form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Подтверждено {rects.Length} объектов. Отклонено {totalTrashed - prevTrashed} объектов."); form.log.Lines = form.log.Lines.Append("").ToArray(); });
                        var name = Path.GetFileNameWithoutExtension(file);

                        string folderPath = "";
                        folderPath = outputFolderPath + f.Split(new string[] { folderMarker }, StringSplitOptions.None)[1] + (outputFolderPath.Last() == Path.DirectorySeparatorChar ? "" : Path.DirectorySeparatorChar + "") + (saveToFolders ? name + Path.DirectorySeparatorChar : Path.DirectorySeparatorChar.ToString());
                        totalImgs += rects.Length;
                        Directory.CreateDirectory(folderPath);
                        for (int i = 0; i < rects.Length; ++i)
                        {
                            var img = CropImage((Bitmap)currentImg, rects[i]);
                            ChangeContrast(ref img, outputContrast, outputBrightness, autoContrastIntensity, tileGridSize, autoBC);
                            ImageFormat imgFormat = ImageFormat.Jpeg;
                            switch (formatIndex)
                            {
                                case 0: imgFormat = ImageFormat.Png; break;
                                case 1: imgFormat = ImageFormat.Jpeg; break;
                                case 2: imgFormat = ImageFormat.Bmp; break;
                                default: imgFormat = ImageFormat.Jpeg; break;
                            }
                            if (!EENumeration) img.Save(folderPath + name + "_" + (i + 1) + GetFilenameExtension(imgFormat), imgFormat);
                            else { img.Save(folderPath + eeIndex + GetFilenameExtension(imgFormat), imgFormat); ++eeIndex; }
                            img.Dispose();
                        }
                        currentImg.Dispose();
                        form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Результат сохранён."); form.log.Lines = form.log.Lines.Append("").ToArray(); form.log.Lines = form.log.Lines.Append("").ToArray(); });
                        form.bar.Invoke((MethodInvoker)delegate () { form.bar.Value++; });
                    }
                    MessageBox.Show($"Обработка завершена. Всего обработано {totalImgs + totalTrashed} изображений. Из них: \n{totalImgs} - положительных;\n{totalTrashed} - отрицательных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Invoke((MethodInvoker)delegate () { form.Close(); });
                    Invoke((MethodInvoker)delegate () { Show(); });
                }
                catch (Exception ex) { if (!isCanceling) { MessageBox.Show($"Ошибка при обработке. {ex.Message} - строка {ex.LineNumber()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); form.Close(); Invoke((MethodInvoker)delegate () { Show(); }); } return; }
            }, cancelToken.Token);
            form.OnCancelOperation += Form_OnCancelOperation;
            void Form_OnCancelOperation(ProcessingForm senderF)
            {
                isCanceling = true;
                cancelToken.Cancel();
                Show();
                senderF.Close();
            }
        }
        private void UpdateImage()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                int XDist = 0;
                int YDist = 0;
                int borderThikness = 0;
                int minXSize = 0;
                int minYSize = 0;
                int threshold = 0;
                int dilate = 0;
                int erode = 0;
                int smooth = 0;
                int brightness = 0;
                int contrast = 0;
                int outputContrast = 0;
                int outputBrightness = 0;
                int intersectThresh = 0;
                int tileGridSize = 0;
                int EENumerationIndex = 0;
                float resolutionMultiplier = float.Parse(DetectionResolutionComboBox.SelectedItem.ToString().Replace(".", ","));
                double autoContrastIntensity = 0;
                if (!GetInputData(out XDist, out YDist, out borderThikness, out minXSize, out minYSize, out threshold, out dilate, out erode, out smooth, out brightness, out contrast, out intersectThresh, out outputContrast, out outputBrightness, out tileGridSize, out autoContrastIntensity, out EENumerationIndex, false))
                {
                    throw new Exception();
                }
                var files = GetFilesFromPath(PathTextBox.Text);
                if ((files.Length <= currentImageIndex && isGrayView) || (files.Length <= currentImageIndex + 1 && !isGrayView && files.Length >= 2))
                {
                    if (files.Length > 0) currentImageIndex = 0;
                    else throw new Exception();
                }
                else if (currentImageIndex < 0)
                {
                    if (files.Length > 0)
                    {
                        if (isGrayView || (!isGrayView && files.Length < 2)) currentImageIndex = files.Length - 1;
                        else if (files.Length >= 2) currentImageIndex = files.Length - 2;
                    }
                    else throw new Exception();
                }
                CurrentImageLabel_1.Text = files[currentImageIndex];
                CurrentImageLabel_2.Text = isGrayView || (files.Length < 2 && !isGrayView) ? "None" : files[currentImageIndex + 1];
                DisplayImage(files[currentImageIndex], ImagePictureBox_1);
                if (!isGrayView && files.Length >= 2) DisplayImage(files[currentImageIndex + 1], ImagePictureBox_2);
                Cursor = Cursors.Default;

                void DisplayImage(string path, PictureBox box)
                {
                    Bitmap fromFile = (Bitmap)Image.FromFile(path);
                    Bitmap source = LowerBitmapResolution(fromFile, resolutionMultiplier);
                    fromFile.Dispose();
                    int totalTrashed = 0;
                    var rects = Detect(path, XDist, YDist, DisableSeparatingInPreview.Checked ? false : SeparateCheckBox.Checked, AutoSettingsCheckBox.Checked, borderThikness, minXSize, minYSize, threshold, dilate, erode, smooth, brightness, contrast, intersectThresh, RotateCheckBox.Checked, resolutionMultiplier, ref totalTrashed, isGrayView || (!isGrayView && files.Length < 2));
                    using (Graphics g = Graphics.FromImage(source))
                    {
                        //if (rects.Length > 0) g.DrawRectangles(new Pen(BorderColorDialog.Color, 10), rects.ToArray());
                        foreach (var r in rects)
                        {
                            var pen = new Pen(BorderColorDialog.Color, (10 * resolutionMultiplier));
                            //g.DrawRectangle(new Pen(Color.Green,10), r.MinAreaRect());
                            g.DrawRotatedRectangle(pen, r);
                        }
                    }
                    if (box.Image != null)
                    {
                        box.Image.Dispose();
                        box.Image = null;
                    }
                    ChangeContrast(ref source, outputContrast, outputBrightness, autoContrastIntensity, tileGridSize, AutoBCCheckBox.Checked);
                    box.Image = DeepCopy(source);
                    source.Dispose();
                }
            }
            catch {
                Cursor = Cursors.Default;
                CurrentImageLabel_1.Text = "None";
                CurrentImageLabel_2.Text = "None";
                if (ImagePictureBox_1.Image != null)
                {
                    ImagePictureBox_1.Image.Dispose();
                    ImagePictureBox_1.Image = null;
                }
                if (ImagePictureBox_2.Image != null)
                {
                    ImagePictureBox_2.Image.Dispose();
                    ImagePictureBox_2.Image = null;
                }
            }
        }
        private void UpdateFilesExplorer()
        {
            try
            {
                var files = GetFilesFromPath(PathTextBox.Text);
                FilesPreviewImageList.Images.Clear();
                FilesListView.Items.Clear();
                foreach (var f in files)
                {
                    ShellFile shellFile = ShellFile.FromFilePath(f);
                    var s = FilesPreviewImageList.ImageSize;
                    FilesPreviewImageList.Images.Add(LowerBitmapResolution(shellFile.Thumbnail.MediumBitmap, s.Width > s.Height ? s.Width : s.Height));
                    Console.WriteLine(shellFile.Thumbnail.MediumBitmap.Size);
                    shellFile.Dispose();
                    FileInfo fi = new FileInfo(f);
                    FilesListView.Items.Add(fi.Name, FilesPreviewImageList.Images.Count - 1);
                }
            }
            catch
            {
                FilesPreviewImageList.Images.Clear();
                FilesListView.Items.Clear();
            }
        }
        private bool GetInputData(out int XDist, out int YDist, out int borderThikness, out int minXSize, out int minYSize, out int threshold, out int dilate, out int erode, out int smooth, out int brightness, out int contrast, out int intersectThresh, out int outputContrast, out int outputBrightness, out int tileGridSize, out double autoContrastIntensity, out int EENumberingIndex, bool showDialog = true)
        {
            XDist = 0;
            YDist = 0;
            borderThikness = 0;
            minXSize = 0;
            minYSize = 0;
            threshold = 0;
            dilate = 0;
            erode = 0;
            smooth = 0;
            brightness = 0;
            contrast = 0;
            intersectThresh = 0;
            outputContrast = 0;
            outputBrightness = 0;
            tileGridSize = 0;
            autoContrastIntensity = 0;
            EENumberingIndex = 0;
            try
            {
                XDist = Convert.ToInt32(XDistTextBox.Text);
                YDist = Convert.ToInt32(YDistTextBox.Text);
                if (XDist < 0 || YDist < 0) throw new Exception();
            }
            catch
            {
                if (showDialog) MessageBox.Show("Допустимое расстояние для объеденения рамок указано неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                borderThikness = Convert.ToInt32(BorderThiknessTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Утолщение рамок указано неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                minXSize = Convert.ToInt32(MinXSizeTextBox.Text);
                minYSize = Convert.ToInt32(MinYSizeTextBox.Text);
                if (minXSize < 0 || minYSize < 0) throw new Exception();
            }
            catch
            {
                if (showDialog) MessageBox.Show("Минимальный размер рамок указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                threshold = Convert.ToInt32(ThresholdTextBox.Text);
                if (threshold < 0 || threshold > 255) throw new Exception();
            }
            catch
            {
                if (showDialog) MessageBox.Show("Порог преобразования в Ч/Б указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                dilate = Convert.ToInt32(ImageDilatingTextBox.Text);
                erode = Convert.ToInt32(ImageErodingTextBox.Text);
                if (dilate < 0 || erode < 0) throw new Exception();
            }
            catch
            {
                if (showDialog) MessageBox.Show("Dilate или erode указано неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                smooth = Convert.ToInt32(SmoothTextBox.Text);
                if (smooth < 0) throw new Exception();
                if (smooth % 2 == 0) smooth++;
            }
            catch
            {
                if (showDialog) MessageBox.Show("Размытие указано неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                brightness = Convert.ToInt32(BrightnessTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Яркость (Ч/Б) указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                contrast = Convert.ToInt32(ContrastTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Контраст (Ч/Б) указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                outputBrightness = Convert.ToInt32(OutputBrightnessTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Яркость указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                outputContrast = Convert.ToInt32(OutputContrastTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Контраст указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                tileGridSize = Convert.ToInt32(AutoContrastGridSizeTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Размер сетки автокоррекции указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                autoContrastIntensity = double.Parse(AutoContrastIntensityTextBox.Text.Replace(".", ","));
            }
            catch
            {
                if (showDialog) MessageBox.Show("Интенсивность автокоррекции указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                EENumberingIndex = Convert.ToInt32(EENumberingTextBox.Text);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Индекс сквозной нумерации указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /*try
            {
                if (!PathTextBox.Text.Contains(';')) PathTextBox.Text += ";";
                foreach (var p in PathTextBox.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (IsDir(p))
                    {
                        if (GetFilesFrom(p, new string[] { "jpg", "jpeg", "png" }, true).Length <= 0)
                        {
                            if (showDialog) MessageBox.Show($"Директория {p} является пустой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else if (!File.Exists(p))
                    {
                        if (showDialog) MessageBox.Show($"Файл по пути {p} не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (PathTextBox.Text.Length > 0 && PathTextBox.Text.Last() == ';') PathTextBox.Text = PathTextBox.Text.Remove(PathTextBox.Text.Length - 1, 1);
            }
            catch
            {
                if (showDialog) MessageBox.Show("Путь к директории указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/
            List<string> files = new List<string>();
            if (!PathTextBox.Text.Contains(';')) PathTextBox.Text += ";";
            foreach (var p in PathTextBox.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (IsDir(p))
                {
                    var temp = GetFilesFrom(p, new string[] { "jpg", "jpeg", "png" }, true);
                    foreach (var t in temp) files.Add(t);
                }
                else files.Add(p);
            }
            if (PathTextBox.Text.Length > 0 && PathTextBox.Text.Last() == ';') PathTextBox.Text = PathTextBox.Text.Remove(PathTextBox.Text.Length - 1, 1);
            return true;
        }
        private RotatedRect[] Detect(string imagePath, int XDist, int YDist, bool enableSeparating, bool autoSettings, int borderThikness, int minXSize, int minYSize, int threshold, int dilate, int erode, int smooth, int brightness, int contrast, int intersectThresh, bool autoRotate, float resolutionMultiplier, ref int totalTrashed, bool preview)
        {
            //var copy = Image.FromFile(imagePath);
            Image source = Image.FromFile(imagePath);//LowerBitmapResolution((Bitmap)copy,resolutionMultiplier);
            //copy.Dispose();
            var f = GraphicsUnit.Pixel;
            var bounds = source.GetBounds(ref f);

            List<RotatedRect> rects = new List<RotatedRect>();

            Image<Bgr, byte> fileImage = new Image<Bgr, byte>(imagePath);
            Console.WriteLine("res" + resolutionMultiplier);
            Image<Bgr, byte> inputImage = LowerBitmapResolution(fileImage, resolutionMultiplier);
            fileImage.Dispose();
            //CvInvoke.BitwiseNot(inputImage, inputImage);
            Image<Gray, byte> temp = new Image<Gray, byte>(inputImage.Size);

            int m1 = GetMainColor(inputImage), m2 = GetMainColor(inputImage, 0, 181);
            int mc = m1;// < m2 ? m1 : m2;

            for (int c = 0; c < 2; ++c)
            {
                if (c > 0) inputImage = new Image<Bgr, byte>(imagePath);
                temp = new Image<Gray, byte>(inputImage.Size.Width, inputImage.Size.Height);
                Console.WriteLine("main: " + m1 + ";" + m2 + "  res: " + mc);
                var type = ThresholdType.Binary;
                if (mc > 180) type = ThresholdType.BinaryInv;

                if (autoSettings)
                {
                    int index = 0;

                    if (mc > 180 && mc < 220) index = 2;
                    else if (mc >= 220) index = 1;

                    dilate = this.autoSettings[index].imageDilating;
                    erode = this.autoSettings[index].imageEroding;
                    smooth = this.autoSettings[index].smooth;
                    brightness = this.autoSettings[index].brightness;
                    contrast = this.autoSettings[index].contrast;

                    if (type == ThresholdType.BinaryInv) CvInvoke.BitwiseNot(inputImage, inputImage);
                    inputImage.Mat.ConvertTo(inputImage, DepthType.Cv8U, 1 + contrast / 127, brightness - contrast);

                    Image<Gray, byte> temp1 = new Image<Gray, byte>(inputImage.Size.Width, inputImage.Size.Height);
                    Image<Gray, byte> temp2 = new Image<Gray, byte>(inputImage.Size.Width, inputImage.Size.Height);
                    Image<Gray, byte> temp3 = new Image<Gray, byte>(inputImage.Size.Width, inputImage.Size.Height);
                    CvInvoke.Threshold(inputImage[0], temp1, 0, 255, ThresholdType.Otsu);
                    CvInvoke.Threshold(inputImage[1], temp2, 0, 255, ThresholdType.Otsu);
                    CvInvoke.Threshold(inputImage[2], temp3, 0, 255, ThresholdType.Otsu);
                    temp2 = temp1.Add(temp2);
                    temp = temp2.Add(temp3);
                    temp1.Dispose();
                    temp2.Dispose();
                    temp3.Dispose();
                }
                else
                {
                    inputImage.Mat.ConvertTo(inputImage, DepthType.Cv8U, 1 + contrast / 127, brightness - contrast);
                    temp = inputImage.Convert<Gray, byte>();
                    CvInvoke.Threshold(temp, temp, threshold, 255, type);
                }
                temp = temp.SmoothGaussian(smooth);
                temp = temp.Erode(erode).Dilate(dilate);
                var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                CvInvoke.MorphologyEx(temp, temp, MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

                if (preview)
                {
                    if (ImagePictureBox_2.Image != null)
                    {
                        ImagePictureBox_2.Image.Dispose();
                        ImagePictureBox_2.Image = null;
                    }
                    ImagePictureBox_2.Image = temp.ToBitmap();
                }
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat m = new Mat();

                var mainColor = GetMainColor(temp, 0, 255);

                CvInvoke.FindContours(temp.InRange(new Gray(mainColor + 1), new Gray(255)), contours, m, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; ++i)
                {
                    try
                    {
                        RotatedRect bbox = CvInvoke.MinAreaRect(contours[i]);
                        Rectangle bboxBounding = bbox.MinAreaRect();
                        if (!autoRotate)
                        {
                            bbox = CvInvoke.MinAreaRect(new PointF[] { new PointF(bboxBounding.Left, bboxBounding.Top), new PointF(bboxBounding.Right, bboxBounding.Top), new PointF(bboxBounding.Right, bboxBounding.Bottom), new PointF(bboxBounding.Left, bboxBounding.Bottom) });
                        }

                        if (bboxBounding.Size.Width >= minXSize && bboxBounding.Size.Height >= minYSize && (bboxBounding.Size.Width < temp.Width - 1 && bboxBounding.Size.Height < temp.Height - 1) && bboxBounding.Left > bounds.Left && bboxBounding.Right < bounds.Right &&
                            bboxBounding.Top > bounds.Top && bboxBounding.Bottom < bounds.Bottom) rects.Add(bbox);
                    }
                    catch { }
                }
                if (rects.Count > 0) break;
                else if (c <= 0) { mc = m2; temp.Dispose(); inputImage.Dispose(); }//m1 < m2 ? m2 : m1;
            }

            if (enableSeparating)
            {
                for (int i = 0; i < rects.Count; ++i)
                {
                    var m = 1 / resolutionMultiplier;
                    var rect = rects[i];
                    rect.Center = new PointF(rect.Center.X * m, rect.Center.Y * m);
                    rect.Size = new SizeF(rect.Size.Width * m, rect.Size.Height * m);
                    var tempImg = CropImage((Bitmap)source, rect);
                    tempImg.Save("temp", ImageFormat.Png);
                    tempImg.Dispose();
                    var predictionResult = ConsumeModel.Predict(new ModelInput { ImageSource = "temp" });
                    if (File.Exists("temp")) File.Delete("temp");
                    if (predictionResult.Prediction == "Trash")
                    {
                        rects.RemoveAt(i);
                        --i;
                        totalTrashed++;
                    }
                }
            }
            //rects = UnionInside(rects.ToArray(), intersectThresh).ToList();

            //if (unionIntersecting) rects = UnionIntersecting(rects.ToArray()).ToList();
            rects = UnionBySizes(rects.ToArray(), XDist, YDist).ToList();

            for (int i = 0; i < rects.Count; ++i) { var r = rects[i]; r = r.Inflate(borderThikness, borderThikness); rects[i] = r; }

            var boundsRect = CvInvoke.MinAreaRect(new PointF[] { new PointF(bounds.Left, bounds.Top), new PointF(bounds.Right, bounds.Top), new PointF(bounds.Right, bounds.Bottom), new PointF(bounds.Left, bounds.Bottom) });
            for (int i = 0; i < rects.Count; ++i) rects[i] = RotatedRectAddons.Intersect(rects[i], boundsRect);

            inputImage.Dispose();
            source.Dispose();
            temp.Dispose();

            return rects.ToArray();
        }
        private Bitmap CropImage(Bitmap source, Rectangle section)
        {
            return (Bitmap)source.Clone(section, source.PixelFormat);
        }
        private Bitmap CropImage(Bitmap source, RotatedRect section)
        {
            Image<Bgr, byte> src = source.ToImage<Bgr, byte>();
            Mat M = new Mat(), rotated = new Mat(), cropped = new Mat();
            float angle = section.Angle;
            Size rectSize = section.Size.ToSize();
            if (section.Angle < -45)
            {
                angle += 90;
                rectSize = new Size(rectSize.Height, rectSize.Width);
            }
            CvInvoke.GetRotationMatrix2D(section.Center, angle, 1, M);
            CvInvoke.WarpAffine(src, rotated, M, src.Size, Inter.Cubic);
            src.Dispose();
            CvInvoke.GetRectSubPix(rotated, rectSize, section.Center, cropped);
            rotated.Dispose();

            var bit = cropped.ToBitmap();
            var res = DeepCopy(bit);
            bit.Dispose();
            cropped.Dispose();
            return res;
        }
        /*private RotatedRect[] UnionIntersecting(RotatedRect[] inputRects)
        {
            var rects = inputRects.ToList();
            for (int i = 0; i < rects.Count; ++i)
            {
                for (int j = 0; j < rects.Count; ++j)
                {
                    if (i != j)
                    {
                        if (rects[i].IntersectsWith(rects[j]))
                        {
                            rects[i] = RotatedRectAddons.Union(rects[i], rects[j]);
                            rects.RemoveAt(j);
                            if (i > j) --i;
                            --j;
                        }
                    }
                }
            }
            return rects.ToArray();
        }
        private RotatedRect[] UnionInside(RotatedRect[] inputRects, int intersectThresh)
        {
            var rects = inputRects.ToList();
            for (int i = 0; i < rects.Count; ++i)
            {
                for (int j = 0; j < rects.Count; ++j)
                {
                    if (i != j)
                    {
                        var sq1 = (rects[j].Size.Width * rects[j].Size.Height * 1F);
                        var sq2 = (rects[i].Size.Width * rects[i].Size.Height * 1F);
                        var sqInt = sq1 + sq2;
                        if (rects[i].IntersectsWith(rects[j]) && (sq2 < sq1 ? sqInt / sq2 : sqInt / sq1) * 100F > intersectThresh)
                        {
                            
                            rects[i] = RotatedRectAddons.Union(rects[i], rects[j]);
                            rects.RemoveAt(j);
                            if (i > j) --i;
                            --j;
                        }
                    }
                }
            }
            return rects.ToArray();
        }*/
        private RotatedRect[] UnionBySizes(RotatedRect[] inputRects, int maxXLenght, int maxYLenght)
        {
            var rects = inputRects.ToList();
            for (int i = 0; i < rects.Count; ++i)
            {
                for (int j = 0; j < rects.Count; ++j)
                {
                    if (i != j && i < rects.Count && j < rects.Count && i >= 0 && j >= 0)
                    {
                        var size = CalculateRectBorderDist(rects[i], rects[j]);
                        if (size.Width < maxXLenght && size.Height < maxYLenght)
                        {
                            rects[i] = RotatedRectAddons.Union(rects[i], rects[j]);
                            rects.RemoveAt(j);
                            if (i > j) --i;
                            --j;
                        }
                    }
                }
            }

            return rects.ToArray();
        }
        private Size CalculateRectBorderDist(RotatedRect rr1, RotatedRect rr2)
        {
            Rectangle rect1 = rr1.MinAreaRect(), rect2 = rr2.MinAreaRect();
            var res = new Size();
            if (rect1.Right < rect2.Left)//rect1 - rect2
            {
                res.Width = rect2.Left - rect1.Right;
            }
            else if (rect1.Left > rect2.Right)//rect2 - rect1
            {
                res.Width = rect1.Left - rect2.Right;
            }
            else res.Width = 0;

            if (rect1.Top > rect2.Bottom)//rect2 \n rect1
            {
                res.Height = rect1.Top - rect2.Bottom;
            }
            else if (rect1.Bottom < rect2.Top)//rect1 \n rect2
            {
                res.Height = rect2.Top - rect1.Bottom;
            }
            else res.Height = 0;

            return res;
        }
        private void ChoosePathButton_Click(object sender, EventArgs e)
        {
            if (IsFolderCheckBox.Checked)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Выбор папки с изображениями";
                dialog.ShowNewFolderButton = true;
                if (dialog.ShowDialog() == DialogResult.OK) { PathTextBox.Text = dialog.SelectedPath; currentImageIndex = 0; }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                dialog.Title = "Выбор изображения";
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PathTextBox.Text = "";
                    foreach (var n in dialog.FileNames)
                    {
                        PathTextBox.Text += n + ";";
                    }
                    if (PathTextBox.Text.Length > 0 && PathTextBox.Text.Last() == ';') PathTextBox.Text = PathTextBox.Text.Remove(PathTextBox.Text.Length - 1, 1);
                    currentImageIndex = 0;
                }
            }
            SaveSettings();
            UpdateImage();
            UpdateFilesExplorer();
        }
        private void IsFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PathTextBox.Text)) return;
            if (!IsDir(PathTextBox.Text) && IsFolderCheckBox.Checked)
            {
                string res = "";
                if (PathTextBox.Text.Contains(';')) { var s = PathTextBox.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[0]; res += s.Replace(Path.GetFileName(s), ""); }
                else res = PathTextBox.Text.Replace(Path.GetFileName(PathTextBox.Text), "");
                if (res.Last() == ';') res = res.Remove(res.Length - 1, 1);
                PathTextBox.Text = res;
            }
            else if (!IsFolderCheckBox.Checked) PathTextBox.Text = "";
        }
        private void ChooseOutputFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Выбор папки для сохранения результатов";
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK) OutputFolderTextBox.Text = dialog.SelectedPath;
        }
        private string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, string.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => SaveSettings();
        private void ResetButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            LoadSettings();

            var oldSet = set;

            int sizeX = set.windowSizeX, sizeY = set.windowSizeY;
            bool isMaximized = set.isMaximized;

            set = new Settings();
            set.windowSizeY = sizeY;
            set.windowSizeX = sizeX;
            set.isMaximized = isMaximized;
            set.Save(appData + settingsFileName);
            LoadSettings();

            BC_BrightnessTextBox.Text = oldSet.BC_Brightness;
            BC_ContrastTextBox.Text = oldSet.BC_Contrast;
            BC_AutoContrastIntensityTextBox.Text = oldSet.BC_autoContrastIntensity;
            BC_AutoContrastGridSizeTextBox.Text = oldSet.BC_tileGridSize;
            BC_AutoCorrectionCheckBox.Checked = oldSet.BC_autoBC;
            BC_SaveFormatComboBox.SelectedIndex = oldSet.BC_saveFormat;
            BC_OutputPathTextBox.Text = oldSet.BC_outputPath;
            BC_IsFolderCheckBox.Checked = oldSet.BC_isFolder;
            UpdateImage();
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                TextBox textBox = PathTextBox;
                if (TabControl.SelectedIndex == 3) textBox = BC_InputPathTextBox;
                List<string> oldFiles = textBox.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                textBox.Text = "";
                foreach (string filePath in files)
                {
                    var ex = Path.GetExtension(filePath);
                    if ((ex == ".jpg" || ex == ".jpeg" || ex == ".png" || ex == ".bmp" || IsDir(filePath)) && !oldFiles.Contains(filePath)) oldFiles.Add(filePath);
                }
                foreach (var f in oldFiles) textBox.Text += f + ";";
                if (textBox.Text.Last() == ';') textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                if (TabControl.SelectedIndex != 3) { UpdateImage(); UpdateFilesExplorer(); }
                else UpdateImageBC();
            }
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        private bool IsDir(string path)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(path);
                return (attr & FileAttributes.Directory) == FileAttributes.Directory;
            }
            catch { return false; }
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (helpForm != null) helpForm.Close();
            helpForm = new HelpForm();
            helpForm.Show();
        }
        public static string GetFilenameExtension(ImageFormat format)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(x => x.FormatID == format.Guid).FilenameExtension.ToLower().Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault().Replace(";", "");
        }
        private void ChangeBorderColorButton_Click(object sender, EventArgs e)
        {
            if (BorderColorDialog.ShowDialog() == DialogResult.OK) UpdateImage();
        }
        private void RightArrowPictureBox_Click(object sender, EventArgs e)
        {
            var files = GetFilesFromPath(PathTextBox.Text);
            ++currentImageIndex;
            if (!isGrayView) ++currentImageIndex;
            //if (currentImageIndex >= files.Length) currentImageIndex = 0;
            UpdateImage();
        }
        private string[] GetFilesFromPath(string text, bool addMarkers = false)
        {
            List<string> files = new List<string>();
            if (!text.Contains(';')) text += ";";
            foreach (var p in text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (IsDir(p) && Directory.Exists(p))
                {
                    var temp = GetFilesFrom(p, new string[] { "jpg", "jpeg", "png" }, true);
                    if (addMarkers) foreach (var t in temp) { if (File.Exists(t) && !files.Contains(t)) files.Add(t + folderMarker + Path.GetDirectoryName(t).Replace(p, "")); }
                    else foreach (var t in temp) { if (File.Exists(t) && !files.Contains(t)) files.Add(t); }
                }
                else if (File.Exists(p) && !files.Contains(p))
                {
                    if (addMarkers) files.Add(p + folderMarker);
                    else files.Add(p);
                }
            }
            if (text.Last() == ';') text = text.Remove(text.Length - 1, 1);
            return files.ToArray();
        }
        private void LeftArrowPictureBox_Click(object sender, EventArgs e)
        {
            var files = GetFilesFromPath(PathTextBox.Text);
            --currentImageIndex;
            if (!isGrayView) --currentImageIndex;
            //if (currentImageIndex < 0) currentImageIndex = files.Length - 1;
            UpdateImage();
        }
        /*private int GetMainColor(Image<Bgr, byte> src, float min = 0, float max = 255)
        {
            int sum = 0;
            int i = 0;
            for (; i < 3; ++i)
            {
                DenseHistogram hist = new DenseHistogram(255, new RangeF(min, max));
                hist.Calculate(new Image<Gray, byte>[] { src[i] }, true, null);
                double[] minValue, maxValue;
                Point[] minLocation;
                Point[] maxLocation;
                hist.MinMax(out minValue, out maxValue, out minLocation, out maxLocation);
                sum += maxLocation[0].Y;
            }
            return sum / i;
        }*/
        private int GetMainColor(Image<Bgr, byte> src, float min = 0, float max = 255)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(min, max));
            hist.Calculate(new Image<Gray, byte>[] { src.Convert<Gray, byte>() }, true, null);
            double[] minValue, maxValue;
            Point[] minLocation;
            Point[] maxLocation;
            hist.MinMax(out minValue, out maxValue, out minLocation, out maxLocation);
            return maxLocation[0].Y;
        }
        private int GetMainColor(Image<Gray, byte> src, float min = 0, float max = 255)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(min, max));
            hist.Calculate(new Image<Gray, byte>[] { src }, true, null);
            double[] minValue, maxValue;
            Point[] minLocation;
            Point[] maxLocation;
            hist.MinMax(out minValue, out maxValue, out minLocation, out maxLocation);
            return maxLocation[0].Y;
        }
        private void AutoSettingsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ThresholdTextBox.Enabled = !AutoSettingsCheckBox.Checked;
            SmoothTextBox.Enabled = !AutoSettingsCheckBox.Checked;
            ImageDilatingTextBox.Enabled = !AutoSettingsCheckBox.Checked;
            ImageErodingTextBox.Enabled = !AutoSettingsCheckBox.Checked;
            BrightnessTextBox.Enabled = !AutoSettingsCheckBox.Checked;
            ContrastTextBox.Enabled = !AutoSettingsCheckBox.Checked;
        }
        private void ChangeContrast(ref Bitmap inputImage, int contrast, int brightness, double autoContrastIntensity, int tileGridSize, bool autoCorrect = false)
        {
            if (contrast == 0 && brightness == 0 && !autoCorrect) return;
            var img = inputImage.ToImage<Bgr, byte>().Mat;

            if (autoCorrect)
            {
                var lab = img.ToImage<Lab, byte>().Mat;
                VectorOfMat labPlanes = new VectorOfMat();
                CvInvoke.Split(lab, labPlanes);
                for (int i = 0; i < labPlanes.Size; ++i) CvInvoke.CLAHE(labPlanes[i], autoContrastIntensity, new Size(tileGridSize, tileGridSize), labPlanes[i]);
                CvInvoke.Merge(labPlanes, lab);
                img = lab.ToImage<Bgr, byte>().Mat;
            }
            else img.ConvertTo(img, DepthType.Cv8U, 1 + contrast / 127, brightness - contrast);
            inputImage = img.ToBitmap();
            img.Dispose();

        }
        private void AutoBCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OutputBrightnessTextBox.Enabled = !AutoBCCheckBox.Checked;
            OutputContrastTextBox.Enabled = !AutoBCCheckBox.Checked;
            AutoContrastGridSizeTextBox.Enabled = AutoBCCheckBox.Checked;
            AutoContrastIntensityTextBox.Enabled = AutoBCCheckBox.Checked;
        }
        private void BC_AutoCorrectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BC_BrightnessTextBox.Enabled = !BC_AutoCorrectionCheckBox.Checked;
            BC_ContrastTextBox.Enabled = !BC_AutoCorrectionCheckBox.Checked;
            BC_AutoContrastGridSizeTextBox.Enabled = BC_AutoCorrectionCheckBox.Checked;
            BC_AutoContrastIntensityTextBox.Enabled = BC_AutoCorrectionCheckBox.Checked;
            UpdateImageBC();
        }
        private void BC_ChooseInputPathButton_Click(object sender, EventArgs e)
        {
            if (BC_IsFolderCheckBox.Checked)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Выбор папки с изображениями";
                dialog.ShowNewFolderButton = true;
                if (dialog.ShowDialog() == DialogResult.OK) { BC_InputPathTextBox.Text = dialog.SelectedPath; currentBCImageIndex = 0; }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                dialog.Title = "Выбор изображения";
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    BC_InputPathTextBox.Text = "";
                    foreach (var n in dialog.FileNames)
                    {
                        BC_InputPathTextBox.Text += n + ";";
                    }
                    if (BC_InputPathTextBox.Text.Length > 0 && BC_InputPathTextBox.Text.Last() == ';') BC_InputPathTextBox.Text = BC_InputPathTextBox.Text.Remove(BC_InputPathTextBox.Text.Length - 1, 1);
                    currentBCImageIndex = 0;
                }
            }
            SaveSettings();
            UpdateImageBC();
        }
        private void UpdateImageBC()
        {
            try
            {
                BC_CurrentImageLabel.Text = "None";
                var files = GetFilesFromPath(BC_InputPathTextBox.Text);
                if (files.Length <= currentBCImageIndex)
                {
                    if (files.Length > 0) currentBCImageIndex = 0;
                    else return;
                }
                else if (currentBCImageIndex < 0)
                {
                    if (files.Length > 0) currentBCImageIndex = files.Length - 1;
                    else return;
                }
                BC_CurrentImageLabel.Text = files[currentBCImageIndex];
                if (BC_ImagePictureBox.Image != null)
                {
                    BC_ImagePictureBox.Image.Dispose();
                    BC_ImagePictureBox.Image = null;
                }
                if (BC_PreviewSource.Image != null)
                {
                    BC_PreviewSource.Image.Dispose();
                    BC_PreviewSource.Image = null;
                }
                Bitmap source = (Bitmap)Image.FromFile(files[currentBCImageIndex]);
                BC_PreviewSource.Image = DeepCopy(source);
                ChangeContrast(ref source, Convert.ToInt32(BC_ContrastTextBox.Text), Convert.ToInt32(BC_BrightnessTextBox.Text), double.Parse(BC_AutoContrastIntensityTextBox.Text.Replace(".", ",")), Convert.ToInt32(BC_AutoContrastGridSizeTextBox.Text), BC_AutoCorrectionCheckBox.Checked);
                BC_ImagePictureBox.Image = DeepCopy(source);
                source.Dispose();
            }
            catch
            {
                BC_CurrentImageLabel.Text = "None";
                if (BC_ImagePictureBox.Image != null)
                {
                    BC_ImagePictureBox.Image.Dispose();
                    BC_ImagePictureBox.Image = null;
                }
                if (BC_PreviewSource.Image != null)
                {
                    BC_PreviewSource.Image.Dispose();
                    BC_PreviewSource.Image = null;
                }
            }
        }
        private void BC_ApplyButton_Click(object sender, EventArgs e) => UpdateImageBC();
        private void BC_LeftArrowPictureBox_Click(object sender, EventArgs e)
        {
            var files = GetFilesFromPath(BC_InputPathTextBox.Text);
            --currentBCImageIndex;
            if (currentBCImageIndex < 0) currentBCImageIndex = files.Length - 1;
            UpdateImageBC();
        }
        private void BC_RightArrowPictureBox_Click(object sender, EventArgs e)
        {
            var files = GetFilesFromPath(BC_InputPathTextBox.Text);
            ++currentBCImageIndex;
            if (currentBCImageIndex >= files.Length) currentBCImageIndex = 0;
            UpdateImageBC();
        }
        private void BC_LeftArrowPanel_Click(object sender, EventArgs e) => BC_LeftArrowPictureBox_Click(null, null);
        private void BC_RightArrowPanel_Click(object sender, EventArgs e) => BC_RightArrowPictureBox_Click(null, null);
        private void BC_IsFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BC_InputPathTextBox.Text)) return;
            if (!IsDir(BC_InputPathTextBox.Text) && BC_IsFolderCheckBox.Checked)
            {
                string res = "";
                if (BC_InputPathTextBox.Text.Contains(';')) { var s = BC_InputPathTextBox.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[0]; res += s.Replace(Path.GetFileName(s), ""); }
                else res = BC_InputPathTextBox.Text.Replace(Path.GetFileName(BC_InputPathTextBox.Text), "");
                if (res.Last() == ';') res = res.Remove(res.Length - 1, 1);
                BC_InputPathTextBox.Text = res;
            }
            else if (!BC_IsFolderCheckBox.Checked) BC_InputPathTextBox.Text = "";
        }
        private void BC_ChooseOutputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Выбор папки для сохранения результатов";
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK) BC_OutputPathTextBox.Text = dialog.SelectedPath;
        }
        private void BC_StartButton_Click(object sender, EventArgs e) => BC_Start();
        private void BC_Start()
        {
            SaveSettings();
            int brightness = 0;
            int contrast = 0;
            double intensity = 0;
            int gridSize = 0;
            bool autoCorrection = BC_AutoCorrectionCheckBox.Checked;
            string outputFolderPath = BC_OutputPathTextBox.Text;
            if (!autoCorrection)
            {
                try { brightness = Convert.ToInt32(BC_BrightnessTextBox.Text); } catch { MessageBox.Show("Яркость указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                try { contrast = Convert.ToInt32(BC_ContrastTextBox.Text); } catch { MessageBox.Show("Контраст указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            else
            {
                try { intensity = double.Parse(BC_AutoContrastIntensityTextBox.Text.Replace(".", ",")); } catch { MessageBox.Show("Интенсивность автокоррекции указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                try { gridSize = Convert.ToInt32(BC_AutoContrastGridSizeTextBox.Text); } catch { MessageBox.Show("Размер сетки автокоррекции указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            if (!Directory.Exists(outputFolderPath))
            {
                MessageBox.Show("Папка для результатов указана неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BC_SaveFormatComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Формат сохранения указан неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProcessingForm form = new ProcessingForm();
            form.Show();
            Hide();
            var cancelToken = new CancellationTokenSource();
            bool isCanceling = false;
            var files = GetFilesFromPath(BC_InputPathTextBox.Text, true);
            int formatIndex = BC_SaveFormatComboBox.SelectedIndex;
            var task = Task.Run(() =>
            {
                try
                {
                    form.bar.Invoke((MethodInvoker)delegate () {
                        form.bar.Maximum = files.Length;
                        form.bar.Value = 0;
                    });
                    form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Обработка начата."); form.log.Lines = form.log.Lines.Append("").ToArray(); });

                    foreach (var f in files)
                    {
                        string file = "";
                        file = f.Split(new string[] { folderMarker }, StringSplitOptions.None)[0];
                        form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Обработка изображения {file}..."); form.log.Lines = form.log.Lines.Append("").ToArray(); });
                        var copy = Image.FromFile(file);
                        Bitmap img = DeepCopy(copy);
                        copy.Dispose();
                        ChangeContrast(ref img, contrast, brightness, intensity, gridSize, autoCorrection);
                        ImageFormat imgFormat = ImageFormat.Jpeg;
                        switch (formatIndex)
                        {
                            case 0: imgFormat = ImageFormat.Png; break;
                            case 1: imgFormat = ImageFormat.Jpeg; break;
                            case 2: imgFormat = ImageFormat.Bmp; break;
                            default: imgFormat = ImageFormat.Jpeg; break;
                        }
                        string folderPath = "";
                        folderPath = outputFolderPath + f.Split(new string[] { folderMarker }, StringSplitOptions.None)[1] + (outputFolderPath.Last() == Path.DirectorySeparatorChar ? "" : Path.DirectorySeparatorChar + "");
                        Directory.CreateDirectory(folderPath);
                        img.Save(folderPath + Path.GetFileNameWithoutExtension(file) + GetFilenameExtension(imgFormat), imgFormat);
                        img.Dispose();
                        form.log.Invoke((MethodInvoker)delegate () { form.log.AppendText($"[{DateTime.Now.ToLongTimeString()}] Результат сохранён."); form.log.Lines = form.log.Lines.Append("").ToArray(); form.log.Lines = form.log.Lines.Append("").ToArray(); });
                        form.bar.Invoke((MethodInvoker)delegate () { form.bar.Value++; });

                    }
                    MessageBox.Show($"Обработка завершена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Invoke((MethodInvoker)delegate () { form.Close(); });
                    Invoke((MethodInvoker)delegate () { Show(); });
                }
                catch (Exception ex) { if (!isCanceling) { MessageBox.Show($"Ошибка при обработке. {ex.Message} - строка {ex.LineNumber()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); form.Close(); Invoke((MethodInvoker)delegate () { Show(); }); } return; }
            }, cancelToken.Token);
            form.OnCancelOperation += Form_OnCancelOperation;
            void Form_OnCancelOperation(ProcessingForm senderF)
            {
                isCanceling = true;
                cancelToken.Cancel();
                Show();
                senderF.Close();
            }
        }
        private void BC_ResetButton_Click(object sender, EventArgs e)
        {
            var set = new Settings();
            BC_BrightnessTextBox.Text = set.BC_Brightness;
            BC_ContrastTextBox.Text = set.BC_Contrast;
            BC_AutoContrastIntensityTextBox.Text = set.BC_autoContrastIntensity;
            BC_AutoContrastGridSizeTextBox.Text = set.BC_tileGridSize;
            BC_AutoCorrectionCheckBox.Checked = set.BC_autoBC;
            BC_SaveFormatComboBox.SelectedIndex = set.BC_saveFormat;
            SaveSettings();
            LoadSettings();
            UpdateImageBC();
        }
        private Bitmap DeepCopy(Bitmap other)
        {
            return new Bitmap(other);
        }
        private Bitmap DeepCopy(Image other)
        {
            return new Bitmap(other);
        }
        private void EENumberingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EENumberingTextBox.Enabled = EENumberingCheckBox.Checked;
        }
        private void LeftArrowPanel_Click(object sender, EventArgs e) => LeftArrowPictureBox_Click(null, null);
        private void RightArrowPanel_Click(object sender, EventArgs e) => RightArrowPictureBox_Click(null, null);
        private Bitmap LowerBitmapResolution(Bitmap source, float multiplier)
        {
            if (multiplier <= 0) return new Bitmap(source);
            return LowerBitmapResolution(source.ToImage<Bgr, byte>(), multiplier).ToBitmap();
        }
        private Bitmap LowerBitmapResolution(Bitmap source, int size)
        {
            if (size <= 0) return new Bitmap(source);
            var ratio = source.Width > source.Height ? source.Height / (float)source.Width : (float)source.Width / source.Height;
            Size newSize = new Size(source.Width > source.Height ? size : (int)(size * ratio), source.Width > source.Height ? (int)(size * ratio) : size);
            Bitmap dst = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(dst))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, (size - newSize.Width) / 2, (size - newSize.Height) / 2, newSize.Width, newSize.Height);
            }
            return dst;
        }
        private Image<Bgr, byte> LowerBitmapResolution(Image<Bgr, byte> source, float multiplier)
        {
            if (multiplier <= 0 || multiplier == 1) return source.Copy();
            Size size = new Size((int)(source.Width * multiplier), (int)(source.Height * multiplier));
            Image<Bgr, byte> result = new Image<Bgr, byte>(size);
            CvInvoke.Resize(source, result, size);
            return result;
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (TabControl.SelectedIndex == 0) UpdateImage();
            if(TabControl.SelectedIndex > 0)
            {
                SaveSettings();
                LoadSettings();
                var l = new Settings();
                l.Load(appData + settingsFileName);
                lastUpdated = l;
                lastUpdated.autoBC = set.autoBC;
                lastUpdated.detectionResolution = set.detectionResolution;
            }
            else if(TabControl.SelectedIndex == 0)
            {
                SaveSettings();
                bool needUpdate = lastUpdated.minXSize != set.minXSize || lastUpdated.minYSize != set.minYSize || lastUpdated.threshold != set.threshold || lastUpdated.smooth != set.smooth ||
                lastUpdated.imageDilating != set.imageDilating || lastUpdated.imageEroding != set.imageEroding || lastUpdated.brightness != set.brightness || lastUpdated.contrast != set.contrast ||
                lastUpdated.detectionResolution != set.detectionResolution || lastUpdated.autoSettings != set.autoSettings || lastUpdated.disableSeparatingInPrewiew != set.disableSeparatingInPrewiew ||
                lastUpdated.presetIndex != set.presetIndex || lastUpdated.outputBrightness != set.outputBrightness || lastUpdated.outputContrast != set.outputContrast || lastUpdated.tileGridSize != set.tileGridSize ||
                lastUpdated.autoContrastIntensity != set.autoContrastIntensity || lastUpdated.autoBC != set.autoBC;
                Console.WriteLine(needUpdate);
                if (needUpdate) UpdateImage();
            }
        }
        private void BorderThiknessTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != BorderThiknessTextBox.Text.Trim()) UpdateImage(); }
        private void BorderThiknessTextBox_Enter(object sender, EventArgs e) => currentEdit = BorderThiknessTextBox.Text;
        private void XDistTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != XDistTextBox.Text.Trim()) UpdateImage(); }
        private void XDistTextBox_Enter(object sender, EventArgs e) => currentEdit = XDistTextBox.Text;
        private void YDistTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != YDistTextBox.Text.Trim()) UpdateImage(); }
        private void YDistTextBox_Enter(object sender, EventArgs e) => currentEdit = YDistTextBox.Text;
        private void RotateCheckBox_Click(object sender, EventArgs e) => UpdateImage();
        private void SeparateCheckBox_Click(object sender, EventArgs e) => UpdateImage();
        private void GrayPreviewSwitchButton_Click(object sender, EventArgs e)
        {
            isGrayView = !isGrayView;
            GrayPreviewButtonTextUpdate();
            UpdateImage();
        }
        private void GrayPreviewButtonTextUpdate() => GrayPreviewSwitchButton.Text = GrayPreviewSwitchButton_2.Text = GrayPreviewSwitchButton_3.Text = isGrayView ? "Изобр." : "Ч/Б";
        private void DisplayTabControl_SelectedIndexChanged(object sender, EventArgs e) { }//=> UpdateFilesExplorer();
        private void FilesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var senderList = (ListView)sender;
                var clickedItem = senderList.HitTest(e.Location).Item;
                if (clickedItem != null)
                {
                    var files = GetFilesFromPath(PathTextBox.Text);
                    if (files.Length != FilesListView.Items.Count) UpdateFilesExplorer();
                    Process.Start(files[clickedItem.Index]);
                }
            }
            catch { }
        }
        private void FilesListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode) DeleteSelectedFileListViewButton_Click(null, null);
        }
        private void DeleteAllFileListViewButton_Click(object sender, EventArgs e)
        {
            PathTextBox.Text = "";
            UpdateImage();
            UpdateFilesExplorer();
        }
        private void DeleteSelectedFileListViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilesListView.SelectedItems.Count <= 0) return;
                var files = GetFilesFromPath(PathTextBox.Text).ToList();
                if (files.Count != FilesListView.Items.Count) UpdateFilesExplorer();
                if (FilesListView.SelectedItems.Count <= 0) return;

                for (int i = 0; i < files.Count; ++i)
                {
                    bool contains = false;
                    var name = Path.GetFileName(files[i]);
                    foreach (var item in FilesListView.SelectedItems)
                    {
                        if (name == ((ListViewItem)item).Text)
                        {
                            contains = true;
                            break;
                        }
                    }
                    if (contains)
                    {
                        files.RemoveAt(i);
                        --i;
                    }
                }
                PathTextBox.Text = "";
                foreach (var file in files) PathTextBox.Text += file + ";";
                if (PathTextBox.Text.Length > 0 && PathTextBox.Text.Last() == ';') PathTextBox.Text = PathTextBox.Text.Remove(PathTextBox.Text.Length - 1, 1);
                UpdateImage();
                UpdateFilesExplorer();
            }
            catch { }
        }
        private void SortByNameFileListViewButton_Click(object sender, EventArgs e) => FilesListView.Sorting = SortOrder.Ascending;
        private void SortByStructureFileListViewButton_Click(object sender, EventArgs e) { FilesListView.Sorting = SortOrder.None; FilesListView.ListViewItemSorter = null; UpdateFilesExplorer(); }
        private Preset[] GetPresets()
        {
            List<Preset> set = new List<Preset>();
            var files = GetFilesFrom(presetsPath, new string[] { presetExt.Replace(".", "") }, false);
            foreach (var f in files)
            {
                try
                {
                    Preset s = new Preset();
                    s.Load(f);
                    set.Add(s);
                }
                catch { }
            }
            return set.ToArray();
        }
        private Preset[] GetPresets(out List<string> paths)
        {
            paths = new List<string>();
            List<Preset> set = new List<Preset>();
            var files = GetFilesFrom(presetsPath, new string[] { presetExt.Replace(".", "") }, false);
            foreach (var f in files)
            {
                try
                {
                    Preset s = new Preset();
                    s.Load(f);
                    set.Add(s);
                    paths.Add(f);
                }
                catch { }
            }
            return set.ToArray();
        }
        private Preset GetPreset(string path)
        {
            Preset s = new Preset();
            s.Load(path);
            return s;
        }
        private void UpdatePresets()
        {
            var pres = GetPresets();
            PresetDataGridView.Invoke((MethodInvoker)delegate ()
            { 
                PresetDataGridView.Rows.Clear();
                foreach (var p in pres) PresetDataGridView.Rows.Add(p.name);
            });
            SettingsPresetComboBox.Invoke((MethodInvoker)delegate ()
            {
                var index = SettingsPresetComboBox.SelectedIndex;
                SettingsPresetComboBox.Items.Clear();
                SettingsPresetComboBox.Items.Add("<нет>");
                foreach (var p in pres) SettingsPresetComboBox.Items.Add(p.name);
                if (index >= SettingsPresetComboBox.Items.Count) SettingsPresetComboBox.SelectedIndex = 0;
                else SettingsPresetComboBox.SelectedIndex = index;
            });
        }
        private void CreateNewPresetButton_Click(object sender, EventArgs e)
        {
            EnterNameForm form = new EnterNameForm();
            form.Show();
            Hide();
            form.OnAcceptName += Form_OnAcceptName;
            form.OnCancelName += Form_OnCancelName;
            void Form_OnAcceptName(EnterNameForm sender_, string name)
            {
                sender_.Close();
                Show();
                SaveSettings();
                var path = presetsPath + name + presetExt;
                Preset preset = new Preset();
                preset.name = name;
                preset.Save(path);
                SavePreset(name);
            }
            void Form_OnCancelName(EnterNameForm sender_)
            {
                sender_.Close();
                Show();
            }
        }
        private void DeletePresetButton_Click(object sender, EventArgs e)
        {
            if (PresetDataGridView.SelectedRows.Count <= 0)
            {
                ShowError("Ничего не выбрано.");
                return;
            }
            try
            {
                foreach (var r in PresetDataGridView.SelectedRows)
                {
                    var path = GetPresetPathByName(((DataGridViewRow)r).Cells[0].Value.ToString());
                    if (File.Exists(path)) File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка удаления: " + ex.Message + ".");
            }
            UpdatePresets();
        }
        private string GetPresetPathByName(string name)
        {
            List<string> presetsPaths;
            var presets = GetPresets(out presetsPaths);

            for (int i = 0; i < presets.Length; ++i)
            {
                if (presets[i].name.Trim() == name.Trim()) return presetsPaths[i];
            }
            return "";
        }
        private void UpdatePresetsButton_Click(object sender, EventArgs e) => UpdatePresets();
        private void PresetDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeletePresetButton_Click(null, null);
        }
        private void ImportPresetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = $"Cropper preset files (*{presetExt}) | *{presetExt}";
            dialog.Title = "Импорт пресетов";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var f in dialog.FileNames) File.Copy(f, presetsPath + Path.GetFileName(f), true);
            }
        }
        private void ExportPresetButton_Click(object sender, EventArgs e)
        {
            if(PresetDataGridView.SelectedRows.Count <= 0)
            {
                ShowError("Ничего не выбрано.");
                return;
            }
            if(PresetDataGridView.SelectedRows.Count == 1)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                var name = PresetDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                dialog.Filter = $"Cropper preset files (*{presetExt}) | *{presetExt}";
                dialog.Title = "Экспорт пресетов";
                dialog.FileName = name + presetExt;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = GetPresetPathByName(name);
                    if (path != "") File.Copy(path, dialog.FileName,true);
                    else UpdatePresets();
                }
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Экспорт пресетов";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool needUpdate = false;
                    foreach (var r in PresetDataGridView.SelectedRows)
                    {
                        var name = ((DataGridViewRow)r).Cells[0].Value.ToString();
                        var path = GetPresetPathByName(name);
                        if (path != "") File.Copy(path, dialog.SelectedPath + "\\" + name + presetExt, true);
                        else needUpdate = true;
                    }
                    if(needUpdate) UpdatePresets();
                }
            }
        }
        private void ShowError(string text, string label = "Ошибка") => MessageBox.Show(text, label, MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void ReplacePresetButton_Click(object sender, EventArgs e)
        {
            if (PresetDataGridView.SelectedRows.Count <= 0)
            {
                ShowError("Ничего не выбрано.");
                return;
            }
            foreach (var r in PresetDataGridView.SelectedRows) if (!SavePreset(((DataGridViewRow)r).Cells[0].Value.ToString())) break;
            MessageBox.Show("Сохранено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveSettingsPresetButton_Click(object sender, EventArgs e)
        {
            if(SettingsPresetComboBox.SelectedIndex <= 0 || SettingsPresetComboBox.SelectedItem == null)
            {
                ShowError("Ничего не выбрано.");
                return;
            }
            if(SavePreset(SettingsPresetComboBox.SelectedItem.ToString())) MessageBox.Show("Сохранено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool SavePreset(string name)
        {
            SaveSettings();
            try
            {
                var path = GetPresetPathByName(name);
                var preset = GetPreset(path);
                preset.settings = set;
                preset.settings.BC_outputPath = "";
                preset.settings.outputPath = "";
                preset.Save(path);
                UpdatePresets();
            }
            catch (Exception ex) { ShowError("Ошибка сохранения: " + ex.Message); return false; }
            return true;
        }
        private void SettingsPresetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SettingsPresetComboBox.SelectedIndex <= 0) return;
            try
            {
                var path = GetPresetPathByName(SettingsPresetComboBox.SelectedItem.ToString());
                var preset = GetPreset(path);
                set = preset.settings;
                LoadSettings(false,true);
                UpdateImage();
            }
            catch (Exception ex) { ShowError("Ошибка применения: " + ex.Message); }
        }
        private void BC_BrightnessTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != BC_BrightnessTextBox.Text.Trim()) UpdateImageBC(); }
        private void BC_BrightnessTextBox_Enter(object sender, EventArgs e) => currentEdit = BC_BrightnessTextBox.Text;
        private void BC_ContrastTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != BC_ContrastTextBox.Text.Trim()) UpdateImageBC(); }
        private void BC_ContrastTextBox_Enter(object sender, EventArgs e) => currentEdit = BC_ContrastTextBox.Text;
        private void BC_AutoContrastIntensityTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != BC_AutoContrastIntensityTextBox.Text.Trim()) UpdateImageBC(); }
        private void BC_AutoContrastIntensityTextBox_Enter(object sender, EventArgs e) => currentEdit = BC_AutoContrastIntensityTextBox.Text;
        private void BC_AutoContrastGridSizeTextBox_Leave(object sender, EventArgs e) { if (currentEdit.Trim() != BC_AutoContrastGridSizeTextBox.Text.Trim()) UpdateImageBC(); }
        private void BC_AutoContrastGridSizeTextBox_Enter(object sender, EventArgs e) => currentEdit = BC_AutoContrastGridSizeTextBox.Text;

        private void ResetButton_2_Click(object sender, EventArgs e) => ResetButton_Click(null, null);
        private void ChangeBorderColorButton_2_Click(object sender, EventArgs e) => ChangeBorderColorButton_Click(null, null);
        private void GrayPreviewSwitchButton_2_Click(object sender, EventArgs e) => GrayPreviewSwitchButton_Click(null, null);
        private void HelpButton_2_Click(object sender, EventArgs e) => HelpButton_Click(null, null);

        private void ResetButton_3_Click(object sender, EventArgs e) => ResetButton_Click(null, null);
        private void ChangeBorderColorButton_3_Click(object sender, EventArgs e) => ChangeBorderColorButton_Click(null, null);
        private void GrayPreviewSwitchButton_3_Click(object sender, EventArgs e) => GrayPreviewSwitchButton_Click(null, null);
        private void HelpButton_3_Click(object sender, EventArgs e) => HelpButton_Click(null, null);

        private void HelpButton_4_Click(object sender, EventArgs e) => HelpButton_Click(null, null);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}