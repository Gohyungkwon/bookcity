using System;
//using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace bookcity
{
	class nxcapiPro
	{
		public const int MAX_COUNT = 10;
		public const ushort MAX_READCOUNT = 100;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpTimeStamp 
	{
		public short 	year;
		public short 	month;
		public short 	day;
		public short 	hour;
		public short 	minute;
		public short 	second;
		public short 	millisec;
		public short 	mindiff;
		public int		utc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpOpenData 
	{
		public ctmpGateMode_Def			deviceType;
		public ctmpServerVersion_Def	APIversion;
		public ctmpCTILink_Def			APIextensions;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)] 
      public string deviceDn;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpPrivDataArray 
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)] 
      public string manufacturerId;
		public uint	dataLength;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxPrivateRawDataLen)] 
      public string data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueueData 
	{
		public uint queueDN;
		public uint	queueWait;
		public uint	replyCall;
		public uint	abandonCall;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpUEI 
	{
		public uint	UEILen;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxAttDataLen)] 
      public string UEIData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCI 
	{
		public uint	CILen;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxAttDataLen)] 
      public string CIData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpPrivateData 
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)] 
      public string vendor;
		public uint length;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=1024)] 
      public string data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpConnectionID 
	{
		public uint				callID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)] 
      public string deviceID;
		ctmpConnectionID_Def	devIDType;
	}

   [StructLayout(LayoutKind.Sequential)]
   public struct ctmpEventData
   {
      public ctmpEventKind_Def eventKind;
      public uint cnid;
      public uint cnsq;
      public byte ctype;
      public uint callRefId;														//OB->campaignid
      public uint priOldCallRefId;												//OB->sequenceno
      public uint secOldCallRefId;												//OB->tokenid
      public ctmpLocalConnectState_Def localConnState;
      public ctmpEventCauses_Def eventCause;
      public uint type;																//OB->scriptid
      public ctmpAgentMode_Def agentMode;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string agentId;															//OB->agentid
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string agentGroup;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string agentData;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string logicalAgent;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string monitorParty;														//OB->telno
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxApplLen)]
      public string UUI;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxApplLen)]
      public string accountCode;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxApplLen)]
      public string authorisationCode;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string dtmfDigit;
      public uint numberOfQueue;
      public uint otherPartyType;
      public ctmpEventCallCause_Def otherPartyCause;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string otherParty;
      public uint otherPartyTrunk;
      public uint otherPartyGroup;
      public uint thirdPartyType;
      public ctmpEventCallCause_Def thirdPartyCause;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string thirdParty;
      public uint thirdPartyTrunk;
      public uint thirdPartyGroup;
      public uint calledPartyType;
      public ctmpEventCallCause_Def calledPartyCause;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string calledParty;
      public uint calledPartyTrunk;
      public uint calledPartyGroup;
      public uint originatingPartyType;
      public ctmpEventCallCause_Def originatingPartyCause;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string originatingParty;
      public uint originatingPartyTrunk;
      public uint originatingPartyGroup;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string connectionList1;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string connectionList2;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string connectionList3;
      public ctmpMode_Def DNDMode;
      public ctmpForward_Def forwardType;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string forwardDn;
      [MarshalAs(UnmanagedType.ByValTStr,SizeConst = nxcapiDef.ctmpMaxDeviceLen)]
      public string messageInvDn;
      public ctmpMode_Def messageWaitingMode;
      public ctmpMode_Def autoAnswerMode;
      public ctmpMode_Def microphoneMuteMode;
      public ctmpMode_Def speakerMuteMode;
      public uint speakerVolume;
      public ctmpTimeStamp timeStamp;
      public ctmpPrivDataArray privData;
      public ctmpQueueData queueData;
      public uint reasonCode;
      public ctmpUEI UEI;					//OB->customerkey
      public ctmpCI CI;
      public int gate;
      public uint monitorID;
      public ctmpPrivateData privateData;
      public uint voiceLength;			//OB->waittime
      public uint voicePosition;			//OB->dialgap
      public byte voiceSpeed;
      public byte voiceLevel;
      public byte voiceVolume;
      public byte sysStatus;
      public uint routeRegReqID;
      public uint routingCrossID;
      public byte errorValue;
      public byte ServerID;
      public byte PbxType;
      public byte callKind;
      public ctmpWorkMode_Def workMode;
      public uint eDivide;
      public uint eUnAttend;
      public systemEventIE eventIE;
   }

	[StructLayout(LayoutKind.Sequential)]
	public struct systemEventIE
	{
	    public ctmpSystemEventIE_Def typeIE;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=3072)] 
      public string nxcapiie;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpMonitorFilter 
	{
		public ctmpCallFilter_Def callFilter;
		public ctmpFeatureFilter_Def featureFilter;
		public ctmpAgentFilter_Def agentFilter;
		public ctmpMaintenanceFilter_Def maintenanceFilter;
		public ctmpVoiceUnitFilter_Def voiceUnitFilter;
		public long privateFilter;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpDeviceData 
	{
		public uint	refId;
		public uint	state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpClientData 
	{
		public uint gate;
		public uint	protocolType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxIPAddrLen)]
		public string clientIPAddr;
		public ctmpOpenData openData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpLinkData 
	{
		public uint protocolType;
		public ctmpProtocolType_Def	connectionProtocol;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxIPAddrLen)]
		public string switchAddr;
		public uint switchPort;
		public uint linkState;
		public ctmpMode_Def normalTrace;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxApplLen)]
		public string normalFile;
		public ctmpMode_Def	networkTrace;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxApplLen)]
		public string networkFile;
		public ctmpMode_Def	fullTrace;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxApplLen)]
		public string fullFile;
		public uint maxMonitors;
		public uint curMonitors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpReadyAgent 
	{
		public uint agentId;
		public uint deviceDN;
		public ctmpMode_Def blendMode;
		public uint continueTime;
	}

    [StructLayout(LayoutKind.Sequential)]
    public struct ctmpReadyAgentEx
    {
        uint agentId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string agentName;
        uint agentGroup;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string groupName;
        uint agentPart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string partName;
        uint deviceDN;
        ctmpMode_Def blendMode;
        uint continueTime;
    }

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpBusyAgent 
	{
		public uint	agentId;
		public uint	deviceDN;
		public ctmpMode_Def	blendMode;
		public uint continueTime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSkillAgent 
	{
		public uint	agentGroup;
		public uint	agentPart;
		public uint	agentId;
		public ctmpAgentMode_Def agentMode;
		public uint agenttime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpConnectionList 
	{
		public uint count;
		[MarshalAs(UnmanagedType.Struct, SizeConst=10)] //2010.10.28 sam 수정
		public ctmpConnectionID connection;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpExtendedDeviceID 
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string deviceID;
		public ctmpDeviceIDType_Def	deviceIDType;
		public ctmpDeviceIDStatus_Def deviceIDStatus;
	}

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tg_CallInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen30)]
        public string szCallNumber;
        public uint nacall;
        public uint nhcall;
        public uint nFlag;    
      
    }
    
	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSnapshotCallResponseInfo 
	{
		public ctmpExtendedDeviceID	deviceOnCall;
		public ctmpConnectionID	callIdentifier;
		public ctmpLocalConnectState_Def localConnectionState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSnapshotCallData 
	{
		public uint	count;
		public ctmpSnapshotCallResponseInfo[] info;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallState 
	{
		public uint count;
		public ctmpLocalConnectState_Def[] state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSnapshotDeviceResponseInfo 
	{
		public ctmpConnectionID	callIdentifier;
		public ctmpCallState localCallState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSnapshotDeviceData 
	{
		public uint count;
		public ctmpSnapshotDeviceResponseInfo[]	info;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQuery 
	{
		public uint QueryLen;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=512)]
		public string QueryData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpPopUpEvent
	{
		public uint	uiAgentId;
		public uint	uiCampaignId;				//campaign ID=분배대상 agent
		public uint	uiSequenceNo;				//campaignList sequence No
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string sCustomerTelNo;			//고객전화번호
		public uint	uiTokenId;					//고객정보 key
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=30)]
		public string sCSKE;					// 고객정보(Designer가 Insert)
		public uint	unScriptId;					// 상담 스크립트 ID(Designer가 Insert)
		public uint	unWaitTime;					// 고객 대기 시간.(Dialer가 Insert)
		public uint	unDialGap;					// 발신주기(Dialer가 Insert)
	}

   [StructLayout(LayoutKind.Sequential)]
	public struct ctmpTenantMaster
    {
        short pos;
        short tenant_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxNameLen)]
        string tenant_name;
    }


   [StructLayout(LayoutKind.Sequential)]
    public struct ctmpGroupMaster
    {

       public short pos;
       public short tenant_id;
       public uint group_id;
       [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxNameLen)]
       public string group_name;
    }

    public struct ctmpPartMaster
    {

        short pos;
        short tenant_id;
        uint group_id;
        uint team_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxNameLen)]
        string team_name;
    }

    public struct ctmpAgentMaster
    {
        short pos;
        short tenant_id;
        uint group_id;
        uint team_id;
        uint agent_id;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxEmployeeLen)]
        string employee_id;
        uint dn;
        char blend;
        char mode;
        short keep;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxNameLen)]
        string name;
        char autoset;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2000)] 
		char skill;
    }

    public struct ParmGetMaxCPSQ
    {
        uint gate_id;
        short invoke_id;
        uint ciod_id;
        uint cp_id;
    }

    public struct ParmBlackList
    {
        uint gate_id;
        short invoke_id;
        uint cp_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen30)]
        string cskey;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen30)]
        string csname;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen20)]
        string csdate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen20)]
        string cstel;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxEmployeeLen)]
        string employee_id;
    }

    public struct ParmCounselResult
    {
        uint gate_id;
        short invoke_id;

        uint cp_id;             /* campaign ID=분배대상 agent */
        uint cp_sq;             /* campaignList sequence No   */

        uint group_id;
        uint part_id;
        uint agent_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxEmployeeLen)]
        string employee_id;

        uint black_list;
        uint call_kind;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen20)]
        string reserved_date;    /* 예약일자(재콜) */
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen20)]
        string reserved_tel;     /* 예약 전화번호  */
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen20)]
        string result;           /* 상담결과 코드 */
        uint clock;
    }

    public struct ParmPreviewMakeCall
    {
        uint gate_id;
        short invoke_id;
        uint ciod_id;

        uint cp_id;             /* campaign ID=분배대상 agent */
        uint cp_sq;             /* campaignList sequence No   */

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxEmployeeLen)]
        string employee_id;
        uint dial_kind;
    }

    public struct ParmCallbackCampaign
    {
        uint gate_id;
        short invoke_id;

        uint ciod_id;
    }

    public struct ParmPopupData
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxEmployeeLen)]
        string employee_id;
        uint cp_id;
        uint cp_seq;
        uint firetime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = nxcapiDef.ctmpMaxLen20)]
        string cstel;
        uint token_id;
        uint script_id;
        uint wait_tm;
        uint dialgap;
        uint cp_mode;
        uint ob_ckind;
    }

    public struct ParmCallbackData
    {
        uint gate_id;
        short invoke_id;
        uint ciod_id;

        uint uiCmId;				// Campaign ID
        uint uiCmSq;				// Campaign Seq
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string strCustKey;		// 고객키
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustName;	// 고객명
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string strCustKey2;	// 고객키2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string strCustKey3;	// 고객키3
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar1;	// 고객특성1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar2;	// 고객특성2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar3;	// 고객특성3
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar4;	// 고객특성4
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar5;	// 고객특성5
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar6;	// 고객특성6
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strCustChar7;	// 고객특성7
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strTelNo1;		// 전화번호1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strTelNo2;		// 전화번호2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strTelNo3;		// 전화번호3
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strTelNo4;		// 전화번호4
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strTelNo5;		// 전화번호5
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string strTkData;		// 토큰 데이타
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string strMailAdd;	// 고객의 메일 주소
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string strSMSPhone;	// SMS Phone Number
        int iBlackFlag;			// BLACK List구분
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strReCallTime;      // 예약 시간
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strRecallTelNo;     // 예약 전화번호

        string employee_id;
        uint uiCallKind;         //재콜종류    
    }


    public struct ParmCampaignListHandle
    {
        uint gate_id;
        short invoke_id;
        uint ciod_id;

        uint uiCampaignId;
        uint ubListKind;
        byte ucListMode;
        uint ubAppKind;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        string ucListFileName;
        uint uiListCount;
    }

    public struct ParmCampaignMaster
    {
        uint uiCampId;		// 캠페인 ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        string ucCampaignName;		// 캠페인을 알아볼 수 있는 이름
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        string ucCampaignDesc;		// 캠페인의 속성 등을 설명
        uint uiCampaignSiteCode;
        uint uiCampaignSVCODE;	// Callback 캠페인 사용시에 각각의
        short ubCampaignMode;	// 아웃바운드 발신방법을 정의
        byte iStartFlag;			// 캠페인 현재 상태
        byte ucCampENFL;		// 캠페인 완료 여부
        byte ucCampCallBack;		// 해당 캠페인을 Callback 캠페인으로 
        byte ucCampDLFL;		// 캠페인 삭제 여부
        uint uiCampListCnt;		// 캠페인 발신데이터 건 수
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        string ucCampListQuery;		// 재발신 조건문
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        string ucCampListFile;		// 발신데이터 파일
        uint uiCampNextCamp;	// Power 모드 캠페인 사용 시에
        uint uiCampTokenId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        string ucCampPhoneOrder;		// 각 고객 별로 최대 5개의 전화번호
        short unCampMaxFreq1;	// 고객전화 1번(TNO1)의 시도 횟수
        short unCampMaxFreq2;	// 고객전화 2번(TNO2)의 시도 횟수
        short unCampMaxFreq3;	// 고객전화 3번(TNO3)의 시도 횟수
        short unCampMaxFreq4;	// 고객전화 4번(TNO4)의 시도 횟수
        short unCampMaxFreq5;	// 고객전화 5번(TNO5)의 시도 횟수
        int uiCampInterval;	// 이전 콜이 실패한 동일한 고객에게
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        string ucCampTACode;		// 외부 접속코드(Trunck Access Code)
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        string ucCampDDDNum;		// 고객전화번호 중, 발신 시 지역번호를
        uint ucCampQueue;
        short unCampMaxRing;	// 최대 링 횟수, 지정된 링 횟수이상이 
        byte ucCampMachine;		// Detection 방법 지정
        short unCampAutoDialTM;	// Auto-Preview 모드의 캠페인 사용시, 
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        string uiCampCRID;		// 캠페인 생성자 ID CUBE는 사번으로 로그인하기에 char씀
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        string ucCampCRTM;		// 캠페인 생성 시간
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        string ucCampCRIP;			// 캠페인 생성자 IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        string uiCampUPID;		// 캠페인 최종 수정자 ID CUBE는 사번으로 로그인하기에 char씀
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        string ucCampUPTM;		// 캠페인 최종 수정 시간
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        string ucCampUPIP;			// 캠페인 최종 수정자 IP

        ushort unCampCustId;	// 고객특성 Master ID
        ushort unCampPhoneId;	// 전화번호설명 Master ID
        uint uiCampScriptId;	// 응대 Script ID
        uint uiCampMentId;		// 사용하지 않음
        uint uiCampCIOD_ID;	// CIOD ID
        uint uiCampAnswerCnt;	// 사용하지 않음
        uint uiCampDialSpeed;	// 발신할 Call수를 비율로 지정함
        uint uiCampParentId;	// 사용하지 않음
        short unCampLevel;	// 사용하지 않음
        short unCampOVTime;	// 사용하지 않음
        uint uiCampALCnt;		// 발신데이터가 일정 수 이하가 남았을
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        string ucCampSPTel;		// 관리자 전화번호
        short unCampRDCnt;	// 재발신 횟수
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 26)]
        string ucCampOBSE;		// 발신순서조건
        uint uiCampGroupId;
        short unUsfl;

    }


	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallID_rtn 
	{
		public uint	callID;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCall_rtn 
	{
		public ctmpConnectionID call;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallList_rtn 
	{
		public ctmpConnectionID	call;
		public ctmpConnectionList callList;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryAgentStatus_rtn 
	{
		public ctmpAgentMode_Def agentMode;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string agentID;
		public uint	reasonCode;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryMailAgentStatus_rtn 
	{
		public ctmpeAgentMode_Def eAgentMode;
		public uint	reasonCode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryDeviceForward_rtn 
	{
		public ctmpForward_Def forwardMode;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string forwardDn;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpMode_rtn 
	{
		public ctmpMode_Def Mode;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQuerySpeakerVolume_rtn 
	{
		public ushort speakerVolume;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryDeviceInfo_rtn 
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string queryDN;
		public ctmpDeviceType_Def deviceType;
		public ctmpDeviceClass_Def deviceClass;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryLastNumber_rtn 
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string lastNumber;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpChangeMonitorFilter_rtn 
	{
		public ctmpMonitorFilter filter;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpMonitorFilter_rtn 
	{
		public uint monitorID;
		public ctmpMonitorFilter filter;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSnapshotCall_rtn 
	{
		public ctmpSnapshotCallData	snapshotCallData;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSnapshotDevice_rtn 
	{
		public ctmpDeviceData deviceData;
		public ctmpSnapshotDeviceData shapshotDevice;
		public uint numberOfCalls;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpReRoute_rtn 
	{
		public uint routeRegisterReqID;
		public uint	routingCrossRefID;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpRouteRegister_rtn 
	{
		public uint routeRegisterReqID;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpEscape_rtn 
	{
		public ctmpPrivDataArray privData;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSysStatReq_rtn 
	{
		public ctmpSystemStatus_Def	systemStatus;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpSysStatStart_rtn 
	{
		public ctmpSystemStatus_Def	systemStatus;
		public uint systemFilter;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpChangeSysStatFilter_rtn 
	{
		public uint systemFilterSelected;
		public uint	systemFilterActive;
		public ctmpPrivateData privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpErrMsg_rtn 
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxErrorMSGLen)]
		public string errorContent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpAgentReadyGet_rtn 
	{
		public ctmpReadyAgent[] readyAgent;
		public uint readCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpAgentBusyGet_rtn 
	{
		public ctmpBusyAgent[] BusyAgent;
		public uint	readCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallToCNID_rtn 
	{
		public uint CNID;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryAgentStatusEx_rtn 
	{
		public uint	queryAgentID;
		public ctmpAgentMode_Def queryAgentMode;
		public uint	queryAgentDN;
		public ctmpMode_Def	queryAgentblendMode;
		public ctmpMode_Def	queryAgentblockMode;
		public uint	queryAgentTime;
		public ctmpAgentType_Def queryAgentType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpWaitTimeGet_rtn 
	{
		public uint waitTime;
		public ushort waitCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpShowClient_rtn 
	{
		public ctmpClientData clientData;
		public ushort readCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpShowLink_rtn 
	{
		public ctmpLinkData	linkData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpShowVer_rtn 
	{
		public uint	swVersion;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string licenseKey;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpStartDataPath_rtn 
	{
		public uint	noCharToCollect;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string terminalChar;
		public uint	timeout;
		public uint ioRefId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpMsgID_rtn 
	{
		public uint messageID;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpQueryVocAtt_rtn 
	{
		public ctmpEncodingAlgorithm_Def encodingAlgorithm;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string sampleRate;
		public uint	durations;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=nxcapiDef.ctmpMaxDeviceLen)]
		public string fileName;
		public uint	position;
		public uint	speed;
		public uint	volume;
		public uint	level;
		public ctmpState_Def state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallbackCampaign
	{
		public uint	ciodID;
		public uint	campaignID;
		public uint	svcCode;
		public uint	cbCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallbackCampign_rtn
	{
		public uint count;
		public ctmpCallbackCampaign[] Campaign;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallbackData_rtn
	{
		public uint ciodID;
		public uint	campaignID;
		public uint	campaignSeq;
		public uint	rtnValue;	//1:callback insert success
								//2:callback insert error
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCallbackData
	{
		public uint	uiCmId;				// Campaign ID
		public uint	uiCmSq;				// Campaign Seq
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=30)]
		public string strCustKey;		// 고객키
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustName;		// 고객명
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=30)]
		public string strCustKey2;		// 고객키2
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=30)]
		public string strCustKey3;		// 고객키3
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar1;		// 고객특성1
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar2;		// 고객특성2
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar3;		// 고객특성3
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar4;		// 고객특성4
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar5;		// 고객특성5
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar6;		// 고객특성6
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strCustChar7;		// 고객특성7
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strTelNo1;		// 전화번호1
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strTelNo2;		// 전화번호2
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strTelNo3;		// 전화번호3
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strTelNo4;		// 전화번호4
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strTelNo5;		// 전화번호5
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=1024)]
		public string strTkData;		// 토큰 데이타
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=100)]
		public string strMailAdd;		// 고객의 메일 주소
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=15)]
		public string strSMSPhone;		// SMS Phone Number
		public int iBlackFlag;			// BLACK List구분
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=19)]
		public string strReCallTime;    // 예약 시간
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string strRecallTelNo;   // 예약 전화번호
		public uint	uiFileIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpConselResult
	{
		public uint	uiCampaignId;			//campaign ID=분배대상 agent
		public uint	uiSequenceNo;			//campaignList sequence No
		public uint	uiGroup;				   //상담원 group
		public uint	uiTeam;					//상담원 team
		public uint	uiAgentId;				//상담원 agentId
		public uint	BlackList;				// Black List
		public uint	CallKind;				// Call 구분
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string sResvDate;			// 예약일자(재콜)
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string sResvTelNo;			// 예약 전화번호
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string sConsultResult;		//상담결과 code
		public uint	uiConsultTime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpAgentBlocking_rtn 
	{
		public uint	Result;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpCampaignListHandle
	{
		public uint uiCampaignId;
		public uint ubListKind;
		public byte ucListMode;
		public uint ubAppKind;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=256)]
		public string ucListFileName;
		public uint uiListCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpBlackList
	{
		public uint cpid;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=31)]
		public string cskey;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=31)]
		public string csname;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpPreviewDial
	{
		public uint uiCampaignId;
		public uint uiSequenceNo;
		public ctmpDialKind_Def dialKind;
	}

	[StructLayout(LayoutKind.Sequential)]
	public	struct ctmpResponseData
	{
		public uint	errorValue;
		public ctmpCallID_rtn callID;							      // ctmpConsultationCall / ctmpSingleStepConferenceCall / 
		public ctmpCall_rtn	call;								      // ctmpMakeCall / ctmpMakePredictiveCall
		public ctmpCallList_rtn callList;						   // ctmpConferenceCall / ctmpTransferCall
		public ctmpQueryAgentStatus_rtn	agentStatus;
		public ctmpQueryMailAgentStatus_rtn mailAgentStatus;
		public ctmpQueryDeviceForward_rtn forward;
		public ctmpMode_rtn mode;								      // ctmpQueryDeviceDND / ctmpQueryDeviceMessageWaitting 
		public ctmpQuerySpeakerVolume_rtn speakVolume;
		public ctmpQueryDeviceInfo_rtn deviceInfo;
		public ctmpQueryLastNumber_rtn lastNum;
		public ctmpChangeMonitorFilter_rtn filter;
		public ctmpMonitorFilter_rtn monitorfilte;				// ctmpMonitorStart / ctmpMonitorCall / ctmpMonitorCallsViaDevice
		public ctmpEventData eventData;
		public ctmpSnapshotCall_rtn	snapshotCall;
		public ctmpSnapshotDevice_rtn shapshotDevice;
		public ctmpReRoute_rtn reRoute;
		public ctmpRouteRegister_rtn routeRegist;				   // ctmpRouteRegisterReq / ctmpRouteRegisterCancel
		public ctmpEscape_rtn escape;
		public ctmpSysStatReq_rtn sysStat;
		public ctmpSysStatStart_rtn sysStart;
		public ctmpChangeSysStatFilter_rtn sysFilter;
		public ctmpErrMsg_rtn errMsg;
		public ctmpAgentReadyGet_rtn readyGet;
		public ctmpAgentBusyGet_rtn BusyGet;
		public ctmpCallToCNID_rtn CNID;
		public ctmpQueryAgentStatusEx_rtn agentEx;
		public ctmpWaitTimeGet_rtn waitGet;
		public ctmpShowClient_rtn showClient;
		public ctmpShowLink_rtn	showLink;
		public ctmpShowVer_rtn showVer;
		public ctmpStartDataPath_rtn startData;
		public ctmpMsgID_rtn concatMsg;							   // ctmpConcatenateMessage / ctmpRecordMessage / ctmpSynthesizeMessage
		public ctmpQueryVocAtt_rtn VoiceAttr;
		public ctmpPrivateData privateData;						   // ctmpEscapeServiceConf / ctmpSysStatStop
		public ctmpCallbackCampign_rtn cbCampaign;
		public ctmpCallbackData_rtn callback;
		public ctmpAgentBlocking_rtn agentblocking;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ctmpResponseInfo_rtn 
	{
		public uint	gate;
		public ushort invoke;
		public byte functionCode;
		public byte serviceCode;
	}
}
