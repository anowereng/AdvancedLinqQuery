using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EF_Practices.Models
{
    public enum PurchaseStates
    {
        All = 0,
        Created = 1,
        Accepted = 2,
        ReadyToShip = 3,
        ConfirmShip = 4,
        Shipped = 5,
        Received = 6,
        Canceled = 7
    }

    public enum SaleCommissionStates
    {
        Ordered = 0,
        Accepted = 1,
        Processing = 2,
        Sold = 3,
        Done = 4
    }

    public enum CommunicationTypes
    {
        PhoneCall = 0,
        Sms = 1,
        Email = 2,
        Inperson = 3
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionMedium
    {
        All = 0,
        Cash = 1,
        Card = 2,
        Cheque = 3,
        Mobile = 4,
        Other = 5,
        Bank = 6,
        Stock = 7
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionFor
    {
        All = 0,
        Sale = 1,
        Purchase = 2,
        Office = 3,
        Other = 4,
        StockTransfer = 5,
        MoneyTransfer = 6
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionWith
    {
        All = 0,
        Customer = 1,
        Supplier = 2,
        Employee = 3,
        Dealer = 4,
        Other = 5,
        Warehouse = 6
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WalletType
    {
        Cash = 1,
        Bank = 2,
        Mobile = 3,
        Goods = 4,
        Online = 5,
        Other = 6
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentGatewayService
    {
        Cash = 1,
        Bkash = 2,
        Rocket = 3,
        Mcash = 4,
        Ucash = 5,
        Mycash = 6,
        Easycash = 7,
        Condition = 8,
        Visa = 9,
        MasterCard = 10,
        AmericanExpress = 11,
        Online = 12,
        Cheque = 13,
        Flexi = 14,
        Other = 15,
        Stock = 16
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionFlowType
    {
        Income = 1,
        Expense = 2,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionState
    {
        Pending = 0,
        Approved = 1,
        Cancelled = 2
    }

    public enum AccountHeadType
    {
        Any = 0,
        Asset = 1,
        Liability = 2,
        Equity = 3,
        Expense = 4,
        Income = 5
    }

    public enum SaleChannel
    {
        All = 0,
        InHouse = 1,
        CashOnDelivery = 2,
        Courier = 3,
        Condition = 4,
        Other = 5
    }

    public enum SaleFrom
    {
        All = 0,
        BizBook365 = 1,
        Facebook = 2,
        Website = 3,
        PhoneCall = 4,
        MobileApp = 5,
        Referral = 6,
        Feedback = 7,
        Other = 8,
        Dealer = 9,
    }

    public enum OrderState
    {
        //All, //0
        Undefined = 0,
        Pending = 1,
        Created = 2, //2
        ReadyToDeparture = 3, //3
        OnTheWay = 4, // 4
        Delivered = 5, //5
        Completed = 6, //6
        Cancel = 7, // 7
    }

    public enum ReportTimeType
    {
        Daily = 0,
        Weekly = 1,
        Monthly = 2,
        Yearly = 3
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SaleDetailType
    {
        Sale = 1,
        Damage = 2,
        Gift = 3,
        Return = 4
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationType
    {
        Created = 1,
        Modified = 2,
    }

    public enum SaleReportType
    {
        SaleByAmount = 0,
        SaleByChannel = 1,
        SaleByOrderFrom = 2
    }


    public enum ProductReportType
    {
        ProductDetailHistory = 1,
        ProductDetailStockReport = 2
    }


    public enum AccountReportType
    {
        TransactionHistory = 1,
        TransactionDeatil = 2
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmsReceiverType
    {
        Unknown = 0,
        Customer = 1,
        Dealer = 2,
        User = 3,
        Supplier = 4
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmsReasonType
    {
        Unknown = 0,
        Sale = 1,
        Purchase = 2,
        Transaction = 3
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BizSmsHook
    {
        OrderPending = 1,
        OrderCreated = 2,
        OrderReadyToDepurture =3
    }

    public enum StockTransferState
    {
        Pending = 0,
        Approved = 1
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModelName
    {
        Sale = 1,
        Purchase = 2,
        Transaction = 3,
        SaleDetail = 4,
        PurchaseDetail = 5,
        Damage = 6,
        Return = 7
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeedbackType
    {
        Positive = 1,
        Negative = 2,
        Other =3
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarehouseType
    {
        Any = 0,
        Franchise = 1,
        Partnership = 2
    }
    public enum EarnRedeemType
    {
        Earn = 1,
        Redeem = 2
    }
}