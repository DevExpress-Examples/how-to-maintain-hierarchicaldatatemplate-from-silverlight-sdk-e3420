Imports System.Windows
Imports System.Windows.Data

Namespace HierarchicalDataTemplateMode
    Public Class SDKHierarchicalDataTemplateAdapter
        Inherits DevExpress.Xpf.Core.HierarchicalDataTemplate

        Public Property SDKTemplate() As HierarchicalDataTemplate

        Public Overrides Function GetActualTemplate() As DataTemplate
            Return SDKTemplate
        End Function

        Public Overrides Function GetActualItemSource() As Binding
            If SDKTemplate IsNot Nothing Then
                Return SDKTemplate.ItemsSource
            End If
            Return Nothing
        End Function

        Public Overrides Function GetActualItemTemplate() As DataTemplate
            If SDKTemplate IsNot Nothing Then
                Return SDKTemplate.ItemTemplate
            End If
            Return Nothing
        End Function
    End Class
End Namespace