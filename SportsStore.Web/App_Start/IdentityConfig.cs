﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SportsStore.IdentityConfig))]

namespace SportsStore
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app) { }
    }
}