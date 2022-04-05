namespace StatusDetails.Repository
{
    public interface IStatusService
    {
        Task<IResult> GetStatus();
        Task<IResult> GetStatusById(int id);
        Task<IResult> CreateStatus(StatusRequest status);
        Task<IResult> UpdateStatus(int id, StatusRequest status);
        Task<IResult> DeleteStatus(int id);
    }
}
