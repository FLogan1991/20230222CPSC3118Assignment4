<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnB))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblInputNights = New System.Windows.Forms.Label()
        Me.lblPerNightCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtNumNights = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(396, 34)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(305, 40)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Orlando AirBnB"
        '
        'lblInputNights
        '
        Me.lblInputNights.AutoSize = True
        Me.lblInputNights.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputNights.Location = New System.Drawing.Point(395, 178)
        Me.lblInputNights.Name = "lblInputNights"
        Me.lblInputNights.Size = New System.Drawing.Size(149, 19)
        Me.lblInputNights.TabIndex = 1
        Me.lblInputNights.Text = "Number of Nights:"
        '
        'lblPerNightCost
        '
        Me.lblPerNightCost.AutoSize = True
        Me.lblPerNightCost.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerNightCost.Location = New System.Drawing.Point(447, 77)
        Me.lblPerNightCost.Name = "lblPerNightCost"
        Me.lblPerNightCost.Size = New System.Drawing.Size(219, 21)
        Me.lblPerNightCost.TabIndex = 2
        Me.lblPerNightCost.Text = "Only $79.00 per night"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(394, 238)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(108, 19)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Cost of Stay:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 415)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(569, 238)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(101, 19)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "FormFailure"
        '
        'txtNumNights
        '
        Me.txtNumNights.Location = New System.Drawing.Point(611, 178)
        Me.txtNumNights.Name = "txtNumNights"
        Me.txtNumNights.Size = New System.Drawing.Size(45, 20)
        Me.txtNumNights.TabIndex = 6
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Location = New System.Drawing.Point(403, 338)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(85, 35)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(523, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(639, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAirBnB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(811, 420)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.txtNumNights)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblPerNightCost)
        Me.Controls.Add(Me.lblInputNights)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmAirBnB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblInputNights As Label
    Friend WithEvents lblPerNightCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCost As Label
    Friend WithEvents txtNumNights As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
