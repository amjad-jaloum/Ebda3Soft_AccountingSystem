using System;
using AccountingSystem_DataAccess;

public class clsSMSLog
{
    public int SmsLogId { get; private set; }
    public int AccountId { get; set; }
    public string Phone { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; private set; }

    public clsSMSLog()
    {
        this.SmsLogId = -1;
        this.AccountId = -1;
        this.Phone = "";
        this.Content = "";
        this.CreatedDate = DateTime.Now;
    }

    private bool _AddNewLog()
    {
        this.SmsLogId = clsSMSLogData.AddNewLog(this.AccountId, this.Phone, this.Content);
        return (this.SmsLogId != -1);
    }

    // Actual third-party gateway SMS logic (Simulation)
    private static bool _SendSMSToGateway(string phone, string message)
    {
        try
        {
            // Here you integrate with Telecommunication API / SMS Gateways

            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Sends a balance alert SMS to an account and logs the operation in the database.
    /// </summary>
    public static bool SendBalanceAlert(int accountId, string phone, decimal currentBalance)
    {
        // Compose the dynamic notification body
        string smsContent = $"عزيزي العميل، رصيد حسابك الحالي هو: {currentBalance:N2}. شكراً لتعاملك معنا.";

        // 1. Dispatch the SMS via the gateway API first
        if (_SendSMSToGateway(phone, smsContent))
        {
            // 2. If successfully sent, log it into the database for history tracking
            clsSMSLog log = new clsSMSLog
            {
                AccountId = accountId,
                Phone = phone,
                Content = smsContent
            };

            return log._AddNewLog();
        }

        return false;
    }
}