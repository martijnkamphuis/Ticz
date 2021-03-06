﻿' The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

Public NotInheritable Class ucMenu_RoomSettings
    Inherits UserControl

    Public Property Menu As TiczMenuSettings

    Public ReadOnly Property vm As TiczViewModel
        Get
            Return CType(Application.Current, Application).myViewModel
        End Get
    End Property

    Public ReadOnly Property TiczSettings As TiczSettings
        Get
            Return CType(Application.Current, Application).myViewModel.TiczSettings
        End Get
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        AddHandler DataContextChanged, Sub(s, e)
                                           Menu = CType(Me.DataContext, TiczMenuSettings)
                                       End Sub

        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class
