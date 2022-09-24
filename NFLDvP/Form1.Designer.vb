<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.STeam = New System.Windows.Forms.DataGridView()
        Me.Week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QBPts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RB1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RB1Pts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RB2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RB2Pts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WR1Pts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WR2Pts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WR3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WR3Pts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEPts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefPts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.currentLoadedWeek = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.weekDataGrid = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.currentRowIndex = New System.Windows.Forms.Label()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.currentLoadedYear = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weekDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 655)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(664, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 626)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"ari", "atl", "bal", "buf", "car", "chi", "cin", "cle", "dal", "den", "det", "gnb", "hou", "ind", "jac", "kan", "lac", "lar", "mia", "min", "nor", "nwe", "nyg", "nyj", "oak", "phi", "pit", "sea", "sfo", "tam", "ten", "was"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "ari"
        '
        'STeam
        '
        Me.STeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STeam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.STeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STeam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Week, Me.Vs, Me.QB, Me.QBPts, Me.RB1, Me.RB1Pts, Me.RB2, Me.RB2Pts, Me.WR1, Me.WR1Pts, Me.WR2, Me.WR2Pts, Me.WR3, Me.WR3Pts, Me.TE, Me.TEPts, Me.DefPts})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.STeam.DefaultCellStyle = DataGridViewCellStyle4
        Me.STeam.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.STeam.Location = New System.Drawing.Point(12, 39)
        Me.STeam.Name = "STeam"
        Me.STeam.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.STeam.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.STeam.Size = New System.Drawing.Size(1363, 397)
        Me.STeam.TabIndex = 3
        '
        'Week
        '
        Me.Week.HeaderText = "Week"
        Me.Week.Name = "Week"
        Me.Week.ReadOnly = True
        '
        'Vs
        '
        Me.Vs.HeaderText = "Vs"
        Me.Vs.Name = "Vs"
        Me.Vs.ReadOnly = True
        '
        'QB
        '
        Me.QB.HeaderText = "QB"
        Me.QB.Name = "QB"
        Me.QB.ReadOnly = True
        '
        'QBPts
        '
        Me.QBPts.HeaderText = "Pts"
        Me.QBPts.Name = "QBPts"
        Me.QBPts.ReadOnly = True
        '
        'RB1
        '
        Me.RB1.HeaderText = "RB1"
        Me.RB1.Name = "RB1"
        Me.RB1.ReadOnly = True
        '
        'RB1Pts
        '
        Me.RB1Pts.HeaderText = "Pts"
        Me.RB1Pts.Name = "RB1Pts"
        Me.RB1Pts.ReadOnly = True
        '
        'RB2
        '
        Me.RB2.HeaderText = "RB2"
        Me.RB2.Name = "RB2"
        Me.RB2.ReadOnly = True
        '
        'RB2Pts
        '
        Me.RB2Pts.HeaderText = "Pts"
        Me.RB2Pts.Name = "RB2Pts"
        Me.RB2Pts.ReadOnly = True
        '
        'WR1
        '
        Me.WR1.HeaderText = "WR1"
        Me.WR1.Name = "WR1"
        Me.WR1.ReadOnly = True
        '
        'WR1Pts
        '
        Me.WR1Pts.HeaderText = "Pts"
        Me.WR1Pts.Name = "WR1Pts"
        Me.WR1Pts.ReadOnly = True
        '
        'WR2
        '
        Me.WR2.HeaderText = "WR2"
        Me.WR2.Name = "WR2"
        Me.WR2.ReadOnly = True
        '
        'WR2Pts
        '
        Me.WR2Pts.HeaderText = "Pts"
        Me.WR2Pts.Name = "WR2Pts"
        Me.WR2Pts.ReadOnly = True
        '
        'WR3
        '
        Me.WR3.HeaderText = "WR3"
        Me.WR3.Name = "WR3"
        Me.WR3.ReadOnly = True
        '
        'WR3Pts
        '
        Me.WR3Pts.HeaderText = "Pts"
        Me.WR3Pts.Name = "WR3Pts"
        Me.WR3Pts.ReadOnly = True
        '
        'TE
        '
        Me.TE.HeaderText = "TE"
        Me.TE.Name = "TE"
        Me.TE.ReadOnly = True
        '
        'TEPts
        '
        Me.TEPts.HeaderText = "Pts"
        Me.TEPts.Name = "TEPts"
        Me.TEPts.ReadOnly = True
        '
        'DefPts
        '
        Me.DefPts.HeaderText = "Def Pts"
        Me.DefPts.Name = "DefPts"
        Me.DefPts.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(493, 629)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(767, 626)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(955, 626)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'currentLoadedWeek
        '
        Me.currentLoadedWeek.AutoSize = True
        Me.currentLoadedWeek.Location = New System.Drawing.Point(394, 629)
        Me.currentLoadedWeek.Name = "currentLoadedWeek"
        Me.currentLoadedWeek.Size = New System.Drawing.Size(13, 13)
        Me.currentLoadedWeek.TabIndex = 7
        Me.currentLoadedWeek.Text = "1"
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(266, 9)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 21)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'weekDataGrid
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.weekDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.weekDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.weekDataGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.weekDataGrid.Location = New System.Drawing.Point(682, 655)
        Me.weekDataGrid.Name = "weekDataGrid"
        Me.weekDataGrid.Size = New System.Drawing.Size(693, 150)
        Me.weekDataGrid.TabIndex = 12
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(1107, 626)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'currentRowIndex
        '
        Me.currentRowIndex.AutoSize = True
        Me.currentRowIndex.Location = New System.Drawing.Point(465, 629)
        Me.currentRowIndex.Name = "currentRowIndex"
        Me.currentRowIndex.Size = New System.Drawing.Size(13, 13)
        Me.currentRowIndex.TabIndex = 14
        Me.currentRowIndex.Text = "0"
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(DFSSilver.Form1)
        '
        'Form1BindingSource1
        '
        Me.Form1BindingSource1.DataSource = GetType(DFSSilver.Form1)
        '
        'currentLoadedYear
        '
        Me.currentLoadedYear.FormattingEnabled = True
        Me.currentLoadedYear.ItemHeight = 13
        Me.currentLoadedYear.Items.AddRange(New Object() {"2017", "2018"})
        Me.currentLoadedYear.Location = New System.Drawing.Point(139, 10)
        Me.currentLoadedYear.Name = "currentLoadedYear"
        Me.currentLoadedYear.Size = New System.Drawing.Size(121, 21)
        Me.currentLoadedYear.TabIndex = 15
        Me.currentLoadedYear.Text = "2018"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 444)
        Me.Controls.Add(Me.currentLoadedYear)
        Me.Controls.Add(Me.currentRowIndex)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.weekDataGrid)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.currentLoadedWeek)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.STeam)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "DFS Silver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weekDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents STeam As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents currentLoadedWeek As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents Form1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Form1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents weekDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents currentRowIndex As System.Windows.Forms.Label
    Friend WithEvents Week As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QBPts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RB1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RB1Pts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RB2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RB2Pts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WR1Pts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WR2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WR2Pts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WR3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WR3Pts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEPts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefPts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currentLoadedYear As System.Windows.Forms.ComboBox

End Class
