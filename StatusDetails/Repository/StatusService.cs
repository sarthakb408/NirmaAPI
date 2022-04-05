namespace StatusDetails.Repository
{
    public class StatusService : IStatusService
    {
        public readonly StatusContext _context;
        public StatusService(StatusContext context)
        {
            _context = context;
        }
        public async Task<IResult> GetStatus()
        {
            return Results.Ok(await _context.Statuss.ToListAsync());
        }
        public async Task<IResult> GetStatusById(int id)
        {
            var status = await _context.Statuss.FindAsync(id);

            return status != null ? Results.Ok(status) : Results.NotFound();
        }
        public async Task<IResult> CreateStatus(StatusRequest status)
        {
            var createdstatus = _context.Statuss.Add(new Status
            {
                status_id = status.status_id ?? String.Empty,
                appointment_id = status.appointment_id ?? String.Empty,
                con_id = status.con_id ?? String.Empty,
                con_loaded = status.con_loaded,
                container_status = status.container_status ?? String.Empty,
                destination = status.destination ?? String.Empty,
                departure_date = status.departure_date ?? String.Empty,
                ship_id = status.ship_id ?? String.Empty,
                arriving_date = status.arriving_date ?? String.Empty,
                receiver_delivery_date = status.receiver_delivery_date ?? String.Empty,
                con_loaded_date = status.con_loaded_date ?? String.Empty

            });

            await _context.SaveChangesAsync();

            return Results.Created($"/status/" + $"{createdstatus.Entity.id}", createdstatus.Entity);
        }
        public async Task<IResult> UpdateStatus(int id, StatusRequest status)
        {
            var statusToUpdate = await _context.Statuss.FindAsync(id);

            if (statusToUpdate == null)
            {
                return Results.NotFound();
            }
            if (status.status_id != null)
            {
                statusToUpdate.status_id = status.status_id;
            }
            if (status.appointment_id != null)
            {
                statusToUpdate.appointment_id = status.appointment_id;
            }
            if (status.con_id != null)
            {
                statusToUpdate.con_id = status.con_id;
            }
            if (status.con_loaded != null)
            {
                statusToUpdate.con_loaded = status.con_loaded;
            }
            if (status.container_status != null)
            {
                statusToUpdate.container_status = status.container_status;
            }
            if (status.destination != null)
            {
                statusToUpdate.destination = status.destination;
            }
            if (status.departure_date != null)
            {
                statusToUpdate.departure_date = status.departure_date;
            }
            if (status.ship_id != null)
            {
                statusToUpdate.ship_id = status.ship_id;
            }
            if (status.arriving_date != null)
            {
                statusToUpdate.arriving_date = status.arriving_date;
            }
            if (status.receiver_delivery_date != null)
            {
                statusToUpdate.receiver_delivery_date = status.receiver_delivery_date;
            }
            if (status.con_loaded_date != null)
            {
                statusToUpdate.con_loaded_date = status.con_loaded_date;
            }

            await _context.SaveChangesAsync();
            return Results.Ok(statusToUpdate);
        }
        public async Task<IResult> DeleteStatus(int id)
        {
            var status = await _context.Statuss.FindAsync(id);
            if (status == null)
            {
                return Results.NotFound();
            }
            _context.Statuss.Remove(status);
            await _context.SaveChangesAsync();
            return Results.NoContent();
        }
    }
}
