using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using KeysManager.Domain;
using KeysManager.Domain.Entities;

namespace Domain.Abstract
{
    public interface IKeyRepository
    {
        IEnumerable<tbKey> KeysList { get; }
    }
}
