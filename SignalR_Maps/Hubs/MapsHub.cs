using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Microsoft.AspNet.SignalR;

namespace SignalR_Maps.Hubs
{
    public class MapsHub : Hub
    {
        public IEnumerable<Location> GetLocations()
        {
            return FileWatcher.Data;
        }
    }
}