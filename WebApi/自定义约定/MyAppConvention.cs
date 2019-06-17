using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi
{
    //自定义约定的两个条件:1.带有方法的静态类型 2.能够对操作定义响应类型和命名要求
    //响应类型通过分析器进行指定，用属性进行批注，命名要求就是对用法进行说明
    
    public static class MyAppConvention
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //[ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
        public static void Find([ApiConventionNameMatch(ApiConventionNameMatchBehavior.Suffix)] [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.AssignableFrom)]Student student)
        {

        }


    }
}
