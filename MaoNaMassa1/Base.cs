using MaoNaMassa1.NotificationContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassa1
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // SPOF 

        }
        public Guid Id { get; set; }

    }
}
