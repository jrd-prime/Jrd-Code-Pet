﻿using System;
using Data;
using Infrastructure.Bootstrap;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public sealed class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private BootstrapSettings bootstrapSettings;

        public override void InstallBindings()
        {
            Debug.Log("<color=cyan>ProjectInstaller</color>");

            if (!bootstrapSettings)
                throw new NullReferenceException("bootstrapSettings is null.");

            Container.Bind<BootstrapSettings>().FromInstance(bootstrapSettings).AsSingle().NonLazy();

            Container.Bind<FirstSceneProvider>().AsSingle();
        }
    }
}
