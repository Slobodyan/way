﻿using Microsoft.AspNet.Http;

namespace Web.Authentication {
	public class BearerUnauthorizedContext : BearerBaseContext {
		public BearerUnauthorizedContext(HttpContext context, BearerAuthenticationOptions options) : base(context, options) {
		}
	}
}
