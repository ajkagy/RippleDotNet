using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RippleDotNet.Json.Converters;

namespace RippleDotNet.Model.Ledger.Objects
{
    public class NFTokenPageLedgerObject : BaseRippleLedgerObject
    {
        public NFTokenPageLedgerObject()
        {
            LedgerEntryType = LedgerEntryType.NFTokenPage;
        }

        public string LedgerIndex { get; set; }

        public List<NonFungibleToken> NonFungibleTokens { get; set; }
    }

    public class NonFungibleToken
    {
        public string TokenID { get; set; }
        public string URI { get; set; }
    } 
}
