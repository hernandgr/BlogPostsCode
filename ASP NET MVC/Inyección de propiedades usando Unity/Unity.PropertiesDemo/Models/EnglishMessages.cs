
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unity.PropertiesDemo.Models
{
public class EnglishMessages : IMessages
{
    public string Greeting()
    {
        return "Hello!";
    }
}
}