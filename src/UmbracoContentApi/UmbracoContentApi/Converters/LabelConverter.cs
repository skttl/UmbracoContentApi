﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoContentApi.Converters
{
    internal class LabelConverter : IConverter
    {
        public string EditorAlias => "Umbraco.Label";

        public object Convert(object value)
        {
            return value;
        }
    }
}