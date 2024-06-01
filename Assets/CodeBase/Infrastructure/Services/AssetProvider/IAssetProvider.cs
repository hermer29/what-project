﻿using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace CodeBase.Infrastructure.Services.AssetProvider
{
    public interface IAssetProvider
    {
        UniTask InitializeAsset();
        UniTask<T> LoadAsync<T>(string address) where T : class;
        UniTask<T> LoadAsync<T>(AssetReference assetReference) where T : class;
        void Cleanup();
    }
}