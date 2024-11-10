using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        print("PlayerInstaller installing.");

        Container.Bind<PlayerPresentor>().AsSingle();
    }
}