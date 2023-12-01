namespace AnriMartServer.Models
{
    public class Order : BaseModel
    {
        public string OrderName { get; set; }

        public string OrderCode { get; set; }

        public string? Description { get; set; }
    }
}