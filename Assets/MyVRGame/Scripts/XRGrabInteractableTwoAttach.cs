using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVRGame
{
    public class XRGrabInteractableTwoAttach : XRGrabInteractable
    {
        #region Variables
        public Transform leftAttachTransform;
        public Transform rightAttachTransform;
        #endregion

        #region Unity Event Method
        protected override void OnSelectEntering(SelectEnterEventArgs args)
        {
            //Attach Point 셋팅
            if (args.interactorObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = leftAttachTransform;
            }
            else if (args.interactableObject.transform.CompareTag("RightHand"))
            {
                attachTransform = rightAttachTransform;
            }
                base.OnSelectEntering(args);
        }
        #endregion
    }

}
