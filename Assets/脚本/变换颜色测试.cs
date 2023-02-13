using UnityEngine;

namespace 脚本
{
    public class 变换颜色测试 : MonoBehaviour
    {
        public Renderer _renderer;

        void FixedUpdate()
        {
            _renderer = GetComponent<Renderer>();
        }

        // Update is called once per frame
        void Update()
        {
            ChangeColor();
        }

        void ChangeColor()
        {
            //改变颜色
            if (Input.GetKeyDown(KeyCode.R))
            {
                _renderer.material.color = Color.red;
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                _renderer.material.color = Color.green;
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                _renderer.material.color = Color.blue;
            }
        }

       

    }
}