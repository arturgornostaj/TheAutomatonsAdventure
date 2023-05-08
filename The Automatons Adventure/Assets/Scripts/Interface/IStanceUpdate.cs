
public interface IStanceUpdate
{
    public void OnScoutingEnter();
    public void OnFightingEnter();
    public void OnSearchingEnter();

}

public enum AutomatonStance
{
    Scouting,
    Fighting,
    Searching
}