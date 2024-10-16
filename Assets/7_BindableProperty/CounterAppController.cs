using UnityEngine;
using UnityEngine.UI;

namespace QFramework.Example7
{
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
            // 交互逻辑
                this.SendCommand<IncreaseCountCommand>();
            } );

            mBtnSub.onClick.AddListener( () =>
            {
            // 交互逻辑
                this.SendCommand( new DecreaseCountCommand(/* 这里可以传参（如果有） */) );
            } );

            // 表现逻辑 model 使用 BindableProperty 後可以少用一個 Event，因為 model 可監聽
            mModel.Count.RegisterWithInitValue(count =>
            {
               UpdateView();

            } ).UnRegisterWhenGameObjectDestroyed( gameObject );

            //this.RegisterEvent<CountChangeEvent>( e =>
            //{
            //    UpdateView();

            //} ).UnRegisterWhenGameObjectDestroyed( gameObject );

            //UpdateView();
        }

        void UpdateView()
        {
            mCountText.text = mModel.Count.ToString();
        }

        // 3.
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
