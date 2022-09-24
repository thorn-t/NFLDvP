Public Class Form1
    Dim STeamDataTable As New DataTable
    Dim weekData As New DataTable

    Private Sub Sleep(ByVal PauseTime As Double)

        Dim Tind As Int16
        For Tind = 1 To PauseTime / 50
            Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STeam.Rows.Add(16)
        'Dim loadedWeeksCount As Integer
        'Dim loadedWeeksToFile As String

        'loadedWeeksCount = 1

        'With week1Data
        '    .Columns.Add("Week", System.Type.GetType("System.String"))
        '    .Columns.Add("Year", System.Type.GetType("System.String"))
        '    .Columns.Add("GID", System.Type.GetType("System.String"))
        '    .Columns.Add("Name", System.Type.GetType("System.String"))
        '    .Columns.Add("Pos", System.Type.GetType("System.String"))
        '    .Columns.Add("Team", System.Type.GetType("System.String"))
        '    .Columns.Add("h/a", System.Type.GetType("System.String"))
        '    .Columns.Add("Oppt", System.Type.GetType("System.String"))
        '    .Columns.Add("DK pts", System.Type.GetType("System.Double"))
        '    .Columns.Add("DK Salary", System.Type.GetType("System.String"))
        'End With

        'Do Until loadedWeeksCount = 17
        '    loadedWeeksToFile = loadedWeeksCount

        '    Dim thereader As New IO.StreamReader("C:\Users\Trevor\Desktop\NFL Data\2017\Week" + loadedWeeksToFile + ".txt", System.Text.Encoding.Default)
        '    Dim sline As String = ""

        '    Do
        '        sline = thereader.ReadLine
        '        If sline Is Nothing Then Exit Do
        '        Dim thecolumns() As String = sline.Split(";")
        '        Dim newrow As DataRow = week1Data.NewRow
        '        newrow("Week") = thecolumns(0)
        '        newrow("Year") = thecolumns(1)
        '        newrow("GID") = thecolumns(2)
        '        newrow("Name") = thecolumns(3)
        '        newrow("Pos") = thecolumns(4)
        '        newrow("Team") = thecolumns(5)
        '        newrow("h/a") = thecolumns(6)
        '        newrow("Oppt") = thecolumns(7)
        '        newrow("DK pts") = thecolumns(8)
        '        newrow("DK Salary") = thecolumns(9)
        '        week1Data.Rows.Add(newrow)
        '    Loop

        '    thereader.Close()

        '    DataGridView1.DataSource = week1Data
        '    loadedWeeksCount += 1
        'Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newview As New DataView(weekData)
        Dim STeamView As New DataView(STeamDataTable)
        Dim criteria As String = "Team = '" & ComboBox1.Text & "'"

3:      newview.Sort = "Pos asc"
        newview.RowFilter = criteria


        DataGridView1.DataSource = newview


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim newRowIndex As Integer = STeam.Rows.Add()

        Dim DefFound As Boolean = False
        Dim QBFound As Boolean = False
        Dim RB1Found As Boolean = False
        Dim RB2Found As Boolean = False
        Dim WR1Found As Boolean = False
        Dim WR2Found As Boolean = False
        Dim WR3Found As Boolean = False
        Dim TEFound As Boolean = False

        i = 0
        Do Until Label1.Text = "" Or i = 16
            Label1.Text = DataGridView1.Rows(i).Cells("Pos").Value

            If Label1.Text = "Def" And DefFound = False Then
                DefFound = True
                STeam.Rows(newRowIndex).Cells("DefPts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                STeam.Rows(newRowIndex).Cells("Def").Value = DataGridView1.Rows(i).Cells("Team").Value
                STeam.Rows(newRowIndex).Cells("VS").Value = DataGridView1.Rows(i).Cells("Oppt").Value
            End If

            If Label1.Text = "QB" And QBFound = False Then
                QBFound = True
                STeam.Rows(newRowIndex).Cells("QBPts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                STeam.Rows(newRowIndex).Cells("QB").Value = DataGridView1.Rows(i).Cells("Name").Value
            End If

            If Label1.Text = "RB" Then
                If RB1Found = True Then
                    If RB2Found = False Then
                        RB2Found = True
                        STeam.Rows(newRowIndex).Cells("RB2Pts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                        STeam.Rows(newRowIndex).Cells("RB2").Value = DataGridView1.Rows(i).Cells("Name").Value
                    End If
                End If
            End If

            If Label1.Text = "RB" Then
                If RB1Found = False Then
                    RB1Found = True
                    STeam.Rows(newRowIndex).Cells("RB1Pts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                    STeam.Rows(newRowIndex).Cells("RB1").Value = DataGridView1.Rows(i).Cells("Name").Value
                End If
            End If

            If Label1.Text = "WR" Then
                If WR1Found = True Then
                    If WR2Found = True Then
                        If WR3Found = False Then
                            WR3Found = True
                            STeam.Rows(newRowIndex).Cells("WR3Pts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                            STeam.Rows(newRowIndex).Cells("WR3").Value = DataGridView1.Rows(i).Cells("Name").Value
                        End If
                    End If
                End If
            End If

            If Label1.Text = "WR" Then
                If WR1Found = True Then
                    If WR2Found = False Then
                        WR2Found = True
                        STeam.Rows(newRowIndex).Cells("WR2Pts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                        STeam.Rows(newRowIndex).Cells("WR2").Value = DataGridView1.Rows(i).Cells("Name").Value
                    End If
                End If
            End If

            If Label1.Text = "WR" Then
                If WR1Found = False Then
                    WR1Found = True
                    STeam.Rows(newRowIndex).Cells("WR1Pts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                    STeam.Rows(newRowIndex).Cells("WR1").Value = DataGridView1.Rows(i).Cells("Name").Value
                End If
            End If

            If Label1.Text = "TE" And TEFound = False Then
                TEFound = True
                STeam.Rows(newRowIndex).Cells("TEPts").Value = DataGridView1.Rows(i).Cells("DK pts").Value
                STeam.Rows(newRowIndex).Cells("TE").Value = DataGridView1.Rows(i).Cells("Name").Value
            End If

            i += 1
        Loop




        'STeam.Rows(newRowIndex).Cells("Def").Value = DataGridView1.Rows(5).Cells("DK pts").Value


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
      
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click

        Dim theData As New OpenData
        Dim newRowIndex As Integer = 0
        Dim weeksDone As Integer = 1


        currentLoadedWeek.Text = 1
        currentRowIndex.Text = 0

        Do Until weeksDone > 17
            DataGridView1.DataSource = theData.load
            theData.sort()
            newRowIndex += 1
            currentRowIndex.Text = newRowIndex
            weeksDone += 1
            currentLoadedWeek.Text = weeksDone
        Loop

        theData.cellStyle()
        currentLoadedWeek.Text = 1


    End Sub
End Class
