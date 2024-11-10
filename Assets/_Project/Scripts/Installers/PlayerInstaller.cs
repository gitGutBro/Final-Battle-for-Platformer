using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        print("PlayerInstaller installing.");

        //TODO: Instantiate player prefab and bind to PlayerPresentor

        //Container.Bind<PlayerPresentor>().AsSingle();
        //Container.Bind<IPlayerView>().FromComponentInHierarchy().AsSingle();
    }
}