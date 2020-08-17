using UnityEngine;

public class ReducedTransition : MonoBehaviour, ITriggerable
{
    public void Trigger(Player player)
    {
        if (player.State != PlayerState.REDUCED)
        {
            player.FallDown(player.transform);
            CrowdController.Instance.Players.Remove(player);
        }
    }
}
