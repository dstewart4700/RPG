Public Class Form2
    Dim SworRand As New Random
    Dim PunchRand As New Random
    Dim EnemAtk As New Random
    Dim Escapade As New Random
    Private Sub ATTACK_Click(sender As Object, e As EventArgs) Handles ATTACK.Click
        ITEM.Visible = False
        MAGIC.Visible = False
        ESCAPE.Visible = False
        Sword.Visible = True
        PUNCH.Visible = True
        BACK.Visible = True
    End Sub

    Private Sub ITEM_Click(sender As Object, e As EventArgs) Handles ITEM.Click
        ATTACK.Visible = False
        MAGIC.Visible = False
        ESCAPE.Visible = False
        Potion.Visible = True
        Mana.Visible = True
        BACK.Visible = True
    End Sub

    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click
        ATTACK.Visible = True
        MAGIC.Visible = True
        ESCAPE.Visible = True
        ITEM.Visible = True
        Potion.Visible = False
        Mana.Visible = False
        BACK.Visible = False
        Sword.Visible = False
        PUNCH.Visible = False
        FIRE.Visible = False
        WATER.Visible = False
        RUN.Visible = False
        SURE.Visible = False
    End Sub

    Private Sub MAGIC_Click(sender As Object, e As EventArgs) Handles MAGIC.Click
        ATTACK.Visible = False
        ITEM.Visible = False
        ESCAPE.Visible = False
        FIRE.Visible = True
        WATER.Visible = True
        BACK.Visible = True
    End Sub

    Private Sub ESCAPE_Click(sender As Object, e As EventArgs) Handles ESCAPE.Click
        ATTACK.Visible = False
        ITEM.Visible = False
        MAGIC.Visible = False
        BACK.Visible = True
        RUN.Visible = True
        SURE.Visible = True
        ESCAPE.Visible = False

    End Sub

    Private Sub Sword_Click(sender As Object, e As EventArgs) Handles Sword.Click
        Dim S As Integer
        S = SworRand.Next(1, 100)
        If S < 5 Then
            EnemyHealth.Visible = True
            EnemyDodge.Visible = True
            EnemyHealth.Visible = False
            EnemyDodge.Visible = False
            Potion.Visible = False
            Mana.Visible = False
            BACK.Visible = False
            Sword.Visible = False
            PUNCH.Visible = False
            FIRE.Visible = False
            WATER.Visible = False
            RUN.Visible = False
            SURE.Visible = False
            ATTACK.Visible = False
        Else
            If EnemyHealth.Value < 10 Then
                EnemyHealth.Visible = True
                EnemyHealth.Value = EnemyHealth.Value - EnemyHealth.Value
                Potion.Visible = False
                Mana.Visible = False
                BACK.Visible = False
                Sword.Visible = False
                PUNCH.Visible = False
                FIRE.Visible = False
                WATER.Visible = False
                RUN.Visible = False
                SURE.Visible = False
                ATTACK.Visible = False
            Else
                EnemyHealth.Visible = True
                EnemyHealth.Value = EnemyHealth.Value - 10
                Potion.Visible = False
                Mana.Visible = False
                BACK.Visible = False
                Sword.Visible = False
                PUNCH.Visible = False
                FIRE.Visible = False
                WATER.Visible = False
                RUN.Visible = False
                SURE.Visible = False
                ATTACK.Visible = False
            End If
        End If
        DamageTimer.Enabled = True

    End Sub
    Private Sub EnemyAttack()
        Dim EnAt As Integer
        EnAt = EnemAtk.Next(1, 100)
        If EnemyHealth.Value > 0 Then
            If EnAt > 75 Then
                PlayerDodge.Visible = True
            Else
                PlayerHealth.Value = PlayerHealth.Value - 5
            End If
        Else PictureBox3.Visible = False
            EnemyHealth.Visible = False
            EnemyDodge.Visible = False
            WIN1.Visible = True
            WIN2.Visible = True
            WinTimer.Enabled = True
        End If
    End Sub

    Private Sub DamageTimer_Tick(sender As Object, e As EventArgs) Handles DamageTimer.Tick
        Console.WriteLine("Damage Timer_Tick")
        EnemyDodge.Visible = False
        EnemyHealth.Visible = False
        DamageTimer.Enabled = False
        EnemyHealth.Visible = False
        EnemyAttack()
        EnemyDamageTimer.Enabled = True
    End Sub

    Private Sub EnemyDamageTimer_Tick(sender As Object, e As EventArgs) Handles EnemyDamageTimer.Tick
        Console.WriteLine("Enemy Damage Timer_Tick")
        DamageTimer.Enabled = False
        PlayerDodge.Visible = False
        EnemyDodge.Visible = False
        EnemyDamageTimer.Enabled = False
        ATTACK.Visible = True
        MAGIC.Visible = True
        ESCAPE.Visible = True
        ITEM.Visible = True
    End Sub

    Private Sub PUNCH_Click(sender As Object, e As EventArgs) Handles PUNCH.Click
        Dim P As Integer
        P = PunchRand.Next(1, 100)

        If P < 50 Then
            EnemyHealth.Visible = True
            EnemyDodge.Visible = True
            Potion.Visible = False
            Mana.Visible = False
            BACK.Visible = False
            Sword.Visible = False
            PUNCH.Visible = False
            FIRE.Visible = False
            WATER.Visible = False
            RUN.Visible = False
            SURE.Visible = False
            ATTACK.Visible = False
        Else
            If EnemyHealth.Value < 25 Then
                EnemyHealth.Visible = True
                EnemyHealth.Value = EnemyHealth.Value - EnemyHealth.Value
                Potion.Visible = False
                Mana.Visible = False
                BACK.Visible = False
                Sword.Visible = False
                PUNCH.Visible = False
                FIRE.Visible = False
                WATER.Visible = False
                RUN.Visible = False
                SURE.Visible = False
                ATTACK.Visible = False
            Else
                EnemyHealth.Visible = True
                EnemyHealth.Value = EnemyHealth.Value - 25
                Potion.Visible = False
                Mana.Visible = False
                BACK.Visible = False
                Sword.Visible = False
                PUNCH.Visible = False
                FIRE.Visible = False
                WATER.Visible = False
                RUN.Visible = False
                SURE.Visible = False
                ATTACK.Visible = False
            End If
            PunchAniTimer.Enabled = True
        End If
        DamageTimer.Enabled = True
    End Sub

    Private Sub Mana_Click(sender As Object, e As EventArgs) Handles Mana.Click
        PlayerStatus.Visible = True
        Potion.Visible = False
        Mana.Visible = False
        BACK.Visible = False
        Sword.Visible = False
        PUNCH.Visible = False
        FIRE.Visible = False
        WATER.Visible = False
        RUN.Visible = False
        SURE.Visible = False
        ATTACK.Visible = False
        ITEM.Visible = False
        DamageTimer.Enabled = True
    End Sub

    Private Sub Potion_Click(sender As Object, e As EventArgs) Handles Potion.Click
        If PlayerHealth.Value < 50 Then
            PlayerHealth.Value = PlayerHealth.Value + 50
        Else PlayerHealth.Value = 100
        End If
        Potion.Visible = False
        Mana.Visible = False
        BACK.Visible = False
        Sword.Visible = False
        PUNCH.Visible = False
        FIRE.Visible = False
        WATER.Visible = False
        RUN.Visible = False
        SURE.Visible = False
        ATTACK.Visible = False
        ITEM.Visible = False
        DamageTimer.Enabled = True
    End Sub

    Private Sub RUN_Click(sender As Object, e As EventArgs) Handles RUN.Click
        Dim R As Integer
        R = Escapade.Next(1, 100)
        If R > 85 Then
            Run1.Visible = True
            Run2.Visible = True
        Else Dim End2 As New Form1
            Me.Visible = False
            End2.ShowDialog()
            Me.Visible = True
        End If
    End Sub

    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If p.Name = "PictureBox1" And Collision(p, "PictureBox3", other) Then
            PunchAniTimer.Enabled = True
            Return

        End If

    End Sub
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function

    Private Sub PunchAniTimer_Tick(sender As Object, e As EventArgs) Handles PunchAniTimer.Tick
        MoveTo(PictureBox1, 73, -31.6)
        PunchAniTimer2.Enabled = True
        PunchAniTimer.Enabled = False
    End Sub

    Private Sub PunchAniTimer2_Tick(sender As Object, e As EventArgs) Handles PunchAniTimer2.Tick
        MoveTo(PictureBox1, 73, -31.6)
        PunchAniTimer3.Enabled = True
        PunchAniTimer2.Enabled = False
    End Sub

    Private Sub PunchAniTimer3_Tick(sender As Object, e As EventArgs) Handles PunchAniTimer3.Tick
        MoveTo(PictureBox1, 73, -31.6)
        PunchAniTimer4.Enabled = True
        PunchAniTimer3.Enabled = False
    End Sub

    Private Sub PunchAniTimer4_Tick(sender As Object, e As EventArgs) Handles PunchAniTimer4.Tick
        MoveTo(PictureBox1, 73, -31.6)
        PunchAniTimer5.Enabled = True
        PunchAniTimer4.Enabled = False
    End Sub

    Private Sub PunchAniTimer5_Tick(sender As Object, e As EventArgs) Handles PunchAniTimer5.Tick
        MoveTo(PictureBox1, 73, -31.6)
        PunchAniTimer4.Enabled = False
        PunchAniTimer5.Enabled = False
        PunchAfterTimer1.Enabled = True
    End Sub

    Private Sub PunchAfterTimer1_Tick(sender As Object, e As EventArgs) Handles PunchAfterTimer1.Tick
        MoveTo(PictureBox1, -73, 31.6)
        PunchAfterTimer1.Enabled = False
        PunchAfterTimer2.Enabled = True
    End Sub

    Private Sub PunchAfterTimer2_Tick(sender As Object, e As EventArgs) Handles PunchAfterTimer2.Tick
        MoveTo(PictureBox1, -73, 31.6)
        PunchAfterTimer2.Enabled = False
        PunchAfterTimer3.Enabled = True
    End Sub

    Private Sub PunchAfterTimer3_Tick(sender As Object, e As EventArgs) Handles PunchAfterTimer3.Tick
        MoveTo(PictureBox1, -73, 31.6)
        PunchAfterTimer3.Enabled = False
        PunchAfterTimer4.Enabled = True
    End Sub

    Private Sub PunchAfterTimer4_Tick(sender As Object, e As EventArgs) Handles PunchAfterTimer4.Tick
        MoveTo(PictureBox1, -73, 31.6)
        PunchAfterTimer4.Enabled = False
        PunchAfterTimer5.Enabled = True
    End Sub

    Private Sub PunchAfterTimer5_Tick(sender As Object, e As EventArgs) Handles PunchAfterTimer5.Tick
        MoveTo(PictureBox1, -73, 31.6)
        PunchAfterTimer5.Enabled = False
    End Sub

    Private Sub WinTimer_Tick(sender As Object, e As EventArgs) Handles WinTimer.Tick
        WinTimer.Enabled = False
        Dim End2 As New Form1
        Me.Visible = False
        End2.ShowDialog()
        Me.Visible = True
    End Sub
End Class