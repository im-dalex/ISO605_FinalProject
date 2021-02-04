using System;
using System.Collections.Generic;
using System.Text;

namespace BRC.Bussiness.Entities.Base
{
    public interface IBasePerson : IBaseEntity
    {
        string Name { get; set; }
        string Identification { get; set; }
    }
}
