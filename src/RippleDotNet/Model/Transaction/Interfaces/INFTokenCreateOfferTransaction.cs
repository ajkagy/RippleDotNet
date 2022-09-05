using System;
using System.Collections.Generic;
using System.Text;

namespace RippleDotNet.Model.Transaction.Interfaces
{
    public interface INFTokenCreateOfferTransaction : ITransactionCommon
    {
        string Owner { get; set; }
        string NFTokenID { get; set; }
        uint? Expiration { get; set; }
        string Destination { get; set; }

    }
}
