using System;
using prmToolkit.NotificationPattern;

namespace XGames.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
