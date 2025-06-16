using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVRGame
{
    public class GameMenuManager : MonoBehaviour
    {
        #region Variables
        public GameObject gameMenu;
        public InputActionProperty gameMenuButton;

        //카메라로부터 앞방향으로 2만큼 떨어지 곳에 보인다
        public Transform head;  //camera
        public float distance = 3f;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            //메뉴 버튼 클릭
            if (gameMenuButton.action.WasPressedThisFrame())
            {
                Toggle();
            }
        }
        #endregion

        #region Custom Method
        private void Toggle()
        {
            gameMenu.SetActive(!gameMenu.activeSelf);

            //UI가 보일 때 - 앞 방향으로 2만큼 떨어진 곳에 보인다
            if (gameMenu.activeSelf)
            {
                gameMenu.transform.position = head.position + new Vector3(head.forward.x, gameMenu.transform.position.y, head.forward.z).normalized *distance;
                gameMenu.transform.LookAt(new Vector3(head.position.x, gameMenu.transform.position.y, head.position.z));
                gameMenu.transform.forward *= -1;
            }
        }
        #endregion
    }

}
