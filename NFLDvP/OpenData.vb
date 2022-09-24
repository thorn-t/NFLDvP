Public Class OpenData

    Dim currentWeek As String


    Private Sub Sleep(ByVal PauseTime As Double)

        Dim Tind As Int16
        For Tind = 1 To PauseTime / 50
            Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next

    End Sub

    Public Function load()
        Dim weekData As New DataTable
        Dim currentYear As String

        currentWeek = Form1.currentLoadedWeek.Text
        currentYear = Form1.currentLoadedYear.Text

        'makes data table and then loads it from file
        With weekData
            .Columns.Add("Week", System.Type.GetType("System.String"))
            .Columns.Add("Year", System.Type.GetType("System.String"))
            .Columns.Add("GID", System.Type.GetType("System.String"))
            .Columns.Add("Name", System.Type.GetType("System.String"))
            .Columns.Add("Pos", System.Type.GetType("System.String"))
            .Columns.Add("Team", System.Type.GetType("System.String"))
            .Columns.Add("h/a", System.Type.GetType("System.String"))
            .Columns.Add("Oppt", System.Type.GetType("System.String"))
            .Columns.Add("DK pts", System.Type.GetType("System.Double"))
            .Columns.Add("DK Salary", System.Type.GetType("System.String"))
        End With

        Dim thereader As New IO.StreamReader("C:\NFL Data\" + currentYear + "\week" + currentWeek + ".txt", System.Text.Encoding.Default)
        Dim sline As String = ""

        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim thecolumns() As String = sline.Split(";")
            Dim newrow As DataRow = weekData.NewRow
            newrow("Week") = thecolumns(0)
            newrow("Year") = thecolumns(1)
            newrow("GID") = thecolumns(2)
            newrow("Name") = thecolumns(3)
            newrow("Pos") = thecolumns(4)
            newrow("Team") = thecolumns(5)
            newrow("h/a") = thecolumns(6)
            newrow("Oppt") = thecolumns(7)
            newrow("DK pts") = thecolumns(8)
            newrow("DK Salary") = thecolumns(9)
            weekData.Rows.Add(newrow)
        Loop

        thereader.Close()
        'sorts loaded data
        Dim sortedData As New DataView(weekData)
        Dim criteria As String = "Team = '" & Form1.ComboBox1.Text & "'"
        sortedData.Sort = "Pos asc"
        sortedData.RowFilter = criteria
        Form1.weekDataGrid.DataSource = sortedData

        If Form1.weekDataGrid.RowCount < 2 Then

        Else
            'grabs oppenent for weekly data from table
            Form1.weekDataGrid.DataSource = sortedData
            Form1.ComboBox2.Text = Form1.weekDataGrid.Rows(1).Cells("Oppt").Value

            'resorts sorted loaded data to get the opponent the selected team played that days stats
            Dim criteria2 As String = "Team = '" & Form1.ComboBox2.Text & "'"
            sortedData.Sort = "Pos asc, DK Salary desc"
            sortedData.RowFilter = criteria2
        End If
        

        Return sortedData
    End Function

    Public Sub sort()
        Dim DefFound As New Boolean

        Dim QBFound As New Boolean
        Dim RB1Found As New Boolean
        Dim RB2Found As New Boolean
        Dim WR1Found As New Boolean
        Dim WR2Found As New Boolean
        Dim WR3Found As New Boolean
        Dim TEFound As New Boolean
        Dim i As Integer
        Dim currentRow As Integer

        DefFound = False
        QBFound = False
        RB1Found = False
        RB2Found = False
        WR1Found = False
        WR2Found = False
        WR3Found = False
        TEFound = False

        currentRow = Form1.currentRowIndex.Text

        Form1.STeam.Rows(currentRow).Cells("Week").Value = currentWeek

        i = 0
        Form1.Label1.Text = "a"
        Do Until Form1.Label1.Text = "" Or i = 16
            If Form1.weekDataGrid.RowCount < 2 Then
                Form1.STeam.Rows(currentRow).Cells("DefPts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("VS").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("QBPts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("QB").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("RB2Pts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("RB2").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("RB1Pts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("RB1").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR3Pts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR3").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR2Pts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR2").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR2Pts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR2").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR1Pts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("WR1").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("TEPts").Value = "bye"
                Form1.STeam.Rows(currentRow).Cells("TE").Value = "bye"

            Else
                Form1.Label1.Text = Form1.DataGridView1.Rows(i).Cells("Pos").Value

                If Form1.Label1.Text = "Def" And DefFound = False Then
                    DefFound = True
                    Form1.STeam.Rows(currentRow).Cells("DefPts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                    Form1.STeam.Rows(currentRow).Cells("VS").Value = Form1.DataGridView1.Rows(i).Cells("Team").Value
                End If

                If Form1.Label1.Text = "QB" And QBFound = False Then
                    QBFound = True
                    Form1.STeam.Rows(currentRow).Cells("QBPts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                    Form1.STeam.Rows(currentRow).Cells("QB").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                End If

                If Form1.Label1.Text = "RB" Then
                    If RB1Found = True Then
                        If RB2Found = False Then
                            RB2Found = True
                            Form1.STeam.Rows(currentRow).Cells("RB2Pts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                            Form1.STeam.Rows(currentRow).Cells("RB2").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                        End If
                    End If
                End If

                If Form1.Label1.Text = "RB" Then
                    If RB1Found = False Then
                        RB1Found = True
                        Form1.STeam.Rows(currentRow).Cells("RB1Pts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                        Form1.STeam.Rows(currentRow).Cells("RB1").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                    End If
                End If

                If Form1.Label1.Text = "WR" Then
                    If WR1Found = True Then
                        If WR2Found = True Then
                            If WR3Found = False Then
                                WR3Found = True
                                Form1.STeam.Rows(currentRow).Cells("WR3Pts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                                Form1.STeam.Rows(currentRow).Cells("WR3").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                            End If
                        End If
                    End If
                End If

                If Form1.Label1.Text = "WR" Then
                    If WR1Found = True Then
                        If WR2Found = False Then
                            WR2Found = True
                            Form1.STeam.Rows(currentRow).Cells("WR2Pts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                            Form1.STeam.Rows(currentRow).Cells("WR2").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                        End If
                    End If
                End If

                If Form1.Label1.Text = "WR" Then
                    If WR1Found = False Then
                        WR1Found = True
                        Form1.STeam.Rows(currentRow).Cells("WR1Pts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                        Form1.STeam.Rows(currentRow).Cells("WR1").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                    End If
                End If

                If Form1.Label1.Text = "TE" And TEFound = False Then
                    TEFound = True
                    Form1.STeam.Rows(currentRow).Cells("TEPts").Value = Form1.DataGridView1.Rows(i).Cells("DK pts").Value
                    Form1.STeam.Rows(currentRow).Cells("TE").Value = Form1.DataGridView1.Rows(i).Cells("Name").Value
                End If




            End If

            i += 1
            
        Loop
    End Sub


    Public Sub cellStyle()
        Dim currentRow As Integer
        Dim currentCell(7) As Integer
        Dim cellCounter As Integer

        currentCell = {3, 5, 7, 9, 11, 13, 15, 16}
        currentRow = 0
        cellCounter = 0

        Do Until currentRow = 17
            For i = 1 To 16
                Form1.STeam.Rows(currentRow).Cells(i).Style.BackColor = Color.White
            Next

            currentRow += 1
        Loop

        currentRow = 0

        Do Until currentRow = 17

            Do Until cellCounter = 8
                If Double.TryParse(Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Value, Nothing) Then
                    If Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Value < 15 Then
                        Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Style.BackColor = Color.FromArgb(255, 235, 236)
                    End If

                    If Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Value >= 15 Then
                        Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Style.BackColor = Color.FromArgb(222, 240, 216)
                    End If
                    
                    If Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Value > 20 Then
                        Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Style.BackColor = Color.FromArgb(177, 209, 172)
                    End If
                Else
                    For i = 1 To 16

                        Form1.STeam.Rows(currentRow).Cells(i).Style.BackColor = Color.LightGray
                    Next
                    ' Form1.STeam.Rows(currentRow).Cells(currentCell(cellCounter)).Style.BackColor = Color.LightGray

                End If
                cellCounter += 1
            Loop
            cellCounter = 0
            currentRow += 1
        Loop
        

    End Sub
End Class
