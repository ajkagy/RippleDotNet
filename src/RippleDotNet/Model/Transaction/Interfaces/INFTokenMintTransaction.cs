using System;
using System.Collections.Generic;
using System.Text;

namespace RippleDotNet.Model.Transaction.Interfaces
{
    public interface INFTokenMintTransaction : ITransactionCommon
    {
        string Issuer { get; set; }
        uint TokenTaxon { get; set; }
        string URI { get; set; }
        uint? TransferFee { get; set; }

    }
}
