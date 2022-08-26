using System;
using Sora;
using Enumeration;

namespace Setam.SetamAttribute;

//Setam指令特性
[AttributeUsage(AttributeTargets.Method)]
public class SetamUtil : Attribute
{
    //适用等级
    public int CoverLevel { get; set; }

    //适用协议
    public ProtocolType protocolType {get; set;} = Normal;


}