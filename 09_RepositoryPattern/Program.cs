using Data;

StreamingContentRepository repository = new StreamingContentRepository();

StreamingContent content = new StreamingContent();
Console.WriteLine(content.IsFamilyFriendly);

StreamingContent toyStory = new StreamingContent("Toy Story", "A story about toys", 92, "Bromance", 10, MaturityRating.G);
StreamingContent rubber = new StreamingContent("Rubber", "It's a tire", 92, "Action/Thriller", 7.5, MaturityRating.R);
StreamingContent princessBride = new StreamingContent("The Princess Bride", "True love overcomes adversity", 98, "Adventure", 10, MaturityRating.PG);

List<StreamingContent> listBeforeAdd = repository.GetDirectory();

repository.AddContentToDirectory(content);
repository.AddContentToDirectory(toyStory);
repository.AddContentToDirectory(rubber);
repository.AddContentToDirectory(princessBride);

List<StreamingContent> listAfterAdd = repository.GetDirectory();

Console.WriteLine(listBeforeAdd.Count);
Console.WriteLine(listAfterAdd.Count);

List<string> titles = repository.GetTitles();
foreach (var title in titles)
{
    Console.WriteLine(title);
}

StreamingContent? foundContent = repository.GetContentByTitle("the princess bride");
Console.WriteLine(foundContent?.Title);
Console.WriteLine(foundContent?.Description);
Console.WriteLine(foundContent?.Genre);
Console.WriteLine(foundContent?.IsFamilyFriendly);

// repository.DeleteContentByTitle("Rubber");

StreamingContent toyStory2 = new StreamingContent("Toy Story 2", "Another story about toys", 92, "Bromance", 10, MaturityRating.G);
repository.UpdateExistingContent("Toy Story", toyStory2);

titles = repository.GetTitles();
foreach (var title in titles)
{
    Console.WriteLine(title);
}