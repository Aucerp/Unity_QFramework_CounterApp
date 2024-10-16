namespace QFramework.Example8
{
    // 2.定义一个架构（提供 MVC、分层、模块管理等）
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            // 注册 System
            this.RegisterSystem<IAchievementSystem>( new AchievementSystem() );

            // 注册 Model
            this.RegisterModel<ICounterModel>( new CounterAppModel() );

            // 注册存储工具的对象
            this.RegisterUtility<IStorage>( new Storage() );
        }
    }
}