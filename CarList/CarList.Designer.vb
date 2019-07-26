<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarList
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CarToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(105, 455)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "&Enter"
        Me.CarToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(186, 455)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.CarToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(267, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.CarToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(84, 34)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 3
        Me.CarToolTip.SetToolTip(Me.txtModel, "Type the customer's first name here.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(84, 90)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 5
        Me.CarToolTip.SetToolTip(Me.txtPrice, "Type the customer's last name here.")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Toyota", "Honda", "Tesla", "Volkswagen", "Audi", "Cadillac"})
        Me.cmbMake.Location = New System.Drawing.Point(84, 7)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.CarToolTip.SetToolTip(Me.cmbMake, "Select the customer's title.")
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(12, 7)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(66, 13)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make: "
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(12, 34)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(66, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Mode&l: "
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.UseWaitCursor = True
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(12, 93)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(66, 13)
        Me.lbPrice.TabIndex = 4
        Me.lbPrice.Text = "&Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(26, 116)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(52, 24)
        Me.chkNew.TabIndex = 6
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.chkNew, "Check to make the customer a VIP.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.Location = New System.Drawing.Point(12, 141)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(352, 246)
        Me.lvwCars.TabIndex = 7
        Me.CarToolTip.SetToolTip(Me.lvwCars, "Select a customer to modify.")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "NEW"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(12, 390)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(330, 60)
        Me.lbResult.TabIndex = 8
        Me.CarToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(12, 65)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(66, 13)
        Me.lbYear.TabIndex = 12
        Me.lbYear.Text = "&Year:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(85, 61)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 13
        '
        'frmCarList
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(376, 477)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents CarToolTip As ToolTip
    Friend WithEvents lbResult As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colPrice As ColumnHeader
End Class
