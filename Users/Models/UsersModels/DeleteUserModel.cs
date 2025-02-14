namespace Users.Models.UsersModels
{
    public class DeleteUserModel
    {
        public int Id { get; set; }
        public bool Delete { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
