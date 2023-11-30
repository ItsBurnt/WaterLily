using System.Collections.Generic;
using System.IO;

namespace WaterLily.Models.Entities;

public class DiscoverStatement : StatementBase
{
    public DiscoverStatement(FileInfo file) : base(file)
    {
    }

    public override List<Transaction> ParseTransactions()
    {
        Transactions = new List<Transaction>();
        throw new System.NotImplementedException();
    }
}