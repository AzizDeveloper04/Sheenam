//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//Free To Use Comfort and Peace
//=================================================

using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Faundations.Guests;

namespace Sheenam.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet <Guest> Guests { get; set; }

    }
}
