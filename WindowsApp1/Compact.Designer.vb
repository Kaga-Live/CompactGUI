<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compact
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compact))
        Me.OldconOut = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttonCompress = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.checkRecursiveScan = New System.Windows.Forms.CheckBox()
        Me.checkHiddenFiles = New System.Windows.Forms.CheckBox()
        Me.checkForceCompression = New System.Windows.Forms.CheckBox()
        Me.compressX4 = New System.Windows.Forms.RadioButton()
        Me.compressX8 = New System.Windows.Forms.RadioButton()
        Me.compressX16 = New System.Windows.Forms.RadioButton()
        Me.compressLZX = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.showinfopopup = New System.Windows.Forms.Label()
        Me.dirChooser = New System.Windows.Forms.LinkLabel()
        Me.chosenDirDisplay = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.preSize = New System.Windows.Forms.Label()
        Me.progressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.progresspercent = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.compactprogressbar = New System.Windows.Forms.ProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.origSizeLabel = New System.Windows.Forms.Label()
        Me.compressedSizeLabel = New System.Windows.Forms.Label()
        Me.compRatioLabel = New System.Windows.Forms.Label()
        Me.spaceSavedLabel = New System.Windows.Forms.Label()
        Me.testcompactargs = New System.Windows.Forms.Button()
        Me.buttonRevert = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.InputPage = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonQueryCompact = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProgressPage = New System.Windows.Forms.TabPage()
        Me.returnArrow = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.checkShowConOut = New System.Windows.Forms.CheckBox()
        Me.conOut = New System.Windows.Forms.ListBox()
        Me.CompResultsPanel = New System.Windows.Forms.Panel()
        Me.dirChosenLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labelFilesCompressed = New System.Windows.Forms.Label()
        Me.compressedSizeVisual = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.progressPageLabel = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.testFileArgs = New System.Windows.Forms.Button()
        Me.ToolTipFilesCompressed = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.InputPage.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ProgressPage.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CompResultsPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.compressedSizeVisual.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OldconOut
        '
        Me.OldconOut.BackColor = System.Drawing.Color.White
        Me.OldconOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OldconOut.ForeColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.OldconOut, "OldconOut")
        Me.OldconOut.Name = "OldconOut"
        Me.OldconOut.ReadOnly = True
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttonCompress
        '
        Me.buttonCompress.BackColor = System.Drawing.Color.Gainsboro
        resources.ApplyResources(Me.buttonCompress, "buttonCompress")
        Me.buttonCompress.ForeColor = System.Drawing.Color.DarkGray
        Me.buttonCompress.Name = "buttonCompress"
        Me.buttonCompress.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'checkRecursiveScan
        '
        resources.ApplyResources(Me.checkRecursiveScan, "checkRecursiveScan")
        Me.checkRecursiveScan.Checked = True
        Me.checkRecursiveScan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkRecursiveScan.ForeColor = System.Drawing.Color.DimGray
        Me.checkRecursiveScan.Name = "checkRecursiveScan"
        Me.checkRecursiveScan.UseVisualStyleBackColor = True
        '
        'checkHiddenFiles
        '
        resources.ApplyResources(Me.checkHiddenFiles, "checkHiddenFiles")
        Me.checkHiddenFiles.ForeColor = System.Drawing.Color.DimGray
        Me.checkHiddenFiles.Name = "checkHiddenFiles"
        Me.checkHiddenFiles.UseVisualStyleBackColor = True
        '
        'checkForceCompression
        '
        resources.ApplyResources(Me.checkForceCompression, "checkForceCompression")
        Me.checkForceCompression.ForeColor = System.Drawing.Color.DimGray
        Me.checkForceCompression.Name = "checkForceCompression"
        Me.checkForceCompression.UseVisualStyleBackColor = True
        '
        'compressX4
        '
        resources.ApplyResources(Me.compressX4, "compressX4")
        Me.compressX4.ForeColor = System.Drawing.Color.DimGray
        Me.compressX4.Name = "compressX4"
        Me.compressX4.UseVisualStyleBackColor = True
        '
        'compressX8
        '
        resources.ApplyResources(Me.compressX8, "compressX8")
        Me.compressX8.Checked = True
        Me.compressX8.ForeColor = System.Drawing.Color.DimGray
        Me.compressX8.Name = "compressX8"
        Me.compressX8.TabStop = True
        Me.compressX8.UseVisualStyleBackColor = True
        '
        'compressX16
        '
        resources.ApplyResources(Me.compressX16, "compressX16")
        Me.compressX16.ForeColor = System.Drawing.Color.DimGray
        Me.compressX16.Name = "compressX16"
        Me.compressX16.UseVisualStyleBackColor = True
        '
        'compressLZX
        '
        resources.ApplyResources(Me.compressLZX, "compressLZX")
        Me.compressLZX.ForeColor = System.Drawing.Color.DimGray
        Me.compressLZX.Name = "compressLZX"
        Me.compressLZX.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.showinfopopup)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Name = "Panel1"
        '
        'showinfopopup
        '
        resources.ApplyResources(Me.showinfopopup, "showinfopopup")
        Me.showinfopopup.ForeColor = System.Drawing.Color.DarkGray
        Me.showinfopopup.Name = "showinfopopup"
        '
        'dirChooser
        '
        Me.dirChooser.ActiveLinkColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.dirChooser, "dirChooser")
        Me.dirChooser.LinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dirChooser.Name = "dirChooser"
        Me.dirChooser.TabStop = True
        Me.dirChooser.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        '
        'chosenDirDisplay
        '
        resources.ApplyResources(Me.chosenDirDisplay, "chosenDirDisplay")
        Me.chosenDirDisplay.AutoEllipsis = True
        Me.chosenDirDisplay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chosenDirDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chosenDirDisplay.Name = "chosenDirDisplay"
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Name = "Label8"
        '
        'preSize
        '
        resources.ApplyResources(Me.preSize, "preSize")
        Me.preSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.preSize.Name = "preSize"
        '
        'progressTimer
        '
        '
        'progresspercent
        '
        Me.progresspercent.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.progresspercent, "progresspercent")
        Me.progresspercent.Name = "progresspercent"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Name = "Label10"
        '
        'compactprogressbar
        '
        Me.compactprogressbar.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.compactprogressbar, "compactprogressbar")
        Me.compactprogressbar.Name = "compactprogressbar"
        Me.compactprogressbar.Step = 2
        Me.compactprogressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Name = "Label9"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'origSizeLabel
        '
        resources.ApplyResources(Me.origSizeLabel, "origSizeLabel")
        Me.origSizeLabel.ForeColor = System.Drawing.Color.White
        Me.origSizeLabel.Name = "origSizeLabel"
        '
        'compressedSizeLabel
        '
        resources.ApplyResources(Me.compressedSizeLabel, "compressedSizeLabel")
        Me.compressedSizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.compressedSizeLabel.Name = "compressedSizeLabel"
        '
        'compRatioLabel
        '
        resources.ApplyResources(Me.compRatioLabel, "compRatioLabel")
        Me.compRatioLabel.Name = "compRatioLabel"
        '
        'spaceSavedLabel
        '
        resources.ApplyResources(Me.spaceSavedLabel, "spaceSavedLabel")
        Me.spaceSavedLabel.ForeColor = System.Drawing.Color.DimGray
        Me.spaceSavedLabel.Name = "spaceSavedLabel"
        '
        'testcompactargs
        '
        resources.ApplyResources(Me.testcompactargs, "testcompactargs")
        Me.testcompactargs.Name = "testcompactargs"
        Me.testcompactargs.UseVisualStyleBackColor = True
        '
        'buttonRevert
        '
        Me.buttonRevert.BackColor = System.Drawing.Color.Gainsboro
        Me.buttonRevert.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.buttonRevert, "buttonRevert")
        Me.buttonRevert.Name = "buttonRevert"
        Me.buttonRevert.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.InputPage)
        Me.TabControl1.Controls.Add(Me.ProgressPage)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'InputPage
        '
        Me.InputPage.BackColor = System.Drawing.Color.White
        Me.InputPage.Controls.Add(Me.buttonQueryCompact)
        Me.InputPage.Controls.Add(Me.FlowLayoutPanel1)
        Me.InputPage.Controls.Add(Me.dirChooser)
        Me.InputPage.Controls.Add(Me.preSize)
        Me.InputPage.Controls.Add(Me.chosenDirDisplay)
        Me.InputPage.Controls.Add(Me.Label7)
        resources.ApplyResources(Me.InputPage, "InputPage")
        Me.InputPage.Name = "InputPage"
        '
        'CheckBox2
        '
        resources.ApplyResources(Me.CheckBox2, "CheckBox2")
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'buttonQueryCompact
        '
        Me.buttonQueryCompact.BackColor = System.Drawing.Color.Gainsboro
        Me.buttonQueryCompact.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        resources.ApplyResources(Me.buttonQueryCompact, "buttonQueryCompact")
        Me.buttonQueryCompact.ForeColor = System.Drawing.Color.DarkGray
        Me.buttonQueryCompact.Name = "buttonQueryCompact"
        Me.buttonQueryCompact.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.buttonCompress)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.compressX4)
        Me.Panel4.Controls.Add(Me.compressLZX)
        Me.Panel4.Controls.Add(Me.compressX8)
        Me.Panel4.Controls.Add(Me.compressX16)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.checkForceCompression)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.checkHiddenFiles)
        Me.Panel3.Controls.Add(Me.checkRecursiveScan)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label14.Name = "Label14"
        Me.ToolTipFilesCompressed.SetToolTip(Me.Label14, resources.GetString("Label14.ToolTip"))
        '
        'ProgressPage
        '
        Me.ProgressPage.BackColor = System.Drawing.Color.White
        Me.ProgressPage.Controls.Add(Me.returnArrow)
        Me.ProgressPage.Controls.Add(Me.TableLayoutPanel2)
        Me.ProgressPage.Controls.Add(Me.progressPageLabel)
        Me.ProgressPage.Controls.Add(Me.compactprogressbar)
        Me.ProgressPage.Controls.Add(Me.progresspercent)
        resources.ApplyResources(Me.ProgressPage, "ProgressPage")
        Me.ProgressPage.Name = "ProgressPage"
        '
        'returnArrow
        '
        resources.ApplyResources(Me.returnArrow, "returnArrow")
        Me.returnArrow.ForeColor = System.Drawing.Color.SteelBlue
        Me.returnArrow.Name = "returnArrow"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.CompResultsPanel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.buttonRevert, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.checkShowConOut)
        Me.Panel2.Controls.Add(Me.conOut)
        Me.Panel2.Name = "Panel2"
        '
        'checkShowConOut
        '
        resources.ApplyResources(Me.checkShowConOut, "checkShowConOut")
        Me.checkShowConOut.ForeColor = System.Drawing.Color.DimGray
        Me.checkShowConOut.Name = "checkShowConOut"
        Me.checkShowConOut.UseVisualStyleBackColor = True
        '
        'conOut
        '
        resources.ApplyResources(Me.conOut, "conOut")
        Me.conOut.BackColor = System.Drawing.Color.White
        Me.conOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.conOut.ForeColor = System.Drawing.Color.DimGray
        Me.conOut.FormattingEnabled = True
        Me.conOut.Name = "conOut"
        '
        'CompResultsPanel
        '
        Me.CompResultsPanel.Controls.Add(Me.dirChosenLabel)
        Me.CompResultsPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.CompResultsPanel.Controls.Add(Me.compressedSizeVisual)
        Me.CompResultsPanel.Controls.Add(Me.Panel5)
        Me.CompResultsPanel.Controls.Add(Me.Label9)
        Me.CompResultsPanel.Controls.Add(Me.Label11)
        Me.CompResultsPanel.Controls.Add(Me.spaceSavedLabel)
        resources.ApplyResources(Me.CompResultsPanel, "CompResultsPanel")
        Me.CompResultsPanel.Name = "CompResultsPanel"
        '
        'dirChosenLabel
        '
        resources.ApplyResources(Me.dirChosenLabel, "dirChosenLabel")
        Me.dirChosenLabel.ForeColor = System.Drawing.Color.DarkGray
        Me.dirChosenLabel.Name = "dirChosenLabel"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.labelFilesCompressed, 0, 0)
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label13.Name = "Label13"
        Me.ToolTipFilesCompressed.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        '
        'labelFilesCompressed
        '
        resources.ApplyResources(Me.labelFilesCompressed, "labelFilesCompressed")
        Me.labelFilesCompressed.ForeColor = System.Drawing.Color.DimGray
        Me.labelFilesCompressed.Name = "labelFilesCompressed"
        '
        'compressedSizeVisual
        '
        Me.compressedSizeVisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.compressedSizeVisual.Controls.Add(Me.compressedSizeLabel)
        resources.ApplyResources(Me.compressedSizeVisual, "compressedSizeVisual")
        Me.compressedSizeVisual.Name = "compressedSizeVisual"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Controls.Add(Me.origSizeLabel)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'progressPageLabel
        '
        resources.ApplyResources(Me.progressPageLabel, "progressPageLabel")
        Me.progressPageLabel.ForeColor = System.Drawing.Color.DimGray
        Me.progressPageLabel.Name = "progressPageLabel"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.testFileArgs)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.OldconOut)
        Me.TabPage3.Controls.Add(Me.testcompactargs)
        Me.TabPage3.Controls.Add(Me.compRatioLabel)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'testFileArgs
        '
        resources.ApplyResources(Me.testFileArgs, "testFileArgs")
        Me.testFileArgs.Name = "testFileArgs"
        Me.testFileArgs.UseVisualStyleBackColor = True
        '
        'ToolTipFilesCompressed
        '
        Me.ToolTipFilesCompressed.AutoPopDelay = 12000
        Me.ToolTipFilesCompressed.BackColor = System.Drawing.Color.White
        Me.ToolTipFilesCompressed.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ToolTipFilesCompressed.InitialDelay = 200
        Me.ToolTipFilesCompressed.IsBalloon = True
        Me.ToolTipFilesCompressed.ReshowDelay = 100
        Me.ToolTipFilesCompressed.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipFilesCompressed.ToolTipTitle = "Information"
        '
        'Compact
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Name = "Compact"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.InputPage.ResumeLayout(False)
        Me.InputPage.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ProgressPage.ResumeLayout(False)
        Me.ProgressPage.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CompResultsPanel.ResumeLayout(False)
        Me.CompResultsPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.compressedSizeVisual.ResumeLayout(False)
        Me.compressedSizeVisual.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OldconOut As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents buttonCompress As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents checkRecursiveScan As CheckBox
    Friend WithEvents checkHiddenFiles As CheckBox
    Friend WithEvents checkForceCompression As CheckBox
    Friend WithEvents compressX4 As RadioButton
    Friend WithEvents compressX8 As RadioButton
    Friend WithEvents compressX16 As RadioButton
    Friend WithEvents compressLZX As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dirChooser As LinkLabel
    Friend WithEvents chosenDirDisplay As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents preSize As Label
    Friend WithEvents progressTimer As Timer
    Friend WithEvents progresspercent As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents compactprogressbar As ProgressBar
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents origSizeLabel As Label
    Friend WithEvents compressedSizeLabel As Label
    Friend WithEvents compRatioLabel As Label
    Friend WithEvents spaceSavedLabel As Label
    Friend WithEvents testcompactargs As Button
    Friend WithEvents buttonRevert As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents InputPage As TabPage
    Friend WithEvents ProgressPage As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents progressPageLabel As Label
    Friend WithEvents returnArrow As Label
    Friend WithEvents CompResultsPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents compressedSizeVisual As Panel
    Friend WithEvents checkShowConOut As CheckBox
    Friend WithEvents showinfopopup As Label
    Friend WithEvents testFileArgs As Button
    Friend WithEvents buttonQueryCompact As Button
    Friend WithEvents labelFilesCompressed As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolTipFilesCompressed As ToolTip
    Friend WithEvents dirChosenLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents conOut As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox2 As CheckBox
End Class
