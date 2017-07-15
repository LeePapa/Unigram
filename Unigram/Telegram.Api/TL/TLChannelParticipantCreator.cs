// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantCreator : TLChannelParticipantBase 
	{
		public TLChannelParticipantCreator() { }
		public TLChannelParticipantCreator(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantCreator; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE3E2E1F9);
			to.Write(UserId);
		}
	}
}