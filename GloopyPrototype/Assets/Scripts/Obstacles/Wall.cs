using System.Collections;
using UnityEngine;

public class Wall : MonoBehaviour, ITriggerable
{
    public void Trigger(Player player)
    {
       StartCoroutine(DestroyPlayerWithDelay(player)); 
    }

    private IEnumerator DestroyPlayerWithDelay(Player player)
    {
        yield return new WaitForSeconds(1.25f);
        player.gameObject.SetActive(false);
        CrowdController.Instance.Players.Remove(player);
    }
}
