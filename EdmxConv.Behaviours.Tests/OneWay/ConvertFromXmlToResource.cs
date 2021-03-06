﻿using CSharpFunctionalExtensions;
using EdmxConv.Behaviours.Modules;
using EdmxConv.Schema.Extensions;
using Shouldly;
using Xunit;
using static EdmxConv.Core.FlowHelpers;

namespace EdmxConv.Behaviours.Tests.OneWay
{
    public class ConvertFromXmlToResource
    {
        [Fact(DisplayName = "Xml -> Resx")]
        public void convert_xml_to_resource() =>
            With(Resources.SampleXmlEdmx)
                .OnSuccess(sample => sample.ToXmlEdmx())
                .OnSuccess(edmx => ConvertModule.ConvertToResource(edmx))
                .Map(edmx => edmx.ToString())
                .OnSuccess(edmx => edmx.ShouldBe(Resources.SampleResourceEdmx));
    }
}