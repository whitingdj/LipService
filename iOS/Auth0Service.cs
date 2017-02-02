using System;
using Auth0.SDK;
using LipService.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Auth0Service))]
namespace LipService.iOS {
	public class Auth0Service {
		public Auth0Service() {
			var auth0 = new Auth0Client(
  			"dwhiting.auth0.com",
 		 	"o1MKUn5fCqxn7vQ0CgV94z68wioaJPb3");
			// 'this' could be a Context object (Android) or UIViewController, UIView, UIBarButtonItem (iOS)
			var user = await auth0.LoginAsync(this);
			/*
			- get user email => user.Profile["email"].ToString()
			- get Windows Azure AD groups => user.Profile["groups"]
			- etc.
			*/
		}
	}
}
