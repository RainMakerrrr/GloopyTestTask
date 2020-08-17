using UnityEngine;

public class FrozenObstacle : MonoBehaviour, ITriggerable
{
    [SerializeField] private float _scaleIncrementSpeed = 4f;

    public void Trigger(Player player)
    {
       player.transform.localScale = Vector3.Lerp(player.transform.localScale, new Vector3(2f, 2f, 2f), _scaleIncrementSpeed);
       player.State = PlayerState.NORMAL;
    }
}
