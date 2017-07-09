<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WoodCabinetApp
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
        Me.lblCabinetCostHeader = New System.Windows.Forms.Label()
        Me.lblLinearFeet = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.lblCostTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLinearFeet = New System.Windows.Forms.TextBox()
        Me.picCabinets = New System.Windows.Forms.PictureBox()
        Me.radPine = New System.Windows.Forms.RadioButton()
        Me.radOak = New System.Windows.Forms.RadioButton()
        Me.radCherry = New System.Windows.Forms.RadioButton()
        Me.grpWoodType = New System.Windows.Forms.GroupBox()
        CType(Me.picCabinets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCabinetCostHeader
        '
        Me.lblCabinetCostHeader.AutoSize = True
        Me.lblCabinetCostHeader.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabinetCostHeader.Location = New System.Drawing.Point(36, 21)
        Me.lblCabinetCostHeader.Name = "lblCabinetCostHeader"
        Me.lblCabinetCostHeader.Size = New System.Drawing.Size(206, 28)
        Me.lblCabinetCostHeader.TabIndex = 0
        Me.lblCabinetCostHeader.Text = "Wood Cabinet Cost"
        '
        'lblLinearFeet
        '
        Me.lblLinearFeet.AutoSize = True
        Me.lblLinearFeet.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinearFeet.Location = New System.Drawing.Point(61, 59)
        Me.lblLinearFeet.Name = "lblLinearFeet"
        Me.lblLinearFeet.Size = New System.Drawing.Size(102, 23)
        Me.lblLinearFeet.TabIndex = 1
        Me.lblLinearFeet.Text = "Linear Feet:"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.Location = New System.Drawing.Point(30, 214)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(121, 23)
        Me.lblCostEstimate.TabIndex = 2
        Me.lblCostEstimate.Text = "Cost Estimate:"
        '
        'lblCostTotal
        '
        Me.lblCostTotal.AutoSize = True
        Me.lblCostTotal.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostTotal.Location = New System.Drawing.Point(160, 214)
        Me.lblCostTotal.Name = "lblCostTotal"
        Me.lblCostTotal.Size = New System.Drawing.Size(0, 23)
        Me.lblCostTotal.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(23, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 33)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(153, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLinearFeet
        '
        Me.txtLinearFeet.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinearFeet.Location = New System.Drawing.Point(169, 56)
        Me.txtLinearFeet.Name = "txtLinearFeet"
        Me.txtLinearFeet.Size = New System.Drawing.Size(48, 30)
        Me.txtLinearFeet.TabIndex = 6
        Me.txtLinearFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picCabinets
        '
        Me.picCabinets.Image = Global.WoodCabinetEstimateApplication.My.Resources.Resources.Cabinets
        Me.picCabinets.Location = New System.Drawing.Point(3, 281)
        Me.picCabinets.Name = "picCabinets"
        Me.picCabinets.Size = New System.Drawing.Size(273, 94)
        Me.picCabinets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCabinets.TabIndex = 7
        Me.picCabinets.TabStop = False
        '
        'radPine
        '
        Me.radPine.AutoSize = True
        Me.radPine.Checked = True
        Me.radPine.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPine.Location = New System.Drawing.Point(103, 114)
        Me.radPine.Name = "radPine"
        Me.radPine.Size = New System.Drawing.Size(56, 25)
        Me.radPine.TabIndex = 1
        Me.radPine.TabStop = True
        Me.radPine.Text = "Pine"
        Me.radPine.UseVisualStyleBackColor = True
        '
        'radOak
        '
        Me.radOak.AutoSize = True
        Me.radOak.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOak.Location = New System.Drawing.Point(103, 139)
        Me.radOak.Name = "radOak"
        Me.radOak.Size = New System.Drawing.Size(56, 25)
        Me.radOak.TabIndex = 2
        Me.radOak.TabStop = True
        Me.radOak.Text = "Oak"
        Me.radOak.UseVisualStyleBackColor = True
        '
        'radCherry
        '
        Me.radCherry.AutoSize = True
        Me.radCherry.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCherry.Location = New System.Drawing.Point(103, 164)
        Me.radCherry.Name = "radCherry"
        Me.radCherry.Size = New System.Drawing.Size(73, 25)
        Me.radCherry.TabIndex = 3
        Me.radCherry.TabStop = True
        Me.radCherry.Text = "Cherry"
        Me.radCherry.UseVisualStyleBackColor = True
        '
        'grpWoodType
        '
        Me.grpWoodType.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWoodType.Location = New System.Drawing.Point(85, 92)
        Me.grpWoodType.Name = "grpWoodType"
        Me.grpWoodType.Size = New System.Drawing.Size(108, 107)
        Me.grpWoodType.TabIndex = 8
        Me.grpWoodType.TabStop = False
        Me.grpWoodType.Text = "Wood Type"
        '
        'WoodCabinetApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(278, 378)
        Me.Controls.Add(Me.radCherry)
        Me.Controls.Add(Me.radOak)
        Me.Controls.Add(Me.picCabinets)
        Me.Controls.Add(Me.radPine)
        Me.Controls.Add(Me.txtLinearFeet)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostTotal)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblLinearFeet)
        Me.Controls.Add(Me.lblCabinetCostHeader)
        Me.Controls.Add(Me.grpWoodType)
        Me.Name = "WoodCabinetApp"
        Me.Text = "Wood Cabinet Estimate"
        CType(Me.picCabinets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCabinetCostHeader As System.Windows.Forms.Label
    Friend WithEvents lblLinearFeet As System.Windows.Forms.Label
    Friend WithEvents lblCostEstimate As System.Windows.Forms.Label
    Friend WithEvents lblCostTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtLinearFeet As System.Windows.Forms.TextBox
    Friend WithEvents picCabinets As System.Windows.Forms.PictureBox
    Friend WithEvents radPine As System.Windows.Forms.RadioButton
    Friend WithEvents radOak As System.Windows.Forms.RadioButton
    Friend WithEvents radCherry As System.Windows.Forms.RadioButton
    Friend WithEvents grpWoodType As System.Windows.Forms.GroupBox

End Class
