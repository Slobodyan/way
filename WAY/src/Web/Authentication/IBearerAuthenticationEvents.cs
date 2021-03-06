﻿using System.Threading.Tasks;

namespace Web.Authentication {
	public interface IBearerAuthenticationEvents {
		Task ValidatePrincipal(BearerValidatePrincipalContext context);

		Task SigningIn(BearerSigningInContext context);

		Task SignedIn(BearerSignedInContext context);

		Task SigningOut(BearerSigningOutContext context);

		Task Unauthorized(BearerUnauthorizedContext context);

		Task Forbidden(BearerForbiddenContext context);
	}
}
