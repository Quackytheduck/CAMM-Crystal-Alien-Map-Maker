﻿Public Class Unit

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.Position = New Point(x, y)
        Me.UnitId = ""
        Me.Team = Team.Astros
        Me.Angle = 0.0
        Me.Damage = 0.0
    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal unitId As String)
        Me.New(x, y)
        Me.UnitId = unitId
    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal unitId As String, ByVal team As Team)
        Me.New(x, y, unitId)
        Me.Team = team
    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal unitId As String, ByVal team As Team, ByVal angle As Single, ByVal damage As Single)
        Me.New(x, y, unitId, team)
        Me.Angle = angle
        Me.Damage = damage
    End Sub

    Public ReadOnly Property HasData() As Boolean
        Get
            Return SmallImage IsNot Nothing
        End Get
    End Property

    Public Property X() As Integer
        Get
            Return Position.X
        End Get
        Set(ByVal value As Integer)
            _position.X = value
        End Set
    End Property

    Public Property Y() As Integer
        Get
            Return Position.Y
        End Get
        Set(ByVal value As Integer)
            _position.Y = value
        End Set
    End Property

    Private _position As Point
    Public Property Position() As Point
        Get
            Return _position
        End Get
        Set(ByVal value As Point)
            _position = value
        End Set
    End Property

    Public ReadOnly Property SmallImage() As Image
        Get
            If Not String.IsNullOrEmpty(UnitId) Then
                Return UnitSmallImageLookup(UnitId)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property FullImage() As Image
        Get
            If Not String.IsNullOrEmpty(UnitId) Then
                Return UnitFullImageLookup(UnitId)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Property UnitId As String

    Public Property Team As Team

    Public Property Angle As Single

    Public Property Damage As Single

End Class
