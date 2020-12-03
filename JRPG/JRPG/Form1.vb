Public Class Form1
    Dim YOffset As Integer
    Dim R As New Random


    Sub Move(p As PictureBox, X As Integer, Y As Integer)
        p.Location = New Point(p.Location.X + X, p.Location.Y + Y)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                Me.Refresh()
            Case Keys.W, Keys.Up
                YOffset = 20

            'Case Keys.S, Keys.Down


            Case Keys.A, Keys.Left
                MoveTo(PictureBox1, -7, 0)
                MoveTo(ATTACK, -7, 0)
            Case Keys.D, Keys.Right
                MoveTo(PictureBox1, 7, 0)
                MoveTo(ATTACK, 7, 0)
            Case Keys.Space
                If ATTACK.Visible = True Then
                    Dim F As New Form2
                    Me.Visible = False
                    F.ShowDialog()
                    Me.Visible = True
                End If
        End Select

    End Sub
    Sub Follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub Chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -10
        Else
            x = 10
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 0
        Else
            y = 0
        End If
        MoveTo(p, x, y)
    End Sub





    'Return true or false if moving to the new location is clear of objects ending with t
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
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If p.Name = "PictureBox1" And Collision(p, "ENEMY", other) Then
            ATTACK.Visible = True
        Else ATTACK.Visible = False

            Return

        End If

    End Sub

    Private Sub Gravity_Tick(sender As Object, e As EventArgs) Handles Gravity.Tick
        MoveTo(PictureBox1, 0, 10 - YOffset)
        If YOffset > 0 Then
            YOffset -= 1

        End If
    End Sub

    Private Sub EnemyTimer_Tick(sender As Object, e As EventArgs) Handles EnemyTimer.Tick
        Dim X As Integer
        X = R.Next(-25, 25)
        MoveTo(ENEMY, X, 0)
    End Sub





    'Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub BulletTimer_Tick(sender As Object, e As EventArgs) Handles BulletTimer.Tick
    'MoveTo(PictureBox3, 0, -50)
    'End Sub
End Class
