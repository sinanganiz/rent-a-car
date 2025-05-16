﻿namespace Core.Persistence.Repositories;

public interface IEntityTimeStamps
{
    DateTime CreatedDate { get; set; }
    DateTime? UpdatedDate { get; set; }
    DateTime? DeletedDate { get; set; }
}
