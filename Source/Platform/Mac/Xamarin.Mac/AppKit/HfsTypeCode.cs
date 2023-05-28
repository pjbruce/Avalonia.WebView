using System;

namespace AppKit;

public enum HfsTypeCode : uint
{
	ClipboardIcon = 1129072976u,
	ClippingUnknownTypeIcon = 1668051061u,
	ClippingPictureTypeIcon = 1668051056u,
	ClippingTextTypeIcon = 1668051060u,
	ClippingSoundTypeIcon = 1668051059u,
	DesktopIcon = 1684370283u,
	FinderIcon = 1179534418u,
	ComputerIcon = 1919905652u,
	FontSuitcaseIcon = 1179011404u,
	FullTrashIcon = 1718907496u,
	GenericApplicationIcon = 1095782476u,
	GenericCdromIcon = 1667523698u,
	GenericControlPanelIcon = 1095782467u,
	GenericControlStripModuleIcon = 1935959414u,
	GenericComponentIcon = 1953001063u,
	GenericDeskAccessoryIcon = 1095782468u,
	GenericDocumentIcon = 1685021557u,
	GenericEditionFileIcon = 1701082214u,
	GenericExtensionIcon = 1229867348u,
	GenericFileServerIcon = 1936881266u,
	GenericFontIcon = 1717987692u,
	GenericFontScalerIcon = 1935895666u,
	GenericFloppyIcon = 1718382713u,
	GenericHardDiskIcon = 1751413611u,
	GenericIDiskIcon = 1768190827u,
	GenericRemovableMediaIcon = 1919774582u,
	GenericMoverObjectIcon = 1836021362u,
	GenericPCCardIcon = 1885564259u,
	GenericPreferencesIcon = 1886545254u,
	GenericQueryDocumentIcon = 1902473849u,
	GenericRamDiskIcon = 1918987620u,
	[Obsolete("Use 'GenericSharedLibraryIcon' instead.")]
	GenericSharedLibaryIcon = 1936223330u,
	GenericSharedLibraryIcon = 1936223330u,
	GenericStationeryIcon = 1935961955u,
	GenericSuitcaseIcon = 1937074548u,
	GenericUrlIcon = 1735750252u,
	GenericWormIcon = 2003792493u,
	InternationalResourcesIcon = 1768319340u,
	KeyboardLayoutIcon = 1801873772u,
	SoundFileIcon = 1936091500u,
	SystemSuitcaseIcon = 2054388083u,
	TrashIcon = 1953657704u,
	TrueTypeFontIcon = 1952868716u,
	TrueTypeFlatFontIcon = 1936092788u,
	TrueTypeMultiFlatFontIcon = 1953784678u,
	UserIDiskIcon = 1969517419u,
	UnknownFSObjectIcon = 1970169459u,
	InternetLocationHttpIcon = 1768712308u,
	InternetLocationFtpIcon = 1768711796u,
	InternetLocationAppleShareIcon = 1768710502u,
	InternetLocationAppleTalkZoneIcon = 1768710516u,
	InternetLocationFileIcon = 1768711785u,
	InternetLocationMailIcon = 1768713569u,
	InternetLocationNewsIcon = 1768713847u,
	InternetLocationNslNeighborhoodIcon = 1768713843u,
	InternetLocationGenericIcon = 1768712037u,
	GenericFolderIcon = 1718379634u,
	DropFolderIcon = 1684172664u,
	MountedFolderIcon = 1835955300u,
	OpenFolderIcon = 1868983396u,
	OwnedFolderIcon = 1870098020u,
	PrivateFolderIcon = 1886549606u,
	SharedFolderIcon = 1936221804u,
	SharingPrivsNotApplicableIcon = 1936223841u,
	SharingPrivsReadOnlyIcon = 1936224879u,
	SharingPrivsReadWriteIcon = 1936224887u,
	SharingPrivsUnknownIcon = 1936225643u,
	SharingPrivsWritableIcon = 2003986804u,
	UserFolderIcon = 1969646692u,
	WorkgroupFolderIcon = 2003201124u,
	GuestUserIcon = 1735750514u,
	UserIcon = 1970496882u,
	OwnerIcon = 1937077106u,
	GroupIcon = 1735554416u,
	AppearanceFolderIcon = 1634758770u,
	AppleMenuFolderIcon = 1634561653u,
	ApplicationsFolderIcon = 1634758771u,
	ApplicationSupportFolderIcon = 1634956656u,
	ColorSyncFolderIcon = 1886547814u,
	ContextualMenuItemsFolderIcon = 1668116085u,
	ControlPanelDisabledFolderIcon = 1668575812u,
	ControlPanelFolderIcon = 1668575852u,
	DocumentsFolderIcon = 1685021555u,
	ExtensionsDisabledFolderIcon = 1702392900u,
	ExtensionsFolderIcon = 1702392942u,
	FavoritesFolderIcon = 1717663347u,
	FontsFolderIcon = 1718578804u,
	InternetSearchSitesFolderIcon = 1769173862u,
	PublicFolderIcon = 1886741094u,
	PrinterDescriptionFolderIcon = 1886413926u,
	PrintMonitorFolderIcon = 1886547572u,
	RecentApplicationsFolderIcon = 1918988400u,
	RecentDocumentsFolderIcon = 1919184739u,
	RecentServersFolderIcon = 1920168566u,
	ShutdownItemsDisabledFolderIcon = 1936221252u,
	ShutdownItemsFolderIcon = 1936221286u,
	SpeakableItemsFolder = 1936747369u,
	StartupItemsDisabledFolderIcon = 1937011268u,
	StartupItemsFolderIcon = 1937011316u,
	SystemExtensionDisabledFolderIcon = 1835098948u,
	SystemFolderIcon = 1835098995u,
	VoicesFolderIcon = 1719037795u,
	AppleScriptBadgeIcon = 1935897200u,
	LockedBadgeIcon = 1818387559u,
	MountedBadgeIcon = 1835164775u,
	SharedBadgeIcon = 1935828071u,
	AliasBadgeIcon = 1633838183u,
	AlertCautionBadgeIcon = 1667392615u,
	AlertNoteIcon = 1852798053u,
	AlertCautionIcon = 1667331444u,
	AlertStopIcon = 1937010544u,
	AppleTalkIcon = 1635019883u,
	AppleTalkZoneIcon = 1635023470u,
	AfpServerIcon = 1634103411u,
	FtpServerIcon = 1718906995u,
	HttpServerIcon = 1752461427u,
	GenericNetworkIcon = 1735288180u,
	IPFileServerIcon = 1769173622u,
	ToolbarCustomizeIcon = 1952675187u,
	ToolbarDeleteIcon = 1952736620u,
	ToolbarFavoritesIcon = 1952866678u,
	ToolbarHomeIcon = 1953001325u,
	ToolbarAdvancedIcon = 1952604534u,
	ToolbarInfoIcon = 1952606574u,
	ToolbarLabelsIcon = 1952607330u,
	ToolbarApplicationsFolderIcon = 1950445683u,
	ToolbarDocumentsFolderIcon = 1950642019u,
	ToolbarMovieFolderIcon = 1951231862u,
	ToolbarMusicFolderIcon = 1951233395u,
	ToolbarPicturesFolderIcon = 1951426915u,
	ToolbarPublicFolderIcon = 1951429986u,
	ToolbarDesktopFolderIcon = 1950643051u,
	ToolbarDownloadsFolderIcon = 1950644078u,
	ToolbarLibraryFolderIcon = 1951164770u,
	ToolbarUtilitiesFolderIcon = 1951757420u,
	ToolbarSitesFolderIcon = 1951626355u,
	AppleLogoIcon = 1667330156u,
	AppleMenuIcon = 1935765612u,
	BackwardArrowIcon = 1650553455u,
	FavoriteItemsIcon = 1717663346u,
	ForwardArrowIcon = 1717662319u,
	GridIcon = 1735551332u,
	HelpIcon = 1751477360u,
	KeepArrangedIcon = 1634889319u,
	LockedIcon = 1819239275u,
	NoFilesIcon = 1852205420u,
	NoFolderIcon = 1852206180u,
	NoWriteIcon = 1853321844u,
	ProtectedApplicationFolderIcon = 1885433968u,
	ProtectedSystemFolderIcon = 1886615923u,
	RecentItemsIcon = 1919118964u,
	ShortcutIcon = 1936224884u,
	SortAscendingIcon = 1634954852u,
	SortDescendingIcon = 1685286500u,
	UnlockedIcon = 1970037611u,
	ConnectToIcon = 1668178804u,
	GenericWindowIcon = 1735879022u,
	QuestionMarkIcon = 1903519091u,
	DeleteAliasIcon = 1684106345u,
	EjectMediaIcon = 1701471587u,
	BurningIcon = 1651864174u,
	RightContainerArrowIcon = 1919115634u
}
