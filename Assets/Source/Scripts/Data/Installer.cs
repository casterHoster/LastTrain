using LastTrain.Weapons.System;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ITransferDataProvider>().To<TransferDataProvider>().AsSingle();

        Container.Bind<WeaponsCreator>().FromComponentInHierarchy().AsSingle();
    }
}