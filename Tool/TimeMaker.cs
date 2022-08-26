using System;
using Sora;

namespace Tool;

//时间记录
//需要载入配置
public static class TimeMaker
{
    public enum MakeFlag
    {
        //在职期限
        Tenure,
        //禁权时长
        Ban,
        //投票期限
        Vote,

    }

    public struct MakeRecord
    {
        internal long        GroupId     { get; set; }
        internal long        UserId      { get; set; }
        internal MakeFlag    EventName   { get; set; }
        internal DateTime    EndTime     { get; set; }
    }

    //开始计时并监听线程
    public void StartTimer()
    {

    }

    //没有计时事件时关闭线程
    public void EndTimer()
    {

    }

    //遍历所有计时器, 根据配置设定检查隔间
    public void CheckExpire()
    {

    }
}