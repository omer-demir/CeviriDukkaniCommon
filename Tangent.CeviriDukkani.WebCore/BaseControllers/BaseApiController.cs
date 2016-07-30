using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Tangent.CeviriDukkani.WebCore.BaseControllers {
    public class BaseApiController : ApiController {
        public JsonMediaTypeFormatter Formatter = new JsonMediaTypeFormatter {
            SerializerSettings = new JsonSerializerSettings {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }
        };

        public HttpResponseMessage OK() {
            HttpResponseMessage response = new HttpResponseMessage {
                StatusCode = HttpStatusCode.OK
            };
            return response;
        }
        public HttpResponseMessage OK(object data) {
            var resp = OK();
            resp.Content = new ObjectContent(data.GetType(), data, Formatter);
            return resp;
        }

        public HttpResponseMessage Error() {
            HttpResponseMessage response = new HttpResponseMessage {
                StatusCode = HttpStatusCode.InternalServerError
            };
            return response;
        }
        public HttpResponseMessage Error(object data) {
            var resp = Error();
            resp.Content = new ObjectContent(data.GetType(), data, Formatter);
            return resp;
        }

        public HttpResponseMessage CustomResponse(HttpStatusCode statusCode, object data) {
            HttpResponseMessage response = new HttpResponseMessage {
                StatusCode = statusCode,
                Content = new ObjectContent(data.GetType(), data, Formatter)
            };
            return response;
        }

        public int GetUserIdFromHeader() {
            var values = Request.Headers.GetValues("x-cev-userid").ToList();
            if (!values.Any()) {
                return default(int);
            }

            return int.Parse(values.FirstOrDefault());
        }

        public string GetUserNameFromHeader() {
            var values = Request.Headers.GetValues("x-cev-username").ToList();
            if (!values.Any()) {
                return default(string);
            }

            return values.FirstOrDefault();
        }
    }
}