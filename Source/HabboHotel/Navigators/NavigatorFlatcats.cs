using System;
namespace Phoenix.HabboHotel.Navigators
{
	internal sealed class NavigatorFlatcats
	{
		public int Id;
		public string Caption;
		public int MinRank;
		public bool CanTrade;

		public NavigatorFlatcats(int Id, string Caption, int MinRank, bool CanTrade)
		{
			this.Id = Id;
			this.Caption = Caption;
			this.MinRank = MinRank;
			this.CanTrade = CanTrade;
		}
	}
}
