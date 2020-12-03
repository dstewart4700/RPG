<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ATTACK = New System.Windows.Forms.Button()
        Me.ITEM = New System.Windows.Forms.Button()
        Me.PlayerHealth = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EnemyHealth = New System.Windows.Forms.ProgressBar()
        Me.WATER = New System.Windows.Forms.Button()
        Me.PUNCH = New System.Windows.Forms.Button()
        Me.FIRE = New System.Windows.Forms.Button()
        Me.Sword = New System.Windows.Forms.Button()
        Me.MAGIC = New System.Windows.Forms.Button()
        Me.ESCAPE = New System.Windows.Forms.Button()
        Me.Potion = New System.Windows.Forms.Button()
        Me.Mana = New System.Windows.Forms.Button()
        Me.BACK = New System.Windows.Forms.Button()
        Me.RUN = New System.Windows.Forms.Button()
        Me.DamageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyDamageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyDodge = New System.Windows.Forms.Label()
        Me.PlayerDodge = New System.Windows.Forms.Label()
        Me.PlayerStatus = New System.Windows.Forms.Label()
        Me.SURE = New System.Windows.Forms.Label()
        Me.WIN1 = New System.Windows.Forms.Label()
        Me.WIN2 = New System.Windows.Forms.Label()
        Me.Run1 = New System.Windows.Forms.Label()
        Me.Run2 = New System.Windows.Forms.Label()
        Me.PunchAniTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAniTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAniTimer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAniTimer4 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAniTimer5 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAfterTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAfterTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAfterTimer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAfterTimer4 = New System.Windows.Forms.Timer(Me.components)
        Me.PunchAfterTimer5 = New System.Windows.Forms.Timer(Me.components)
        Me.WinTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 223)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 356)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(801, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(574, 46)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(138, 163)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'ATTACK
        '
        Me.ATTACK.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATTACK.Location = New System.Drawing.Point(574, 372)
        Me.ATTACK.Name = "ATTACK"
        Me.ATTACK.Size = New System.Drawing.Size(83, 23)
        Me.ATTACK.TabIndex = 3
        Me.ATTACK.Text = "FIGHT"
        Me.ATTACK.UseVisualStyleBackColor = True
        '
        'ITEM
        '
        Me.ITEM.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEM.Location = New System.Drawing.Point(574, 401)
        Me.ITEM.Name = "ITEM"
        Me.ITEM.Size = New System.Drawing.Size(83, 23)
        Me.ITEM.TabIndex = 4
        Me.ITEM.Text = "ITEM"
        Me.ITEM.UseVisualStyleBackColor = True
        '
        'PlayerHealth
        '
        Me.PlayerHealth.ForeColor = System.Drawing.Color.Red
        Me.PlayerHealth.Location = New System.Drawing.Point(12, 372)
        Me.PlayerHealth.Name = "PlayerHealth"
        Me.PlayerHealth.Size = New System.Drawing.Size(191, 20)
        Me.PlayerHealth.TabIndex = 5
        Me.PlayerHealth.Tag = "YOU"
        Me.PlayerHealth.Value = 100
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(218, 372)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(25, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "You"
        '
        'EnemyHealth
        '
        Me.EnemyHealth.BackColor = System.Drawing.Color.Red
        Me.EnemyHealth.Location = New System.Drawing.Point(574, 195)
        Me.EnemyHealth.Name = "EnemyHealth"
        Me.EnemyHealth.Size = New System.Drawing.Size(138, 23)
        Me.EnemyHealth.TabIndex = 7
        Me.EnemyHealth.Value = 100
        Me.EnemyHealth.Visible = False
        '
        'WATER
        '
        Me.WATER.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WATER.Location = New System.Drawing.Point(443, 372)
        Me.WATER.Name = "WATER"
        Me.WATER.Size = New System.Drawing.Size(103, 25)
        Me.WATER.TabIndex = 8
        Me.WATER.Text = "WATER"
        Me.WATER.UseVisualStyleBackColor = True
        Me.WATER.Visible = False
        '
        'PUNCH
        '
        Me.PUNCH.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PUNCH.Location = New System.Drawing.Point(443, 372)
        Me.PUNCH.Name = "PUNCH"
        Me.PUNCH.Size = New System.Drawing.Size(103, 25)
        Me.PUNCH.TabIndex = 9
        Me.PUNCH.Text = "PUNCH"
        Me.PUNCH.UseVisualStyleBackColor = True
        Me.PUNCH.Visible = False
        '
        'FIRE
        '
        Me.FIRE.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRE.Location = New System.Drawing.Point(334, 372)
        Me.FIRE.Name = "FIRE"
        Me.FIRE.Size = New System.Drawing.Size(103, 25)
        Me.FIRE.TabIndex = 10
        Me.FIRE.Text = "FIREBALL"
        Me.FIRE.UseVisualStyleBackColor = True
        Me.FIRE.Visible = False
        '
        'Sword
        '
        Me.Sword.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sword.Location = New System.Drawing.Point(334, 372)
        Me.Sword.Name = "Sword"
        Me.Sword.Size = New System.Drawing.Size(103, 25)
        Me.Sword.TabIndex = 11
        Me.Sword.Text = "SWORD"
        Me.Sword.UseVisualStyleBackColor = True
        Me.Sword.Visible = False
        '
        'MAGIC
        '
        Me.MAGIC.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAGIC.Location = New System.Drawing.Point(663, 372)
        Me.MAGIC.Name = "MAGIC"
        Me.MAGIC.Size = New System.Drawing.Size(83, 23)
        Me.MAGIC.TabIndex = 12
        Me.MAGIC.Text = "MAGIC"
        Me.MAGIC.UseVisualStyleBackColor = True
        '
        'ESCAPE
        '
        Me.ESCAPE.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESCAPE.Location = New System.Drawing.Point(663, 401)
        Me.ESCAPE.Name = "ESCAPE"
        Me.ESCAPE.Size = New System.Drawing.Size(83, 23)
        Me.ESCAPE.TabIndex = 13
        Me.ESCAPE.Text = "RUN"
        Me.ESCAPE.UseVisualStyleBackColor = True
        '
        'Potion
        '
        Me.Potion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Potion.Location = New System.Drawing.Point(334, 372)
        Me.Potion.Name = "Potion"
        Me.Potion.Size = New System.Drawing.Size(103, 25)
        Me.Potion.TabIndex = 14
        Me.Potion.Text = "POTION"
        Me.Potion.UseVisualStyleBackColor = True
        Me.Potion.Visible = False
        '
        'Mana
        '
        Me.Mana.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mana.Location = New System.Drawing.Point(443, 372)
        Me.Mana.Name = "Mana"
        Me.Mana.Size = New System.Drawing.Size(103, 25)
        Me.Mana.TabIndex = 15
        Me.Mana.Text = "ATK UP"
        Me.Mana.UseVisualStyleBackColor = True
        Me.Mana.Visible = False
        '
        'BACK
        '
        Me.BACK.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BACK.Location = New System.Drawing.Point(663, 401)
        Me.BACK.Name = "BACK"
        Me.BACK.Size = New System.Drawing.Size(83, 23)
        Me.BACK.TabIndex = 16
        Me.BACK.Text = "BACK"
        Me.BACK.UseVisualStyleBackColor = True
        Me.BACK.Visible = False
        '
        'RUN
        '
        Me.RUN.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RUN.Location = New System.Drawing.Point(574, 401)
        Me.RUN.Name = "RUN"
        Me.RUN.Size = New System.Drawing.Size(83, 23)
        Me.RUN.TabIndex = 17
        Me.RUN.Text = "RUN"
        Me.RUN.UseVisualStyleBackColor = True
        Me.RUN.Visible = False
        '
        'DamageTimer
        '
        Me.DamageTimer.Interval = 1000
        '
        'EnemyDamageTimer
        '
        Me.EnemyDamageTimer.Interval = 1000
        '
        'EnemyDodge
        '
        Me.EnemyDodge.AutoSize = True
        Me.EnemyDodge.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnemyDodge.Location = New System.Drawing.Point(547, 73)
        Me.EnemyDodge.Name = "EnemyDodge"
        Me.EnemyDodge.Size = New System.Drawing.Size(42, 18)
        Me.EnemyDodge.TabIndex = 23
        Me.EnemyDodge.Text = "MISS"
        Me.EnemyDodge.Visible = False
        '
        'PlayerDodge
        '
        Me.PlayerDodge.AutoSize = True
        Me.PlayerDodge.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerDodge.Location = New System.Drawing.Point(180, 244)
        Me.PlayerDodge.Name = "PlayerDodge"
        Me.PlayerDodge.Size = New System.Drawing.Size(42, 18)
        Me.PlayerDodge.TabIndex = 24
        Me.PlayerDodge.Text = "MISS"
        Me.PlayerDodge.Visible = False
        '
        'PlayerStatus
        '
        Me.PlayerStatus.AutoSize = True
        Me.PlayerStatus.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerStatus.Location = New System.Drawing.Point(58, 223)
        Me.PlayerStatus.Name = "PlayerStatus"
        Me.PlayerStatus.Size = New System.Drawing.Size(48, 18)
        Me.PlayerStatus.TabIndex = 25
        Me.PlayerStatus.Text = "ATK+"
        Me.PlayerStatus.Visible = False
        '
        'SURE
        '
        Me.SURE.AutoSize = True
        Me.SURE.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SURE.Location = New System.Drawing.Point(390, 406)
        Me.SURE.Name = "SURE"
        Me.SURE.Size = New System.Drawing.Size(105, 18)
        Me.SURE.TabIndex = 26
        Me.SURE.Text = "Are you sure?"
        Me.SURE.Visible = False
        '
        'WIN1
        '
        Me.WIN1.AutoSize = True
        Me.WIN1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WIN1.Location = New System.Drawing.Point(564, 46)
        Me.WIN1.Name = "WIN1"
        Me.WIN1.Size = New System.Drawing.Size(182, 19)
        Me.WIN1.TabIndex = 27
        Me.WIN1.Text = "CONGRATULATIONS"
        Me.WIN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WIN1.Visible = False
        '
        'WIN2
        '
        Me.WIN2.AutoSize = True
        Me.WIN2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WIN2.Location = New System.Drawing.Point(605, 65)
        Me.WIN2.Name = "WIN2"
        Me.WIN2.Size = New System.Drawing.Size(90, 19)
        Me.WIN2.TabIndex = 28
        Me.WIN2.Text = "YOU WIN!"
        Me.WIN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WIN2.Visible = False
        '
        'Run1
        '
        Me.Run1.AutoSize = True
        Me.Run1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Run1.Location = New System.Drawing.Point(375, 156)
        Me.Run1.Name = "Run1"
        Me.Run1.Size = New System.Drawing.Size(86, 19)
        Me.Run1.TabIndex = 29
        Me.Run1.Text = "You Failed"
        Me.Run1.Visible = False
        '
        'Run2
        '
        Me.Run2.AutoSize = True
        Me.Run2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Run2.Location = New System.Drawing.Point(377, 175)
        Me.Run2.Name = "Run2"
        Me.Run2.Size = New System.Drawing.Size(84, 19)
        Me.Run2.TabIndex = 30
        Me.Run2.Text = "To Escape"
        Me.Run2.Visible = False
        '
        'PunchAniTimer
        '
        Me.PunchAniTimer.Interval = 50
        '
        'PunchAniTimer2
        '
        Me.PunchAniTimer2.Interval = 50
        '
        'PunchAniTimer3
        '
        Me.PunchAniTimer3.Interval = 50
        '
        'PunchAniTimer4
        '
        Me.PunchAniTimer4.Interval = 50
        '
        'PunchAniTimer5
        '
        Me.PunchAniTimer5.Interval = 50
        '
        'PunchAfterTimer1
        '
        Me.PunchAfterTimer1.Interval = 50
        '
        'PunchAfterTimer2
        '
        Me.PunchAfterTimer2.Interval = 50
        '
        'PunchAfterTimer3
        '
        Me.PunchAfterTimer3.Interval = 50
        '
        'PunchAfterTimer4
        '
        Me.PunchAfterTimer4.Interval = 50
        '
        'PunchAfterTimer5
        '
        Me.PunchAfterTimer5.Interval = 50
        '
        'WinTimer
        '
        Me.WinTimer.Interval = 3000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Run2)
        Me.Controls.Add(Me.Run1)
        Me.Controls.Add(Me.WIN2)
        Me.Controls.Add(Me.WIN1)
        Me.Controls.Add(Me.SURE)
        Me.Controls.Add(Me.PlayerStatus)
        Me.Controls.Add(Me.Potion)
        Me.Controls.Add(Me.Mana)
        Me.Controls.Add(Me.PlayerDodge)
        Me.Controls.Add(Me.EnemyDodge)
        Me.Controls.Add(Me.EnemyHealth)
        Me.Controls.Add(Me.PUNCH)
        Me.Controls.Add(Me.Sword)
        Me.Controls.Add(Me.RUN)
        Me.Controls.Add(Me.ESCAPE)
        Me.Controls.Add(Me.FIRE)
        Me.Controls.Add(Me.WATER)
        Me.Controls.Add(Me.BACK)
        Me.Controls.Add(Me.MAGIC)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PlayerHealth)
        Me.Controls.Add(Me.ITEM)
        Me.Controls.Add(Me.ATTACK)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Form2"
        Me.Text = "BATTLE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ATTACK As Button
    Friend WithEvents ITEM As Button
    Friend WithEvents PlayerHealth As ProgressBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EnemyHealth As ProgressBar
    Friend WithEvents WATER As Button
    Friend WithEvents PUNCH As Button
    Friend WithEvents FIRE As Button
    Friend WithEvents Sword As Button
    Friend WithEvents MAGIC As Button
    Friend WithEvents ESCAPE As Button
    Friend WithEvents Potion As Button
    Friend WithEvents Mana As Button
    Friend WithEvents BACK As Button
    Friend WithEvents RUN As Button
    Friend WithEvents DamageTimer As Timer
    Friend WithEvents EnemyDamageTimer As Timer
    Friend WithEvents EnemyDodge As Label
    Friend WithEvents PlayerDodge As Label
    Friend WithEvents PlayerStatus As Label
    Friend WithEvents SURE As Label
    Friend WithEvents WIN1 As Label
    Friend WithEvents WIN2 As Label
    Friend WithEvents Run1 As Label
    Friend WithEvents Run2 As Label
    Friend WithEvents PunchAniTimer As Timer
    Friend WithEvents PunchAniTimer2 As Timer
    Friend WithEvents PunchAniTimer3 As Timer
    Friend WithEvents PunchAniTimer4 As Timer
    Friend WithEvents PunchAniTimer5 As Timer
    Friend WithEvents PunchAfterTimer1 As Timer
    Friend WithEvents PunchAfterTimer2 As Timer
    Friend WithEvents PunchAfterTimer3 As Timer
    Friend WithEvents PunchAfterTimer4 As Timer
    Friend WithEvents PunchAfterTimer5 As Timer
    Friend WithEvents WinTimer As Timer
End Class
