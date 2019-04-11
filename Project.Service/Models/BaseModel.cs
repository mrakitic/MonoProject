using System;

namespace Project.Service.Models
{
    public class BaseModel
    {

        public Guid Id { get; set; }
        public int Index { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
