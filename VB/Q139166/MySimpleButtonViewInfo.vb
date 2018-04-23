Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Reflection
Imports DevExpress.Utils
Namespace DXSample
	Public Class MySimpleButtonViewInfo
		Inherits SimpleButtonViewInfo
		Public Sub New(ByVal owner As SimpleButton)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CreateEditorButtonObjectInfoArgs(ByVal editorButton As EditorButton, ByVal appearance As AppearanceObject) As EditorButtonObjectInfoArgs
			Return MyBase.CreateEditorButtonObjectInfoArgs(New MyEditorButton(), appearance)
		End Function
	End Class

	Public Class MyEditorButton
		Inherits EditorButton
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides Property Image() As System.Drawing.Image
			Get
				Return MyBase.Image
			End Get
			Set(ByVal value As System.Drawing.Image)
				If MyBase.Image Is value Then
					Return
				End If
				Dim fi As FieldInfo = GetType(EditorButton).GetField("_image", BindingFlags.Instance Or BindingFlags.NonPublic)
				fi.SetValue(Me, value)
				OnChanged()
			End Set
		End Property
	End Class
End Namespace