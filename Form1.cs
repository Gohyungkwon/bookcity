using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace bookcity
{
    public partial class Form1 : Form
    {

        #region 변수부
        //각라벨에 텍스트를 나타내기 위한 델리게이트 함수
        //delegate void SetTextCallback(txtControl txtCont, string text);
        //각버튼의 Enable를 바꾸기 위한 델리게이트 함수        
        delegate void SetButtonCallback(string btName, bool boo);

        // 이석사유 선택 박스를 바꾸기 위한 델리게이트 함수
        delegate void SetRestReasonSelector(int nIndex);

        //이벤트 스레드에 의해서 얻어진 이벤트 데이터의 callId값을 저장하는 변수
        delegate void TickCallback();

        //private uint g_activeCallId = 0;
        //NEXUS_LOGIN에서 얻어온 포트 값을 저장하는 변수                                         
        private uint g_portNo = 0;
        //사유코드를 설정하는 변수                                                
        //private uint g_reasonCode = 0;
        //서버와 연결하기 위한 핸들,nxcapiOpenServer시에 얻어온다.                                        
        private uint g_gate = 0;
        //동시에 여러개의 명령을 요청했을때 이변수로 어떤 요청의 결과인지 알수 있다.                                                
        private uint g_invokeID = 0;
        //defalt값은 0 이고 이중화시에                                             
        private uint g_defPbx = 0;

        private string g_Uui = "";
        private string g_accountCode = "";
        private string g_authCode = "";
        private string g_uei = "";
        private string g_ci = "";

        //현재 activeDevice를 저장
        //private string g_activeDevice = "";
        //모티터하고 있는 device저장                                    
        private string g_monitorParty = "";
        //서버 아이피 주소 저장                          
        private string g_serverName = "";

        private string g_agentData = "5555";
        private string g_agentGroup = "401";
        // 자기 DN
        private string g_deviceDN = "";
        // 자기 아이디
        private string g_agentId = "";
        // 이중화시 두번째 아이피
        private string g_secondIP = "";
        // 전화를 걸다가 프로그램이 죽어서 재로그인후 CC를 해야 할때 저장된 callid를 가져와서 저장한다.
        private uint g_initCallid = 0;
        //  상동+ dn을 저장한다.                           
        private string g_initDn = "";
        // 이중화 여부                            
        private bool g_checkHA = false;
        // 현재 콜아이디가 아닌 이전 콜아이디
        //private string g_oldCallId = "";
        //ctmpUEI구조체 
        private ctmpUEI Cg_uei = new ctmpUEI();
        //ctmpCI구조체                
        private ctmpCI Cg_ci = new ctmpCI();
        // 로그인폼 객체                
        //private LoginFrm g_loginfrm = null;
        //call과 관련된 ID,device등을 담는 구조체
        ctmpConnectionID g_call = new ctmpConnectionID();
        //새로들어온 call과 관련된 정보를 담는 구조체
        ctmpConnectionID g_newCall = new ctmpConnectionID();
        //hold나 consultation 할때 생기는 heldcallid와 DN을 담는 구조체
        ctmpConnectionID g_heldCall = new ctmpConnectionID();
        //현재 active된 call과 관련된 정보를 담는 구조체
        ctmpConnectionID g_activeCall = new ctmpConnectionID();
        //위의 구조체들을 담는 구조체(conference call 할때 필요함)
        ctmpConnectionList g_callList = new ctmpConnectionList();
        //nxcapiGetEvent함수의 이벤트를 감시하기 위한 스레드
        private Thread threadNxcapi = null;
        // 프로퍼티 클래스 객체
        //Cproperties g_properties = null;
        // 새로운 콜아이디 저장
        private uint g_newCallID = 0;
        // 홀드여부 
        private bool g_held = false;

        private bool g_i_pressed_hold = false;

        // 홀드콜이 클리어 되었는지 여부
        //private bool heldcallClear = false;
        // 현재 회의 상태 인지여부
        private bool conferencecallClear = false;
        // 협의 상태 여부
        private bool g_consultation_transfer = false;

        private bool g_consultation_conference = false;

        //private bool g_loginChk = false; 
        // 콜아이디를 관리하는 배열
        private ArrayList al_CallId = new ArrayList();

        private bool g_originated = false;

        //private double opacityValue;
        private bool m_bTimer;
        private long tick_counter;

        private bool isReady = false;


        string i_networkType = "TCPIP";
        string i_appName = "NXCAPI";
        uint i_mode = (uint)ctmpSyncMode_Def.ctmpV_SYNC;
        int i_returnValue = 0;


        public Form1()
        {
            InitializeComponent();

           
        }

        //오픈서버 모니터스타트 로그인 
        private void button1_Click(object sender, EventArgs e)
        {

            /*Event thread Start*/
            threadNxcapi = new Thread(new ThreadStart(this.f_nxcapiGetEvent));
            threadNxcapi.Start();

            /* openServer 예제 */
            ctmpOpenData OpenData;

            OpenData.deviceType = ctmpGateMode_Def.ctmpV_Dn;
            OpenData.APIversion = ctmpServerVersion_Def.ctmpV_CTMPV30;
            OpenData.APIextensions = (ctmpCTILink_Def)4;
            OpenData.deviceDn = "50058";

            i_returnValue = nxcapiApi.nxcapiOpenServer(out g_gate,
                                                           1,
                                                           ref OpenData,
                                                           "175.119.227.109",
                                                           9707,
                                                           i_networkType,
                                                           i_appName,
                                                           i_mode,
                                                           1);

            //i_returnValue = nxcapiApi.nxcapiOpenServerHA(out g_gate,
            //                                               1,
            //                                               ref OpenData,
            //                                               "175.119.227.109",
            //                                               "211.56.188.47",
            //                                               9707,
            //                                               i_networkType,
            //                                               i_appName,
            //                                               i_mode,
            //                                               1);
            Console.WriteLine("open : " + i_returnValue);
            i_returnValue = nxcapiApi.nxcapiMonitorStart(g_gate, 1);
            Console.WriteLine("monitor : " + i_returnValue);
        }


        /// <summary>
        /// 전화걸기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            ctmpConnectionID newCall = new ctmpConnectionID();
            ctmpUEI uei = new ctmpUEI();
            ctmpCI ci = new ctmpCI();
            ctmpPrivateData pri = new ctmpPrivateData();
            i_returnValue = nxcapiApi.nxcapiMakeCall(g_gate, 1, "50058", "01032294555", "uui", "x", "x", ref newCall, ref uei, ref ci, ref pri);
            Console.WriteLine("dial : " + i_returnValue);

        }

        /// <summary>
        /// 로그인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

                ctmpAgentMode_Def i_agentMode = ctmpAgentMode_Def.ctmpV_AgentLogin;
                ctmpWorkMode_Def i_workMode = ctmpWorkMode_Def.ctmp_AUTO_IN;
                ctmpPrivateData i_privateData = new ctmpPrivateData();

                i_returnValue = nxcapiApi.nxcapiSetFeatureAgentStatus(g_gate,
                                                                                    g_invokeID,
                                                                                   "50058",
                                                                                   i_agentMode,
                                                                                   "50058",
                                                                                   g_agentData,
                                                                                   g_agentGroup,
                                                                                   0,
                                                                                   i_workMode,
                                                                                   ref i_privateData);


                Console.WriteLine("login : " + i_returnValue);
           
        }

        /// <summary>
        /// 로그아웃
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int i_returnValue = 0;

                ctmpAgentMode_Def i_agentMode = ctmpAgentMode_Def.ctmpV_AgentLogout;
                ctmpWorkMode_Def i_workMode = ctmpWorkMode_Def.ctmp_AUX_WORK;
                ctmpPrivateData i_privateData = new ctmpPrivateData();

                i_returnValue = nxcapiApi.nxcapiSetFeatureAgentStatus(g_gate,
                                                                                   g_invokeID,
                                                                                  "50058",
                                                                                   i_agentMode,
                                                                                   "50058",
                                                                                   g_agentData,
                                                                                   g_agentGroup,
                                                                                   0,
                                                                                   i_workMode,
                                                                                   ref i_privateData);

                Console.WriteLine("logout : " + i_returnValue);
           
        }


        /// <summary>
        /// 전화끊기 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_callClear_Click");

            ctmpPrivateData i_privateData = new ctmpPrivateData();
            int i_returnValue = 0;

            try
            {
                
                // 회의 통화일때
                if (conferencecallClear == true)
                {
                    switch (al_CallId.Count)
                    {
                        case 1:
                            //회의 통화 이지만 자신이 협의를 한것이아니라 회의 이벤트를 받은 사람일때
                            g_call.callID = uint.Parse(al_CallId[0].ToString());

                            break;

                        case 2:
                            // 회의 통화이지만 협의 통화를 받고 회의 이벤트를 받았을 때 마지막에 받은 콜아이디가 회의 통화시에 콜아이디 이다.
                            al_CallId.RemoveRange(0, 1);
                            g_call.callID = uint.Parse(al_CallId[0].ToString());

                            break;

                        case 3:
                            // 내가 협의를 하는 주체가 되고 회의 통화로 전환시키는 주체가 되어서 콜아이디가 3개가 된다. CC에 사용되는 콜아이디는 3번째 콜아이디이다.
                            al_CallId.RemoveRange(0, 2);
                            g_call.callID = uint.Parse(al_CallId[0].ToString());

                            break;
                    }
                }
                else
                {// 회의통화를 제외한 콜의 CC
                    if (al_CallId.Count != 0)
                    {
                        switch (al_CallId.Count)
                        {
                            case 1:
                                //일반통화시 
                                g_call.callID = uint.Parse(al_CallId[0].ToString());
                                //f_controlEnable(conCaseOfoperation.en_Init);

                                break;

                            case 2:
                                // 회의통화시 상대방이 한번 끊고 남은 콜
                                g_call.callID = uint.Parse(al_CallId[al_CallId.Count - 1].ToString());

                                if (g_held == false)
                                {
                                    //f_controlEnable(conCaseOfoperation.en_Case1);
                                }
                                else
                                {
                                    //f_controlEnable(conCaseOfoperation.en_Case4);
                                }

                                break;

                        }

                        g_call.deviceID = g_monitorParty;
                    }
                }
                // CC 함수호출
                i_returnValue = nxcapiApi.nxcapiClearConnection(g_gate,
                                                                            g_invokeID,
                                                                            ref g_call,
                                                                            ref i_privateData);
                Console.WriteLine("clear_call : " + i_returnValue);
                if (i_returnValue == nxcapiDef.ctmpSuccess)
                {
                    // 클리어된 콜아이디를 제거 한다.
                    al_CallId.Remove(g_call.callID);
                }
                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("ClearConnection Exception : " + ex.ToString());
                MessageBox.Show("ClearConnectionError : " + ex.ToString() + "\n");
            }
        }


        /// <summary>
        /// 전화받기 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            // Console.WriteLine("btn_answerCall_Click");
            ctmpPrivateData i_privateData = new ctmpPrivateData();

            if (al_CallId.Count != 0)
            {
                if (al_CallId.Count > 1)
                {
                    // 보류된 상태에서의 콜아이디
                    g_call.callID = uint.Parse(al_CallId[al_CallId.Count - 1].ToString());
                }
                else
                {
                    // 일반 콜일 때의 콜아이디
                    g_call.callID = uint.Parse(al_CallId[0].ToString());
                    Console.WriteLine("callid : "+uint.Parse(al_CallId[0].ToString()));
                }
                g_call.deviceID = g_monitorParty;
            }

            try
            {
                // 응답 함수 호출
                int i_returnValue = nxcapiApi.nxcapiAnswerCall(g_gate,
                                                                         g_invokeID,
                                                                         ref g_call,
                                                                         ref i_privateData);

                // Console.WriteLine("Answer Call Return : " + i_returnValue);
                if (i_returnValue == nxcapiDef.ctmpSuccess)
                {
                    //f_setText(txtControl.en_returnValue, "Answer Call Succeeded");

                }
                else
                {
                    //f_setText(txtControl.en_returnValue, "Answer Call Failed");
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("AnswerCallError :" + ex.ToString());
                MessageBox.Show("AnswerCallError :" + ex.ToString() + "\n");
            }


        }

        /// <summary>
        /// 상태 바꾸기 함수
        /// </summary>
        /// <param name="m_agentMode"></param>
        public int f_agentStaus_click(ctmpAgentMode_Def m_agentMode, uint unReasonCode = 0)
        {
            ctmpPrivateData i_privateData = new ctmpPrivateData();

            try
            {
                int i_returnValue = nxcapiApi.nxcapiSetFeatureAgentStatus(g_gate,
                                                                                       g_invokeID,
                                                                                       "50058",
                                                                                       m_agentMode,
                                                                                       "50058",
                                                                                       g_agentData,
                                                                                       g_agentGroup,
                                                                                       unReasonCode,
                                                                                       0,
                                                                                       ref i_privateData);
                 Console.WriteLine("f_agentStaus_click Return : " + i_returnValue);

                if (i_returnValue == nxcapiDef.ctmpSuccess)
                {
                    switch (m_agentMode)
                    {
                        case ctmpAgentMode_Def.ctmpV_AgentReady:
                        case ctmpAgentMode_Def.ctmpV_AgentAfterCallWork:
                            //f_setButton("btn_makeCall", true);
                            //Deselect_RestReasonCode();
                            break;
                    }
                }
                else
                {
                    switch (m_agentMode)
                    {
                        case ctmpAgentMode_Def.ctmpV_AgentLogin:
                            if (i_returnValue != 2025)
                            {
                                 Console.WriteLine("Login is failed");
                            }
                            break;

                        case ctmpAgentMode_Def.ctmpV_AgentReady:

                             Console.WriteLine("Ready is failed");

                            break;

                        case ctmpAgentMode_Def.ctmpV_AgentAfterCallWork:

                             Console.WriteLine("AfterCallWork is failed");

                            break;

                        case ctmpAgentMode_Def.ctmpV_AgentNotReady:

                             Console.WriteLine("NotReady is failed");

                            break;

                        case ctmpAgentMode_Def.ctmpV_AgentLogout:

                             Console.WriteLine("Logout is failed");

                            break;
                    }

                }

                return 1;
            }
            catch (Exception ex)
            {
                 Console.WriteLine("f_agentStaus_click Exception : " + ex.ToString());
                MessageBox.Show("f_agentStaus_click Exception : " + ex.ToString() + "\n");
            }

            return 0;
        }

      
        /// <summary>
        /// 대기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
             Console.WriteLine("btn_ready_Click");
            f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentReady);
        }
        /// <summary>
        /// 후처리 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
             Console.WriteLine("btn_acw_Click");
            f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentAfterCallWork);
        }
        /// <summary>
        /// 휴식 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
             Console.WriteLine("btn_notready_Click");
            f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentNotReady);
        }



        //식사
        private void button10_Click(object sender, EventArgs e)
        {
            f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentNotReady, 1);
        }

        //이석
        private void button11_Click(object sender, EventArgs e)
        {
            f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentNotReady, 2);
        }

        //보류
        private void button12_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_hold_Click");
            ctmpPrivateData i_privateData = new ctmpPrivateData();

            byte reservation = 0;

            g_call.callID = uint.Parse(al_CallId[0].ToString());
            g_call.deviceID = g_monitorParty;

            try
            {
                int i_returnValue = nxcapiApi.nxcapiHoldCall(g_gate,
                                                                      g_invokeID,
                                                                      ref g_call,
                                                                      reservation,
                                                                      ref i_privateData);
                Console.WriteLine("Hold Call Return : " + i_returnValue);
                if (i_returnValue == nxcapiDef.ctmpSuccess)
                {
                    //f_setText(txtControl.en_returnValue, "Hold Call Succeeded");
                    g_i_pressed_hold = true;
                }
                else
                {
                    //f_setText(txtControl.en_returnValue, "Hold Call Failed");
                }
            }
            catch (Exception ex)
            {
                //logger.Error("Hold Call Exception : " + ex.ToString());
                MessageBox.Show("Holdcall Exception :" + ex.ToString());
            }
        }
        //보류해제
        private void button13_Click(object sender, EventArgs e)
        {
            ctmpPrivateData i_privateData = new ctmpPrivateData();

            try
            {
                int i_returnValue = nxcapiApi.nxcapiRetrieveCall(g_gate,
                                                                          g_invokeID,
                                                                          ref g_heldCall,
                                                                          ref i_privateData);

                Console.WriteLine(" Retrieve Call Return : " + i_returnValue);
                if (i_returnValue == nxcapiDef.ctmpSuccess)
                {
                    //f_setText(txtControl.en_returnValue, "Retrievedcall Succeeded");
                }
                else
                {
                    //f_setText(txtControl.en_returnValue, "Retrievedcall Failed");
                }
            }
            catch (Exception ex)
            {
                //logger.Error("Retrievedcall Exception :" + ex.ToString());
                MessageBox.Show("Retrievedcall Exception :" + ex.ToString());
            }
        }
        //오픈서버 모니터스톱 로그인 
        private void button14_Click(object sender, EventArgs e)
        {
             try
             {
                    int i_returnValue = nxcapiApi.nxcapiMonitorStop(g_gate, g_invokeID);
                    Console.WriteLine("moniterStop Return : " + i_returnValue);

                    i_returnValue = nxcapiApi.nxcapiCloseServer(g_gate,
                                                                         g_invokeID);
                    Console.WriteLine("CloseServer Return : " + i_returnValue);
                    threadNxcapi.Abort();           //Thread End
   
             }
             catch (Exception ex)
             {
                 //MessageBox.Show("f_closeServer Exception : " + ex.Message);
                 Console.WriteLine("f_closeServer Exception : " + ex.Message);
             }
   
        }

        #endregion


        #region GetEvent

        private void f_nxcapiGetEvent()
        {
            Console.WriteLine("f_nxcapiGetEvent");
            try
            {
                while (true)
                {
                    ctmpEventData i_eventData = new ctmpEventData();

                    int ReturnValue = nxcapiApi.nxcapiGetEvent(g_gate,
                                                                         ref i_eventData,
                                                                         0);

                    if (ReturnValue == nxcapiDef.ctmpSuccess)
                    {

                        g_monitorParty = i_eventData.monitorParty;

                        Console.WriteLine("nxcapiGetEvent : " + i_eventData.eventKind);
                        switch (i_eventData.eventKind)
                        {
                            /*ServiceInitated*/
                            case ctmpEventKind_Def.ctmpEK_ServiceInitated:
                                Console.WriteLine(i_eventData.eventKind);
                                break;

                            case ctmpEventKind_Def.ctmpEK_Originated:
                                Console.WriteLine(i_eventData.eventKind);
                                //f_setText(txtControl.en_returnValue, "Originated");
                                g_originated = true;

                                break;

                            /*Delivered*/
                            case ctmpEventKind_Def.ctmpEK_Delivered:

                                isReady = false;
                                //f_setText(txtControl.en_returnValue, "Delivered");
                                Console.WriteLine(i_eventData.eventKind);

                                Cg_uei.UEILen = i_eventData.UEI.UEILen;
                                Cg_uei.UEIData = i_eventData.UEI.UEIData;

                                Console.WriteLine("CHECK UEI UEIData : " + i_eventData.UEI.UEIData);
                                // Console.WriteLine("CHECK UEI otherParty : " + i_eventData.otherParty);
                                // Console.WriteLine("CHECK UEI callRefId : " + i_eventData.callRefId);
                                // Console.WriteLine("CHECK key : " + global_key);

                                //if (i_eventData.localConnState != ctmpLocalConnectState_Def.ctmpES_Altering)

                                if (g_originated)
                                { // 내가 전화를 걸때
                                    //g_originated = false;
                                    //resendButton_Click(i_eventData.otherParty, "DL1", global_key);
                                }
                                else
                                {// 걸려온 전화
                                    //resendButton_Click(i_eventData.otherParty, "DL", global_key);
                                    //전화받을 때 전화번호 입력창 공란으로 : 협의전환시 상담원에게 혼란을 줌.
                                    //f_setText(txtControl.en_number, "");

                                    /*
                                    if (i_eventData.otherParty.Trim().ToLower().Equals("anonymous"))
                                    {
                                       f_setText(txtControl.en_number, "");
                                    }
                                    else
                                    {
                                        f_setText(txtControl.en_number, i_eventData.otherParty);
                                    }
                                    */

                                    //if (g_properties.pro_popup)
                                        //MessageBox.Show(" UEI : " + i_eventData.UEI.UEIData);
                                    
                                    //ex)01030112972|1234567890|7002
                                    Console.WriteLine("CHECK UEI Datas1 : " + i_eventData.UEI.UEIData);

                                    //DisplayUEIDatas(i_eventData.UEI.UEIData);
                                    //_uei.callID = i_eventData.callRefId.ToString();

                                    //f_setText(txtControl.en_uei_sa, _uei.IVR);
                                    //f_setText(txtControl.en_uei_kb, _uei.IVRpath);
                                    //f_setText(txtControl.en_uei_reg, _uei.callID);
                                    //f_setText(txtControl.en_uei_ani, _uei.ani);
                                    //f_setText(txtControl.en_uei_ani, i_eventData.otherParty);

                                    //f_controlEnable(conCaseOfoperation.en_Case6);

                                    //깜박임 시작
                                    //StartRingBell();
                                }

                                Console.WriteLine("CHECK i_eventData callRefId : " + i_eventData.callRefId);


                                if (al_CallId.Count == 0 || !al_CallId.Contains(i_eventData.callRefId))
                                {
                                    al_CallId.Insert(al_CallId.Count, i_eventData.callRefId);
                                }
                                //f_setText(txtControl.en_agent_status, "통화중");

                                break;

                            /*Established*/
                            case ctmpEventKind_Def.ctmpEK_Established:
                                Console.WriteLine(i_eventData.eventKind);
                                isReady = false;

                                //f_setText(txtControl.en_returnValue, "Established");

                                if (i_eventData.thirdParty == g_deviceDN)
                                {
                                }
                                else
                                {
                                    //상대방이 전화를 받았습니다.

                                }

                                if (g_consultation_conference)
                                {   // 회의 협의 통화 ES
                                    //f_controlEnable(conCaseOfoperation.en_CaseConferenceConsultation);

                                }
                                else if (g_consultation_transfer)
                                {   // 전환 협의 통화 ES
                                    //f_controlEnable(conCaseOfoperation.en_CaseTransferConsultation);
                                }
                                else
                                {
                                    //f_controlEnable(conCaseOfoperation.en_Case1);
                                    g_originated = false;
                                }

                                //StopRingBell();

                                break;

                            /*Held*/
                            case ctmpEventKind_Def.ctmpEK_Held:

                                //f_setText(txtControl.en_returnValue, "Held");
                                g_held = true;
                                g_heldCall.callID = i_eventData.callRefId;
                                g_heldCall.deviceID = i_eventData.monitorParty;

                                if (g_i_pressed_hold)
                                {   // 내가 눌른 홀드면 재연결 버튼 활성화
                                    //f_controlEnable(conCaseOfoperation.en_Case4);
                                    g_i_pressed_hold = false;
                                }
                                else
                                {   // 홀드 당한거면 재연결 버튼 비활성화
                                    //f_controlEnable(conCaseOfoperation.en_Case4_Held);
                                }

                                if (al_CallId.Count == 0 || !al_CallId.Contains(i_eventData.callRefId))
                                {
                                    al_CallId.Add(i_eventData.callRefId);
                                }

                                break;

                            case ctmpEventKind_Def.ctmpEK_Retrieved:

                                //f_setText(txtControl.en_returnValue, "Retrieved");
                                //f_controlEnable(conCaseOfoperation.en_Case1);

                                g_held = g_originated = g_consultation_conference = g_consultation_transfer = false;
                                break;

                            /*Transferred*/
                            case ctmpEventKind_Def.ctmpEK_Transferred:

                                //if (i_eventData.secOldCallRefId != 0)
                                if (g_originated)
                                {// 전환통화 시도 // ctmpEK_ConnectionCleared가 발생하지 않고 끊어진다.                        
                                    g_originated = false;
                                    //btn_callClear_Click(null, null);

                                    al_CallId.RemoveRange(0, al_CallId.Count);
                                    //f_controlEnable(conCaseOfoperation.en_Init);
                                    //StopRingBell();
                                    //f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentAfterCallWork);

                                }
                                else
                                {// 전환통화를 받았을 때
                                    //f_setText(txtControl.en_returnValue, "Transferred");
                                    //f_controlEnable(conCaseOfoperation.en_Case1);
                                    al_CallId.RemoveRange(0, al_CallId.Count);
                                    al_CallId.Add(i_eventData.callRefId);
                                }
                                break;

                            /*Confernced*/
                            case ctmpEventKind_Def.ctmpEK_Confernced:

                                //f_setText(txtControl.en_returnValue, "Confernced");

                                /*
                                if (i_eventData.monitorParty == i_eventData.otherParty)
                                {

                                }
                                else
                                */
                                {//상대방이 co를 날렸을 때
                                    //f_controlEnable(conCaseOfoperation.en_Case5);
                                }
                                conferencecallClear = true;
                                al_CallId.Add(i_eventData.callRefId);

                                break;

                            /*ConnectionCleared*/
                            case ctmpEventKind_Def.ctmpEK_ConnectionCleared:

                                g_originated = false;
                                //StopRingBell();

                                //f_setText(txtControl.en_returnValue, "ConnectionCleared");
                                //resendButton_Click(i_eventData.otherParty, "CC", global_key);

                                if (i_eventData.otherParty == g_monitorParty)
                                {// 내가 끊었을때

                                }
                                else
                                {// 상대방이 끊었을 때       

                                    switch (al_CallId.Count)
                                    {
                                        case 1:

                                            //f_controlEnable(conCaseOfoperation.en_Init);
                                            g_held = false;
                                            al_CallId.Remove(i_eventData.callRefId);
                                            break;

                                        case 2:
                                            //f_controlEnable(conCaseOfoperation.en_Case1);
                                            al_CallId.RemoveAt(0);
                                            break;

                                        case 3:

                                            //f_controlEnable(conCaseOfoperation.en_Case1);
                                            al_CallId.RemoveRange(0, al_CallId.Count - 1);
                                            break;
                                    }

                                }

                                if (g_consultation_transfer)
                                {
                                    // 전환협의 중에 전환시키지 않은 상태에서 통화가 끊어짐 ( 이전 통화는 남아있음 )
                                    g_consultation_transfer = false;
                                    //f_setButton("btn_transfer", false);
                                }
                                else if (g_consultation_conference)
                                {
                                    // 회의협의 중에 회의 연결 시키지 않은 상태에서 통화가 끊어짐 ( 이전 통화는 남아있음 )
                                    g_consultation_conference = false;
                                    //f_setButton("btn_conference", false);
                                }

                                if (g_held)
                                {
                                    //f_setButton("btn_retrieved", true);
                                }

                                // 전 상태가  READY 였다면, 다시  Set READY
                                f_agentStaus_click(ctmpAgentMode_Def.ctmpV_AgentAfterCallWork);
                                break;

                            /*Ready*/
                            case ctmpEventKind_Def.ctmpEK_Ready:

                                isReady = true;
                                //f_setText(txtControl.en_returnValue, "Ready");
                                //f_setText(txtControl.en_agent_status, "대기");
                                //f_controlEnable(conCaseOfoperation.en_Init);

                                break;

                            /*ACW*/
                            case ctmpEventKind_Def.ctmpEK_AfterCallWork:

                                isReady = false;
                                //f_setText(txtControl.en_returnValue, "AfterCallWork");
                                //f_setText(txtControl.en_agent_status, "후처리");
                                //f_controlEnable(conCaseOfoperation.en_Init);
                                al_CallId.Clear();
                                g_held = g_originated = g_consultation_transfer = g_consultation_conference = false;
                                break;

                            /*NotReady*/
                            case ctmpEventKind_Def.ctmpEK_NotReady:

                                isReady = false;

                                break;
                            /*LogIn*/
                            case ctmpEventKind_Def.ctmpEK_LoggedOn:

                                //g_loginChk = true;

                                break;

                            /*CCSE Down*/
                            case ctmpEventKind_Def.ctmpEK_CCSEDown:
                            case ctmpEventKind_Def.ctmpEK_CCSEDisConnect:
                            case ctmpEventKind_Def.ctmpEK_CCSEFail:
                            case ctmpEventKind_Def.ctmpEK_CCSELinkFailPbx:
                            case ctmpEventKind_Def.ctmpEK_CCSENoActPbx:
                            case ctmpEventKind_Def.ctmpEK_CCSERecovery:

                            /*LogOff*/
                            case ctmpEventKind_Def.ctmpEK_LoggedOff:

                                break;

                            default:
                                break;
                        }
                        g_activeCall.callID = i_eventData.callRefId;
                        g_activeCall.deviceID = i_eventData.monitorParty;
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }

                        
                }
            }
            catch
            {
            }
        }








        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
