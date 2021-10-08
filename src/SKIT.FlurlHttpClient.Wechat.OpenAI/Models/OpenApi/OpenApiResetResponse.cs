﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/openapi/reset 接口的响应。</para>
    /// </summary>
    public class OpenApiResetResponse : WechatOpenAIResponse<OpenApiResetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : OpenApiCreateResponse.Types.Data
            {
            }
        }
    }
}
