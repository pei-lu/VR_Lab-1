using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public interface MyRayInteractable
{
    public string InteractionPrompt { get; set; }
    public bool Myrayinteract(XRRayInteractor interactor);
}
