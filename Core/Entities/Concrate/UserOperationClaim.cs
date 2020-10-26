using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrate
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
        public int OperationClaimId { get; set; }
    }
}
