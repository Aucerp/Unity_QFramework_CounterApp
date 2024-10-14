namespace QFramework.Example5_2
{
    // 2.定义一个架构（提供 MVC、分层、模块管理等）
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            // 注册 Model
            this.RegisterModel( new CounterAppModel() );

            // 注册存储工具的对象
            this.RegisterUtility( new Storage() );
        }
    }
}