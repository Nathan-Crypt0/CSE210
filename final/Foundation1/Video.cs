class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;

    public List<Comment> Comments = new List<Comment>();

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}