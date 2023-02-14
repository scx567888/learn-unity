using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using 脚本;

namespace 脚本
{
    public class 自动销毁 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject,100f);        
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

