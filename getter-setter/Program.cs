using System;
using StudentData;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo đối tượng Student
        Student student = new Student();

        // Thiết lập thông tin sinh viên qua Setter
        student.Name = "John Doe";
        student.Age = 25; // Hợp lệ
        student.Grade = 8.5;   
        student.PrintInfo();      

        // Thử thiết lập giá trị không hợp lệ cho Age
        student.Age = -5; // Không hợp lệ, sẽ in thông báo lỗi

        // In thông tin sinh viên
        student.PrintInfo();
    }
}
