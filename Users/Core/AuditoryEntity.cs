namespace Users.Core
{
    public class AuditoryEntity
    {
        public AuditoryEntity() 
        {
            Delete = false;
            CreationDate = DateTime.Now;
        }

        public bool Delete { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
