﻿using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class StartLearmApiCommand : BaseApiCommand<LearnCodeRequest, LearnCodeResponse>
    {
        public StartLearmApiCommand(LearnCodeRequest request, string url)
            : base(request, url)
        {
        }
    }
}