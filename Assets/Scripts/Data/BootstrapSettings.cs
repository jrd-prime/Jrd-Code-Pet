using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Data
{
    [CreateAssetMenu(fileName = nameof(BootstrapSettings), menuName = "AppName/" + nameof(BootstrapSettings))]
    public class BootstrapSettings : SettingsBase
    {
        [field: SerializeField] public AssetReference FirstScene { get; private set; }

        private void OnValidate()
        {
            if (FirstScene == null) throw new Exception("FirstScene is null or invalid. " + name);
        }
    }
}
