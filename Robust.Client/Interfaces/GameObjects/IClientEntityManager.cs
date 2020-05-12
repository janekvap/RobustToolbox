﻿using Robust.Shared.GameObjects;
using Robust.Shared.Interfaces.GameObjects;
using System.Collections.Generic;

namespace Robust.Client.Interfaces.GameObjects
{
    public interface IClientEntityManager : IEntityManager
    {
        /// <returns>The list of new entities created.</returns>
        List<EntityUid> ApplyEntityStates(EntityState[] curEntStates, IEnumerable<EntityUid> deletions,
            EntityState[] nextEntStates);
    }
}
