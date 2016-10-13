using System;
//using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace bookcity
{
	class nxcapiApi
	{
		[DllImport("nxcapi.dll")]
		public static extern int nxcapiGetEvent(uint gate,
                                              ref ctmpEventData eventData,
                                              uint dontWait);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiMakeCall(uint gate,
											               uint invokeID,
											            	[MarshalAs(UnmanagedType.LPStr)] 
                                                string callingNumber,
											            	[MarshalAs(UnmanagedType.LPStr)] 
                                                string calledNumber,
											            	[MarshalAs(UnmanagedType.LPStr)] 
                                                string UUI,
											            	[MarshalAs(UnmanagedType.LPStr)] 
                                                string accountCode,
											            	[MarshalAs(UnmanagedType.LPStr)] 
                                                string authCode,
											            	ref ctmpConnectionID newCall,
											            	ref ctmpUEI UEI, 
											            	ref ctmpCI CI, 
											            	ref ctmpPrivateData privateData);

      [DllImport("nxcapi.dll")]
      public static extern int nxcapiOpenServer(out uint gate,
                                                uint invokeID,
                                                ref ctmpOpenData openData,
                                                [MarshalAs(UnmanagedType.LPStr)] 
                                                string serverName,
                                                uint portNo,
                                                [MarshalAs(UnmanagedType.LPStr)] 
                                                string networkType,
                                                [MarshalAs(UnmanagedType.LPStr)] 
                                                string appName,
                                                uint mode,
                                                uint defPbx);
        [DllImport("nxcapi.dll")]
        public static extern int nxcapiOpenServerHA(out uint gate,
                                                    uint invokeID,
                                                    ref ctmpOpenData openData,
                                                    [MarshalAs(UnmanagedType.LPStr)] 
                                                    string primaryIP,
                                                    [MarshalAs(UnmanagedType.LPStr)] 
                                                    string secondaryIP,
                                                    uint portNo,
                                                    [MarshalAs(UnmanagedType.LPStr)] 
                                                    string networkType,
                                                    [MarshalAs(UnmanagedType.LPStr)] 
                                                    string appName,
                                                    uint mode,
                                                    uint defPbx);

	   	[DllImport("nxcapi.dll")]
            public static extern int nxcapiMonitorStart(uint gate,
                                                        uint invokeID);

	   	[DllImport("nxcapi.dll")]
            public static extern int nxcapiMonitorStop(uint gate,
												                   uint invokeID);

		   [DllImport("nxcapi.dll")]
            public static extern int nxcapiCloseServer(uint gate, 
												                   uint invokeID);
         [DllImport("nxcapi.dll")]
            public static extern int nxcapiCloseServerHA(uint gate,
                                                         uint invokeID);
		
         [DllImport("nxcapi.dll")]
            public static extern int nxcapiAddDevice(uint gate,
                                                     uint invokeID,
                                                     ref ctmpOpenData openData);


        [DllImport("nxcapi.dll")]
        public static extern int nxcapiMakePredictiveCall(uint 	gate,
                                                          uint		invokeID,
                                                          [MarshalAs(UnmanagedType.LPStr)]
                                                          string 	callingNumber,
                                                          [MarshalAs(UnmanagedType.LPStr)]                                                 
                                                          string 	calledNumber,
                                                          ref ctmpDeviceClass_Def	calledClass, 
                                                          ref ctmpAllocationState_Def allocation,
                                                          uint	numberOfRings,
                                                          string 	UUI,
                                                          string		accountCode,
                                                          string		authCode,
                                                          out ctmpConnectionID	newCall,					// out value
                                                          ref ctmpPrivateData		privateData);

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiCallCompletion (uint	gate,
                                                       uint	invokeID,
				                                        	 ref ctmpConnectionID	call,
				                                        	 ref ctmpAction_Def		action,
				                                        	 ref ctmpPrivateData		privateData);
        [DllImport("nxcapi.dll")]
        public static extern int nxcapiClearCall(uint gate,
                                                 uint invokeID,
                                                 ref ctmpConnectionID call,
                                                 ref ctmpPrivateData privateData);

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiClearConnection(uint gate,
                                                       uint invokeID,
                                                       ref ctmpConnectionID call,
												                   ref ctmpPrivateData privateData);
    
        [DllImport("nxcapi.dll")]
        public static extern int  nxcapiAlternateCall (uint gate,
					                                        uint invokeID,
					                                        ref ctmpConnectionID heldCall, 
					                                        ref ctmpConnectionID	activeCall, 
					                                        ref ctmpPrivateData		privateData);
        
        [DllImport("nxcapi.dll")]
        public static extern int nxcapiAssociateData (uint	gate, 
				                                          uint		invokeID,
				                                          ref ctmpConnectionID	call,
                                                      [MarshalAs(UnmanagedType.LPStr)]			
                                                      string		UUI,
                                                      [MarshalAs(UnmanagedType.LPStr)]			
                                                      string		accountCode,
                                                      [MarshalAs(UnmanagedType.LPStr)]
				                                          string		authCode);


		[DllImport("nxcapi.dll")]
        public static extern int nxcapiAnswerCall(uint gate, 
											                 uint invokeID,
                                                  ref ctmpConnectionID alertingCall, 
											                 ref ctmpPrivateData privateData);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiHoldCall(uint gate,
											               uint invokeID,
											               ref ctmpConnectionID call,
											               byte reservation, 
											               ref ctmpPrivateData privateData);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiRetrieveCall(uint gate,
												                uint invokeID,
												                ref ctmpConnectionID	call,
												                ref ctmpPrivateData privateData);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiConsultationCall(uint gate, 
													                 uint invokeID,
													                 ref ctmpConnectionID call,
                                                        [MarshalAs(UnmanagedType.LPStr)]	
													                 string calledNumber, 
													                 int calledClass,
                                                        [MarshalAs(UnmanagedType.LPStr)]	
													                 string UUI,
                                                        [MarshalAs(UnmanagedType.LPStr)]	
													                 string accountCode,
                                                        [MarshalAs(UnmanagedType.LPStr)]	
													                 string authCode, 
													                 ref uint newCall,
													                 ref ctmpUEI UEI, 
													                 ref ctmpCI CI,
													                 ref ctmpPrivateData privateData);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiReconnectCall(uint gate,
												                 uint invokeID,
												                 ref ctmpConnectionID heldCall,
												                 ref ctmpConnectionID activeCall,
												                 ref ctmpPrivateData	privateData);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiTransferCall(uint gate,
												                uint invokeID,
												                ref ctmpConnectionID heldCall, 
												                ref ctmpConnectionID activeCall, 											                
                                                    ref ctmpConnectionID newCall,
                                                    [Out] ctmpConnectionList callList,  //2010.10.28 sam 수정
												                ref ctmpPrivateData privateData);

		[DllImport("nxcapi.dll")]
      /*
       ctmpAPI 
         nxcapiConferenceCall (ctmpGateID			gate,
				                  ctmpInvokeID		invokeID,
				                  const ctmpConnectionID	&heldCall, 
				                  const ctmpConnectionID	&activeCall, 
				                  ctmpConnectionID	*newCall,					// out value
				                  ctmpConnectionList	*callList=NULL,				// out value
				                  ctmpPrivateData		*privateData=NULL);
       */
      public static extern int nxcapiConferenceCall(uint gate,
													               uint invokeID,
													               ref ctmpConnectionID heldCall,
													               ref ctmpConnectionID activeCall,
                                                      ref ctmpConnectionID newCall,
                                                      [Out] ctmpConnectionList callList,//2010.10.28 sam 수정
													               ref ctmpPrivateData privateData);

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiSingleStepTransfer(uint gate,
                                                          uint invokeID,
                                                          ref ctmpConnectionID call,
                                                          [MarshalAs(UnmanagedType.LPStr)]	
														                string calledNumber,
                                                          int mode,
                                                          out uint newCall,
                                                          [MarshalAs(UnmanagedType.LPStr)]	
														                string UUI,
                                                          [MarshalAs(UnmanagedType.LPStr)]	
														                string accountCode,
                                                          [MarshalAs(UnmanagedType.LPStr)]	      
														                string authCode,
                                                          ref ctmpUEI UEI,
                                                          ref ctmpCI CI);
      [DllImport("nxcapi.dll")]
        public static extern int nxcapiSetAgentFlag(uint gate,
                                                    uint invokeID,
                                                    ref uint agentID,
                                                    uint waitMode);

		[DllImport("nxcapi.dll")]
        public static extern int nxcapiDivertDirect(uint gate, 
												                uint invokeID,
												                ref ctmpConnectionID	call,
                                                    [MarshalAs(UnmanagedType.LPStr)]	
												                string divertedDn,
                                                    [MarshalAs(UnmanagedType.LPStr)]	
												                string UUI, 
												                ref ctmpUEI UEI, 
												                ref ctmpCI CI,
												                ref ctmpPrivateData privateData);
        [DllImport("nxcapi.dll")]
        public static extern int nxcapiDivertPickup (uint gate,
                                                     uint invokeID,
                                                     ref ctmpConnectionID	call,
                                                     [MarshalAs(UnmanagedType.LPStr)]	
                                                     string  divertDn,
                                                     ref ctmpPrivateData	PrivateData);

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiDivertNoRet(uint gate,
                                                   uint invokeID,
                                                   uint  divertedDn,
                                                   [MarshalAs(UnmanagedType.LPStr)]	
                                                   string  UUI,
                                                   [MarshalAs(UnmanagedType.LPStr)]	
                                                   string agentID);



		[DllImport("nxcapi.dll")] 
      public static extern int nxcapiDivertDeflect(uint gate, 
											                    uint invokeID,
											                    ref ctmpConnectionID call,
                                                     [MarshalAs(UnmanagedType.LPStr)]	
											                    string divertDn,
                                                     [MarshalAs(UnmanagedType.LPStr)]	
											                    string UUI,
											                    ref ctmpUEI UEI, 
											                    ref ctmpCI CI,
											                    ref ctmpPrivateData privateData);

        [DllImport("nxcapi.dll")]
       public static extern int  nxcapiGetCurrentPbxID();


       /* 상담원 상태 조회 */
		[DllImport("nxcapi.dll")]
		public static extern int nxcapiQueryAgentStatus (uint gate,
													                uint invokeID,
													                string deviceDN,
													                out uint agentMode,
													                [MarshalAs(UnmanagedType.LPStr)]
													                out string agentId,
													                out uint reasonCode,
													                ref ctmpPrivateData privateData);
      /*확장된 상담원 상태조회
       *수정 2010.11.08 
       * 
       * 현재 queryAgentID 값은 조회시에 자신의 아이디를 설정해서 
       * 주어야만 상태를 가져올수 있습니다.ex)queryAgentID="STEST001";
       * 
       */
      [DllImport("nxcapi.dll")]
      public static extern int nxcapiQueryAgentStatusEx(uint gate,
                                                        uint invokeID,
                                                        [MarshalAs(UnmanagedType.LPStr)]
                                                        string agentID,
                                                        uint deviceDN,
                                                        [MarshalAs(UnmanagedType.LPStr)]
                                                        string queryAgentID,
                                                        out ctmpAgentMode_Def queryAgentMode,                                                       
                                                        out uint queryAgentDN,
                                                        out ctmpMode_Def queryAgentblendMode,
                                                        out ctmpMode_Def queryAgentblockMode,                                                        
                                                        out uint queryAgentTime,
                                                        out ctmpAgentType_Def queryAgentType,
                                                        [Out] char[] centerid);

		/* 상담 모드 설정 */
		[DllImport("nxcapi.dll")]
        public static extern int nxcapiSetFeatureAgentStatus(uint gate,
															                uint invokeID,
															                [MarshalAs(UnmanagedType.LPStr)]
															                //[MarshalAs(UnmanagedType.ByValTStr, SizeConst=ctmpDef.ctmpMaxDeviceLen)]
															                string deviceDN,
															                ctmpAgentMode_Def agentMode,
															                [MarshalAs(UnmanagedType.LPStr)]
															                string agentId,
															                [MarshalAs(UnmanagedType.LPStr)]
															                string agentData,
															                [MarshalAs(UnmanagedType.LPStr)]
															                string agentGroup,
															                uint reasoncode,
															                ctmpWorkMode_Def workMode, 
															                ref ctmpPrivateData	privateData);

		/* busy인 상담원수와 상담원 리스트 검색 */
		[DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentBusyGet(uint gate, 
												                uint invokeID,
												                ushort AgentGroup, 
												                ushort AgentPart, 
												                ushort maxCount, 
												                [Out] ctmpBusyAgent[] BusyAgent,
												                [Out] uint[] readCount);

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentBusyGetCount(uint gate,
                                                         uint invokeID,
                                                         ushort AgentGroup,
                                                         ushort AgentPart,
                                                         ushort maxCount,
                                                         [Out]uint[] readCount); 				   // out value

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentBusyGetValue(uint gate,
                                                         uint invokeID,
                                                         ushort count,
                                                         [Out]uint[] agentId,  					   // out value
                                                         [Out]uint[] deviceDN,  				      // out value
                                                         out ctmpMode_Def blendMode,  				// out value
                                                         [Out]ushort[] continueTime); 			   // out value


		/* ready인 상담원수와 상담원 리스트 검색 */
		[DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentReadyGet(uint gate, 
												                 uint invokeID,
												                 ushort AgentGroup, 
												                 ushort AgentPart, 
												                 ushort maxCount,
												                 [Out] ctmpReadyAgent[] readyAgent,
												                 [Out] uint[] readCount);

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentReadyGetEx(uint gate,
                                                       uint invokeID,
                                                       ushort AgentGroup,
                                                       ushort AgentPart,
                                                       ushort maxCount,
                                                       [Out]ctmpReadyAgentEx[] readyAgentEx,				// out value
                                                       [Out]uint[] readCount);				            // out value

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentReadyGetCount(uint gate,
                                                          uint invokeID,
                                                          ushort AgentGroup,
                                                          ushort AgentPart,
                                                          ushort maxCount,
                                                          [Out]uint[] readCount);				         // out value

        [DllImport("nxcapi.dll")]
        public static extern int nxcapiAgentReadyGetValue(uint gate,
                                                          uint invokeID,
                                                          ushort count,
                                                          [Out]uint[] agentId,  				            // out value
                                                          [Out]uint[] deviceDN,  			            // out value
                                                          ctmpMode_Def blendMode,  			            // out value
                                                          [Out]ushort[] continueTime); 		         // out value

		[DllImport("nxcapi.dll")]
        public  static extern int nxcapiSendMsg	(uint	gate,
                                                 uint invokeID,
                                                 [MarshalAs(UnmanagedType.LPStr)]
                                                 string appName,
                                                 ref ctmpUEI UEI,
                                                 ref ctmpCI CI,
                                                 ref ctmpPrivateData privateData);

      [DllImport("nxcapi.dll")]
      public static extern int nxcapiGetGroupMaster(uint gate,
                                                    uint invokeID,
                                                    uint tenantId,
                                                    uint groupId,
                                                    [Out] ctmpGroupMaster[] group,
                                                    uint groupCount,
                                                    ref uint rtnCount,
                                                    ref uint centerID);
	}
}
