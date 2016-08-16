﻿using UnityDataKeepersCore.Core.DataLayer.Model;

namespace UnityDataKeepersCore.Core.DataLayer.DataCollectionDrivers
{
    public interface IStoredCollectionDriver<TItem> : IDataCollectionDriver<TItem>
        where TItem : class, IDataItem
    {
        bool Save();
    }
}