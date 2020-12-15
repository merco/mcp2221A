<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

  'Richiesto da Progettazione Windows Form
  Private components As System.ComponentModel.IContainer

  'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
  'Può essere modificata in Progettazione Windows Form.  
  'Non modificarla mediante l'editor del codice.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.VoltaggioEsterno = New AquaControls.AquaGauge()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.chkAutoScroll = New System.Windows.Forms.CheckBox()
    Me.TextBoxDaComHEX = New System.Windows.Forms.TextBox()
    Me.chkTS = New System.Windows.Forms.CheckBox()
    Me.TextBoxDaCom = New System.Windows.Forms.TextBox()
    Me.ComBaudRates = New System.Windows.Forms.ComboBox()
    Me.ButtonChiudiCom = New System.Windows.Forms.Button()
    Me.ButtonApriCom = New System.Windows.Forms.Button()
    Me.ComboBoxComPort = New System.Windows.Forms.ComboBox()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.VoltaggioInterno = New AquaControls.AquaGauge()
    Me.CorrenteInterna = New AquaControls.AquaGauge()
    Me.PanelInvio = New System.Windows.Forms.Panel()
    Me.TextBoxInvio = New System.Windows.Forms.TextBox()
    Me.BtnInvia = New System.Windows.Forms.Button()
    Me.ChkBoxHexMode = New System.Windows.Forms.CheckBox()
    Me.chkcrlf = New System.Windows.Forms.CheckBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ButtonSvuotaUsart = New System.Windows.Forms.Button()
    Me.ComboBoxI2CSpeed = New System.Windows.Forms.ComboBox()
    Me.ComboBoxI2CLenAdd = New System.Windows.Forms.ComboBox()
    Me.ButtonI2CScan = New System.Windows.Forms.Button()
    Me.ProgressBarI2cScan = New System.Windows.Forms.ProgressBar()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextBoxI2CAddr = New System.Windows.Forms.TextBox()
    Me.TextBoxI2CCommand = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.TextBoxI2Result = New System.Windows.Forms.TextBox()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtI2CFile = New System.Windows.Forms.TextBox()
    Me.btnI2CFile = New System.Windows.Forms.Button()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.PanelInvio.SuspendLayout()
    Me.SuspendLayout()
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 150
    '
    'VoltaggioEsterno
    '
    Me.VoltaggioEsterno.BackColor = System.Drawing.Color.Transparent
    Me.VoltaggioEsterno.DecimalPlaces = 0
    Me.VoltaggioEsterno.DialAlpha = 255
    Me.VoltaggioEsterno.DialBorderColor = System.Drawing.Color.SlateGray
    Me.VoltaggioEsterno.DialColor = System.Drawing.Color.AliceBlue
    Me.VoltaggioEsterno.DialText = "Step Up  (V)"
    Me.VoltaggioEsterno.DialTextColor = System.Drawing.Color.Black
    Me.VoltaggioEsterno.DialTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.VoltaggioEsterno.DialTextVOffset = 0
    Me.VoltaggioEsterno.DigitalValue = 0!
    Me.VoltaggioEsterno.DigitalValueBackAlpha = 0
    Me.VoltaggioEsterno.DigitalValueBackColor = System.Drawing.Color.DimGray
    Me.VoltaggioEsterno.DigitalValueColor = System.Drawing.Color.Red
    Me.VoltaggioEsterno.DigitalValueDecimalPlaces = 2
    Me.VoltaggioEsterno.Enabled = False
    Me.VoltaggioEsterno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.VoltaggioEsterno.Glossiness = 40.0!
    Me.VoltaggioEsterno.Location = New System.Drawing.Point(12, 23)
    Me.VoltaggioEsterno.MaxValue = 15.0!
    Me.VoltaggioEsterno.MinValue = 0!
    Me.VoltaggioEsterno.Name = "VoltaggioEsterno"
    Me.VoltaggioEsterno.NoOfDivisions = 15
    Me.VoltaggioEsterno.NoOfSubDivisions = 1
    Me.VoltaggioEsterno.PointerColor = System.Drawing.Color.Black
    Me.VoltaggioEsterno.RimAlpha = 255
    Me.VoltaggioEsterno.RimColor = System.Drawing.Color.LawnGreen
    Me.VoltaggioEsterno.ScaleColor = System.Drawing.Color.Gray
    Me.VoltaggioEsterno.ScaleFontSizeDivider = 18
    Me.VoltaggioEsterno.Size = New System.Drawing.Size(181, 181)
    Me.VoltaggioEsterno.TabIndex = 2
    Me.VoltaggioEsterno.Threshold1Color = System.Drawing.Color.White
    Me.VoltaggioEsterno.Threshold1Start = 0!
    Me.VoltaggioEsterno.Threshold1Stop = 5.0!
    Me.VoltaggioEsterno.Threshold2Color = System.Drawing.Color.Red
    Me.VoltaggioEsterno.Threshold2Start = 12.0!
    Me.VoltaggioEsterno.Threshold2Stop = 15.0!
    Me.VoltaggioEsterno.Value = 5.0!
    Me.VoltaggioEsterno.ValueToDigital = False
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Location = New System.Drawing.Point(199, 12)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(773, 637)
    Me.TabControl1.TabIndex = 3
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.ButtonSvuotaUsart)
    Me.TabPage1.Controls.Add(Me.Label1)
    Me.TabPage1.Controls.Add(Me.PanelInvio)
    Me.TabPage1.Controls.Add(Me.chkAutoScroll)
    Me.TabPage1.Controls.Add(Me.TextBoxDaComHEX)
    Me.TabPage1.Controls.Add(Me.chkTS)
    Me.TabPage1.Controls.Add(Me.TextBoxDaCom)
    Me.TabPage1.Controls.Add(Me.ComBaudRates)
    Me.TabPage1.Controls.Add(Me.ButtonChiudiCom)
    Me.TabPage1.Controls.Add(Me.ButtonApriCom)
    Me.TabPage1.Controls.Add(Me.ComboBoxComPort)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(765, 611)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "USART"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'chkAutoScroll
    '
    Me.chkAutoScroll.AutoSize = True
    Me.chkAutoScroll.Checked = True
    Me.chkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAutoScroll.Location = New System.Drawing.Point(304, 588)
    Me.chkAutoScroll.Name = "chkAutoScroll"
    Me.chkAutoScroll.Size = New System.Drawing.Size(137, 17)
    Me.chkAutoScroll.TabIndex = 7
    Me.chkAutoScroll.Text = "Scorrimento automatico"
    Me.chkAutoScroll.UseVisualStyleBackColor = True
    '
    'TextBoxDaComHEX
    '
    Me.TextBoxDaComHEX.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxDaComHEX.Location = New System.Drawing.Point(396, 79)
    Me.TextBoxDaComHEX.Multiline = True
    Me.TextBoxDaComHEX.Name = "TextBoxDaComHEX"
    Me.TextBoxDaComHEX.ReadOnly = True
    Me.TextBoxDaComHEX.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxDaComHEX.Size = New System.Drawing.Size(363, 503)
    Me.TextBoxDaComHEX.TabIndex = 6
    '
    'chkTS
    '
    Me.chkTS.AutoSize = True
    Me.chkTS.Location = New System.Drawing.Point(7, 588)
    Me.chkTS.Name = "chkTS"
    Me.chkTS.Size = New System.Drawing.Size(96, 17)
    Me.chkTS.TabIndex = 5
    Me.chkTS.Text = "Aggiungi orario"
    Me.chkTS.UseVisualStyleBackColor = True
    '
    'TextBoxDaCom
    '
    Me.TextBoxDaCom.Location = New System.Drawing.Point(7, 79)
    Me.TextBoxDaCom.Multiline = True
    Me.TextBoxDaCom.Name = "TextBoxDaCom"
    Me.TextBoxDaCom.ReadOnly = True
    Me.TextBoxDaCom.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxDaCom.Size = New System.Drawing.Size(383, 503)
    Me.TextBoxDaCom.TabIndex = 4
    '
    'ComBaudRates
    '
    Me.ComBaudRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComBaudRates.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComBaudRates.FormattingEnabled = True
    Me.ComBaudRates.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"})
    Me.ComBaudRates.Location = New System.Drawing.Point(141, 6)
    Me.ComBaudRates.Name = "ComBaudRates"
    Me.ComBaudRates.Size = New System.Drawing.Size(97, 23)
    Me.ComBaudRates.TabIndex = 3
    '
    'ButtonChiudiCom
    '
    Me.ButtonChiudiCom.Enabled = False
    Me.ButtonChiudiCom.Location = New System.Drawing.Point(396, 6)
    Me.ButtonChiudiCom.Name = "ButtonChiudiCom"
    Me.ButtonChiudiCom.Size = New System.Drawing.Size(64, 23)
    Me.ButtonChiudiCom.TabIndex = 2
    Me.ButtonChiudiCom.Text = "CHIUDI"
    Me.ButtonChiudiCom.UseVisualStyleBackColor = True
    '
    'ButtonApriCom
    '
    Me.ButtonApriCom.Location = New System.Drawing.Point(326, 5)
    Me.ButtonApriCom.Name = "ButtonApriCom"
    Me.ButtonApriCom.Size = New System.Drawing.Size(64, 24)
    Me.ButtonApriCom.TabIndex = 1
    Me.ButtonApriCom.Text = "APRI"
    Me.ButtonApriCom.UseVisualStyleBackColor = True
    '
    'ComboBoxComPort
    '
    Me.ComboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxComPort.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxComPort.FormattingEnabled = True
    Me.ComboBoxComPort.Location = New System.Drawing.Point(6, 6)
    Me.ComboBoxComPort.Name = "ComboBoxComPort"
    Me.ComboBoxComPort.Size = New System.Drawing.Size(129, 23)
    Me.ComboBoxComPort.TabIndex = 0
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.btnI2CFile)
    Me.TabPage2.Controls.Add(Me.txtI2CFile)
    Me.TabPage2.Controls.Add(Me.Label3)
    Me.TabPage2.Controls.Add(Me.Button2)
    Me.TabPage2.Controls.Add(Me.TextBoxI2Result)
    Me.TabPage2.Controls.Add(Me.Button1)
    Me.TabPage2.Controls.Add(Me.TextBoxI2CCommand)
    Me.TabPage2.Controls.Add(Me.TextBoxI2CAddr)
    Me.TabPage2.Controls.Add(Me.Label2)
    Me.TabPage2.Controls.Add(Me.ProgressBarI2cScan)
    Me.TabPage2.Controls.Add(Me.ButtonI2CScan)
    Me.TabPage2.Controls.Add(Me.ComboBoxI2CLenAdd)
    Me.TabPage2.Controls.Add(Me.ComboBoxI2CSpeed)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(765, 611)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "I 2 C"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'VoltaggioInterno
    '
    Me.VoltaggioInterno.BackColor = System.Drawing.Color.Transparent
    Me.VoltaggioInterno.DecimalPlaces = 0
    Me.VoltaggioInterno.DialAlpha = 255
    Me.VoltaggioInterno.DialBorderColor = System.Drawing.Color.SlateGray
    Me.VoltaggioInterno.DialColor = System.Drawing.Color.AliceBlue
    Me.VoltaggioInterno.DialText = "Main Voltage (V)"
    Me.VoltaggioInterno.DialTextColor = System.Drawing.Color.Black
    Me.VoltaggioInterno.DialTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.VoltaggioInterno.DialTextVOffset = 0
    Me.VoltaggioInterno.DigitalValue = 0!
    Me.VoltaggioInterno.DigitalValueBackAlpha = 0
    Me.VoltaggioInterno.DigitalValueBackColor = System.Drawing.Color.DimGray
    Me.VoltaggioInterno.DigitalValueColor = System.Drawing.Color.Red
    Me.VoltaggioInterno.DigitalValueDecimalPlaces = 2
    Me.VoltaggioInterno.Enabled = False
    Me.VoltaggioInterno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.VoltaggioInterno.Glossiness = 40.0!
    Me.VoltaggioInterno.Location = New System.Drawing.Point(16, 210)
    Me.VoltaggioInterno.MaxValue = 6.0!
    Me.VoltaggioInterno.MinValue = 0!
    Me.VoltaggioInterno.Name = "VoltaggioInterno"
    Me.VoltaggioInterno.NoOfDivisions = 6
    Me.VoltaggioInterno.NoOfSubDivisions = 1
    Me.VoltaggioInterno.PointerColor = System.Drawing.Color.Black
    Me.VoltaggioInterno.RimAlpha = 255
    Me.VoltaggioInterno.RimColor = System.Drawing.Color.Yellow
    Me.VoltaggioInterno.ScaleColor = System.Drawing.Color.Gray
    Me.VoltaggioInterno.ScaleFontSizeDivider = 18
    Me.VoltaggioInterno.Size = New System.Drawing.Size(181, 181)
    Me.VoltaggioInterno.TabIndex = 4
    Me.VoltaggioInterno.Threshold1Color = System.Drawing.Color.White
    Me.VoltaggioInterno.Threshold1Start = 0!
    Me.VoltaggioInterno.Threshold1Stop = 3.0!
    Me.VoltaggioInterno.Threshold2Color = System.Drawing.Color.Red
    Me.VoltaggioInterno.Threshold2Start = 5.0!
    Me.VoltaggioInterno.Threshold2Stop = 6.0!
    Me.VoltaggioInterno.Value = 5.0!
    Me.VoltaggioInterno.ValueToDigital = False
    '
    'CorrenteInterna
    '
    Me.CorrenteInterna.BackColor = System.Drawing.Color.Transparent
    Me.CorrenteInterna.DecimalPlaces = 0
    Me.CorrenteInterna.DialAlpha = 255
    Me.CorrenteInterna.DialBorderColor = System.Drawing.Color.SlateGray
    Me.CorrenteInterna.DialColor = System.Drawing.Color.AliceBlue
    Me.CorrenteInterna.DialText = "Main Current (mA)"
    Me.CorrenteInterna.DialTextColor = System.Drawing.Color.Black
    Me.CorrenteInterna.DialTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CorrenteInterna.DialTextVOffset = 0
    Me.CorrenteInterna.DigitalValue = 0!
    Me.CorrenteInterna.DigitalValueBackAlpha = 0
    Me.CorrenteInterna.DigitalValueBackColor = System.Drawing.Color.DimGray
    Me.CorrenteInterna.DigitalValueColor = System.Drawing.Color.Red
    Me.CorrenteInterna.DigitalValueDecimalPlaces = 2
    Me.CorrenteInterna.Enabled = False
    Me.CorrenteInterna.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CorrenteInterna.Glossiness = 40.0!
    Me.CorrenteInterna.Location = New System.Drawing.Point(16, 397)
    Me.CorrenteInterna.MaxValue = 500.0!
    Me.CorrenteInterna.MinValue = 0!
    Me.CorrenteInterna.Name = "CorrenteInterna"
    Me.CorrenteInterna.NoOfSubDivisions = 1
    Me.CorrenteInterna.PointerColor = System.Drawing.Color.Black
    Me.CorrenteInterna.RimAlpha = 255
    Me.CorrenteInterna.RimColor = System.Drawing.Color.LawnGreen
    Me.CorrenteInterna.ScaleColor = System.Drawing.Color.Gray
    Me.CorrenteInterna.ScaleFontSizeDivider = 18
    Me.CorrenteInterna.Size = New System.Drawing.Size(181, 181)
    Me.CorrenteInterna.TabIndex = 5
    Me.CorrenteInterna.Threshold1Color = System.Drawing.Color.Yellow
    Me.CorrenteInterna.Threshold1Start = 400.0!
    Me.CorrenteInterna.Threshold1Stop = 450.0!
    Me.CorrenteInterna.Threshold2Color = System.Drawing.Color.Red
    Me.CorrenteInterna.Threshold2Start = 451.0!
    Me.CorrenteInterna.Threshold2Stop = 500.0!
    Me.CorrenteInterna.Value = 0!
    Me.CorrenteInterna.ValueToDigital = False
    '
    'PanelInvio
    '
    Me.PanelInvio.Controls.Add(Me.chkcrlf)
    Me.PanelInvio.Controls.Add(Me.ChkBoxHexMode)
    Me.PanelInvio.Controls.Add(Me.BtnInvia)
    Me.PanelInvio.Controls.Add(Me.TextBoxInvio)
    Me.PanelInvio.Enabled = False
    Me.PanelInvio.Location = New System.Drawing.Point(7, 36)
    Me.PanelInvio.Name = "PanelInvio"
    Me.PanelInvio.Size = New System.Drawing.Size(752, 37)
    Me.PanelInvio.TabIndex = 8
    '
    'TextBoxInvio
    '
    Me.TextBoxInvio.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxInvio.Location = New System.Drawing.Point(3, 3)
    Me.TextBoxInvio.Name = "TextBoxInvio"
    Me.TextBoxInvio.Size = New System.Drawing.Size(452, 22)
    Me.TextBoxInvio.TabIndex = 0
    '
    'BtnInvia
    '
    Me.BtnInvia.Location = New System.Drawing.Point(685, 3)
    Me.BtnInvia.Name = "BtnInvia"
    Me.BtnInvia.Size = New System.Drawing.Size(64, 23)
    Me.BtnInvia.TabIndex = 3
    Me.BtnInvia.Text = "Invia"
    Me.BtnInvia.UseVisualStyleBackColor = True
    '
    'ChkBoxHexMode
    '
    Me.ChkBoxHexMode.AutoSize = True
    Me.ChkBoxHexMode.Location = New System.Drawing.Point(556, 6)
    Me.ChkBoxHexMode.Name = "ChkBoxHexMode"
    Me.ChkBoxHexMode.Size = New System.Drawing.Size(75, 17)
    Me.ChkBoxHexMode.TabIndex = 4
    Me.ChkBoxHexMode.Text = "Hex Mode"
    Me.ChkBoxHexMode.UseVisualStyleBackColor = True
    '
    'chkcrlf
    '
    Me.chkcrlf.AutoSize = True
    Me.chkcrlf.Location = New System.Drawing.Point(461, 6)
    Me.chkcrlf.Name = "chkcrlf"
    Me.chkcrlf.Size = New System.Drawing.Size(62, 17)
    Me.chkcrlf.TabIndex = 5
    Me.chkcrlf.Text = "+ CRLF"
    Me.chkcrlf.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(244, 11)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(33, 13)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "8,N,1"
    '
    'ButtonSvuotaUsart
    '
    Me.ButtonSvuotaUsart.Location = New System.Drawing.Point(684, 584)
    Me.ButtonSvuotaUsart.Name = "ButtonSvuotaUsart"
    Me.ButtonSvuotaUsart.Size = New System.Drawing.Size(75, 23)
    Me.ButtonSvuotaUsart.TabIndex = 10
    Me.ButtonSvuotaUsart.Text = "Svuota"
    Me.ButtonSvuotaUsart.UseVisualStyleBackColor = True
    '
    'ComboBoxI2CSpeed
    '
    Me.ComboBoxI2CSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxI2CSpeed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxI2CSpeed.FormattingEnabled = True
    Me.ComboBoxI2CSpeed.Items.AddRange(New Object() {"100K", "400K"})
    Me.ComboBoxI2CSpeed.Location = New System.Drawing.Point(6, 3)
    Me.ComboBoxI2CSpeed.Name = "ComboBoxI2CSpeed"
    Me.ComboBoxI2CSpeed.Size = New System.Drawing.Size(129, 23)
    Me.ComboBoxI2CSpeed.TabIndex = 1
    '
    'ComboBoxI2CLenAdd
    '
    Me.ComboBoxI2CLenAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxI2CLenAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBoxI2CLenAdd.FormattingEnabled = True
    Me.ComboBoxI2CLenAdd.Items.AddRange(New Object() {"7BIT", "8BIT"})
    Me.ComboBoxI2CLenAdd.Location = New System.Drawing.Point(141, 3)
    Me.ComboBoxI2CLenAdd.Name = "ComboBoxI2CLenAdd"
    Me.ComboBoxI2CLenAdd.Size = New System.Drawing.Size(129, 23)
    Me.ComboBoxI2CLenAdd.TabIndex = 3
    '
    'ButtonI2CScan
    '
    Me.ButtonI2CScan.Location = New System.Drawing.Point(684, 6)
    Me.ButtonI2CScan.Name = "ButtonI2CScan"
    Me.ButtonI2CScan.Size = New System.Drawing.Size(75, 23)
    Me.ButtonI2CScan.TabIndex = 4
    Me.ButtonI2CScan.Text = "Cerca..."
    Me.ButtonI2CScan.UseVisualStyleBackColor = True
    '
    'ProgressBarI2cScan
    '
    Me.ProgressBarI2cScan.Location = New System.Drawing.Point(488, 6)
    Me.ProgressBarI2cScan.Name = "ProgressBarI2cScan"
    Me.ProgressBarI2cScan.Size = New System.Drawing.Size(190, 23)
    Me.ProgressBarI2cScan.TabIndex = 5
    Me.ProgressBarI2cScan.Visible = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(16, 45)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(96, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Indirizzo (decimale)"
    '
    'TextBoxI2CAddr
    '
    Me.TextBoxI2CAddr.Location = New System.Drawing.Point(118, 42)
    Me.TextBoxI2CAddr.Name = "TextBoxI2CAddr"
    Me.TextBoxI2CAddr.Size = New System.Drawing.Size(69, 20)
    Me.TextBoxI2CAddr.TabIndex = 7
    '
    'TextBoxI2CCommand
    '
    Me.TextBoxI2CCommand.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxI2CCommand.Location = New System.Drawing.Point(19, 82)
    Me.TextBoxI2CCommand.Multiline = True
    Me.TextBoxI2CCommand.Name = "TextBoxI2CCommand"
    Me.TextBoxI2CCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxI2CCommand.Size = New System.Drawing.Size(363, 435)
    Me.TextBoxI2CCommand.TabIndex = 8
    Me.TextBoxI2CCommand.Text = resources.GetString("TextBoxI2CCommand.Text")
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(19, 559)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 9
    Me.Button1.Text = "Invia"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'TextBoxI2Result
    '
    Me.TextBoxI2Result.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxI2Result.Location = New System.Drawing.Point(388, 82)
    Me.TextBoxI2Result.Multiline = True
    Me.TextBoxI2Result.Name = "TextBoxI2Result"
    Me.TextBoxI2Result.ReadOnly = True
    Me.TextBoxI2Result.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxI2Result.Size = New System.Drawing.Size(363, 435)
    Me.TextBoxI2Result.TabIndex = 10
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(676, 559)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 11
    Me.Button2.Text = "Svuota"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(20, 529)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(23, 13)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "File"
    '
    'txtI2CFile
    '
    Me.txtI2CFile.Location = New System.Drawing.Point(49, 524)
    Me.txtI2CFile.Name = "txtI2CFile"
    Me.txtI2CFile.Size = New System.Drawing.Size(653, 20)
    Me.txtI2CFile.TabIndex = 13
    '
    'btnI2CFile
    '
    Me.btnI2CFile.Location = New System.Drawing.Point(708, 524)
    Me.btnI2CFile.Name = "btnI2CFile"
    Me.btnI2CFile.Size = New System.Drawing.Size(42, 23)
    Me.btnI2CFile.TabIndex = 14
    Me.btnI2CFile.Text = "..."
    Me.btnI2CFile.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(984, 661)
    Me.Controls.Add(Me.CorrenteInterna)
    Me.Controls.Add(Me.VoltaggioInterno)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.VoltaggioEsterno)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Merco tool"
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.PanelInvio.ResumeLayout(False)
    Me.PanelInvio.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Timer1 As Timer
  Friend WithEvents VoltaggioEsterno As AquaControls.AquaGauge
  Friend WithEvents TabControl1 As TabControl
  Friend WithEvents TabPage1 As TabPage
  Friend WithEvents ComboBoxComPort As ComboBox
  Friend WithEvents TabPage2 As TabPage
  Friend WithEvents ButtonChiudiCom As Button
  Friend WithEvents ButtonApriCom As Button
    Friend WithEvents VoltaggioInterno As AquaControls.AquaGauge
    Friend WithEvents CorrenteInterna As AquaControls.AquaGauge
    Friend WithEvents ComBaudRates As ComboBox
    Friend WithEvents TextBoxDaCom As TextBox
    Friend WithEvents chkTS As CheckBox
    Friend WithEvents TextBoxDaComHEX As TextBox
    Friend WithEvents chkAutoScroll As CheckBox
    Friend WithEvents PanelInvio As Panel
    Friend WithEvents BtnInvia As Button
    Friend WithEvents TextBoxInvio As TextBox
    Friend WithEvents ChkBoxHexMode As CheckBox
    Friend WithEvents chkcrlf As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSvuotaUsart As Button
  Friend WithEvents ComboBoxI2CLenAdd As ComboBox
  Friend WithEvents ComboBoxI2CSpeed As ComboBox
  Friend WithEvents ButtonI2CScan As Button
  Friend WithEvents ProgressBarI2cScan As ProgressBar
  Friend WithEvents TextBoxI2CCommand As TextBox
  Friend WithEvents TextBoxI2CAddr As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Button1 As Button
  Friend WithEvents TextBoxI2Result As TextBox
  Friend WithEvents Button2 As Button
  Friend WithEvents btnI2CFile As Button
  Friend WithEvents txtI2CFile As TextBox
  Friend WithEvents Label3 As Label
End Class
