namespace TerminalDetails.Repository
{
    public interface ITerminalService
    {

        Task<IResult> GetTerminals();
        Task<IResult> GetTerminalById(int id);
        Task<IResult> CreateTerminal(TerminalRequest terminal);
        Task<IResult> UpdateTerminal(int id, TerminalRequest terminal);
        Task<IResult> DeleteTerminal(int id);
    }
}
