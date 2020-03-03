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
        Me.btn_insertStudent = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_mark5 = New System.Windows.Forms.TextBox()
        Me.txt_mark6 = New System.Windows.Forms.TextBox()
        Me.txt_mark7 = New System.Windows.Forms.TextBox()
        Me.txt_mark8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_mark1 = New System.Windows.Forms.TextBox()
        Me.txt_mark2 = New System.Windows.Forms.TextBox()
        Me.txt_mark3 = New System.Windows.Forms.TextBox()
        Me.txt_mark4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_insertTechStudent = New System.Windows.Forms.Button()
        Me.btu_exit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcAvg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mbAVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_insertStudent
        '
        Me.btn_insertStudent.Location = New System.Drawing.Point(32, 191)
        Me.btn_insertStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertStudent.Name = "btn_insertStudent"
        Me.btn_insertStudent.Size = New System.Drawing.Size(118, 30)
        Me.btn_insertStudent.TabIndex = 0
        Me.btn_insertStudent.Text = "اضافة طالب"
        Me.btn_insertStudent.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(586, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات الطالب"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(26, 38)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(266, 40)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(76, 20)
        Me.txt_name.TabIndex = 4
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(431, 40)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(76, 20)
        Me.txt_id.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "تاريخ الميلاد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "اسم الطالب"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(526, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الطالب"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 131)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(572, 263)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "طالب الفرع التكنولوجي"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_mark5)
        Me.GroupBox4.Controls.Add(Me.txt_mark6)
        Me.GroupBox4.Controls.Add(Me.txt_mark7)
        Me.GroupBox4.Controls.Add(Me.txt_mark8)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(47, 41)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(225, 203)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "المباحث الأساسية"
        '
        'txt_mark5
        '
        Me.txt_mark5.Location = New System.Drawing.Point(26, 31)
        Me.txt_mark5.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark5.Name = "txt_mark5"
        Me.txt_mark5.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark5.TabIndex = 10
        '
        'txt_mark6
        '
        Me.txt_mark6.Location = New System.Drawing.Point(26, 72)
        Me.txt_mark6.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark6.Name = "txt_mark6"
        Me.txt_mark6.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark6.TabIndex = 12
        '
        'txt_mark7
        '
        Me.txt_mark7.Location = New System.Drawing.Point(26, 114)
        Me.txt_mark7.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark7.Name = "txt_mark7"
        Me.txt_mark7.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark7.TabIndex = 14
        '
        'txt_mark8
        '
        Me.txt_mark8.Location = New System.Drawing.Point(26, 154)
        Me.txt_mark8.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark8.Name = "txt_mark8"
        Me.txt_mark8.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark8.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 157)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "الإدارة والريادة"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 37)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "الاتصالات والالكترونيات"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "التربية الدينية"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 118)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "الثقافة العلمية"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_mark1)
        Me.GroupBox3.Controls.Add(Me.txt_mark2)
        Me.GroupBox3.Controls.Add(Me.txt_mark3)
        Me.GroupBox3.Controls.Add(Me.txt_mark4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(311, 41)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(225, 203)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "المباحث الإجبارية"
        '
        'txt_mark1
        '
        Me.txt_mark1.Location = New System.Drawing.Point(32, 33)
        Me.txt_mark1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark1.Name = "txt_mark1"
        Me.txt_mark1.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark1.TabIndex = 6
        '
        'txt_mark2
        '
        Me.txt_mark2.Location = New System.Drawing.Point(32, 75)
        Me.txt_mark2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark2.Name = "txt_mark2"
        Me.txt_mark2.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark2.TabIndex = 7
        '
        'txt_mark3
        '
        Me.txt_mark3.Location = New System.Drawing.Point(32, 116)
        Me.txt_mark3.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark3.Name = "txt_mark3"
        Me.txt_mark3.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark3.TabIndex = 8
        '
        'txt_mark4
        '
        Me.txt_mark4.Location = New System.Drawing.Point(32, 157)
        Me.txt_mark4.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mark4.Name = "txt_mark4"
        Me.txt_mark4.Size = New System.Drawing.Size(76, 20)
        Me.txt_mark4.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 159)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "اللغة الانجليزية"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "البرمجة والأتمتة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "الرياضيات"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 119)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "اللغة العربية"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_insertTechStudent
        '
        Me.btn_insertTechStudent.Location = New System.Drawing.Point(32, 240)
        Me.btn_insertTechStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertTechStudent.Name = "btn_insertTechStudent"
        Me.btn_insertTechStudent.Size = New System.Drawing.Size(118, 24)
        Me.btn_insertTechStudent.TabIndex = 3
        Me.btn_insertTechStudent.Text = "اضافة طالب تكنولوجي"
        Me.btn_insertTechStudent.UseVisualStyleBackColor = True
        '
        'btu_exit
        '
        Me.btu_exit.Location = New System.Drawing.Point(32, 290)
        Me.btu_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btu_exit.Name = "btu_exit"
        Me.btu_exit.Size = New System.Drawing.Size(118, 24)
        Me.btu_exit.TabIndex = 4
        Me.btu_exit.Text = "خروج"
        Me.btu_exit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.name, Me.birthDate, Me.mcAvg, Me.mbAVG, Me.avg, Me.result})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 398)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 122)
        Me.DataGridView1.TabIndex = 5
        '
        'id
        '
        Me.id.HeaderText = "الرقم"
        Me.id.Name = "id"
        '
        'name
        '
        Me.name.HeaderText = "الاسم"
        Me.name.Name = "name"
        '
        'birthDate
        '
        Me.birthDate.HeaderText = "تاريخ الميلاد"
        Me.birthDate.Name = "birthDate"
        '
        'mcAvg
        '
        Me.mcAvg.HeaderText = "معدل المباحث الاجبارية"
        Me.mcAvg.Name = "mcAvg"
        '
        'mbAVG
        '
        Me.mbAVG.HeaderText = "معدل المباحث الاساسية"
        Me.mbAVG.Name = "mbAVG"
        '
        'avg
        '
        Me.avg.HeaderText = "المعدل العام"
        Me.avg.Name = "avg"
        '
        'result
        '
        Me.result.HeaderText = "النتيجة"
        Me.result.Name = "result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 531)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btu_exit)
        Me.Controls.Add(Me.btn_insertTechStudent)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_insertStudent)
        Me.Margin = New System.Windows.Forms.Padding(2)
        'Me.name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_insertStudent As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_mark5 As TextBox
    Friend WithEvents txt_mark6 As TextBox
    Friend WithEvents txt_mark7 As TextBox
    Friend WithEvents txt_mark8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_mark1 As TextBox
    Friend WithEvents txt_mark2 As TextBox
    Friend WithEvents txt_mark3 As TextBox
    Friend WithEvents txt_mark4 As TextBox
    Friend WithEvents btn_insertTechStudent As Button
    Friend WithEvents btu_exit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents birthDate As DataGridViewTextBoxColumn
    Friend WithEvents mcAvg As DataGridViewTextBoxColumn
    Friend WithEvents mbAVG As DataGridViewTextBoxColumn
    Friend WithEvents avg As DataGridViewTextBoxColumn
    Friend WithEvents result As DataGridViewTextBoxColumn
End Class
