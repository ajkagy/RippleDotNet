using System;
using System.Collections.Generic;
using System.Text;

namespace RippleDotNet.Model.Ledger.Objects
{
    public class NFTokenOfferLedgerObject : BaseRippleLedgerObject
    {
        public NFTokenOfferLedgerObject()
        {
            LedgerEntryType = LedgerEntryType.NFTokenOffer;
        }

        public string LedgerIndex { get; set; }

        public NewFieldsObj NewFields { get; set; }
    }

    public class NewFieldsObj
    {
        public string Destination { get; set; }
        public string Owner { get; set; }
        public uint Flags { get; set; }
        public string TokenID { get; set; }
    }
}
