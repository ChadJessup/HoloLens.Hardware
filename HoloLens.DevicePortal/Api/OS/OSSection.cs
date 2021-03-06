﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HoloLens.DevicePortal.Api.OS
{
    public class OSSection
    {
        private static class Constants
        {
            public const string InfoUri = "/api/os/info";
            public const string MachineNameUri = "/api/os/machinename";
        }

        public async Task<Info> GetInfoAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.InfoUri);
            return JsonConvert.DeserializeObject<Info>(content);
        }

        public async Task<string> GetMachineNameAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.MachineNameUri);
            return JObject.Parse(content)["ComputerName"].ToString();
        }
    }
}
