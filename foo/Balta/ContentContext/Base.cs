using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}