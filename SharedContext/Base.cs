namespace Balta.SharedContext
{
    using NotificationContext;
    using System;

    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}