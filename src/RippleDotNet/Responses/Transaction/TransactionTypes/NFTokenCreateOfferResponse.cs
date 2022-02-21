using RippleDotNet.Model.Transaction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RippleDotNet.Responses.Transaction.TransactionTypes
{
    public class NFTokenCreateOfferResponse : TransactionResponseCommon, INFTokenCreateOfferTransaction
    {
        public string Owner { get; set; }
        public string TokenID { get; set; }
        public uint? Expiration { get; set; }
        public string Destination { get; set; }
    }
}
