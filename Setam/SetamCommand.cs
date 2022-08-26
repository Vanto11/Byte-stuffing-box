using System;
using Sora;

namespace Setam;

//指令池
public class SetamCommand
{
    public static async ValueTask Mute(object sender, GroupMessageEventArgs eventArgs)
    {
        if (eventArgs.Message.RawText.Equals("在"))
            await eventArgs.Sender.SendPrivateMessage(SoraSegment.Image("https://i.loli.net/2020/11/02/2OgZ1M6YNV5kntS.gif"));
    }

    public static async ValueTask VoteMute(object sender, GroupMessageEventArgs eventArgs)
    {
        if (eventArgs.Message.RawText.Equals("在"))
            await eventArgs.Sender.SendPrivateMessage(SoraSegment.Image("https://i.loli.net/2020/11/02/2OgZ1M6YNV5kntS.gif"));
    }

    public static async ValueTask Kick(object sender, GroupMessageEventArgs eventArgs)
    {
        if (eventArgs.Message.RawText.Equals("在"))
            await eventArgs.Sender.SendPrivateMessage(SoraSegment.Image("https://i.loli.net/2020/11/02/2OgZ1M6YNV5kntS.gif"));
    }

    public static async ValueTask VoteKick(object sender, GroupMessageEventArgs eventArgs)
    {
        if (eventArgs.Message.RawText.Equals("在"))
            await eventArgs.Sender.SendPrivateMessage(SoraSegment.Image("https://i.loli.net/2020/11/02/2OgZ1M6YNV5kntS.gif"));
    }
}