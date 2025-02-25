namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.enter_register_package 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90585 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90810 </para>
    /// </summary>
    public class EnterRegisterPackageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class AuthorizerUser
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [System.Xml.Serialization.XmlElement("UserId")]
                public string UserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置注册码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("RegisterCode")]
        public string RegisterCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权管理员信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthUserInfo", IsNullable = true)]
        public Types.AuthorizerUser? AuthorizerUser { get; set; }

        /// <summary>
        /// 获取或设置推广包 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TemplateId")]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义渠道参数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("State", IsNullable = true)]
        public string? State { get; set; }
    }
}
