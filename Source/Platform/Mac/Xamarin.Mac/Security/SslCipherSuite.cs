using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsCipherSuite' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsCipherSuite' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsCipherSuite' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsCipherSuite' instead.")]
public enum SslCipherSuite : uint
{
	SSL_NULL_WITH_NULL_NULL = 0u,
	TLS_NULL_WITH_NULL_NULL = 0u,
	SSL_RSA_WITH_NULL_MD5 = 1u,
	SSL_RSA_WITH_NULL_SHA = 2u,
	SSL_RSA_EXPORT_WITH_RC4_40_MD5 = 3u,
	SSL_RSA_WITH_RC4_128_MD5 = 4u,
	SSL_RSA_WITH_RC4_128_SHA = 5u,
	SSL_RSA_WITH_3DES_EDE_CBC_SHA = 10u,
	SSL_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22u,
	SSL_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23u,
	SSL_DH_anon_WITH_RC4_128_MD5 = 24u,
	SSL_DH_anon_WITH_3DES_EDE_CBC_SHA = 27u,
	TLS_RSA_WITH_NULL_MD5 = 1u,
	TLS_RSA_WITH_NULL_SHA = 2u,
	TLS_RSA_WITH_RC4_128_MD5 = 4u,
	TLS_RSA_WITH_RC4_128_SHA = 5u,
	TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10u,
	TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22u,
	TLS_DH_anon_WITH_RC4_128_MD5 = 24u,
	TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27u,
	TLS_PSK_WITH_NULL_SHA = 44u,
	TLS_RSA_WITH_AES_128_CBC_SHA = 47u,
	TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51u,
	TLS_DH_anon_WITH_AES_128_CBC_SHA = 52u,
	TLS_RSA_WITH_AES_256_CBC_SHA = 53u,
	TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57u,
	TLS_DH_anon_WITH_AES_256_CBC_SHA = 58u,
	TLS_RSA_WITH_NULL_SHA256 = 59u,
	TLS_RSA_WITH_AES_128_CBC_SHA256 = 60u,
	TLS_RSA_WITH_AES_256_CBC_SHA256 = 61u,
	TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103u,
	TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107u,
	TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108u,
	TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109u,
	TLS_PSK_WITH_RC4_128_SHA = 138u,
	TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139u,
	TLS_PSK_WITH_AES_128_CBC_SHA = 140u,
	TLS_PSK_WITH_AES_256_CBC_SHA = 141u,
	TLS_RSA_WITH_AES_128_GCM_SHA256 = 156u,
	TLS_RSA_WITH_AES_256_GCM_SHA384 = 157u,
	TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158u,
	TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159u,
	TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165u,
	TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166u,
	TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167u,
	TLS_PSK_WITH_AES_128_GCM_SHA256 = 168u,
	TLS_PSK_WITH_AES_256_GCM_SHA384 = 169u,
	TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170u,
	TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171u,
	TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172u,
	TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173u,
	TLS_PSK_WITH_AES_128_CBC_SHA256 = 174u,
	TLS_PSK_WITH_AES_256_CBC_SHA384 = 175u,
	TLS_PSK_WITH_NULL_SHA256 = 176u,
	TLS_PSK_WITH_NULL_SHA384 = 177u,
	TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178u,
	TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179u,
	TLS_DHE_PSK_WITH_NULL_SHA256 = 180u,
	TLS_DHE_PSK_WITH_NULL_SHA384 = 181u,
	TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182u,
	TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183u,
	TLS_RSA_PSK_WITH_NULL_SHA256 = 184u,
	TLS_RSA_PSK_WITH_NULL_SHA384 = 185u,
	TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153u,
	TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154u,
	TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155u,
	TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156u,
	TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157u,
	TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158u,
	TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159u,
	TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160u,
	TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161u,
	TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162u,
	TLS_ECDH_RSA_WITH_NULL_SHA = 49163u,
	TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164u,
	TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165u,
	TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166u,
	TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167u,
	TLS_ECDHE_RSA_WITH_NULL_SHA = 49168u,
	TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169u,
	TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170u,
	TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171u,
	TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172u,
	TLS_ECDH_anon_WITH_NULL_SHA = 49173u,
	TLS_ECDH_anon_WITH_RC4_128_SHA = 49174u,
	TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175u,
	TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176u,
	TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177u,
	TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187u,
	TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188u,
	TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189u,
	TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190u,
	TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191u,
	TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192u,
	TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193u,
	TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194u,
	TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195u,
	TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196u,
	TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197u,
	TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198u,
	TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199u,
	TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200u,
	TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201u,
	TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202u,
	TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205u,
	TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206u,
	TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52392u,
	TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52393u,
	TLS_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52395u,
	TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255u,
	TLS_AES_128_GCM_SHA256 = 4865u,
	TLS_AES_256_GCM_SHA384 = 4866u,
	TLS_CHACHA20_POLY1305_SHA256 = 4867u,
	TLS_AES_128_CCM_SHA256 = 4868u,
	TLS_AES_128_CCM_8_SHA256 = 4869u,
	SSL_RSA_WITH_RC2_CBC_MD5 = 65408u,
	SSL_RSA_WITH_IDEA_CBC_MD5 = 65409u,
	SSL_RSA_WITH_DES_CBC_MD5 = 65410u,
	SSL_RSA_WITH_3DES_EDE_CBC_MD5 = 65411u,
	SSL_NO_SUCH_CIPHERSUITE = 65535u
}
