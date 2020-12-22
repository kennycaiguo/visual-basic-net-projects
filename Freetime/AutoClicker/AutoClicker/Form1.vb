Imports System.Runtime.InteropServices

' 
' Copyright 2020, Kye Matzen, http://kyematzen.com
' <p>
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the
' Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
' and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
' <p>
' The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
' <p>
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
' ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
' THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'

Public Class frmAutoClicker

    Dim clickerEnabled As Boolean = False
    Private WithEvents kbHook As New KeyboardHook
    Private Declare Sub mouse_event Lib "user32.dll" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As IntPtr)
    Dim clicksRemaining As Integer = -1
    Dim mouseButton As String
    Dim clickType As String

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_MOVE = &H1

    Private Sub keyPressed(ByVal Key As Keys) Handles kbHook.KeyDown
        If (Key.ToString = "F6") Then
            If clickerEnabled Then
                stopProgram()
            Else
                startProgram()
            End If
        End If
    End Sub

    Sub startProgram()
        Me.Text = "Clicking - Auto Clicker 1.1.5"

        Dim time As Integer = getTime()

        systemClicker.Interval = If(time = 0, 1, time)

        If rButtonRepeat.Checked Then
            clicksRemaining = numericUpDownTimes.Value
        End If

        mouseButton = comboBoxMouseButton.SelectedItem
        clickType = comboBoxClickType.SelectedItem

        toggleSettings(False)
    End Sub

    Sub stopProgram()
        Me.Text = "Stopped - Auto Clicker 1.1.5"

        toggleSettings(True)

        clicksRemaining = -1
    End Sub

    Function getTime() As Integer
        Dim milliseconds As Integer = 0

        If IsNumeric(txtBoxHours.Text) Then
            milliseconds += (CInt(txtBoxHours.Text) * 3600000)
        End If

        If IsNumeric(txtBoxMinutes.Text) Then
            milliseconds += (CInt(txtBoxMinutes.Text) * 60000)
        End If

        If IsNumeric(txtBoxSeconds.Text) Then
            milliseconds += (CInt(txtBoxSeconds.Text) * 1000)
        End If

        If IsNumeric(txtBoxMilliseconds.Text) Then
            milliseconds += CInt(txtBoxMilliseconds.Text)
        End If

        Return milliseconds
    End Function

    Sub toggleSettings(ByRef bool As Boolean)
        clickerEnabled = Not bool

        btnStart.Enabled = bool
        btnStop.Enabled = Not bool
        systemClicker.Enabled = Not bool

        txtBoxHours.Enabled = bool
        txtBoxMinutes.Enabled = bool
        txtBoxSeconds.Enabled = bool
        txtBoxMilliseconds.Enabled = bool

        comboBoxMouseButton.Enabled = bool
        comboBoxClickType.Enabled = bool

        rButtonRepeat.Enabled = bool
        rButtonRepeatUntilStopped.Enabled = bool

        numericUpDownTimes.Enabled = bool
    End Sub

    Private Sub frmAutoClicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comboBoxMouseButton.SelectedIndex = 0
        comboBoxClickType.SelectedIndex = 0

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        startProgram()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        stopProgram()
    End Sub

    Private Sub systemClicker_Tick(sender As Object, e As EventArgs) Handles systemClicker.Tick
        Select Case clicksRemaining
            Case Is = -1
                executeClick()
            Case Is > 0
                executeClick()
                clicksRemaining -= 1
            Case Else
                stopProgram()
        End Select
    End Sub

    Sub executeClick()
        If mouseButton = "Left" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)

            If clickType = "Double" Then
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            End If

            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        ElseIf mouseButton = "Right" Then
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)

            If clickType = "Double" Then
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
            End If

            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
        Else
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)

            If clickType = "Double" Then
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
            End If

            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
        End If
    End Sub
End Class

Public Class KeyboardHook

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode, scanCode, time As UInt32
        Public flags As KBDLLHOOKSTRUCTFlags
        Public dwExtraInfo As UIntPtr
    End Structure

    <Flags()>
    Private Enum KBDLLHOOKSTRUCTFlags As UInt32
        LLKHF_EXTENDED = &H1
        LLKHF_INJECTED = &H10
        LLKHF_ALTDOWN = &H20
        LLKHF_UP = &H80
    End Enum

    Public Shared Event KeyDown(ByVal Key As Keys)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const HC_ACTION As Integer = 0
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104


    Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    Private KBDLLHookProcDelegate As KBDLLHookProc = New KBDLLHookProc(AddressOf KeyboardProc)
    Private HHookID As IntPtr = IntPtr.Zero

    Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        If (nCode = HC_ACTION) Then
            Dim struct As KBDLLHOOKSTRUCT
            Dim keyType As Keys = CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys)

            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(keyType)
            End Select
        End If
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function

    Public Sub New()
        HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
        If HHookID = IntPtr.Zero Then
            Throw New Exception("Could not set keyboard hook")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If Not HHookID = IntPtr.Zero Then
            UnhookWindowsHookEx(HHookID)
        End If
        MyBase.Finalize()
    End Sub
End Class