using UnityEngine;

public class FireObstacle : MonoBehaviour, ITriggerable
{
    [SerializeField] private float _scaleDecrementSpeed = 4f;
   
    public void Trigger(Player player)
    {
        player.transform.localScale = Vector3.Lerp(player.transform.localScale, new Vector3(1f, 1f, 1f), _scaleDecrementSpeed * Time.fixedDeltaTime);
        player.State = PlayerState.REDUCED;
    }
    
}
