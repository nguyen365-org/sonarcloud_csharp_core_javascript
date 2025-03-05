namespace WebApplication.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
    }
}
