﻿using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using UmbracoContentApi.Models;
using UmbracoContentApi.Resolvers;

namespace UmbracoContentApi.Converters
{
    internal class NestedContentConverter : IConverter
    {
        public string EditorAlias => "Umbraco.NestedContent";

        public object Convert(object value)
        {
            var list = new List<LinkModel>();
            foreach (IPublishedElement element in (IEnumerable<IPublishedElement>) value)
            {
                list.Add(
                    new LinkModel
                    {
                        Id = element.Key,
                        LinkType = LinkTypeResolver.GetLinkType(element.ContentType.ItemType)
                    });
            }

            return list;
        }
    }
}