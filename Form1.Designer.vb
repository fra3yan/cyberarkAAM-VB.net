<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        ListView1 = New ListView()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(387, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(238, 23)
        Button1.TabIndex = 0
        Button1.Text = "Get data from API"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(26, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(169, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(202, 36)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(169, 23)
        TextBox2.TabIndex = 4
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(26, 97)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(599, 239)
        ListView1.TabIndex = 5
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(387, 355)
        Button2.Name = "Button2"
        Button2.Size = New Size(238, 23)
        Button2.TabIndex = 6
        Button2.Text = "Get data from Database"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 594)
        Controls.Add(Button2)
        Controls.Add(ListView1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
End Class
