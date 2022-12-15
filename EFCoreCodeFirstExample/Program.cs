// See https://aka.ms/new-console-template for more information
using EFCoreCodeFirstExample.Data;
using EFCoreCodeFirstExample.Data.Entities;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("EF Core Example");
        var dbContext = new BlogDbContext();
        var postObject = new Post
        {
            Title = "My First Post"
        };
        postObject.Comments.Add(new Comment { Body = "this is my first comment" });
        //look at that comments. add and the class Comment and Post, why can you do that.  not understanding??

        dbContext.Posts.Add(postObject);
        _ = await dbContext.SaveChangesAsync();
        Console.WriteLine("Done with Main method.");
    }
}