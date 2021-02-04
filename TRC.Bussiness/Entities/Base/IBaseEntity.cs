using System;
using System.Collections.Generic;
using System.Text;

namespace BRC.Bussiness.Entities.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string Status { get; set; }
    }
}
