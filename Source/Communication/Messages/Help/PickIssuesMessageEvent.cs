using System;
using Phoenix.HabboHotel.GameClients;
using Phoenix.Messages;
namespace Phoenix.Communication.Messages.Help
{
	internal sealed class PickIssuesMessageEvent : Interface
	{
		public void imethod_0(GameClient class16_0, ClientMessage class18_0)
		{
			if (class16_0.GetHabbo().HasFuse("acc_supporttool"))
			{
				class18_0.PopWiredInt32();
				uint uint_ = class18_0.PopWiredUInt();
				Phoenix.GetGame().GetModerationTool().method_6(class16_0, uint_);
			}
		}
	}
}
