namespace TerminalDetails.Repository
{
    public class TerminalService : ITerminalService
    {
        public readonly TerminalContext _context;

        public TerminalService(TerminalContext context)
        {
            _context = context;
        }

        public async Task<IResult> GetTerminals()
        {
            return Results.Ok(await _context.Terminals.ToListAsync());
        }

        public async Task<IResult> GetTerminalById(int id)
        {
            var terminal = await _context.Terminals.FindAsync(id);

            return terminal != null ? Results.Ok(terminal) : Results.NotFound();
        }

        public async Task<IResult> CreateTerminal(TerminalRequest terminal)
        {
            var createdterminal = _context.Terminals.Add(new Terminal
            {
                terminal_id = terminal.terminal_id ?? String.Empty,
                terminal_name = terminal.terminal_name ?? String.Empty,
                terminal_mobile = terminal.terminal_mobile ?? String.Empty,
                terminal_email = terminal.terminal_email ?? String.Empty,
                terminal_username = terminal.terminal_username ?? String.Empty,
                terminal_password = terminal.terminal_password ?? String.Empty,
                terminal_location = terminal.terminal_location ?? String.Empty,
                city = terminal.city ?? String.Empty,
                country = terminal.country ?? String.Empty,
                zipcode = terminal.zipcode ?? String.Empty,
                terminal_logo = terminal.terminal_logo ?? String.Empty,
                fax = terminal.fax ?? String.Empty,
                description = terminal.description ?? String.Empty,
                terminal_status = terminal.terminal_status ?? String.Empty,
                token = terminal.token ?? String.Empty

            });

            await _context.SaveChangesAsync();

            return Results.Created($"/terminals/" + $"{createdterminal.Entity.id}", createdterminal.Entity);
        }

        public async Task<IResult> UpdateTerminal(int id, TerminalRequest terminal)
        {
            var terminalToUpdate = await _context.Terminals.FindAsync(id);

            if (terminalToUpdate == null)
            {
                return Results.NotFound();
            }
            if (terminal.terminal_id != null)
            {
                terminalToUpdate.terminal_id = terminal.terminal_id;
            }
            if (terminal.terminal_name != null)
            {
                terminalToUpdate.terminal_name = terminal.terminal_name;
            }
            if (terminal.terminal_mobile != null)
            {
                terminalToUpdate.terminal_mobile = terminal.terminal_mobile;
            }
            if (terminal.terminal_email != null)
            {
                terminalToUpdate.terminal_email = terminal.terminal_email;
            }
            if (terminal.terminal_username != null)
            {
                terminalToUpdate.terminal_username = terminal.terminal_username;
            }
            if (terminal.terminal_password != null)
            {
                terminalToUpdate.terminal_password = terminal.terminal_password;
            }
            if (terminal.terminal_location != null)
            {
                terminalToUpdate.terminal_location = terminal.terminal_location;
            }
            if (terminal.city != null)
            {
                terminalToUpdate.city = terminal.city;
            }
            if (terminal.country != null)
            {
                terminalToUpdate.country = terminal.country;
            }
            if (terminal.zipcode != null)
            {
                terminalToUpdate.zipcode = terminal.zipcode;
            }
            if (terminal.terminal_logo != null)
            {
                terminalToUpdate.terminal_logo = terminal.terminal_logo;
            }
            if (terminal.fax != null)
            {
                terminalToUpdate.fax = terminal.fax;
            }
            if (terminal.description != null)
            {
                terminalToUpdate.description = terminal.description;
            }
            if (terminal.terminal_status != null)
            {
                terminalToUpdate.terminal_status = terminal.terminal_status;
            }
            if (terminal.token != null)
            {
                terminalToUpdate.token = terminal.token;
            }

            await _context.SaveChangesAsync();
            return Results.Ok(terminalToUpdate);
        }

        public async Task<IResult> DeleteTerminal(int id)
        {
            var terminal = await _context.Terminals.FindAsync(id);
            if (terminal == null)
            {
                return Results.NotFound();
            }
            _context.Terminals.Remove(terminal);
            await _context.SaveChangesAsync();
            return Results.NoContent();
        }
    }
}
