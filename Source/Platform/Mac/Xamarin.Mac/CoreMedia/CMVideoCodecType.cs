using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMVideoCodecType : uint
{
	YUV422YpCbCr8 = 846624121u,
	Animation = 1919706400u,
	Cinepak = 1668704612u,
	JPEG = 1785750887u,
	JPEG_OpenDML = 1684890161u,
	SorensonVideo = 1398165809u,
	SorensonVideo3 = 1398165811u,
	H263 = 1748121139u,
	H264 = 1635148593u,
	Mpeg4Video = 1836070006u,
	Mpeg2Video = 1836069494u,
	Mpeg1Video = 1836069238u,
	DvcNtsc = 1685480224u,
	DvcPal = 1685480304u,
	DvcProPal = 1685483632u,
	DvcPro50NTSC = 1685468526u,
	DvcPro50PAL = 1685468528u,
	DvcProHD720p60 = 1685481584u,
	DvcProHD720p50 = 1685481585u,
	DvcProHD1080i60 = 1685481526u,
	DvcProHD1080i50 = 1685481525u,
	DvcProHD1080p30 = 1685481523u,
	DvcProHD1080p25 = 1685481522u,
	AppleProRes4444 = 1634743400u,
	AppleProRes422HQ = 1634755432u,
	AppleProRes422 = 1634755438u,
	AppleProRes422LT = 1634755443u,
	AppleProRes422Proxy = 1634755439u,
	Hevc = 1752589105u
}
