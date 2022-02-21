using System;
using System.Collections.Generic;
using System.Text;

namespace RippleDotNet.Model.Transaction.Interfaces
{
    public interface INFTokenCreateOfferTransaction : ITransactionCommon
    {
        string Owner { get; set; }
        string TokenID { get; set; }
        uint? Expiration { get; set; }
        string Destination { get; set; }

    }
}
