// score manager class
class ScoreManager
{
    private int score;

    public ScoreManager()
    {
        score = 0;
    }

    public void AddToScore(int value)
    {
        score += value;
    }

    public int GetScore()
    {
        return score;
    }
}