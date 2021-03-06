﻿using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Represent an H.264 NAL packet
	/// </summary>
	[ComImport]
	[Guid("E260E955-14BE-4395-9775-9F02CC0A9D89")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingH264NALPacket
	{
		int GetPayloadSize();
		int GetBytes([Out] out IntPtr buffer);
		int GetBytesWithSizePrefix([Out] out IntPtr buffer); // Contains a 32-bit unsigned big endian size prefix
		int GetDisplayTime([In] ulong requestedTimeScale, [Out] out ulong displayTime);
		int GetPacketIndex([Out] out uint packetIndex);
	}
}
