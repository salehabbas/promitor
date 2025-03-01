﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Promitor.Agents.ResourceDiscovery.Graph.Model;

namespace Promitor.Agents.ResourceDiscovery.Graph.Interfaces
{
    public interface IAzureResourceGraph
    {
        Task<JObject> QueryAzureLandscapeAsync(string queryName, string query);
        Task<JObject> QueryTargetSubscriptionsAsync(string queryName, string query);
        Task<List<Resource>> QueryForResourcesAsync(string queryName, string query, List<string> targetSubscriptions);
    }
}
