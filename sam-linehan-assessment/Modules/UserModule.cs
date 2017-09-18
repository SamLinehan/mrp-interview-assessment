using System;
using Nancy;
using Nancy.ModelBinding;

namespace sam_linehan_assessment.Modules
{
    public class UserModule : NancyModule
    {
        public UserModule()
        {
			Post("/user/add", args =>
			{
				var userModel = this.Bind<Models.User>();
                return "";
			});

            Delete("/user/delete/{id}", args => 
            {
                return "";
            });

            Get("/user/{id}", args =>
            {
                return "getting user id";
            });

            Get("/user/list", args =>
            {
                return "user list";
            });

        }
    }
}
