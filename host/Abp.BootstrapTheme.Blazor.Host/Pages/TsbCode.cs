using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.BootstrapTheme.Blazor.Host.Pages
{
    public class TsbCode
    {
        // 主键Id
        [DisplayName("主键Id")]
        public string Id { get; set; }
        // 编码
        [DisplayName("编码")]
        public string CodeClass { get; set; }
        // 名称
        [DisplayName("名称")]
        public string CodeName { get; set; }
        // 来源
        [DisplayName("来源")]
        public string CodeSource { get; set; }
        // 描述1
        [DisplayName("描述1")]
        public string CodeDesc1Name { get; set; }
        // 描述2
        [DisplayName("描述2")]
        public string CodeDesc2Name { get; set; }
        // 描述3
        [DisplayName("描述3")]
        public string CodeDesc3Name { get; set; }
        // 描述4
        [DisplayName("描述4")]
        public string CodeDesc4Name { get; set; }
    }
}
