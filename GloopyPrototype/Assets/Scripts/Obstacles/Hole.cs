using UnityEngine;

public class Hole : MonoBehaviour, ITriggerable
{
    public void Trigger(Player player)
    {
        player.FallDown(player.transform);
        CrowdController.Instance.Players.Remove(player);
    }
}
