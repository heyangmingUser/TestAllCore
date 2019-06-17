using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]//默认约定的类型
    //[ApiConventionType(typeof(MyAppConvention))]
    public class StudentController : ControllerBase
    {
        //使用webApi分析器
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Student), StatusCodes.Status200OK)]//指定操作类型和状态码
        [ProducesDefaultResponseType]//键入所有未被指定的http状态码
        [ProducesResponseType(StatusCodes.Status404NotFound)]//可以直接指定返回的类型
        public IActionResult Get(int id)
        {
            //api约定的分析器，简单的理解为可以指定具体的响应类型，swagger包含可能返回的状态码和相应类型
            return Ok(new Student());
        }

        //使用WebApi约定，webApi可代替使用上面的分析器，来装饰单个操作，返回类型和状态码
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Put))]
        [HttpPut("{id}")]
        public IActionResult Update(int id, Student student)
        {
            return NotFound();
        }

        //使用自定义的webApi约定
        [ApiConventionMethod(typeof(MyAppConvention), nameof(MyAppConvention.Find))]
        [HttpDelete("{id}")]
        public IActionResult UpdateII(int id)
        {
            return Ok();
        }

        public ActionResult<Student> GetInfos(int id)
        {
            
            return Ok(new Student());
        }

    }
}
