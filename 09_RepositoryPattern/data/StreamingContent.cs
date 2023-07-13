namespace Data;

public class StreamingContent
{
    public StreamingContent()
    {
        MaturityRating = MaturityRating.Unknown;
    }
    public StreamingContent(string title, string description, int runTime, string genre, double score, MaturityRating rating)
    {
        Title = title;
        Description = description;
        RunTime = runTime;
        Genre = genre;
        UserScore = score;
        MaturityRating = rating;
    }

    public string Title { get; set; }
    public int RunTime { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public double UserScore { get; set; }
    public MaturityRating MaturityRating { get; set; }
    public bool IsFamilyFriendly
    {
        get
        {
            switch (MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                    return true;
                case MaturityRating.PG_13:
                case MaturityRating.R:
                case MaturityRating.NC_17:
                case MaturityRating.TV_14:
                case MaturityRating.TV_MA:
                default:
                    return false;
            }
        }
    }
}

public enum MaturityRating
{ G, PG, PG_13, R, NC_17, TV_Y, TV_G, TV_PG, TV_14, TV_MA, Unknown }