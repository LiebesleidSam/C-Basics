using Data;

public class StreamingContentRepository
{
    private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // Create
    public bool AddContentToDirectory(StreamingContent content)
    {
        int startingCount = _contentDirectory.Count;

        if (content.Title != null)
        {
            _contentDirectory.Add(content);
        }

        bool countIncreased = _contentDirectory.Count > startingCount;

        return countIncreased;
    }
    
    // Read
    public List<string> GetTitles()
    {
        List<string> titles = new List<string>();

        foreach (StreamingContent content in _contentDirectory)
        {
            titles.Add(content.Title ?? "Untitled");
        }

        return titles;

        // Does the same thing that the above code does
        // .Select is the C# equivalent of the JavaScript .map
        // return _contentDirectory.Select(content => content.Title ?? "Untitled").ToList();
    }

    public List<StreamingContent> GetDirectory()
    {
        return new List<StreamingContent>(_contentDirectory);
    }

    public StreamingContent? GetContentByTitle(string title)
    {
        // Loop through each streaming content object in the directory
        foreach (var content in _contentDirectory)
        {
            // Check if the title of content equals the title parameter
            if (content.Title?.ToLower() == title.ToLower())
            {
                // If we find the matching title, return content
                return content;
            }
        }
        // If no title matches the title parameter
        return null;
    }

    // Update
    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
    {
        // Get old content and verify it exists
        StreamingContent? oldContent = GetContentByTitle(originalTitle);

        if (oldContent == null)
        {
            // If oldContent was not found, we return false
            return false;
        }

        // oldContent was found

        // Only need option 1 OR option 2

        // Option 1) Replace values for all properties
        // Reference never changes

        // oldContent.Title = newContent.Title;
        // oldContent.Description = newContent.Description;
        // etc.

        // Option 2) Replace the reference held in the list
        // Swap one stored reference for another

        int index = _contentDirectory.IndexOf(oldContent);
        _contentDirectory[index] = newContent;

        return true;
    }

    // Delete
    public bool DeleteExistingContent(StreamingContent existingContent)
    {
        bool deleteResult = _contentDirectory.Remove(existingContent);
        return deleteResult;
    }

    public bool DeleteContentByTitle(string title)
    {
        StreamingContent? targetContent = GetContentByTitle(title);
        if (targetContent == null)
        {
            return false;
        }

        bool deleteResult = DeleteExistingContent(targetContent);
        return deleteResult;
    }
}