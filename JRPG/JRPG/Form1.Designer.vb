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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WALL = New System.Windows.Forms.PictureBox()
        Me.Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.ENEMY = New System.Windows.Forms.PictureBox()
        Me.ATTACK = New System.Windows.Forms.PictureBox()
        Me.EnemyTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENEMY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATTACK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 273)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'WALL
        '
        Me.WALL.Image = CType(resources.GetObject("WALL.Image"), System.Drawing.Image)
        Me.WALL.Location = New System.Drawing.Point(-3, 417)
        Me.WALL.Name = "WALL"
        Me.WALL.Size = New System.Drawing.Size(803, 52)
        Me.WALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.WALL.TabIndex = 2
        Me.WALL.TabStop = False
        '
        'Gravity
        '
        Me.Gravity.Enabled = True
        '
        'ENEMY
        '
        Me.ENEMY.BackColor = System.Drawing.Color.Transparent
        Me.ENEMY.Image = CType(resources.GetObject("ENEMY.Image"), System.Drawing.Image)
        Me.ENEMY.Location = New System.Drawing.Point(339, 252)
        Me.ENEMY.Name = "ENEMY"
        Me.ENEMY.Size = New System.Drawing.Size(380, 164)
        Me.ENEMY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ENEMY.TabIndex = 3
        Me.ENEMY.TabStop = False
        '
        'ATTACK
        '
        Me.ATTACK.BackColor = System.Drawing.Color.Transparent
        Me.ATTACK.Image = CType(resources.GetObject("ATTACK.Image"), System.Drawing.Image)
        Me.ATTACK.Location = New System.Drawing.Point(12, 157)
        Me.ATTACK.Name = "ATTACK"
        Me.ATTACK.Size = New System.Drawing.Size(94, 93)
        Me.ATTACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ATTACK.TabIndex = 4
        Me.ATTACK.TabStop = False
        Me.ATTACK.Visible = False
        '
        'EnemyTimer
        '
        Me.EnemyTimer.Enabled = True
        Me.EnemyTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ATTACK)
        Me.Controls.Add(Me.WALL)
        Me.Controls.Add(Me.ENEMY)
        Me.Name = "Form1"
        Me.Text = "OVERWORLD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENEMY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATTACK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WALL As PictureBox
    Friend WithEvents Gravity As Timer
    Friend WithEvents ENEMY As PictureBox
    Friend WithEvents ATTACK As PictureBox
    Friend WithEvents EnemyTimer As Timer
End Class
