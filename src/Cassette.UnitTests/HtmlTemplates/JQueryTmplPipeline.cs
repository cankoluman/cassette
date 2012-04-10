﻿using Cassette.Configuration;
using Moq;
using Should;
using Xunit;

namespace Cassette.HtmlTemplates
{
    public class JQueryTmplPipeline_Tests
    {
        [Fact]
        public void WhenProcessBundle_ThenBundleContentTypeIsTextJavascript()
        {
            var pipeline = new JQueryTmplPipeline(Mock.Of<IUrlGenerator>());
            var bundle = new HtmlTemplateBundle("~/");

            pipeline.Process(bundle, new CassetteSettings(""));

            bundle.ContentType.ShouldEqual("text/javascript");
        }

        [Fact]
        public void WhenProcessBundle_ThenHashIsAssigned()
        {
            var pipeline = new JQueryTmplPipeline(Mock.Of<IUrlGenerator>());
            var bundle = new HtmlTemplateBundle("~");

            pipeline.Process(bundle, new CassetteSettings(""));

            bundle.Hash.ShouldNotBeNull();
        }
    }
}