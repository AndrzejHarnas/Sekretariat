<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodajp
    Inherits System.Windows.Forms.Form
    Public cos As Integer
    Public nr As String
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dodajp))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.stn = New System.Windows.Forms.TextBox
        Me.names = New System.Windows.Forms.TextBox
        Me.surname = New System.Windows.Forms.TextBox
        Me.dtur = New System.Windows.Forms.TextBox
        Me.StanowiskaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.zp = New System.Windows.Forms.ComboBox
        Me.ZakladyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.city = New System.Windows.Forms.TextBox
        Me.street = New System.Windows.Forms.TextBox
        Me.kot = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.nrid = New System.Windows.Forms.TextBox
        Me.stp = New System.Windows.Forms.ComboBox
        Me.nastepny = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.StanowiskaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZakladyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Name = "Cancel_Button"
        '
        'OK_Button
        '
        resources.ApplyResources(Me.OK_Button, "OK_Button")
        Me.OK_Button.Name = "OK_Button"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'stn
        '
        resources.ApplyResources(Me.stn, "stn")
        Me.stn.Name = "stn"
        '
        'names
        '
        resources.ApplyResources(Me.names, "names")
        Me.names.Name = "names"
        '
        'surname
        '
        resources.ApplyResources(Me.surname, "surname")
        Me.surname.Name = "surname"
        '
        'dtur
        '
        resources.ApplyResources(Me.dtur, "dtur")
        Me.dtur.Name = "dtur"
        '
        'StanowiskaBindingSource
        '
        Me.StanowiskaBindingSource.DataMember = "stanowiska"
        '
        'InigkrosnoDataSet
        '
      
        '
        'zp
        '
        Me.zp.AllowDrop = True
        Me.zp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.zp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.zp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.zp.FormattingEnabled = True
        resources.ApplyResources(Me.zp, "zp")
        Me.zp.Name = "zp"
        '
        'ZakladyBindingSource
        '
        Me.ZakladyBindingSource.DataMember = "zaklady"

        '
        'city
        '
        resources.ApplyResources(Me.city, "city")
        Me.city.Name = "city"
        '
        'street
        '
        resources.ApplyResources(Me.street, "street")
        Me.street.Name = "street"
        '
        'kot
        '
        resources.ApplyResources(Me.kot, "kot")
        Me.kot.Name = "kot"
        '
        'StanowiskaTableAdapter
        '

        '
        'ZakladyTableAdapter
        '

        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'nrid
        '
        resources.ApplyResources(Me.nrid, "nrid")
        Me.nrid.Name = "nrid"
        Me.nrid.TabStop = False
        '
        'stp
        '
        Me.stp.AllowDrop = True
        Me.stp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stp.DropDownWidth = 200
        Me.stp.FormattingEnabled = True
        resources.ApplyResources(Me.stp, "stp")
        Me.stp.Name = "stp"
        '
        'nastepny
        '
        Me.nastepny.Image = Global.Sekretariat.My.Resources.Resources.skipover
        resources.ApplyResources(Me.nastepny, "nastepny")
        Me.nastepny.Name = "nastepny"
        Me.nastepny.UseVisualStyleBackColor = True
        '
        'dodajp
        '
        Me.AcceptButton = Me.OK_Button
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.nastepny)
        Me.Controls.Add(Me.stp)
        Me.Controls.Add(Me.nrid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.kot)
        Me.Controls.Add(Me.street)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.zp)
        Me.Controls.Add(Me.dtur)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.names)
        Me.Controls.Add(Me.stn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dodajp"
        Me.TableLayoutPanel1.ResumeLayout(False)
       

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents stn As System.Windows.Forms.TextBox
    Friend WithEvents names As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents dtur As System.Windows.Forms.TextBox
    Friend WithEvents zp As System.Windows.Forms.ComboBox
    Friend WithEvents city As System.Windows.Forms.TextBox
    Friend WithEvents street As System.Windows.Forms.TextBox
    Friend WithEvents kot As System.Windows.Forms.TextBox
    Friend WithEvents StanowiskaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZakladyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nrid As System.Windows.Forms.TextBox
    Friend WithEvents stp As System.Windows.Forms.ComboBox
    Friend WithEvents nastepny As System.Windows.Forms.Button

End Class
