Imports System.IO.Ports
Imports System.Runtime.InteropServices

Public Class Form1

  Private Const SB_VERT As Integer = &H1
  Private Const WM_VSCROLL As Integer = &H115
  Private Const SB_THUMBPOSITION As Integer = &H4
  <DllImport("user32.dll", CharSet:=CharSet.Auto)>
  Private Shared Function GetScrollPos(ByVal hWnd As IntPtr, ByVal nBar As Integer) As Integer

  End Function
  <DllImport("user32.dll")>
  Private Shared Function SetScrollPos(ByVal hWnd As IntPtr, ByVal nBar As Integer, ByVal nPos As Integer, ByVal bRedraw As Boolean) As Integer
  End Function
  <DllImport("user32.dll")>
  Private Shared Function PostMessageA(ByVal hWnd As IntPtr, ByVal nBar As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Boolean
  End Function
  <DllImport("user32.dll")>
  Private Shared Function GetScrollRange(ByVal hWnd As IntPtr, ByVal nBar As Integer, <Out> ByRef lpMinPos As Integer, <Out> ByRef lpMaxPos As Integer) As Boolean
  End Function
  Private Sub AppendTextToTextBox(ByVal textbox As TextBox, ByVal text As String, ByVal autoscroll As Boolean)
    Dim savedVpos As Integer = GetScrollPos(textbox.Handle, SB_VERT)
    textbox.AppendText(text)

    If autoscroll Then
      Dim VSmin, VSmax As Integer
      GetScrollRange(textbox.Handle, SB_VERT, VSmin, VSmax)
      Dim sbOffset As Integer = CInt(((textbox.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / (textbox.Font.Height)))
      savedVpos = VSmax - sbOffset
    End If

    SetScrollPos(textbox.Handle, SB_VERT, savedVpos, True)
    PostMessageA(textbox.Handle, WM_VSCROLL, SB_THUMBPOSITION + &H10000 * savedVpos, 0)
  End Sub
  Dim initError As String = ""
    Dim USB As New MercoUSBBoard
    Dim spDrLine As String = ""
    Dim spBuffer As String = ""
    Dim WithEvents PortaCOM As IO.Ports.SerialPort = Nothing
  Private Sub ChiudiCom()
    Me.PanelInvio.Enabled = False
    If Not IsNothing(PortaCOM) Then
      If PortaCOM.IsOpen Then
        PortaCOM.Close()

      End If
      PortaCOM.Dispose()
      PortaCOM = Nothing
    End If
  End Sub
  Private Function ApriCom() As String

    ChiudiCom()
    Dim returnStr As String = ""
    Try
      PortaCOM = My.Computer.Ports.OpenSerialPort(Me.ComboBoxComPort.Text, Val(Me.ComBaudRates.Text), Parity.None, 8, 1)


    Catch ex As Exception
      returnStr = "Error: Serial Port " & ex.Message
      ChiudiCom()
    Finally

    End Try
    Return returnStr
  End Function

  Private Sub DisableUI()
    Me.VoltaggioEsterno.Value = 0
    Me.VoltaggioEsterno.DigitalValue = 0
    Me.VoltaggioInterno.Value = 0
    Me.VoltaggioInterno.DigitalValue = 0

    Me.CorrenteInterna.Value = 0
    Me.CorrenteInterna.DigitalValue = 0
  End Sub
  Public Sub DisplayCurrent()
    Me.CorrenteInterna.Value = USB.InternalCurrent
    Me.CorrenteInterna.DigitalValue = USB.InternalCurrent

    If USB.InternalCurrent > 95 Then
      Me.CorrenteInterna.MaxValue = 500
      Exit Sub
    End If
    If USB.InternalCurrent > 45 Then
      Me.CorrenteInterna.MaxValue = 100
    Else
      Me.CorrenteInterna.MaxValue = 50
    End If



  End Sub
  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    If Not USB.isAvailable Then
      initError = USB.StartUSB
      Me.Text = initError
      Me.TabControl1.Enabled = False
      DisableUI()
      ChiudiCom()
    Else
      Me.TabControl1.Enabled = True
      Me.Text = USB.Produttore
      USB.QueryVoltages()
      Me.VoltaggioEsterno.Value = USB.ExternalVoltage
      Me.VoltaggioEsterno.DigitalValue = USB.ExternalVoltage

      Me.VoltaggioInterno.Value = USB.InternalVoltage
      Me.VoltaggioInterno.DigitalValue = USB.InternalVoltage
      DisplayCurrent()

    End If


  End Sub

  Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    USB.StopUSB()
  End Sub

  Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    initError = USB.StartUSB
    Me.Text = initError
    If initError <> "" Then Me.TabControl1.Enabled = False
    Me.ComboBoxComPort.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    Me.ComBaudRates.SelectedIndex = 5

    ComboBoxI2CLenAdd.SelectedIndex = 0
    ComboBoxI2CSpeed.SelectedIndex = 0


  End Sub

  Private Sub ComboBoxComPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxComPort.SelectedIndexChanged

  End Sub

  Private Sub ButtonApriCom_Click(sender As Object, e As EventArgs) Handles ButtonApriCom.Click
    If Me.ComboBoxComPort.SelectedIndex < 0 Then
      MsgBox("Indica una porta", MsgBoxStyle.Critical)
      Exit Sub
    End If

    Dim mm As String = ApriCom()

    If mm = "" Then
      ButtonApriCom.Enabled = False
      ButtonChiudiCom.Enabled = True
      Me.ComboBoxComPort.Enabled = False
      Me.PanelInvio.Enabled = True
    Else
      MsgBox(mm, MsgBoxStyle.Critical)
    End If
  End Sub

  Private Sub ButtonChiudiCom_Click(sender As Object, e As EventArgs) Handles ButtonChiudiCom.Click
    ChiudiCom()
    ButtonApriCom.Enabled = True
    ButtonChiudiCom.Enabled = False
    Me.ComboBoxComPort.Enabled = True
  End Sub



  Private Sub PortaCOM_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles PortaCOM.DataReceived
    Try
      If PortaCOM.IsOpen Then
        spDrLine = spDrLine & PortaCOM.ReadExisting() 'imp
        Me.Invoke(New EventHandler(AddressOf doProcess)) 'imp

        'If InStr(1, spDrLine, vbCr) > 0 _
        'Or InStr(1, spDrLine, vbLf) > 0 Then
        '  spBuffer = spDrLine
        '  spDrLine = ""
        '  Me.Invoke(New EventHandler(AddressOf doProcess)) 'imp
        'Else
        '  Exit Sub
        'End If
      End If
    Catch ex As Exception
      'handle the way you want
    End Try
  End Sub
  Function StringToHex(ByVal text As String) As String
    Dim hex As String = ""
    For i As Integer = 0 To text.Length - 1
      Dim c As String = Asc(text.Substring(i, 1)).ToString("x").ToUpper
      If c.Length = 1 Then c = "0" & c
      hex &= c & " "
    Next
    Return hex
  End Function


  Private Sub TBAppend(tb As TextBox, value As String)

    If Not chkAutoScroll.Checked Then
      Dim caretPos = tb.Text.Length
      tb.AppendText(value)
      tb.Select(caretPos, 0)
      tb.SelectionStart = caretPos
      tb.ScrollToCaret()

    Else
      tb.AppendText(value)
    End If

  End Sub
  Private Sub doProcess()
    'Console.WriteLine(spBuffer)
    Dim TS As String = Format(Now, "hh:mm:ss.fff")
    Dim HHstring As String = StringToHex(spDrLine)
    If chkTS.Checked Then spDrLine = TS & " => " & spDrLine & vbCrLf
    AppendTextToTextBox(TextBoxDaCom, spDrLine, chkAutoScroll.Checked)

    AppendTextToTextBox(TextBoxDaComHEX, HHstring, chkAutoScroll.Checked)

    spDrLine = ""






  End Sub

  Private Sub BtnInvia_Click(sender As Object, e As EventArgs) Handles BtnInvia.Click
    If TextBoxInvio.Text = "" Then Exit Sub
    If ChkBoxHexMode.Checked Then
      Dim Values() As String = Split(TextBoxInvio.Text, " ")
      For Each Valore As String In Values
        If Valore <> "" Then

          Dim Numero As Integer = 0

          Try
            Convert.ToByte(Valore, 16)
          Catch ex As Exception
            Numero = 0
            MsgBox("Cifre non riconoscibili in stringa esadecimale => " + Valore, MsgBoxStyle.Critical)
          End Try

          Dim ab(0) As Byte
          ab(0) = Numero
          PortaCOM.Write(ab, 0, 1)
        End If
      Next


    Else
      If chkcrlf.Checked Then
        PortaCOM.WriteLine(Me.TextBoxInvio.Text)
      Else
        PortaCOM.Write(Me.TextBoxInvio.Text)
      End If

    End If

  End Sub

  Private Sub ChkBoxHexMode_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxHexMode.CheckedChanged
    Me.chkcrlf.Enabled = Not ChkBoxHexMode.Checked
  End Sub

  Private Sub ButtonSvuotaUsart_Click(sender As Object, e As EventArgs) Handles ButtonSvuotaUsart.Click
    Me.TextBoxDaCom.Clear()
    Me.TextBoxDaComHEX.Clear()

  End Sub

  Private Sub ButtonI2CScan_Click(sender As Object, e As EventArgs) Handles ButtonI2CScan.Click

    Dim bb7 As Boolean = False

    bb7 = ComboBoxI2CLenAdd.Text = "7BIT"

    Dim fromAddress As String = InputBox("Indirizzo iniziale (decimale)", "I2C Scan", "0")
    Dim toAddress As String = InputBox("Indirizzo finale (decimale)", "I2C Scan", IIf(bb7, "127", "255"))

    Dim fromI As Integer = Val(fromAddress)
    Dim ToI As Integer = Val(toAddress)

    If Not (fromI >= 0 AndAlso ToI > 0 AndAlso ToI >= fromI) Then
      MsgBox("Indirizzi errati", MsgBoxStyle.Exclamation)
      Exit Sub
    End If


    Me.Enabled = False
    Dim UintSpd As UInteger = Replace(ComboBoxI2CSpeed.Text, "K", "000")


    Dim ee As String = USB.ScanI2C(fromI, ToI, UintSpd, bb7, ProgressBarI2cScan)
    Me.Enabled = True

    If ee <> "" Then
      MsgBox(ee.ToString, MsgBoxStyle.Information, "Indirizzi I2C Trovati (decimale)")
    Else
      MsgBox("Nessun dispositivo trovato !", MsgBoxStyle.Exclamation)
    End If

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim UintSpd As UInteger = Replace(ComboBoxI2CSpeed.Text, "K", "000")
    Dim bb7 As Boolean = ComboBoxI2CLenAdd.Text = "7BIT"
    Dim comando As String = Me.TextBoxI2CCommand.Text.ToUpper.Trim
    If TextBoxI2CAddr.Text.Trim = "" Then
      MsgBox("Indica un indirizzo", MsgBoxStyle.Critical)
      Exit Sub
    End If
    If comando.Contains("TXT") And Me.txtI2CFile.Text = "" Then
      MsgBox("Indica un file I2C", MsgBoxStyle.Critical)
      Exit Sub
    End If

    Timer1.Enabled = False
    Dim ee As String = USB.CommandI2C(Val(TextBoxI2CAddr.Text), UintSpd, bb7, comando, Me.txtI2CFile.Text)
    Timer1.Enabled = True
    TextBoxI2Result.AppendText(ee)
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    TextBoxI2Result.Clear()
  End Sub

  Private Sub btnI2CFile_Click(sender As Object, e As EventArgs) Handles btnI2CFile.Click
    Dim fs As New SaveFileDialog
    fs.Filter = "File TXT|*.txt"
    If fs.ShowDialog = DialogResult.OK Then
      txtI2CFile.Text = fs.FileName
    End If
    fs.Dispose()

  End Sub
End Class
