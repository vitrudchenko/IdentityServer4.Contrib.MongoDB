﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


namespace IdentityServer4.MongoDB.Entities
{
    public class ClientClaim
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}