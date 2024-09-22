public class Problem
{
    public string GetProblem { get; set; }
    public string GetDescription { get; set; }
    public string GetExpectedOutput { get; set; }
    public string GetCode { get; set; }
    public bool IsSolved { get; set; } = false;
    public string DifficultyLevel { get; set; }
    public int ScoreValue { get; set; }
}
