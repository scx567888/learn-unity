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
            Invoke(nameof(aaa),5f);
        }

        void aaa()
        {
            Destroy(gameObject);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

