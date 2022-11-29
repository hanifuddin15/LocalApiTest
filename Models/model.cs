using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalApiTest.Models
{

    public class MsginfoModel
    {
        /*
         * App Version Number, length 5, fromat ANS, Mandatory
         * ex: ValidValue:"1.0.0"
         */
        public string versionNo { get; set; }

        /*
         * Message Id, length 17-49, fromat AN, Mandatory
         * It is used to match a response to its request. 
         * The value must be unique on any message and any day. 
         * The value in the response mustmatchthevalueintherequest
         */
        public string msgID { get; set; }

        /*
         * TimeStamp, length 14, fromat N(YYYYMMDDhhmmss), Mandatory
         */
        public string timeStamp { get; set; }

        /* 
         * MessageType, length 1-50, fromat ANS, Mandatory
         */
        public string msgType { get; set; }

        /* 
         * INS ID, length 1-16 , fromat AN, Mandatory
         */
        public string insID { get; set; }
    }


    public class CardStatusInquireRequestModel
        {
            public MsginfoModel msgInfo { get; set; }
            public CardStatusInquireTrxModel trxInfo { get; set; }
        }


        public class CardStatusInquireTrxModel
        {
            public string pan { get; set; }
        }


        public class CardStatusInquireRequestModelAppG
        {
            public MsginfoModel msgInfo { get; set; }
            public CardStatusInquireTrxModelAppG trxInfo { get; set; }
        }


        public class CardStatusInquireTrxModelAppG
        {
            public string deviceID { get; set; }
            public string userID { get; set; }
            public string token { get; set; }
        }

        public class CardStatusManagementRequestModel
        {
            public MsginfoModel msgInfo { get; set; }
            public CardStatusManagementTrxModel trxInfo { get; set; }
        }

        public class CardStatusManagementTrxModel
        {
            public string pan { get; set; }
            public string cardAction { get; set; }
            public string accountInfo { get; set; }
        }



        public class CardStatusManagementRequestModelAppGateWay
        {
            public MsginfoModel msgInfo { get; set; }
            public CardStatusManagementTrxModelAppGateWay trxInfo { get; set; }
        }

        public class CardStatusManagementTrxModelAppGateWay
        {
            public string deviceID { get; set; }
            public string userID { get; set; }
            public string token { get; set; }
            public string tokenAction { get; set; }
        }

        // Make renew card application
        public class MakeCardApplicationRequestModel
        {
            public MsginfoModel msgInfo { get; set; }
            public MakeCardApplicationTrxModel trxInfo { get; set; }
        }

        public class MakeCardApplicationTrxModel
        {
            public string applicationID { get; set; }
            public string prdNo { get; set; }
            public string accountInfo { get; set; }
            // public CUSTINFO custInfo { get; set; }

        }

        public class AccountInfoModel
        {
            public string token { get; set; }
            public string pan { get; set; }

            public string accountNo { get; set; }
            public string firstName { get; set; }
            public string midName { get; set; }
            public string lastName { get; set; }
            public string accountStatus { get; set; }
            public int AccountTier { get; set; }
            public string countryCode { get; set; }
        }


        public class CUSTINFO
        {
            public string firstName { get; set; }
            public string midName { get; set; }
            public string lastName { get; set; }
            public string printName { get; set; }
            public string idType { get; set; }
            public string idNo { get; set; }
            public string idCountry { get; set; }
            public string mobileNo { get; set; }
            public string email { get; set; }
            public string postCode { get; set; }
            public string addrLine1 { get; set; }
            public string addrLine2 { get; set; }
            public string addrLine3 { get; set; }
        }

    }


