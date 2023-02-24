<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.rdb1Player = New System.Windows.Forms.RadioButton()
        Me.rdb2Player = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbDifficulty = New System.Windows.Forms.ComboBox()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdb1Player
        '
        Me.rdb1Player.AutoSize = True
        Me.rdb1Player.Font = New System.Drawing.Font("Segoe Print", 14.25!)
        Me.rdb1Player.Location = New System.Drawing.Point(18, 96)
        Me.rdb1Player.Name = "rdb1Player"
        Me.rdb1Player.Size = New System.Drawing.Size(183, 37)
        Me.rdb1Player.TabIndex = 0
        Me.rdb1Player.TabStop = True
        Me.rdb1Player.Text = "1 Player + CPU"
        Me.rdb1Player.UseVisualStyleBackColor = True
        '
        'rdb2Player
        '
        Me.rdb2Player.AutoSize = True
        Me.rdb2Player.Font = New System.Drawing.Font("Segoe Print", 14.25!)
        Me.rdb2Player.Location = New System.Drawing.Point(18, 130)
        Me.rdb2Player.Name = "rdb2Player"
        Me.rdb2Player.Size = New System.Drawing.Size(115, 37)
        Me.rdb2Player.TabIndex = 1
        Me.rdb2Player.TabStop = True
        Me.rdb2Player.Text = "2 Player"
        Me.rdb2Player.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 20.25!)
        Me.lblTitle.Location = New System.Drawing.Point(10, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(299, 47)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Noughts and Crosses"
        '
        'cmbDifficulty
        '
        Me.cmbDifficulty.Font = New System.Drawing.Font("Segoe Print", 8.25!)
        Me.cmbDifficulty.FormattingEnabled = True
        Me.cmbDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cmbDifficulty.Location = New System.Drawing.Point(18, 211)
        Me.cmbDifficulty.Name = "cmbDifficulty"
        Me.cmbDifficulty.Size = New System.Drawing.Size(121, 27)
        Me.cmbDifficulty.TabIndex = 3
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Segoe Print", 12.0!)
        Me.lblDifficulty.Location = New System.Drawing.Point(14, 180)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(127, 28)
        Me.lblDifficulty.TabIndex = 4
        Me.lblDifficulty.Text = "CPU Difficulty"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe Print", 14.25!)
        Me.btnStart.Location = New System.Drawing.Point(84, 272)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(135, 42)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(312, 339)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.cmbDifficulty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.rdb2Player)
        Me.Controls.Add(Me.rdb1Player)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdb1Player As RadioButton
    Friend WithEvents rdb2Player As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbDifficulty As ComboBox
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents btnStart As Button
End Class
