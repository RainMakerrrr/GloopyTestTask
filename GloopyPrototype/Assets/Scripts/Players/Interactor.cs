using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    private ITriggerable _triggerable;

    private void Update()
    {
        CheckForTrigger();
    }

    private void CheckForTrigger()
    {
        if (_triggerable != null)
            _triggerable.Trigger(gameObject.GetComponent<Player>());
    }

    private void OnTriggerEnter(Collider other)
    {
        ITriggerable triggerable = other.GetComponent<ITriggerable>();
        if (triggerable == null) return;
      
        _triggerable = triggerable;
    }

    private void OnTriggerExit(Collider other)
    {
        ITriggerable triggerable = other.GetComponent<ITriggerable>();
        if (_triggerable != triggerable) return;

        _triggerable = null;

       
    }
}
