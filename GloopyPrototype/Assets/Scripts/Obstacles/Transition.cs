using UnityEngine;

public class Transition : MonoBehaviour, ITriggerable
{
    public void Trigger(Player player)
    {
        if (player.State != PlayerState.NORMAL)
        {
            player.FallDown(player.transform);
            CrowdController.Instance.Players.Remove(player);
        }
    }
}
