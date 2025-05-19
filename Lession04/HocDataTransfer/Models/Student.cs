namespace HocDataTransfer.Models
{
    public class Student
    {
        [Minlength(5,ErrorMessage = "Ho ten toi thieu 5 ky tu!")]
        [Required(ErrorMessage = "Ho ten khong duoc de trong!")]
        public string? FullName { get; set; }
        [EmailAddress(ErrorMessage = "Email khong dung dinh dang!")]
        public string? Email { get; set; }
        [Range(18,60,ErrorMessage = "Tuoi phai tu 18 den 60!")]
        public int? Age { get; set; }
    }
}
