using UnityEngine;

namespace 脚本
{
    public class 灯光测试 : MonoBehaviour
    {
        private Light myLight;

        void FixedUpdate()
        {
            myLight = GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                myLight.enabled = !myLight.enabled;
            }
        }
    }
    
}