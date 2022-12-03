namespace BmesRestApi.Models.Shared
{
    public class Person:BaseObject
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}
