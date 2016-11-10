using System.ServiceModel;
using System.ServiceModel.Web;

namespace ServicoWcf.Services.Interfaces
{
    [ServiceContract]
    public interface IAuthenticationTokenService
    {
        /// <summary>
        ///     Gera token de acesso
        /// </summary>
        /// <returns></returns>
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        string GenerateToken();

        /// <summary>
        ///     Valida token de acesso
        /// </summary>
        /// <returns></returns>
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        bool ValidateToken();
    }
}
