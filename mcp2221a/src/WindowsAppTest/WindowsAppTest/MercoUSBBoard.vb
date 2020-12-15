Public Class MercoUSBBoard
  Dim VID As UInteger = &H2710
  Dim PID As UInteger = &H76DD
  Public adck As Single = ((2048 / 1023) * (7.46 / 0.97)) / 1000
  Public adck5_3 As Single = ((2048 / 1023) * (3.25 / 0.99)) / 1000
  Public adcCurrent As Single = (((2048 / 1023)) * 1.2) * (26.33 / 157)
  Dim H As IntPtr = IntPtr.Zero
  Dim nDev As UInteger = 0
  Dim rv As Integer = 0
  Dim AdcUSB(3) As UInteger
  Public ExternalVoltage As Decimal = 0
  Public InternalVoltage As Decimal = 0
  Public InternalCurrent As Decimal = 0
  Public SerialNumber As String = ""
  Public Produttore As String = ""
  Public Costruttore As String = ""
  Public Sub New()

  End Sub
  Public Sub StopUSB()
    If H.ToInt32 = -1 Then Exit Sub
    mcp2221_dll_m.MCP2221.M_Mcp2221_Close(H)


  End Sub
  Public Function isAvailable() As Boolean
    Dim pro = mcp2221_dll_m.MCP2221.M_Mcp2221_GetProductDescriptor(H)
    Return pro = Produttore And (Produttore <> "")
  End Function
  Public Sub QueryVoltages()
    If H.ToInt32 = -1 Then Exit Sub
    AdcUSB(0) = 0 : AdcUSB(1) = 0 : AdcUSB(2) = 0



    mcp2221_dll_m.MCP2221.M_Mcp2221_GetAdcData(H, AdcUSB)

    ExternalVoltage = Math.Round(Val(AdcUSB(2)) * adck, 3)
    InternalVoltage = Math.Round(Val(AdcUSB(1)) * adck5_3, 3)
    InternalCurrent = Math.Round(Val(AdcUSB(0)) * adcCurrent, 3)
  End Sub

  Public Function StartUSB() As String

    rv = mcp2221_dll_m.MCP2221.M_Mcp2221_GetConnectedDevices(VID, PID, nDev)

    If nDev <= 0 Then
      Return "Dispositivo non trovato"
    End If
    H = mcp2221_dll_m.MCP2221.M_Mcp2221_OpenByIndex(VID, PID, 0)

    If H.ToInt32 = -1 Then
      Return "Porta USB occupata!"
    End If

    mcp2221_dll_m.MCP2221.M_Mcp2221_SetAdvancedCommParams(H, 0, 100)

    rv = mcp2221_dll_m.MCP2221.M_Mcp2221_SetAdcVref(H, 0, 2)
    rv = mcp2221_dll_m.MCP2221.M_Mcp2221_SetAdcVref(H, 1, 2)
    Costruttore = mcp2221_dll_m.MCP2221.M_Mcp2221_GetManufacturerDescriptor(H)
    Produttore = mcp2221_dll_m.MCP2221.M_Mcp2221_GetProductDescriptor(H)
    SerialNumber = mcp2221_dll_m.MCP2221.M_Mcp2221_GetSerialNumberDescriptor(H)


    Return ""
  End Function

  Public Function CommandI2C(addr As Integer, spd As UInteger, bit7 As Boolean, cmdList As String, filePath As String) As String
    Dim sbFileDest As New System.Text.StringBuilder
    Dim Sb As New System.Text.StringBuilder
    Dim arr(0) As Byte
    mcp2221_dll_m.MCP2221.M_Mcp2221_I2cCancelCurrentTransfer(H)
    mcp2221_dll_m.MCP2221.M_Mcp2221_SetSpeed(H, spd)
    cmdList = cmdList.ToUpper
    Dim b7 As Integer = 0
    If bit7 Then b7 = 1
    Dim righe() As String = Split(cmdList, vbCrLf)
    Dim cr As Int16 = 0
    For Each riga As String In righe
      cr = cr + 1
      riga = riga.Trim

      Dim rv As Integer = 0
      Dim cmd As String = ""
      Dim payload As String = ""
      Dim sbuffer() As String
      Dim buffer() As Byte
      If riga.StartsWith(";") Or riga.StartsWith("//") Then
        GoTo nextr
      End If
      If riga.StartsWith("LEGGI") Then
        cmd = "R"
        payload = Replace(riga, "LEGGI ", "").Trim
      End If
      If riga.StartsWith("LEGGI") Then
        cmd = "R"
        payload = Replace(riga, "LEGGI ", "").Trim
      End If
      If riga.StartsWith("SCRIVI") Then
        cmd = "W"
        payload = Replace(riga, "SCRIVI ", "").Trim
      End If
      If riga.StartsWith("LEGGI2TXT") Then
        cmd = "RF"
        payload = Replace(riga, "LEGGI2TXT ", "").Trim
      End If
      If riga.StartsWith("SCRIVIDATXT") Then
        cmd = "WF"
        payload = Replace(riga, "SCRIVIDATXT", "").Trim
        'payload = " "
      End If
      If riga.StartsWith("ATTESA") Then
        cmd = "D"
        payload = Replace(riga, "ATTESA ", "").Trim
      End If

      If payload = "" Then GoTo nextr
      sbuffer = Split(payload, ",")
      ReDim Preserve buffer(sbuffer.Length - 1)

      If cmd = "W" Then
        Dim idx As Int16 = 0
        For Each ss As String In sbuffer
          buffer(idx) = Val(ss)
          idx = idx + 1
        Next
      End If
      If cmd = "WF" And filePath <> "" And IO.File.Exists(filePath) Then
        Dim tt As String = System.IO.File.ReadAllText(filePath)
        For idx As Integer = sbuffer.Length - 1 To 0 Step -1
          tt = sbuffer(idx) & " " & tt
        Next
        sbuffer = Split(tt, " ")
        ReDim buffer(sbuffer.Length - 1)
        For idx As Int16 = 0 To sbuffer.Length - 1
          buffer(idx) = Val(sbuffer(idx))
        Next
      End If

      Select Case cmd
        Case "R", "RF"
          Dim toread As Integer = sbuffer(0)
          ReDim buffer(toread - 1)
          rv = mcp2221_dll_m.MCP2221.M_Mcp2221_I2cRead(H, toread, addr, b7, buffer)
          If rv = 0 Then
            Dim sbloc As New System.Text.StringBuilder
            For i As Int16 = 0 To buffer.Length - 1
              sbloc.Append(buffer(i) & " ")
            Next
            Sb.AppendLine("RICEZIONE RIGA N°" & cr & " ARRAY[" & buffer.Length & "] (" & sbloc.ToString.Trim & ")")

            If cmd = "RF" And filePath <> "" Then
              System.IO.File.WriteAllText(filePath, sbloc.ToString.Trim)
            End If

          End If
        Case "W", "WF"
          rv = mcp2221_dll_m.MCP2221.M_Mcp2221_I2cWrite(H, buffer.Length, addr, b7, buffer)
        Case "D"
          System.Threading.Thread.Sleep(buffer(0))
      End Select

      If rv <> 0 Then
        Dim eComando As String = ""
        Select Case rv
          Case -401 : eComando = "E_ERR_INVALID_SPEED"
          Case -402 : eComando = "E_ERR_SPEED_NOT_SET"
          Case -403 : eComando = "E_ERR_INVALID_BYTE_NUMBER"
          Case -404 : eComando = "E_ERR_INVALID_ADDRESS"
          Case -405 : eComando = "E_ERR_I2C_BUSY"
          Case -406 : eComando = "E_ERR_I2C_READ_ERROR"
          Case -407 : eComando = "E_ERR_ADDRESS_NACK"
          Case -408 : eComando = "E_ERR_TIMEOUT"
          Case -409 : eComando = "E_ERR_TOO_MANY_RX_BYTES"
          Case -410 : eComando = "E_ERR_COPY_RX_DATA_FAILED"
          Case -411 : eComando = "E_ERR_NO_EFFECT"
          Case -412 : eComando = "E_ERR_COPY_TX_DATA_FAILED"
          Case -413 : eComando = "E_ERR_INVALID_PEC"
          Case -414 : eComando = "E_ERR_BLOCK_SIZE_MISMATCH"
        End Select
        Dim errnuo = mcp2221_dll_m.MCP2221.M_Mcp2221_GetLastError()
        Sb.AppendLine("ERRORE COMANDO RIGA N°" & cr & "(" & riga & ") " & eComando)
      Else
        Sb.AppendLine("Comando riga N°" & cr & " OK.")
      End If

nextr:
    Next




    mcp2221_dll_m.MCP2221.M_Mcp2221_I2cCancelCurrentTransfer(H)

    Return Sb.ToString
  End Function
  Public Function ScanI2C(fromI As Integer, ToI As Integer, spd As UInteger, bit7 As Boolean, pb As ProgressBar) As String

    Dim Sb As New System.Text.StringBuilder
    Dim arr(0) As Byte
    arr(0) = 0
    Dim b7 As Integer = 0
    If bit7 Then b7 = 1
    If Not IsNothing(pb) Then
      pb.Maximum = ToI
      pb.Minimum = fromI
      pb.Visible = True
    End If
    For i As Integer = fromI To ToI
      pb.Value = i
      Dim rv As Integer = -1
      rv = mcp2221_dll_m.MCP2221.M_Mcp2221_I2cCancelCurrentTransfer(H)
      rv = mcp2221_dll_m.MCP2221.M_Mcp2221_SetSpeed(H, spd)

      rv = mcp2221_dll_m.MCP2221.M_Mcp2221_I2cWrite(H, 1, i, b7, arr)
      If rv = 0 Then
        Sb.AppendLine("Indirizzo : " & i)
      End If
      mcp2221_dll_m.MCP2221.M_Mcp2221_I2cCancelCurrentTransfer(H)
    Next

    If Not IsNothing(pb) Then

      pb.Visible = False
    End If
    Return Sb.ToString
  End Function
End Class
