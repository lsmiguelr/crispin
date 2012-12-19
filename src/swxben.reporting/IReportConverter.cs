﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Xsl;

namespace swxben.reporting
{
    public interface IReportConverter
    {
        string ConvertToString(string xrpt);
        void ReplaceXslt(XslCompiledTransform xslt);
        byte[] ConvertToBuffer(string xrpt, string reportName);
    }
}