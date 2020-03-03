Public Class Form1
    Public stu As ClsStudent
    Public stuTech As ClsTechnology
    Public tempArray1() As Integer
    Public tempArray2() As Integer

    Private Sub btn_insertStudent_Click(sender As Object, e As EventArgs) Handles btn_insertStudent.Click
        stu = New ClsStudent(txt_id.Text, txt_name.Text, DateTimePicker1.Text)
        stu.insertSubjectMark()
        stu.caculate_average()
        stu.caculate_result()

        DataGridView1.Rows.Add(txt_id.Text, txt_name.Text, DateTimePicker1.Text, " ", " ", stu._avg, stu._result)

    End Sub

    Private Sub btn_insertTechStudent_Click(sender As Object, e As EventArgs) Handles btn_insertTechStudent.Click
        tempArray1 = {Val(txt_mark1.Text), Val(txt_mark2.Text), Val(txt_mark3.Text), Val(txt_mark4.Text)}
        tempArray2 = {Val(txt_mark5.Text), Val(txt_mark6.Text), Val(txt_mark7.Text), Val(txt_mark8.Text)}

        stuTech = New ClsTechnology(txt_id.Text, txt_name.Text, DateTimePicker1.Text, tempArray1, tempArray2)
        stuTech.averageCompulsary()
        stuTech.averageBasic()
        stuTech.caculate_average()
        stuTech.caculate_result()

        DataGridView1.Rows.Add(txt_id.Text, txt_name.Text, DateTimePicker1.Text, stuTech._avg1, stuTech._avg2, stuTech._avg, stuTech._result)

    End Sub

    Private Sub btu_exit_Click(sender As Object, e As EventArgs) Handles btu_exit.Click
        End
    End Sub
End Class
