// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.4.3
//     Build date: 2014-04-15 19:10:39 UTC
//     on: 2014-04-16, 21:49:59 UTC
//     C# generater version: 
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \mainpage
 *   helloworld Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href=''>helloworld</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>0
 *      <tr><th>API Docs
 *          <td><a href=''>
 *              </a>
 *      <tr><th>Discovery Name<td>helloworld
 *      <tr><th>Generated At<td>2014-04-16 21:49:59 UTC
 *      <tr><th>C# Generator<td>google-apis-code-generator
 *      <tr><th>Generator Version
 *          <td>1.4.3 / c#=1.8.1
 *      <tr><th>Generator Build<td>2014-04-15 19:10:39 UTC
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using helloworld can be found at
 * <a href=''></a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data
{    

    public class HelloGreeting : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class HelloGreetingCollection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<HelloGreeting> Items { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}

namespace EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1
{
    /// <summary>The Helloworld Service.</summary>
    public class HelloworldService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public HelloworldService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public HelloworldService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            greetings = new GreetingsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "helloworld"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://endpoints-helloworld-dotnet.appspot.com/_ah/api/helloworld/v1/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "helloworld/v1/"; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the helloworld.</summary>
        public class Scope
        {
            /// <summary>View your email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

        }



        private readonly GreetingsResource greetings;

        /// <summary>Gets the Greetings resource.</summary>
        public virtual GreetingsResource Greetings
        {
            get { return greetings; }
        }
    }

    ///<summary>A base abstract class for Helloworld requests.</summary>
    public abstract class HelloworldBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new HelloworldBaseServiceRequest instance.</summary>
        protected HelloworldBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Helloworld parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "greetings" collection of methods.</summary>
    public class GreetingsResource
    {
        private const string Resource = "greetings";

        ///<summary> The service whih this resource is belong to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GreetingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }



        public virtual AuthedRequest Authed()
        {
            return new AuthedRequest(service);
        }


        public class AuthedRequest : HelloworldBaseServiceRequest<EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreeting>
        {
            /// <summary>Constructs a new Authed request.</summary>
            public AuthedRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "authed"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "hellogreeting/authed"; }
            }

            /// <summary>Initializes Authed parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }


        /// <param name="id"></param>
        public virtual GetGreetingRequest GetGreeting(int id)
        {
            return new GetGreetingRequest(service, id);
        }


        public class GetGreetingRequest : HelloworldBaseServiceRequest<EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreeting>
        {
            /// <summary>Constructs a new GetGreeting request.</summary>
            public GetGreetingRequest(Google.Apis.Services.IClientService service, int id)
                : base(service)
            {
                Id = id;
                InitParameters();
            }



            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "getGreeting"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "hellogreeting/{id}"; }
            }

            /// <summary>Initializes GetGreeting parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }


        public virtual ListGreetingRequest ListGreeting()
        {
            return new ListGreetingRequest(service);
        }


        public class ListGreetingRequest : HelloworldBaseServiceRequest<EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreetingCollection>
        {
            /// <summary>Constructs a new ListGreeting request.</summary>
            public ListGreetingRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "listGreeting"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "hellogreeting"; }
            }

            /// <summary>Initializes ListGreeting parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }


        /// <param name="body">The body of the request.</param>
        /// <param name="times"></param>
        public virtual MultiplyRequest Multiply(EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreeting body, int times)
        {
            return new MultiplyRequest(service, body, times);
        }


        public class MultiplyRequest : HelloworldBaseServiceRequest<EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreeting>
        {
            /// <summary>Constructs a new Multiply request.</summary>
            public MultiplyRequest(Google.Apis.Services.IClientService service, EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreeting body, int times)
                : base(service)
            {
                Times = times;
                Body = body;
                InitParameters();
            }



            [Google.Apis.Util.RequestParameterAttribute("times", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Times { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            EndpointsHelloworldDotnetAppspotCom.Apis.Helloworld.v1.Data.HelloGreeting Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "multiply"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "hellogreeting/{times}"; }
            }

            /// <summary>Initializes Multiply parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "times", new Google.Apis.Discovery.Parameter
                    {
                        Name = "times",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}
