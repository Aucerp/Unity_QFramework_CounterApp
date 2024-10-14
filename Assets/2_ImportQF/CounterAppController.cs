using UnityEngine;
using UnityEngine.UI;

namespace QFramework.Example2
{

    // 1. 定义一个 Model 对象
    public class CounterAppModel : AbstractModel
    {
        public int Count;

        protected override void OnInit()
        {
            Count = 0;
        }
    }


    // 2.定义一个架构（提供 MVC、分层、模块管理等）
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            // 注册 Model
            this.RegisterModel( new CounterAppModel() );
        }
    }

    // Controller
    public class CounterAppController : MonoBehaviour, IController /* 3.实现 IController 接口 */
    {
        // View
        private Button mBtnAdd;
        private Button mBtnSub;
        private Text mCountText;

        // 4. Model
        private CounterAppModel mModel;

        void Start()
        {
            // 5. 获取模型
            mModel = this.GetModel<CounterAppModel>();

            // View 组件获取
            mBtnAdd = transform.Find( "BtnAdd" ).GetComponent<Button>();
            mBtnSub = transform.Find( "BtnSub" ).GetComponent<Button>();
            mCountText = transform.Find( "CountText" ).GetComponent<Text>();


            // 监听输入
            mBtnAdd.onClick.AddListener( () =>
            {
                // 6. 交互逻辑
                mModel.Count++;
                // 表现逻辑
                UpdateView();
            } );

            mBtnSub.onClick.AddListener( () =>
            {
                // 7. 交互逻辑
                mModel.Count--;
                // 表现逻辑
                UpdateView();
            } );

            UpdateView();
        }

        void UpdateView()
        {
            mCountText.text = mModel.Count.ToString();
        }

        // 3.指定架构
        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }

        private void OnDestroy()
        {
            // 8. 将 Model 设置为空
            mModel = null;
        }
    }
}