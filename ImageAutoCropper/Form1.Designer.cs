
namespace ImageAutoCropper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.DetectButton = new System.Windows.Forms.Button();
            this.XDistTextBoxLabel = new System.Windows.Forms.Label();
            this.XDistTextBox = new System.Windows.Forms.TextBox();
            this.YDistTextBoxLabel = new System.Windows.Forms.Label();
            this.YDistTextBox = new System.Windows.Forms.TextBox();
            this.ChoosePathButton = new System.Windows.Forms.Button();
            this.ChooseFileLabel_1 = new System.Windows.Forms.Label();
            this.IsFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.BorderThiknessTextBox = new System.Windows.Forms.TextBox();
            this.BorderThiknessLabel = new System.Windows.Forms.Label();
            this.SeparateCheckBox = new System.Windows.Forms.CheckBox();
            this.EENumberingLabel = new System.Windows.Forms.Label();
            this.EENumberingTextBox = new System.Windows.Forms.TextBox();
            this.EENumberingCheckBox = new System.Windows.Forms.CheckBox();
            this.RotateCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangeBorderColorButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OutputFolderLabel = new System.Windows.Forms.Label();
            this.ChooseOutputFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.BorderColorDialog = new System.Windows.Forms.ColorDialog();
            this.CurrentImageLabel_1 = new System.Windows.Forms.Label();
            this.PreviewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentImageLabel_2 = new System.Windows.Forms.Label();
            this.ImagePictureBox_2 = new System.Windows.Forms.PictureBox();
            this.ImagePictureBox_1 = new System.Windows.Forms.PictureBox();
            this.LeftArrowPanel = new System.Windows.Forms.Panel();
            this.LeftArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.RightArrowPanel = new System.Windows.Forms.Panel();
            this.RightArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.DisplayTabControl = new System.Windows.Forms.TabControl();
            this.DisplayTab = new System.Windows.Forms.TabPage();
            this.FileExplorerTab = new System.Windows.Forms.TabPage();
            this.FilesListPreviewControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SortByStructureFileListViewButton = new System.Windows.Forms.Button();
            this.SortByNameFileListViewButton = new System.Windows.Forms.Button();
            this.DeleteSelectedFileListViewButton = new System.Windows.Forms.Button();
            this.DeleteAllFileListViewButton = new System.Windows.Forms.Button();
            this.FilesListView = new System.Windows.Forms.ListView();
            this.FilesPreviewImageList = new System.Windows.Forms.ImageList(this.components);
            this.SettingsPanelScroll = new System.Windows.Forms.Panel();
            this.SaveSettingsPresetButton = new System.Windows.Forms.Button();
            this.SettingsPresetComboBox = new System.Windows.Forms.ComboBox();
            this.PXLabel_3 = new System.Windows.Forms.Label();
            this.PXLabel_2 = new System.Windows.Forms.Label();
            this.PXLabel_1 = new System.Windows.Forms.Label();
            this.GrayPreviewSwitchButton = new System.Windows.Forms.Button();
            this.SaveToFoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.DelimiterPictureBox_2 = new System.Windows.Forms.PictureBox();
            this.DelimiterPictureBox_1 = new System.Windows.Forms.PictureBox();
            this.ChooseFileLabel_2 = new System.Windows.Forms.Label();
            this.AutoContrastTabPage = new System.Windows.Forms.TabPage();
            this.LogoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Logo2PictureBox = new System.Windows.Forms.PictureBox();
            this.Logo1PictureBox = new System.Windows.Forms.PictureBox();
            this.GrayPreviewSwitchButton_2 = new System.Windows.Forms.Button();
            this.ChangeBorderColorButton_2 = new System.Windows.Forms.Button();
            this.HelpButton_2 = new System.Windows.Forms.Button();
            this.ResetButton_2 = new System.Windows.Forms.Button();
            this.AutoContrastIntensityLabel = new System.Windows.Forms.Label();
            this.AutoContrastIntensityTextBox = new System.Windows.Forms.TextBox();
            this.AutoContrastGridSizeLabel = new System.Windows.Forms.Label();
            this.AutoContrastGridSizeTextBox = new System.Windows.Forms.TextBox();
            this.AutoBCCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputBrightnessLabel = new System.Windows.Forms.Label();
            this.OutputBrightnessTextBox = new System.Windows.Forms.TextBox();
            this.OutputContrastLabel = new System.Windows.Forms.Label();
            this.OutputContrastTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalSettingsTabPage = new System.Windows.Forms.TabPage();
            this.GrayPreviewSwitchButton_3 = new System.Windows.Forms.Button();
            this.ChangeBorderColorButton_3 = new System.Windows.Forms.Button();
            this.HelpButton_3 = new System.Windows.Forms.Button();
            this.ResetButton_3 = new System.Windows.Forms.Button();
            this.PresetEditGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdatePresetsButton = new System.Windows.Forms.Button();
            this.ExportPresetButton = new System.Windows.Forms.Button();
            this.ImportPresetButton = new System.Windows.Forms.Button();
            this.DeletePresetButton = new System.Windows.Forms.Button();
            this.ReplacePresetButton = new System.Windows.Forms.Button();
            this.CreateNewPresetButton = new System.Windows.Forms.Button();
            this.PresetDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetectionResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.DetectionResolutionLabel = new System.Windows.Forms.Label();
            this.ContrastTextBox = new System.Windows.Forms.TextBox();
            this.ImageErodingTextBox = new System.Windows.Forms.TextBox();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.DisableSeparatingInPreview = new System.Windows.Forms.CheckBox();
            this.BrightnessTextBox = new System.Windows.Forms.TextBox();
            this.MinXSizeLabel = new System.Windows.Forms.Label();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.MinXSizeTextBox = new System.Windows.Forms.TextBox();
            this.MinYSizeLabel = new System.Windows.Forms.Label();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.ImageErodingLabel = new System.Windows.Forms.Label();
            this.ImageDilatingTextBox = new System.Windows.Forms.TextBox();
            this.ImageDilatingLabel = new System.Windows.Forms.Label();
            this.SmoothTextBox = new System.Windows.Forms.TextBox();
            this.ThresholdTextBox = new System.Windows.Forms.TextBox();
            this.SmoothLabel = new System.Windows.Forms.Label();
            this.MinYSizeTextBox = new System.Windows.Forms.TextBox();
            this.AutoSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveFormatComboBox = new System.Windows.Forms.ComboBox();
            this.SaveFormatLabel = new System.Windows.Forms.Label();
            this.BrightnessAndContrastControlTab = new System.Windows.Forms.TabPage();
            this.BC_SettingsPanelScroll = new System.Windows.Forms.Panel();
            this.BC_InputPathTextBox = new System.Windows.Forms.TextBox();
            this.DelimiterPictureBox_3 = new System.Windows.Forms.PictureBox();
            this.BC_ContrastTextBox = new System.Windows.Forms.TextBox();
            this.BC_IsFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.BC_InputPathLabel = new System.Windows.Forms.Label();
            this.HelpButton_4 = new System.Windows.Forms.Button();
            this.BC_InputPathLabel_2 = new System.Windows.Forms.Label();
            this.BC_ContrastLabel = new System.Windows.Forms.Label();
            this.BC_ResetButton = new System.Windows.Forms.Button();
            this.BC_ChooseInputPathButton = new System.Windows.Forms.Button();
            this.BC_SaveFormatComboBox = new System.Windows.Forms.ComboBox();
            this.BC_BrightnessTextBox = new System.Windows.Forms.TextBox();
            this.BC_OutputPathTextBox = new System.Windows.Forms.TextBox();
            this.BC_SaveFormatLabel = new System.Windows.Forms.Label();
            this.BC_BrightnessLabel = new System.Windows.Forms.Label();
            this.BC_StartButton = new System.Windows.Forms.Button();
            this.BC_AutoCorrectionCheckBox = new System.Windows.Forms.CheckBox();
            this.BC_AutoContrastIntensityLabel = new System.Windows.Forms.Label();
            this.BC_ChooseOutputPathButton = new System.Windows.Forms.Button();
            this.BC_AutoContrastIntensityTextBox = new System.Windows.Forms.TextBox();
            this.BC_AutoContrastGridSizeTextBox = new System.Windows.Forms.TextBox();
            this.BC_AutoContrastGridSizeLabel = new System.Windows.Forms.Label();
            this.BC_OutputPathLabel = new System.Windows.Forms.Label();
            this.BC_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BC_RightArrowPanel = new System.Windows.Forms.Panel();
            this.BC_RightArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.BC_LeftArrowPanel = new System.Windows.Forms.Panel();
            this.BC_LeftArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.BC_SourceImageLabel = new System.Windows.Forms.Label();
            this.BC_CurrentImageLabel = new System.Windows.Forms.Label();
            this.BC_PreviewSource = new System.Windows.Forms.PictureBox();
            this.BC_ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.PreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox_1)).BeginInit();
            this.LeftArrowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPictureBox)).BeginInit();
            this.RightArrowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPictureBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.DisplayTabControl.SuspendLayout();
            this.DisplayTab.SuspendLayout();
            this.FileExplorerTab.SuspendLayout();
            this.FilesListPreviewControlPanel.SuspendLayout();
            this.SettingsPanelScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelimiterPictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelimiterPictureBox_1)).BeginInit();
            this.AutoContrastTabPage.SuspendLayout();
            this.LogoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1PictureBox)).BeginInit();
            this.AdditionalSettingsTabPage.SuspendLayout();
            this.PresetEditGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresetDataGridView)).BeginInit();
            this.BrightnessAndContrastControlTab.SuspendLayout();
            this.BC_SettingsPanelScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelimiterPictureBox_3)).BeginInit();
            this.BC_TableLayoutPanel.SuspendLayout();
            this.BC_RightArrowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BC_RightArrowPictureBox)).BeginInit();
            this.BC_LeftArrowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BC_LeftArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_PreviewSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTextBox.Location = new System.Drawing.Point(13, 44);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(306, 26);
            this.PathTextBox.TabIndex = 1;
            // 
            // DetectButton
            // 
            this.DetectButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectButton.Location = new System.Drawing.Point(83, 581);
            this.DetectButton.Name = "DetectButton";
            this.DetectButton.Size = new System.Drawing.Size(257, 45);
            this.DetectButton.TabIndex = 2;
            this.DetectButton.Text = "Старт";
            this.DetectButton.UseVisualStyleBackColor = true;
            this.DetectButton.Click += new System.EventHandler(this.DetectButton_Click);
            // 
            // XDistTextBoxLabel
            // 
            this.XDistTextBoxLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XDistTextBoxLabel.Location = new System.Drawing.Point(10, 196);
            this.XDistTextBoxLabel.Name = "XDistTextBoxLabel";
            this.XDistTextBoxLabel.Size = new System.Drawing.Size(225, 26);
            this.XDistTextBoxLabel.TabIndex = 3;
            this.XDistTextBoxLabel.Text = "Объединить по горизонтали";
            this.XDistTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // XDistTextBox
            // 
            this.XDistTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XDistTextBox.Location = new System.Drawing.Point(241, 196);
            this.XDistTextBox.MaxLength = 12;
            this.XDistTextBox.Name = "XDistTextBox";
            this.XDistTextBox.Size = new System.Drawing.Size(164, 26);
            this.XDistTextBox.TabIndex = 4;
            this.XDistTextBox.Text = "0";
            this.XDistTextBox.Enter += new System.EventHandler(this.XDistTextBox_Enter);
            this.XDistTextBox.Leave += new System.EventHandler(this.XDistTextBox_Leave);
            // 
            // YDistTextBoxLabel
            // 
            this.YDistTextBoxLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YDistTextBoxLabel.Location = new System.Drawing.Point(13, 239);
            this.YDistTextBoxLabel.Name = "YDistTextBoxLabel";
            this.YDistTextBoxLabel.Size = new System.Drawing.Size(222, 26);
            this.YDistTextBoxLabel.TabIndex = 5;
            this.YDistTextBoxLabel.Text = "Объединить по вертикали";
            this.YDistTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YDistTextBox
            // 
            this.YDistTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YDistTextBox.Location = new System.Drawing.Point(241, 239);
            this.YDistTextBox.MaxLength = 12;
            this.YDistTextBox.Name = "YDistTextBox";
            this.YDistTextBox.Size = new System.Drawing.Size(164, 26);
            this.YDistTextBox.TabIndex = 6;
            this.YDistTextBox.Text = "0";
            this.YDistTextBox.Enter += new System.EventHandler(this.YDistTextBox_Enter);
            this.YDistTextBox.Leave += new System.EventHandler(this.YDistTextBox_Leave);
            // 
            // ChoosePathButton
            // 
            this.ChoosePathButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePathButton.Location = new System.Drawing.Point(325, 44);
            this.ChoosePathButton.Name = "ChoosePathButton";
            this.ChoosePathButton.Size = new System.Drawing.Size(80, 26);
            this.ChoosePathButton.TabIndex = 7;
            this.ChoosePathButton.Text = "Выбор";
            this.ChoosePathButton.UseVisualStyleBackColor = true;
            this.ChoosePathButton.Click += new System.EventHandler(this.ChoosePathButton_Click);
            // 
            // ChooseFileLabel_1
            // 
            this.ChooseFileLabel_1.AutoSize = true;
            this.ChooseFileLabel_1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileLabel_1.Location = new System.Drawing.Point(11, 19);
            this.ChooseFileLabel_1.Name = "ChooseFileLabel_1";
            this.ChooseFileLabel_1.Size = new System.Drawing.Size(125, 18);
            this.ChooseFileLabel_1.TabIndex = 8;
            this.ChooseFileLabel_1.Text = "Входной путь (";
            // 
            // IsFolderCheckBox
            // 
            this.IsFolderCheckBox.AutoSize = true;
            this.IsFolderCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsFolderCheckBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsFolderCheckBox.Location = new System.Drawing.Point(130, 19);
            this.IsFolderCheckBox.Name = "IsFolderCheckBox";
            this.IsFolderCheckBox.Size = new System.Drawing.Size(74, 22);
            this.IsFolderCheckBox.TabIndex = 9;
            this.IsFolderCheckBox.Text = "Папка";
            this.IsFolderCheckBox.UseVisualStyleBackColor = true;
            this.IsFolderCheckBox.CheckedChanged += new System.EventHandler(this.IsFolderCheckBox_CheckedChanged);
            // 
            // BorderThiknessTextBox
            // 
            this.BorderThiknessTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderThiknessTextBox.Location = new System.Drawing.Point(241, 153);
            this.BorderThiknessTextBox.MaxLength = 12;
            this.BorderThiknessTextBox.Name = "BorderThiknessTextBox";
            this.BorderThiknessTextBox.Size = new System.Drawing.Size(164, 26);
            this.BorderThiknessTextBox.TabIndex = 8;
            this.BorderThiknessTextBox.Text = "0";
            this.BorderThiknessTextBox.Enter += new System.EventHandler(this.BorderThiknessTextBox_Enter);
            this.BorderThiknessTextBox.Leave += new System.EventHandler(this.BorderThiknessTextBox_Leave);
            // 
            // BorderThiknessLabel
            // 
            this.BorderThiknessLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderThiknessLabel.Location = new System.Drawing.Point(83, 153);
            this.BorderThiknessLabel.Name = "BorderThiknessLabel";
            this.BorderThiknessLabel.Size = new System.Drawing.Size(152, 26);
            this.BorderThiknessLabel.TabIndex = 7;
            this.BorderThiknessLabel.Text = "Рамка";
            this.BorderThiknessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SeparateCheckBox
            // 
            this.SeparateCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeparateCheckBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparateCheckBox.Location = new System.Drawing.Point(14, 500);
            this.SeparateCheckBox.Name = "SeparateCheckBox";
            this.SeparateCheckBox.Size = new System.Drawing.Size(242, 22);
            this.SeparateCheckBox.TabIndex = 8;
            this.SeparateCheckBox.Text = "Отсеивание \"мусора\"";
            this.SeparateCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeparateCheckBox.UseVisualStyleBackColor = true;
            this.SeparateCheckBox.Click += new System.EventHandler(this.SeparateCheckBox_Click);
            // 
            // EENumberingLabel
            // 
            this.EENumberingLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EENumberingLabel.Location = new System.Drawing.Point(13, 391);
            this.EENumberingLabel.Name = "EENumberingLabel";
            this.EENumberingLabel.Size = new System.Drawing.Size(222, 26);
            this.EENumberingLabel.TabIndex = 33;
            this.EENumberingLabel.Text = "Начинать нумерацию с";
            this.EENumberingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EENumberingTextBox
            // 
            this.EENumberingTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EENumberingTextBox.Location = new System.Drawing.Point(241, 391);
            this.EENumberingTextBox.MaxLength = 12;
            this.EENumberingTextBox.Name = "EENumberingTextBox";
            this.EENumberingTextBox.Size = new System.Drawing.Size(164, 26);
            this.EENumberingTextBox.TabIndex = 32;
            this.EENumberingTextBox.Text = "1";
            // 
            // EENumberingCheckBox
            // 
            this.EENumberingCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EENumberingCheckBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EENumberingCheckBox.Location = new System.Drawing.Point(13, 348);
            this.EENumberingCheckBox.Name = "EENumberingCheckBox";
            this.EENumberingCheckBox.Size = new System.Drawing.Size(243, 22);
            this.EENumberingCheckBox.TabIndex = 31;
            this.EENumberingCheckBox.Text = "Сквозная нумерация";
            this.EENumberingCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EENumberingCheckBox.UseVisualStyleBackColor = true;
            this.EENumberingCheckBox.CheckedChanged += new System.EventHandler(this.EENumberingCheckBox_CheckedChanged);
            // 
            // RotateCheckBox
            // 
            this.RotateCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RotateCheckBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateCheckBox.Location = new System.Drawing.Point(13, 282);
            this.RotateCheckBox.Name = "RotateCheckBox";
            this.RotateCheckBox.Size = new System.Drawing.Size(243, 22);
            this.RotateCheckBox.TabIndex = 30;
            this.RotateCheckBox.Text = "Автовыравнивание";
            this.RotateCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RotateCheckBox.UseVisualStyleBackColor = true;
            this.RotateCheckBox.Click += new System.EventHandler(this.RotateCheckBox_Click);
            // 
            // ChangeBorderColorButton
            // 
            this.ChangeBorderColorButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBorderColorButton.Location = new System.Drawing.Point(122, 720);
            this.ChangeBorderColorButton.Name = "ChangeBorderColorButton";
            this.ChangeBorderColorButton.Size = new System.Drawing.Size(83, 29);
            this.ChangeBorderColorButton.TabIndex = 17;
            this.ChangeBorderColorButton.Text = "Рамка";
            this.ChangeBorderColorButton.UseVisualStyleBackColor = true;
            this.ChangeBorderColorButton.Click += new System.EventHandler(this.ChangeBorderColorButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(314, 720);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(83, 29);
            this.HelpButton.TabIndex = 20;
            this.HelpButton.Text = "Помощь";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(26, 720);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(83, 29);
            this.ResetButton.TabIndex = 17;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OutputFolderLabel
            // 
            this.OutputFolderLabel.AutoSize = true;
            this.OutputFolderLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFolderLabel.Location = new System.Drawing.Point(13, 85);
            this.OutputFolderLabel.Name = "OutputFolderLabel";
            this.OutputFolderLabel.Size = new System.Drawing.Size(125, 18);
            this.OutputFolderLabel.TabIndex = 16;
            this.OutputFolderLabel.Text = "Выходной путь";
            // 
            // ChooseOutputFolderButton
            // 
            this.ChooseOutputFolderButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOutputFolderButton.Location = new System.Drawing.Point(325, 110);
            this.ChooseOutputFolderButton.Name = "ChooseOutputFolderButton";
            this.ChooseOutputFolderButton.Size = new System.Drawing.Size(80, 26);
            this.ChooseOutputFolderButton.TabIndex = 15;
            this.ChooseOutputFolderButton.Text = "Выбор";
            this.ChooseOutputFolderButton.UseVisualStyleBackColor = true;
            this.ChooseOutputFolderButton.Click += new System.EventHandler(this.ChooseOutputFolderButton_Click);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFolderTextBox.Location = new System.Drawing.Point(13, 110);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.ReadOnly = true;
            this.OutputFolderTextBox.Size = new System.Drawing.Size(306, 26);
            this.OutputFolderTextBox.TabIndex = 14;
            // 
            // CurrentImageLabel_1
            // 
            this.CurrentImageLabel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentImageLabel_1.Location = new System.Drawing.Point(53, 0);
            this.CurrentImageLabel_1.Name = "CurrentImageLabel_1";
            this.CurrentImageLabel_1.Size = new System.Drawing.Size(485, 20);
            this.CurrentImageLabel_1.TabIndex = 19;
            this.CurrentImageLabel_1.Text = "None";
            this.CurrentImageLabel_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPanel.ColumnCount = 4;
            this.PreviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PreviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PreviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PreviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.PreviewPanel.Controls.Add(this.CurrentImageLabel_2, 2, 0);
            this.PreviewPanel.Controls.Add(this.CurrentImageLabel_1, 1, 0);
            this.PreviewPanel.Controls.Add(this.ImagePictureBox_2, 2, 1);
            this.PreviewPanel.Controls.Add(this.ImagePictureBox_1, 1, 1);
            this.PreviewPanel.Controls.Add(this.LeftArrowPanel, 0, 1);
            this.PreviewPanel.Controls.Add(this.RightArrowPanel, 3, 1);
            this.PreviewPanel.Location = new System.Drawing.Point(0, 3);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.RowCount = 2;
            this.PreviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PreviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PreviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PreviewPanel.Size = new System.Drawing.Size(1084, 781);
            this.PreviewPanel.TabIndex = 20;
            // 
            // CurrentImageLabel_2
            // 
            this.CurrentImageLabel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentImageLabel_2.Location = new System.Drawing.Point(544, 0);
            this.CurrentImageLabel_2.Name = "CurrentImageLabel_2";
            this.CurrentImageLabel_2.Size = new System.Drawing.Size(485, 20);
            this.CurrentImageLabel_2.TabIndex = 41;
            this.CurrentImageLabel_2.Text = "None";
            this.CurrentImageLabel_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagePictureBox_2
            // 
            this.ImagePictureBox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePictureBox_2.Location = new System.Drawing.Point(544, 23);
            this.ImagePictureBox_2.Name = "ImagePictureBox_2";
            this.ImagePictureBox_2.Size = new System.Drawing.Size(485, 755);
            this.ImagePictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox_2.TabIndex = 13;
            this.ImagePictureBox_2.TabStop = false;
            // 
            // ImagePictureBox_1
            // 
            this.ImagePictureBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePictureBox_1.Location = new System.Drawing.Point(53, 23);
            this.ImagePictureBox_1.Name = "ImagePictureBox_1";
            this.ImagePictureBox_1.Size = new System.Drawing.Size(485, 755);
            this.ImagePictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox_1.TabIndex = 0;
            this.ImagePictureBox_1.TabStop = false;
            // 
            // LeftArrowPanel
            // 
            this.LeftArrowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LeftArrowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftArrowPanel.Controls.Add(this.LeftArrowPictureBox);
            this.LeftArrowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftArrowPanel.Location = new System.Drawing.Point(3, 23);
            this.LeftArrowPanel.Name = "LeftArrowPanel";
            this.LeftArrowPanel.Size = new System.Drawing.Size(44, 755);
            this.LeftArrowPanel.TabIndex = 18;
            this.LeftArrowPanel.Click += new System.EventHandler(this.LeftArrowPanel_Click);
            // 
            // LeftArrowPictureBox
            // 
            this.LeftArrowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LeftArrowPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LeftArrowPictureBox.Image = global::ImageAutoCropper.Properties.Resources.arrow;
            this.LeftArrowPictureBox.Location = new System.Drawing.Point(6, 3);
            this.LeftArrowPictureBox.Name = "LeftArrowPictureBox";
            this.LeftArrowPictureBox.Size = new System.Drawing.Size(30, 750);
            this.LeftArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftArrowPictureBox.TabIndex = 17;
            this.LeftArrowPictureBox.TabStop = false;
            this.LeftArrowPictureBox.Click += new System.EventHandler(this.LeftArrowPictureBox_Click);
            // 
            // RightArrowPanel
            // 
            this.RightArrowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RightArrowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightArrowPanel.Controls.Add(this.RightArrowPictureBox);
            this.RightArrowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightArrowPanel.Location = new System.Drawing.Point(1035, 23);
            this.RightArrowPanel.Name = "RightArrowPanel";
            this.RightArrowPanel.Size = new System.Drawing.Size(46, 755);
            this.RightArrowPanel.TabIndex = 19;
            this.RightArrowPanel.Click += new System.EventHandler(this.RightArrowPanel_Click);
            // 
            // RightArrowPictureBox
            // 
            this.RightArrowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RightArrowPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RightArrowPictureBox.Image = global::ImageAutoCropper.Properties.Resources.arrow_2;
            this.RightArrowPictureBox.Location = new System.Drawing.Point(7, 3);
            this.RightArrowPictureBox.Name = "RightArrowPictureBox";
            this.RightArrowPictureBox.Size = new System.Drawing.Size(30, 750);
            this.RightArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightArrowPictureBox.TabIndex = 18;
            this.RightArrowPictureBox.TabStop = false;
            this.RightArrowPictureBox.Click += new System.EventHandler(this.RightArrowPictureBox_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.MainTab);
            this.TabControl.Controls.Add(this.AutoContrastTabPage);
            this.TabControl.Controls.Add(this.AdditionalSettingsTabPage);
            this.TabControl.Controls.Add(this.BrightnessAndContrastControlTab);
            this.TabControl.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1530, 848);
            this.TabControl.TabIndex = 31;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.DisplayTabControl);
            this.MainTab.Controls.Add(this.SettingsPanelScroll);
            this.MainTab.Location = new System.Drawing.Point(4, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1522, 817);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Основное";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // DisplayTabControl
            // 
            this.DisplayTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayTabControl.Controls.Add(this.DisplayTab);
            this.DisplayTabControl.Controls.Add(this.FileExplorerTab);
            this.DisplayTabControl.Location = new System.Drawing.Point(427, 0);
            this.DisplayTabControl.Name = "DisplayTabControl";
            this.DisplayTabControl.SelectedIndex = 0;
            this.DisplayTabControl.Size = new System.Drawing.Size(1095, 818);
            this.DisplayTabControl.TabIndex = 22;
            this.DisplayTabControl.SelectedIndexChanged += new System.EventHandler(this.DisplayTabControl_SelectedIndexChanged);
            // 
            // DisplayTab
            // 
            this.DisplayTab.Controls.Add(this.PreviewPanel);
            this.DisplayTab.Location = new System.Drawing.Point(4, 27);
            this.DisplayTab.Name = "DisplayTab";
            this.DisplayTab.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayTab.Size = new System.Drawing.Size(1087, 787);
            this.DisplayTab.TabIndex = 0;
            this.DisplayTab.Text = "Предпросмотр";
            this.DisplayTab.UseVisualStyleBackColor = true;
            // 
            // FileExplorerTab
            // 
            this.FileExplorerTab.Controls.Add(this.FilesListPreviewControlPanel);
            this.FileExplorerTab.Controls.Add(this.FilesListView);
            this.FileExplorerTab.Location = new System.Drawing.Point(4, 22);
            this.FileExplorerTab.Name = "FileExplorerTab";
            this.FileExplorerTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileExplorerTab.Size = new System.Drawing.Size(1087, 797);
            this.FileExplorerTab.TabIndex = 1;
            this.FileExplorerTab.Text = "Файлы";
            this.FileExplorerTab.UseVisualStyleBackColor = true;
            // 
            // FilesListPreviewControlPanel
            // 
            this.FilesListPreviewControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListPreviewControlPanel.ColumnCount = 4;
            this.FilesListPreviewControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FilesListPreviewControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FilesListPreviewControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FilesListPreviewControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FilesListPreviewControlPanel.Controls.Add(this.SortByStructureFileListViewButton, 0, 0);
            this.FilesListPreviewControlPanel.Controls.Add(this.SortByNameFileListViewButton, 1, 0);
            this.FilesListPreviewControlPanel.Controls.Add(this.DeleteSelectedFileListViewButton, 2, 0);
            this.FilesListPreviewControlPanel.Controls.Add(this.DeleteAllFileListViewButton, 3, 0);
            this.FilesListPreviewControlPanel.Location = new System.Drawing.Point(0, 757);
            this.FilesListPreviewControlPanel.Name = "FilesListPreviewControlPanel";
            this.FilesListPreviewControlPanel.RowCount = 1;
            this.FilesListPreviewControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FilesListPreviewControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.FilesListPreviewControlPanel.Size = new System.Drawing.Size(1084, 40);
            this.FilesListPreviewControlPanel.TabIndex = 2;
            // 
            // SortByStructureFileListViewButton
            // 
            this.SortByStructureFileListViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortByStructureFileListViewButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByStructureFileListViewButton.Location = new System.Drawing.Point(3, 3);
            this.SortByStructureFileListViewButton.Name = "SortByStructureFileListViewButton";
            this.SortByStructureFileListViewButton.Size = new System.Drawing.Size(265, 34);
            this.SortByStructureFileListViewButton.TabIndex = 5;
            this.SortByStructureFileListViewButton.Text = "Сортировать по структуре";
            this.SortByStructureFileListViewButton.UseVisualStyleBackColor = true;
            this.SortByStructureFileListViewButton.Click += new System.EventHandler(this.SortByStructureFileListViewButton_Click);
            // 
            // SortByNameFileListViewButton
            // 
            this.SortByNameFileListViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortByNameFileListViewButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByNameFileListViewButton.Location = new System.Drawing.Point(274, 3);
            this.SortByNameFileListViewButton.Name = "SortByNameFileListViewButton";
            this.SortByNameFileListViewButton.Size = new System.Drawing.Size(265, 34);
            this.SortByNameFileListViewButton.TabIndex = 4;
            this.SortByNameFileListViewButton.Text = "Сортировать по названию";
            this.SortByNameFileListViewButton.UseVisualStyleBackColor = true;
            this.SortByNameFileListViewButton.Click += new System.EventHandler(this.SortByNameFileListViewButton_Click);
            // 
            // DeleteSelectedFileListViewButton
            // 
            this.DeleteSelectedFileListViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteSelectedFileListViewButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedFileListViewButton.Location = new System.Drawing.Point(545, 3);
            this.DeleteSelectedFileListViewButton.Name = "DeleteSelectedFileListViewButton";
            this.DeleteSelectedFileListViewButton.Size = new System.Drawing.Size(265, 34);
            this.DeleteSelectedFileListViewButton.TabIndex = 3;
            this.DeleteSelectedFileListViewButton.Text = "Удалить";
            this.DeleteSelectedFileListViewButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedFileListViewButton.Click += new System.EventHandler(this.DeleteSelectedFileListViewButton_Click);
            // 
            // DeleteAllFileListViewButton
            // 
            this.DeleteAllFileListViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAllFileListViewButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllFileListViewButton.Location = new System.Drawing.Point(816, 3);
            this.DeleteAllFileListViewButton.Name = "DeleteAllFileListViewButton";
            this.DeleteAllFileListViewButton.Size = new System.Drawing.Size(265, 34);
            this.DeleteAllFileListViewButton.TabIndex = 0;
            this.DeleteAllFileListViewButton.Text = "Удалить всё";
            this.DeleteAllFileListViewButton.UseVisualStyleBackColor = true;
            this.DeleteAllFileListViewButton.Click += new System.EventHandler(this.DeleteAllFileListViewButton_Click);
            // 
            // FilesListView
            // 
            this.FilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListView.HideSelection = false;
            this.FilesListView.LargeImageList = this.FilesPreviewImageList;
            this.FilesListView.Location = new System.Drawing.Point(3, 3);
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(1081, 754);
            this.FilesListView.TabIndex = 0;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            this.FilesListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilesListView_KeyDown);
            this.FilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesListView_MouseDoubleClick);
            // 
            // FilesPreviewImageList
            // 
            this.FilesPreviewImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FilesPreviewImageList.ImageSize = new System.Drawing.Size(64, 64);
            this.FilesPreviewImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SettingsPanelScroll
            // 
            this.SettingsPanelScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsPanelScroll.AutoScroll = true;
            this.SettingsPanelScroll.Controls.Add(this.SaveSettingsPresetButton);
            this.SettingsPanelScroll.Controls.Add(this.SettingsPresetComboBox);
            this.SettingsPanelScroll.Controls.Add(this.PXLabel_3);
            this.SettingsPanelScroll.Controls.Add(this.PXLabel_2);
            this.SettingsPanelScroll.Controls.Add(this.PXLabel_1);
            this.SettingsPanelScroll.Controls.Add(this.GrayPreviewSwitchButton);
            this.SettingsPanelScroll.Controls.Add(this.SaveToFoldersCheckBox);
            this.SettingsPanelScroll.Controls.Add(this.DelimiterPictureBox_2);
            this.SettingsPanelScroll.Controls.Add(this.DelimiterPictureBox_1);
            this.SettingsPanelScroll.Controls.Add(this.XDistTextBoxLabel);
            this.SettingsPanelScroll.Controls.Add(this.EENumberingLabel);
            this.SettingsPanelScroll.Controls.Add(this.XDistTextBox);
            this.SettingsPanelScroll.Controls.Add(this.YDistTextBoxLabel);
            this.SettingsPanelScroll.Controls.Add(this.BorderThiknessTextBox);
            this.SettingsPanelScroll.Controls.Add(this.YDistTextBox);
            this.SettingsPanelScroll.Controls.Add(this.BorderThiknessLabel);
            this.SettingsPanelScroll.Controls.Add(this.EENumberingTextBox);
            this.SettingsPanelScroll.Controls.Add(this.PathTextBox);
            this.SettingsPanelScroll.Controls.Add(this.EENumberingCheckBox);
            this.SettingsPanelScroll.Controls.Add(this.ChooseFileLabel_2);
            this.SettingsPanelScroll.Controls.Add(this.RotateCheckBox);
            this.SettingsPanelScroll.Controls.Add(this.IsFolderCheckBox);
            this.SettingsPanelScroll.Controls.Add(this.SeparateCheckBox);
            this.SettingsPanelScroll.Controls.Add(this.DetectButton);
            this.SettingsPanelScroll.Controls.Add(this.ChangeBorderColorButton);
            this.SettingsPanelScroll.Controls.Add(this.HelpButton);
            this.SettingsPanelScroll.Controls.Add(this.OutputFolderLabel);
            this.SettingsPanelScroll.Controls.Add(this.ResetButton);
            this.SettingsPanelScroll.Controls.Add(this.ChooseFileLabel_1);
            this.SettingsPanelScroll.Controls.Add(this.ChoosePathButton);
            this.SettingsPanelScroll.Controls.Add(this.ChooseOutputFolderButton);
            this.SettingsPanelScroll.Controls.Add(this.OutputFolderTextBox);
            this.SettingsPanelScroll.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsPanelScroll.Location = new System.Drawing.Point(-4, 0);
            this.SettingsPanelScroll.Name = "SettingsPanelScroll";
            this.SettingsPanelScroll.Size = new System.Drawing.Size(429, 821);
            this.SettingsPanelScroll.TabIndex = 21;
            // 
            // SaveSettingsPresetButton
            // 
            this.SaveSettingsPresetButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsPresetButton.Location = new System.Drawing.Point(218, 660);
            this.SaveSettingsPresetButton.Name = "SaveSettingsPresetButton";
            this.SaveSettingsPresetButton.Size = new System.Drawing.Size(179, 29);
            this.SaveSettingsPresetButton.TabIndex = 42;
            this.SaveSettingsPresetButton.Text = "Сохранить изменения";
            this.SaveSettingsPresetButton.UseVisualStyleBackColor = true;
            this.SaveSettingsPresetButton.Click += new System.EventHandler(this.SaveSettingsPresetButton_Click);
            // 
            // SettingsPresetComboBox
            // 
            this.SettingsPresetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingsPresetComboBox.FormattingEnabled = true;
            this.SettingsPresetComboBox.Items.AddRange(new object[] {
            "<нет>"});
            this.SettingsPresetComboBox.Location = new System.Drawing.Point(26, 660);
            this.SettingsPresetComboBox.Name = "SettingsPresetComboBox";
            this.SettingsPresetComboBox.Size = new System.Drawing.Size(179, 26);
            this.SettingsPresetComboBox.TabIndex = 41;
            this.SettingsPresetComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsPresetComboBox_SelectedIndexChanged);
            // 
            // PXLabel_3
            // 
            this.PXLabel_3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PXLabel_3.ForeColor = System.Drawing.Color.DarkGray;
            this.PXLabel_3.Location = new System.Drawing.Point(374, 242);
            this.PXLabel_3.Name = "PXLabel_3";
            this.PXLabel_3.Size = new System.Drawing.Size(23, 20);
            this.PXLabel_3.TabIndex = 40;
            this.PXLabel_3.Text = "px";
            this.PXLabel_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PXLabel_2
            // 
            this.PXLabel_2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PXLabel_2.ForeColor = System.Drawing.Color.DarkGray;
            this.PXLabel_2.Location = new System.Drawing.Point(374, 199);
            this.PXLabel_2.Name = "PXLabel_2";
            this.PXLabel_2.Size = new System.Drawing.Size(23, 20);
            this.PXLabel_2.TabIndex = 39;
            this.PXLabel_2.Text = "px";
            this.PXLabel_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PXLabel_1
            // 
            this.PXLabel_1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PXLabel_1.ForeColor = System.Drawing.Color.DarkGray;
            this.PXLabel_1.Location = new System.Drawing.Point(374, 156);
            this.PXLabel_1.Name = "PXLabel_1";
            this.PXLabel_1.Size = new System.Drawing.Size(23, 20);
            this.PXLabel_1.TabIndex = 38;
            this.PXLabel_1.Text = "px";
            this.PXLabel_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrayPreviewSwitchButton
            // 
            this.GrayPreviewSwitchButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayPreviewSwitchButton.Location = new System.Drawing.Point(218, 720);
            this.GrayPreviewSwitchButton.Name = "GrayPreviewSwitchButton";
            this.GrayPreviewSwitchButton.Size = new System.Drawing.Size(83, 29);
            this.GrayPreviewSwitchButton.TabIndex = 37;
            this.GrayPreviewSwitchButton.Text = "Ч/Б";
            this.GrayPreviewSwitchButton.UseVisualStyleBackColor = true;
            this.GrayPreviewSwitchButton.Click += new System.EventHandler(this.GrayPreviewSwitchButton_Click);
            // 
            // SaveToFoldersCheckBox
            // 
            this.SaveToFoldersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveToFoldersCheckBox.Location = new System.Drawing.Point(13, 457);
            this.SaveToFoldersCheckBox.Name = "SaveToFoldersCheckBox";
            this.SaveToFoldersCheckBox.Size = new System.Drawing.Size(243, 22);
            this.SaveToFoldersCheckBox.TabIndex = 36;
            this.SaveToFoldersCheckBox.Text = "Файлы в отдельные папки";
            this.SaveToFoldersCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveToFoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // DelimiterPictureBox_2
            // 
            this.DelimiterPictureBox_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DelimiterPictureBox_2.Location = new System.Drawing.Point(15, 434);
            this.DelimiterPictureBox_2.Name = "DelimiterPictureBox_2";
            this.DelimiterPictureBox_2.Size = new System.Drawing.Size(392, 2);
            this.DelimiterPictureBox_2.TabIndex = 35;
            this.DelimiterPictureBox_2.TabStop = false;
            // 
            // DelimiterPictureBox_1
            // 
            this.DelimiterPictureBox_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DelimiterPictureBox_1.Location = new System.Drawing.Point(15, 325);
            this.DelimiterPictureBox_1.Name = "DelimiterPictureBox_1";
            this.DelimiterPictureBox_1.Size = new System.Drawing.Size(392, 2);
            this.DelimiterPictureBox_1.TabIndex = 34;
            this.DelimiterPictureBox_1.TabStop = false;
            // 
            // ChooseFileLabel_2
            // 
            this.ChooseFileLabel_2.AutoSize = true;
            this.ChooseFileLabel_2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileLabel_2.Location = new System.Drawing.Point(205, 19);
            this.ChooseFileLabel_2.Name = "ChooseFileLabel_2";
            this.ChooseFileLabel_2.Size = new System.Drawing.Size(15, 18);
            this.ChooseFileLabel_2.TabIndex = 18;
            this.ChooseFileLabel_2.Text = ")";
            // 
            // AutoContrastTabPage
            // 
            this.AutoContrastTabPage.Controls.Add(this.LogoTableLayoutPanel);
            this.AutoContrastTabPage.Controls.Add(this.GrayPreviewSwitchButton_2);
            this.AutoContrastTabPage.Controls.Add(this.ChangeBorderColorButton_2);
            this.AutoContrastTabPage.Controls.Add(this.HelpButton_2);
            this.AutoContrastTabPage.Controls.Add(this.ResetButton_2);
            this.AutoContrastTabPage.Controls.Add(this.AutoContrastIntensityLabel);
            this.AutoContrastTabPage.Controls.Add(this.AutoContrastIntensityTextBox);
            this.AutoContrastTabPage.Controls.Add(this.AutoContrastGridSizeLabel);
            this.AutoContrastTabPage.Controls.Add(this.AutoContrastGridSizeTextBox);
            this.AutoContrastTabPage.Controls.Add(this.AutoBCCheckBox);
            this.AutoContrastTabPage.Controls.Add(this.OutputBrightnessLabel);
            this.AutoContrastTabPage.Controls.Add(this.OutputBrightnessTextBox);
            this.AutoContrastTabPage.Controls.Add(this.OutputContrastLabel);
            this.AutoContrastTabPage.Controls.Add(this.OutputContrastTextBox);
            this.AutoContrastTabPage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoContrastTabPage.Location = new System.Drawing.Point(4, 27);
            this.AutoContrastTabPage.Name = "AutoContrastTabPage";
            this.AutoContrastTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AutoContrastTabPage.Size = new System.Drawing.Size(1522, 817);
            this.AutoContrastTabPage.TabIndex = 2;
            this.AutoContrastTabPage.Text = "Автоконтраст";
            this.AutoContrastTabPage.UseVisualStyleBackColor = true;
            // 
            // LogoTableLayoutPanel
            // 
            this.LogoTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoTableLayoutPanel.ColumnCount = 4;
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.LogoTableLayoutPanel.Controls.Add(this.Logo2PictureBox, 3, 0);
            this.LogoTableLayoutPanel.Controls.Add(this.Logo1PictureBox, 1, 0);
            this.LogoTableLayoutPanel.Location = new System.Drawing.Point(376, 54);
            this.LogoTableLayoutPanel.Name = "LogoTableLayoutPanel";
            this.LogoTableLayoutPanel.RowCount = 1;
            this.LogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LogoTableLayoutPanel.Size = new System.Drawing.Size(1137, 90);
            this.LogoTableLayoutPanel.TabIndex = 51;
            // 
            // Logo2PictureBox
            // 
            this.Logo2PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo2PictureBox.Image = global::ImageAutoCropper.Properties.Resources.Logo2;
            this.Logo2PictureBox.Location = new System.Drawing.Point(832, 3);
            this.Logo2PictureBox.Name = "Logo2PictureBox";
            this.Logo2PictureBox.Size = new System.Drawing.Size(302, 84);
            this.Logo2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo2PictureBox.TabIndex = 50;
            this.Logo2PictureBox.TabStop = false;
            // 
            // Logo1PictureBox
            // 
            this.Logo1PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo1PictureBox.Image = global::ImageAutoCropper.Properties.Resources.Logo1;
            this.Logo1PictureBox.Location = new System.Drawing.Point(475, 3);
            this.Logo1PictureBox.Name = "Logo1PictureBox";
            this.Logo1PictureBox.Size = new System.Drawing.Size(299, 84);
            this.Logo1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo1PictureBox.TabIndex = 49;
            this.Logo1PictureBox.TabStop = false;
            // 
            // GrayPreviewSwitchButton_2
            // 
            this.GrayPreviewSwitchButton_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrayPreviewSwitchButton_2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayPreviewSwitchButton_2.Location = new System.Drawing.Point(214, 715);
            this.GrayPreviewSwitchButton_2.Name = "GrayPreviewSwitchButton_2";
            this.GrayPreviewSwitchButton_2.Size = new System.Drawing.Size(83, 29);
            this.GrayPreviewSwitchButton_2.TabIndex = 48;
            this.GrayPreviewSwitchButton_2.Text = "Ч/Б";
            this.GrayPreviewSwitchButton_2.UseVisualStyleBackColor = true;
            this.GrayPreviewSwitchButton_2.Click += new System.EventHandler(this.GrayPreviewSwitchButton_2_Click);
            // 
            // ChangeBorderColorButton_2
            // 
            this.ChangeBorderColorButton_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeBorderColorButton_2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBorderColorButton_2.Location = new System.Drawing.Point(118, 715);
            this.ChangeBorderColorButton_2.Name = "ChangeBorderColorButton_2";
            this.ChangeBorderColorButton_2.Size = new System.Drawing.Size(83, 29);
            this.ChangeBorderColorButton_2.TabIndex = 45;
            this.ChangeBorderColorButton_2.Text = "Рамка";
            this.ChangeBorderColorButton_2.UseVisualStyleBackColor = true;
            this.ChangeBorderColorButton_2.Click += new System.EventHandler(this.ChangeBorderColorButton_2_Click);
            // 
            // HelpButton_2
            // 
            this.HelpButton_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HelpButton_2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton_2.Location = new System.Drawing.Point(310, 715);
            this.HelpButton_2.Name = "HelpButton_2";
            this.HelpButton_2.Size = new System.Drawing.Size(83, 29);
            this.HelpButton_2.TabIndex = 47;
            this.HelpButton_2.Text = "Помощь";
            this.HelpButton_2.UseVisualStyleBackColor = true;
            this.HelpButton_2.Click += new System.EventHandler(this.HelpButton_2_Click);
            // 
            // ResetButton_2
            // 
            this.ResetButton_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetButton_2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton_2.Location = new System.Drawing.Point(22, 715);
            this.ResetButton_2.Name = "ResetButton_2";
            this.ResetButton_2.Size = new System.Drawing.Size(83, 29);
            this.ResetButton_2.TabIndex = 46;
            this.ResetButton_2.Text = "Сброс";
            this.ResetButton_2.UseVisualStyleBackColor = true;
            this.ResetButton_2.Click += new System.EventHandler(this.ResetButton_2_Click);
            // 
            // AutoContrastIntensityLabel
            // 
            this.AutoContrastIntensityLabel.Location = new System.Drawing.Point(11, 140);
            this.AutoContrastIntensityLabel.Name = "AutoContrastIntensityLabel";
            this.AutoContrastIntensityLabel.Size = new System.Drawing.Size(176, 27);
            this.AutoContrastIntensityLabel.TabIndex = 41;
            this.AutoContrastIntensityLabel.Text = "Интенсивность";
            this.AutoContrastIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoContrastIntensityTextBox
            // 
            this.AutoContrastIntensityTextBox.Location = new System.Drawing.Point(193, 140);
            this.AutoContrastIntensityTextBox.MaxLength = 12;
            this.AutoContrastIntensityTextBox.Name = "AutoContrastIntensityTextBox";
            this.AutoContrastIntensityTextBox.Size = new System.Drawing.Size(164, 26);
            this.AutoContrastIntensityTextBox.TabIndex = 42;
            this.AutoContrastIntensityTextBox.Text = "0";
            // 
            // AutoContrastGridSizeLabel
            // 
            this.AutoContrastGridSizeLabel.Location = new System.Drawing.Point(8, 97);
            this.AutoContrastGridSizeLabel.Name = "AutoContrastGridSizeLabel";
            this.AutoContrastGridSizeLabel.Size = new System.Drawing.Size(179, 26);
            this.AutoContrastGridSizeLabel.TabIndex = 43;
            this.AutoContrastGridSizeLabel.Text = "Размер сетки автокоррекции";
            this.AutoContrastGridSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoContrastGridSizeTextBox
            // 
            this.AutoContrastGridSizeTextBox.Location = new System.Drawing.Point(193, 97);
            this.AutoContrastGridSizeTextBox.MaxLength = 12;
            this.AutoContrastGridSizeTextBox.Name = "AutoContrastGridSizeTextBox";
            this.AutoContrastGridSizeTextBox.Size = new System.Drawing.Size(164, 26);
            this.AutoContrastGridSizeTextBox.TabIndex = 44;
            this.AutoContrastGridSizeTextBox.Text = "0";
            // 
            // AutoBCCheckBox
            // 
            this.AutoBCCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoBCCheckBox.Location = new System.Drawing.Point(11, 183);
            this.AutoBCCheckBox.Name = "AutoBCCheckBox";
            this.AutoBCCheckBox.Size = new System.Drawing.Size(197, 24);
            this.AutoBCCheckBox.TabIndex = 40;
            this.AutoBCCheckBox.Text = "Автокоррекция";
            this.AutoBCCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoBCCheckBox.UseVisualStyleBackColor = true;
            this.AutoBCCheckBox.CheckedChanged += new System.EventHandler(this.AutoBCCheckBox_CheckedChanged);
            // 
            // OutputBrightnessLabel
            // 
            this.OutputBrightnessLabel.Location = new System.Drawing.Point(11, 12);
            this.OutputBrightnessLabel.Name = "OutputBrightnessLabel";
            this.OutputBrightnessLabel.Size = new System.Drawing.Size(176, 22);
            this.OutputBrightnessLabel.TabIndex = 36;
            this.OutputBrightnessLabel.Text = "Яркость";
            this.OutputBrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputBrightnessTextBox
            // 
            this.OutputBrightnessTextBox.Location = new System.Drawing.Point(193, 11);
            this.OutputBrightnessTextBox.MaxLength = 12;
            this.OutputBrightnessTextBox.Name = "OutputBrightnessTextBox";
            this.OutputBrightnessTextBox.Size = new System.Drawing.Size(164, 26);
            this.OutputBrightnessTextBox.TabIndex = 37;
            this.OutputBrightnessTextBox.Text = "0";
            // 
            // OutputContrastLabel
            // 
            this.OutputContrastLabel.Location = new System.Drawing.Point(11, 54);
            this.OutputContrastLabel.Name = "OutputContrastLabel";
            this.OutputContrastLabel.Size = new System.Drawing.Size(176, 26);
            this.OutputContrastLabel.TabIndex = 38;
            this.OutputContrastLabel.Text = "Контраст";
            this.OutputContrastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputContrastTextBox
            // 
            this.OutputContrastTextBox.Location = new System.Drawing.Point(193, 54);
            this.OutputContrastTextBox.MaxLength = 12;
            this.OutputContrastTextBox.Name = "OutputContrastTextBox";
            this.OutputContrastTextBox.Size = new System.Drawing.Size(164, 26);
            this.OutputContrastTextBox.TabIndex = 39;
            this.OutputContrastTextBox.Text = "0";
            // 
            // AdditionalSettingsTabPage
            // 
            this.AdditionalSettingsTabPage.Controls.Add(this.GrayPreviewSwitchButton_3);
            this.AdditionalSettingsTabPage.Controls.Add(this.ChangeBorderColorButton_3);
            this.AdditionalSettingsTabPage.Controls.Add(this.HelpButton_3);
            this.AdditionalSettingsTabPage.Controls.Add(this.ResetButton_3);
            this.AdditionalSettingsTabPage.Controls.Add(this.PresetEditGroupBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.DetectionResolutionComboBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.DetectionResolutionLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.ContrastTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.ImageErodingTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.ContrastLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.DisableSeparatingInPreview);
            this.AdditionalSettingsTabPage.Controls.Add(this.BrightnessTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.MinXSizeLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.BrightnessLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.MinXSizeTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.MinYSizeLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.ThresholdLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.ImageErodingLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.ImageDilatingTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.ImageDilatingLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.SmoothTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.ThresholdTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.SmoothLabel);
            this.AdditionalSettingsTabPage.Controls.Add(this.MinYSizeTextBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.AutoSettingsCheckBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.SaveFormatComboBox);
            this.AdditionalSettingsTabPage.Controls.Add(this.SaveFormatLabel);
            this.AdditionalSettingsTabPage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalSettingsTabPage.Location = new System.Drawing.Point(4, 27);
            this.AdditionalSettingsTabPage.Name = "AdditionalSettingsTabPage";
            this.AdditionalSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdditionalSettingsTabPage.Size = new System.Drawing.Size(1522, 817);
            this.AdditionalSettingsTabPage.TabIndex = 3;
            this.AdditionalSettingsTabPage.Text = "Расширенные настройки";
            this.AdditionalSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // GrayPreviewSwitchButton_3
            // 
            this.GrayPreviewSwitchButton_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrayPreviewSwitchButton_3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayPreviewSwitchButton_3.Location = new System.Drawing.Point(214, 715);
            this.GrayPreviewSwitchButton_3.Name = "GrayPreviewSwitchButton_3";
            this.GrayPreviewSwitchButton_3.Size = new System.Drawing.Size(83, 29);
            this.GrayPreviewSwitchButton_3.TabIndex = 52;
            this.GrayPreviewSwitchButton_3.Text = "Ч/Б";
            this.GrayPreviewSwitchButton_3.UseVisualStyleBackColor = true;
            this.GrayPreviewSwitchButton_3.Click += new System.EventHandler(this.GrayPreviewSwitchButton_3_Click);
            // 
            // ChangeBorderColorButton_3
            // 
            this.ChangeBorderColorButton_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeBorderColorButton_3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBorderColorButton_3.Location = new System.Drawing.Point(118, 715);
            this.ChangeBorderColorButton_3.Name = "ChangeBorderColorButton_3";
            this.ChangeBorderColorButton_3.Size = new System.Drawing.Size(83, 29);
            this.ChangeBorderColorButton_3.TabIndex = 49;
            this.ChangeBorderColorButton_3.Text = "Рамка";
            this.ChangeBorderColorButton_3.UseVisualStyleBackColor = true;
            this.ChangeBorderColorButton_3.Click += new System.EventHandler(this.ChangeBorderColorButton_3_Click);
            // 
            // HelpButton_3
            // 
            this.HelpButton_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HelpButton_3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton_3.Location = new System.Drawing.Point(310, 715);
            this.HelpButton_3.Name = "HelpButton_3";
            this.HelpButton_3.Size = new System.Drawing.Size(83, 29);
            this.HelpButton_3.TabIndex = 51;
            this.HelpButton_3.Text = "Помощь";
            this.HelpButton_3.UseVisualStyleBackColor = true;
            this.HelpButton_3.Click += new System.EventHandler(this.HelpButton_3_Click);
            // 
            // ResetButton_3
            // 
            this.ResetButton_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetButton_3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton_3.Location = new System.Drawing.Point(22, 715);
            this.ResetButton_3.Name = "ResetButton_3";
            this.ResetButton_3.Size = new System.Drawing.Size(83, 29);
            this.ResetButton_3.TabIndex = 50;
            this.ResetButton_3.Text = "Сброс";
            this.ResetButton_3.UseVisualStyleBackColor = true;
            this.ResetButton_3.Click += new System.EventHandler(this.ResetButton_3_Click);
            // 
            // PresetEditGroupBox
            // 
            this.PresetEditGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetEditGroupBox.Controls.Add(this.UpdatePresetsButton);
            this.PresetEditGroupBox.Controls.Add(this.ExportPresetButton);
            this.PresetEditGroupBox.Controls.Add(this.ImportPresetButton);
            this.PresetEditGroupBox.Controls.Add(this.DeletePresetButton);
            this.PresetEditGroupBox.Controls.Add(this.ReplacePresetButton);
            this.PresetEditGroupBox.Controls.Add(this.CreateNewPresetButton);
            this.PresetEditGroupBox.Controls.Add(this.PresetDataGridView);
            this.PresetEditGroupBox.Location = new System.Drawing.Point(547, 6);
            this.PresetEditGroupBox.Name = "PresetEditGroupBox";
            this.PresetEditGroupBox.Size = new System.Drawing.Size(966, 500);
            this.PresetEditGroupBox.TabIndex = 38;
            this.PresetEditGroupBox.TabStop = false;
            this.PresetEditGroupBox.Text = "Редактор пресетов";
            // 
            // UpdatePresetsButton
            // 
            this.UpdatePresetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePresetsButton.Location = new System.Drawing.Point(808, 206);
            this.UpdatePresetsButton.Name = "UpdatePresetsButton";
            this.UpdatePresetsButton.Size = new System.Drawing.Size(151, 30);
            this.UpdatePresetsButton.TabIndex = 43;
            this.UpdatePresetsButton.Text = "Обновить";
            this.UpdatePresetsButton.UseVisualStyleBackColor = true;
            this.UpdatePresetsButton.Click += new System.EventHandler(this.UpdatePresetsButton_Click);
            // 
            // ExportPresetButton
            // 
            this.ExportPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportPresetButton.Location = new System.Drawing.Point(809, 170);
            this.ExportPresetButton.Name = "ExportPresetButton";
            this.ExportPresetButton.Size = new System.Drawing.Size(151, 30);
            this.ExportPresetButton.TabIndex = 42;
            this.ExportPresetButton.Text = "Экспорт...";
            this.ExportPresetButton.UseVisualStyleBackColor = true;
            this.ExportPresetButton.Click += new System.EventHandler(this.ExportPresetButton_Click);
            // 
            // ImportPresetButton
            // 
            this.ImportPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportPresetButton.Location = new System.Drawing.Point(809, 134);
            this.ImportPresetButton.Name = "ImportPresetButton";
            this.ImportPresetButton.Size = new System.Drawing.Size(151, 30);
            this.ImportPresetButton.TabIndex = 41;
            this.ImportPresetButton.Text = "Импорт...";
            this.ImportPresetButton.UseVisualStyleBackColor = true;
            this.ImportPresetButton.Click += new System.EventHandler(this.ImportPresetButton_Click);
            // 
            // DeletePresetButton
            // 
            this.DeletePresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePresetButton.Location = new System.Drawing.Point(809, 98);
            this.DeletePresetButton.Name = "DeletePresetButton";
            this.DeletePresetButton.Size = new System.Drawing.Size(151, 30);
            this.DeletePresetButton.TabIndex = 40;
            this.DeletePresetButton.Text = "Удалить...";
            this.DeletePresetButton.UseVisualStyleBackColor = true;
            this.DeletePresetButton.Click += new System.EventHandler(this.DeletePresetButton_Click);
            // 
            // ReplacePresetButton
            // 
            this.ReplacePresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplacePresetButton.Location = new System.Drawing.Point(809, 62);
            this.ReplacePresetButton.Name = "ReplacePresetButton";
            this.ReplacePresetButton.Size = new System.Drawing.Size(151, 30);
            this.ReplacePresetButton.TabIndex = 39;
            this.ReplacePresetButton.Text = "Сохранить...";
            this.ReplacePresetButton.UseVisualStyleBackColor = true;
            this.ReplacePresetButton.Click += new System.EventHandler(this.ReplacePresetButton_Click);
            // 
            // CreateNewPresetButton
            // 
            this.CreateNewPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewPresetButton.Location = new System.Drawing.Point(809, 26);
            this.CreateNewPresetButton.Name = "CreateNewPresetButton";
            this.CreateNewPresetButton.Size = new System.Drawing.Size(151, 30);
            this.CreateNewPresetButton.TabIndex = 38;
            this.CreateNewPresetButton.Text = "Создать...";
            this.CreateNewPresetButton.UseVisualStyleBackColor = true;
            this.CreateNewPresetButton.Click += new System.EventHandler(this.CreateNewPresetButton_Click);
            // 
            // PresetDataGridView
            // 
            this.PresetDataGridView.AllowUserToAddRows = false;
            this.PresetDataGridView.AllowUserToDeleteRows = false;
            this.PresetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.PresetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PresetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn});
            this.PresetDataGridView.Location = new System.Drawing.Point(17, 25);
            this.PresetDataGridView.Name = "PresetDataGridView";
            this.PresetDataGridView.ReadOnly = true;
            this.PresetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PresetDataGridView.Size = new System.Drawing.Size(785, 458);
            this.PresetDataGridView.TabIndex = 37;
            this.PresetDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PresetDataGridView_KeyDown);
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DetectionResolutionComboBox
            // 
            this.DetectionResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DetectionResolutionComboBox.FormattingEnabled = true;
            this.DetectionResolutionComboBox.Items.AddRange(new object[] {
            "1",
            "0.75",
            "0.5",
            "0.25",
            "0.125"});
            this.DetectionResolutionComboBox.Location = new System.Drawing.Point(354, 356);
            this.DetectionResolutionComboBox.Name = "DetectionResolutionComboBox";
            this.DetectionResolutionComboBox.Size = new System.Drawing.Size(164, 26);
            this.DetectionResolutionComboBox.TabIndex = 36;
            // 
            // DetectionResolutionLabel
            // 
            this.DetectionResolutionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DetectionResolutionLabel.Location = new System.Drawing.Point(9, 356);
            this.DetectionResolutionLabel.Name = "DetectionResolutionLabel";
            this.DetectionResolutionLabel.Size = new System.Drawing.Size(339, 23);
            this.DetectionResolutionLabel.TabIndex = 35;
            this.DetectionResolutionLabel.Text = "Множитель разрешения (предпросмотр)";
            this.DetectionResolutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContrastTextBox
            // 
            this.ContrastTextBox.Location = new System.Drawing.Point(354, 309);
            this.ContrastTextBox.MaxLength = 12;
            this.ContrastTextBox.Name = "ContrastTextBox";
            this.ContrastTextBox.Size = new System.Drawing.Size(164, 26);
            this.ContrastTextBox.TabIndex = 26;
            this.ContrastTextBox.Text = "45";
            // 
            // ImageErodingTextBox
            // 
            this.ImageErodingTextBox.Location = new System.Drawing.Point(354, 224);
            this.ImageErodingTextBox.MaxLength = 12;
            this.ImageErodingTextBox.Name = "ImageErodingTextBox";
            this.ImageErodingTextBox.Size = new System.Drawing.Size(164, 26);
            this.ImageErodingTextBox.TabIndex = 12;
            this.ImageErodingTextBox.Text = "2";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ContrastLabel.Location = new System.Drawing.Point(6, 313);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(342, 22);
            this.ContrastLabel.TabIndex = 25;
            this.ContrastLabel.Text = "Контраст (Ч/Б)";
            this.ContrastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisableSeparatingInPreview
            // 
            this.DisableSeparatingInPreview.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisableSeparatingInPreview.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableSeparatingInPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisableSeparatingInPreview.Location = new System.Drawing.Point(9, 442);
            this.DisableSeparatingInPreview.Name = "DisableSeparatingInPreview";
            this.DisableSeparatingInPreview.Size = new System.Drawing.Size(360, 22);
            this.DisableSeparatingInPreview.TabIndex = 34;
            this.DisableSeparatingInPreview.Text = "Отключить отсеивание в предпросмотре";
            this.DisableSeparatingInPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisableSeparatingInPreview.UseVisualStyleBackColor = true;
            // 
            // BrightnessTextBox
            // 
            this.BrightnessTextBox.Location = new System.Drawing.Point(354, 267);
            this.BrightnessTextBox.MaxLength = 12;
            this.BrightnessTextBox.Name = "BrightnessTextBox";
            this.BrightnessTextBox.Size = new System.Drawing.Size(164, 26);
            this.BrightnessTextBox.TabIndex = 24;
            this.BrightnessTextBox.Text = "-45";
            // 
            // MinXSizeLabel
            // 
            this.MinXSizeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinXSizeLabel.Location = new System.Drawing.Point(11, 12);
            this.MinXSizeLabel.Name = "MinXSizeLabel";
            this.MinXSizeLabel.Size = new System.Drawing.Size(337, 22);
            this.MinXSizeLabel.TabIndex = 3;
            this.MinXSizeLabel.Text = "Минимальный размер по X";
            this.MinXSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrightnessLabel.Location = new System.Drawing.Point(6, 270);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(342, 22);
            this.BrightnessLabel.TabIndex = 23;
            this.BrightnessLabel.Text = "Яркость (Ч/Б)";
            this.BrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinXSizeTextBox
            // 
            this.MinXSizeTextBox.Location = new System.Drawing.Point(354, 5);
            this.MinXSizeTextBox.MaxLength = 12;
            this.MinXSizeTextBox.Name = "MinXSizeTextBox";
            this.MinXSizeTextBox.Size = new System.Drawing.Size(164, 26);
            this.MinXSizeTextBox.TabIndex = 4;
            this.MinXSizeTextBox.Text = "100";
            // 
            // MinYSizeLabel
            // 
            this.MinYSizeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinYSizeLabel.Location = new System.Drawing.Point(14, 56);
            this.MinYSizeLabel.Name = "MinYSizeLabel";
            this.MinYSizeLabel.Size = new System.Drawing.Size(334, 22);
            this.MinYSizeLabel.TabIndex = 5;
            this.MinYSizeLabel.Text = "Минимальный размер по Y";
            this.MinYSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThresholdLabel.Location = new System.Drawing.Point(6, 98);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(342, 22);
            this.ThresholdLabel.TabIndex = 7;
            this.ThresholdLabel.Text = "Порог преобразования в Ч/Б";
            this.ThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImageErodingLabel
            // 
            this.ImageErodingLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImageErodingLabel.Location = new System.Drawing.Point(6, 227);
            this.ImageErodingLabel.Name = "ImageErodingLabel";
            this.ImageErodingLabel.Size = new System.Drawing.Size(342, 22);
            this.ImageErodingLabel.TabIndex = 11;
            this.ImageErodingLabel.Text = "Erode при преобразовании в Ч/Б";
            this.ImageErodingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImageDilatingTextBox
            // 
            this.ImageDilatingTextBox.Location = new System.Drawing.Point(354, 181);
            this.ImageDilatingTextBox.MaxLength = 12;
            this.ImageDilatingTextBox.Name = "ImageDilatingTextBox";
            this.ImageDilatingTextBox.Size = new System.Drawing.Size(164, 26);
            this.ImageDilatingTextBox.TabIndex = 10;
            this.ImageDilatingTextBox.Text = "2";
            // 
            // ImageDilatingLabel
            // 
            this.ImageDilatingLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImageDilatingLabel.Location = new System.Drawing.Point(6, 184);
            this.ImageDilatingLabel.Name = "ImageDilatingLabel";
            this.ImageDilatingLabel.Size = new System.Drawing.Size(342, 22);
            this.ImageDilatingLabel.TabIndex = 9;
            this.ImageDilatingLabel.Text = "Dilate при преобразовании в Ч/Б";
            this.ImageDilatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SmoothTextBox
            // 
            this.SmoothTextBox.Location = new System.Drawing.Point(354, 138);
            this.SmoothTextBox.MaxLength = 12;
            this.SmoothTextBox.Name = "SmoothTextBox";
            this.SmoothTextBox.Size = new System.Drawing.Size(164, 26);
            this.SmoothTextBox.TabIndex = 19;
            this.SmoothTextBox.Text = "5";
            // 
            // ThresholdTextBox
            // 
            this.ThresholdTextBox.Location = new System.Drawing.Point(354, 95);
            this.ThresholdTextBox.MaxLength = 12;
            this.ThresholdTextBox.Name = "ThresholdTextBox";
            this.ThresholdTextBox.Size = new System.Drawing.Size(164, 26);
            this.ThresholdTextBox.TabIndex = 8;
            this.ThresholdTextBox.Text = "100";
            // 
            // SmoothLabel
            // 
            this.SmoothLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SmoothLabel.Location = new System.Drawing.Point(9, 141);
            this.SmoothLabel.Name = "SmoothLabel";
            this.SmoothLabel.Size = new System.Drawing.Size(339, 22);
            this.SmoothLabel.TabIndex = 18;
            this.SmoothLabel.Text = "Размытие";
            this.SmoothLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinYSizeTextBox
            // 
            this.MinYSizeTextBox.Location = new System.Drawing.Point(354, 52);
            this.MinYSizeTextBox.MaxLength = 12;
            this.MinYSizeTextBox.Name = "MinYSizeTextBox";
            this.MinYSizeTextBox.Size = new System.Drawing.Size(164, 26);
            this.MinYSizeTextBox.TabIndex = 6;
            this.MinYSizeTextBox.Text = "100";
            // 
            // AutoSettingsCheckBox
            // 
            this.AutoSettingsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSettingsCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSettingsCheckBox.Location = new System.Drawing.Point(9, 399);
            this.AutoSettingsCheckBox.Name = "AutoSettingsCheckBox";
            this.AutoSettingsCheckBox.Size = new System.Drawing.Size(360, 22);
            this.AutoSettingsCheckBox.TabIndex = 32;
            this.AutoSettingsCheckBox.Text = "Определять настройки автоматически";
            this.AutoSettingsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSettingsCheckBox.UseVisualStyleBackColor = true;
            this.AutoSettingsCheckBox.CheckedChanged += new System.EventHandler(this.AutoSettingsCheckBox_CheckedChanged);
            // 
            // SaveFormatComboBox
            // 
            this.SaveFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaveFormatComboBox.FormattingEnabled = true;
            this.SaveFormatComboBox.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "BMP"});
            this.SaveFormatComboBox.Location = new System.Drawing.Point(354, 485);
            this.SaveFormatComboBox.Name = "SaveFormatComboBox";
            this.SaveFormatComboBox.Size = new System.Drawing.Size(164, 26);
            this.SaveFormatComboBox.TabIndex = 31;
            // 
            // SaveFormatLabel
            // 
            this.SaveFormatLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveFormatLabel.Location = new System.Drawing.Point(9, 485);
            this.SaveFormatLabel.Name = "SaveFormatLabel";
            this.SaveFormatLabel.Size = new System.Drawing.Size(339, 23);
            this.SaveFormatLabel.TabIndex = 30;
            this.SaveFormatLabel.Text = "Формат сохранения результатов";
            this.SaveFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrightnessAndContrastControlTab
            // 
            this.BrightnessAndContrastControlTab.Controls.Add(this.BC_SettingsPanelScroll);
            this.BrightnessAndContrastControlTab.Controls.Add(this.BC_TableLayoutPanel);
            this.BrightnessAndContrastControlTab.Location = new System.Drawing.Point(4, 27);
            this.BrightnessAndContrastControlTab.Name = "BrightnessAndContrastControlTab";
            this.BrightnessAndContrastControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.BrightnessAndContrastControlTab.Size = new System.Drawing.Size(1522, 817);
            this.BrightnessAndContrastControlTab.TabIndex = 1;
            this.BrightnessAndContrastControlTab.Text = "Яркость/контраст";
            this.BrightnessAndContrastControlTab.UseVisualStyleBackColor = true;
            // 
            // BC_SettingsPanelScroll
            // 
            this.BC_SettingsPanelScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BC_SettingsPanelScroll.AutoScroll = true;
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_InputPathTextBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.DelimiterPictureBox_3);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_ContrastTextBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_IsFolderCheckBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_InputPathLabel);
            this.BC_SettingsPanelScroll.Controls.Add(this.HelpButton_4);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_InputPathLabel_2);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_ContrastLabel);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_ResetButton);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_ChooseInputPathButton);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_SaveFormatComboBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_BrightnessTextBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_OutputPathTextBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_SaveFormatLabel);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_BrightnessLabel);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_StartButton);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_AutoCorrectionCheckBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_AutoContrastIntensityLabel);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_ChooseOutputPathButton);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_AutoContrastIntensityTextBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_AutoContrastGridSizeTextBox);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_AutoContrastGridSizeLabel);
            this.BC_SettingsPanelScroll.Controls.Add(this.BC_OutputPathLabel);
            this.BC_SettingsPanelScroll.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_SettingsPanelScroll.Location = new System.Drawing.Point(-4, 0);
            this.BC_SettingsPanelScroll.Name = "BC_SettingsPanelScroll";
            this.BC_SettingsPanelScroll.Size = new System.Drawing.Size(433, 821);
            this.BC_SettingsPanelScroll.TabIndex = 55;
            // 
            // BC_InputPathTextBox
            // 
            this.BC_InputPathTextBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_InputPathTextBox.Location = new System.Drawing.Point(13, 44);
            this.BC_InputPathTextBox.Name = "BC_InputPathTextBox";
            this.BC_InputPathTextBox.ReadOnly = true;
            this.BC_InputPathTextBox.Size = new System.Drawing.Size(306, 26);
            this.BC_InputPathTextBox.TabIndex = 17;
            // 
            // DelimiterPictureBox_3
            // 
            this.DelimiterPictureBox_3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DelimiterPictureBox_3.Location = new System.Drawing.Point(13, 368);
            this.DelimiterPictureBox_3.Name = "DelimiterPictureBox_3";
            this.DelimiterPictureBox_3.Size = new System.Drawing.Size(392, 2);
            this.DelimiterPictureBox_3.TabIndex = 54;
            this.DelimiterPictureBox_3.TabStop = false;
            // 
            // BC_ContrastTextBox
            // 
            this.BC_ContrastTextBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_ContrastTextBox.Location = new System.Drawing.Point(241, 196);
            this.BC_ContrastTextBox.MaxLength = 12;
            this.BC_ContrastTextBox.Name = "BC_ContrastTextBox";
            this.BC_ContrastTextBox.Size = new System.Drawing.Size(164, 26);
            this.BC_ContrastTextBox.TabIndex = 30;
            this.BC_ContrastTextBox.Text = "0";
            this.BC_ContrastTextBox.Enter += new System.EventHandler(this.BC_ContrastTextBox_Enter);
            this.BC_ContrastTextBox.Leave += new System.EventHandler(this.BC_ContrastTextBox_Leave);
            // 
            // BC_IsFolderCheckBox
            // 
            this.BC_IsFolderCheckBox.AutoSize = true;
            this.BC_IsFolderCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BC_IsFolderCheckBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_IsFolderCheckBox.Location = new System.Drawing.Point(130, 19);
            this.BC_IsFolderCheckBox.Name = "BC_IsFolderCheckBox";
            this.BC_IsFolderCheckBox.Size = new System.Drawing.Size(74, 22);
            this.BC_IsFolderCheckBox.TabIndex = 20;
            this.BC_IsFolderCheckBox.Text = "Папка";
            this.BC_IsFolderCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BC_IsFolderCheckBox.UseVisualStyleBackColor = true;
            this.BC_IsFolderCheckBox.CheckedChanged += new System.EventHandler(this.BC_IsFolderCheckBox_CheckedChanged);
            // 
            // BC_InputPathLabel
            // 
            this.BC_InputPathLabel.AutoSize = true;
            this.BC_InputPathLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_InputPathLabel.Location = new System.Drawing.Point(11, 19);
            this.BC_InputPathLabel.Name = "BC_InputPathLabel";
            this.BC_InputPathLabel.Size = new System.Drawing.Size(125, 18);
            this.BC_InputPathLabel.TabIndex = 19;
            this.BC_InputPathLabel.Text = "Входной путь (";
            // 
            // HelpButton_4
            // 
            this.HelpButton_4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton_4.Location = new System.Drawing.Point(218, 720);
            this.HelpButton_4.Name = "HelpButton_4";
            this.HelpButton_4.Size = new System.Drawing.Size(179, 29);
            this.HelpButton_4.TabIndex = 52;
            this.HelpButton_4.Text = "Помощь";
            this.HelpButton_4.UseVisualStyleBackColor = true;
            this.HelpButton_4.Click += new System.EventHandler(this.HelpButton_4_Click);
            // 
            // BC_InputPathLabel_2
            // 
            this.BC_InputPathLabel_2.AutoSize = true;
            this.BC_InputPathLabel_2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_InputPathLabel_2.Location = new System.Drawing.Point(205, 19);
            this.BC_InputPathLabel_2.Name = "BC_InputPathLabel_2";
            this.BC_InputPathLabel_2.Size = new System.Drawing.Size(15, 18);
            this.BC_InputPathLabel_2.TabIndex = 42;
            this.BC_InputPathLabel_2.Text = ")";
            // 
            // BC_ContrastLabel
            // 
            this.BC_ContrastLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_ContrastLabel.Location = new System.Drawing.Point(10, 196);
            this.BC_ContrastLabel.Name = "BC_ContrastLabel";
            this.BC_ContrastLabel.Size = new System.Drawing.Size(225, 26);
            this.BC_ContrastLabel.TabIndex = 29;
            this.BC_ContrastLabel.Text = "Контраст";
            this.BC_ContrastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BC_ResetButton
            // 
            this.BC_ResetButton.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BC_ResetButton.Location = new System.Drawing.Point(26, 720);
            this.BC_ResetButton.Name = "BC_ResetButton";
            this.BC_ResetButton.Size = new System.Drawing.Size(179, 29);
            this.BC_ResetButton.TabIndex = 28;
            this.BC_ResetButton.Text = "Сброс";
            this.BC_ResetButton.UseVisualStyleBackColor = true;
            this.BC_ResetButton.Click += new System.EventHandler(this.BC_ResetButton_Click);
            // 
            // BC_ChooseInputPathButton
            // 
            this.BC_ChooseInputPathButton.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BC_ChooseInputPathButton.Location = new System.Drawing.Point(325, 44);
            this.BC_ChooseInputPathButton.Name = "BC_ChooseInputPathButton";
            this.BC_ChooseInputPathButton.Size = new System.Drawing.Size(80, 26);
            this.BC_ChooseInputPathButton.TabIndex = 18;
            this.BC_ChooseInputPathButton.Text = "Выбор";
            this.BC_ChooseInputPathButton.UseVisualStyleBackColor = true;
            this.BC_ChooseInputPathButton.Click += new System.EventHandler(this.BC_ChooseInputPathButton_Click);
            // 
            // BC_SaveFormatComboBox
            // 
            this.BC_SaveFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BC_SaveFormatComboBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_SaveFormatComboBox.FormattingEnabled = true;
            this.BC_SaveFormatComboBox.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "BMP"});
            this.BC_SaveFormatComboBox.Location = new System.Drawing.Point(240, 391);
            this.BC_SaveFormatComboBox.Name = "BC_SaveFormatComboBox";
            this.BC_SaveFormatComboBox.Size = new System.Drawing.Size(164, 26);
            this.BC_SaveFormatComboBox.TabIndex = 41;
            // 
            // BC_BrightnessTextBox
            // 
            this.BC_BrightnessTextBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_BrightnessTextBox.Location = new System.Drawing.Point(241, 153);
            this.BC_BrightnessTextBox.MaxLength = 12;
            this.BC_BrightnessTextBox.Name = "BC_BrightnessTextBox";
            this.BC_BrightnessTextBox.Size = new System.Drawing.Size(164, 26);
            this.BC_BrightnessTextBox.TabIndex = 28;
            this.BC_BrightnessTextBox.Text = "0";
            this.BC_BrightnessTextBox.Enter += new System.EventHandler(this.BC_BrightnessTextBox_Enter);
            this.BC_BrightnessTextBox.Leave += new System.EventHandler(this.BC_BrightnessTextBox_Leave);
            // 
            // BC_OutputPathTextBox
            // 
            this.BC_OutputPathTextBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_OutputPathTextBox.Location = new System.Drawing.Point(13, 110);
            this.BC_OutputPathTextBox.Name = "BC_OutputPathTextBox";
            this.BC_OutputPathTextBox.ReadOnly = true;
            this.BC_OutputPathTextBox.Size = new System.Drawing.Size(306, 26);
            this.BC_OutputPathTextBox.TabIndex = 21;
            // 
            // BC_SaveFormatLabel
            // 
            this.BC_SaveFormatLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_SaveFormatLabel.Location = new System.Drawing.Point(14, 391);
            this.BC_SaveFormatLabel.Name = "BC_SaveFormatLabel";
            this.BC_SaveFormatLabel.Size = new System.Drawing.Size(220, 26);
            this.BC_SaveFormatLabel.TabIndex = 40;
            this.BC_SaveFormatLabel.Text = "Формат для сохранения";
            this.BC_SaveFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BC_BrightnessLabel
            // 
            this.BC_BrightnessLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_BrightnessLabel.Location = new System.Drawing.Point(83, 153);
            this.BC_BrightnessLabel.Name = "BC_BrightnessLabel";
            this.BC_BrightnessLabel.Size = new System.Drawing.Size(152, 26);
            this.BC_BrightnessLabel.TabIndex = 27;
            this.BC_BrightnessLabel.Text = "Яркость";
            this.BC_BrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BC_StartButton
            // 
            this.BC_StartButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_StartButton.Location = new System.Drawing.Point(83, 581);
            this.BC_StartButton.Name = "BC_StartButton";
            this.BC_StartButton.Size = new System.Drawing.Size(257, 45);
            this.BC_StartButton.TabIndex = 25;
            this.BC_StartButton.Text = "Старт";
            this.BC_StartButton.UseVisualStyleBackColor = true;
            this.BC_StartButton.Click += new System.EventHandler(this.BC_StartButton_Click);
            // 
            // BC_AutoCorrectionCheckBox
            // 
            this.BC_AutoCorrectionCheckBox.AutoSize = true;
            this.BC_AutoCorrectionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BC_AutoCorrectionCheckBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_AutoCorrectionCheckBox.Location = new System.Drawing.Point(108, 325);
            this.BC_AutoCorrectionCheckBox.Name = "BC_AutoCorrectionCheckBox";
            this.BC_AutoCorrectionCheckBox.Size = new System.Drawing.Size(146, 22);
            this.BC_AutoCorrectionCheckBox.TabIndex = 31;
            this.BC_AutoCorrectionCheckBox.Text = "Автокоррекция";
            this.BC_AutoCorrectionCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BC_AutoCorrectionCheckBox.UseVisualStyleBackColor = true;
            this.BC_AutoCorrectionCheckBox.CheckedChanged += new System.EventHandler(this.BC_AutoCorrectionCheckBox_CheckedChanged);
            // 
            // BC_AutoContrastIntensityLabel
            // 
            this.BC_AutoContrastIntensityLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_AutoContrastIntensityLabel.Location = new System.Drawing.Point(13, 239);
            this.BC_AutoContrastIntensityLabel.Name = "BC_AutoContrastIntensityLabel";
            this.BC_AutoContrastIntensityLabel.Size = new System.Drawing.Size(222, 26);
            this.BC_AutoContrastIntensityLabel.TabIndex = 36;
            this.BC_AutoContrastIntensityLabel.Text = "Интенсивность автокоррекции";
            this.BC_AutoContrastIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BC_ChooseOutputPathButton
            // 
            this.BC_ChooseOutputPathButton.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BC_ChooseOutputPathButton.Location = new System.Drawing.Point(325, 110);
            this.BC_ChooseOutputPathButton.Name = "BC_ChooseOutputPathButton";
            this.BC_ChooseOutputPathButton.Size = new System.Drawing.Size(80, 26);
            this.BC_ChooseOutputPathButton.TabIndex = 22;
            this.BC_ChooseOutputPathButton.Text = "Выбор";
            this.BC_ChooseOutputPathButton.UseVisualStyleBackColor = true;
            this.BC_ChooseOutputPathButton.Click += new System.EventHandler(this.BC_ChooseOutputPathButton_Click);
            // 
            // BC_AutoContrastIntensityTextBox
            // 
            this.BC_AutoContrastIntensityTextBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_AutoContrastIntensityTextBox.Location = new System.Drawing.Point(241, 239);
            this.BC_AutoContrastIntensityTextBox.MaxLength = 12;
            this.BC_AutoContrastIntensityTextBox.Name = "BC_AutoContrastIntensityTextBox";
            this.BC_AutoContrastIntensityTextBox.Size = new System.Drawing.Size(164, 26);
            this.BC_AutoContrastIntensityTextBox.TabIndex = 37;
            this.BC_AutoContrastIntensityTextBox.Text = "0";
            this.BC_AutoContrastIntensityTextBox.Enter += new System.EventHandler(this.BC_AutoContrastIntensityTextBox_Enter);
            this.BC_AutoContrastIntensityTextBox.Leave += new System.EventHandler(this.BC_AutoContrastIntensityTextBox_Leave);
            // 
            // BC_AutoContrastGridSizeTextBox
            // 
            this.BC_AutoContrastGridSizeTextBox.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_AutoContrastGridSizeTextBox.Location = new System.Drawing.Point(240, 282);
            this.BC_AutoContrastGridSizeTextBox.MaxLength = 12;
            this.BC_AutoContrastGridSizeTextBox.Name = "BC_AutoContrastGridSizeTextBox";
            this.BC_AutoContrastGridSizeTextBox.Size = new System.Drawing.Size(164, 26);
            this.BC_AutoContrastGridSizeTextBox.TabIndex = 39;
            this.BC_AutoContrastGridSizeTextBox.Text = "0";
            this.BC_AutoContrastGridSizeTextBox.Enter += new System.EventHandler(this.BC_AutoContrastGridSizeTextBox_Enter);
            this.BC_AutoContrastGridSizeTextBox.Leave += new System.EventHandler(this.BC_AutoContrastGridSizeTextBox_Leave);
            // 
            // BC_AutoContrastGridSizeLabel
            // 
            this.BC_AutoContrastGridSizeLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_AutoContrastGridSizeLabel.Location = new System.Drawing.Point(12, 282);
            this.BC_AutoContrastGridSizeLabel.Name = "BC_AutoContrastGridSizeLabel";
            this.BC_AutoContrastGridSizeLabel.Size = new System.Drawing.Size(222, 26);
            this.BC_AutoContrastGridSizeLabel.TabIndex = 38;
            this.BC_AutoContrastGridSizeLabel.Text = "Размер сетки автокоррекции";
            this.BC_AutoContrastGridSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BC_OutputPathLabel
            // 
            this.BC_OutputPathLabel.AutoSize = true;
            this.BC_OutputPathLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BC_OutputPathLabel.Location = new System.Drawing.Point(13, 85);
            this.BC_OutputPathLabel.Name = "BC_OutputPathLabel";
            this.BC_OutputPathLabel.Size = new System.Drawing.Size(125, 18);
            this.BC_OutputPathLabel.TabIndex = 23;
            this.BC_OutputPathLabel.Text = "Выходной путь";
            // 
            // BC_TableLayoutPanel
            // 
            this.BC_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BC_TableLayoutPanel.ColumnCount = 4;
            this.BC_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.BC_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BC_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.BC_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BC_TableLayoutPanel.Controls.Add(this.BC_RightArrowPanel, 2, 1);
            this.BC_TableLayoutPanel.Controls.Add(this.BC_LeftArrowPanel, 0, 1);
            this.BC_TableLayoutPanel.Controls.Add(this.BC_SourceImageLabel, 3, 0);
            this.BC_TableLayoutPanel.Controls.Add(this.BC_CurrentImageLabel, 1, 0);
            this.BC_TableLayoutPanel.Controls.Add(this.BC_PreviewSource, 3, 1);
            this.BC_TableLayoutPanel.Controls.Add(this.BC_ImagePictureBox, 1, 1);
            this.BC_TableLayoutPanel.Location = new System.Drawing.Point(432, 0);
            this.BC_TableLayoutPanel.Name = "BC_TableLayoutPanel";
            this.BC_TableLayoutPanel.RowCount = 2;
            this.BC_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BC_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BC_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BC_TableLayoutPanel.Size = new System.Drawing.Size(1094, 821);
            this.BC_TableLayoutPanel.TabIndex = 27;
            // 
            // BC_RightArrowPanel
            // 
            this.BC_RightArrowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BC_RightArrowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BC_RightArrowPanel.Controls.Add(this.BC_RightArrowPictureBox);
            this.BC_RightArrowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC_RightArrowPanel.Location = new System.Drawing.Point(550, 23);
            this.BC_RightArrowPanel.Name = "BC_RightArrowPanel";
            this.BC_RightArrowPanel.Size = new System.Drawing.Size(44, 795);
            this.BC_RightArrowPanel.TabIndex = 30;
            this.BC_RightArrowPanel.Click += new System.EventHandler(this.BC_RightArrowPanel_Click);
            // 
            // BC_RightArrowPictureBox
            // 
            this.BC_RightArrowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BC_RightArrowPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BC_RightArrowPictureBox.Image = global::ImageAutoCropper.Properties.Resources.arrow_2;
            this.BC_RightArrowPictureBox.Location = new System.Drawing.Point(6, 3);
            this.BC_RightArrowPictureBox.Name = "BC_RightArrowPictureBox";
            this.BC_RightArrowPictureBox.Size = new System.Drawing.Size(30, 787);
            this.BC_RightArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BC_RightArrowPictureBox.TabIndex = 18;
            this.BC_RightArrowPictureBox.TabStop = false;
            this.BC_RightArrowPictureBox.Click += new System.EventHandler(this.BC_RightArrowPictureBox_Click);
            // 
            // BC_LeftArrowPanel
            // 
            this.BC_LeftArrowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BC_LeftArrowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BC_LeftArrowPanel.Controls.Add(this.BC_LeftArrowPictureBox);
            this.BC_LeftArrowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC_LeftArrowPanel.Location = new System.Drawing.Point(3, 23);
            this.BC_LeftArrowPanel.Name = "BC_LeftArrowPanel";
            this.BC_LeftArrowPanel.Size = new System.Drawing.Size(44, 795);
            this.BC_LeftArrowPanel.TabIndex = 29;
            this.BC_LeftArrowPanel.Click += new System.EventHandler(this.BC_LeftArrowPanel_Click);
            // 
            // BC_LeftArrowPictureBox
            // 
            this.BC_LeftArrowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BC_LeftArrowPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BC_LeftArrowPictureBox.Image = global::ImageAutoCropper.Properties.Resources.arrow;
            this.BC_LeftArrowPictureBox.Location = new System.Drawing.Point(6, 3);
            this.BC_LeftArrowPictureBox.Name = "BC_LeftArrowPictureBox";
            this.BC_LeftArrowPictureBox.Size = new System.Drawing.Size(30, 787);
            this.BC_LeftArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BC_LeftArrowPictureBox.TabIndex = 17;
            this.BC_LeftArrowPictureBox.TabStop = false;
            this.BC_LeftArrowPictureBox.Click += new System.EventHandler(this.BC_LeftArrowPictureBox_Click);
            // 
            // BC_SourceImageLabel
            // 
            this.BC_SourceImageLabel.AutoSize = true;
            this.BC_SourceImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC_SourceImageLabel.Location = new System.Drawing.Point(600, 0);
            this.BC_SourceImageLabel.Name = "BC_SourceImageLabel";
            this.BC_SourceImageLabel.Size = new System.Drawing.Size(491, 20);
            this.BC_SourceImageLabel.TabIndex = 28;
            this.BC_SourceImageLabel.Text = "Исходное изображение";
            this.BC_SourceImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BC_CurrentImageLabel
            // 
            this.BC_CurrentImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC_CurrentImageLabel.Location = new System.Drawing.Point(53, 0);
            this.BC_CurrentImageLabel.Name = "BC_CurrentImageLabel";
            this.BC_CurrentImageLabel.Size = new System.Drawing.Size(491, 20);
            this.BC_CurrentImageLabel.TabIndex = 19;
            this.BC_CurrentImageLabel.Text = "None";
            this.BC_CurrentImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BC_PreviewSource
            // 
            this.BC_PreviewSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BC_PreviewSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC_PreviewSource.Location = new System.Drawing.Point(600, 23);
            this.BC_PreviewSource.Name = "BC_PreviewSource";
            this.BC_PreviewSource.Size = new System.Drawing.Size(491, 795);
            this.BC_PreviewSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BC_PreviewSource.TabIndex = 13;
            this.BC_PreviewSource.TabStop = false;
            // 
            // BC_ImagePictureBox
            // 
            this.BC_ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BC_ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC_ImagePictureBox.Location = new System.Drawing.Point(53, 23);
            this.BC_ImagePictureBox.Name = "BC_ImagePictureBox";
            this.BC_ImagePictureBox.Size = new System.Drawing.Size(491, 795);
            this.BC_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BC_ImagePictureBox.TabIndex = 0;
            this.BC_ImagePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1529, 848);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1090, 688);
            this.Name = "Form1";
            this.Text = "Image Auto Cropper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.PreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox_1)).EndInit();
            this.LeftArrowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPictureBox)).EndInit();
            this.RightArrowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPictureBox)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.DisplayTabControl.ResumeLayout(false);
            this.DisplayTab.ResumeLayout(false);
            this.FileExplorerTab.ResumeLayout(false);
            this.FilesListPreviewControlPanel.ResumeLayout(false);
            this.SettingsPanelScroll.ResumeLayout(false);
            this.SettingsPanelScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelimiterPictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelimiterPictureBox_1)).EndInit();
            this.AutoContrastTabPage.ResumeLayout(false);
            this.AutoContrastTabPage.PerformLayout();
            this.LogoTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1PictureBox)).EndInit();
            this.AdditionalSettingsTabPage.ResumeLayout(false);
            this.AdditionalSettingsTabPage.PerformLayout();
            this.PresetEditGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PresetDataGridView)).EndInit();
            this.BrightnessAndContrastControlTab.ResumeLayout(false);
            this.BC_SettingsPanelScroll.ResumeLayout(false);
            this.BC_SettingsPanelScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelimiterPictureBox_3)).EndInit();
            this.BC_TableLayoutPanel.ResumeLayout(false);
            this.BC_TableLayoutPanel.PerformLayout();
            this.BC_RightArrowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BC_RightArrowPictureBox)).EndInit();
            this.BC_LeftArrowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BC_LeftArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_PreviewSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_ImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox_1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button DetectButton;
        private System.Windows.Forms.Label XDistTextBoxLabel;
        private System.Windows.Forms.TextBox XDistTextBox;
        private System.Windows.Forms.Label YDistTextBoxLabel;
        private System.Windows.Forms.TextBox YDistTextBox;
        private System.Windows.Forms.Button ChoosePathButton;
        private System.Windows.Forms.Label ChooseFileLabel_1;
        private System.Windows.Forms.CheckBox IsFolderCheckBox;
        private System.Windows.Forms.TextBox BorderThiknessTextBox;
        private System.Windows.Forms.Label BorderThiknessLabel;
        private System.Windows.Forms.CheckBox SeparateCheckBox;
        private System.Windows.Forms.PictureBox ImagePictureBox_2;
        private System.Windows.Forms.Label OutputFolderLabel;
        private System.Windows.Forms.Button ChooseOutputFolderButton;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button ChangeBorderColorButton;
        private System.Windows.Forms.ColorDialog BorderColorDialog;
        private System.Windows.Forms.PictureBox LeftArrowPictureBox;
        private System.Windows.Forms.Label CurrentImageLabel_1;
        private System.Windows.Forms.TableLayoutPanel PreviewPanel;
        private System.Windows.Forms.CheckBox RotateCheckBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage BrightnessAndContrastControlTab;
        private System.Windows.Forms.Label BC_OutputPathLabel;
        private System.Windows.Forms.Button BC_ChooseOutputPathButton;
        private System.Windows.Forms.TextBox BC_InputPathTextBox;
        private System.Windows.Forms.TextBox BC_OutputPathTextBox;
        private System.Windows.Forms.Button BC_ChooseInputPathButton;
        private System.Windows.Forms.Label BC_InputPathLabel;
        private System.Windows.Forms.CheckBox BC_IsFolderCheckBox;
        private System.Windows.Forms.CheckBox BC_AutoCorrectionCheckBox;
        private System.Windows.Forms.Label BC_BrightnessLabel;
        private System.Windows.Forms.TextBox BC_BrightnessTextBox;
        private System.Windows.Forms.Label BC_ContrastLabel;
        private System.Windows.Forms.TextBox BC_ContrastTextBox;
        private System.Windows.Forms.Button BC_StartButton;
        private System.Windows.Forms.TableLayoutPanel BC_TableLayoutPanel;
        private System.Windows.Forms.Label BC_CurrentImageLabel;
        private System.Windows.Forms.PictureBox BC_RightArrowPictureBox;
        private System.Windows.Forms.PictureBox BC_PreviewSource;
        private System.Windows.Forms.PictureBox BC_LeftArrowPictureBox;
        private System.Windows.Forms.PictureBox BC_ImagePictureBox;
        private System.Windows.Forms.Label BC_SourceImageLabel;
        private System.Windows.Forms.Panel SettingsPanelScroll;
        private System.Windows.Forms.Label BC_AutoContrastIntensityLabel;
        private System.Windows.Forms.TextBox BC_AutoContrastIntensityTextBox;
        private System.Windows.Forms.Label BC_AutoContrastGridSizeLabel;
        private System.Windows.Forms.TextBox BC_AutoContrastGridSizeTextBox;
        private System.Windows.Forms.ComboBox BC_SaveFormatComboBox;
        private System.Windows.Forms.Label BC_SaveFormatLabel;
        private System.Windows.Forms.Button BC_ResetButton;
        private System.Windows.Forms.Label EENumberingLabel;
        private System.Windows.Forms.TextBox EENumberingTextBox;
        private System.Windows.Forms.CheckBox EENumberingCheckBox;
        private System.Windows.Forms.Panel LeftArrowPanel;
        private System.Windows.Forms.Label ChooseFileLabel_2;
        private System.Windows.Forms.TabPage AutoContrastTabPage;
        private System.Windows.Forms.Label AutoContrastIntensityLabel;
        private System.Windows.Forms.TextBox AutoContrastIntensityTextBox;
        private System.Windows.Forms.Label AutoContrastGridSizeLabel;
        private System.Windows.Forms.TextBox AutoContrastGridSizeTextBox;
        private System.Windows.Forms.CheckBox AutoBCCheckBox;
        private System.Windows.Forms.Label OutputBrightnessLabel;
        private System.Windows.Forms.TextBox OutputBrightnessTextBox;
        private System.Windows.Forms.Label OutputContrastLabel;
        private System.Windows.Forms.TextBox OutputContrastTextBox;
        private System.Windows.Forms.TabPage AdditionalSettingsTabPage;
        private System.Windows.Forms.TextBox ImageErodingTextBox;
        private System.Windows.Forms.Label MinXSizeLabel;
        private System.Windows.Forms.TextBox ContrastTextBox;
        private System.Windows.Forms.TextBox MinXSizeTextBox;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label MinYSizeLabel;
        private System.Windows.Forms.TextBox MinYSizeTextBox;
        private System.Windows.Forms.TextBox BrightnessTextBox;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TextBox ThresholdTextBox;
        private System.Windows.Forms.TextBox SmoothTextBox;
        private System.Windows.Forms.Label ImageDilatingLabel;
        private System.Windows.Forms.Label SmoothLabel;
        private System.Windows.Forms.TextBox ImageDilatingTextBox;
        private System.Windows.Forms.Label ImageErodingLabel;
        private System.Windows.Forms.CheckBox AutoSettingsCheckBox;
        private System.Windows.Forms.ComboBox SaveFormatComboBox;
        private System.Windows.Forms.Label SaveFormatLabel;
        private System.Windows.Forms.Panel RightArrowPanel;
        private System.Windows.Forms.PictureBox RightArrowPictureBox;
        private System.Windows.Forms.PictureBox DelimiterPictureBox_1;
        private System.Windows.Forms.CheckBox SaveToFoldersCheckBox;
        private System.Windows.Forms.PictureBox DelimiterPictureBox_2;
        private System.Windows.Forms.CheckBox DisableSeparatingInPreview;
        private System.Windows.Forms.Button GrayPreviewSwitchButton;
        private System.Windows.Forms.ComboBox DetectionResolutionComboBox;
        private System.Windows.Forms.Label DetectionResolutionLabel;
        private System.Windows.Forms.Label PXLabel_1;
        private System.Windows.Forms.Label PXLabel_3;
        private System.Windows.Forms.Label PXLabel_2;
        private System.Windows.Forms.Label CurrentImageLabel_2;
        private System.Windows.Forms.TabControl DisplayTabControl;
        private System.Windows.Forms.TabPage DisplayTab;
        private System.Windows.Forms.TabPage FileExplorerTab;
        private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.ImageList FilesPreviewImageList;
        private System.Windows.Forms.TableLayoutPanel FilesListPreviewControlPanel;
        private System.Windows.Forms.Button DeleteSelectedFileListViewButton;
        private System.Windows.Forms.Button DeleteAllFileListViewButton;
        private System.Windows.Forms.Button SortByStructureFileListViewButton;
        private System.Windows.Forms.Button SortByNameFileListViewButton;
        private System.Windows.Forms.ComboBox SettingsPresetComboBox;
        private System.Windows.Forms.Button SaveSettingsPresetButton;
        private System.Windows.Forms.GroupBox PresetEditGroupBox;
        private System.Windows.Forms.Button ReplacePresetButton;
        private System.Windows.Forms.Button CreateNewPresetButton;
        private System.Windows.Forms.DataGridView PresetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Button DeletePresetButton;
        private System.Windows.Forms.Button ImportPresetButton;
        private System.Windows.Forms.Button ExportPresetButton;
        private System.Windows.Forms.Button UpdatePresetsButton;
        private System.Windows.Forms.Panel BC_LeftArrowPanel;
        private System.Windows.Forms.Panel BC_RightArrowPanel;
        private System.Windows.Forms.Label BC_InputPathLabel_2;
        private System.Windows.Forms.Button GrayPreviewSwitchButton_2;
        private System.Windows.Forms.Button ChangeBorderColorButton_2;
        private System.Windows.Forms.Button HelpButton_2;
        private System.Windows.Forms.Button ResetButton_2;
        private System.Windows.Forms.Button GrayPreviewSwitchButton_3;
        private System.Windows.Forms.Button ChangeBorderColorButton_3;
        private System.Windows.Forms.Button HelpButton_3;
        private System.Windows.Forms.Button ResetButton_3;
        private System.Windows.Forms.Button HelpButton_4;
        private System.Windows.Forms.PictureBox DelimiterPictureBox_3;
        private System.Windows.Forms.Panel BC_SettingsPanelScroll;
        private System.Windows.Forms.PictureBox Logo1PictureBox;
        private System.Windows.Forms.TableLayoutPanel LogoTableLayoutPanel;
        private System.Windows.Forms.PictureBox Logo2PictureBox;
    }
}

