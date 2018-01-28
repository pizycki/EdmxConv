using System.Web;
using CSharpFunctionalExtensions;
using EdmxConv.Behaviours.Modules;
using EdmxConv.Core;
using EdmxConv.Schema;
using EdmxConv.Schema.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EdmxConv.Controllers
{
    public class ConvertController : BaseApiController
    {
        [HttpPost, Route("api/convert")]
        public IActionResult Convert([FromBody] ConvertParams payload) =>
            ConvertParamsValidationModule.Validate(payload)
                .OnSuccess(ConvertEdmxArgsModule.CreateArguments)
                .OnSuccess(ConvertModule.Convert)
                .Map(edmx => (plain: edmx.ToString(), type: edmx.Type))
                // This must stay here, because of reference to System.Web
                .OnSuccessIf(condition: edmxWithType => edmxWithType.type == EdmxTypeEnum.Xml,
                             func: edmxWithType =>
                                FlowHelpers.With(edmxWithType.plain)
                                    .OnSuccess(EncodeHtml)
                                    .Map(xml => (plain: xml, type: EdmxTypeEnum.Xml)))
                .Map(edmxWithType => edmxWithType.plain)
                .OnBoth(MapToHttpResponse);

        private static Result<string> EncodeHtml(string xml) =>
            FlowHelpers.With(xml)
                .OnSuccess(edmx => edmx.ToString())
                .OnSuccess(edmx => HttpUtility.HtmlEncode(edmx));

        [HttpGet, Route("api/convert/configuration")]
        public ActionResult GetConfiguration() =>
            Ok(new
            {
                Sources = new dynamic[]
                {
                    new { Name = "XML",      Type = EdmxTypeEnum.Xml },
                    new { Name = "Resource", Type = EdmxTypeEnum.Resource },
                    new { Name = "Database", Type = EdmxTypeEnum.Database }
                },

                Targets = new dynamic[]
                {
                    new { Name = "XML",      Type = EdmxTypeEnum.Xml },
                    new { Name = "Resource", Type = EdmxTypeEnum.Resource },
                    new { Name = "Database", Type = EdmxTypeEnum.Database }
                },
            });

    }
}