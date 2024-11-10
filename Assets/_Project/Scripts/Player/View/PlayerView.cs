using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerView : MonoBehaviour, IPlayerView
{
    private Rigidbody2D _rigidbody;
    private PlayerPresentor _presentor;

    private void Awake() => 
        _rigidbody = GetComponent<Rigidbody2D>();

    [Inject]
    public void Construct(PlayerPresentor presentor) => 
        _presentor = presentor;

    private void Update()
    {
        Debug.Log($"_presentor: {_presentor}");

        _presentor.Debuging();
    }
}