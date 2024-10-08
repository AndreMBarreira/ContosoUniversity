﻿using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;

namespace ContosoUniversity.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ContosoUniversityContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ContosoUniversityContext>>()))
        {
            // Look for any movies.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }
            context.Student.AddRange(
                new Student
                {
                    FirstMidName = "Carson",
                    LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01")
                },
                new Student
                {
                    FirstMidName = "Meredith",
                    LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {
                    FirstMidName = "Arturo",
                    LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01")
                },
                new Student
                {
                    FirstMidName = "Gytis",
                    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {
                    FirstMidName = "Yan",
                    LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {
                    FirstMidName = "Peggy",
                    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01")
                },
                new Student
                {
                    FirstMidName = "Laura",
                    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01")
                },
                new Student
                {
                    FirstMidName = "Nino",
                    LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01")
                }
            );

            // Look for any instructos.
            if (context.Instructors.Any())
            {
                return;   // DB has been seeded
            }
            context.Instructors.AddRange(
                new Instructor
                {
                    FirstMidName = "Kim",
                    LastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11")
                },
                new Instructor
                {
                    FirstMidName = "Fadi",
                    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06")
                },
                new Instructor
                {
                    FirstMidName = "Roger",
                    LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01")
                },
                new Instructor
                {
                    FirstMidName = "Candace",
                    LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15")
                },
                new Instructor
                {
                    FirstMidName = "Roger",
                    LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12")
                });

            context.SaveChanges();

            // Look for any department.
            if (context.Departments.Any())
            {
                return;   // DB has been seeded
            }
            context.Departments.AddRange(
                new Department
                {
                    Name = "English",
                    Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
                },
                new Department
                {
                    Name = "Mathematics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").ID
                },
                new Department
                {
                    Name = "Engineering",
                    Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                },
                new Department
                {
                    Name = "Economics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").ID
                }
                );

            context.SaveChanges();

            // Look for any instructos.
            if (context.Course.Any())
            {
                return;   // DB has been seeded
            }
            context.Course.AddRange(
                new Course
                {
                    CourseID = 1050,
                    Title = "Chemistry",
                    Credits = 3,
                    DepartmentID = context.Departments.Single(s => s.Name == "Engineering").DepartmentID
                },
                new Course
                {
                    CourseID = 4022,
                    Title = "Microeconomics",
                    Credits = 3,
                    DepartmentID = context.Departments.Single(s => s.Name == "Economics").DepartmentID
                },
                new Course
                {
                    CourseID = 4041,
                    Title = "Macroeconomics",
                    Credits = 3,
                    DepartmentID = context.Departments.Single(s => s.Name == "Economics").DepartmentID
                },
                new Course
                {
                    CourseID = 1045,
                    Title = "Calculus",
                    Credits = 4,
                    DepartmentID = context.Departments.Single(s => s.Name == "Mathematics").DepartmentID
                },
                new Course
                {
                    CourseID = 3141,
                    Title = "Trigonometry",
                    Credits = 4,
                    DepartmentID = context.Departments.Single(s => s.Name == "Mathematics").DepartmentID
                },
                new Course
                {
                    CourseID = 2021,
                    Title = "Composition",
                    Credits = 3,
                    DepartmentID = context.Departments.Single(s => s.Name == "English").DepartmentID
                },
                new Course
                {
                    CourseID = 2042,
                    Title = "Literature",
                    Credits = 4,
                    DepartmentID = context.Departments.Single(s => s.Name == "English").DepartmentID
                });
            context.SaveChanges();

            // Look for any instructos.
            if (context.OfficeAssignments.Any())
            {
                return;   // DB has been seeded
            }
            context.OfficeAssignments.AddRange(
                new OfficeAssignment
                {
                    InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").ID,
                    Location = "Smith 17"
                },
                new OfficeAssignment
                {
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID,
                    Location = "Gowan 27"
                },
                new OfficeAssignment
                {
                    InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").ID,
                    Location = "Thompson 304"
                });

            // Look for any instructos.
            if (context.CourseAssignments.Any())
            {
                return;   // DB has been seeded
            }
            context.CourseAssignments.AddRange(
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Chemistry").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Chemistry").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Microeconomics").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Macroeconomics").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Calculus").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Trigonometry").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Composition").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
                },
                new CourseAssignment
                {
                    CourseID = context.Course.Single(c => c.Title == "Literature").CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
                }
                );

            // Look for any instructos.
            if (context.Enrollment.Any())
            {
                return;   // DB has been seeded
            }
            context.Enrollment.AddRange(
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Alexander").ID,
                        CourseID = context.Course.Single(c => c.Title == "Chemistry").CourseID,
                        Grade = Grade.A
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Alexander").ID,
                        CourseID = context.Course.Single(c => c.Title == "Microeconomics").CourseID,
                        Grade = Grade.C
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Alexander").ID,
                        CourseID = context.Course.Single(c => c.Title == "Macroeconomics").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Alonso").ID,
                        CourseID = context.Course.Single(c => c.Title == "Calculus").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Alonso").ID,
                        CourseID = context.Course.Single(c => c.Title == "Trigonometry").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Alonso").ID,
                        CourseID = context.Course.Single(c => c.Title == "Composition").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Anand").ID,
                        CourseID = context.Course.Single(c => c.Title == "Chemistry").CourseID
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Anand").ID,
                        CourseID = context.Course.Single(c => c.Title == "Microeconomics").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Barzdukas").ID,
                        CourseID = context.Course.Single(c => c.Title == "Chemistry").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Li").ID,
                        CourseID = context.Course.Single(c => c.Title == "Composition").CourseID,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        StudentID = context.Student.Single(s => s.LastName == "Justice").ID,
                        CourseID = context.Course.Single(c => c.Title == "Literature").CourseID,
                        Grade = Grade.B
                    });

                context.SaveChanges();
        }
    }
}