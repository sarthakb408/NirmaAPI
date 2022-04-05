namespace StatusDetails.Model
{
    public class Status
    {
        public int id { get; set; }
        public string? status_id { get; set; }
        public string? appointment_id { get; set; }
        public string? con_id { get; set; }
        public bool con_loaded { get; set; }
        public string? container_status { get; set; }
        public string? destination { get; set; }
        public string? departure_date { get; set; }
        public string? ship_id { get; set; }
        public string? arriving_date { get; set; }
        public string? receiver_delivery_date { get; set; }
        public string? con_loaded_date { get; set; }
    }
}
