﻿namespace Zevopay.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BankAccount
    {
        public string ifsc { get; set; }
        public string bank_name { get; set; }
        public string name { get; set; }
        public List<object> notes { get; set; }
        public string account_number { get; set; }
    }

    public class Contact
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string reference_id { get; set; }
        public string batch_id { get; set; }
        public bool active { get; set; }
        public Notes notes { get; set; }
        public int created_at { get; set; }
    }

    public class Error
    {
        public string source { get; set; }
        public string reason { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public string step { get; set; }
        public Metadata metadata { get; set; }
    }

    public class FundAccount
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string contact_id { get; set; }
        public Contact contact { get; set; }
        public string account_type { get; set; }
        public BankAccount bank_account { get; set; }
        public Vpa vpa { get; set; }
        public string batch_id { get; set; }
        public bool active { get; set; }
        public int created_at { get; set; }
    }

    public class Metadata
    {
    }

    public class Notes
    {
        public string notes_key_1 { get; set; }
        public string notes_key_2 { get; set; }
    }


    public class PayoutsMoneyTransferRequestModel
    {
        public string account_number { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public string mode { get; set; }
        public string purpose { get; set; }
        public FundAccount fund_account { get; set; }
        public bool queue_if_low_balance { get; set; }
        public string reference_id { get; set; }
        public string narration { get; set; }
        public Notes notes { get; set; }
    }

    public class PayoutsMoneyTransferResponseModel
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string fund_account_id { get; set; }
        public FundAccount fund_account { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public Notes notes { get; set; }
        public int fees { get; set; }
        public int tax { get; set; }
        public string status { get; set; }
        public string purpose { get; set; }
        public string utr { get; set; }
        public string mode { get; set; }
        public string reference_id { get; set; }
        public string narration { get; set; }
        public string batch_id { get; set; }
        public string failure_reason { get; set; }
        public int created_at { get; set; }
        public string fee_type { get; set; }
        public StatusDetails status_details { get; set; }
        public string merchant_id { get; set; }
        public string status_details_id { get; set; }
        public Error error { get; set; }
    }

    public class StatusDetails
    {
        public string reason { get; set; }
        public string description { get; set; }
        public string source { get; set; }
    }

    public class UpiPayoutRequestModel
    {
        public string account_number { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public string mode { get; set; }
        public string purpose { get; set; }
        public FundAccount fund_account { get; set; }
        public bool queue_if_low_balance { get; set; }
        public string reference_id { get; set; }
        public string narration { get; set; }
        public Notes notes { get; set; }
    }

    public class UpiPayoutResponseModel
    {
        public string id { get; set; }
        public string entity { get; set; }
        public string fund_account_id { get; set; }
        public FundAccount fund_account { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public Notes notes { get; set; }
        public int fees { get; set; }
        public int tax { get; set; }
        public string status { get; set; }
        public string purpose { get; set; }
        public string utr { get; set; }
        public string mode { get; set; }
        public string reference_id { get; set; }
        public string narration { get; set; }
        public string batch_id { get; set; }
        public string failure_reason { get; set; }
        public int created_at { get; set; }
        public string fee_type { get; set; }
        public StatusDetails status_details { get; set; }
        public string merchant_id { get; set; }
        public string status_details_id { get; set; }
        public Error error { get; set; }
    }

    public class Vpa
    {
        public string username { get; set; }
        public string handle { get; set; }
        public string address { get; set; }
    }

}
