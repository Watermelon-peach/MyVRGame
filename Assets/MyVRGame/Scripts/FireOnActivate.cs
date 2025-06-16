using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVRGame
{
    public class FireOnActivate : MonoBehaviour
    {
        #region Variables
        public GameObject bulletPrefab;
        public Transform firePoint;
        public float speed = 20f;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            //Active 이벤트 등록
            XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
            grabInteractable.activated.AddListener(Fire);
        }
        #endregion

        #region Custom Method
        public void Fire(ActivateEventArgs args)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = firePoint.forward * speed;
            Destroy(bullet, 3f);
        }
        #endregion
    }

}
