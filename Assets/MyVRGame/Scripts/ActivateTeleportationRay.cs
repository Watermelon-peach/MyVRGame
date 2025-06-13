using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVRGame
{
    //텔레포트 인터랙터를 액티브 버튼을 누르면 보여지게 만든다
    public class ActivateTeleportationRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTeleportation;
        public GameObject rightTeleportation;

        //액티브 인풋값
        public InputActionProperty leftActivate;
        public InputActionProperty rightActivate;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            //인풋값 읽어오기
            float leftValue = leftActivate.action.ReadValue<float>();
            float rightValue = rightActivate.action.ReadValue<float>();

            //인풋값이 들어오면 활성화시킨다
            leftTeleportation.SetActive(leftValue > 0.1f);
            rightTeleportation.SetActive(rightValue > 0.1f);
        }
        #endregion
    }

}
