<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirlinePassengerGrowth
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFinalGrowth = New System.Windows.Forms.Label()
        Me.lblYearSelected = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGrowth = New System.Windows.Forms.Button()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.cboComboBox = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblFinalGrowth)
        Me.Panel1.Controls.Add(Me.lblYearSelected)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnGrowth)
        Me.Panel1.Controls.Add(Me.lstYear)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtyear)
        Me.Panel1.Controls.Add(Me.lblyear)
        Me.Panel1.Controls.Add(Me.cboComboBox)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(399, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 455)
        Me.Panel1.TabIndex = 0
        '
        'lblFinalGrowth
        '
        Me.lblFinalGrowth.AutoSize = True
        Me.lblFinalGrowth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalGrowth.Location = New System.Drawing.Point(87, 413)
        Me.lblFinalGrowth.Name = "lblFinalGrowth"
        Me.lblFinalGrowth.Size = New System.Drawing.Size(217, 29)
        Me.lblFinalGrowth.TabIndex = 9
        Me.lblFinalGrowth.Text = "XXXXXXXXXXXX"
        Me.lblFinalGrowth.Visible = False
        '
        'lblYearSelected
        '
        Me.lblYearSelected.AutoSize = True
        Me.lblYearSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearSelected.Location = New System.Drawing.Point(87, 384)
        Me.lblYearSelected.Name = "lblYearSelected"
        Me.lblYearSelected.Size = New System.Drawing.Size(217, 29)
        Me.lblYearSelected.TabIndex = 8
        Me.lblYearSelected.Text = "XXXXXXXXXXXX"
        Me.lblYearSelected.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(217, 336)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnGrowth
        '
        Me.btnGrowth.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnGrowth.Location = New System.Drawing.Point(60, 336)
        Me.btnGrowth.Name = "btnGrowth"
        Me.btnGrowth.Size = New System.Drawing.Size(86, 32)
        Me.btnGrowth.TabIndex = 6
        Me.btnGrowth.Text = "Growth"
        Me.btnGrowth.UseVisualStyleBackColor = False
        Me.btnGrowth.Visible = False
        '
        'lstYear
        '
        Me.lstYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.ItemHeight = 29
        Me.lstYear.Location = New System.Drawing.Point(68, 229)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(120, 91)
        Me.lstYear.TabIndex = 5
        Me.lstYear.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(55, 182)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(133, 29)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select year"
        Me.lblSelect.Visible = False
        '
        'txtyear
        '
        Me.txtyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(240, 130)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(52, 35)
        Me.txtyear.TabIndex = 3
        Me.txtyear.Visible = False
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(60, 133)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(128, 29)
        Me.lblyear.TabIndex = 2
        Me.lblyear.Text = "Enter year:"
        Me.lblyear.Visible = False
        '
        'cboComboBox
        '
        Me.cboComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComboBox.FormattingEnabled = True
        Me.cboComboBox.Items.AddRange(New Object() {"Year1", "Year2", "Year3", "Year4", "Year5", "Year6", "Year7", "Year8", "Year9", "Year10"})
        Me.cboComboBox.Location = New System.Drawing.Point(97, 78)
        Me.cboComboBox.Name = "cboComboBox"
        Me.cboComboBox.Size = New System.Drawing.Size(195, 40)
        Me.cboComboBox.TabIndex = 1
        Me.cboComboBox.Text = "Select Year"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(24, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(374, 43)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Passenger Growth"
        '
        'frmAirlinePassengerGrowth
        '
        Me.AcceptButton = Me.btnGrowth
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airlines_Passenger_Growth.My.Resources.Resources.airplane
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAirlinePassengerGrowth"
        Me.Text = "Airline Passanger Growth"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboComboBox As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFinalGrowth As Label
    Friend WithEvents lblYearSelected As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnGrowth As Button
    Friend WithEvents lstYear As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtyear As TextBox
    Friend WithEvents lblyear As Label
End Class
