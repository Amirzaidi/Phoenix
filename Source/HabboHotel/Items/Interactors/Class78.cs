using System;
using Phoenix.HabboHotel.GameClients;
using Phoenix.Messages;
using Phoenix.HabboHotel.Items;
namespace Phoenix.HabboHotel.Items.Interactors
{
	internal sealed class Class78 : Class69
	{
		public override void OnPlace(GameClient class16_0, UserItemData class63_0)
		{
		}
		public override void OnRemove(GameClient class16_0, UserItemData class63_0)
		{
		}
		public override void OnTrigger(GameClient class16_0, UserItemData class63_0, int int_0, bool bool_0)
		{
			if (bool_0)
			{
				ServerMessage gClass = new ServerMessage(650u);
				gClass.AppendInt32(0);
				gClass.AppendInt32(5);
				gClass.AppendInt32(0);
				gClass.AppendInt32(class63_0.GetBaseItem().int_0);
				gClass.AppendUInt(class63_0.uint_0);
				gClass.AppendStringWithBreak("");
				gClass.AppendString("I");
				if (class63_0.string_3.Length > 0)
				{
					gClass.AppendString(class63_0.string_3);
				}
				else
				{
					gClass.AppendString("RB");
				}
				gClass.AppendStringWithBreak("HRAH");
				class16_0.method_14(gClass);
				class63_0.method_3(1);
			}
		}
	}
}
