namespace WebApplication.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required string Title { get; set; }
    }
}
