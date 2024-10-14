using UnityEngine;
using UnityEngine.UI;

namespace QFramework.Example1
{
    // Controller
    public class CounterAppController : MonoBehaviour
    {
        // View
        private Button mBtnAdd;
        private Button mBtnSub;
        private Text mCountText;

        // Model
        private int mCount = 0;

        void Start()
        {
            // View 组件获取
            mBtnAdd = transform.Find( "BtnAdd" ).GetComponent<Button>();
            mBtnSub = transform.Find( "BtnSub" ).GetComponent<Button>();
            mCountText = transform.Find( "CountText" ).GetComponent<Text>();


            // 监听输入
            mBtnAdd.onClick.AddListener( () =>
            {
                // 交互逻辑
                mCount++;
                // 表现逻辑
                UpdateView();
            } );

            mBtnSub.onClick.AddListener( () =>
            {
                // 交互逻辑
                mCount--;
                // 表现逻辑
                UpdateView();
            } );

            UpdateView();
        }

        void UpdateView()
        {
            mCountText.text = mCount.ToString();
        }
    }
}