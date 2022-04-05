namespace StatusDetails.Request
{
    public record StatusRequest(string? status_id, string? appointment_id, string? con_id, bool con_loaded, string? container_status, string? destination, string? departure_date, string? ship_id, string? arriving_date, string? receiver_delivery_date, string? con_loaded_date);
}
