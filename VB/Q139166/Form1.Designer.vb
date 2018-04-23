Imports Microsoft.VisualBasic
Imports System
Namespace Q139166
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.mySimpleButton1 = New DXSample.MySimpleButton()
			Me.SuspendLayout()
			' 
			' mySimpleButton1
			' 
			Me.mySimpleButton1.Image = (CType(resources.GetObject("mySimpleButton1.Image"), System.Drawing.Image))
			Me.mySimpleButton1.Location = New System.Drawing.Point(93, 90)
			Me.mySimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.mySimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.mySimpleButton1.Name = "mySimpleButton1"
			Me.mySimpleButton1.Size = New System.Drawing.Size(98, 38)
			Me.mySimpleButton1.TabIndex = 1
			Me.mySimpleButton1.Text = "mySimpleButton1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 216)
			Me.Controls.Add(Me.mySimpleButton1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private mySimpleButton1 As DXSample.MySimpleButton
	End Class
End Namespace

