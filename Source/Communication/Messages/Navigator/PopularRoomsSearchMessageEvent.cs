using System;
using Phoenix.HabboHotel.GameClients;
using Phoenix.Messages;
namespace Phoenix.Communication.Messages.Navigator
{
	internal sealed class PopularRoomsSearchMessageEvent : Interface
	{
		public void imethod_0(GameClient class16_0, ClientMessage class18_0)
		{
			class16_0.GetConnection().SendData(Phoenix.GetGame().GetNavigator().method_11(class16_0, class18_0.PopFixedInt32()));
		}
	}
}
