namespace PerformansysAnalys.Application.Auth.Dtos
{
    public class ReqisterRequest
    {
        public string Login { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        public string? VkProfileLink { get; set; } = string.Empty;
        public int GroupId { get; set; }


    }
}
