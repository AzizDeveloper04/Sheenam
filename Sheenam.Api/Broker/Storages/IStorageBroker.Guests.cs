//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//Free To Use Comfort and Peace
//=================================================

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Faundations.Guests;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace Sheenam.Api.Broker.Storages
{
    public partial interface IStorageBroker
    {
       ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
