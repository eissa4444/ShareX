﻿using ShareX.HelpersLib;
namespace ShareX
{
    partial class ApplicationSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSettingsForm));
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnLanguages = new ShareX.HelpersLib.MenuButton();
            this.cmsLanguages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.llTranslators = new System.Windows.Forms.LinkLabel();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbRememberMainFormPosition = new System.Windows.Forms.CheckBox();
            this.cbSilentRun = new System.Windows.Forms.CheckBox();
            this.cbRememberMainFormSize = new System.Windows.Forms.CheckBox();
            this.cbTaskbarProgressEnabled = new System.Windows.Forms.CheckBox();
            this.cbTrayIconProgressEnabled = new System.Windows.Forms.CheckBox();
            this.cbShellContextMenu = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.cbShowTray = new System.Windows.Forms.CheckBox();
            this.cbSendToMenu = new System.Windows.Forms.CheckBox();
            this.tpPaths = new System.Windows.Forms.TabPage();
            this.lblNotePersonalFolderPath = new System.Windows.Forms.Label();
            this.btnOpenScreenshotsFolder = new System.Windows.Forms.Button();
            this.lblPreviewPersonalFolderPath = new System.Windows.Forms.Label();
            this.btnBrowsePersonalFolderPath = new System.Windows.Forms.Button();
            this.lblPersonalFolderPath = new System.Windows.Forms.Label();
            this.txtPersonalFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseCustomScreenshotsPath = new System.Windows.Forms.Button();
            this.btnOpenPersonalFolderPath = new System.Windows.Forms.Button();
            this.txtCustomScreenshotsPath = new System.Windows.Forms.TextBox();
            this.cbUseCustomScreenshotsPath = new System.Windows.Forms.CheckBox();
            this.lblSaveImageSubFolderPattern = new System.Windows.Forms.Label();
            this.lblSaveImageSubFolderPatternPreview = new System.Windows.Forms.Label();
            this.txtSaveImageSubFolderPattern = new System.Windows.Forms.TextBox();
            this.tpProxy = new System.Windows.Forms.TabPage();
            this.cbProxyMethod = new System.Windows.Forms.ComboBox();
            this.lblProxyMethod = new System.Windows.Forms.Label();
            this.lblProxyHost = new System.Windows.Forms.Label();
            this.txtProxyHost = new System.Windows.Forms.TextBox();
            this.nudProxyPort = new System.Windows.Forms.NumericUpDown();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.lblProxyPassword = new System.Windows.Forms.Label();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.lblProxyUsername = new System.Windows.Forms.Label();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.tpUpload = new System.Windows.Forms.TabPage();
            this.tcUpload = new System.Windows.Forms.TabControl();
            this.tpPerformance = new System.Windows.Forms.TabPage();
            this.lblUploadLimit = new System.Windows.Forms.Label();
            this.nudUploadLimit = new System.Windows.Forms.NumericUpDown();
            this.lblUploadLimitHint = new System.Windows.Forms.Label();
            this.cbBufferSize = new System.Windows.Forms.ComboBox();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.tpUploadResults = new System.Windows.Forms.TabPage();
            this.gbClipboardFormats = new System.Windows.Forms.GroupBox();
            this.btnClipboardFormatEdit = new System.Windows.Forms.Button();
            this.btnClipboardFormatRemove = new System.Windows.Forms.Button();
            this.btnClipboardFormatAdd = new System.Windows.Forms.Button();
            this.lvClipboardFormats = new ShareX.HelpersLib.MyListView();
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpUploadRetry = new System.Windows.Forms.TabPage();
            this.chkUseSecondaryUploaders = new System.Windows.Forms.CheckBox();
            this.tlpBackupDestinations = new System.Windows.Forms.TableLayoutPanel();
            this.gbSecondaryImageUploaders = new System.Windows.Forms.GroupBox();
            this.lvSecondaryImageUploaders = new ShareX.HelpersLib.MyListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSecondaryFileUploaders = new System.Windows.Forms.GroupBox();
            this.lvSecondaryFileUploaders = new ShareX.HelpersLib.MyListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSecondaryTextUploaders = new System.Windows.Forms.GroupBox();
            this.lvSecondaryTextUploaders = new ShareX.HelpersLib.MyListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbIfUploadFailRetryOnce = new System.Windows.Forms.Label();
            this.nudRetryUpload = new System.Windows.Forms.NumericUpDown();
            this.tpPrint = new System.Windows.Forms.TabPage();
            this.cbPrintDontShowWindowsDialog = new System.Windows.Forms.CheckBox();
            this.cbDontShowPrintSettingDialog = new System.Windows.Forms.CheckBox();
            this.btnShowImagePrintSettings = new System.Windows.Forms.Button();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.pgSettings = new System.Windows.Forms.PropertyGrid();
            this.tttvMain = new ShareX.HelpersLib.TabToTreeView();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpPaths.SuspendLayout();
            this.tpProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProxyPort)).BeginInit();
            this.tpUpload.SuspendLayout();
            this.tcUpload.SuspendLayout();
            this.tpPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadLimit)).BeginInit();
            this.tpUploadResults.SuspendLayout();
            this.gbClipboardFormats.SuspendLayout();
            this.tpUploadRetry.SuspendLayout();
            this.tlpBackupDestinations.SuspendLayout();
            this.gbSecondaryImageUploaders.SuspendLayout();
            this.gbSecondaryFileUploaders.SuspendLayout();
            this.gbSecondaryTextUploaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetryUpload)).BeginInit();
            this.tpPrint.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            resources.ApplyResources(this.tcSettings, "tcSettings");
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tpPaths);
            this.tcSettings.Controls.Add(this.tpProxy);
            this.tcSettings.Controls.Add(this.tpUpload);
            this.tcSettings.Controls.Add(this.tpPrint);
            this.tcSettings.Controls.Add(this.tpAdvanced);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnLanguages);
            this.tpGeneral.Controls.Add(this.llTranslators);
            this.tpGeneral.Controls.Add(this.lblLanguage);
            this.tpGeneral.Controls.Add(this.cbRememberMainFormPosition);
            this.tpGeneral.Controls.Add(this.cbSilentRun);
            this.tpGeneral.Controls.Add(this.cbRememberMainFormSize);
            this.tpGeneral.Controls.Add(this.cbTaskbarProgressEnabled);
            this.tpGeneral.Controls.Add(this.cbTrayIconProgressEnabled);
            this.tpGeneral.Controls.Add(this.cbShellContextMenu);
            this.tpGeneral.Controls.Add(this.cbStartWithWindows);
            this.tpGeneral.Controls.Add(this.cbShowTray);
            this.tpGeneral.Controls.Add(this.cbSendToMenu);
            resources.ApplyResources(this.tpGeneral, "tpGeneral");
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btnLanguages
            // 
            resources.ApplyResources(this.btnLanguages, "btnLanguages");
            this.btnLanguages.Menu = this.cmsLanguages;
            this.btnLanguages.MenuX0 = true;
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.UseVisualStyleBackColor = true;
            // 
            // cmsLanguages
            // 
            this.cmsLanguages.Name = "cmsLanguages";
            resources.ApplyResources(this.cmsLanguages, "cmsLanguages");
            // 
            // llTranslators
            // 
            resources.ApplyResources(this.llTranslators, "llTranslators");
            this.llTranslators.Name = "llTranslators";
            this.llTranslators.TabStop = true;
            this.llTranslators.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTranslators_LinkClicked);
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // cbRememberMainFormPosition
            // 
            resources.ApplyResources(this.cbRememberMainFormPosition, "cbRememberMainFormPosition");
            this.cbRememberMainFormPosition.Name = "cbRememberMainFormPosition";
            this.cbRememberMainFormPosition.UseVisualStyleBackColor = true;
            this.cbRememberMainFormPosition.CheckedChanged += new System.EventHandler(this.cbRememberMainFormPosition_CheckedChanged);
            // 
            // cbSilentRun
            // 
            resources.ApplyResources(this.cbSilentRun, "cbSilentRun");
            this.cbSilentRun.Name = "cbSilentRun";
            this.cbSilentRun.UseVisualStyleBackColor = true;
            this.cbSilentRun.CheckedChanged += new System.EventHandler(this.cbSilentRun_CheckedChanged);
            // 
            // cbRememberMainFormSize
            // 
            resources.ApplyResources(this.cbRememberMainFormSize, "cbRememberMainFormSize");
            this.cbRememberMainFormSize.Name = "cbRememberMainFormSize";
            this.cbRememberMainFormSize.UseVisualStyleBackColor = true;
            this.cbRememberMainFormSize.CheckedChanged += new System.EventHandler(this.cbRememberMainFormSize_CheckedChanged);
            // 
            // cbTaskbarProgressEnabled
            // 
            resources.ApplyResources(this.cbTaskbarProgressEnabled, "cbTaskbarProgressEnabled");
            this.cbTaskbarProgressEnabled.Name = "cbTaskbarProgressEnabled";
            this.cbTaskbarProgressEnabled.UseVisualStyleBackColor = true;
            this.cbTaskbarProgressEnabled.CheckedChanged += new System.EventHandler(this.cbTaskbarProgressEnabled_CheckedChanged);
            // 
            // cbTrayIconProgressEnabled
            // 
            resources.ApplyResources(this.cbTrayIconProgressEnabled, "cbTrayIconProgressEnabled");
            this.cbTrayIconProgressEnabled.Name = "cbTrayIconProgressEnabled";
            this.cbTrayIconProgressEnabled.UseVisualStyleBackColor = true;
            this.cbTrayIconProgressEnabled.CheckedChanged += new System.EventHandler(this.cbTrayIconProgressEnabled_CheckedChanged);
            // 
            // cbShellContextMenu
            // 
            resources.ApplyResources(this.cbShellContextMenu, "cbShellContextMenu");
            this.cbShellContextMenu.Name = "cbShellContextMenu";
            this.cbShellContextMenu.UseVisualStyleBackColor = true;
            this.cbShellContextMenu.CheckedChanged += new System.EventHandler(this.cbShellContextMenu_CheckedChanged);
            // 
            // cbStartWithWindows
            // 
            resources.ApplyResources(this.cbStartWithWindows, "cbStartWithWindows");
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // cbShowTray
            // 
            resources.ApplyResources(this.cbShowTray, "cbShowTray");
            this.cbShowTray.Name = "cbShowTray";
            this.cbShowTray.UseVisualStyleBackColor = true;
            this.cbShowTray.CheckedChanged += new System.EventHandler(this.cbShowTray_CheckedChanged);
            // 
            // cbSendToMenu
            // 
            resources.ApplyResources(this.cbSendToMenu, "cbSendToMenu");
            this.cbSendToMenu.Name = "cbSendToMenu";
            this.cbSendToMenu.UseVisualStyleBackColor = true;
            this.cbSendToMenu.CheckedChanged += new System.EventHandler(this.cbSendToMenu_CheckedChanged);
            // 
            // tpPaths
            // 
            this.tpPaths.Controls.Add(this.lblNotePersonalFolderPath);
            this.tpPaths.Controls.Add(this.btnOpenScreenshotsFolder);
            this.tpPaths.Controls.Add(this.lblPreviewPersonalFolderPath);
            this.tpPaths.Controls.Add(this.btnBrowsePersonalFolderPath);
            this.tpPaths.Controls.Add(this.lblPersonalFolderPath);
            this.tpPaths.Controls.Add(this.txtPersonalFolderPath);
            this.tpPaths.Controls.Add(this.btnBrowseCustomScreenshotsPath);
            this.tpPaths.Controls.Add(this.btnOpenPersonalFolderPath);
            this.tpPaths.Controls.Add(this.txtCustomScreenshotsPath);
            this.tpPaths.Controls.Add(this.cbUseCustomScreenshotsPath);
            this.tpPaths.Controls.Add(this.lblSaveImageSubFolderPattern);
            this.tpPaths.Controls.Add(this.lblSaveImageSubFolderPatternPreview);
            this.tpPaths.Controls.Add(this.txtSaveImageSubFolderPattern);
            resources.ApplyResources(this.tpPaths, "tpPaths");
            this.tpPaths.Name = "tpPaths";
            this.tpPaths.UseVisualStyleBackColor = true;
            // 
            // lblNotePersonalFolderPath
            // 
            resources.ApplyResources(this.lblNotePersonalFolderPath, "lblNotePersonalFolderPath");
            this.lblNotePersonalFolderPath.Name = "lblNotePersonalFolderPath";
            // 
            // btnOpenScreenshotsFolder
            // 
            resources.ApplyResources(this.btnOpenScreenshotsFolder, "btnOpenScreenshotsFolder");
            this.btnOpenScreenshotsFolder.Name = "btnOpenScreenshotsFolder";
            this.btnOpenScreenshotsFolder.UseVisualStyleBackColor = true;
            this.btnOpenScreenshotsFolder.Click += new System.EventHandler(this.btnOpenScreenshotsFolder_Click);
            // 
            // lblPreviewPersonalFolderPath
            // 
            resources.ApplyResources(this.lblPreviewPersonalFolderPath, "lblPreviewPersonalFolderPath");
            this.lblPreviewPersonalFolderPath.Name = "lblPreviewPersonalFolderPath";
            // 
            // btnBrowsePersonalFolderPath
            // 
            resources.ApplyResources(this.btnBrowsePersonalFolderPath, "btnBrowsePersonalFolderPath");
            this.btnBrowsePersonalFolderPath.Name = "btnBrowsePersonalFolderPath";
            this.btnBrowsePersonalFolderPath.UseVisualStyleBackColor = true;
            this.btnBrowsePersonalFolderPath.Click += new System.EventHandler(this.btnBrowsePersonalFolderPath_Click);
            // 
            // lblPersonalFolderPath
            // 
            resources.ApplyResources(this.lblPersonalFolderPath, "lblPersonalFolderPath");
            this.lblPersonalFolderPath.Name = "lblPersonalFolderPath";
            // 
            // txtPersonalFolderPath
            // 
            resources.ApplyResources(this.txtPersonalFolderPath, "txtPersonalFolderPath");
            this.txtPersonalFolderPath.Name = "txtPersonalFolderPath";
            this.txtPersonalFolderPath.TextChanged += new System.EventHandler(this.txtPersonalFolderPath_TextChanged);
            // 
            // btnBrowseCustomScreenshotsPath
            // 
            resources.ApplyResources(this.btnBrowseCustomScreenshotsPath, "btnBrowseCustomScreenshotsPath");
            this.btnBrowseCustomScreenshotsPath.Name = "btnBrowseCustomScreenshotsPath";
            this.btnBrowseCustomScreenshotsPath.UseVisualStyleBackColor = true;
            this.btnBrowseCustomScreenshotsPath.Click += new System.EventHandler(this.btnBrowseCustomScreenshotsPath_Click);
            // 
            // btnOpenPersonalFolderPath
            // 
            resources.ApplyResources(this.btnOpenPersonalFolderPath, "btnOpenPersonalFolderPath");
            this.btnOpenPersonalFolderPath.Name = "btnOpenPersonalFolderPath";
            this.btnOpenPersonalFolderPath.UseVisualStyleBackColor = true;
            this.btnOpenPersonalFolderPath.Click += new System.EventHandler(this.btnOpenPersonalFolder_Click);
            // 
            // txtCustomScreenshotsPath
            // 
            resources.ApplyResources(this.txtCustomScreenshotsPath, "txtCustomScreenshotsPath");
            this.txtCustomScreenshotsPath.Name = "txtCustomScreenshotsPath";
            this.txtCustomScreenshotsPath.TextChanged += new System.EventHandler(this.txtCustomScreenshotsPath_TextChanged);
            // 
            // cbUseCustomScreenshotsPath
            // 
            resources.ApplyResources(this.cbUseCustomScreenshotsPath, "cbUseCustomScreenshotsPath");
            this.cbUseCustomScreenshotsPath.Name = "cbUseCustomScreenshotsPath";
            this.cbUseCustomScreenshotsPath.UseVisualStyleBackColor = true;
            this.cbUseCustomScreenshotsPath.CheckedChanged += new System.EventHandler(this.cbUseCustomScreenshotsPath_CheckedChanged);
            // 
            // lblSaveImageSubFolderPattern
            // 
            resources.ApplyResources(this.lblSaveImageSubFolderPattern, "lblSaveImageSubFolderPattern");
            this.lblSaveImageSubFolderPattern.Name = "lblSaveImageSubFolderPattern";
            // 
            // lblSaveImageSubFolderPatternPreview
            // 
            resources.ApplyResources(this.lblSaveImageSubFolderPatternPreview, "lblSaveImageSubFolderPatternPreview");
            this.lblSaveImageSubFolderPatternPreview.Name = "lblSaveImageSubFolderPatternPreview";
            // 
            // txtSaveImageSubFolderPattern
            // 
            resources.ApplyResources(this.txtSaveImageSubFolderPattern, "txtSaveImageSubFolderPattern");
            this.txtSaveImageSubFolderPattern.Name = "txtSaveImageSubFolderPattern";
            this.txtSaveImageSubFolderPattern.TextChanged += new System.EventHandler(this.txtSaveImageSubFolderPattern_TextChanged);
            // 
            // tpProxy
            // 
            this.tpProxy.Controls.Add(this.cbProxyMethod);
            this.tpProxy.Controls.Add(this.lblProxyMethod);
            this.tpProxy.Controls.Add(this.lblProxyHost);
            this.tpProxy.Controls.Add(this.txtProxyHost);
            this.tpProxy.Controls.Add(this.nudProxyPort);
            this.tpProxy.Controls.Add(this.lblProxyPort);
            this.tpProxy.Controls.Add(this.lblProxyPassword);
            this.tpProxy.Controls.Add(this.txtProxyPassword);
            this.tpProxy.Controls.Add(this.lblProxyUsername);
            this.tpProxy.Controls.Add(this.txtProxyUsername);
            resources.ApplyResources(this.tpProxy, "tpProxy");
            this.tpProxy.Name = "tpProxy";
            this.tpProxy.UseVisualStyleBackColor = true;
            // 
            // cbProxyMethod
            // 
            this.cbProxyMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProxyMethod.FormattingEnabled = true;
            resources.ApplyResources(this.cbProxyMethod, "cbProxyMethod");
            this.cbProxyMethod.Name = "cbProxyMethod";
            this.cbProxyMethod.SelectedIndexChanged += new System.EventHandler(this.cbProxyMethod_SelectedIndexChanged);
            // 
            // lblProxyMethod
            // 
            resources.ApplyResources(this.lblProxyMethod, "lblProxyMethod");
            this.lblProxyMethod.Name = "lblProxyMethod";
            // 
            // lblProxyHost
            // 
            resources.ApplyResources(this.lblProxyHost, "lblProxyHost");
            this.lblProxyHost.Name = "lblProxyHost";
            // 
            // txtProxyHost
            // 
            resources.ApplyResources(this.txtProxyHost, "txtProxyHost");
            this.txtProxyHost.Name = "txtProxyHost";
            this.txtProxyHost.TextChanged += new System.EventHandler(this.txtProxyHost_TextChanged);
            // 
            // nudProxyPort
            // 
            resources.ApplyResources(this.nudProxyPort, "nudProxyPort");
            this.nudProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudProxyPort.Name = "nudProxyPort";
            this.nudProxyPort.ValueChanged += new System.EventHandler(this.nudProxyPort_ValueChanged);
            // 
            // lblProxyPort
            // 
            resources.ApplyResources(this.lblProxyPort, "lblProxyPort");
            this.lblProxyPort.Name = "lblProxyPort";
            // 
            // lblProxyPassword
            // 
            resources.ApplyResources(this.lblProxyPassword, "lblProxyPassword");
            this.lblProxyPassword.Name = "lblProxyPassword";
            // 
            // txtProxyPassword
            // 
            resources.ApplyResources(this.txtProxyPassword, "txtProxyPassword");
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.UseSystemPasswordChar = true;
            this.txtProxyPassword.TextChanged += new System.EventHandler(this.txtProxyPassword_TextChanged);
            // 
            // lblProxyUsername
            // 
            resources.ApplyResources(this.lblProxyUsername, "lblProxyUsername");
            this.lblProxyUsername.Name = "lblProxyUsername";
            // 
            // txtProxyUsername
            // 
            resources.ApplyResources(this.txtProxyUsername, "txtProxyUsername");
            this.txtProxyUsername.Name = "txtProxyUsername";
            this.txtProxyUsername.TextChanged += new System.EventHandler(this.txtProxyUsername_TextChanged);
            // 
            // tpUpload
            // 
            this.tpUpload.Controls.Add(this.tcUpload);
            resources.ApplyResources(this.tpUpload, "tpUpload");
            this.tpUpload.Name = "tpUpload";
            this.tpUpload.UseVisualStyleBackColor = true;
            // 
            // tcUpload
            // 
            this.tcUpload.Controls.Add(this.tpPerformance);
            this.tcUpload.Controls.Add(this.tpUploadResults);
            this.tcUpload.Controls.Add(this.tpUploadRetry);
            resources.ApplyResources(this.tcUpload, "tcUpload");
            this.tcUpload.Name = "tcUpload";
            this.tcUpload.SelectedIndex = 0;
            // 
            // tpPerformance
            // 
            this.tpPerformance.Controls.Add(this.lblUploadLimit);
            this.tpPerformance.Controls.Add(this.nudUploadLimit);
            this.tpPerformance.Controls.Add(this.lblUploadLimitHint);
            this.tpPerformance.Controls.Add(this.cbBufferSize);
            this.tpPerformance.Controls.Add(this.lblBufferSize);
            resources.ApplyResources(this.tpPerformance, "tpPerformance");
            this.tpPerformance.Name = "tpPerformance";
            this.tpPerformance.UseVisualStyleBackColor = true;
            // 
            // lblUploadLimit
            // 
            resources.ApplyResources(this.lblUploadLimit, "lblUploadLimit");
            this.lblUploadLimit.Name = "lblUploadLimit";
            // 
            // nudUploadLimit
            // 
            resources.ApplyResources(this.nudUploadLimit, "nudUploadLimit");
            this.nudUploadLimit.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudUploadLimit.Name = "nudUploadLimit";
            this.nudUploadLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUploadLimit.ValueChanged += new System.EventHandler(this.nudUploadLimit_ValueChanged);
            // 
            // lblUploadLimitHint
            // 
            resources.ApplyResources(this.lblUploadLimitHint, "lblUploadLimitHint");
            this.lblUploadLimitHint.Name = "lblUploadLimitHint";
            // 
            // cbBufferSize
            // 
            this.cbBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBufferSize.FormattingEnabled = true;
            resources.ApplyResources(this.cbBufferSize, "cbBufferSize");
            this.cbBufferSize.Name = "cbBufferSize";
            this.cbBufferSize.SelectedIndexChanged += new System.EventHandler(this.cbBufferSize_SelectedIndexChanged);
            // 
            // lblBufferSize
            // 
            resources.ApplyResources(this.lblBufferSize, "lblBufferSize");
            this.lblBufferSize.Name = "lblBufferSize";
            // 
            // tpUploadResults
            // 
            this.tpUploadResults.Controls.Add(this.gbClipboardFormats);
            resources.ApplyResources(this.tpUploadResults, "tpUploadResults");
            this.tpUploadResults.Name = "tpUploadResults";
            this.tpUploadResults.UseVisualStyleBackColor = true;
            // 
            // gbClipboardFormats
            // 
            resources.ApplyResources(this.gbClipboardFormats, "gbClipboardFormats");
            this.gbClipboardFormats.Controls.Add(this.btnClipboardFormatEdit);
            this.gbClipboardFormats.Controls.Add(this.btnClipboardFormatRemove);
            this.gbClipboardFormats.Controls.Add(this.btnClipboardFormatAdd);
            this.gbClipboardFormats.Controls.Add(this.lvClipboardFormats);
            this.gbClipboardFormats.Name = "gbClipboardFormats";
            this.gbClipboardFormats.TabStop = false;
            // 
            // btnClipboardFormatEdit
            // 
            resources.ApplyResources(this.btnClipboardFormatEdit, "btnClipboardFormatEdit");
            this.btnClipboardFormatEdit.Name = "btnClipboardFormatEdit";
            this.btnClipboardFormatEdit.UseVisualStyleBackColor = true;
            this.btnClipboardFormatEdit.Click += new System.EventHandler(this.btnClipboardFormatEdit_Click);
            // 
            // btnClipboardFormatRemove
            // 
            resources.ApplyResources(this.btnClipboardFormatRemove, "btnClipboardFormatRemove");
            this.btnClipboardFormatRemove.Name = "btnClipboardFormatRemove";
            this.btnClipboardFormatRemove.UseVisualStyleBackColor = true;
            this.btnClipboardFormatRemove.Click += new System.EventHandler(this.btnClipboardFormatRemove_Click);
            // 
            // btnClipboardFormatAdd
            // 
            resources.ApplyResources(this.btnClipboardFormatAdd, "btnClipboardFormatAdd");
            this.btnClipboardFormatAdd.Name = "btnClipboardFormatAdd";
            this.btnClipboardFormatAdd.UseVisualStyleBackColor = true;
            this.btnClipboardFormatAdd.Click += new System.EventHandler(this.btnAddClipboardFormat_Click);
            // 
            // lvClipboardFormats
            // 
            resources.ApplyResources(this.lvClipboardFormats, "lvClipboardFormats");
            this.lvClipboardFormats.AutoFillColumn = true;
            this.lvClipboardFormats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDescription,
            this.chFormat});
            this.lvClipboardFormats.FullRowSelect = true;
            this.lvClipboardFormats.Name = "lvClipboardFormats";
            this.lvClipboardFormats.UseCompatibleStateImageBehavior = false;
            this.lvClipboardFormats.View = System.Windows.Forms.View.Details;
            this.lvClipboardFormats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvClipboardFormats_MouseDoubleClick);
            // 
            // chDescription
            // 
            resources.ApplyResources(this.chDescription, "chDescription");
            // 
            // chFormat
            // 
            resources.ApplyResources(this.chFormat, "chFormat");
            // 
            // tpUploadRetry
            // 
            this.tpUploadRetry.Controls.Add(this.chkUseSecondaryUploaders);
            this.tpUploadRetry.Controls.Add(this.tlpBackupDestinations);
            this.tpUploadRetry.Controls.Add(this.cbIfUploadFailRetryOnce);
            this.tpUploadRetry.Controls.Add(this.nudRetryUpload);
            resources.ApplyResources(this.tpUploadRetry, "tpUploadRetry");
            this.tpUploadRetry.Name = "tpUploadRetry";
            this.tpUploadRetry.UseVisualStyleBackColor = true;
            // 
            // chkUseSecondaryUploaders
            // 
            resources.ApplyResources(this.chkUseSecondaryUploaders, "chkUseSecondaryUploaders");
            this.chkUseSecondaryUploaders.Name = "chkUseSecondaryUploaders";
            this.chkUseSecondaryUploaders.UseVisualStyleBackColor = true;
            this.chkUseSecondaryUploaders.CheckedChanged += new System.EventHandler(this.chkUseSecondaryUploaders_CheckedChanged);
            // 
            // tlpBackupDestinations
            // 
            resources.ApplyResources(this.tlpBackupDestinations, "tlpBackupDestinations");
            this.tlpBackupDestinations.Controls.Add(this.gbSecondaryImageUploaders, 0, 0);
            this.tlpBackupDestinations.Controls.Add(this.gbSecondaryFileUploaders, 2, 0);
            this.tlpBackupDestinations.Controls.Add(this.gbSecondaryTextUploaders, 1, 0);
            this.tlpBackupDestinations.Name = "tlpBackupDestinations";
            // 
            // gbSecondaryImageUploaders
            // 
            this.gbSecondaryImageUploaders.Controls.Add(this.lvSecondaryImageUploaders);
            resources.ApplyResources(this.gbSecondaryImageUploaders, "gbSecondaryImageUploaders");
            this.gbSecondaryImageUploaders.Name = "gbSecondaryImageUploaders";
            this.gbSecondaryImageUploaders.TabStop = false;
            // 
            // lvSecondaryImageUploaders
            // 
            this.lvSecondaryImageUploaders.AllowDrop = true;
            this.lvSecondaryImageUploaders.AllowItemDrag = true;
            this.lvSecondaryImageUploaders.AutoFillColumn = true;
            this.lvSecondaryImageUploaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSecondaryImageUploaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            resources.ApplyResources(this.lvSecondaryImageUploaders, "lvSecondaryImageUploaders");
            this.lvSecondaryImageUploaders.FullRowSelect = true;
            this.lvSecondaryImageUploaders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSecondaryImageUploaders.HideSelection = false;
            this.lvSecondaryImageUploaders.MultiSelect = false;
            this.lvSecondaryImageUploaders.Name = "lvSecondaryImageUploaders";
            this.lvSecondaryImageUploaders.UseCompatibleStateImageBehavior = false;
            this.lvSecondaryImageUploaders.View = System.Windows.Forms.View.Details;
            this.lvSecondaryImageUploaders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvSecondaryUploaders_MouseUp);
            // 
            // gbSecondaryFileUploaders
            // 
            this.gbSecondaryFileUploaders.Controls.Add(this.lvSecondaryFileUploaders);
            resources.ApplyResources(this.gbSecondaryFileUploaders, "gbSecondaryFileUploaders");
            this.gbSecondaryFileUploaders.Name = "gbSecondaryFileUploaders";
            this.gbSecondaryFileUploaders.TabStop = false;
            // 
            // lvSecondaryFileUploaders
            // 
            this.lvSecondaryFileUploaders.AllowDrop = true;
            this.lvSecondaryFileUploaders.AllowItemDrag = true;
            this.lvSecondaryFileUploaders.AutoFillColumn = true;
            this.lvSecondaryFileUploaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSecondaryFileUploaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            resources.ApplyResources(this.lvSecondaryFileUploaders, "lvSecondaryFileUploaders");
            this.lvSecondaryFileUploaders.FullRowSelect = true;
            this.lvSecondaryFileUploaders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSecondaryFileUploaders.MultiSelect = false;
            this.lvSecondaryFileUploaders.Name = "lvSecondaryFileUploaders";
            this.lvSecondaryFileUploaders.UseCompatibleStateImageBehavior = false;
            this.lvSecondaryFileUploaders.View = System.Windows.Forms.View.Details;
            this.lvSecondaryFileUploaders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvSecondaryUploaders_MouseUp);
            // 
            // gbSecondaryTextUploaders
            // 
            this.gbSecondaryTextUploaders.Controls.Add(this.lvSecondaryTextUploaders);
            resources.ApplyResources(this.gbSecondaryTextUploaders, "gbSecondaryTextUploaders");
            this.gbSecondaryTextUploaders.Name = "gbSecondaryTextUploaders";
            this.gbSecondaryTextUploaders.TabStop = false;
            // 
            // lvSecondaryTextUploaders
            // 
            this.lvSecondaryTextUploaders.AllowDrop = true;
            this.lvSecondaryTextUploaders.AllowItemDrag = true;
            this.lvSecondaryTextUploaders.AutoFillColumn = true;
            this.lvSecondaryTextUploaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSecondaryTextUploaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            resources.ApplyResources(this.lvSecondaryTextUploaders, "lvSecondaryTextUploaders");
            this.lvSecondaryTextUploaders.FullRowSelect = true;
            this.lvSecondaryTextUploaders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSecondaryTextUploaders.MultiSelect = false;
            this.lvSecondaryTextUploaders.Name = "lvSecondaryTextUploaders";
            this.lvSecondaryTextUploaders.UseCompatibleStateImageBehavior = false;
            this.lvSecondaryTextUploaders.View = System.Windows.Forms.View.Details;
            this.lvSecondaryTextUploaders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvSecondaryUploaders_MouseUp);
            // 
            // cbIfUploadFailRetryOnce
            // 
            resources.ApplyResources(this.cbIfUploadFailRetryOnce, "cbIfUploadFailRetryOnce");
            this.cbIfUploadFailRetryOnce.Name = "cbIfUploadFailRetryOnce";
            // 
            // nudRetryUpload
            // 
            resources.ApplyResources(this.nudRetryUpload, "nudRetryUpload");
            this.nudRetryUpload.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRetryUpload.Name = "nudRetryUpload";
            this.nudRetryUpload.ValueChanged += new System.EventHandler(this.nudRetryUpload_ValueChanged);
            // 
            // tpPrint
            // 
            this.tpPrint.Controls.Add(this.cbPrintDontShowWindowsDialog);
            this.tpPrint.Controls.Add(this.cbDontShowPrintSettingDialog);
            this.tpPrint.Controls.Add(this.btnShowImagePrintSettings);
            resources.ApplyResources(this.tpPrint, "tpPrint");
            this.tpPrint.Name = "tpPrint";
            this.tpPrint.UseVisualStyleBackColor = true;
            // 
            // cbPrintDontShowWindowsDialog
            // 
            resources.ApplyResources(this.cbPrintDontShowWindowsDialog, "cbPrintDontShowWindowsDialog");
            this.cbPrintDontShowWindowsDialog.Name = "cbPrintDontShowWindowsDialog";
            this.cbPrintDontShowWindowsDialog.UseVisualStyleBackColor = true;
            this.cbPrintDontShowWindowsDialog.CheckedChanged += new System.EventHandler(this.cbPrintDontShowWindowsDialog_CheckedChanged);
            // 
            // cbDontShowPrintSettingDialog
            // 
            resources.ApplyResources(this.cbDontShowPrintSettingDialog, "cbDontShowPrintSettingDialog");
            this.cbDontShowPrintSettingDialog.Name = "cbDontShowPrintSettingDialog";
            this.cbDontShowPrintSettingDialog.UseVisualStyleBackColor = true;
            this.cbDontShowPrintSettingDialog.CheckedChanged += new System.EventHandler(this.cbDontShowPrintSettingDialog_CheckedChanged);
            // 
            // btnShowImagePrintSettings
            // 
            resources.ApplyResources(this.btnShowImagePrintSettings, "btnShowImagePrintSettings");
            this.btnShowImagePrintSettings.Name = "btnShowImagePrintSettings";
            this.btnShowImagePrintSettings.UseVisualStyleBackColor = true;
            this.btnShowImagePrintSettings.Click += new System.EventHandler(this.btnShowImagePrintSettings_Click);
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.pgSettings);
            resources.ApplyResources(this.tpAdvanced, "tpAdvanced");
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // pgSettings
            // 
            resources.ApplyResources(this.pgSettings, "pgSettings");
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pgSettings.ToolbarVisible = false;
            // 
            // tttvMain
            // 
            resources.ApplyResources(this.tttvMain, "tttvMain");
            this.tttvMain.ImageList = null;
            this.tttvMain.MainTabControl = null;
            this.tttvMain.Name = "tttvMain";
            this.tttvMain.TreeViewFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tttvMain.TreeViewSize = 175;
            // 
            // ApplicationSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcSettings);
            this.Controls.Add(this.tttvMain);
            this.Name = "ApplicationSettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpPaths.ResumeLayout(false);
            this.tpPaths.PerformLayout();
            this.tpProxy.ResumeLayout(false);
            this.tpProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProxyPort)).EndInit();
            this.tpUpload.ResumeLayout(false);
            this.tcUpload.ResumeLayout(false);
            this.tpPerformance.ResumeLayout(false);
            this.tpPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadLimit)).EndInit();
            this.tpUploadResults.ResumeLayout(false);
            this.gbClipboardFormats.ResumeLayout(false);
            this.tpUploadRetry.ResumeLayout(false);
            this.tpUploadRetry.PerformLayout();
            this.tlpBackupDestinations.ResumeLayout(false);
            this.gbSecondaryImageUploaders.ResumeLayout(false);
            this.gbSecondaryFileUploaders.ResumeLayout(false);
            this.gbSecondaryTextUploaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRetryUpload)).EndInit();
            this.tpPrint.ResumeLayout(false);
            this.tpPrint.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

   

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpProxy;
        private System.Windows.Forms.CheckBox cbSendToMenu;
        private System.Windows.Forms.Button btnOpenPersonalFolderPath;
        private System.Windows.Forms.CheckBox cbShowTray;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.Label lblSaveImageSubFolderPatternPreview;
        private System.Windows.Forms.TextBox txtSaveImageSubFolderPattern;
        private System.Windows.Forms.Label lblSaveImageSubFolderPattern;
        private System.Windows.Forms.CheckBox cbUseCustomScreenshotsPath;
        private System.Windows.Forms.TabPage tpPaths;
        private System.Windows.Forms.Button btnBrowseCustomScreenshotsPath;
        private System.Windows.Forms.TextBox txtCustomScreenshotsPath;
        private System.Windows.Forms.Label lblProxyHost;
        private System.Windows.Forms.TextBox txtProxyHost;
        private System.Windows.Forms.NumericUpDown nudProxyPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.Label lblProxyPassword;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label lblProxyUsername;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.CheckBox cbShellContextMenu;
        private System.Windows.Forms.ComboBox cbProxyMethod;
        private System.Windows.Forms.Label lblProxyMethod;
        private System.Windows.Forms.TabPage tpUpload;
        private System.Windows.Forms.Label cbIfUploadFailRetryOnce;
        private System.Windows.Forms.Label lblUploadLimit;
        private System.Windows.Forms.ComboBox cbBufferSize;
        private System.Windows.Forms.Label lblUploadLimitHint;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.NumericUpDown nudUploadLimit;
        private System.Windows.Forms.GroupBox gbClipboardFormats;
        private System.Windows.Forms.Button btnClipboardFormatRemove;
        private System.Windows.Forms.Button btnClipboardFormatAdd;
        private HelpersLib.MyListView lvClipboardFormats;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chFormat;
        private System.Windows.Forms.Button btnClipboardFormatEdit;
        private System.Windows.Forms.TabPage tpPrint;
        private System.Windows.Forms.CheckBox cbDontShowPrintSettingDialog;
        private System.Windows.Forms.Button btnShowImagePrintSettings;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.PropertyGrid pgSettings;
        private System.Windows.Forms.CheckBox cbTaskbarProgressEnabled;
        private System.Windows.Forms.CheckBox cbTrayIconProgressEnabled;
        private System.Windows.Forms.CheckBox cbRememberMainFormSize;
        private System.Windows.Forms.Label lblPreviewPersonalFolderPath;
        private System.Windows.Forms.Button btnBrowsePersonalFolderPath;
        private System.Windows.Forms.Label lblPersonalFolderPath;
        private System.Windows.Forms.TextBox txtPersonalFolderPath;
        private System.Windows.Forms.Button btnOpenScreenshotsFolder;
        private System.Windows.Forms.Label lblNotePersonalFolderPath;
        private System.Windows.Forms.CheckBox cbSilentRun;
        private System.Windows.Forms.NumericUpDown nudRetryUpload;
        private System.Windows.Forms.TableLayoutPanel tlpBackupDestinations;
        private System.Windows.Forms.GroupBox gbSecondaryImageUploaders;
        private MyListView lvSecondaryImageUploaders;
        private System.Windows.Forms.GroupBox gbSecondaryFileUploaders;
        private MyListView lvSecondaryFileUploaders;
        private System.Windows.Forms.GroupBox gbSecondaryTextUploaders;
        private MyListView lvSecondaryTextUploaders;
        private System.Windows.Forms.TabControl tcUpload;
        private System.Windows.Forms.TabPage tpPerformance;
        private System.Windows.Forms.TabPage tpUploadResults;
        private System.Windows.Forms.TabPage tpUploadRetry;
        private System.Windows.Forms.CheckBox chkUseSecondaryUploaders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox cbPrintDontShowWindowsDialog;
        private System.Windows.Forms.CheckBox cbRememberMainFormPosition;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.LinkLabel llTranslators;
        private TabToTreeView tttvMain;
        private MenuButton btnLanguages;
        private System.Windows.Forms.ContextMenuStrip cmsLanguages;
    }
}