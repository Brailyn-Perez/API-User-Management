namespace Users.Models.UsersModels
{
    public class UpdateUserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
