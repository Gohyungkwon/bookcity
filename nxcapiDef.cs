/**
 * ===========================================================
 * 넥서스커뮤니티 큐브 시스템
 * Copyright (c) 2010 by NEXUS COMMUNITY, Inc.
 *
 * 파 일 명 : nxcapiDef.cs
 * 파일설명 : 
 * ===========================================================
 * 작성일자              작성자     내용
 * -----------------------------------------------------------
 * 2010/09/12   		 Marcos		최초생성
 * 2010/10/28         Sam        수정
 * ===========================================================
 */
using System;
//using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace bookcity
{
   class nxcapiDef
   {
      public const int ctmpSuccess = 1;

      /*++++++++++++++++++++++++*/
      /*  Length constants      */
      /*++++++++++++++++++++++++*/
      public const int ctmpMaxAccountInfoLen       = 32;
      public const int ctmpMaxAuthInfoLen          = 32;
      public const int ctmpMaxApplLen              = 64;
      public const int ctmpMaxAgentId              = 10;
      public const int ctmpMaxDeviceLen            = 24;
      public const int ctmpMaxErrorMSGLen          = 256;
      public const int ctmpMaxIPAddrLen            = 15;
      public const int ctmpMaxLogIDLen             = 16;
      public const int ctmpMaxManufacturerLen      = 24;
      public const int ctmpMaxNameLen              = 16;
      public const int ctmpMaxNetLen               = 16;
      public const int ctmpMaxPrivateDataElements  = 3;
      public const int ctmpMaxPrivateRawDataLen    = 128;
      public const int ctmpMaxTimeStamp            = 15;
      public const int ctmpMaxAttDataLen           = 1024;
      public const int ctmpMaxSysDataLen           = 256;
      public const int ctmpMaxReadyCount           = 50;
      public const int ctmpMaxEmployeeLen          = 32;
      public const int ctmpMaxLen30                = 31;
      public const int ctmpMaxLen20                = 21;
   }

   public enum ctmpACSLevel_Def
   {
      ACS_LEVEL1 = 1,
      ACS_LEVEL2 = 2,
      ACS_LEVEL3 = 3,
      ACS_LEVEL4 = 4
   } 

	public enum ctmpAction_Def
   {
	   ctmpK_BargeIn = 100, 
		ctmpK_RingBack = 101, 
		ctmpK_capmOn = 102
	}

	// Agent Filter (12XX)
	public enum ctmpAgentFilter_Def
   {
			ctmpF_LoggedOn          = 1,
			ctmpF_LoggedOff         = 2,
			ctmpF_NotReady          = 4,
			ctmpF_Ready             = 8,
			ctmpF_WorkNotReady      = 16,			/* CSTA2 Removed */
			ctmpF_WorkReady         = 32,
			ctmpF_WorkingAfterCall  = 64,		   /* CSTA2 Added */
			ctmpF_Busy              = 128
	} 

	public enum ctmpEventKind_Def
	{
		ctmpEK_CallCleared			      = 1,
		ctmpEK_Confernced			         = 2,
		ctmpEK_ConnectionCleared	      = 3,
		ctmpEK_Delivered			         = 4,
		ctmpEK_Diverted				      = 5,
		ctmpEK_Established			      = 6,
		ctmpEK_Failed				         = 7,
		ctmpEK_Held					         = 8,
		ctmpEK_NetworkReached		      = 9,
		ctmpEK_Originated			         = 10,
		ctmpEK_Queued				         = 11,
		ctmpEK_Retrieved			         = 12,
		ctmpEK_ServiceInitated		      = 13,
		ctmpEK_Transferred			      = 14,
		ctmpEK_Route				         = 15,
		ctmpEK_RouteEnded			         = 16,
		ctmpEK_DummyCall			         = 17,
		ctmpEK_eDiverted			         = 18,
		
		ctmpEK_CallInformation		      = 101,
		ctmpEK_DoNotDisturb			      = 102,
		ctmpEK_Forwarding			         = 103,
		ctmpEK_MessageWaiting		      = 104,
		ctmpEK_AutoAnswer			         = 105,	/* CSTA2 */
		ctmpEK_MicrophoneMute		      = 106,	/* CSTA2 */
		ctmpEK_SpeakerMute			      = 107,	/* CSTA2 */
		ctmpEK_SpeakerVolume		         = 108,	/* CSTA2 */
		
		ctmpEK_SystemEventIE		         = 200,   // added by K.CH.S 2008.01.31 nexuscube
		
		ctmpEK_LoggedOn				      = 201,
		ctmpEK_LoggedOff			         = 202,
		ctmpEK_NotReady				      = 203,
		ctmpEK_Ready				         = 204,
		ctmpEK_OtherWork			         = 205,
		ctmpEK_AfterCallWork		         = 206,
		ctmpEK_eLoggedOn			         = 207,
		ctmpEK_eLoggedOff			         = 208,
		ctmpEK_eNotReady			         = 209,
		ctmpEK_eReady				         = 210,
		
		ctmpEK_MLogedOn				      = 240,
		ctmpEK_MLogedOff			         = 241,
		ctmpEK_MReady				         = 243,
		ctmpEK_MNotReady			         = 242,
		ctmpEK_MAfterCallWork		      = 244,
		ctmpEK_MDelivery			         = 245,
		ctmpEK_MComplete			         = 256,
		ctmpEK_BackInService		         = 23,		/* CSTA2 */
		ctmpEK_OutOfService			      = 24,		/* CSTA2 */
		ctmpEK_Private				         = 25,		/* CSTA2 */
		ctmpEK_VoiceUnitPlay		         = 41,		/* CSTA2 */
		ctmpEK_VoiceUnitRecord		      = 42,		/* CSTA2 */
		ctmpEK_VoiceUnitReview		      = 43,		/* CSTA2 */
		ctmpEK_VoiceUnitStop		         = 44,		/* CSTA2 */
		ctmpEK_VoiceUnitSuspendPlay      = 45,		/* CSTA2 */
		ctmpEK_VoiceUnitSuspendRecord    = 46,		/* CSTA2 */
		ctmpEK_VoiceUnitAttributeChange  = 47,	   /* CSTA2 */
		ctmpEK_MonitorEnded			      = 61,		/* ASAI  */
		ctmpEK_PrivateStatus		         = 63,		/* ASAI  */
		ctmpEK_SysStat				         = 65,		/* ASAI  */
		ctmpEK_SysStatEnded			      = 66,		/* ASAI  */
		ctmpEK_RouteRegisterAbort	      = 71,		/* ASAI  */
		ctmpEK_RouteRequest			      = 110,	/* ASAI  */
		ctmpEK_RouteEnd				      = 111,	/* ASAI  */
		ctmpEK_CCSEDisConnect		      = 250, 
		ctmpEK_CCSEConnect			      = 251,										
		ctmpEK_CCSEFail				      = 995,	// 2001/01/29 sbkyun
		ctmpEK_CCSELinkFailPbx		      = 996,	// 2001/01/29 sbkyun  //ASAI발생
		ctmpEK_CCSENoActPbx			      = 997,	// 2001/01/29 sbkyun  //ASAI발생
		ctmpEK_CCSERecovery			      = 998,	// 2001/01/29 sbkyun  //ASAI발생
		ctmpEK_CCSEDown				      = 999,	// CTMP Down sbkyun - 2001/01/29	/* for CCSE Down by dwlim 990127 req kcpark */
		
		ctmpEK_Popup				         = 254,	// CTMP Oubound PopupEvent
		ctmpEK_PwdConfirm			         = 253,	/* 2008.07.07 skkim add ars event make */
	}

	public enum ctmpLocalConnectState_Def 
   {
	   ctmpES_Null       = 0,
		ctmpES_Initiate   = 1,
		ctmpES_Altering   = 2,
		ctmpES_Connect    = 3,
		ctmpES_Hold       = 4,
		ctmpES_Queued     = 5,
		ctmpES_Fail       = 6
	}

	public enum ctmpEventCauses_Def 
   {
		ctmpEC_ActiveMonitor                = 1,
		ctmpEC_Alternate                    = 2,
		ctmpEC_Busy                         = 3,
		ctmpEC_CallBack                     = 4,
		ctmpEC_CallCancelled                = 5,
		ctmpEC_CallForwardAlways            = 6,
		ctmpEC_CallForwardBusy              = 7,
		ctmpEC_CallForwardNoAnswer          = 8,
		ctmpEC_CallForward                  = 9,
		ctmpEC_CallNotAnswered              = 10,
		ctmpEC_CallPickup                   = 11,
		ctmpEC_CampOn                       = 12,
		ctmpEC_DestNotObtainable            = 13,
		ctmpEC_DoNotDisturb                 = 14,
		ctmpEC_IncompatibleDestination      = 15,
		ctmpEC_InvalidAccountCode           = 16,
		ctmpEC_KeyConference                = 17,
		ctmpEC_Lockout                      = 18,
		ctmpEC_Maintenance                  = 19,
		ctmpEC_NetworkCongestion            = 20,
		ctmpEC_NetworkNotObtainable         = 21,
		ctmpEC_NewCall                      = 22,
		ctmpEC_NoAvailableAgents            = 23,
		ctmpEC_Override                     = 24,
		ctmpEC_Park                         = 25,
		ctmpEC_Overflow                     = 26,
		ctmpEC_Recall                       = 27,
		ctmpEC_Redirected                   = 28,
		ctmpEC_ReorderTone                  = 29,
		ctmpEC_ResourcesNotAvailable        = 30,
		ctmpEC_SilentMonitor                = 31,
		ctmpEC_Transfer                     = 32,
		ctmpEC_TrunksBusy                   = 33,
		ctmpEC_VoiceUnitInitiator           = 34,
		ctmpEC_Blocked                      = 35,					/* CSTA2 Added */
		ctmpEC_CharCountReached             = 36,
		ctmpEC_Consultation                 = 37,
		ctmpEC_Distributed                  = 38,
		ctmpEC_DTMFToneDetected             = 39,
		ctmpEC_DurationExceeded             = 40,
		ctmpEC_EndOfDataDetected            = 41,
		ctmpEC_EnteringDistribution         = 42,
		ctmpEC_ForcedPause                  = 43,
		ctmpEC_MakeCall                     = 44,
		ctmpEC_MessageSizeExceeded          = 45,
		ctmpEC_NetworkSignal                = 46,
		ctmpEC_NextMessage                  = 47,
		ctmpEC_NormalClearing               = 48,
		ctmpEC_NoSpeechDetected             = 49,
		ctmpEC_NumberChanged                = 50,
		ctmpEC_SingleStepConference         = 51,
		ctmpEC_SingleStepTransfer           = 52,
		ctmpEC_SpeechDetected               = 53,
		ctmpEC_SwitchTerminated             = 54,
		ctmpEC_TerminationChangeReceived    = 55,
		ctmpEC_TimeOut                      = 56
	}

	public enum ctmpAgentMode_Def 
   {
	   ctmpV_AgentLogin           = 0,
		ctmpV_AgentLogout          = 1,
		ctmpV_AgentNotReady        = 2,
		ctmpV_AgentReady           = 3,
		ctmpV_AgentOtherWork       = 4,
		ctmpV_AgentAfterCallWork   = 5
	}

	public enum ctmpeAgentMode_Def
   {
	   ctmpV_eAgentLogin          = 0,
		ctmpV_eAgentLogout         = 1,
		ctmpV_eNotReady            = 2,
		ctmpV_eReady               = 3,	
		ctmpV_eAgentOtherWork      = 4,
		ctmpV_eAgentAfterCallWork  = 5,
		ctmpV_eAgentMailClear      = 6
	}	

	public enum ctmpEventCallCause_Def 
   {
		ctmpV_AddedParty           = 1,
		ctmpV_AlertingDevice       = 2,
		ctmpV_AnsweringDevice      = 3,
		ctmpV_CalledNumber         = 4,
		ctmpV_CallingDevice        = 5,
		ctmpV_ConfController       = 6,
		ctmpV_DivertingDevice      = 7,
		ctmpV_FailedDevice         = 8,
		ctmpV_HoldingDevice        = 9,
		ctmpV_LastRedirection      = 10,
		ctmpV_ReleasingDevice      = 11,
		ctmpV_RetrievingDevice     = 12,
		ctmpV_TransferringDevice   = 13,
		ctmpV_TrunkUsed            = 14
	}

	public enum ctmpAgentType_Def 
   {
	   ctmpV_NotUse   = 0,
		ctmpV_PSTN     = 1,
		ctmpV_WEB      = 2,
		ctmpV_PSTNWEB  = 3,
	}

	// (MakePredictiveCall)
	public enum ctmpAllocationState_Def 
   {
		ctmpP_CallDelivered  = 0, 
		ctmpP_Established    = 1
	}

	public enum ctmpAttributeToQuery_Def 
   {
	   ctmpV_EncodingAlgorithm = 0,
		ctmpV_SampleRate        = 1,
		ctmpV_Duration          = 2,
		ctmpV_FileName          = 3,
		ctmpV_CurrentPosition   = 4,
		ctmpV_CurrentSpeed      = 5,
		ctmpV_CurrentVolume     = 6,
		ctmpV_CurrentLevel      = 7,
		ctmpV_CurrentState      = 8
	}

	public enum ctmpCallFilter_Def 
   {
	   ctmpF_CallCleared       = 1,
		ctmpF_Conferenced       = 2,
		ctmpF_ConnectionCleared = 4,
		ctmpF_Delivered         = 8,
		ctmpF_Diverted          = 16,
		ctmpF_Established       = 32,
		ctmpF_Failed            = 64,
		ctmpF_Held              = 128,
		ctmpF_NetworkReached    = 256,
		ctmpF_Originated        = 512,
		ctmpF_Queued            = 1024,
		ctmpF_Retrieved         = 2048,
		ctmpF_ServiceInitiated  = 4096,
		ctmpF_Transferrd        = 8192
	} 

	public enum ctmpMode_Def 
   {
		ctmpV_Off   = 0, 
		ctmpV_On    = 1
	}

	public enum ctmpForward_Def 
   {
		ctmpC_ImmediateOn    = 0,
		ctmpC_ImmediateOff   = 1,
		ctmpC_BusyOn         = 2,
		ctmpC_BusyOff        = 3,
		ctmpC_NoAnsOn        = 4,
		ctmpC_NoAnsOff       = 5,
		ctmpC_BusyIntOn      = 6,
		ctmpC_BusyIntOff     = 7,
		ctmpC_BusyExtOn      = 8,
		ctmpC_BusyExtOff     = 9,
		ctmpC_NoAnsIntOn     = 10,
		ctmpC_NoAnsIntOff    = 11,
		ctmpC_NoAnsExtOn     = 12,
		ctmpC_NoAnsExtOff    = 13,
		ctmpC_ImmIntOn       = 14,					/* CSTA2 Added */
		ctmpC_ImmIntOff      = 15,
		ctmpC_ImmExtOn       = 16,
		ctmpC_ImmExtOff      = 17
	}

	public enum ctmpWorkMode_Def
	{
      ctmp_AUX_WORK  = 1,
		ctmp_AFTCAL_WK = 2,
		ctmp_AUTO_IN   = 3,
		ctmp_MANUAL_IN = 4
	}

	public enum ctmpSystemEventIE_Def
	{
		ctmpSE_Tenant                       = 1,
		ctmpSE_Group                        = 2,
		ctmpSE_Part                         = 3,
		ctmpSE_Agent                        = 4,
		ctmpSE_Route                        = 5,
		
		ctmpSE_GetMaxCPSQ                   = 100,    /* for outbound system */
		ctmpSE_BlackListInsert              = 101,    /* for outbound system */
		ctmpSE_CallbackCampaign             = 102,    /* for outbound system */
		ctmpSE_CallbackListInsert           = 103,    /* for outbound system */
		ctmpSE_CampaignListHandle           = 104,    /* for outbound system */
		ctmpSE_PreviewMakeCall              = 105,    /* for outbound system */
		ctmpSE_CounselResult                = 106,    /* for outbound system */
		ctmpSE_Popup                        = 107,    /* for outbound system */
		/*
		// Routing
		*/
		cubeSE_ApplyScenario                = 200,
		cubeSE_SystemCallRetrieve           = 201,
		cubeSE_RegisterCall                 = 210,
		cubeSE_AllowRouting                 = 211,
		cubeSE_SelectedTarget               = 212,
	}

	public enum ctmpConnectionID_Def 
	{
      STATIC_ID   = 0,
		DYNAMIC_ID  = 1
	}

	public enum ctmpGateMode_Def 
	{
		ctmpV_Dn          = 0,
		ctmpV_RoutePoint  = 1,
		ctmpV_MonitorGate = 2,
		ctmpV_Manager     = 9
	}

	public enum ctmpDataPathDirection_Def 
   {
		ctmpV_FromRequestor  = 0,
		ctmpV_ToRequestor    = 1,
		ctmpV_BiDirectional  = 2
	} 

	public enum ctmpDataPathType_Def 
   {
		ctmpV_Text           = 0, 
		ctmpV_DigitalVoice   = 1
	} 

	public enum ctmpServerVersion_Def 
	{
		ctmpV_CTMPV20 = 0x20,
		ctmpV_CTMPV30 = 0x30
	}

	public enum ctmpDeviceIDStatus_Def 
   {
		ID_PROVIDED       = 0,
		ID_NOT_KNOWN      = 1,
		ID_NOT_REQUIRED   = 2
	}

	public enum ctmpDeviceClass_Def
   {
		ctmpV_Voice       = 0x80,
		ctmpV_Data        = 0x40,
		ctmpV_Image       = 0x20,
		ctmpV_OtherDevice = 0x10,
		ctmpV_Audio       = 0x08, 
		ctmpV_Transfer    = 0,				// Meridian Consult Option
		ctmpV_Conference  = 1				// Meridian Consult Option
	}

	public enum ctmpDeviceIDType_Def
   {
		DEVICE_IDENTIFIER                         = 0,
		IMPLICIT_PUBLIC                           = 20,
		EXPLICIT_PUBLIC_UNKNOWN                   = 30,
		EXPLICIT_PUBLIC_INTERNATIONAL             = 31,
		EXPLICIT_PUBLIC_NATIONAL                  = 32,
		EXPLICIT_PUBLIC_NETWORK_SPECIFIC          = 33,
		EXPLICIT_PUBLIC_SUBSCRIBER                = 34,
		EXPLICIT_PUBLIC_ABBREVIATED               = 35,
		IMPLICIT_PRIVATE                          = 40,
		EXPLICIT_PRIVATE_UNKNOWN                  = 50,
		EXPLICIT_PRIVATE_LEVEL3_REGIONAL_NUMBER   = 51,
		EXPLICIT_PRIVATE_LEVEL2_REGIONAL_NUMBER   = 52,
		EXPLICIT_PRIVATE_LEVEL1_REGIONAL_NUMBER   = 53,
		EXPLICIT_PRIVATE_PTN_SPECIFIC_NUMBER      = 54,
		EXPLICIT_PRIVATE_LOCAL_NUMBER             = 55,
		EXPLICIT_PRIVATE_ABBREVIATED              = 56,
		OTHER_PLAN                                = 60,
		TRUNK_IDENTIFIER                          = 70,
		TRUNK_GROUP_IDENTIFIER                    = 71
	} 

	public enum ctmpCTILink_Def 
	{
      ctmpV_None     = 0,
		ctmpV_ASAI     = 1,
		ctmpV_Meridian = 2,
		ctmpV_CSTA1    = 3,
		ctmpV_CSTA2    = 4,
		ctmpV_CSTA3    = 5,
		/*	2007.03.28	jbpark	한고원
		**	Ericsson(CSTA1)에서 ctmpF_DivertDirect 지원안되는 버그 수정
		*/
		ctmpV_NotSupport = 7
	}

	public enum ctmpSyncMode_Def 
	{
	   ctmpV_SYNC        = 1, 
		ctmpV_ASYNC       = 2,
		ctmpV_ASYNC_EVENT = 3
	}

	// (QueryDevice)
	public enum ctmpDeviceType_Def
   {
		   ctmpV_Station        = 0,
			ctmpV_Line           = 1,
			ctmpV_Button         = 2,
			ctmpV_ACD            = 3,
			ctmpV_Trunk          = 4,
			ctmpV_Operator       = 5,
			ctmpV_Other          = 6,
			ctmpV_StationGroup   = 16,
			ctmpV_LineGroup      = 17,
			ctmpV_ButtonGroup    = 18,
			ctmpV_ACDGroup       = 19,
			ctmpV_TrunkGroup     = 20,
			ctmpV_OperatorGroup  = 21,
			ctmpV_OtherGroup     = 255,
			ctmpV_ParkingDevice  = 22	/* CSTA2 Added */
	}

	public enum ctmpEncodingAlgorithm_Def
   {
		ctmpV_ADPCM6K     = 0,
	   ctmpV_ADPCM8K     = 1,
		ctmpV_MuLawPCM6K  = 2,
		ctmpV_ALawPCM6K   = 3
	}

	public enum ctmpError_Def 
	{
		ctmpPbxErr	                  = 1000,
		ctmpUnspecCstaErr             = 1001,
		ctmpCstaBadErr                = 1002,
		ctmpOpGeneric                 = 1101,
		ctmpReqIncomWithObj           = 1102,
		ctmpValueOutOfRange           = 1103,
		ctmpObjectNotKnown            = 1104,
		ctmpInvCallingDevice          = 1105,
		ctmpInvCalledDevice           = 1106,
		ctmpInvForwardingDest         = 1107,
		ctmpPrivViolSpecDev           = 1108,
		ctmpPrivViolCalledDev         = 1109,
		ctmpPrivViolCallingDev        = 1110,
		ctmpInvCallIdentifier         = 1111,
		ctmpInvDevIdentifier          = 1112,
		ctmpInvConnIdentifier         = 1113,
		ctmpInvalidDest               = 1114,
		ctmpInvalidFeature            = 1115,
		ctmpInvAllocState             = 1116,
		ctmpInvCrossRefId             = 1117,
		ctmpInvObjectType             = 1118,
		ctmpSecurityViol              = 1119,
		ctmpInvCSTAAppCor             = 1120,  	/* CSTA2 Added */
		ctmpAccountCode               = 1121,
		ctmpAuthCode                  = 1122,
		ctmpReqIncCallingDev          = 1123,
		ctmpReqIncCalledDev           = 1124,
		ctmpInvMessageID              = 1125,
		ctmpMessageIDReq              = 1126,
		ctmpMediaIncompatible         = 1127,
		ctmpStGeneric                 = 1201,
		ctmpBadObjState               = 1202,
		ctmpInvConnIdActCall          = 1203,
		ctmpNoActiveCall              = 1204,
		ctmpNoHeldCall                = 1205,
		ctmpNoCallToClear             = 1206,
		ctmpNoConnToClear             = 1207,
		ctmpNoCallToAnswer            = 1208,
		ctmpNoCallToComplete	      	= 1209,
		ctmpNoAbleToPlay		      	= 1210,		/* CSTA2 Added */
		ctmpNoAbleToResume	      	= 1211,
		ctmpEndOfMessage		      	= 1212,
		ctmpBeginOfMessage	      	= 1213,
		ctmpMessageSuspended	      	= 1214,
		ctmpSysGeneric			      	= 1301,
		ctmpServiceBusy		      	= 1302,
		ctmpResourceBusy		      	= 1303,
		ctmpResOutOfServ		      	= 1304,
		ctmpNetBusy				      	= 1305,
		ctmpNetOutOfServ		      	= 1306,
		ctmpOverallMonLimEx			   = 1307,
		ctmpConfMemberLimEx			   = 1308,
		ctmpSubsGeneric				   = 1401,
		ctmpObjMonLimEx				   = 1402,
		ctmpExTrunkLimEx			      = 1403,
		ctmpOutstandReqLimEx		      = 1404,
		ctmpPerfGeneric				   = 1501,
		ctmpPerfLimEx				      = 1502,
		ctmpUnspecified				   = 1600,
		ctmpSeqNumErr				      = 1601,
		ctmpTimeStampErr			      = 1602,
		ctmpPacErr					      = 1603,
		ctmpSealErr					      = 1604,

		ctmpUnassignNum               = 1701,
		ctmpNormalClearing            = 1702,
		ctmpUserBusy                  = 1703,
		ctmpNoUserRespond             = 1704,
		ctmpCallRejected              = 1705,
		ctmpNumberChanged             = 1706,
		ctmpInvalidNumber             = 1707,
		ctmpFacilityRejected          = 1708,
		ctmpUnSpecified               = 1709,
		ctmpNoCircuitAvail            = 1710,
		ctmpTempFail                  = 1711,
		ctmpSwitchEquip               = 1712,
		ctmpFacilityNotScrib          = 1713,
		ctmpOutGoingBarred            = 1714,
		ctmpBearerNotAvail            = 1715,
		ctmpInvalidCRV                = 1716,
		ctmpChannelDoNotExist         = 1717,
		ctmpIncompatibleDest          = 1718,
		ctmpInvalidMessage            = 1719,
		ctmpMandatoryIeMissing        = 1720,
		ctmpMessageNotExist           = 1721,
		ctmpMessageNotComp            = 1722,
		ctmpIENotExist                = 1723,
		ctmpInvalidIEContents         = 1724,
		ctmpRecoveryTimerExpiry       = 1725,
		ctmpProtocolError             = 1726,
		ctmpNormalUnspec              = 1727,
		ctmpAgentToHook1              = 1751,
		ctmpAgentNotMember            = 1752,
		ctmpAgentStateIcon            = 1753,
		ctmpAgentLoggedMax            = 1754,
		ctmpIncorrectNum              = 1755,
		ctmpAgentNotLogin             = 1756,
		ctmpInSameState               = 1757,
		ctmpTimedAnswer               = 1758,
		ctmpVoiceEnergy               = 1759,
		ctmpNoAnswer                  = 1760,
		ctmpTrunkNotAvail             = 1761,
		ctmpCalssifierNot             = 1762,
		ctmpQueueFull                 = 1763,
		ctmpRemainInQueue             = 1764,
		ctmpAnswerMachine             = 1765,
		ctmpCallForwarding            = 1766,
		ctmpPrincipalBusy             = 1767,
		ctmpOutOfService              = 1768,
		ctmpDoNotAnswer               = 1769,
		ctmpRedirected                = 1770,
		ctmpSendAllCalls              = 1771,
		ctmpNetworkOutOf              = 1772,
		ctmpResourceNot               = 1773,
		ctmpHuntNotAdmin              = 1774,
		ctmpAgentToHook2              = 1775,
		ctmpPermissionDeny            = 1776,
		ctmpAdminInProgress           = 1777,
		ctmpFeatureReject             = 1778,
		ctmpServiceNotAvail           = 1779,
		ctmpServiceNotImple           = 1780,
		ctmpInCompatibleOpt           = 1781,
		ctmpTerminated                = 1782,
		ctmpInternalAudit             = 1783,
		ctmpConferenceError           = 1784,
		ctmpSinglestepconfNot         = 1785,
		ctmpSinglestepconfFull		   = 1786,

		ctmpAlreadyAdded			      = 2001,
		ctmpAsn1DecodeErr			      = 2002,
		ctmpAsn1EncodeErr			      = 2003,
		ctmpDupOpenServer			      = 2004,
		ctmpFileOpenError			      = 2005,
		ctmpInvLicenseKey			      = 2006,
		ctmpIsCurrentDn				   = 2007,
		ctmpIsOpenDn				      = 2008,
		ctmpLibFail					      = 2009,
		ctmpLinkConnectFail			   = 2010,
		ctmpLinkDown				      = 2011,
		ctmpNotMemberDn				   = 2012,
		ctmpNotOpen					      = 2013,
		ctmpOpenLimitReached		      = 2014,
		ctmpTimeout					      = 2015,
		ctmpTooManyOpens			      = 2016,
		ctmpUnknownErrCode			   = 2017,
		ctmpNotSupport				      = 2018,		// 2000.7.14 - SHK
		ctmpCCSEFail				      = 2020,		// 2001.1.29 - sbkyun
		ctmpCCSELinkFailPbx			   = 2021, 
		ctmpCCSENoActPbx			      = 2022,
		ctmpV30Error				      = 2023,
		
		ctmpAlreadyOpen				   = 3001,
		ctmpBodyErr					      = 3002,
		ctmpHeadErr					      = 3003,
		ctmpInvAgentMode			      = 3004,
		ctmpInvDeviceType			      = 3005,
		ctmpInvDNDMode				      = 3006,
		ctmpInvGate					      = 3007,
		ctmpInvNetType				      = 3008,
		ctmpInvParam				      = 3009,
		ctmpNoEvent					      = 3010,
		ctmpNotOn					      = 3011,
		ctmpRpcConnecFail			      = 3012,
		ctmpServerTimeOut			      = 3013,
		ctmpServerUnknown			      = 3014,
		ctmpUnsupAPIversion			   = 3015,
		ctmpUnsupProc				      = 3016,
		ctmpAcseTimeout				   = 3017,
		ctmpNotCicrLoad				   = 3018,
		ctmpAgentIdNotFound			   = 3019,
		ctmpInvalidInvokeId			   = 3020, 
		ctmpDataNotFound			      = 3021,
		ctmpDifferentData			      = 3022,
		ctmpExistData				      = 3023,
		ctmpUsingData				      = 3024,
		ctmpDataFull				      = 3025,
		ctmpInvDN					      = 3026,		// 2000.7.14 - SHK
		ctmpTooManyMultiAddDeviceDn	= 3040,
		ctmpStartReceiveErr			   = 3041
	}

	public enum ctmpFailCall_Def
   {
		ctmpV_CampOn   = 0, 
		ctmpV_RingBack = 1, 
		ctmpV_Intrude  = 2
	}

	public enum ctmpFeature_Def 
   {
		FT_CAMP_ON     = 0,
		FT_CALL_BACK   = 1,
		FT_INTRUDE     = 2
	}

	// Feature Filter (11XX)
	public enum ctmpFeatureFilter_Def
   {
		ctmpF_CallInformation   = 1,
		ctmpF_DoNotDisturb      = 2,
		ctmpF_Forwarding        = 4,
		ctmpF_MessageWaiting    = 8,
		ctmpF_AutoAnswer        = 16,				/* CSTA2 Added */
		ctmpF_MicrophoneMute    = 32,
		ctmpF_SpeakerMute       = 64,
		ctmpF_SpeakerVolume     = 128
	}

	public enum ctmpInvokeIDType_Def 
   {
		APP_GEN_ID,		/* application will provide invokeIDs; any 4-byte value is legal */
		LIB_GEN_ID		/* library will generate invokeIDs in the range 1-32767 */
	}

	public enum ctmpLevel_Def 
   {
		ctmp_HOME_WORK_TOP         = 1,
		ctmp_AWAY_WORK_TOP         = 2,
		ctmp_DEVICE_DEVICE_MONITOR = 3,
		ctmp_CALL_DEVICE_MONITOR   = 4,
		ctmp_CALL_CONTROL          = 5,
		ctmp_ROUTING               = 6,
		ctmp_CALL_CALL_MONITOR     = 7
	}

	// Maintenance Filter (13XX)
	public enum ctmpMaintenanceFilter_Def 
   {
		ctmpF_BackInService  = 1,
		ctmpF_OutOfService   = 2
	}

	// (SingleStepConference)
	public enum ctmpParticipationType_Def 
   {
		ctmpV_Slient = 0, 
		ctmpV_Active = 1
	}

	public enum ctmpProtocolType_Def
   {
		ctmpK_None           = 0, 
		ctmpK_MeridianLink   = 1, 
		ctmpK_CstaPrivate    = 2
	}

	public enum ctmpQueryDeviceFeature_Def
   {
		ctmpV_MsgWaitingOn      = 0,
		ctmpV_DoNotDisturbOn    = 1,
		ctmpV_Forward           = 2,
		ctmpV_LastDialed        = 3,
		ctmpV_DeviceInfo        = 4,
		ctmpV_AgentState        = 5,
		ctmpV_RoutingEnabled    = 6,		/* CSTA2 */
		ctmpV_AutoAnswer        = 7,		/* CSTA2 */
		ctmpV_MicrophoneMuteOn  = 8,		/* CSTA2 */
		ctmpV_SpeakerMuteOn     = 9,		/* CSTA2 */
		ctmpV_SpeakerVolume     = 10		/* CSTA2 */
	}

	public enum ctmpServerTrace_Def 
   {
		ctmpV_NormalTrace    = 1,
		ctmpV_NetworkTrace   = 2,
		ctmpV_FullTrace      = 3
	}

	public enum ctmpSex_Def
   {
		ctmpV_Male     = 0,
		ctmpV_Female   = 1
	}

	public enum ctmpSimpleCallState_Def 
   {
		ctmpSS_CallNull               = 0,
		ctmpSS_CallPending            = 1,
		ctmpSS_CallOriginated         = 3,
		ctmpSS_CallDelivered          = 35,
		ctmpSS_CallDeliveredHeld      = 36,
		ctmpSS_CallReceived           = 50,
		ctmpSS_CallEstablished        = 51,
		ctmpSS_CallEstablishedHeld    = 52,
		ctmpSS_CallReceivedOnHold     = 66,
		ctmpSS_CallEstablishedOnHold  = 67,
		ctmpSS_CallQueued             = 83,
		ctmpSS_CallQueuedHeld         = 84,
		ctmpSS_CallFailed             = 99,
		ctmpSS_CallFailedHeld         = 100
	}

	public enum ctmpState_Def 
   {
		ctmpV_Stop           = 0,
		ctmpV_Play           = 1,
		ctmpV_Record         = 2,
		ctmpV_SuspendPlay    = 3,
		ctmpV_SuspendRecord  = 4,
		ctmpV_Review         = 5
	}

	public enum ctmpStreamType_Def 
   {
		ST_CSTA        = 1,
		ST_OAM         = 2,
		ST_DIRECTORY   = 3,
		ST_NMSRV       = 4
	}

	public enum ctmpSystemStatus_Def 
   {
		ctmpV_Initaliziong      = 0,
		ctmpV_Enabled           = 1,
		ctmpV_Normal            = 2,
		ctmpV_MessageLost       = 3,
		ctmpV_Disabled          = 4,
		ctmpV_OverloadImminent  = 5,
		ctmpV_OverloadReached   = 6,
		ctmpV_Relieved          = 7
	} 

	public enum ctmpTermination_Def 
   {
		ctmpV_DurationExceeded  = 0,
		ctmpV_DTMFDetected      = 1,
		ctmpV_EndOfDataDetected = 2,
		ctmpV_SpeechDetected    = 3
	} 

	// Voice Unit Filter (14XX)    CSTA2 Added
	public enum ctmpVoiceUnitFilter_Def 
   {
		ctmpF_VoiceStop         = 1,				/* CSTA2 Addend */
		ctmpF_Play              = 2,
		ctmpF_SuspendPlay       = 4,
		ctmpF_Record            = 8,
		ctmpF_SuspendRecord     = 16,
		ctmpF_VoiceReview       = 32,
		ctmpF_VoiceAttrChange   = 64
	} 

	/* 2003-7-11 add (outbound) */
	public enum ctmpDialKind_Def 
   {
		ctmp_AgentDirectCall = 1,
		ctmp_AutoCall        = 2,
		ctmp_CancelCall      = 3
	} 
}
