using Newtonsoft.Json;
using System;

namespace JsonHandler
{
    public class Class1
    {
        public void fun1 ()
        {
            string json = "{\"Id\":1,\"Name\":\"刘备\",\"Age\":\"22\"}";
            //此处模拟在不建实体类的情况下，反转将json返回回dynamic对象
            var DynamicObject = JsonConvert.DeserializeObject<dynamic>(json);
          //  ViewBag.Name = DynamicObject.Name; //此处的Name是无法智能感知的
        }
    }
}
