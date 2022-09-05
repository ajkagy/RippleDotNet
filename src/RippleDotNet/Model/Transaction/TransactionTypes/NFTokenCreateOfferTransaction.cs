using System;
using System.Collections.Generic;
using System.Text;
using RippleDotNet.Model.Transaction.Interfaces;

namespace RippleDotNet.Model.Transaction.TransactionTypes
{
    public class NFTokenCreateOfferTransaction : TransactionCommon, INFTokenCreateOfferTransaction
    {
        public NFTokenCreateOfferTransaction()
        {
            TransactionType = TransactionType.NFTokenCreateOffer;
        }
        public new NFTokenCreateOfferFlags? Flags { get; set; }
        public string Owner { get; set; }
        public string NFTokenID { get; set; }
        public uint? Expiration { get; set; }
        public string Destination { get; set; }
    }
}
