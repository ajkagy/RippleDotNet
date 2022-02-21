using RippleDotNet.Model.Transaction.Interfaces;
using RippleDotNet.Responses.Transaction.Interfaces;

namespace RippleDotNet.Responses.Transaction.TransactionTypes
{
    public class NFTokenMintTransactionResponse : TransactionResponseCommon, INFTokenMintTransaction
    {
        public string Issuer { get; set; }
        public uint TokenTaxon { get; set; }
        public string URI { get; set; }
        public uint? TransferFee { get; set; }
    }
}
