using System.Collections.Generic;
using System.IO;
using WaterLily.Models.Enums;
using WaterLily.Models.Interfaces;

namespace WaterLily.Models.Entities;

public abstract class StatementBase : IStatement
{
    protected StatementBase(FileInfo file)
    {
        File = file;
    }

    public FileInfo File { get; init; }

    public Organization Organization { get; protected set; }

    public List<Transaction> Transactions { get; protected set; }

    public void RenameParsedFile()
    {
        throw new System.NotImplementedException();
    }

    public void Archive()
    {
        throw new System.NotImplementedException();
    }

    public virtual Organization ParseOrganization()
    {
        Organization = Organization.Discover;
        throw new System.NotImplementedException();
    }

    public abstract List<Transaction> ParseTransactions();
}