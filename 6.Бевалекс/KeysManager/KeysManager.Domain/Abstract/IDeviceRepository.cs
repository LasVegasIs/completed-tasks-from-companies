using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysManager.Domain;
using KeysManager.Domain.Entities;

namespace Domain.Abstract
{
    public interface IDeviceRepository
    {
        IEnumerable<tbDevice> DevicesList { get; }
    }
}
