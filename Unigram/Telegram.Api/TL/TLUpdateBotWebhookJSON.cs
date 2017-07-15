// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotWebhookJSON : TLUpdateBase 
	{
		public TLDataJSON Data { get; set; }

		public TLUpdateBotWebhookJSON() { }
		public TLUpdateBotWebhookJSON(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateBotWebhookJSON; } }

		public override void Read(TLBinaryReader from)
		{
			Data = TLFactory.Read<TLDataJSON>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8317C0C3);
			to.WriteObject(Data);
		}
	}
}