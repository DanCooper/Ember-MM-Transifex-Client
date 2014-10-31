Imports System.Xml.Serialization

Public Class Transifex

    <Serializable()> _
    <XmlRoot("strings")> _
    Public Class Strings
        Implements IComparable(Of Strings)

#Region "Fields"

        Private _strings As New List(Of [String])

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Me.Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        <XmlElement("string")> _
        Public Property Strings() As List(Of [String])
            Get
                Return Me._strings
            End Get
            Set(ByVal value As List(Of [String]))
                _strings = value
            End Set
        End Property

        <XmlIgnore()> _
        Public ReadOnly Property StringsSpecified() As Boolean
            Get
                Return Me._strings.Count > 0
            End Get
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            Me._strings.Clear()
        End Sub

        Public Function CompareTo(ByVal other As Strings) As Integer Implements IComparable(Of Strings).CompareTo
            'Dim retVal As Integer = (Me.Lev).CompareTo(other.Lev)
            'If retVal = 0 Then
            '    retVal = (Me.Year).CompareTo(other.Year) * -1
            'End If
            'Return retVal
        End Function

#End Region 'Methods

    End Class

    <Serializable()> _
    Public Class [String]

#Region "Fields"

        Private _id As Long
        Private _data As String
        Private _text As String

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Me.Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        <XmlAttribute("id")> _
        Public Property ID() As Long
            Get
                Return _id
            End Get
            Set(ByVal value As Long)
                _id = value
            End Set
        End Property

        <XmlIgnore()> _
        Public ReadOnly Property IDSpecified() As Boolean
            Get
                Return Not String.IsNullOrEmpty(Me._id)
            End Get
        End Property

        <XmlAttribute("data-tx-text")> _
        Public Property Data() As String
            Get
                Return _data
            End Get
            Set(ByVal value As String)
                _data = value
            End Set
        End Property

        <XmlIgnore()> _
        Public ReadOnly Property DataSpecified() As Boolean
            Get
                Return Not String.IsNullOrEmpty(Me._data)
            End Get
        End Property

        <XmlText()> _
        Public Property Text() As String
            Get
                Return _text
            End Get
            Set(ByVal value As String)
                _text = value
            End Set
        End Property

        <XmlIgnore()> _
        Public ReadOnly Property TextSpecified() As Boolean
            Get
                Return Not String.IsNullOrEmpty(Me._text)
            End Get
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            _id = -1
            _text = String.Empty
            _data = String.Empty
        End Sub

#End Region 'Methods

    End Class

End Class
