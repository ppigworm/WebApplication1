Imports System.Xml

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Dim xdoc As New XmlDocument
            xdoc.Load(Server.MapPath("colors.xml"))
            Dim xnode As XmlNode
            Dim lItem As ListItem
            For Each xnode In xdoc.DocumentElement.SelectNodes(".//color")
                lItem = New ListItem
                lItem.Text = xnode.Attributes("name").Value.Substring(0, 1).ToUpper & xnode.Attributes("name").Value.Substring(1)
                lItem.Value = xnode.InnerText
                DropDownList1.Items.Add(lItem)

            Next

            Page.Title = "Pick your favorite color."
        End If
    End Sub


    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        selResult.InnerHtml = "Your favorite color is <span style=" & Chr(34) & "background-color: " & DropDownList1.SelectedItem.Value & Chr(34) & ">" & DropDownList1.SelectedItem.Text & "</span>."

        'populate unselected ones
        Dim c As ListItem
        Dim unselList As String
        For Each c In DropDownList1.Items
            If Not c.Selected Then
                unselList = unselList & "<li style=" & Chr(34) & "background-color:" & c.Value & Chr(34) & ">" & c.Text & "</li>" & vbCrLf
            End If
        Next

        unselected.InnerHtml = unselList.Trim

    End Sub


End Class