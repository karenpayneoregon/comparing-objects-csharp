
namespace ApplicationDataLibrary;

public class Concert
{
        
    public int PersonId { get; set; }
    public int ConcertCount { get; set; }
    public int Year { get; set; }

    public override string ToString() 
        => $"{nameof(PersonId)}: {PersonId}, {nameof(ConcertCount)}: {ConcertCount}";
}