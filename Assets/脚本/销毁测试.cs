using UnityEngine;

namespace 脚本
{
    public class 销毁测试 : MonoBehaviour
    {
        void Update()
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Destroy(gameObject);
            }
        }
    }
}