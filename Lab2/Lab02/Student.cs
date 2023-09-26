﻿namespace Lab02
{
    internal class Student
    {
        public string StLastName { get; set; }
        public string StFirstName { get; set; }
        public int Grade { get; set; }
        public int Classroom { get; set; }
        public int Bus { get; set; }
        public string TLastName { get; set; }
        public string TFirstName { get; set; }

        public override string ToString()
        {
            string data = "Student LastName:" + StLastName + Environment.NewLine;
            data += "Student FirstName:" + StFirstName + Environment.NewLine;
            data += "Student Grade:" + Grade + Environment.NewLine;
            data += "Student Classroom:" + Classroom + Environment.NewLine;
            data += "Student Bus:" + Bus + Environment.NewLine;
            data += "Teacher LastName:" + TLastName + Environment.NewLine;
            data += "Teacher FirstName:" + TFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringStudentClassTeacher()
        {
            string data = "Student: " + StLastName + " " + StFirstName + Environment.NewLine;
            data += "Student Classroom: " + Classroom + Environment.NewLine;
            data += "Teacher: " + TLastName + " " + TFirstName + Environment.NewLine;
            data += Environment.NewLine;
            return data;
        }
        public string ToStringStudentBus()
        {
            string data = "Student: " + StLastName + " " + StFirstName + Environment.NewLine;
            data += "Bus: " + Bus + Environment.NewLine;
            data += Environment.NewLine;
            return data;
        }
        public string ToStringStudentTeacher()
        {
            string data = "Student: " + StLastName + " " + StFirstName + Environment.NewLine;
            data += "Teacher: " + TLastName + " " + TFirstName + Environment.NewLine;
            data += Environment.NewLine;
            return data;
        }
        public string ToStringBusStudent()
        {
            string data = "Student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringGradeStudent()
        {
            string data = "Student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringClassStudent()
        {
            string data = "Student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringClassTaecher()
        {
            string data = "Teacher: " + TLastName + " " + TFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringGradeTaecher()
        {
            string data = "Teacher: " + TLastName + " " + TFirstName + Environment.NewLine;
            return data;
        }
    }
}