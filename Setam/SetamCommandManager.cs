using System;
using System.Reflection
using Sora;

namespace Setam;

public class SetamCommandManager
{
    //接收请求->查找指令->(CD检查，启用检查)->指令匹配特性检查->回调结果

    //指令名
    private string _commandName;

    //改用统一方法
    //从私聊请求指令
    public static async ValueTask GetSetamPrivateCommand(object sender, PrivateMessageEventArgs eventArgs)
    {
        
    }
    //从群聊请求指令
    public static async ValueTask GetSetamGroupCommand(object sender, GroupMessageEventArgs eventArgs)
    {
        
    }
    //分析字段
    private void ParseSegment(MessageBody message)
    {
        
    }
    //查找指令
    private void FindCommand(string cmd)
    {
        
    }
    //特性检查
    private void CheckAttribute()
    {

    }
    //指令回调
    private void ReponseCommand(MessageBody message)
    {
        
    }
}
