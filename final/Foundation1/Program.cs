using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Actually Train a Dragon", "The Dragon Man", 345);
        Comment comment1 = new Comment("DragonLover87", "If a dragon were truly trainable that would be so cool!");
        Comment comment2 = new Comment("user44", "I don't believe in dragons.");
        Comment comment3 = new Comment("Rod Hairs", "Great video. Very information. Where can I buy one of these dragons for myself?");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);

        Video video2 = new Video("", "", 239);
        Comment comment4 = new Comment("", "");
        Comment comment5 = new Comment("", "");
        Comment comment6 = new Comment("", "");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video2);

        Video video3 = new Video("", "", 587);
        Comment comment7 = new Comment("", "");
        Comment comment8 = new Comment("", "");
        Comment comment9 = new Comment("", "");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        videos.Add(video3);

        Console.Clear();
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}