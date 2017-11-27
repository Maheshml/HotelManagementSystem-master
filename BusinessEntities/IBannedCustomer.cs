namespace BusinessEntities
{
    public interface IBannedCustomer
    {

      
            int BanId { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
            string Email { get; set; }
            string ReasonForBan { get; set; }
            //string dateBanned { get; set; }
         
            string Photo { get; set; }


    }
}