using Unity.VisualScripting;
using UnityEngine;

namespace 脚本
{
    public class 胶囊人 : MonoBehaviour
    {
        public Rigidbody _rigidbody;
        public Transform _transform;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Transform>().transform.Rotate(Vector3.up * 10);
            // if (Input.GetMouseButton(0))
            {
                Rigidbody instantiate = Instantiate(_rigidbody, _transform.position, _transform.rotation);
                instantiate.GetComponent<Renderer>().material.color = RandomColor();
                instantiate.AddComponent<自动销毁>();
                instantiate.transform.localScale = RandomSize();
                instantiate.AddForce(_transform.right * 350f);
            }
        }

        private Color RandomColor()
        {
            //随机颜色的HSV值,饱和度不变，只改变H值
            //H、S、V三个值的范围都是在0~1之间
            float h = Random.Range(0f, 1f); //随机值
            float s = 0.9f; //设置饱和度为定值
            Color color = Color.HSVToRGB(h, s, 1);
            return color;
        }

        public static Vector3 RandomSize()
        {
            //随机颜色的HSV值,饱和度不变，只改变H值
            //H、S、V三个值的范围都是在0~1之间
            float h = Random.Range(0f, 0.3f); //随机值
            return new Vector3(h, h, h);
        }
    }
}