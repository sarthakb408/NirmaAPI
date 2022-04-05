namespace TerminalDetails.Request
{
    public record TerminalRequest (string? terminal_id, string? terminal_name, string? terminal_mobile, string? terminal_email, string? terminal_username, string? terminal_password, string? terminal_location, string? city, string? country, string? zipcode, string? terminal_logo, string? fax, string? description, string? terminal_status, string? token);

}
