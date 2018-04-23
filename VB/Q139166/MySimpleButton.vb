Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System.Reflection

Namespace DXSample
	Public Class MySimpleButton
		Inherits SimpleButton
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
				Dim fi As FieldInfo = GetType(SimpleButton).GetField("image", BindingFlags.Instance Or BindingFlags.NonPublic)
				fi.SetValue(Me, value)
				OnPropertiesChanged()
			End Set
		End Property

		Protected Overrides Function CreateViewInfo() As DevExpress.XtraEditors.ViewInfo.BaseStyleControlViewInfo
			Return New MySimpleButtonViewInfo(Me)
		End Function
	End Class
End Namespace