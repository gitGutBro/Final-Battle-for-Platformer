using Zenject;

public class PlayerPresentor
{
    private IPlayerView _playerView;

    public PlayerPresentor(IPlayerView playerView) => 
        _playerView = playerView;

    public void Debuging()
    {
        UnityEngine.Debug.Log($"_playerView: {_playerView}");
    }
}