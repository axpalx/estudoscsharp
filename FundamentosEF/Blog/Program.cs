using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new BlogDataContext())
      {
        // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
        // context.Tags.Add(tag);
        // context.SaveChanges();

        // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
        // tag.Name = ".NET";
        // tag.Slug = "dotnet";
        // context.Update(tag);
        // context.SaveChanges();

        // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
        // context.Remove(tag);
        // context.SaveChanges();

        // var tags = context.Tags.AsNoTracking().ToList();

        // foreach (var tag in tags)
        // {
        //   Console.WriteLine(tag.Name);
        // }

        // var user = new User
        // {
        //   Name = "Alex Pulido",
        //   Slug = "alexpulido",
        //   Email = "teste@teste.com",
        //   Bio = "0x Microsoft MVP",
        //   Image = "https://alexpulido.io",
        //   PasswordHash = "11111111"
        // };

        // var category = new Category
        // {
        //   Name = "Backend",
        //   Slug = "backend"
        // };

        // var post = new Post
        // {
        //   Author = user,
        //   Category = category,
        //   Body = "<p>Hello World<p>",
        //   Slug = "comecando-com-ef-core",
        //   Summary = "Neste artigo vamos aprender EF Core",
        //   Title = "Começando com EF Core",
        //   CreateDate = DateTime.Now,
        //   LastUpdateDate = DateTime.Now,
        // };

        // context.Posts.Add(post);
        // context.SaveChanges();


        // var posts = context
        //   .Posts
        //   .AsNoTracking()
        //   .Include(x => x.Author)
        //   .OrderBy(x => x.LastUpdateDate)
        //   .ToList();

        // foreach (var post in posts)
        // {
        //   Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
        // }



        
      }
    }
  }
}
