// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputReportReasonPornography : TLReportReasonBase 
	{
		public TLInputReportReasonPornography() { }
		public TLInputReportReasonPornography(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputReportReasonPornography; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2E59D922);
		}
	}
}