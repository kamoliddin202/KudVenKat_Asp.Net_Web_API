namespace KudVenKat_Asp.Net_Web_API.Models
{
    public static class StudentRepasitory
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student
                {
                    Id = 1,
                    StudentName = "Ali",
                    Email = "Example@gmail.com",
                    Address = "Tashkent"
                },
                new Student
                {
                    Id = 1,
                    StudentName = "Ali",
                    Email = "Example@gmail.com",
                    Address = "Tashkent"
                }
        };

    }
}
