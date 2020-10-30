using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Xamarin.Auth;
using Newtonsoft.Json.Linq;
using XF_LoginFacebook;
using System.Runtime.Remoting.Contexts;
using CompraAi;
using CompraAi.Views;

[assembly: ExportRenderer(typeof(Login), typeof(XF_LoginFacebook.Droid.FBLoginPageRenderer))]
namespace XF_LoginFacebook.Droid
{

    public class FBLoginPageRenderer : PageRenderer
    {
        [Obsolete]
        public FBLoginPageRenderer()
        {

            var activity = Context as Activity;
            var auth = new OAuth2Authenticator(
                clientId: "354923305867050",   //  seu cliente id OAuth2 client id
                scope: "",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("https://www.facebook.com/connect/login_success.html"));
            auth.Completed += async (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    var accessToken = eventArgs.Account.Properties["access_token"].ToString();
                    var expiresIn = Convert.ToDouble(eventArgs.Account.Properties["expires_in"]);
                    var expiryDate = DateTime.Now + TimeSpan.FromSeconds(expiresIn);
                    var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, eventArgs.Account);
                    var response = await request.GetResponseAsync();
                    var obj = JObject.Parse(response.GetResponseText());
                    var id = obj["id"].ToString().Replace("\"", "");
                    var name = obj["name"].ToString().Replace("\"", "");
                    await App.NavigateToProfile(string.Format("Olá {0}, seja bem-vindo", name));
                }
                else
                {
                    await App.NavigateToProfile("Usuário Cancelou o login");
                }
            };
            activity.StartActivity(auth.GetUI(activity));
        }
    }

}