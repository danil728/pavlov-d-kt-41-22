﻿namespace pavlov_d_kt_41_22.Models
{
    public class Department //Кафедра
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int HeadTeacherId { get; set; }  // ID заведующего кафедрой

        public Teacher HeadTeacher { get; set; }
    }
}