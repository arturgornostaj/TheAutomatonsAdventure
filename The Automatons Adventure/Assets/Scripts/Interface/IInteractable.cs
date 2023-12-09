using UnityEngine;

public interface IInteractable
{

    public void GrabObject(Transform backpackPosition);

    public void DisposeObject(Transform backpackPosition, Vector3 force);

}
