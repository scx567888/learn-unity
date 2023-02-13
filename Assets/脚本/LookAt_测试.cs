using UnityEngine;

namespace 脚本
{
    public class LookAt_测试 : MonoBehaviour
    {

        public Transform target;
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(target);
        }
    
    }
}
