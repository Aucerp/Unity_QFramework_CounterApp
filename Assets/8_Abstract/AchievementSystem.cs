using UnityEngine;
namespace QFramework.Example8
{
    public interface IAchievementSystem : ISystem { }
    public class AchievementSystem : AbstractSystem, IAchievementSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<ICounterModel>();

            model.Count.Register( count =>
            {
                if ( count == 10 )
                {
                    Debug.Log( "點擊達人成就達成" );
                }
                else if ( count == 20 ) 
                {
                    Debug.Log("點擊專家成就達成");
                }
                else if ( count == -10 )
                {
                    Debug.Log( "點擊菜鳥成就達成" );
                }
            } );
        }
    }
}
