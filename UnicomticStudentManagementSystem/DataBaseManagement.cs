using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace StudentManagementSystem
{
    public static class DatabaseManagement
    {
        private static readonly string dbDirectory = "DATABASE";
        private static readonly string dbFileName = "unicomtic.db";
        private static readonly string fullPath = Path.Combine(dbDirectory, dbFileName);
        private static readonly string dbPath = $"Data Source={fullPath}";

        public static void InitializeDatabase()
        {
            try
            {
                if (!Directory.Exists(dbDirectory))
                    Directory.CreateDirectory(dbDirectory);

                if (!File.Exists(fullPath))
                    SQLiteConnection.CreateFile(fullPath);

                using (var connection = new SQLiteConnection(dbPath))
                {
                    connection.Open();
                    CreateTables(connection);
                    InsertDefaultUsersIfNeeded(connection);
                    InsertDefaultRoomsIfNeeded(connection);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database Initialization Error: " + ex.Message);
            }
        }

        private static void CreateTables(SQLiteConnection connection)
        {
            string[] queries =
            {
        @"
        CREATE TABLE IF NOT EXISTS UserDetails (
            UserId INTEGER PRIMARY KEY AUTOINCREMENT,
            UserName TEXT NOT NULL,
            UserPassword TEXT NOT NULL,
            UserRole TEXT NOT NULL
        );",

        @"
        CREATE TABLE IF NOT EXISTS StudentCourse (
            StuCourseId INTEGER PRIMARY KEY AUTOINCREMENT,
            StuCourseName TEXT NOT NULL
        );",

        @"
        CREATE TABLE IF NOT EXISTS StuSubject (
            StuSubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
            StuSubjectName TEXT NOT NULL,
            StuCourseId INTEGER,
            FOREIGN KEY(StuCourseId) REFERENCES StudentCourse(StuCourseId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS StudentDetails (
            StuId INTEGER PRIMARY KEY AUTOINCREMENT,
            StuName TEXT NOT NULL,
            StuCourseId INTEGER,
            FOREIGN KEY(StuCourseId) REFERENCES StudentCourse(StuCourseId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS StuExam (
            ExamId INTEGER PRIMARY KEY AUTOINCREMENT,
            ExamName TEXT NOT NULL,
            StuSubjectId INTEGER,
            FOREIGN KEY(StuSubjectId) REFERENCES StuSubject(StuSubjectId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS StuScore (
            StuId INTEGER,
            ExamId INTEGER,
            Score INTEGER,
            PRIMARY KEY (StuId, ExamId),
            FOREIGN KEY(StuId) REFERENCES StudentDetails(StuId),
            FOREIGN KEY(ExamId) REFERENCES StuExam(ExamId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS SubRoom (
            RoomId INTEGER PRIMARY KEY AUTOINCREMENT,
            RoomName TEXT NOT NULL,
            RoomType TEXT NOT NULL
        );",

        @"
        CREATE TABLE IF NOT EXISTS SubTimetable (
            TimetableId INTEGER PRIMARY KEY AUTOINCREMENT,
            StuSubjectId INTEGER,
            SubTimeslot TEXT NOT NULL,
            RoomId INTEGER,
            FOREIGN KEY(StuSubjectId) REFERENCES StuSubject(StuSubjectId),
            FOREIGN KEY(RoomId) REFERENCES SubRoom(RoomId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS LecturerDetails (
            LectureId INTEGER PRIMARY KEY AUTOINCREMENT,
            LectureName TEXT NOT NULL,
            SubjectName TEXT NOT NULL
        );",

        @"
        CREATE TABLE IF NOT EXISTS LecturerSubjects (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            LectureId INTEGER,
            StuSubjectId INTEGER,
            FOREIGN KEY(LectureId) REFERENCES LecturerDetails(LectureId),
            FOREIGN KEY(StuSubjectId) REFERENCES StuSubject(StuSubjectId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS StudentSubjects (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            StuId INTEGER,
            StuSubjectId INTEGER,
            FOREIGN KEY(StuId) REFERENCES StudentDetails(StuId),
            FOREIGN KEY(StuSubjectId) REFERENCES StuSubject(StuSubjectId)
        );",

        @"
        CREATE TABLE IF NOT EXISTS StuAttendance (
            StuId INTEGER,
            StuSubjectId INTEGER,
            Date TEXT NOT NULL,
            Status TEXT NOT NULL,
            PRIMARY KEY (StuId, StuSubjectId, Date),
            FOREIGN KEY(StuId) REFERENCES StudentDetails(StuId),
            FOREIGN KEY(StuSubjectId) REFERENCES StuSubject(StuSubjectId)
        );"
    };

            foreach (string query in queries)
            {
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void InsertDefaultUsersIfNeeded(SQLiteConnection connection)
        {
            string countQuery = "SELECT COUNT(*) FROM UserDetails;";
            using (var cmd = new SQLiteCommand(countQuery, connection))
            {
                long count = (long)cmd.ExecuteScalar();

                if (count == 0)
                {
                    string insert = @"
                        INSERT INTO UserDetails (UserName, UserPassword, UserRole) VALUES ('admin', 'admin123', 'Admin');
                        INSERT INTO UserDetails (UserName, UserPassword, UserRole) VALUES ('staff1', 'staff123', 'Staff');
                        INSERT INTO UserDetails (UserName, UserPassword, UserRole) VALUES ('lecturer1', 'lec123', 'Lecturer');
                        INSERT INTO UserDetails (UserName, UserPassword, UserRole) VALUES ('student1', 'stu123', 'Student');
                    ";

                    using (var insertCmd = new SQLiteCommand(insert, connection))
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void InsertDefaultRoomsIfNeeded(SQLiteConnection connection)
        {
            string countQuery = "SELECT COUNT(*) FROM SubRoom;";
            using (var cmd = new SQLiteCommand(countQuery, connection))
            {
                long count = (long)cmd.ExecuteScalar();

                if (count == 0)
                {
                    string insert = @"
                        INSERT INTO SubRoom (RoomName, RoomType) VALUES ('Lab 1', 'Lab');
                        INSERT INTO SubRoom (RoomName, RoomType) VALUES ('Lab 2', 'Lab');
                        INSERT INTO SubRoom (RoomName, RoomType) VALUES ('Hall A', 'Hall');
                        INSERT INTO SubRoom (RoomName, RoomType) VALUES ('Hall B', 'Hall');
                    ";

                    using (var insertCmd = new SQLiteCommand(insert, connection))
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // ✅ Always return an opened connection
        public static SQLiteConnection GetConnection()
        {
            var con = new SQLiteConnection(dbPath);
            con.Open();
            return con;
        }
    }
}
