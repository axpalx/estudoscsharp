using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.NotificationContext;

namespace Balta.ContentContext
{
  public class Article : Content
  {
    public IList<Notification> Notifications { get; set; }
    public Article(string title, string url)
    : base(title, url)
    {

    }
  }
}