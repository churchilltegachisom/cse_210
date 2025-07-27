using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("C# Tutorial", "CodeAcademy", 600);
        video1.AddComment(new Comment("Favour", "Very helpful, thank you!"));
        video1.AddComment(new Comment("Bambi", "Can you make one on OOP?"));
        video1.AddComment(new Comment("Charles", "I finally understand classes!"));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Funny Cat Compilation", "PetWorld", 300);
        video2.AddComment(new Comment("Diamond", "I laughed so hard!"));
        video2.AddComment(new Comment("Precious", "My kids loved it."));
        video2.AddComment(new Comment("Emmanuel", "Cute overload!"));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Top 10 Travel Destinations", "Wanderlust", 900);
        video3.AddComment(new Comment("Tega", "Adding these to my list!"));
        video3.AddComment(new Comment("Irene", "Been to #3, it's amazing."));
        video3.AddComment(new Comment("Boma", "Beautiful visuals."));
        videos.Add(video3);

        // Display each video info
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
