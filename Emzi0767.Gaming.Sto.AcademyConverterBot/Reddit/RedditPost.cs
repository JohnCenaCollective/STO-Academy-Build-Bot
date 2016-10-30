namespace Emzi0767.Gaming.Sto.AcademyConverterBot.Reddit
{
    public struct RedditPost
    {
        public string Fullname { get; set; }
        public string Content { get; set; }
        public string BuildId { get; set; }
        public bool Convert { get; set; }

        public override string ToString()
        {
            return this.Fullname;
        }
    }
}
