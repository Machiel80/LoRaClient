﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Kpn.LoRa.Api.Stub.Models.AppServersRoutingProfiles
{

    public class AppServersRoutingProfiles
    {
        public Brief[] briefs { get; set; }
    }

    public class Brief
    {
        public string name { get; set; }
        public string ID { get; set; }
        public bool isDefault { get; set; }
        public string href { get; set; }
    }

    public class AppServersRoutingProfile
    {
        public Occcontext occContext { get; set; }
        public string ID { get; set; }
        public string name { get; set; }
        public bool isDefault { get; set; }
        public Route[] routes { get; set; }
    }

    public class Occcontext
    {
        public int version { get; set; }
        public long lastUpdate { get; set; }
        public string who { get; set; }
    }

    public class Route
    {
        public string sourcePort { get; set; }
        public string strategy { get; set; }
        public string destinations { get; set; }
    }


}